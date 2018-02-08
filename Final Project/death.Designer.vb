<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class death
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
        Me.btnRestart = New System.Windows.Forms.Button()
        Me.btnQuit = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnRestart
        '
        Me.btnRestart.ForeColor = System.Drawing.Color.Black
        Me.btnRestart.Image = Global.Final_Project.My.Resources.Resources.Firegifthat_works
        Me.btnRestart.Location = New System.Drawing.Point(335, 467)
        Me.btnRestart.Name = "btnRestart"
        Me.btnRestart.Size = New System.Drawing.Size(126, 61)
        Me.btnRestart.TabIndex = 0
        Me.btnRestart.Text = "RESTART"
        Me.btnRestart.UseVisualStyleBackColor = True
        '
        'btnQuit
        '
        Me.btnQuit.Image = Global.Final_Project.My.Resources.Resources.Firegifthat_works
        Me.btnQuit.Location = New System.Drawing.Point(571, 542)
        Me.btnQuit.Name = "btnQuit"
        Me.btnQuit.Size = New System.Drawing.Size(119, 61)
        Me.btnQuit.TabIndex = 1
        Me.btnQuit.Text = "QUIT"
        Me.btnQuit.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Image = Global.Final_Project.My.Resources.Resources.Firegifthat_works
        Me.Button3.Location = New System.Drawing.Point(828, 467)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(133, 61)
        Me.Button3.TabIndex = 2
        Me.Button3.Text = "MAIN MENU"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'death
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Final_Project.My.Resources.Resources.menuScreen
        Me.ClientSize = New System.Drawing.Size(1219, 652)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.btnQuit)
        Me.Controls.Add(Me.btnRestart)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Name = "death"
        Me.Text = "Form2"
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnRestart As System.Windows.Forms.Button
    Friend WithEvents btnQuit As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
End Class
