Public Class UseCard
   Private _mainForm As ParentForm
   Private DiscoveryCard As Discovery
   Private MonopolyCard As Monopoly
   Private RoadBuildingCard As RoadBuilding
   Private KnightCard As Knight

   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()
      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent
      ' Add any initialization after the InitializeComponent() call.
      _mainForm = main
      DiscoveryCard = New Discovery
      MonopolyCard = New Monopoly
      RoadBuildingCard = New RoadBuilding
      KnightCard = New Knight
   End Sub

   Private Sub BuyForm_Activated(sender As Object, e As EventArgs) Handles Me.Activated
      If _mainForm.localPlayer.KnightCount > 0 Then
         btnKnightUse.Enabled = True
      Else
         btnKnightUse.Enabled = False
      End If
      If _mainForm.localPlayer.MonopolyCount > 0 Then
         btnMonopolyUse.Enabled = True
      Else
         btnMonopolyUse.Enabled = False
      End If
      If _mainForm.localPlayer.DiscoveryCount > 0 Then
         btnDiscoveryUse.Enabled = True
      Else
         btnDiscoveryUse.Enabled = False
      End If
      If _mainForm.localPlayer.RoadBuildingCount > 0 Then
         btnRoadBuilderUse.Enabled = True
      Else
         btnRoadBuilderUse.Enabled = False
      End If
   End Sub

   Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
      Me.Hide()
   End Sub

   Private Sub btnDiscoveryUse_Click(sender As Object, e As EventArgs) Handles btnDiscoveryUse.Click
      DiscoveryCard.setParentForm(_mainForm)
      DiscoveryCard.Play(_mainForm.localPlayer)
      _mainForm.localPlayer.DiscoveryCount -= 1
      _mainForm.Deck.lblDiscoveryCount.Text = _mainForm.localPlayer.DiscoveryCount
      Me.Hide()
   End Sub

   Private Sub btnKnightUse_Click(sender As Object, e As EventArgs) Handles btnKnightUse.Click
      KnightCard.Play(_mainForm.localPlayer)
      _mainForm.localPlayer.KnightCount -= 1
      _mainForm.Deck.lblKnightCount.Text = _mainForm.localPlayer.KnightCount
      Me.Hide()
   End Sub

   Private Sub btnRoadBuilderUse_Click(sender As Object, e As EventArgs) Handles btnRoadBuilderUse.Click
      RoadBuildingCard.Play(_mainForm.localPlayer)
      _mainForm.localPlayer.RoadBuildingCount -= 1
      _mainForm.Deck.lblRoadBuildingCount.Text = _mainForm.localPlayer.RoadBuildingCount
      Me.Hide()
   End Sub

   Private Sub btnMonopolyUse_Click(sender As Object, e As EventArgs) Handles btnMonopolyUse.Click
      MonopolyCard.Play(_mainForm.localPlayer)
      _mainForm.localPlayer.MonopolyCount -= 1
      _mainForm.Deck.lblMonopolyCount.Text = _mainForm.localPlayer.MonopolyCount
      Me.Hide()
   End Sub
End Class