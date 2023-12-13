' Transaction.vb

Public Class Transaction
    Public Property TransactionId As Integer
    Public Property Book As Book
    Public Property Patron As Patron

    Public Sub DisplayInfo()
        Console.WriteLine($"Transaction ID: {TransactionId}")
        Book.DisplayInfo()
        Patron.DisplayInfo()
    End Sub
End Class
