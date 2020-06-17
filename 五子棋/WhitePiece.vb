Public Class WhitePiece
    Inherits Piece
    Public Sub New(x As Integer, y As Integer)
        MyBase.New(x, y)
        Me.Image = My.Resources.white

    End Sub
End Class
