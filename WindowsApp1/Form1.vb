Imports myIO = System.IO

Public Class Form1
    Private Const dialogtitle As String = "Open File Dialog"
    Private Const fileDefault As String = "C:\Ken\temp"
    Private Const filter As String = "Text files (*.txt*)|*.txt*"
    Private Const filterIndex As Integer = 1
    Private Const pwd As String = "fred"

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim myDadJoke As DadJoke = DadJoke.GetInstance
        RichTextBox1.Text = myDadJoke.GetJoke()
        myDadJoke = Nothing

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = dialogtitle
        fd.InitialDirectory = fileDefault
        fd.Filter = filter
        fd.FilterIndex = filterIndex
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim myDadJoke As DadJoke = DadJoke.GetInstance
            myDadJoke.UpdateJokeFile(fd.FileName, pwd)
            myDadJoke = Nothing
        End If

    End Sub
End Class
