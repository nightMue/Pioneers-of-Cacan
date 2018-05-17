Imports Pioneers_of_Tacan.gameboard

Public Class Intersect
    Inherits BoardPoint

   'Public Enum BuildingType
   '    Settlement
   '    City
   'End Enum

   'Private road As PlayerColor
   'Private building As PlayerColor

   'Public Sub New()
   '    road = PlayerColor.Unclaimed
   '    building = PlayerColor.Unclaimed
   'End Sub

   Public Enum BuildingColor
      None
      Orange
      Blue
      White
      Green
      Red
      Brown
   End Enum

   Public Enum BuildingType
      None
      Settlement
      City
   End Enum

   Private ownerColor As BuildingColor
   Private type As BuildingType
   Private adjacentPoints As List(Of Intersect)
   Private adjacentHexes As List(Of HexTile)

   Public Sub New()
      type = BuildingType.None
      ownerColor = BuildingColor.None
   End Sub

   Public Sub CollectResources(rollValue As Integer, ByRef resources() As Integer)
      For Each h As HexTile In adjacentHexes
         If (h.Value = rollValue) Then
            Dim type As Integer = h.Type
            resources(type) += 1
         End If
      Next
   End Sub

End Class
