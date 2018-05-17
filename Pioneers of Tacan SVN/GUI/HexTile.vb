Imports Pioneers_of_Tacan.gameboard

Public Class HexTile
    Inherits BoardPoint

   'Public ReadOnly ResourceType As PointType

   'Public ReadOnly Value As Integer

   'Public Sub New(ByVal type As PointType, ByVal val As Integer)
   '    ResourceType = type
   '    Value = val
   'End Sub

   Public Property HasRobber As Boolean

   Public ReadOnly Property Type As ResourceType

   Private _value As Integer
   Public ReadOnly Property Value As Integer
      Get
         If (HasRobber) Then
            Return 0
         Else
            Return _value
         End If
      End Get
   End Property

   Public Sub New(ByVal type As PointType, ByVal val As Integer)
      type = type
      _value = val
      HasRobber = False
   End Sub
End Class
