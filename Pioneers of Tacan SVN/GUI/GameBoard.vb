Imports Pioneers_of_Tacan.BoardPoint

Public Class gameboard
    Private Shared r1() As PointType = {0, 0, 0, 1, 0, 1, 0, 1, 0, 0, 0}
    Private Shared r2() As PointType = {0, 0, 1, 8, 1, 8, 1, 8, 1, 0, 0}
    Private Shared r3() As PointType = {0, 1, 8, 1, 8, 1, 8, 1, 8, 1, 0}
    Private Shared r4() As PointType = {1, 8, 1, 8, 1, 8, 1, 8, 1, 8, 1}

    Private Shared defaultTileTypes(19) As PointType
    Private Shared defaultTileVals(19) As Integer

    Private gridPoints()() As PointType
    Private tiles(19) As HexTile

    Private boardPoints()() As BoardPoint

    Public Enum PlayerColor
        Unclaimed
        Orange
        Blue
        White
        Green
        Red
        Brown
    End Enum

    Public Sub New()
        r1.CopyTo(gridPoints(1), r1.Length)
        r2.CopyTo(gridPoints(2), r2.Length)
        r2.CopyTo(gridPoints(3), r2.Length)
        r3.CopyTo(gridPoints(4), r3.Length)
        r3.CopyTo(gridPoints(5), r3.Length)
        r4.CopyTo(gridPoints(6), r4.Length)
        r4.CopyTo(gridPoints(7), r4.Length)
        r3.CopyTo(gridPoints(8), r3.Length)
        r3.CopyTo(gridPoints(9), r3.Length)
        r2.CopyTo(gridPoints(10), r2.Length)
        r2.CopyTo(gridPoints(11), r2.Length)
        r1.CopyTo(gridPoints(12), r1.Length)

        initTiles(defaultTileTypes, defaultTileVals)
        generateBoard(tiles)
    End Sub

    Private Sub generateBoard(tiles() As HexTile)
        Dim tileCounter = 0
        Dim tileIndex = 0
        For j = 0 To 10
            For i = 0 To 11
                If (gridPoints(j)(i) = 8) Then
                    boardPoints(j)(i) = tiles(tileIndex)
                    tileIndex = ++tileCounter / 2
                Else
                    boardPoints(j)(i) = New Intersect()
                End If
            Next
        Next
    End Sub

    Private Sub initTiles(types() As PointType, vals() As Integer)
        For i = 0 To 18
            tiles(i) = New HexTile(types(i), vals(i))
        Next
    End Sub

End Class