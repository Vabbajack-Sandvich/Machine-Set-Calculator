Public Class Form2
    Private Sub Form2_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Form2_Closed(sender As Object, e As EventArgs) Handles Me.Closed
        Form1.Show()
    End Sub

    Private Sub Form2_Shown(sender As Object, e As EventArgs) Handles Me.Shown
        Me.TopMost = True
        Me.TopMost = False
        Me.TopMost = True
    End Sub
End Class