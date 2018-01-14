Public Class HomeScreen
    Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
        frmJoin.Show()
    End Sub

    Private Sub btnCreate_Click(sender As Object, e As EventArgs) Handles btnCreate.Click
        frmCreate.show()
    End Sub

    Private Sub HomeScreen_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        My.Computer.Audio.Play(My.Resources._8_Bit_Mayhem_1_, AudioPlayMode.BackgroundLoop)
    End Sub
End Class
