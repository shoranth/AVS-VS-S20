<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class DinerMenu
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
        Me.SoupButton = New System.Windows.Forms.Button()
        Me.SaladButton = New System.Windows.Forms.Button()
        Me.FishButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.DinerNameLabel = New System.Windows.Forms.Label()
        Me.DisplaySpecialLabel = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'SoupButton
        '
        Me.SoupButton.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SoupButton.Location = New System.Drawing.Point(62, 323)
        Me.SoupButton.Name = "SoupButton"
        Me.SoupButton.Size = New System.Drawing.Size(139, 79)
        Me.SoupButton.TabIndex = 0
        Me.SoupButton.Text = "Soup"
        Me.SoupButton.UseVisualStyleBackColor = True
        '
        'SaladButton
        '
        Me.SaladButton.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.SaladButton.Location = New System.Drawing.Point(231, 323)
        Me.SaladButton.Name = "SaladButton"
        Me.SaladButton.Size = New System.Drawing.Size(139, 79)
        Me.SaladButton.TabIndex = 1
        Me.SaladButton.Text = "Salad"
        Me.SaladButton.UseVisualStyleBackColor = True
        '
        'FishButton
        '
        Me.FishButton.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FishButton.Location = New System.Drawing.Point(406, 323)
        Me.FishButton.Name = "FishButton"
        Me.FishButton.Size = New System.Drawing.Size(139, 79)
        Me.FishButton.TabIndex = 2
        Me.FishButton.Text = "Fish"
        Me.FishButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Font = New System.Drawing.Font("Calibri", 16.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ExitButton.Location = New System.Drawing.Point(574, 323)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(139, 79)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "E&xit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'DinerNameLabel
        '
        Me.DinerNameLabel.AutoSize = True
        Me.DinerNameLabel.Font = New System.Drawing.Font("Magneto", 20.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DinerNameLabel.Location = New System.Drawing.Point(274, 22)
        Me.DinerNameLabel.Name = "DinerNameLabel"
        Me.DinerNameLabel.Size = New System.Drawing.Size(271, 48)
        Me.DinerNameLabel.TabIndex = 4
        Me.DinerNameLabel.Text = "Dex's Diner"
        '
        'DisplaySpecialLabel
        '
        Me.DisplaySpecialLabel.AutoEllipsis = True
        Me.DisplaySpecialLabel.AutoSize = True
        Me.DisplaySpecialLabel.Font = New System.Drawing.Font("Segoe Print", 14.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.DisplaySpecialLabel.Location = New System.Drawing.Point(180, 158)
        Me.DisplaySpecialLabel.Name = "DisplaySpecialLabel"
        Me.DisplaySpecialLabel.Size = New System.Drawing.Size(453, 49)
        Me.DisplaySpecialLabel.TabIndex = 5
        Me.DisplaySpecialLabel.Text = "Please select and option below"
        Me.DisplaySpecialLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'DinerMenu
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 450)
        Me.Controls.Add(Me.DisplaySpecialLabel)
        Me.Controls.Add(Me.DinerNameLabel)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.FishButton)
        Me.Controls.Add(Me.SaladButton)
        Me.Controls.Add(Me.SoupButton)
        Me.Name = "DinerMenu"
        Me.Text = "Dex's Diner Special Menu"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SoupButton As Button
    Friend WithEvents SaladButton As Button
    Friend WithEvents FishButton As Button
    Friend WithEvents ExitButton As Button
    Friend WithEvents DinerNameLabel As Label
    Friend WithEvents DisplaySpecialLabel As Label
End Class
