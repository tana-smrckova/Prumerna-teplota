Option Strict On
Imports System

Module Program
    Sub Main()
        Console.Write("Teplota nam��en� v 8:00 hod byla: ")
        Dim Teplota1 As String = Console.ReadLine()
        Console.Write("Teplota nam��en� v 12:00 hod byla: ")
        Dim Teplota2 As String = Console.ReadLine()
        Console.Write("Teplota nam��en� v 18:00 hod byla: ")
        Dim Teplota3 As String = Console.ReadLine()
        Dim TeplotaPrumer As Double = (CInt(Teplota1) + CInt(Teplota2) + CInt(Teplota3)) / 3
        Console.WriteLine("Pr�m�rn� teplota za dne�n� den je: " & TeplotaPrumer)
    End Sub
End Module
