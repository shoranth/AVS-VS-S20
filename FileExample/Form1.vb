Public Class Form1

    Dim fileName As String = "C:\Users\avsho\Downloads\jnk.txt"

    Sub WriteToFile()


        'Mytestfile.txt is located in the bin/Debug folders found within the Form Folder
        'FileOpen(1, "MyTestFile.txt", OpenMode.Output)

        FileOpen(1, fileName, OpenMode.Output)
        'rewrites over past text in file
        WriteLine(1, "File was opened")
        FileClose(1)

    End Sub

    Sub AppendToFile()

        FileOpen(1, fileName, OpenMode.Append)
        'does not rewrite over past text in file
        WriteLine(1, "File was opened again", "some other info", Now, 255)
        FileClose(1)

    End Sub

    Sub ReadFile()
        Dim tempString As Boolean

        FileOpen(1, fileName, OpenMode.Input)

        Input(1, tempString)
        Console.WriteLine(tempString)

        Input(1, tempString)
        Console.WriteLine(tempString)

        FileClose(1)

    End Sub

    Sub ReadEntireFile()
        Dim tempString As String

        Try
            'Reads the entire file
            FileOpen(1, fileName, OpenMode.Input)
            Do While Not EOF(1)
                Input(1, tempString)
            Loop
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            FileClose(1)
        End Try
    End Sub

    Sub ReadFileToArray()
        Dim currentFileRecord As String
        Dim fileDataArray As Array
        Dim fileDataString As String

        Try
            'Reads the entire file
            FileOpen(1, fileName, OpenMode.Input)
            Do While Not EOF(1)
                Input(1, currentFileRecord)
                fileDataString &= currentFileRecord & "$$"
            Loop
        Catch ex As Exception
            Console.WriteLine(ex.Message)
        Finally
            FileClose(1)
        End Try

        fileDataArray = Split(fileDataString, ",")

        Console.WriteLine()

    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'WriteToFile()
        'AppendToFile()
        'ReadFile()
        ReadEntireFile()
    End Sub
End Class
