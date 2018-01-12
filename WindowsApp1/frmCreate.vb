﻿Imports System.Threading
Imports System.Net.Sockets
Imports System.Net



Public Class frmCreate

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

    Private Sub frmCreate_Loaded(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim host As String = System.Net.Dns.GetHostName()
        ip = System.Net.Dns.GetHostByName(host).AddressList(0).ToString()
        ipAddress = Dns.GetHostByName(host).AddressList(0)
        otherPlayersTop = objPlayer2.Top
        MsgBox("Give this Ip to your friend " + ip)
        connectionThread = New Thread(AddressOf connect)
        connectionThread.Start()
        ballXVelocity = -2
        ballYVelocity = 1


    End Sub
    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub frmCreate_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And objBall.Bounds.IntersectsWith(objPlayer1.Bounds) Then
            ballYVelocity = (ballYVelocity * 2) * -1
            xSpeedMultPlayer1 += 1
        End If
        If e.KeyCode = Keys.Down And Not (objPlayer1.Top > Me.MaximumSize.Height - 130) Then
            objPlayer1.Top += 15
        ElseIf e.KeyCode = Keys.Up And Not (objPlayer1.Top < 10) Then
            objPlayer1.Top -= 15
        End If
    End Sub

    Private Sub sendPosition()
        bw.Write("P")
        bw.Write(objPlayer1.Top)
        bw.Write("BT")
        bw.Write(objBall.Top)
        bw.Write("BL")
        bw.Write(objBall.Left)
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
            objPlayer1.SetBounds(objPlayer1.Left, objPlayer1.Top, 15, 69)
            objPlayer2.SetBounds(objPlayer2.Left, otherPlayersTop, 15, 69)
            If ballSpeedCounter > 500 Then
                objBall.SetBounds(objBall.Left + ballXVelocity, objBall.Top + ballYVelocity, 13, 14)
                ballSpeedCounter = 0
            End If
            If objBall.Bounds.IntersectsWith(objPlayer2.Bounds) Then
                ballXVelocity = -2 * xSpeedMultPlayer2
            End If
            If objBall.Bounds.IntersectsWith(objPlayer1.Bounds) Then
                ballXVelocity = 2 * xSpeedMultPlayer1
            End If
            If objBall.Left > playGround.Bounds.Width - 30 Or objBall.Left < 0 Then
                If objBall.Left > playGround.Bounds.Width - 30 Then
                    player1Points += 1
                    bw.Write("I")
                    updatePointsUI()
                    resetPosition()
                    btnReady.Visible = True
                    pause = True
                    pauseAndWaitForReady()
                Else
                    bw.Write("U")
                    player2Points += 1
                    updatePointsUI()
                    resetPosition()
                    btnReady.Visible = True
                    pause = True
                    pauseAndWaitForReady()
                End If

            End If
            If objBall.Top > playGround.Bounds.Height - 50 Or objBall.Top < 0 Then
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
    End Sub
    Private Sub pauseAndWaitForReady()
        Do While pause = True Or btnReady.Visible = True

        Loop
    End Sub
    Private Sub connect()

        Dim listener As New TcpListener(ipAddress, 49552)
        listener.Start()
        connection = listener.AcceptTcpClient()
        bw = New IO.BinaryWriter(connection.GetStream())
        br = New IO.BinaryReader(connection.GetStream())
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
    End Sub
End Class