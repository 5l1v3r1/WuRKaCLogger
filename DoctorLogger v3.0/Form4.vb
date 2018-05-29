Public Class Form4

    Private Sub Form4_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Hide()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        OpenFileDialog1.DefaultExt = "ico"
        OpenFileDialog1.Filter = "icon files (*.ico)|*.ico"
        OpenFileDialog1.FilterIndex = 1
        If OpenFileDialog1.ShowDialog(Me) = DialogResult.OK Then
            TextIcon.Text = String.Empty
            TextIcon.Text = OpenFileDialog1.FileName
        End If
    End Sub

    Private Sub CheckBox1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.Click
        If CheckBox1.Checked = True Then
            TextIcon.Enabled = True
            Button5.Enabled = True
        Else
            TextIcon.Enabled = False
            Button5.Enabled = False
        End If
    End Sub

    Private Sub Form4_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class