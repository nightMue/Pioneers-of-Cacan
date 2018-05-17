Imports Pioneers_of_Tacan
Imports System.Threading
Public Class StartForm

   Private startThread As Thread
   Private _frmClient As ConnectForm
   Private _frmServer As ServerGUI

   Public Sub New()
      InitializeComponent()
   End Sub

   Private Sub btnHost_Click(sender As Object, e As EventArgs) Handles btnHost.Click

      _frmServer = New ServerGUI With {.MainForm = Me}
      _frmClient = New ConnectForm With {.MainForm = Me}
      Me.Hide()
      _frmServer.Show()
      _frmClient.isHost = True
      _frmClient.Show()
      _frmClient.Hide()
      'startThread = New Thread(AddressOf StartHost)
      'startThread.Start()
      'Me.Hide()
   End Sub

   'Private Sub StartHost()
   '   Application.Run(_frmServer)
   'End Sub

   Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click

      _frmClient = New ConnectForm With {.MainForm = Me}
      Me.Hide()
      _frmClient.Show()
   End Sub

   'Private Sub StartClient()
   '   Application.Run(_frmClient)
   'End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
      Environment.Exit(1)
   End Sub
End Class