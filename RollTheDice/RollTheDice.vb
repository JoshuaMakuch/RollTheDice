'Joshua Makuch
'RCET0265
'Winter 2023
'RollTheDice
'https://github.com/JoshuaMakuch/RollTheDice.git

Option Strict On
Option Explicit On

Imports System

Module RollTheDice
    Sub Main()

        Dim rolls(11) As Integer 'Initializes an array conatining 12 toltal values
        Dim roll1 As Integer
        Dim roll2 As Integer
        Dim Total As Integer
        Dim random As New Random() 'Creates an instance of the random class and the new generates a new seed each run through to provide pseudo randomness

        For i As Integer = 0 To 999
            roll1 = random.Next(1, 7) 'First die roll. Also the .next generates a random integer, but .NextDouble can be used to generate a random double
            roll2 = random.Next(1, 7) 'Second die roll
            Total = roll1 + roll2 'The combination of the two rolls
            rolls(Total - 1) += 1 'Increments the amount of times the total was rolled based on what the total is. 
        Next

        Console.WriteLine("Roll of The Dice".PadLeft(41))
        Console.WriteLine("------------------------------------------------------------------")

        For i As Integer = 1 To 11
            Console.Write((i + 1).ToString().PadLeft(5) & "|")
        Next

        Console.WriteLine()
        Console.WriteLine("------------------------------------------------------------------")

        For i As Integer = 1 To 11
            Console.Write(rolls(i).ToString.PadLeft(5) & "|")
        Next

        Console.WriteLine()

    End Sub
End Module
