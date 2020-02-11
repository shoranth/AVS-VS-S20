Public Class FormControlsForm
    Private Sub FormControlsForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click

        Dim displayText As String
        displayText = NameTextBox.Text & vbNewLine & StreetTextBox.Text & vbNewLine & StateTextBox.Text

        DisplayLabel.Text = displayText

    End Sub

    Private Sub StreetTextBox_TextChanged(sender As Object, e As EventArgs) Handles StreetTextBox.TextChanged

    End Sub

    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click
        RadioButton1.Checked = True

        If CheckBox1.Checked = True Then
            DisplayLabel.Text = NameTextBox.Text
        End If

    End Sub
End Class
