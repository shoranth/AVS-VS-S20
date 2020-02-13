Public Class ValidateUserDataForm
    Private Sub ValidateUserDataForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub ValidateButton_Click(sender As Object, e As EventArgs) Handles ValidateButton.Click
        'IsEmpty()
        Dim userMessage As String

        If IsStringEmpty(TextBox3.Text) = True Then
            userMessage &= "Please enter text in textbox 3." & vbNewLine
            TextBox3.Select()
        End If

        If IsStringEmpty(TextBox2.Text) = True Then
            userMessage &= "Please enter text in textbox 2." & vbNewLine
            TextBox2.Select()
        End If

        If IsStringEmpty(TextBox1.Text) = True Then
            userMessage &= "Please enter text in textbox 1." & vbNewLine
            TextBox1.Select()
        End If

        If userMessage <> "" Then
            MsgBox(userMessage)
        End If
    End Sub

    'Checks to see if each text box is empty
    Sub IsEmpty()

        Dim userMessage As String
        userMessage = ""

        'Anthoer way to check a condition
        'Select Case ""
        '    Case TextBox3.Text
        '        userMessage &= "Please enter text in textbox 3." & vbNewLine
        '    Case TextBox2.Text
        '        userMessage &= "Please enter text in textbox 2." & vbNewLine
        '    Case TextBox1.Text
        '        userMessage &= "Please enter text in textbox 1." & vbNewLine
        'End Select

        'If TextBox1.Text = "" Then
        '    userMessage &= "Please enter text in textbox 1." & vbNewLine
        '    'selects the box that needs to be filled in when this if is triggered
        '    TextBox1.Select()
        'End If

        'If TextBox2.Text = "" Then
        '    userMessage &= "Please enter text in textbox 2." & vbNewLine
        '    TextBox2.Select()
        'End If

        'If TextBox3.Text = "" Then
        '    userMessage &= ("Please enter text in texbox 3.")
        '    TextBox3.Select()
        'End If

        'If userMessage <> "" Then
        '    MsgBox(userMessage)
        'End If

    End Sub

    Function IsStringEmpty(stringUnderTest As String) As Boolean
        Dim status As Boolean
        If stringUnderTest = "" Then
            status = True
        Else
            status = False
        End If
        Return status
    End Function

End Class
