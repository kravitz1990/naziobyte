
Public Class frmConfig

    Dim hIP As System.Net.IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
    Private Sub TrackBar1_Scroll(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TrackBar1.Scroll
        TextBox1.Text = TrackBar1.Value & ".0"
    End Sub


    Private Sub Button4_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnAddSound.Click
        ContextMenuStrip1.Show(Cursor.Position)
    End Sub

    Private Sub frmConfig_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadSetting()


    End Sub


    Private Sub ApplySetting()

        isPlaySound = CheckBox1.Checked
        cQuakeLevel = TrackBar1.Value & ".0"
        soundPath = ListSound.Text

    End Sub

    Private Sub LoadSetting()

        CheckBox1.Checked = isPlaySound
        TrackBar1.Value = Mid(cQuakeLevel, 1, 1)
        TextBox1.Text = cQuakeLevel & ".0"
        

        getIPv4.Text = hIP.AddressList(1).ToString

    End Sub

    Private Sub Button1_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button1.Click

        ApplySetting()
        Button1.Enabled = False

    End Sub

    Private Sub Button3_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button3.Click

        ApplySetting()
        Me.Close()

    End Sub

    Private Sub Button2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button2.Click

        Me.Close()

    End Sub

    Private Sub CheckBox1_CheckedChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            btnStop.Enabled = True
            btnplay.Enabled = True
            ListSound.Enabled = True
            btnAddSound.Enabled = True
            isPlaySound = True

        ElseIf CheckBox1.Checked = False Then

            btnStop.Enabled = False
            btnplay.Enabled = False
            ListSound.Enabled = False
            btnAddSound.Enabled = False
            isPlaySound = False

        End If

    End Sub

    Private Sub TabPage2_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles TabPage2.Click

    End Sub

    Private Sub Button4_Click_1(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button4.Click
        EmailManage.ShowDialog()
    End Sub

    Private Sub Button5_Click(ByVal sender As System.Object, ByVal e As System.EventArgs)

    End Sub

    Private Sub Button7_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles Button7.Click
        TwitManage.ShowDialog()
    End Sub
End Class