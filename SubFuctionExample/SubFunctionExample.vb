'Anthony Shore
'RCET 
'Spring 2020
'Sub Function Example
'

Module SubFunctionExample

    Sub Main()

        Dim myNumber As Integer
        myNumber = 7

        Console.WriteLine("This is located in Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()

        MySub(myNumber)
        Console.WriteLine("This is located in Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()

        myNumber = MyFunc(myNumber)
        Console.WriteLine("This is located in Sub Main")
        Console.WriteLine(myNumber)
        Console.ReadLine()

    End Sub

    Sub MySub(myNumber As Integer)

        'Dim myNumber As Integer
        'myNumber = 2 + myNumber    same as the line of code below
        myNumber += 2
        Console.WriteLine("This is located in Sub MySub")
        Console.WriteLine(myNumber)
        Console.ReadLine()

    End Sub

    Function MyFunc(myNumber As Integer) As Integer

        'Dim myNumber As Integer
        myNumber -= 93
        Console.WriteLine("Located in Function MyFunc")
        Console.WriteLine(myNumber)
        Console.ReadLine()
        Return myNumber

    End Function

End Module
