'////////////////////////////////
'
'DadJoke (c) Kamikaze Software
'
'
'////////////////////////////////
Public Class DadJoke

    Private Const myFilePath As String = "C:\Ken\temp\dadjokes.txt"
    Private Shared myJokeArray As String() = System.IO.File.ReadAllLines(myFilePath)
    Private Shared myRandomGenerator As Random = New Random()

    Public Shared ReadOnly Property GetInstance As DadJoke
        Get
            Static Instance As DadJoke = New DadJoke
            Return Instance
        End Get
    End Property

    Private Sub New()
        ' prevents object creation
    End Sub

    Public Function GetJoke() As String
        Return myJokeArray(myRandomGenerator.Next(0, myJokeArray.Count))
    End Function

    Public Sub UpdateJokeFile(ByVal filePath As String, ByVal password As String)

        Try
            If password = "fred" Then
                myJokeArray = IO.File.ReadAllLines(filePath)
            End If
        Catch ex As Exception
            myJokeArray = IO.File.ReadAllLines(myFilePath)
        End Try

    End Sub


End Class
