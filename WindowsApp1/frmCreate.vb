Imports System.Threading
Imports System.Net.Sockets
Imports System.Net



Public Class ObjPwr1

    Dim connection As TcpClient
    Dim bw As IO.BinaryWriter
    Dim br As IO.BinaryReader
    Dim ipAddress As IPAddress
    Dim ip As String
    Private connectionThread As Thread
    Private render As Thread
    Private receivingData As Thread
    Dim otherPlayersTop As Integer
    Dim ballXVelocity As Integer
    Dim ballYVelocity As Integer
    Dim ballSpeedCounter As Integer = 0
    Dim xSpeedMultPlayer1 As Integer = 1
    Dim xSpeedMultPlayer2 As Integer = 1
    Dim player1Points As Integer = 0
    Dim player2Points As Integer = 0
    Dim pause As Boolean = True
    Dim player1PowerBar, player2PowerBar As Integer
    Dim toggleCounter As Integer


    Private Sub frmCreate_Loaded(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim host As String = System.Net.Dns.GetHostName()
        ip = System.Net.Dns.GetHostByName(host).AddressList(0).ToString()
        ipAddress = Dns.GetHostByName(host).AddressList(0)
        otherPlayersTop = objPlayer2.Top
        Me.BackColor = Color.Green
        MsgBox("Give this Ip to your 'friend' " + ip)
        connectionThread = New Thread(AddressOf connect)
        connectionThread.Start()
        ballXVelocity = -2
        ballYVelocity = 1
        player1PowerBar = 0
        player2PowerBar = 0


    End Sub
    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub frmCreate_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And objBall.Bounds.IntersectsWith(objPlayer1.Bounds) Then
            ballYVelocity = (ballYVelocity * 2) * -1
            xSpeedMultPlayer1 += 1
        End If
        If e.KeyCode = Keys.Down And Not (objPlayer1.Top > 425) Then
            objPlayer1.Top += 15
        ElseIf e.KeyCode = Keys.Up And Not (objPlayer1.Top < 25) Then
            objPlayer1.Top -= 15
        End If
    End Sub

    Private Sub sendPosition()
        Try

            bw.Write("P")
            bw.Write(objPlayer1.Top)
            bw.Write("BT")
            bw.Write(objBall.Top)
            bw.Write("BL")
            bw.Write(objBall.Left)
        Catch ex As Exception
            MsgBox("The other guy left!")
        End Try
    End Sub
    Private Sub receivePosition()
        Dim message As String
        Do While True
            message = br.ReadString()
            If message = "P" Then
                otherPlayersTop = br.ReadUInt16
            ElseIf message = "H" And objBall.Bounds.IntersectsWith(objPlayer2.Bounds) Then
                ballYVelocity = (ballYVelocity * 2) * -1
                xSpeedMultPlayer2 += 1
            ElseIf message = "GO" Then
                pause = False
            End If
        Loop
    End Sub
    Private Sub renderG()
        Do While True
            toggleCounter += 1
            If (player1PowerBar >= 10 And toggleCounter > 10000) Then
                toggleBackground()
                toggleCounter = 0
            End If
            If player1PowerBar < 10 Then
                Me.BackColor = Color.Green
            End If
            objPlayer1.SetBounds(objPlayer1.Left, objPlayer1.Top, 15, 69)
            objPlayer2.SetBounds(objPlayer2.Left, otherPlayersTop, 15, 69)
            If objBall.Bounds.IntersectsWith(objPlayer2.Bounds) Then
                ballXVelocity = -2 * xSpeedMultPlayer2
                If ballSpeedCounter > 500 Then
                    addPower(False)
                End If


            End If
            If objBall.Bounds.IntersectsWith(objPlayer1.Bounds) Then
                ballXVelocity = 2 * xSpeedMultPlayer1
                If ballSpeedCounter > 500 Then
                    addPower(True)
                End If
            End If
            If ballSpeedCounter > 500 Then
                objBall.SetBounds(objBall.Left + ballXVelocity, objBall.Top + ballYVelocity, 13, 14)
                ballSpeedCounter = 0
            End If

            If objBall.Left > objPlayer2.Left Or objBall.Left < objPlayer1.Left Then
                If objBall.Left > objPlayer2.Left Then
                    player1Points += 1
                    Try

                        bw.Write("I")
                    Catch ex As Exception
                        MsgBox("The other guy left!")
                    End Try
                    updatePointsUI()
                    resetPosition()
                    btnReady.Visible = True
                    pause = True
                    pauseAndWaitForReady()
                Else
                    Try

                        bw.Write("U")
                    Catch ex As Exception
                        MsgBox("The other guy left!")
                    End Try
                    player2Points += 1
                    updatePointsUI()
                    resetPosition()
                    btnReady.Visible = True
                    pause = True
                    pauseAndWaitForReady()
                End If

            End If
            If objBall.Top > playGround.Bounds.Height - 20 Or objBall.Top < 10 Then
                ballYVelocity = ballYVelocity * -1
            End If
            ballSpeedCounter += 1
            sendPosition()
        Loop
    End Sub
    Private Sub updatePointsUI()
        lblPlayer1Score.Text = player1Points
        lblPlayer2Score.text = player2Points
    End Sub
    Private Sub resetPosition()
        objPlayer2.SetBounds(742, 201, 15, 69)
        objPlayer1.SetBounds(6, 201, 15, 69)
        objBall.SetBounds(367, 230, 13, 14)
        Dim rand As Integer = Math.Ceiling(Rnd() * 2)
        If rand = 1 Then
            ballYVelocity = -1
            ballXVelocity = 1
        Else
            ballYVelocity = 1
            ballXVelocity = -1
        End If
        xSpeedMultPlayer1 = 1
        xSpeedMultPlayer2 = 1
    End Sub
    Private Sub pauseAndWaitForReady()
        Do While pause = True Or btnReady.Visible = True
        Loop
    End Sub

    Private Sub addPower(isPlayerOne As Boolean)

        If player1PowerBar >= 10 And isPlayerOne Then
            xSpeedMultPlayer1 += 1
            ballYVelocity = (ballYVelocity * 2) * -1
            player1PowerBar = 0
        ElseIf player2PowerBar >= 10 And Not isPlayerOne Then
            xSpeedMultPlayer2 += 1
            ballYVelocity = (ballYVelocity * 2) * -1
            player2PowerBar = 0
            Try

                bw.Write("XO")
            Catch ex As Exception
                MsgBox("The other guy left!")
            End Try
        End If

        Dim toAdd, midPoint As Integer

        If isPlayerOne And player1PowerBar < 10 Then
            midPoint = (objPlayer1.Top + 34)
            toAdd = IIf(objBall.Top + 5 < midPoint + 10 And objBall.Top + 5 > midPoint - 10, 2, 1)
            player1PowerBar += toAdd
        ElseIf Not (isPlayerOne) And player2PowerBar < 10 Then
            midPoint = (objPlayer2.Top + 34)
            toAdd = IIf(objBall.Top + 5 < midPoint + 10 And objBall.Top + 5 > midPoint - 10, 2, 1)
            player2PowerBar += toAdd
        End If

        If player2PowerBar >= 10 Then
            Try

                bw.Write("X")
            Catch ex As Exception
                MsgBox("The other guy left!")
            End Try
        End If

    End Sub
    Private Sub toggleBackground()
        If Me.BackColor = Color.Green Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Green
        End If
    End Sub
    Private Sub connect()

        Dim listener As New TcpListener(ipAddress, 49552)
        listener.Start()
        MsgBox("Don't press the ready button until prompted!")
        connection = listener.AcceptTcpClient()
        bw = New IO.BinaryWriter(connection.GetStream())
        br = New IO.BinaryReader(connection.GetStream())
        MsgBox("Ok ready up your friend has joined!")
        receivingData = New Thread(AddressOf receivePosition)
        receivingData.Start()
        bw.Write("HI")
        pauseAndWaitForReady()
        render = New Thread(AddressOf renderG)
        render.Start()
    End Sub

    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        bw.Write("GO")
        btnReady.Visible = False
        MyBase.Focus()
    End Sub

    Private Sub XTREME_Tick(sender As Object, e As EventArgs) Handles XTREME.Tick
        If Me.BackColor = Color.Green Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Green
        End If
    End Sub

    
End Class