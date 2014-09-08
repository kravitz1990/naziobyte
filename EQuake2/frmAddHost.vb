Imports System.Net
Imports System.Net.Sockets
Imports System.Threading

Public Class frmAddHost

    Dim td As Thread

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Me.Close()
    End Sub

    Private Sub ComboBox1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles ComboBox1.SelectedIndexChanged


        Select Case ComboBox1.Text


            Case "TCP"

                Button1.Enabled = True

            Case "UDP"

                Button1.Enabled = False
            Case Else

                Button2.Enabled = False

        End Select


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click


        If txtHost.Text = "" Or txtPort.Text = "" Or ComboBox1.Text = "" Then

            MsgBox("โปรดใส่ข้อมูลให้ครบถ้วน", MsgBoxStyle.Critical, "ผิดพลาด")

        Else


            NetworkCard.netGrid.Rows.Add(txtHost.Text, txtPort.Text, ComboBox1.Text)
            net_Host.Add(txtHost.Text)
            net_Port.Add(txtPort.Text)
            net_Protocol.Add(ComboBox1.Text)
            NetworkCard.btnsave.Enabled = True
            NetworkCard.startNoSave += 1

            Me.Close()

        End If


    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click


        Me.Cursor = Cursors.WaitCursor
        sbConnect()
        Me.Cursor = Cursors.Default

    End Sub


    Private Sub sbConnect()


        If txtHost.Text = "" Or txtPort.Text = "" Or ComboBox1.Text = "" Then
            MsgBox("โปรดใส่ข้อมูลให้ครบถ้วน", MsgBoxStyle.Critical, "ผิดพลาด")

        Else

                    Try

                        Dim tcTest As New TcpClient(txtHost.Text, Int(txtPort.Text))
                        If tcTest.Connected Then


                            MsgBox("การเชื่อมต่อสำเร็จ", MsgBoxStyle.Information, "                ")


                        End If

                        tcTest.Close()



                    Catch ex As Exception

                        MsgBox("การเชื่อมต่อล้มเหลว", MsgBoxStyle.Critical, "               ")

                    End Try

        End If

    End Sub

    Private Sub frmAddHost_Load(sender As System.Object, e As System.EventArgs) Handles MyBase.Load

    End Sub
End Class