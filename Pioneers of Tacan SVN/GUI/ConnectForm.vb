Imports System.Net
Imports System.Net.Sockets
Imports System.Threading
Imports System.Threading.Tasks
Imports System.Text.RegularExpressions
Imports Pioneers_of_Tacan

Public Class ConnectForm

   Private Delegate Sub DisableButtonDelegate()
   Private Delegate Function CheckStringsDelegate()
   Private Delegate Sub LogUpdateDelegate(update As String)

   Private DisableButtons As DisableButtonDelegate
   Private CheckStrings As CheckStringsDelegate
   Private LogUpdate As LogUpdateDelegate

   Private ipAddress As String
   Private port As Integer
   Private _host As Boolean = False
   Dim tcp As New TcpClient
   Private connected As Boolean = False

   Public WriteOnly Property isHost As Boolean
      Set(value As Boolean)
         _host = value
      End Set
   End Property

   Public Property MainForm As Form
   Private Sub btnJoin_Click(sender As Object, e As EventArgs) Handles btnJoin.Click
      join()
   End Sub

   Private Sub join()
      ipAddress = txtIPAddress.Text
      port = txtPort.Text
      Dim dummyThread = New Thread(
      Sub()
         Try
            If Me.Invoke(CheckStrings) Then
               Me.Invoke(LogUpdate, "Please enter a valid IP and Port.")
            Else
               tcp.Connect(ipAddress, port)
               Me.Invoke(DisableButtons)
               Me.Invoke(LogUpdate, "Connection Successful.")
               Me.Invoke(LogUpdate, "Game will begin when all players have connected.")
               connected = True
            End If
         Catch ex As Exception
            Console.WriteLine(ex.ToString)
            Me.Invoke(LogUpdate, "Please enter a valid IP and Port.")
         End Try
      End Sub)
      dummyThread.Start()
   End Sub

   Private Sub disable()
      txtIPAddress.Enabled = False
      txtPort.Enabled = False
      btnJoin.Enabled = False
   End Sub

   Private Function check() As Boolean
      If Not Regex.Match(txtPort.Text, "^\d+$").Success Then
         Return True
      ElseIf txtIPAddress.TextLength = 0 Or txtPort.TextLength = 0 Then
         Return True
      Else
         Return False
      End If
   End Function

   Private Sub ClientForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
      DisableButtons = AddressOf disable
      CheckStrings = AddressOf check
      LogUpdate = AddressOf Log_Update
      If _host Then
         txtIPAddress.Text = "127.0.0.1"
         txtPort.Text = "5000"
         join()
         'Dim p = New Player(tcp)
         'p.startGame()

      End If
   End Sub

   Private Sub Log_Update(update As String)
      txtLog.AppendText(update + vbCrLf)
   End Sub

   Private Sub btnBack_Click(sender As Object, e As EventArgs) Handles btnBack.Click
      If connected Then
         tcp.Close()
      End If
      Me.Hide()
      MainForm.Show()
   End Sub
End Class
