Module IfThen

    Sub Main()
        Dim firstNumber As Integer
        Dim secondNumber As Integer

        Console.WriteLine("What is the First Number?")
        firstNumber = Console.ReadLine()

        Console.WriteLine("What is the Second Number?")
        secondNumber = Console.ReadLine()

        'This is the complete if then statement
        'If it evaluates to true, it will perform the code within the if then statement
        'If false, it will skip the code in the if then statement
        'The code will select the first true and end the if then statement. Even if there are mulitple trues. 
        If firstNumber > secondNumber Then
            Console.WriteLine("The First Number is GREATER than the Second Number.")
        ElseIf firstNumber < secondNumber Then
            Console.WriteLine("The First Number is LESS than the Second Number.")
            'If the first and second numbers are equal then this code will execute since it is the first equal to condition
        ElseIf firstNumber = secondNumber Then
            Console.WriteLine("First number is equal to the Second Number")
        ElseIf firstNumber <= secondNumber Then
            Console.WriteLine("First number is Less than or equal to the Second Number")
        ElseIf firstNumber >= secondNumber Then
            Console.WriteLine("First number is Greater than or equal to the Second Number")
        ElseIf firstNumber <> secondNumber Then
            Console.WriteLine("The numbers are not equal")
        Else
            Console.WriteLine("The numbers are not greater than or less than each other.")
        End If

        Console.ReadLine()

    End Sub

End Module
