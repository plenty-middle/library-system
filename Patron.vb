' Patron.vb

Public Class Patron
    Public Property PatronId As Integer
    Public Property Name As String
    Public Property Email As String

    Public Sub DisplayInfo()
        Console.WriteLine($"Patron ID: {PatronId}")
        Console.WriteLine($"Name: {Name}")
        Console.WriteLine($"Email: {Email}")
    End Sub
End Class
