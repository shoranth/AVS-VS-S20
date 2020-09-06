Public Class AddressLabelForm
    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub DisplayButton_Click(sender As Object, e As EventArgs) Handles DisplayButton.Click

        FirstNameTextBox.ToString()
        AddressLabelDisplay.Text = FirstNameTextBox.Text & " " & LastNameTextBox.Text & vbNewLine & StreetAddressTextBox.Text & vbNewLine & CityTextBox.Text & ", " & StateTextBox.Text & " " & ZipCodeTextBox.Text

    End Sub

    Private Sub ClearButton_Click(sender As Object, e As EventArgs) Handles ClearButton.Click

        AddressLabelDisplay.Text = String.Empty

    End Sub

End Class
