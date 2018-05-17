Imports System.Net
Imports System.Net.Sockets
Imports System.Text
Imports System.Text.RegularExpressions
Imports System.Threading
Imports System.Threading.Tasks
Imports Pioneers_of_Tacan

Public Class ServerGUI
   Private Delegate Sub UpdateTextBoxDelegate(t As TextBox, msg As String)
   Private _updateTextBox As UpdateTextBoxDelegate = AddressOf UpdateTextBox

   Private port As Int32 = 5000
   'Private port2 As Int32 = 5002
   'Private port3 As Int32 = 5003
   'Private port4 As Int32 = 5004

   Private tcp As TcpListener
   'Private tcp2 As TcpListener
   'Private tcp3 As TcpListener
   'Private tcp4 As TcpListener

   Private numOfPlayers As Integer = 0
   Public gameStart = False
   Private tcpActive As Boolean = False
   Private threadStop As Boolean = False
   Public Property MainForm As Form

   Private Sub start()
      Dim dummyThread = New Thread(
      Sub()
         Dim ipUsed As IPAddress
         ipUsed = IPAddress.Any
         tcp = New TcpListener(ipUsed, port)
         tcp.Start()
         tcpActive = True
         Dim host As String = System.Net.Dns.GetHostName()
         Dim IP As String = System.Net.Dns.GetHostEntry(host).AddressList(1).ToString()
         UpdateTextBox(txtLog, "Waiting for connections on..." + vbNewLine + "IP Address: " + IP + vbNewLine + "Port: " + port.ToString)
         While Not gameStart And numOfPlayers < 4
            Try
               Dim client As TcpClient = tcp.AcceptTcpClient()
               'UpdatePlayers(1)
               numOfPlayers += 1
               'Console.WriteLine(numOfPlayers.ToString)
               Dim player As Player = New Player(client, numOfPlayers)
               UpdateTextBox(txtLog, "Player " + player.playerNum.ToString + " Connected.")
               UpdateTextBox(txtLog, numOfPlayers.ToString + "/4 Players Connected.")

               If (threadStop) Then
                  If tcpActive Then
                     tcp.Stop()
                     For Each i In Player.clients
                        i.Dispose()
                        i.Close()
                     Next
                  End If
                  Exit While
               End If
            Catch ex As Exception
               'UpdateTextBox(ex.ToString())
            End Try
         End While
      End Sub)

      dummyThread.Start()
   End Sub

   Private Sub LogText(str As String)
      txtLog.AppendText(str + vbCrLf)
   End Sub

   Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnBack.Click
      threadStop = True

      Me.Hide()
      MainForm.Show()
   End Sub



   Private Sub UpdateTextBox(t As TextBox, msg As String)
      If (txtLog.InvokeRequired) Then
         txtLog.Invoke(_updateTextBox, t, msg)
      Else
         txtLog.AppendText(msg + vbCrLf)
         txtLog.Update()
      End If
   End Sub

   Private Sub ServerGUI_shown(sender As Object, e As EventArgs) Handles MyBase.Shown
      threadStop = False
   End Sub

   Private Sub ServerGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      start()
   End Sub

   Private Sub btnGameStart_Click(sender As Object, e As EventArgs) Handles btnGameStart.Click
      Dim pForm = New Pioneers_of_Tacan.ParentForm
      Me.Hide()
      pForm.Show()
   End Sub
End Class

Public Class Player
   Public Shared clients As New List(Of TcpClient)

   Public playerNum As Integer
   Public playerName As String

   Sub New(client As TcpClient, pNum As Integer)
      clients.Add(client)
      playerNum = pNum
   End Sub
End Class