Public Class pageWelcome
    Private Sub btnLoadObjectDemo_Click(sender As Object, e As EventArgs) Handles btnLoadObjectDemo.Click
        Me.Hide()
        Dim pageObjectDemonstrations As New pageObjectDemonstrations
        pageObjectDemonstrations.StartPosition = FormStartPosition.Manual
        pageObjectDemonstrations.DesktopLocation = Me.DesktopLocation
        pageObjectDemonstrations.Show()

    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click

        Dim msgClose As MsgBoxResult
        msgClose = MsgBox("Do you really want to exit?", MsgBoxStyle.YesNo)

        If msgClose = MsgBoxResult.Yes Then
            Application.Exit()
        End If

    End Sub

    Private Sub pageWelcome_Click(sender As Object, e As EventArgs) Handles MyBase.Click
        Me.WindowState = FormWindowState.Maximized
        Me.BackColor = Color.FromArgb(255, 0, 0)
    End Sub
End Class
