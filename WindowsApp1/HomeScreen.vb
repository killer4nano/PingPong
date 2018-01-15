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

        txtRules.Text = "Use the UP and DOWN arrows to move your paddle" & vbCrLf & vbCrLf
        txtRules.Text += "Use Spacebar for a chance to speed up your shot" & vbCrLf & vbCrLf
        txtRules.Text += "HOST = Red Paddle" & vbCrLf
        txtRules.Text += "GUEST = Black Paddle" & vbCrLf & vbCrLf
        txtRules.Text += "Hitting the ball closer to the center of the paddle charges up your POWER METER" & vbCrLf & vbCrLf
        txtRules.Text += "Charge up your power meter for a POWER SHOT" & vbCrLf & vbCrLf
        txtRules.Text += "Play PONG to the ExXxtreme!!!"

    End Sub

    Private Sub btnCntrls_Click(sender As Object, e As EventArgs) Handles btnCntrls.MouseDown
        btnRules2.Show()
        txtRules.Show()
    End Sub


    Private Sub btnRules2_Click(sender As Object, e As EventArgs) Handles btnRules2.MouseDown
        txtRules.Hide()
        btnRules2.Hide()
    End Sub

    Private Sub btnRules2_Click_1(sender As Object, e As EventArgs) Handles btnRules2.Click

    End Sub

    Private Sub btnCntrls_Click_1(sender As Object, e As EventArgs) Handles btnCntrls.Click

    End Sub

    Private Sub txtRules_TextChanged(sender As Object, e As EventArgs) Handles txtRules.TextChanged

    End Sub
End Class
