<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class pageObjectDemonstrations
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        components = New ComponentModel.Container()
        btnLoadPicture = New Button()
        btnExitToWelcomePage = New Button()
        tipLoadPicture = New ToolTip(components)
        tipExitToWelcomePage = New ToolTip(components)
        gboxDisplayTest = New GroupBox()
        txtSample = New TextBox()
        gboxFont = New GroupBox()
        radioTahoma = New RadioButton()
        radioMagneto = New RadioButton()
        radioGaramond = New RadioButton()
        pictureView = New PictureBox()
        gboxFontStyle = New GroupBox()
        checkBoldItalic = New CheckBox()
        checkBold = New CheckBox()
        checkItalic = New CheckBox()
        gboxFontColor = New GroupBox()
        radioRed = New RadioButton()
        radioBlue = New RadioButton()
        radioGreen = New RadioButton()
        FolderBrowserDialog1 = New FolderBrowserDialog()
        OpenFileDialog1 = New OpenFileDialog()
        gboxDisplayTest.SuspendLayout()
        gboxFont.SuspendLayout()
        CType(pictureView, ComponentModel.ISupportInitialize).BeginInit()
        gboxFontStyle.SuspendLayout()
        gboxFontColor.SuspendLayout()
        SuspendLayout()
        ' 
        ' btnLoadPicture
        ' 
        btnLoadPicture.Location = New Point(140, 444)
        btnLoadPicture.Name = "btnLoadPicture"
        btnLoadPicture.Size = New Size(187, 45)
        btnLoadPicture.TabIndex = 0
        btnLoadPicture.Text = "Load Picture"
        tipLoadPicture.SetToolTip(btnLoadPicture, "Loads a picture from the hard disk of the computer and displays it in the picture box")
        btnLoadPicture.UseVisualStyleBackColor = True
        ' 
        ' btnExitToWelcomePage
        ' 
        btnExitToWelcomePage.Location = New Point(691, 444)
        btnExitToWelcomePage.Name = "btnExitToWelcomePage"
        btnExitToWelcomePage.Size = New Size(153, 45)
        btnExitToWelcomePage.TabIndex = 1
        btnExitToWelcomePage.Text = "Exit"
        tipExitToWelcomePage.SetToolTip(btnExitToWelcomePage, "Back to the welcome page")
        btnExitToWelcomePage.UseVisualStyleBackColor = True
        ' 
        ' tipLoadPicture
        ' 
        tipLoadPicture.ToolTipTitle = "Load Picture"
        ' 
        ' gboxDisplayTest
        ' 
        gboxDisplayTest.Controls.Add(txtSample)
        gboxDisplayTest.Location = New Point(53, 39)
        gboxDisplayTest.Name = "gboxDisplayTest"
        gboxDisplayTest.Size = New Size(282, 73)
        gboxDisplayTest.TabIndex = 2
        gboxDisplayTest.TabStop = False
        gboxDisplayTest.Text = "Display Test"
        ' 
        ' txtSample
        ' 
        txtSample.Location = New Point(26, 32)
        txtSample.Name = "txtSample"
        txtSample.Size = New Size(174, 27)
        txtSample.TabIndex = 0
        txtSample.Text = "Sample text"
        ' 
        ' gboxFont
        ' 
        gboxFont.Controls.Add(radioTahoma)
        gboxFont.Controls.Add(radioMagneto)
        gboxFont.Controls.Add(radioGaramond)
        gboxFont.Location = New Point(410, 43)
        gboxFont.Name = "gboxFont"
        gboxFont.Size = New Size(449, 65)
        gboxFont.TabIndex = 3
        gboxFont.TabStop = False
        gboxFont.Text = "Font"
        ' 
        ' radioTahoma
        ' 
        radioTahoma.AutoSize = True
        radioTahoma.Location = New Point(324, 26)
        radioTahoma.Name = "radioTahoma"
        radioTahoma.Size = New Size(82, 24)
        radioTahoma.TabIndex = 2
        radioTahoma.TabStop = True
        radioTahoma.Text = "Tahoma"
        radioTahoma.UseVisualStyleBackColor = True
        ' 
        ' radioMagneto
        ' 
        radioMagneto.AutoSize = True
        radioMagneto.Location = New Point(197, 26)
        radioMagneto.Name = "radioMagneto"
        radioMagneto.Size = New Size(90, 24)
        radioMagneto.TabIndex = 1
        radioMagneto.TabStop = True
        radioMagneto.Text = "Magneto"
        radioMagneto.UseVisualStyleBackColor = True
        ' 
        ' radioGaramond
        ' 
        radioGaramond.AutoSize = True
        radioGaramond.Location = New Point(60, 26)
        radioGaramond.Name = "radioGaramond"
        radioGaramond.Size = New Size(100, 24)
        radioGaramond.TabIndex = 0
        radioGaramond.TabStop = True
        radioGaramond.Text = "Garamond"
        radioGaramond.UseVisualStyleBackColor = True
        ' 
        ' pictureView
        ' 
        pictureView.Location = New Point(53, 137)
        pictureView.Name = "pictureView"
        pictureView.Size = New Size(342, 288)
        pictureView.TabIndex = 4
        pictureView.TabStop = False
        ' 
        ' gboxFontStyle
        ' 
        gboxFontStyle.Controls.Add(checkBoldItalic)
        gboxFontStyle.Controls.Add(checkBold)
        gboxFontStyle.Controls.Add(checkItalic)
        gboxFontStyle.Location = New Point(442, 141)
        gboxFontStyle.Name = "gboxFontStyle"
        gboxFontStyle.Size = New Size(212, 226)
        gboxFontStyle.TabIndex = 5
        gboxFontStyle.TabStop = False
        gboxFontStyle.Text = "Font Style"
        ' 
        ' checkBoldItalic
        ' 
        checkBoldItalic.AutoSize = True
        checkBoldItalic.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold Or FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        checkBoldItalic.Location = New Point(28, 137)
        checkBoldItalic.Name = "checkBoldItalic"
        checkBoldItalic.Size = New Size(105, 24)
        checkBoldItalic.TabIndex = 2
        checkBoldItalic.Text = "Bold Italic"
        checkBoldItalic.UseVisualStyleBackColor = True
        ' 
        ' checkBold
        ' 
        checkBold.AutoSize = True
        checkBold.Font = New Font("Segoe UI", 9.0F, FontStyle.Bold, GraphicsUnit.Point, CByte(0))
        checkBold.Location = New Point(28, 89)
        checkBold.Name = "checkBold"
        checkBold.Size = New Size(63, 24)
        checkBold.TabIndex = 1
        checkBold.Text = "Bold"
        checkBold.UseVisualStyleBackColor = True
        ' 
        ' checkItalic
        ' 
        checkItalic.AutoSize = True
        checkItalic.Font = New Font("Segoe UI", 9.0F, FontStyle.Italic, GraphicsUnit.Point, CByte(0))
        checkItalic.Location = New Point(28, 45)
        checkItalic.Name = "checkItalic"
        checkItalic.Size = New Size(63, 24)
        checkItalic.TabIndex = 0
        checkItalic.Text = "Italic"
        checkItalic.UseVisualStyleBackColor = True
        ' 
        ' gboxFontColor
        ' 
        gboxFontColor.Controls.Add(radioRed)
        gboxFontColor.Controls.Add(radioBlue)
        gboxFontColor.Controls.Add(radioGreen)
        gboxFontColor.Location = New Point(678, 141)
        gboxFontColor.Name = "gboxFontColor"
        gboxFontColor.Size = New Size(181, 226)
        gboxFontColor.TabIndex = 6
        gboxFontColor.TabStop = False
        gboxFontColor.Text = "Font Color"
        ' 
        ' radioRed
        ' 
        radioRed.AutoSize = True
        radioRed.Location = New Point(13, 136)
        radioRed.Name = "radioRed"
        radioRed.Size = New Size(56, 24)
        radioRed.TabIndex = 2
        radioRed.TabStop = True
        radioRed.Text = "Red"
        radioRed.UseVisualStyleBackColor = True
        ' 
        ' radioBlue
        ' 
        radioBlue.AutoSize = True
        radioBlue.Location = New Point(13, 88)
        radioBlue.Name = "radioBlue"
        radioBlue.Size = New Size(59, 24)
        radioBlue.TabIndex = 1
        radioBlue.TabStop = True
        radioBlue.Text = "Blue"
        radioBlue.UseVisualStyleBackColor = True
        ' 
        ' radioGreen
        ' 
        radioGreen.AutoSize = True
        radioGreen.Location = New Point(13, 44)
        radioGreen.Name = "radioGreen"
        radioGreen.Size = New Size(69, 24)
        radioGreen.TabIndex = 0
        radioGreen.TabStop = True
        radioGreen.Text = "Green"
        radioGreen.UseVisualStyleBackColor = True
        ' 
        ' OpenFileDialog1
        ' 
        OpenFileDialog1.FileName = "OpenFileDialog1"
        ' 
        ' pageObjectDemonstrations
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 501)
        Controls.Add(gboxFontColor)
        Controls.Add(gboxFontStyle)
        Controls.Add(pictureView)
        Controls.Add(gboxFont)
        Controls.Add(gboxDisplayTest)
        Controls.Add(btnExitToWelcomePage)
        Controls.Add(btnLoadPicture)
        Name = "pageObjectDemonstrations"
        Text = "Object Demonstration"
        gboxDisplayTest.ResumeLayout(False)
        gboxDisplayTest.PerformLayout()
        gboxFont.ResumeLayout(False)
        gboxFont.PerformLayout()
        CType(pictureView, ComponentModel.ISupportInitialize).EndInit()
        gboxFontStyle.ResumeLayout(False)
        gboxFontStyle.PerformLayout()
        gboxFontColor.ResumeLayout(False)
        gboxFontColor.PerformLayout()
        ResumeLayout(False)
    End Sub

    Friend WithEvents btnLoadPicture As Button
    Friend WithEvents btnExitToWelcomePage As Button
    Friend WithEvents tipLoadPicture As ToolTip
    Friend WithEvents tipExitToWelcomePage As ToolTip
    Friend WithEvents gboxDisplayTest As GroupBox
    Friend WithEvents txtSample As TextBox
    Friend WithEvents gboxFont As GroupBox
    Friend WithEvents radioTahoma As RadioButton
    Friend WithEvents radioMagneto As RadioButton
    Friend WithEvents radioGaramond As RadioButton
    Friend WithEvents pictureView As PictureBox
    Friend WithEvents gboxFontStyle As GroupBox
    Friend WithEvents checkBoldItalic As CheckBox
    Friend WithEvents checkBold As CheckBox
    Friend WithEvents checkItalic As CheckBox
    Friend WithEvents gboxFontColor As GroupBox
    Friend WithEvents radioRed As RadioButton
    Friend WithEvents radioBlue As RadioButton
    Friend WithEvents radioGreen As RadioButton
    Friend WithEvents FolderBrowserDialog1 As FolderBrowserDialog
    Friend WithEvents OpenFileDialog1 As OpenFileDialog
End Class
