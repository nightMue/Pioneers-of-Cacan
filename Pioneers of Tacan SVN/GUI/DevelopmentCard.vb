Public MustInherit Class DevelopmentCard
   Public Enum Type
      Knight
      VP
      RoadBuilding
      Monopoly
      Discovery
   End Enum

   Public cardType

   Public MustOverride Sub Play(localPlayer As Player)
End Class

Public Class Knight
   Inherits DevelopmentCard

   Public Sub New()
      cardType = DevelopmentCard.Type.Knight
   End Sub

   Public Overrides Sub Play(localPlayer As Player)
      'player may move the robber and take a resource at random from a player touching the new robber hex
      ' knight card is added to your army count
      localPlayer.ArmySize += 1
      MessageBox.Show("You army has increased to " + localPlayer.ArmySize.ToString)
   End Sub
End Class

Public Class VP
   Inherits DevelopmentCard

   Public Sub New()
      cardType = DevelopmentCard.Type.VP
   End Sub

   Public Overrides Sub Play(localPlayer As Player)
      'do nothing
      'increment players total VP count
      localPlayer.VPCount += 1
   End Sub
End Class

Public Class RoadBuilding
   Inherits DevelopmentCard

   Public Sub New()
      cardType = DevelopmentCard.Type.RoadBuilding
   End Sub

   Public Overrides Sub Play(localPlayer As Player)
      'allows player to place 2 roads without using recources
   End Sub
End Class

Public Class Monopoly
   Inherits DevelopmentCard
   Private playerForm As MonopolyPlayForm

   Public Sub New()
      cardType = DevelopmentCard.Type.Monopoly
      playerForm = New MonopolyPlayForm
   End Sub

   Public Overrides Sub Play(localPlayer As Player)
      'allows player to take all of one kind of recource from the other players
      playerForm.player = localPlayer
      playerForm.Show()
      playerForm.BringToFront()
   End Sub
End Class

Public Class Discovery
   Inherits DevelopmentCard
   Private bankForm As DiscoveryPlayForm

   Public Sub New()
      cardType = DevelopmentCard.Type.Discovery
      bankForm = New DiscoveryPlayForm()
   End Sub

   Public Overrides Sub Play(localPlayer As Player)
      'allows player to recive two recources of any kind from bank
      bankForm.player = localPlayer
      bankForm.Show()
      bankForm.BringToFront()
   End Sub

   Public Sub setParentForm(main As ParentForm)
      bankForm._mainForm = main
   End Sub
End Class
