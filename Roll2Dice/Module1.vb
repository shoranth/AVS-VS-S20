Module Module1

    Sub Main()

        Dim diceOne As Integer
        Dim diceTwo As Integer
        Dim diceTotal As Integer
        Dim diceValues(12, 2) As Integer
        'Dim twosCount As Integer
        'Dim threesCount As Integer
        'Dim foursCount As Integer
        'Dim fivesCount As Integer
        'Dim sixsCount As Integer
        'Dim sevensCount As Integer
        'Dim eightsCount As Integer
        'Dim ninesCount As Integer
        'Dim tensCount As Integer
        'Dim elevensCount As Integer
        'Dim twelvesCount As Integer


        For numberOfDiceRoll = 1 To 10
            diceOne = Int((6 - 1 + 1) * Rnd() + 1)
            diceTwo = Int((6 - 1 + 1) * Rnd() + 1)
            diceTotal = diceOne + diceTwo

            Console.WriteLine(diceTotal)

            diceValues(diceTotal, 2) += 1
            diceValues(diceTotal, 3) += 1
            diceValues(diceTotal, 4) += 1
            diceValues(diceTotal, 5) += 1
            diceValues(diceTotal, 6) += 1
            diceValues(diceTotal, 7) += 1
            diceValues(diceTotal, 8) += 1
            diceValues(diceTotal, 9) += 1
            diceValues(diceTotal, 10) += 1
            diceValues(diceTotal, 11) += 1
            diceValues(diceTotal, 12) += 1


        Next

        Console.WriteLine(diceValues(12, 2))

        Console.ReadLine()

    End Sub

End Module
