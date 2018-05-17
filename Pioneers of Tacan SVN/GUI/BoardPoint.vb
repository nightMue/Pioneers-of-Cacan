Public MustInherit Class BoardPoint
   Public Enum PointType
      Ocean     '0
      Intersect '1
      Desert    '2
      Clay      '3
      Ore       '4
      Wheat     '5
      Wood      '6
      Wool      '7
      'Uninitialized hex tile
      Uninitialized '8
   End Enum

   Public Enum ResourceType
      Clay
      Ore
      Wheat
      Wood
      Wool
   End Enum

   Public Function IsAdjacent() As Boolean
        Return True
    End Function

End Class
