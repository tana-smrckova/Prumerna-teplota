Option Strict On
Imports System

Module Program
    Sub Main()
        Console.Write("Teplota namìøená v 8:00 hod byla: ")
        Dim Teplota1 As String = Console.ReadLine()
        Console.Write("Teplota namìøená v 12:00 hod byla: ")
        Dim Teplota2 As String = Console.ReadLine()
        Console.Write("Teplota namìøená v 18:00 hod byla: ")
        Dim Teplota3 As String = Console.ReadLine()
        Dim TeplotaPrumer As Double = (CInt(Teplota1) + CInt(Teplota2) + CInt(Teplota3)) / 3
        Console.WriteLine("Prùmìrná teplota za dnešní den je: " & TeplotaPrumer)
    End Sub
End Module
