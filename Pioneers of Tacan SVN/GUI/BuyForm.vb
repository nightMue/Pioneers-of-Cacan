Imports Pioneers_of_Tacan

Public Class BuyForm
   Private _mainForm As ParentForm

   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent
      ' Add any initialization after the InitializeComponent() call.
      _mainForm = main
   End Sub

   Private Sub BuyForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
      lblClay.Text = _mainForm.localPlayer.Clay.ToString
      lblOre.Text = _mainForm.localPlayer.Ore.ToString
      lblWheat.Text = _mainForm.localPlayer.Wheat.ToString
      lblWood.Text = _mainForm.localPlayer.Wood.ToString
      lblWool.Text = _mainForm.localPlayer.Wool.ToString

      If Not (Integer.Parse(lblClay.Text) >= 1 And Integer.Parse(lblWood.Text) >= 1) Then
         btnRoad.Enabled = False
      Else
         btnRoad.Enabled = True
      End If

      If Not (Integer.Parse(lblClay.Text) >= 1 And Integer.Parse(lblWood.Text) >= 1 And Integer.Parse(lblWheat.Text) >= 1 And Integer.Parse(lblWool.Text) >= 1) Then
         btnSettlement.Enabled = False
      Else
         btnSettlement.Enabled = True
      End If

      If Not (Integer.Parse(lblOre.Text) >= 3 And Integer.Parse(lblWheat.Text) >= 2) Then
         btnCity.Enabled = False
      Else
         btnCity.Enabled = True
      End If

      If Not (Integer.Parse(lblOre.Text) >= 1 And Integer.Parse(lblWheat.Text) >= 1 And Integer.Parse(lblWool.Text) >= 1) Then
         btnDevelopmentCard.Enabled = False
      Else
         btnDevelopmentCard.Enabled = True
      End If
   End Sub

   Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
      Me.Hide()
   End Sub

   Private Sub btnRoad_Click(sender As Object, e As EventArgs) Handles btnRoad.Click
      ' hide form and show parent for user to click were to build road
      _mainForm.localPlayer.Clay -= 1
      _mainForm.localPlayer.Wood -= 1

      _mainForm.Control.SetLabels()
      Me.Hide()
   End Sub

   Private Sub btnSettlement_Click(sender As Object, e As EventArgs) Handles btnSettlement.Click
      _mainForm.localPlayer.VictoryPoints += 1
      ' hide form and show parent for user to click were to build settlement
      _mainForm.localPlayer.Clay -= 1
      _mainForm.localPlayer.Wheat -= 1
      _mainForm.localPlayer.Wool -= 1
      _mainForm.localPlayer.Wood -= 1
      _mainForm.localPlayer.numSettlements += 1

      _mainForm.Board.enablePlaceSettlements()

      _mainForm.Control.SetLabels()
      Me.Hide()
   End Sub

   Private Sub btnCity_Click(sender As Object, e As EventArgs) Handles btnCity.Click
      If (_mainForm.localPlayer.numSettlements = 0) Then
         MessageBox.Show("No settlements owned")
         Exit Sub
      End If
      _mainForm.localPlayer.VictoryPoints += 2
      ' hide form and show parent for user to click were to build city
      _mainForm.localPlayer.Ore -= 3
      _mainForm.localPlayer.Wheat -= 2

      _mainForm.Board.enablePlaceCity()

      _mainForm.Control.SetLabels()
      Me.Hide()
   End Sub

   Private Sub btnDevelopmentCard_Click(sender As Object, e As EventArgs) Handles btnDevelopmentCard.Click
      'get random Development Card and tell player and add to their deck

      'get index, card and add to players deck
      Dim Generator As System.Random = New System.Random()
      Dim cardIndex As Integer = Generator.Next(1, _mainForm.DevelopmentCards.Count)
      Dim card As DevelopmentCard = _mainForm.DevelopmentCards.Item(cardIndex)
      _mainForm.localPlayer.DevelopmentCards.Add(card)

      'remove card for game deck
      _mainForm.DevelopmentCards.RemoveAt(cardIndex)

      _mainForm.localPlayer.Ore -= 1
      _mainForm.localPlayer.Wheat -= 1
      _mainForm.localPlayer.Wool -= 1

      ' show card to player still needs to be added
      MessageBox.Show("You recived a " + card.cardType.ToString + " card!")

      If card.cardType = DevelopmentCard.Type.Knight Then
         _mainForm.localPlayer.KnightCount += 1
         _mainForm.Deck.lblKnightCount.Text = _mainForm.localPlayer.KnightCount
      ElseIf card.cardType = DevelopmentCard.Type.VP Then
         _mainForm.localPlayer.VPCount += 1
         _mainForm.Deck.lblVPCount.Text = _mainForm.localPlayer.VPCount
      ElseIf card.cardType = DevelopmentCard.Type.RoadBuilding Then
         _mainForm.localPlayer.RoadBuildingCount += 1
         _mainForm.Deck.lblRoadBuildingCount.Text = _mainForm.localPlayer.RoadBuildingCount
      ElseIf card.cardType = DevelopmentCard.Type.Discovery Then
         _mainForm.localPlayer.DiscoveryCount += 1
         _mainForm.Deck.lblDiscoveryCount.Text = _mainForm.localPlayer.DiscoveryCount
      ElseIf card.cardType = DevelopmentCard.Type.Monopoly Then
         _mainForm.localPlayer.MonopolyCount += 1
         _mainForm.Deck.lblMonopolyCount.Text = _mainForm.localPlayer.MonopolyCount
      End If
      _mainForm.Control.SetLabels()
      Me.Hide()
   End Sub
End Class