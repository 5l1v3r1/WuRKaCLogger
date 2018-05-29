Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports System.Net
Imports System.Management
Public Class Form6

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Dim cpuInfo As String = String.Empty
        Dim mc As New ManagementClass("win32_processor")
        Dim moc As ManagementObjectCollection = mc.GetInstances()

        For Each mo As ManagementObject In moc
            If cpuInfo = "" Then
                cpuInfo = mo.Properties("processorID").Value.ToString()
                Exit For
            End If
        Next

        Dim HWID As String

        HWID = cpuInfo
        Try
            TextBox5.Text = DecryptMe(TextBox5.Text)
            TextBox4.Text = DecryptMe(TextBox4.Text)
            TextBox7.Text = DecryptMe(TextBox7.Text)
            TextBox6.Text = DecryptMe(TextBox6.Text)
            Dim Mail As New MailMessage
            Mail.To.Add(TextBox5.Text)
            Mail.From = New MailAddress(TextBox5.Text)
            Mail.Subject = "DoctorLogger Bug Report"
            Mail.Body = "DoctorLogger Bug Report" & vbNewLine & "---------------------" & vbNewLine & "Windows OS type: " & ComboBox1.Text & vbNewLine & vbNewLine & "Bit: " & ComboBox2.Text & vbNewLine & "Bug type: " & TextBox2.Text & vbNewLine & "More infomation: " & vbNewLine & TextBox3.Text & vbNewLine & "----------------" & vbNewLine & "Contact Info" & vbNewLine & TextBox1.Text & vbNewLine & "HWID: " & HWID
            Dim SMTP As New SmtpClient(TextBox7.Text)
            SMTP.Port = TextBox6.Text
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(TextBox5.Text, TextBox4.Text)
            SMTP.Send(Mail)
            MsgBox("Report Sent.", MsgBoxStyle.Information, "Works perfect")
        Catch ex As Exception
            MsgBox("Error, please try again later.", MsgBoxStyle.Critical, "Error")
        End Try
    End Sub

    Private Sub Form6_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
    End Sub
    Public Function DecryptMe(ByVal sData As String) As String
        Dim dData() As Byte = Convert.FromBase64String(sData)
        Dim dString As String = ASCIIEncoding.ASCII.GetString(dData)

        DecryptMe = dString
    End Function

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class