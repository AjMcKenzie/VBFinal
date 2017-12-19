Public Class LevelSelect

    Private Sub btnBackMainMenu_Click(sender As Object, e As EventArgs) Handles btnBackMainMenu.Click
        Me.Close()
        MainMenu.Visible = True
    End Sub
End Class