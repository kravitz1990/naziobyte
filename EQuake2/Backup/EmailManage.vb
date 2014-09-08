Imports System.Net
Imports System.Net.Sockets
Imports System.Net.Mail
Imports System.Threading
Imports System.IO

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
    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        If txtUser.Text = "" Or txtPass.Text = "" Then

            MsgBox("โปรดป้อนชื่อและรหัสก่อนเข้าใช้งาน", MsgBoxStyle.Critical, "ผิดพลาด")

        Else

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
            mail.Body = "EarthQuake Realtime Checker 2.0.0.0" & vbCrLf & "--------------------------------------------" & vbCrLf & "login success : (In Good standing)"


            sm.Send(mail)

            MsgBox("เข้าสู่ระบบสำเร็จ", MsgBoxStyle.Information, "              ")
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


            Dim rd As StreamReader
            Dim wr As StreamWriter
            Dim xFile As String = CurDir() & "\" & txtUser.Text & ".txt"
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




        Catch ex As Exception

            Console.WriteLine(ex.Message)

            If Me.InvokeRequired Then
                Me.Invoke(New MethodInvoker(AddressOf SendMailThread))
            Else

                MsgBox("ไม่สามารถเข้าสู่ระบบได้", MsgBoxStyle.Critical, "               ")
                UnblobkSomeThing2()
                Me.Cursor = Cursors.Default


            End If
        End Try

    End Sub


    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        If MsgBox("คุณแน่ใจหรือว่าต้องการออกจากระบบ", MsgBoxStyle.YesNo + MsgBoxStyle.Exclamation, "ยืนยันการออกจากระบบ") = MsgBoxResult.Yes Then

            UnblobkSomeThing()

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

        Dim xFile As String = CurDir() & "\" & txtUser.Text & ".txt"
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
End Class