Imports fLaSh.Dissembler
Imports System.IO
Public Class Form2

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)
        Me.Hide()
    End Sub

    Private Sub Form2_FormClosing(ByVal sender As System.Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles MyBase.FormClosing
        e.Cancel = True
    End Sub

    Private Sub Form2_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Try
            If Form1.CheckBox4.Checked = True Then
                Form1.DoThisShit(TextBox1.Text)
                MsgBox("Downloader works fine.", MsgBoxStyle.Information, "Works Perfect")
            End If
        Catch ex As Exception
            MsgBox("Error, invaild download link.", MsgBoxStyle.Critical, "Error")
            Exit Sub
        End Try
    End Sub
End Class