Imports System.Net
Imports System.IO

Public Class NetworkCard

    Dim hIP As IPHostEntry = System.Net.Dns.GetHostByName(System.Net.Dns.GetHostName)
    Dim wr(2) As StreamWriter
    Dim rd(2) As StreamReader
    Public startNoSave As Integer
    Dim iRow As Integer

    Private Sub NetworkCard_FormClosing(sender As Object, e As FormClosingEventArgs) Handles Me.FormClosing

        'If btnsave.Enabled = True Then

        'For x = net_Host.Count - 1 To (net_Host.Count - startNoSave) - 1

        'net_Host.RemoveAt(x)
        'net_Port.RemoveAt(x)
        'net_Protocol.RemoveAt(x)

        'Next

        'End If

        LoadFileSetting()

        btnsave.Enabled = False

        frmConfig.ApplySetting()
        iSaveSettingAsync()

        ' For Each pd As String In net_Host

        'Console.WriteLine(pd)

        'Next

    End Sub

    Private Sub NetworkCard_Load(sender As Object, e As EventArgs) Handles MyBase.Load


        ' CheckBox1.Checked = isSendNetworkMessage

        If CheckBox1.Checked = True Then

            '   isSendNetworkMessage = True
            ComboBox1.Enabled = True
            netGrid.Enabled = True
            btnAdd.Enabled = True
            btnsave.Enabled = True
            btnRemove.Enabled = True

        ElseIf CheckBox1.Checked = False Then

            ' isSendNetworkMessage = False
            ComboBox1.Enabled = False
            netGrid.Enabled = False
            btnAdd.Enabled = False
            btnsave.Enabled = False
            btnRemove.Enabled = False

        End If






        LoadCardList()
        LoadFileSetting()

    End Sub


    Private Sub LoadCardList()

        ComboBox1.Items.Clear()
        For i = 0 To hIP.AddressList.Length - 1

            ComboBox1.Items.Add(hIP.AddressList(i).ToString)

        Next
        ComboBox1.SelectedIndex = ipIndex

    End Sub

    Private Sub btnAdd_Click(sender As Object, e As EventArgs) Handles btnAdd.Click
        frmAddHost.ShowDialog()


    End Sub

    Private Sub btnsave_Click(sender As Object, e As EventArgs) Handles btnsave.Click



        If netGrid.Rows.Count <> 0 Then


            btnsave.Enabled = False
            SaveFileSetting()

        Else

            btnsave.Enabled = False

        End If

        frmConfig.txtgetIPv4.Text = ComboBox1.Text
        frmConfig.txtCountHost.Text = net_Host.Count
        frmConfig.txtNetEQ.Text = cQuakeLevel & " ริกเตอร์ขึ้นไป"
     

    End Sub


    Private Sub SaveFileSetting()


        wr(0) = File.CreateText(CurDir() & "\netHost.dat")
        For i = 0 To net_Host.Count - 1
            wr(0).WriteLine(net_Host(i))
        Next
        wr(0).Close()



        wr(1) = File.CreateText(CurDir() & "\netPort.dat")
        For i = 0 To net_Port.Count - 1
            wr(1).WriteLine(net_Port(i))
        Next
        wr(1).Close()


        wr(2) = File.CreateText(CurDir() & "\netProtocol.dat")
        For i = 0 To net_Protocol.Count - 1
            wr(2).WriteLine(net_Protocol(i))
        Next
        wr(2).Close()




    End Sub


    Private Sub LoadFileSetting()


        Dim file1 As String = CurDir() & "\netHost.dat"
        Dim file2 As String = CurDir() & "\netPort.dat"
        Dim file3 As String = CurDir() & "\netProtocol.dat"
        Dim lines As String()
        net_Host.Clear()
        net_Port.Clear()
        net_Protocol.Clear()
        netGrid.Rows.Clear()



        If File.Exists(file1) And File.Exists(file2) And File.Exists(file3) Then

            lines = File.ReadAllLines(file1)

            rd(0) = File.OpenText(file1)
            For i = 0 To lines.Length - 1

                net_Host.Add(rd(0).ReadLine)

            Next
            rd(0).Close()

            lines = File.ReadAllLines(file2)


            rd(1) = File.OpenText(CurDir() & "\netPort.dat")
            For i = 0 To lines.Length - 1

                net_Port.Add(rd(1).ReadLine)

            Next
            rd(1).Close()



            lines = File.ReadAllLines(file3)
            rd(2) = File.OpenText(CurDir() & "\netProtocol.dat")
            For i = 0 To lines.Length - 1

                net_Protocol.Add(rd(2).ReadLine)

            Next
            rd(2).Close()


        End If


        For p = 0 To net_Host.Count - 1

            netGrid.Rows.Add(net_Host(p), net_Port(p), net_Protocol(p))

        Next

        'startNoSave = net_Host.Count

    End Sub

    
    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged

        If CheckBox1.Checked = True Then

            ' isSendNetworkMessage = True
            ComboBox1.Enabled = True
            netGrid.Enabled = True
            btnAdd.Enabled = True
            btnsave.Enabled = True
            btnRemove.Enabled = True


            frmConfig.txtgetIPv4.Text = ComboBox1.Text
            frmConfig.txtCountHost.Text = net_Host.Count
            frmConfig.txtNetEQ.Text = cQuakeLevel & " ริกเตอร์ขึ้นไป"

            frmConfig.setNetworkGreenFont()

        ElseIf CheckBox1.Checked = False Then

            'isSendNetworkMessage = False
            ComboBox1.Enabled = False
            netGrid.Enabled = False
            btnAdd.Enabled = False
            btnsave.Enabled = False
            btnRemove.Enabled = False


            frmConfig.txtgetIPv4.Text = "None"
            frmConfig.txtCountHost.Text = "None"
            frmConfig.txtNetEQ.Text = "None"

            frmConfig.UnsetNetworkGreenFont()

        End If
    End Sub

    Private Sub netGrid_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles netGrid.CellClick

        iRow = netGrid.CurrentCell.RowIndex

    End Sub

    Private Sub btnRemove_Click(sender As Object, e As EventArgs) Handles btnRemove.Click

        On Error Resume Next

        btnsave.Enabled = True
        netGrid.Rows.RemoveAt(iRow)
        net_Host.RemoveAt(iRow)
        net_Port.RemoveAt(iRow)
        net_Protocol.RemoveAt(iRow)

    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged

        btnsave.Enabled = False
        ipIndex = ComboBox1.SelectedIndex

        frmConfig.txtgetIPv4.Text = ComboBox1.Text

    End Sub
End Class