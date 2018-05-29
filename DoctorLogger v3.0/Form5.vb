Public Class Form5
#Region " Global Variables "
    Dim Point As New System.Drawing.Point()
    Dim X, Y As Integer
#End Region

#Region " GUI "
    Private Sub Main_MouseMove(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseMove
        If e.Button = MouseButtons.Left Then
            Point = Control.MousePosition
            Point.X = Point.X - (X)
            Point.Y = Point.Y - (Y)
            Me.Location = Point
        End If
    End Sub
    Private Sub Main_MouseDown(ByVal sender As System.Object, ByVal e As System.Windows.Forms.MouseEventArgs) Handles MyBase.MouseDown
        X = Control.MousePosition.X - Me.Location.X
        Y = Control.MousePosition.Y - Me.Location.Y
    End Sub

#End Region
    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
    End Sub

    Private Sub Form5_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

    End Sub

    Private Sub RichTextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles RichTextBox1.TextChanged

    End Sub
End Class