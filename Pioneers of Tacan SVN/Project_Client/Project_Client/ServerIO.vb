Imports System.Net.Sockets
Imports System.Threading

Public Class ServerIO
   Private serverStream As NetworkStream
   Private listener As Thread
   Private stopListening As Boolean
   Private readBuf(500) As Byte
   'Private 
   Private chatHeader = "ch|"
   Private gameStateHeader = "gs|"
   Private tradeHeader = "tr|"

   Public Sub New(serverStream As NetworkStream)
      Me.serverStream = serverStream
      stopListening = False
      listener = New Thread(AddressOf Listen)
   End Sub

   Public Event ChatReceived(msg As String)

   Private Sub Listen()
      While Not (stopListening)
         If (serverStream.DataAvailable) Then
            serverStream.Read(readBuf, 0, readBuf.Length)
            Dim msg As String = readBuf.ToString()
            HandleMsg(msg)
         End If
      End While
   End Sub

   Private Sub HandleMsg(msg As String)
      If (msg.StartsWith(chatHeader)) Then
         msg.TrimStart(chatHeader)
         RaiseEvent ChatReceived(msg)
      ElseIf (msg.StartsWith(gameStateHeader)) Then

      ElseIf (msg.StartsWith(tradeHeader)) Then

      End If
   End Sub

   Public Sub sendChat(chat As String)
      Dim msg As String = chatHeader & chat

   End Sub
End Class
