Imports System.Net.Sockets
Imports System.Threading

Public Class ServerThread
   Private client As TcpClient
   Private listener As Thread
   Private IOStream As NetworkStream
   Friend done As Boolean = False
   Private readBuf(500) As Byte

   Public Sub New(cl As TcpClient)
      client = cl
      IOStream = cl.GetStream()
   End Sub

   Public Event MsgRecieved(msg As String)

   Public Sub Run()
      While Not (done)
         If (IOStream.DataAvailable) Then
            IOStream.Read(readBuf, 0, readBuf.Length)
            Dim msg As String = System.Text.Encoding.ASCII.GetString(readBuf)
            RaiseEvent MsgRecieved(msg)
         End If
      End While

      IOStream.Close()
      client.Dispose()
      client.Close()
   End Sub

   Public Sub sendMsg(msg As String)
      Dim msgBuf = System.Text.Encoding.ASCII.GetBytes(msg)
      IOStream.Write(msgBuf, 0, msgBuf.Length)
   End Sub
End Class
