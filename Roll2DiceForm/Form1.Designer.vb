<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Roll2DiceForm
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
        Me.DiceRollsListBox = New System.Windows.Forms.ListBox()
        Me.RollOnceButton = New System.Windows.Forms.Button()
        Me.RollThousandButton = New System.Windows.Forms.Button()
        Me.ExitButton = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'DiceRollsListBox
        '
        Me.DiceRollsListBox.FormattingEnabled = True
        Me.DiceRollsListBox.ItemHeight = 20
        Me.DiceRollsListBox.Location = New System.Drawing.Point(137, 171)
        Me.DiceRollsListBox.Name = "DiceRollsListBox"
        Me.DiceRollsListBox.Size = New System.Drawing.Size(442, 304)
        Me.DiceRollsListBox.TabIndex = 0
        '
        'RollOnceButton
        '
        Me.RollOnceButton.Location = New System.Drawing.Point(137, 64)
        Me.RollOnceButton.Name = "RollOnceButton"
        Me.RollOnceButton.Size = New System.Drawing.Size(101, 45)
        Me.RollOnceButton.TabIndex = 1
        Me.RollOnceButton.Text = "Roll Once"
        Me.RollOnceButton.UseVisualStyleBackColor = True
        '
        'RollThousandButton
        '
        Me.RollThousandButton.Location = New System.Drawing.Point(244, 64)
        Me.RollThousandButton.Name = "RollThousandButton"
        Me.RollThousandButton.Size = New System.Drawing.Size(228, 45)
        Me.RollThousandButton.TabIndex = 2
        Me.RollThousandButton.Text = "Roll 1000 Times"
        Me.RollThousandButton.UseVisualStyleBackColor = True
        '
        'ExitButton
        '
        Me.ExitButton.Location = New System.Drawing.Point(478, 64)
        Me.ExitButton.Name = "ExitButton"
        Me.ExitButton.Size = New System.Drawing.Size(101, 45)
        Me.ExitButton.TabIndex = 3
        Me.ExitButton.Text = "Exit"
        Me.ExitButton.UseVisualStyleBackColor = True
        '
        'Roll2DiceForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(800, 599)
        Me.Controls.Add(Me.ExitButton)
        Me.Controls.Add(Me.RollThousandButton)
        Me.Controls.Add(Me.RollOnceButton)
        Me.Controls.Add(Me.DiceRollsListBox)
        Me.Name = "Roll2DiceForm"
        Me.Text = "Roll 2 Dice"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents DiceRollsListBox As ListBox
    Friend WithEvents RollOnceButton As Button
    Friend WithEvents RollThousandButton As Button
    Friend WithEvents ExitButton As Button
End Class
