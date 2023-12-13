' LibrarySystem.vb

Module LibrarySystem
    Sub Main()
        ' Create books
        Dim book1 As New Book With {.BookId = 1, .Title = "Introduction to VB.NET", .Author = "John Doe"}
        Dim book2 As New Book With {.BookId = 2, .Title = "Advanced VB.NET Programming", .Author = "Jane Smith"}

        ' Create patrons
        Dim patron1 As New Patron With {.PatronId = 101, .Name = "Alice", .Email = "alice@example.com"}
        Dim patron2 As New Patron With {.PatronId = 102, .Name = "Bob", .Email = "bob@example.com"}

        ' Create transactions
        Dim transaction1 As New Transaction With {.TransactionId = 1001, .Book = book1, .Patron = patron1}
        Dim transaction2 As New Transaction With {.TransactionId = 1002, .Book = book2, .Patron = patron2}

        ' Display information
        Console.WriteLine("Transaction Information:")
        transaction1.DisplayInfo()
        Console.WriteLine()
        transaction2.DisplayInfo()
    End Sub
End Module
