Imports myIO = System.IO

Public Class Form1

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click

        Dim myDadJoke As DadJoke = DadJoke.GetInstance
        RichTextBox1.Text = myDadJoke.GetJoke()
        myDadJoke = Nothing

    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim fd As OpenFileDialog = New OpenFileDialog()

        fd.Title = "Open File Dialog"
        fd.InitialDirectory = "C:\Ken\temp"
        ''fd.Filter = "Text files (*.txt*)|*.txt*|All files (*.*)|*.*"
        fd.Filter = "Text files (*.txt*)|*.txt*"
        fd.FilterIndex = 2
        fd.RestoreDirectory = True

        If fd.ShowDialog() = DialogResult.OK Then
            Dim myDadJoke As DadJoke = DadJoke.GetInstance
            myDadJoke.UpdateJokeFile(fd.FileName, "fred")
            myDadJoke = Nothing
        End If

    End Sub
End Class
