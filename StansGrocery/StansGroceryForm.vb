'Anthony Shore
'RCET 0265
'Spring 2020
'Stan's Grocery

Option Compare Binary

Public Class StansGroceryForm
    Private groceryTextFile As String = "G:\My Drive\Visual Basic Class\AVS-VS-S20\StansGrocery\Grocery.txt"
    Public itemAisleInfo(2, 4) As String

    'Loads Data into an array when the program starts
    Sub ReadFileItemsToArray()
        Dim itemAisle As Integer = 0

        'loads data from file
        Try
            FileOpen(1, groceryTextFile, OpenMode.Input)
            Do While Not EOF(1)
                Input(1, itemAisleInfo(itemAisle, 0))
                Input(1, itemAisleInfo(itemAisle, 1))
                Input(1, itemAisleInfo(itemAisle, 2))
                Input(1, itemAisleInfo(itemAisle, 3))
                Input(1, itemAisleInfo(itemAisle, 4))
                itemAisle += 1
            Loop
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            FileClose(1)
        End Try

        'loads data into combo box for user to choose from
        For i = 0 To 2
            For j = 0 To 4
                ItemComboBox.Items.Add(itemAisleInfo(i, j))
            Next
        Next

        'loads data into display list box for user to choose from
        For i = 0 To 2
            For j = 0 To 4
                ItemDisplayListBox.Items.Add(itemAisleInfo(i, j))
            Next
        Next

    End Sub

    'triggers when search button is clicked
    Sub SearchItems()
        AisleDisplayLabel.Text = ""


        Try
            'searches aisle 1
            For i = 0 To 4
                If itemAisleInfo(0, i) = SearchTextBox.Text Then
                    AisleDisplayLabel.Text = "Your Item is on aisle 1."
                End If
            Next

            'searches aisle 2
            For i = 0 To 4
                If itemAisleInfo(1, i) = SearchTextBox.Text Then
                    AisleDisplayLabel.Text = "Your Item is on aisle 2."
                End If
            Next

            'searches aisle 3
            For i = 0 To 4
                If itemAisleInfo(2, i) = SearchTextBox.Text Then
                    AisleDisplayLabel.Text = "Your Item is on aisle 3."
                End If
            Next
            'if code above fails an error message is given
        Catch ex As Exception
            MsgBox("Please enter a proper value")
        End Try

        'if the item was not found 
        If AisleDisplayLabel.Text = "" Then
            AisleDisplayLabel.Text = "Your item was not found"
        End If

    End Sub
    Private Sub SearchButton_Click(sender As Object, e As EventArgs) Handles SearchButton.Click

        'closes the program if zzz is entered
        If SearchTextBox.Text = "zzz" Then
            Me.Close()
        Else
            SearchItems()
        End If

    End Sub

    Private Sub StansGroceryForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        'loads data into the array for the program to search through when search button is clicked
        ReadFileItemsToArray()

    End Sub

    Private Sub ItemComboBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemComboBox.SelectedIndexChanged

        'if there is a change in the combo box the display list box is cleared and the text in the combo box is loaded into the search text box
        If ItemComboBox.selectedindex <> -1 Then
            ItemDisplayListBox.selectedindex = -1
            SearchTextBox.text = ItemComboBox.selecteditem.tostring
        End If

    End Sub

    Private Sub ItemDisplayListBox_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ItemDisplayListBox.SelectedIndexChanged

        'if there is a change in the display list box the combo box is cleared and the text in the display list box is loaded into the search text box
        If ItemDisplayListBox.selectedindex <> -1 Then
            ItemcomboBox.selectedindex = -1
            SearchTextBox.text = ItemDisplayListBox.selecteditem.tostring
        End If

    End Sub

End Class
