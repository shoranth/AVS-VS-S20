'Anthony Shore
'RCET0265
'Spring 2020
'Math Contest
'https://github.com/shoranth/AVS-VS-S20

Public Class MathContestForm
    Private Sub MathContestForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub


    Sub IsEmpty()
        'Check each if empty and alert user
        Dim userMessage As String = ""

        If FirstLastNameTextBox.Text = "" Then
            userMessage &= "Please enter a name into the Name text box." & vbNewLine
            FirstLastNameTextBox.Select()
        End If

        If FirstNumberTextBox.Text = "" Then
            userMessage &= "Please enter a number into the First Number text box." & vbNewLine
            SecondNumberTextBox.Select()
        End If

        If SecondNumberTextBox.Text = "" Then
            userMessage &= "Please entera number into the Second Number text box." & vbNewLine
            FirstNumberTextBox.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If
    End Sub

    Private Sub AddRadioButton_CheckedChanged(sender As Object, e As EventArgs) Handles AddRadioButton.CheckedChanged
        AddRadioButton.Checked = True
    End Sub
End Class
