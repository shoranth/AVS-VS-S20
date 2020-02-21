'Anthony Shore
'RCET0265
'Spring 2020
'Diner Menu Program
'https://github.com/shoranth/AVS-VS-S20

Public Class DinerMenu
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles SoupButton.Click

        Dim soupItem As String = "Geonosis Fire Ball Soup." & vbNewLine & "Its so hot fire will come out your ears." & vbNewLine & "Served with resfreshing Blue Milk" & vbNewLine & "(Food not available for humans)"

        DisplaySpecialLabel.Text = soupItem

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles SaladButton.Click

        Dim saladItem As String = "A nutrituous grilled Porg Salad. " & vbNewLine & "Served with Iced Tea or Tar Tar Milk."

        DisplaySpecialLabel.Text = saladItem

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles FishButton.Click

        Dim fishItem As String = "Caught from the oceans of Kamino," & vbNewLine & " the Kamino fish is slowly roasted" & vbNewLine & " over an open fire for 26 hours. " & vbNewLine & "Served with frog legs and Jawa Juice."

        DisplaySpecialLabel.Text = fishItem

    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles ExitButton.Click
        Me.Close()
    End Sub

End Class
