Public Class Board
    Private ReadOnly NO_MATCH_NODE As New Point(-1, -1)

    Private ReadOnly OFFSET As Integer = 75
    Private ReadOnly NODE_RADIUS As Integer = 10
    Private ReadOnly NODE_DISTRANCE As Integer = 75
    Public Function CanBePlaced(x As Integer, y As Integer) As Boolean
        Dim nodeId As New Point()
        nodeId = FindTheClosetNode(x, y)
        If nodeId = NO_MATCH_NODE Then
            Return False
        End If

        Return True
    End Function

    Private Function FindTheClosetNode(x As Integer, y As Integer) As Point
        Dim nodeIdX As Integer = FindTheClosetNode(x)
        If nodeIdX = -1 Then
            Return NO_MATCH_NODE
        End If

        Dim nodeIdY As Integer = FindTheClosetNode(y)
        If nodeIdY = -1 Then
            Return NO_MATCH_NODE
        End If

        Return New Point(nodeIdX, nodeIdY)
    End Function

    Private Function FindTheClosetNode(pos As Integer) As Integer
        If pos < OFFSET - NODE_RADIUS Then
            Return -1
        End If

        pos = pos - OFFSET

        Dim quotient As Integer = pos / NODE_DISTRANCE
        Dim remainder As Integer = pos Mod NODE_DISTRANCE

        If remainder <= NODE_RADIUS Then
            Return quotient
        ElseIf remainder >= NODE_DISTRANCE - NODE_RADIUS Then
            Return quotient + 1
        Else
            Return -1
        End If
    End Function

End Class
