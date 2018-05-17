Public Class DeckForm
   Private _mainForm As ParentForm
   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.

      SetStyle(ControlStyles.SupportsTransparentBackColor, True)
      BackColor = Color.Transparent
      _mainForm = main
   End Sub
   Public Sub reload()
      lblDiscoveryCount.Text = _mainForm.localPlayer.DiscoveryCount.ToString
      lblKnightCount.Text = _mainForm.localPlayer.KnightCount.ToString
      lblMonopolyCount.Text = _mainForm.localPlayer.MonopolyCount.ToString
      lblRoadBuildingCount.Text = _mainForm.localPlayer.RoadBuildingCount.ToString
      lblVPCount.Text = _mainForm.localPlayer.VPCount.ToString
   End Sub
End Class