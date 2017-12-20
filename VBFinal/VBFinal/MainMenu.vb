Public Class MainMenu

    Dim second As Integer

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        Timer1.Interval = 1000
        Timer1.Start() 'Timer starts functioning
    End Sub

    Private Sub Timer1_Tick(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Timer1.Tick

        picLogo.Visible = False
        lblLogoName.Visible = False

        second = second + 1
        If second >= 2 Then
            btnStart.Visible = True
            btnExitM.Visible = True
            btnShopM.Visible = True
        End If
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExitM.Click
        Me.Close()
    End Sub

    Private Sub btnStart_Click(sender As Object, e As EventArgs) Handles btnStart.Click
        Dim Box = New LevelSelect
        Box.Show()
        Me.Visible = False
    End Sub

    Private Sub btnShopM_Click(sender As Object, e As EventArgs) Handles btnShopM.Click
        Dim Box = New Shop
        Box.Show()
        Me.Visible = False
    End Sub
End Class
