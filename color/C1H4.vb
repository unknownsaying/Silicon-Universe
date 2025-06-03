Imports System
Imports System.Collections.Generic

Public Interface IC1H4
    ReadOnly Property CarbonCount As Integer
    ReadOnly Property HydrogenCount As Integer
End Interface

Public Class C1H4
    Implements IC1H4

    Public ReadOnly Property CarbonCount As Integer Implements IC1H4.CarbonCount
            Return 1
    End Property

    Public ReadOnly Property HydrogenCount As Integer Implements IC1H4.HydrogenCount
            Return 4
    End Property
End Class

Public Class C5H8
    Implements IC1H4

    Public ReadOnly Property CarbonCount As Integer Implements IC1H4.CarbonCount
            Return 5
    End Property

    Public ReadOnly Property HydrogenCount As Integer Implements IC1H4.HydrogenCount
            Return 8
    End Property
End Class

Public Class C13H24
    Implements IC1H4

    Public ReadOnly Property CarbonCount As Integer Implements IC1H4.CarbonCount
            Return 13
    End Property

    Public ReadOnly Property HydrogenCount As Integer Implements IC1H4.HydrogenCount
            Return 24
    End Property
End Class

Module Program
    Function GenerateC2H2() As IEnumerable(Of IC1H4)
        Dim result As New List(Of IC1H4)
        result.Add(New C1H4())
        result.Add(New C5H8())
        result.Add(New C13H24())
        Return result
    End Function

    Sub Main()
        For Each compound As IC1H4 In GenerateC2H2()
            Console.WriteLine($"Carbon: {compound.CarbonCount}, Hydrogen: {compound.HydrogenCount}")
        Next

        Console.ReadLine() ' Keep console window open
    End Sub
End Module
