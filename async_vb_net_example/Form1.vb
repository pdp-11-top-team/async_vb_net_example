

Public Class Form1
    Sub LongOperation()

        Threading.Thread.Sleep(5000)

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Label1.Text = "Button 1 in charge"
        Application.DoEvents()  ' needed here so that the label will update

        LongOperation()
        Label1.Text = "Button 1 finished"
    End Sub

    Private Async Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Label1.Text = "Button 2 in charge"
        Application.DoEvents()  ' needed here so that the label will update

        Await Task.Run(Sub()
                           LongOperation()
                       End Sub)

        Label1.Text = "Button 2 finished"

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Label2.Text = "it's okay!"
        Application.DoEvents()  ' needed here so that the label will update
    End Sub
End Class
