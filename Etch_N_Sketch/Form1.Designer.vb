<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Etch_N_Sketch
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
        Me.CursorColorPicker = New System.Windows.Forms.ColorDialog()
        Me.DrawAreaLabel = New System.Windows.Forms.Label()
        Me.EraseButton = New System.Windows.Forms.Button()
        Me.CursorColorButton = New System.Windows.Forms.Button()
        Me.BackgroundColorButton = New System.Windows.Forms.Button()
        Me.BackgroundColorPicker = New System.Windows.Forms.ColorDialog()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DrawAreaLabel
        '
        Me.DrawAreaLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.DrawAreaLabel.Cursor = System.Windows.Forms.Cursors.Cross
        Me.DrawAreaLabel.Location = New System.Drawing.Point(179, 91)
        Me.DrawAreaLabel.Name = "DrawAreaLabel"
        Me.DrawAreaLabel.Size = New System.Drawing.Size(380, 158)
        Me.DrawAreaLabel.TabIndex = 0
        '
        'EraseButton
        '
        Me.EraseButton.Location = New System.Drawing.Point(257, 306)
        Me.EraseButton.Name = "EraseButton"
        Me.EraseButton.Size = New System.Drawing.Size(75, 23)
        Me.EraseButton.TabIndex = 1
        Me.EraseButton.Text = "Erase"
        Me.EraseButton.UseVisualStyleBackColor = True
        '
        'CursorColorButton
        '
        Me.CursorColorButton.Location = New System.Drawing.Point(420, 306)
        Me.CursorColorButton.Name = "CursorColorButton"
        Me.CursorColorButton.Size = New System.Drawing.Size(75, 23)
        Me.CursorColorButton.TabIndex = 2
        Me.CursorColorButton.Text = "Cursor Color"
        Me.CursorColorButton.UseVisualStyleBackColor = True
        '
        'BackgroundColorButton
        '
        Me.BackgroundColorButton.Location = New System.Drawing.Point(546, 306)
        Me.BackgroundColorButton.Name = "BackgroundColorButton"
        Me.BackgroundColorButton.Size = New System.Drawing.Size(75, 23)
        Me.BackgroundColorButton.TabIndex = 3
        Me.BackgroundColorButton.Text = "Background Color"
        Me.BackgroundColorButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(644, 306)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(75, 23)
        Me.ExitButton.TabIndex = 4
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Etch_N_Sketch
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.BackgroundColorButton)
        Me.Controls.Add(Me.CursorColorButton)
        Me.Controls.Add(Me.EraseButton)
        Me.Controls.Add(Me.DrawAreaLabel)
        Me.Name = "Etch_N_Sketch"
        Me.Text = "Form1"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents CursorColorPicker As ColorDialog
    Friend WithEvents DrawAreaLabel As Label
    Friend WithEvents EraseButton As Button
    Friend WithEvents CursorColorButton As Button
    Friend WithEvents BackgroundColorButton As Button
    Friend WithEvents BackgroundColorPicker As ColorDialog
    Friend WithEvents ExitButton As Button
End Class
