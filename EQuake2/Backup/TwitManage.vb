Imports System.IO
Imports TwitterVB2
Imports System.Threading

Public Class TwitManage

    Public tw As New TwitterAPI

    Dim oFile As System.IO.File
    Dim oWrite As System.IO.StreamWriter
    Dim trd As Thread
    Dim isAuthen As Boolean
    Dim pbFile1 As String = CurDir() & "\aMake_0Auth1.dat"
    Dim pbFile2 As String = CurDir() & "\zMake_0Auth2.dat"

    Private Sub TwitManage_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

       
        If File.Exists(pbFile1) And File.Exists(pbFile2) Then

            readFileSetting()

            btnChkTw.Enabled = False
            btnQespin.Enabled = False
            btnTwLogout.Enabled = True

        Else
            btnChkTw.Enabled = False
            btnQespin.Enabled = True
            btnTwLogout.Enabled = False

        End If


    End Sub


    Private Sub readFileSetting()

        Dim rd1 As New StreamReader(pbFile1)
        Dim rd2 As New StreamReader(pbFile2)

        auth1 = rd1.ReadLine 'อ่านไฟล์ aMake_0Auth1.dat
        auth2 = rd2.ReadLine 'อ่านไฟล์ zMake_0Auth2.dat

        rd1.Close()
        rd2.Close()

    End Sub


    Private Sub makeFileSetting(ByVal token As String, ByVal tokenSecret As String)

        Dim wr1 As StreamWriter
        Dim wr2 As StreamWriter

        wr1 = File.CreateText(pbFile1)
        wr2 = File.CreateText(pbFile2)

        wr1.WriteLine(token)
        wr2.WriteLine(tokenSecret)

        wr1.Close()
        wr2.Close()


    End Sub

    Public Function isAuthentication() As Boolean

        Return True

    End Function


    Private Sub btnQespin_Click(sender As System.Object, e As System.EventArgs) Handles btnQespin.Click

        Process.Start(getURL_PIN)

    End Sub

    Private Function getURL_PIN() As String

        Return tw.GetAuthorizationLink(consumer, consumersecret)

    End Function


    Private Sub btnChkTw_Click(sender As System.Object, e As System.EventArgs) Handles btnChkTw.Click

        If tw.ValidatePIN(TextBox1.Text) = True Then

            'Login success
            If MessageBox.Show("คุณต้องการเปิดใช้งานเดี่ยวนี้หรือไม่", "เข้าสู่ระบบสำเร็จ", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) = MsgBoxResult.Ok Then

                oauthtocken = tw.OAuth_Token
                oauthtockensecret = tw.OAuth_TokenSecret
                makeFileSetting(oauthtocken, oauthtockensecret)

                auth1 = oauthtocken
                auth2 = oauthtockensecret

                btnChkTw.Enabled = False
                btnQespin.Enabled = False
                btnTwLogout.Enabled = True



            End If

        Else

            MessageBox.Show("คุณใส่รหัส PIN ไม่ถูกต้อง", "ผิดพลาด", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If


    End Sub


    Private Sub btnTwLogout_Click(sender As System.Object, e As System.EventArgs) Handles btnTwLogout.Click

        If File.Exists(pbFile1) And File.Exists(pbFile2) Then

            File.Delete(pbFile1)
            File.Delete(pbFile2)

            btnTwLogout.Enabled = False
            btnQespin.Enabled = True
            btnChkTw.Enabled = False
            isSendTwitterMessage = False

        End If

    End Sub

    Private Sub TextBox1_TextChanged(sender As System.Object, e As System.EventArgs) Handles TextBox1.TextChanged

        If TextBox1.Text <> Nothing Then

            btnChkTw.Enabled = True
        Else

            btnChkTw.Enabled = False

        End If

    End Sub
End Class