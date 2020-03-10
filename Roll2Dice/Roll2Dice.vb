'Anthony Shore
'RCET 265
'Spring 2020
'Roll 2 Dice
'https://github.com/shoranth/AVS-VS-S20

Module Roll2Dice

    Sub Main()

        Dim diceOne As Integer
        Dim diceTwo As Integer
        Dim diceTotal As Integer = 0
        Dim diceValues(12, 2) As Integer

        'enters a number into column 1 that represents the number rolled
        For i = 2 To 12
            diceValues(i, 1) = i
        Next

        'adds a one to the total number of dice rolls made for that number
        For numberOfDiceRoll = 1 To 1000

            'generates a random number
            diceOne = Int((6 - 1 + 1) * Rnd() + 1)
            diceTwo = Int((6 - 1 + 1) * Rnd() + 1)

            'adds the two together
            diceTotal = diceOne + diceTwo

            'adds a 1 to the total contained within the array in column 2
            diceValues(diceTotal, 2) += 1
        Next

        'code that displays the table
        Console.WriteLine("1000 dice rolls are made using two dice. The results are displayed below")
        Console.WriteLine()
        Console.WriteLine("          Number Rolled       Number of Dice Rolls")

        'for loop that displays each column of the table
        For j = 2 To 12

            'nested for loop that displays the rows of the table
            For p = 1 To 2
                Console.Write(diceValues(j, p).ToString().PadLeft(15) & "|")
            Next
            Console.WriteLine()
        Next

        Console.ReadLine()

    End Sub

End Module
