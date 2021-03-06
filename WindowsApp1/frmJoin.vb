﻿Imports System.Threading
Imports System.Net.Sockets
Imports System.Net

Public Class frmJoin
    'Variable Decleration
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
    Dim toggleCounter As Integer
    Dim currentPowerUp As Integer
    Dim flicker As Boolean = False
    'Loading form
    Private Sub frmJoin_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Green
        'Making sure threads can make changes to form
        Control.CheckForIllegalCrossThreadCalls = False
        Dim hostIp As String
        'requesting host ip
        hostIp = InputBox("What is the host IP?", "Connection", "")
        connection = New TcpClient
        connection.Connect(hostIp, 49552)
        'connection success
        'setting up writing and reading of stream
        bw = New IO.BinaryWriter(connection.GetStream())
        br = New IO.BinaryReader(connection.GetStream())
        otherPlayersTop = objPlayer1.Top
        receivingData = New Thread(AddressOf receivePosition)
        receivingData.Start()
    End Sub

    Private Sub frmJoin_KeyPress(sender As Object, e As KeyEventArgs) Handles MyBase.KeyDown
        'Key  presses and updating host about button presses.
        If e.KeyCode = Keys.Space And objBall.Bounds.IntersectsWith(objPlayer2.Bounds) Then
            Try

                bw.Write("H")
            Catch ex As Exception
                MsgBox("The other guy left!")
            End Try
        End If
        If e.KeyCode = Keys.Down And Not (objPlayer2.Top > 425) Then
            objPlayer2.Top += 15
        ElseIf e.KeyCode = Keys.Up And Not (objPlayer2.Top < 25) Then
            objPlayer2.Top -= 15
        End If
        sendPosition()
    End Sub
    Private Sub sendPosition()
        'sending the position of your paddle to the host
        Try

            bw.Write("P")
            bw.Write(objPlayer2.Top)
        Catch ex As Exception
            MsgBox("The other guy left!")
        End Try
    End Sub
    Private Sub receivePosition()
        'receiving points and updates from host
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
            ElseIf message = "X" Then
                flicker = True
            ElseIf message = "XO" Then
                flicker = False
                Me.BackColor = Color.Green
            End If
        Loop
    End Sub

    Private Sub renderG()
        'much simpler render thread
        Do While True
            toggleCounter += 1
            'flicker incase the power up is available  with larger buffer because the loop has alot less to do
            If (flicker And toggleCounter > 5000000) Then
                toggleBackground()
                toggleCounter = 0
            End If
            If flicker = False Then
                Me.BackColor = Color.Green
            End If
            objPlayer1.SetBounds(objPlayer1.Left, otherPlayersTop, 15, 69)
            objPlayer2.SetBounds(objPlayer2.Left, objPlayer2.Top, 15, 69)
            objBall.SetBounds(objBall.Left, objBall.Top, 13, 14)
        Loop
    End Sub
    Private Sub updatePointsUI()
        'updating points
        lblPlayer1Score.Text = player1Points
        lblPlayer2Score.Text = player2Points
    End Sub
    Private Sub resetPosition()
        'resetting paddle positions after points.
        objPlayer2.SetBounds(742, 201, 15, 69)
        objPlayer1.SetBounds(6, 201, 15, 69)
        objBall.SetBounds(367, 230, 13, 14)
    End Sub
    Private Sub pauseAndWaitForReady()
        'waiting till the other player and you are ready to start
        Dim message As String
        Do While Not (message = "GO")
            message = br.ReadString
        Loop
        Do While btnReady.Visible = True

        Loop
        render = New Thread(AddressOf renderG)
        render.Start()
    End Sub
    Private Sub toggleBackground()
        'make the screen flicker incase of power up
        If Me.BackColor = Color.Green Then
            Me.BackColor = Color.Red
        Else
            Me.BackColor = Color.Green
        End If
    End Sub

    Private Sub btnReady_Click(sender As Object, e As EventArgs) Handles btnReady.Click
        'inform player 1 of player 2 being ready
        btnReady.Visible = False
        bw.Write("GO")
        MyBase.Focus()
    End Sub

End Class