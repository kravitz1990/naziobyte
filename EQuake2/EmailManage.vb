Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Mail
Imports System.Threading
Imports System.IO
Imports System.Security.AccessControl


Public Class EmailManage

 
    Dim connType As String = ""
    Dim td As Thread
    Public sm As New SmtpClient
    Dim mail As New MailMessage
    Dim maxEmail As Integer = 100

    Private Sub EmailManage_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        'saveList()
    End Sub

    Private Sub EmailManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        'โปรดอ่าน
        'จำเป็นต้องใช้อีเมลรวมไปถึงรหัสผ่านส่วนตัวของท่านในการเข้าสู่ระบบเพื่อให้สามารถส่งข้อมูลต่อไปยังบุคคลอื่นได้
        'ซึ่งระบบนี้อาจดูเหมือนเป็นการจงใจขโมยบัญชีของผู้อื่น แต่ทางเราไม่มีนโยบายที่จะเก็บบันทึกหรือนำข้อมูลของท่านไปใช้ประโยชน์ใดๆ หากบัญชีอีเมลของท่านเกิดได้รับความเสียหายทางเราจะไม่รับผิดชอบใด ๆ ทุกกรณี เพื่อคลายข้อกังวลแนะนำโปรดสมัครอีเมลสำรองใหม่หรือปฏิเสธข้อตกลงนี้

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click




        If txtUser.Text = "" Or txtPass.Text = "" Then

            MsgBox("โปรดป้อนชื่อและรหัสก่อนเข้าใช้งาน", MsgBoxStyle.Critical, "ผิดพลาด")

        Else
            MassMailCreate()

            Button2.Enabled = False
            txtUser.ReadOnly = True
            txtPass.ReadOnly = True
            Me.Cursor = Cursors.WaitCursor
            ComboBox1.Enabled = False
            SendMailThread()

        End If


    End Sub


    Private Sub SendMailThread()

        Try

            sm.Credentials = New Net.NetworkCredential(txtUser.Text, txtPass.Text)
            mail = New MailMessage
            mail.From = New MailAddress(txtUser.Text)
            mail.To.Add(txtUser.Text)
            mail.Subject = "Confirm login credential!"
            mail.Body = "EarthQuake Realtime Checker " & My.Application.Info.Version.ToString & vbCrLf & "--------------------------------------------" & vbCrLf & "login success : (In Good standing)"
            sm.Send(mail)

            MsgBox("เข้าสู่ระบบสำเร็จ", MsgBoxStyle.Information, "              ")
            showInterfacelogin(True)
            saveMailProfile(True)
            mailAccept = "Yes"
            frmConfig.ApplySetting()
            iSaveSettingAsync()

        Catch ex As Exception

            Console.WriteLine(ex.Message)

            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf SendMailThread))
            Else

                MsgBox("ไม่สามารถเข้าสู่ระบบได้", MsgBoxStyle.Critical, "               ")
                mailAccept = "No"
                UnblobkSomeThing2()
                Me.Cursor = Cursors.Default
                saveMailProfile(False)


            End If
        End Try

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MsgBox("คุณแน่ใจหรือว่าต้องการออกจากระบบ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "           ") = MsgBoxResult.Yes Then

            showInterfacelogin(False)
            frmConfig.ApplySetting()
            mailAccept = "No"
            iSaveSettingAsync()
            saveMailProfile(False)

        End If

    End Sub


    Private Sub UnblobkSomeThing()

        txtUser.ReadOnly = False
        txtPass.ReadOnly = False
        txtUser.Text = ""
        txtPass.Text = ""
        Button2.Enabled = True
        Button3.Enabled = False
        'oServer.User = Nothing
        'oServer.Password = Nothing
        txtDisable.Visible = True
        listMail.Visible = False
        btnAdd.Visible = False
        btnsave.Visible = False
        btnRemove.Visible = False
        ComboBox1.Enabled = True
        ComboBox1.Enabled = True
        isSendEmailMessage = False
        mailUser = Nothing
        mailPassword = Nothing
        frmConfig.txtgetMail.Text = "None"
        frmConfig.txtgetDateMail.Text = "None"
        frmConfig.txtCountSenderMail.Text = "None"
        frmConfig.txtRitcher.Text = "None"

        SSL = Nothing
        HOST = Nothing
        PORT = Nothing
        ComboBox1.Text = Nothing

        frmConfig.UnsetMailGreenFont()

    End Sub

    Private Sub UnblobkSomeThing2()

        txtUser.ReadOnly = False
        txtPass.ReadOnly = False
        Button2.Enabled = True
        Button3.Enabled = False
        'oServer.User = Nothing
        'oServer.Password = Nothing
        ComboBox1.Enabled = True
        isSendEmailMessage = False
        mailUser = Nothing
        mailPassword = Nothing
        frmConfig.txtgetMail.Text = "None"
        frmConfig.txtgetDateMail.Text = "None"
        frmConfig.txtCountSenderMail.Text = "None"
        frmConfig.txtRitcher.Text = "None"
        ComboBox1.SelectedIndex = -1

        SSL = Nothing
        HOST = Nothing
        PORT = Nothing
        ComboBox1.Text = Nothing

        frmConfig.UnsetMailGreenFont()

    End Sub



    Private Sub ComboBox1_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles ComboBox1.Click


        Select Case ComboBox1.Text

            Case "Live (SSL)"

                sm.Port = 587
                sm.Host = "smtp.live.com"
                sm.EnableSsl = True

                PORT = 587
                HOST = "smtp.live.com"
                SSL = True


            Case "Gmail (SSL)"

                sm.Port = 587
                sm.Host = "smtp.gmail.com"
                sm.EnableSsl = True


                PORT = 587
                HOST = "smtp.gmail.com"
                SSL = True



            Case "Yahoo! (SSL)"

                sm.Port = 465
                sm.Host = "plus.smtp.mail.yahoo.com"
                sm.EnableSsl = True


                PORT = 465
                HOST = "plus.smtp.mail.yahoo.com"
                SSL = True


            Case "GMX (No SSL)"

                sm.Port = 587
                sm.Host = "mail.gmx.com"
                sm.EnableSsl = False

                PORT = 587
                HOST = "mail.gmx.com"
                SSL = False


        End Select


    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles ComboBox1.SelectedIndexChanged


        Select Case ComboBox1.Text

            Case "Live (SSL)"

                sm.Port = 587
                sm.Host = "smtp.live.com"
                sm.EnableSsl = True

                PORT = 587
                HOST = "smtp.live.com"
                SSL = True
                HIndex = ComboBox1.SelectedIndex


            Case "Gmail (SSL)"

                sm.Port = 587
                sm.Host = "smtp.gmail.com"
                sm.EnableSsl = True


                PORT = 587
                HOST = "smtp.gmail.com"
                SSL = True
                HIndex = ComboBox1.SelectedIndex


            Case "Yahoo! (SSL)"

                sm.Port = 465
                sm.Host = "plus.smtp.mail.yahoo.com"
                sm.EnableSsl = True


                PORT = 465
                HOST = "plus.smtp.mail.yahoo.com"
                SSL = True
                HIndex = ComboBox1.SelectedIndex

            Case "GMX (No SSL)"

                sm.Port = 587
                sm.Host = "mail.gmx.com"
                sm.EnableSsl = False

                PORT = 587
                HOST = "mail.gmx.com"
                SSL = False
                HIndex = ComboBox1.SelectedIndex

        End Select


    End Sub



    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click
        Me.Close()
        'saveList()
    End Sub

    Private Sub btnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAdd.Click

        Dim reply As String
        reply = InputBox("เพิ่มรายชื่ออีเมล", "  ")

        btnsave.Enabled = True

        If reply <> "" Then

            xBuild.Add(reply)
            listMail.Items.Add(xBuild.Item(xBuild.Count - 1))

        End If


    End Sub


    Private Sub saveList()

        Dim xFile As String = CurDir() & "\profiles\" & txtUser.Text & ".txt"
        Dim wrt As StreamWriter
        wrt = File.CreateText(xFile)


        If listMail.Items.Count <> 0 Then


            xBuild.Clear()
            For p = 0 To listMail.Items.Count - 1
                xBuild.Add(listMail.Items(p))

            Next

            For Each ec As String In xBuild

                wrt.WriteLine(ec)

            Next

            btnsave.Enabled = False
        Else

            wrt.Write("")
            btnsave.Enabled = False

        End If
        wrt.Close()

        frmConfig.txtCountSenderMail.Text = Me.listMail.Items.Count & " คน"


    End Sub


    Private Sub btnRemove_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnRemove.Click

        On Error Resume Next
        If listMail.Items.Count <> 0 Then

            btnsave.Enabled = True
            listMail.Items.RemoveAt(listMail.SelectedIndex)

        End If


       
    End Sub

    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnsave.Click
        saveList()
    End Sub


    Public Sub saveMailProfile(ByVal isSave As Boolean)

        ' Dim temp = CurDir() & "\profiles\temp.dat"
        ' Dim dbgit = CurDir() & "\profiles\dbgid.dat"


        If isSave = True Then


            My.Settings.mail_user = EncryptText(txtUser.Text)
            My.Settings.mail_password = EncryptText(txtPass.Text)
            My.Settings.Save()

            'Dim ak As StreamWriter
            'ak = File.CreateText(Temp)
            'ak.WriteLine(EncryptText(txtUser.Text))
            'ak.WriteLine(EncryptText(txtPass.Text))
            'ak.Close()
            'EncryptFile(Temp, dbgit, "5eb8014d")
            'File.Delete(Temp)
            'ElseIf isSave = False Then
            'If File.Exists(dbgit) Then
            'File.Delete(dbgit)

        End If

        'End If

    End Sub

    Public Sub showInterfacelogin(ByVal isLog As Boolean)


        If isLog = True Then

            Button3.Enabled = True
            Me.Cursor = Cursors.Default
            txtDisable.Visible = False
            listMail.Visible = True
            btnAdd.Visible = True
            btnRemove.Visible = True
            btnsave.Visible = True
            ComboBox1.Enabled = False
            isSendEmailMessage = True
            mailUser = txtUser.Text
            mailPassword = txtPass.Text
            frmConfig.txtgetMail.Text = txtUser.Text
            frmConfig.txtgetDateMail.Text = ToLocalTime(DateTime.Now)
            frmConfig.txtRitcher.Text = "6.0 ริกเตอร์ขึ้นไป (บังคับ)"
            frmConfig.setMailGreenFont()


            Dim rd As StreamReader
            Dim wr As StreamWriter
            Dim xFile As String = CurDir() & "\profiles\" & txtUser.Text & ".txt"
            Dim lines As String() = File.ReadAllLines(xFile)

            If File.Exists(xFile) Then

                rd = File.OpenText(xFile)
                listMail.Items.Clear()
                xBuild.Clear()

                For i = 1 To lines.Length

                    xBuild.Add(rd.ReadLine)

                Next

                For Each rk As String In xBuild

                    listMail.Items.Add(rk)

                Next

                rd.Close()

            Else
                wr = File.CreateText(xFile)
                wr.Close()
                wr.Dispose()
                wr = Nothing

            End If

            ' frmConfig.txtCountSenderMail.Text = Me.listMail.Items.Count & " คน"

        Else

            UnblobkSomeThing()

        End If

    End Sub

    Private Sub MassMailCreate()

        Dim cr As StreamWriter
        If File.Exists(txtUser.Text) = False Then
            cr = File.CreateText(CurDir() & "\profiles\" & txtUser.Text & ".txt")
            cr.Close()
        End If

    End Sub
 
End Class
