Imports System.Threading
Imports System.Net.Sockets
Imports System.Net

Public Class frmJoin
    Dim connection As TcpClient
    Dim bw As IO.BinaryWriter
    Dim br As IO.BinaryReader
    Private receivingData As Thread
    Private render As Thread
    Dim ballXVelocity As Integer
    Dim ballVelocity As Integer
    Dim otherPlayersTop As Integer
    Dim player1Points As Integer = 0
    Dim player2Points As Integer = 0
    Dim pause As Boolean = True
    Dim currentPowerUp As Integer

    Private Sub frmJoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Dim hostIp As String
        hostIp = InputBox("What is the host IP?", "Connection", "")
        connection = New TcpClient
        connection.Connect(hostIp, 49552)
        bw = New IO.BinaryWriter(connection.GetStream())
        br = New IO.BinaryReader(connection.GetStream())
        otherPlayersTop = objPlayer1.Top
        receivingData = New Thread(AddressOf receivePosition)
        receivingData.Start()
    End Sub
    Private Sub frmJoin_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Space And objBall.Bounds.IntersectsWith(objPlayer2.Bounds) Then
            bw.Write("H")
        End If
        If e.KeyCode = Keys.Down And Not (objPlayer2.Top > 425) Then
            objPlayer2.Top += 15
        ElseIf e.KeyCode = Keys.Up And Not (objPlayer2.Top < 25) Then
            objPlayer2.Top -= 15
        End If
        sendPosition()
    End Sub
    Private Sub sendPosition()
        bw.Write("P")
        bw.Write(objPlayer2.Top)
    End Sub
    Private Sub receivePosition()
        Dim message As String
        Do While True
            message = br.ReadString()
            If message = "P" Then
                otherPlayersTop = br.ReadUInt16
            ElseIf message = "BT" Then
                objBall.Top = br.ReadUInt16
            ElseIf message = "BL" Then
                objBall.Left = br.ReadUInt16
            ElseIf message = "I" Or message = "U" Then
                btnReady.Visible = True
                render.Abort()
                resetPosition()
                If message = "I" Then
                    player1Points += 1
                Else
                    player2Points += 1
                End If
                updatePointsUI()
                pauseAndWaitForReady()
            ElseIf message = "HI" Then
                pauseAndWaitForReady()
            End If
        Loop
    End Sub

    Private Sub renderG()
        Do While True
            objPlayer1.SetBounds(objPlayer1.Left, otherPlayersTop, 15, 69)
            objPlayer2.SetBounds(objPlayer2.Left, objPlayer2.Top, 15, 69)
            objBall.SetBounds(objBall.Left, objBall.Top, 13, 14)
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
        Dim message As String
        Do While Not (message = "GO")
            message = br.ReadString
        Loop
        Do While btnReady.Visible = True

        Loop
        render = New Thread(AddressOf renderG)
        render.Start()
    End Sub

    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        btnReady.Visible = False
        bw.Write("GO")
        MyBase.Focus()
    End Sub


End Class