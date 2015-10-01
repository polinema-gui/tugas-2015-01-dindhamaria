Public Class Form1

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If Me.BackColor = Color.Purple Then
            Me.BackColor = Color.AntiqueWhite
        Else
            Me.BackColor = Color.Purple
        End If
    End Sub
End Class
