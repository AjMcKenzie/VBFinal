Public Class LevelSelect

    Private Sub btnBackMainMenu_Click(sender As Object, e As EventArgs) Handles btnBackMainMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub

    Private Sub PictureBox28_Click(sender As Object, e As EventArgs) Handles PictureBox28.Click
        Dim Box = New Level1
        Box.Show()
        Me.Close()
    End Sub
End Class