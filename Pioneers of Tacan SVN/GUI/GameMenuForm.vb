Public Class GameMenuForm
   Private _mainForm As ParentForm

   Public Sub New(main As ParentForm)

      ' This call is required by the designer.
      InitializeComponent()

      ' Add any initialization after the InitializeComponent() call.
      _mainForm = main
   End Sub
   Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
      Me.Hide()
   End Sub

   Private Sub BtnDesktop_Click(sender As Object, e As EventArgs) Handles btnDesktop.Click
      If (GiveUp()) Then
         Environment.Exit(1)
      End If
   End Sub

   Private Sub btnMain_Click(sender As Object, e As EventArgs) Handles btnMain.Click
      If (GiveUp()) Then
         _mainForm.QuitToMenu()
      End If
   End Sub

   Private Function GiveUp() As Boolean
      'Show confirm dialog
      'Send resignation to game server
      'Return result of confirm dialog
      Return True
   End Function
End Class