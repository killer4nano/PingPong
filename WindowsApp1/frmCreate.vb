Imports System.Threading
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
    Private sendingData As Thread
    Private receivingData As Thread
    Dim otherPlayersTop As Integer
    Private Sub frmCreate_Loaded(sender As Object, e As EventArgs) Handles MyBase.Shown

        Dim host As String = System.Net.Dns.GetHostName()
        ip = System.Net.Dns.GetHostByName(host).AddressList(0).ToString()
        otherPlayersTop = objPlayer2.Top
        MsgBox("Give this Ip to your friend " + ip)
        connectionThread = New Thread(AddressOf connect)
        connectionThread.Start()
        render = New Thread(AddressOf renderG)
        render.Start()

    End Sub
    Private Sub frmCreate_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Control.CheckForIllegalCrossThreadCalls = False
    End Sub
    Private Sub frmCreate_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        If e.KeyCode = Keys.Down And Not (objPlayer1.Top > Me.MaximumSize.Height - 130) Then
            objPlayer1.Top += 15
        ElseIf e.KeyCode = Keys.Up And Not (objPlayer1.Top < 10) Then
            objPlayer1.Top -= 15
        End If
    End Sub

    Private Sub sendPosition()
        Do While True
            bw.Write("P")
            bw.Write(objPlayer1.Top)
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
            objPlayer1.SetBounds(objPlayer1.Left, objPlayer1.Top, 15, 69)
            objPlayer2.SetBounds(objPlayer2.Left, otherPlayersTop, 15, 69)
        Loop
    End Sub
    Private Sub connect()
        ipAddress = Dns.GetHostEntry(ip).AddressList(0)
        Dim listener As New TcpListener(ipAddress, 49552)
        listener.Start()
        connection = listener.AcceptTcpClient()
        bw = New IO.BinaryWriter(connection.GetStream())
        br = New IO.BinaryReader(connection.GetStream())
        sendingData = New Thread(AddressOf sendPosition)
        receivingData = New Thread(AddressOf receivePosition)
        sendingData.Start()
        receivingData.Start()
    End Sub


End Class