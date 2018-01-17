Public Class HomeScreen
    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        frmJoin.Show()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        ObjPwr1.Show()
        My.Computer.Audio.Stop()
    End Sub

    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources._8_Bit_Mayhem_1_, AudioPlayMode.BackgroundLoop)

        txtRules.Hide()
        btnRules2.Hide()


        txtRules.Text = "CREATE a game. Have your opponent JOIN your game" & vbCrLf & vbCrLf
        txtRules.Text += "Use the UP and DOWN arrows to move your PADDLE" & vbCrLf & vbCrLf
        txtRules.Text += "Use SPACEBAR for a chance to speed up your shot" & vbCrLf & vbCrLf
        txtRules.Text += "HOST = BLUE" & vbCrLf
        txtRules.Text += "GUEST = BLACK" & vbCrLf & vbCrLf
        txtRules.Text += "Hitting the ball closer to the center of the paddle charges up your POWER METER" & vbCrLf & vbCrLf
        txtRules.Text += "Your SCREEN will flicker when your POWER SHOT is ready"

        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 0
            txtRules.SelectionLength = 6
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 34
            txtRules.SelectionLength = 4
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 58
            txtRules.SelectionLength = 2
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 65
            txtRules.SelectionLength = 4
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 90
            txtRules.SelectionLength = 6
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 102
            txtRules.SelectionLength = 8
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 147
            txtRules.SelectionLength = 4
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 154
            txtRules.SelectionLength = 4
            txtRules.SelectionColor = Color.MediumBlue
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 159
            txtRules.SelectionLength = 5
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 167
            txtRules.SelectionLength = 5
            txtRules.SelectionColor = Color.Black
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 242
            txtRules.SelectionLength = 11
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 260
            txtRules.SelectionLength = 6
            txtRules.SelectionColor = Color.Red
        End With
        With txtRules
            txtRules.Focus()
            txtRules.SelectionStart = 290
            txtRules.SelectionLength = 11
            txtRules.SelectionColor = Color.Red
        End With


    End Sub
    
    Private Sub btnCntrls_Click(sender As Object, e As EventArgs) Handles btnCntrls.MouseDown
        btnRules2.Show()
        txtRules.Show()
    End Sub


    Private Sub btnRules2_Click(sender As Object, e As EventArgs) Handles btnRules2.MouseDown
        txtRules.Hide()
        btnRules2.Hide()
    End Sub
End Class
