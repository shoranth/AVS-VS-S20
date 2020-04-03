Public Class Form1
    Private Sub GoButton_Click(sender As Object, e As EventArgs) Handles GoButton.Click


        MainComboBox.Items.Add(NameTextBox.Text)
        NameTextBox.Text = ""
        'Load Name and age into an array

    End Sub



    Private Sub MainComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles MainComboBox.SelectedIndexChanged

        Me.Text = MainComboBox.SelectedIndex
        NameTextBox.Text = MainComboBox.SelectedItem.ToString


    End Sub
End Class
