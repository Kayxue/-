Public Class Piece
    Inherits PictureBox

    Private ReadOnly IMAGE_WIDTH As Integer = 50
    Public Sub New(x As Integer, y As Integer)
        Me.BackColor = Color.Transparent
        Me.Location = New Point(x - IMAGE_WIDTH / 2, y - IMAGE_WIDTH / 2)
        Me.Size = New Size(IMAGE_WIDTH, IMAGE_WIDTH)
    End Sub
End Class
