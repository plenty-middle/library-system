' Book.vb

Public Class Book
    Public Property BookId As Integer
    Public Property Title As String
    Public Property Author As String

    Public Sub DisplayInfo()
        Console.WriteLine($"Book ID: {BookId}")
        Console.WriteLine($"Title: {Title}")
        Console.WriteLine($"Author: {Author}")
    End Sub
End Class
