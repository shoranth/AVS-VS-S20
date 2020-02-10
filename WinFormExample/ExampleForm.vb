Public Class ExampleForm
    Private Sub WinFormExample_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Text = "Hello Form"
    End Sub

    Private Sub ExitButton_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

    Private Sub UpdateButton_Click(sender As Object, e As EventArgs) Handles UpdateButton.Click
        Dim userInput As String

        userInput = UserTextBox.Text
        Me.Text = userInput

    End Sub
End Class
