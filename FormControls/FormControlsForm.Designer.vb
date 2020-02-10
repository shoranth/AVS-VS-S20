<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class FormControlsForm
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
        Me.GoButton = New System.Windows.Forms.Button()
        Me.UpdateButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.UserInputGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserSelectionGroupBox = New System.Windows.Forms.GroupBox()
        Me.UserPictureBox = New System.Windows.Forms.PictureBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.UserInputGroupBox.SuspendLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GoButton
        '
        Me.GoButton.Location = New System.Drawing.Point(31, 372)
        Me.GoButton.Name = "GoButton"
        Me.GoButton.Size = New System.Drawing.Size(240, 75)
        Me.GoButton.TabIndex = 0
        Me.GoButton.Text = "Go"
        Me.GoButton.UseVisualStyleBackColor = True
        '
        'UpdateButton
        '
        Me.UpdateButton.Location = New System.Drawing.Point(277, 372)
        Me.UpdateButton.Name = "UpdateButton"
        Me.UpdateButton.Size = New System.Drawing.Size(240, 75)
        Me.UpdateButton.TabIndex = 1
        Me.UpdateButton.Text = "Update"
        Me.UpdateButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(523, 372)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(240, 75)
        Me.ExitButton.TabIndex = 2
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'UserInputGroupBox
        '
        Me.UserInputGroupBox.Controls.Add(Me.TextBox3)
        Me.UserInputGroupBox.Controls.Add(Me.TextBox2)
        Me.UserInputGroupBox.Controls.Add(Me.TextBox1)
        Me.UserInputGroupBox.Location = New System.Drawing.Point(31, 35)
        Me.UserInputGroupBox.Name = "UserInputGroupBox"
        Me.UserInputGroupBox.Size = New System.Drawing.Size(240, 285)
        Me.UserInputGroupBox.TabIndex = 3
        Me.UserInputGroupBox.TabStop = False
        '
        'UserSelectionGroupBox
        '
        Me.UserSelectionGroupBox.Location = New System.Drawing.Point(277, 35)
        Me.UserSelectionGroupBox.Name = "UserSelectionGroupBox"
        Me.UserSelectionGroupBox.Size = New System.Drawing.Size(248, 285)
        Me.UserSelectionGroupBox.TabIndex = 4
        Me.UserSelectionGroupBox.TabStop = False
        '
        'UserPictureBox
        '
        Me.UserPictureBox.Location = New System.Drawing.Point(531, 35)
        Me.UserPictureBox.Name = "UserPictureBox"
        Me.UserPictureBox.Size = New System.Drawing.Size(232, 285)
        Me.UserPictureBox.TabIndex = 5
        Me.UserPictureBox.TabStop = False
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(24, 64)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(184, 26)
        Me.TextBox1.TabIndex = 0
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(24, 135)
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(184, 26)
        Me.TextBox2.TabIndex = 1
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(24, 210)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(184, 26)
        Me.TextBox3.TabIndex = 2
        '
        'FormControlsForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(809, 529)
        Me.Controls.Add(Me.UserPictureBox)
        Me.Controls.Add(Me.UserSelectionGroupBox)
        Me.Controls.Add(Me.UserInputGroupBox)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.UpdateButton)
        Me.Controls.Add(Me.GoButton)
        Me.Name = "FormControlsForm"
        Me.Text = "Form1"
        Me.UserInputGroupBox.ResumeLayout(False)
        Me.UserInputGroupBox.PerformLayout()
        CType(Me.UserPictureBox, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GoButton As Button
    Friend WithEvents UpdateButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents UserInputGroupBox As GroupBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents UserSelectionGroupBox As GroupBox
    Friend WithEvents UserPictureBox As PictureBox
End Class
