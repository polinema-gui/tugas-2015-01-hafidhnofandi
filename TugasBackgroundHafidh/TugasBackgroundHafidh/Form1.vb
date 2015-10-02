Public Class Form1

    Private Sub GantiButton_Click(sender As Object, e As EventArgs) Handles GantiButton.Click
        If Me.BackColor = Color.Blue Then
            Me.BackColor = Color.Pink
        Else
            Me.BackColor = Color.Blue

        End If
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.BackColor = Color.Blue
    End Sub
End Class
