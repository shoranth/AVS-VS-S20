'Anthony Shore 
'RCET 02
'Spring 2020
'Accumulate Messages Function
'https://github.com/shoranth/AVS-VS-S20

Module UserMessageFunction



    Sub Main()

        'MsgBox(UserMessages(True, "hello", False))
        Console.WriteLine(UserMEssages(True, "hello", False))
        Console.WriteLine(UserMEssages(True, "hello2", False))
        Console.WriteLine(UserMEssages(True, "hello3", False))
        MsgBox(UserMEssages(True, "", False))

    End Sub

    Function UserMEssages(addMessage As Boolean, message As String, clearMessage As Boolean)

        Static formattedMessages As String = ""

        formattedMessages &= message & vbNewLine

        Return formattedMessages

    End Function



End Module
