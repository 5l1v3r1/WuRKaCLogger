Public Class Form3

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        MessageBox.Show(TextBox1.Text, TextBox2.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        MessageBox.Show(TextBox2.Text, TextBox1.Text, MessageBoxButtons.OK, MessageBoxIcon.Error)
    End Sub

    Private Sub Form3_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub
End Class