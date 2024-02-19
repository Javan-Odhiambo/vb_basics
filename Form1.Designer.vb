<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class pageWelcome
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        lblWelcome = New Label()
        btnLoadObjectDemo = New Button()
        btnExit = New Button()
        SuspendLayout()
        ' 
        ' lblWelcome
        ' 
        lblWelcome.AutoSize = True
        lblWelcome.Location = New Point(12, 9)
        lblWelcome.Margin = New Padding(8, 0, 8, 0)
        lblWelcome.Name = "lblWelcome"
        lblWelcome.Size = New Size(122, 20)
        lblWelcome.TabIndex = 0
        lblWelcome.Text = "Welcoming Form"
        ' 
        ' btnLoadObjectDemo
        ' 
        btnLoadObjectDemo.Location = New Point(300, 226)
        btnLoadObjectDemo.Name = "btnLoadObjectDemo"
        btnLoadObjectDemo.Size = New Size(176, 48)
        btnLoadObjectDemo.TabIndex = 1
        btnLoadObjectDemo.Text = "Load Object Demo"
        btnLoadObjectDemo.UseVisualStyleBackColor = True
        ' 
        ' btnExit
        ' 
        btnExit.AccessibleDescription = "Test"
        btnExit.ImageAlign = ContentAlignment.MiddleLeft
        btnExit.Location = New Point(498, 226)
        btnExit.Name = "btnExit"
        btnExit.Size = New Size(176, 48)
        btnExit.TabIndex = 2
        btnExit.Text = "EXIT"
        btnExit.UseVisualStyleBackColor = True
        ' 
        ' pageWelcome
        ' 
        AutoScaleDimensions = New SizeF(8.0F, 20.0F)
        AutoScaleMode = AutoScaleMode.Font
        ClientSize = New Size(974, 501)
        Controls.Add(btnExit)
        Controls.Add(btnLoadObjectDemo)
        Controls.Add(lblWelcome)
        Name = "pageWelcome"
        Text = "Welcome"
        ResumeLayout(False)
        PerformLayout()
    End Sub

    Friend WithEvents lblWelcome As Label
    Friend WithEvents btnLoadObjectDemo As Button
    Friend WithEvents btnExit As Button

End Class
