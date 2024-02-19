Public Class pageObjectDemonstrations
    Private Sub btnExitToWelcomePage_Click(sender As Object, e As EventArgs) Handles btnExitToWelcomePage.Click
        Me.Close()

        pageWelcome.StartPosition = FormStartPosition.Manual
        pageWelcome.DesktopLocation = Me.DesktopLocation

        pageWelcome.Show()
    End Sub

    Private Sub checkItalic_CheckedChanged(sender As Object, e As EventArgs) Handles checkItalic.CheckedChanged
        If checkItalic.Checked Then
            txtSample.Font = New Font(txtSample.Font, FontStyle.Italic)
        Else
            txtSample.Font = New Font(txtSample.Font, FontStyle.Regular)

        End If
    End Sub

    Private Sub checkBold_CheckedChanged(sender As Object, e As EventArgs) Handles checkBold.CheckedChanged
        If checkBold.Checked Then
            txtSample.Font = New Font(txtSample.Font, FontStyle.Bold)
        Else
            txtSample.Font = New Font(txtSample.Font, FontStyle.Regular)

        End If
    End Sub

    Private Sub checkBoldItalic_CheckedChanged(sender As Object, e As EventArgs) Handles checkBoldItalic.CheckedChanged
        If checkBoldItalic.Checked Then
            txtSample.Font = New Font(txtSample.Font, FontStyle.Bold Or FontStyle.Italic)
        Else
            txtSample.Font = New Font(txtSample.Font, FontStyle.Regular)
        End If
    End Sub

    Private Sub radioGreen_CheckedChanged(sender As Object, e As EventArgs) Handles radioGreen.CheckedChanged
        If radioGreen.Checked Then
            txtSample.ForeColor = Color.Green
        End If

    End Sub

    Private Sub radioBlue_CheckedChanged(sender As Object, e As EventArgs) Handles radioBlue.CheckedChanged
        If radioBlue.Checked Then
            txtSample.ForeColor = Color.Blue
        End If
    End Sub

    Private Sub radioRed_CheckedChanged(sender As Object, e As EventArgs) Handles radioRed.CheckedChanged
        If radioRed.Checked Then
            txtSample.ForeColor = Color.Red
        End If
    End Sub

    Private Sub radioGaramond_CheckedChanged(sender As Object, e As EventArgs) Handles radioGaramond.CheckedChanged
        If radioGaramond.Checked Then
            txtSample.Font = New Font("Garamond", txtSample.Font.Size)
        End If
    End Sub

    Private Sub radioMagneto_CheckedChanged(sender As Object, e As EventArgs) Handles radioMagneto.CheckedChanged
        If radioMagneto.Checked Then
            txtSample.Font = New Font("Magneto", txtSample.Font.Size)
        End If
    End Sub

    Private Sub radioTahoma_CheckedChanged(sender As Object, e As EventArgs) Handles radioTahoma.CheckedChanged
        If radioTahoma.Checked Then
            txtSample.Font = New Font("Tahoma", txtSample.Font.Size)
        End If
    End Sub

    Private Sub btnLoadPicture_Click(sender As Object, e As EventArgs) Handles btnLoadPicture.Click
        OpenFileDialog1 = New OpenFileDialog()
        OpenFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp"
        OpenFileDialog1.Title = "Select an Image File"
        OpenFileDialog1.ShowDialog()

        If OpenFileDialog1.FileName <> "" Then
            pictureView.Image = Image.FromFile(OpenFileDialog1.FileName)
            pictureView.SizeMode = PictureBoxSizeMode.Zoom
        End If

    End Sub
End Class