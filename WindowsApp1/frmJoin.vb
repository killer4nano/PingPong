Imports System.Threading
Imports System.Net.Sockets
Imports System.Net

Public Class frmJoin
    Dim connection As TcpClient
    Dim bw As IO.BinaryWriter
    Dim br As IO.BinaryReader
    Private sendingData As Thread
    Private receivingData As Thread
    Private render As Thread
    Dim ballXVelocity As Integer
    Dim ballVelocity As Integer
    Dim otherPlayersTop As Integer
    Private Sub frmJoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
        Dim hostIp As String
        hostIp = InputBox("What is the host IP?", "Connection", "")
        lblIp.Text = "Host IP : " + hostIp
        connection = New TcpClient
        connection.Connect(hostIp, 49552)
        bw = New IO.BinaryWriter(connection.GetStream())
        br = New IO.BinaryReader(connection.GetStream())
        otherPlayersTop = objPlayer1.Top
        render = New Thread(AddressOf renderG)
        render.Start()
        sendingData = New Thread(AddressOf sendPosition)
        receivingData = New Thread(AddressOf receivePosition)
        sendingData.Start()
        receivingData.Start()
    End Sub
    Private Sub frmJoin_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Down And Not (objPlayer2.Top > Me.MaximumSize.Height - 130) Then
            objPlayer2.Top += 15
        ElseIf e.KeyCode = Keys.Up And Not (objPlayer2.Top < 10) Then
            objPlayer2.Top -= 15
        End If
    End Sub
    Private Sub sendPosition()
        Do While True
            bw.Write("P")
            bw.Write(objPlayer2.Top)
        Loop
    End Sub
    Private Sub receivePosition()
        Dim message As String
        Do While True
            message = br.ReadString()
            If message = "P" Then
                otherPlayersTop = br.ReadUInt16
            End If
        Loop
    End Sub

    Private Sub renderG()
        Do While True
            objPlayer1.SetBounds(objPlayer1.Left, otherPlayersTop, 15, 69)
            objPlayer2.SetBounds(objPlayer2.Left, objPlayer2.Top, 15, 69)
        Loop
    End Sub

    Private Sub frmJoin_Loaded(sender As Object, e As EventArgs) Handles MyBase.Shown

    End Sub

End Class