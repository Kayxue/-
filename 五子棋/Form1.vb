Public Class Form1
    Private isblack As Boolean = True
    Private board As New Board()
    Public Sub New()
        InitializeComponent()


    End Sub

    Private Sub Form1_MouseDown(sender As Object, e As MouseEventArgs) Handles MyBase.MouseDown
        If isblack Then
            Me.Controls.Add(New BlackPiece(e.X, e.Y))
            isblack = False
        Else
            Me.Controls.Add(New WhitePiece(e.X, e.Y))
            isblack = True
        End If

    End Sub

    Private Sub Form1_MouseMove(sender As Object, e As MouseEventArgs) Handles MyBase.MouseMove
        If board.CanBePlaced(e.X, e.Y) Then
            Me.Cursor = Cursors.Hand
        Else
            Me.Cursor = Cursors.Default
        End If
    End Sub
End Class
