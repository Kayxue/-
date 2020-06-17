Public Class BlackPiece
    Inherits Piece
    Public Sub New(x As Integer, y As Integer)
        MyBase.New(x, y)
        Me.Image = My.Resources.black


    End Sub
End Class
