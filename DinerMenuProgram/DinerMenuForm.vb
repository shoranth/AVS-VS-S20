Public Class DinerMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        Dim soupItem As String = "Lobster Bisque"

        DisplaySpecialLabel.Text = soupItem

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

        Dim saladItem As String = "Ceasar Salad"

        DisplaySpecialLabel.Text = saladItem

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles FishButton.Click

        Dim fishItem As String = "Fresh Salmon"

        DisplaySpecialLabel.Text = fishItem

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
