Imports System.Console

Module Program
    Sub Main()
        Dim month, dat, year, maxdays As Integer
        WriteLine("input date (DD/MM/YYYY)")
        dat = ReadLine()
        month = ReadLine()
        year = ReadLine()
        Select Case month
            Case 1, 3, 5, 7, 8, 10, 12
                maxdays = 31
            Case 4, 6, 9, 11
                maxdays = 30
            Case 2
                maxdays = 28
            Case Else
                WriteLine("month not exist")



        End Select

        If dat < maxdays + 1 And month < 13 And year < 2025 Then
        ElseIf year = 2024 And month < 10 Then

            WriteLine("valid date")
        Else
            WriteLine("invalid date ")

        End If
        ReadLine()
    End Sub
End Module
