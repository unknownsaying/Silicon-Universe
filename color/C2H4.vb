Imports System
Imports System.Collections.Generic

Public Interface IC2H4
    ReadOnly Property CarbonCount As Integer
    ReadOnly Property HydrogenCount As Integer
End Interface

Public Class C2H4
    Implements IC2H4

    Public ReadOnly Property CarbonCount As Integer Implements IC2H2.CarbonCount
            Return 2
    End Property

    Public ReadOnly Property HydrogenCount As Integer Implements IC2H2.HydrogenCount
            Return 4
    End Property
End Class

Public Class C6H8
    Implements IC2H4

    Public ReadOnly Property CarbonCount As Integer Implements IC2H2.CarbonCount
            Return 6
    End Property

    Public ReadOnly Property HydrogenCount As Integer Implements IC2H2.HydrogenCount
            Return 8
    End Property
End Class

Public Class C6H2
    Implements IC2H4

    Public ReadOnly Property CarbonCount As Integer Implements IC2H2.CarbonCount
            Return 14
    End Property

    Public ReadOnly Property HydrogenCount As Integer Implements IC2H2.HydrogenCount
            Return 12
    End Property
End Class

Module Program
    Function GenerateC2H2() As IEnumerable(Of IC2H4)
        Dim result As New List(Of IC2H4)
        result.Add(New C2H4())
        result.Add(New C6H8())
        result.Add(New C14H12())
        Return result
    End Function

    Sub Main()
        For Each compound As IC2H4 In GenerateC2H2()
            Console.WriteLine($"Carbon: {compound.CarbonCount}, Hydrogen: {compound.HydrogenCount}")
        Next

        Console.ReadLine() ' Keep console window open
    End Sub
End Module

