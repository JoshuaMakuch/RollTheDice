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

        Dim rolls(10) As Integer 'Initializes an array conatining 11 toltal values
        Dim roll1 As Integer
        Dim roll2 As Integer
        Dim Total As Integer
        Dim random As New Random() 'Creates an instance of the random class and the new generates a new seed each run through to provide pseudo randomness

        For i As Integer = 0 To 999
            roll1 = random.Next(1, 7) 'First die roll. Also the .next generates a random integer (>= first and < second), but .NextDouble can be used to generate a random double
            roll2 = random.Next(1, 7) 'Second die roll
            Total = roll1 + roll2 'The combination of the two rolls
            rolls(Total - 2) += 1 'Increments the amount of times the total was rolled based on what the total is. (Shifted -2 to match appropriate array value)
        Next

        Console.WriteLine("Roll of The Dice".PadLeft(41)) 'Rights the roll of the dice to be centered in the console output
        Console.WriteLine("------------------------------------------------------------------") 'A divider that was calculated to be 66 characters long

        For i As Integer = 0 To 10 'Write the values from 2 to 12 and formats it
            Console.Write((i + 2).ToString().PadLeft(5) & "|")
        Next

        Console.WriteLine() 'Another Visual Divider
        Console.WriteLine("------------------------------------------------------------------")

        For i As Integer = 0 To 10 'Outputs the stored values based on the rolls array and formats them to look nice
            Console.Write(rolls(i).ToString.PadLeft(5) & "|")
        Next

        Console.WriteLine() 'A visual spacer

    End Sub
End Module
