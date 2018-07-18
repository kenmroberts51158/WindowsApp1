Imports myIO = System.IO

Public Class Form1
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        MsgBox("hello world")

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click

        Dim quoteArray As String() = myIO.File.ReadAllLines("C:\Ken\dadjokes.txt")
        RichTextBox1.Text = quoteArray(GetRandom(0, quoteArray.Count))

    End Sub

    Public Function GetRandom(ByVal Min As Integer, ByVal Max As Integer) As Integer

        Dim myRandomGenerator As Random = New Random()
        Return myRandomGenerator.Next(Min, Max)

    End Function

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim myDadJoke As DadJoke = DadJoke.GetInstance
        RichTextBox1.Text = myDadJoke.GetJoke()
        myDadJoke = Nothing

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\Ken"
        fd.Filter = "Text files (*.txt*)|*.txt*|All files (*.*)|*.*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim myDadJoke As DadJoke = DadJoke.GetInstance
            myDadJoke.UpdateJokeFile(fd.FileName, "fred")
            myDadJoke = Nothing
        End If
    End Sub
End Class
