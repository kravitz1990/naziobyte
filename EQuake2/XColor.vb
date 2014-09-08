Imports System.Web.UI.WebControls.ListItem
Public Class XColor


    Dim temp As String

    Private Sub XColor_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    

        dg.Rows.Add(166)


        For i = 1 To 166

            dg.Item(0, i).Value = i
            dg.Item(0, i).Style.BackColor = Color.FromKnownColor(i)


        Next


        RadioButton1.BackColor = Color.FromKnownColor(KnownColor.ActiveCaption)
        RadioButton2.BackColor = Color.FromKnownColor(KnownColor.ControlLight)
        RadioButton3.BackColor = Color.FromKnownColor(KnownColor.Highlight)
        RadioButton4.BackColor = Color.FromKnownColor(KnownColor.HotTrack)
        RadioButton5.BackColor = Color.FromKnownColor(KnownColor.InactiveCaption)
        RadioButton6.BackColor = Color.FromKnownColor(KnownColor.InactiveCaptionText)
        RadioButton7.BackColor = Color.FromKnownColor(KnownColor.Info)
        RadioButton8.BackColor = Color.FromKnownColor(KnownColor.AntiqueWhite)
        RadioButton9.BackColor = Color.FromKnownColor(KnownColor.Aqua)
        RadioButton10.BackColor = Color.FromKnownColor(KnownColor.Aquamarine)
        RadioButton11.BackColor = Color.FromKnownColor(KnownColor.Beige)
        RadioButton12.BackColor = Color.FromKnownColor(KnownColor.Bisque)
        RadioButton13.BackColor = Color.FromKnownColor(KnownColor.BlanchedAlmond)
        RadioButton14.BackColor = Color.FromKnownColor(KnownColor.Blue)
        RadioButton15.BackColor = Color.FromKnownColor(KnownColor.BlueViolet)
        RadioButton16.BackColor = Color.FromKnownColor(KnownColor.Brown)
        RadioButton17.BackColor = Color.FromKnownColor(KnownColor.BurlyWood)
        RadioButton18.BackColor = Color.FromKnownColor(KnownColor.CadetBlue)
        RadioButton19.BackColor = Color.FromKnownColor(KnownColor.Chartreuse)
        RadioButton20.BackColor = Color.FromKnownColor(KnownColor.Chocolate)
        RadioButton21.BackColor = Color.FromKnownColor(KnownColor.Coral)
        RadioButton22.BackColor = Color.FromKnownColor(KnownColor.CornflowerBlue)
        RadioButton23.BackColor = Color.FromKnownColor(KnownColor.Crimson)
        RadioButton24.BackColor = Color.FromKnownColor(KnownColor.Cyan)
        RadioButton25.BackColor = Color.FromKnownColor(KnownColor.DarkBlue)
        RadioButton26.BackColor = Color.FromKnownColor(KnownColor.DarkCyan)
        RadioButton27.BackColor = Color.FromKnownColor(KnownColor.DarkGoldenrod)
        RadioButton28.BackColor = Color.FromKnownColor(KnownColor.DarkGray)
        RadioButton29.BackColor = Color.FromKnownColor(KnownColor.DarkGreen)
        RadioButton30.BackColor = Color.FromKnownColor(KnownColor.DarkKhaki)
        RadioButton31.BackColor = Color.FromKnownColor(KnownColor.DarkMagenta)
        RadioButton32.BackColor = Color.FromKnownColor(KnownColor.DarkOliveGreen)
        RadioButton33.BackColor = Color.FromKnownColor(KnownColor.DarkOrange)
        RadioButton34.BackColor = Color.FromKnownColor(KnownColor.DarkRed)
        RadioButton35.BackColor = Color.FromKnownColor(KnownColor.DarkSalmon)
        RadioButton36.BackColor = Color.FromKnownColor(KnownColor.DarkSeaGreen)
        RadioButton37.BackColor = Color.FromKnownColor(KnownColor.DarkSlateBlue)
        RadioButton38.BackColor = Color.FromKnownColor(KnownColor.DarkSlateGray)
        RadioButton39.BackColor = Color.FromKnownColor(KnownColor.DarkTurquoise)
        RadioButton40.BackColor = Color.FromKnownColor(KnownColor.DarkViolet)
        RadioButton41.BackColor = Color.FromKnownColor(KnownColor.DeepPink)
        RadioButton42.BackColor = Color.FromKnownColor(KnownColor.DeepSkyBlue)
        RadioButton43.BackColor = Color.FromKnownColor(KnownColor.DimGray)
        RadioButton44.BackColor = Color.FromKnownColor(KnownColor.DodgerBlue)
        RadioButton45.BackColor = Color.FromKnownColor(KnownColor.Firebrick)
        RadioButton46.BackColor = Color.FromKnownColor(KnownColor.ForestGreen)
        RadioButton47.BackColor = Color.FromKnownColor(KnownColor.Fuchsia)
        RadioButton48.BackColor = Color.FromKnownColor(KnownColor.Gainsboro)
        RadioButton49.BackColor = Color.FromKnownColor(KnownColor.Gold)
        RadioButton50.BackColor = Color.FromKnownColor(KnownColor.Goldenrod)
        RadioButton51.BackColor = Color.FromKnownColor(KnownColor.Green)
        RadioButton52.BackColor = Color.FromKnownColor(KnownColor.GreenYellow)
        RadioButton53.BackColor = Color.FromKnownColor(KnownColor.IndianRed)
        RadioButton54.BackColor = Color.FromKnownColor(KnownColor.Khaki)
        RadioButton55.BackColor = Color.FromKnownColor(KnownColor.Lavender)
        RadioButton56.BackColor = Color.FromKnownColor(KnownColor.LawnGreen)
        RadioButton57.BackColor = Color.FromKnownColor(KnownColor.LemonChiffon)
        RadioButton58.BackColor = Color.FromKnownColor(KnownColor.LightBlue)
        RadioButton59.BackColor = Color.FromKnownColor(KnownColor.LightCoral)
        RadioButton60.BackColor = Color.FromKnownColor(KnownColor.LightCyan)
        RadioButton61.BackColor = Color.FromKnownColor(KnownColor.LightGreen)
        RadioButton62.BackColor = Color.FromKnownColor(KnownColor.LightPink)
        RadioButton63.BackColor = Color.FromKnownColor(KnownColor.LightSalmon)
        RadioButton64.BackColor = Color.FromKnownColor(KnownColor.LightSeaGreen)
        RadioButton65.BackColor = Color.FromKnownColor(KnownColor.LightSkyBlue)
        RadioButton66.BackColor = Color.FromKnownColor(KnownColor.LightSlateGray)
        RadioButton67.BackColor = Color.FromKnownColor(KnownColor.LightSteelBlue)
        RadioButton68.BackColor = Color.FromKnownColor(KnownColor.Lime)
        RadioButton69.BackColor = Color.FromKnownColor(KnownColor.LimeGreen)
        RadioButton70.BackColor = Color.FromKnownColor(KnownColor.Magenta)
        RadioButton71.BackColor = Color.FromKnownColor(KnownColor.MediumAquamarine)
        RadioButton72.BackColor = Color.FromKnownColor(KnownColor.MediumOrchid)
        RadioButton73.BackColor = Color.FromKnownColor(KnownColor.MediumPurple)
        RadioButton74.BackColor = Color.FromKnownColor(KnownColor.MediumSeaGreen)
        RadioButton75.BackColor = Color.FromKnownColor(KnownColor.MediumSlateBlue)
        RadioButton76.BackColor = Color.FromKnownColor(KnownColor.MediumSpringGreen)
        RadioButton77.BackColor = Color.FromKnownColor(KnownColor.MediumVioletRed)
        RadioButton78.BackColor = Color.FromKnownColor(KnownColor.Orange)
        RadioButton79.BackColor = Color.FromKnownColor(KnownColor.OrangeRed)
        RadioButton80.BackColor = Color.FromKnownColor(KnownColor.Orchid)
        RadioButton81.BackColor = Color.FromKnownColor(KnownColor.PaleGoldenrod)
        RadioButton82.BackColor = Color.FromKnownColor(KnownColor.PaleGreen)
        RadioButton83.BackColor = Color.FromKnownColor(KnownColor.PaleTurquoise)
        RadioButton84.BackColor = Color.FromKnownColor(KnownColor.Pink)
        RadioButton85.BackColor = Color.FromKnownColor(KnownColor.Plum)
        RadioButton86.BackColor = Color.FromKnownColor(KnownColor.Salmon)
        RadioButton87.BackColor = Color.FromKnownColor(KnownColor.SandyBrown)
        RadioButton88.BackColor = Color.FromKnownColor(KnownColor.SeaGreen)
        RadioButton89.BackColor = Color.FromKnownColor(KnownColor.SkyBlue)
        RadioButton90.BackColor = Color.FromKnownColor(KnownColor.SlateBlue)
        RadioButton91.BackColor = Color.FromKnownColor(KnownColor.SlateGray)
        RadioButton92.BackColor = Color.FromKnownColor(KnownColor.Tan)
        RadioButton93.BackColor = Color.FromKnownColor(KnownColor.Teal)
        RadioButton94.BackColor = Color.FromKnownColor(KnownColor.Thistle)
        RadioButton95.BackColor = Color.FromKnownColor(KnownColor.Tomato)
        RadioButton96.BackColor = Color.FromKnownColor(KnownColor.Turquoise)
        RadioButton97.BackColor = Color.FromKnownColor(KnownColor.Violet)
        RadioButton98.BackColor = Color.FromKnownColor(KnownColor.Wheat)
        RadioButton99.BackColor = Color.FromKnownColor(KnownColor.Yellow)
        RadioButton100.BackColor = Color.FromKnownColor(KnownColor.White)


    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Close()
    End Sub



    Private Sub Button3_Click(sender As Object, e As EventArgs)


    End Sub

    Private Sub dg_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellClick

        Static b As Integer


        b += 1
        Dim i As Integer = dg.CurrentCell.Value

        TextBox1.Paste(vbCrLf & "RadioButton" & b & ".BackColor =" & dg.Item(0, i).Style.BackColor.ToString.Replace("Color", "".Replace("[", "".Replace("]", ""))))



    End Sub

    Private Sub dg_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dg.CellContentClick




    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        Try


            Select Case ATP_colorCardSlot

                Case 0

                    Form1.selCol1.Checked = True
                    Form1.nonselCol1.Checked = False
                    Form1.ColStripA.BackColor = Color.FromName(temp)
                    setColorLevel_1(temp)
                    Form1.GenerateGridLevelColor()

                Case 1

                    Form1.selCol2.Checked = True
                    Form1.nonSelCol2.Checked = False
                    Form1.ColStripB.BackColor = Color.FromName(temp)
                    setColorLevel_2(temp)
                    Form1.GenerateGridLevelColor()

                Case 2

                    Form1.selCol3.Checked = True
                    Form1.nonSelCol3.Checked = False
                    Form1.ColStripC.BackColor = Color.FromName(temp)
                    setColorLevel_3(temp)
                    Form1.GenerateGridLevelColor()

                Case 3

                    Form1.selCol4.Checked = True
                    Form1.nonSelCol4.Checked = False
                    Form1.ColStripD.BackColor = Color.FromName(temp)
                    setColorLevel_4(temp)
                    Form1.GenerateGridLevelColor()

                Case 4

                    Form1.selCol5.Checked = True
                    Form1.nonSelCol5.Checked = False
                    Form1.ColStripE.BackColor = Color.FromName(temp)
                    setColorLevel_5(temp)
                    Form1.GenerateGridLevelColor()

                Case 5

                    Form1.celCol6.Checked = True
                    Form1.nonSelCol6.Checked = False
                    Form1.ColStripF.BackColor = Color.FromName(temp)
                    setColorLevel_6(temp)
                    Form1.GenerateGridLevelColor()

                Case 6

                    Form1.selCol7.Checked = True
                    Form1.nonSelCol7.Checked = False
                    Form1.ColStripG.BackColor = Color.FromName(temp)
                    setColorLevel_7(temp)
                    Form1.GenerateGridLevelColor()

                Case 7

                    Form1.selCol8.Checked = True
                    Form1.nonSelCol8.Checked = False
                    Form1.ColStripH.BackColor = Color.FromName(temp)
                    setColorLevel_8(temp)
                    Form1.GenerateGridLevelColor()

                Case 8

                    Form1.selCol9.Checked = True
                    Form1.nonSelCol9.Checked = False
                    Form1.ColStripI.BackColor = Color.FromName(temp)
                    setColorLevel_9(temp)
                    Form1.GenerateGridLevelColor()

                Case 9

                    Form1.selCol10.Checked = True
                    Form1.nonSelCol10.Checked = False
                    Form1.ColStripJ.BackColor = Color.FromName(temp)
                    setColorLevel_10(temp)
                    Form1.GenerateGridLevelColor()

            End Select

        Catch ex As Exception

        End Try

       

        Me.Close()

    End Sub

    Private Sub RadioButton1_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton1.CheckedChanged

        temp = RadioButton1.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton2_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton2.CheckedChanged

        temp = RadioButton2.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton3_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton3.CheckedChanged

        temp = RadioButton3.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton4_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton4.CheckedChanged

        temp = RadioButton4.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton5_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton5.CheckedChanged

        temp = RadioButton5.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton6_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton6.CheckedChanged

        temp = RadioButton6.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton7_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton7.CheckedChanged

        temp = RadioButton7.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton8_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton8.CheckedChanged

        temp = RadioButton8.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton9_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton9.CheckedChanged

        temp = RadioButton9.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton10_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton10.CheckedChanged

        temp = RadioButton10.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton11_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton11.CheckedChanged

        temp = RadioButton11.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton12_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton12.CheckedChanged

        temp = RadioButton12.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton13_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton13.CheckedChanged

        temp = RadioButton13.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton14_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton14.CheckedChanged

        temp = RadioButton14.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton15_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton15.CheckedChanged

        temp = RadioButton15.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton16_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton16.CheckedChanged

        temp = RadioButton16.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton17_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton17.CheckedChanged

        temp = RadioButton17.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton18_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton18.CheckedChanged

        temp = RadioButton18.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton19_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton19.CheckedChanged

        temp = RadioButton19.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton20_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton20.CheckedChanged

        temp = RadioButton20.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton21_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton21.CheckedChanged

        temp = RadioButton21.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton22_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton22.CheckedChanged

        temp = RadioButton22.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton23_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton23.CheckedChanged

        temp = RadioButton23.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton24_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton24.CheckedChanged

        temp = RadioButton24.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton25_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton25.CheckedChanged

        temp = RadioButton25.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton26_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton26.CheckedChanged

        temp = RadioButton26.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton27_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton27.CheckedChanged

        temp = RadioButton27.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton28_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton28.CheckedChanged

        temp = RadioButton28.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton29_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton29.CheckedChanged

        temp = RadioButton29.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton30_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton30.CheckedChanged

        temp = RadioButton30.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton31_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton31.CheckedChanged

        temp = RadioButton31.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton32_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton32.CheckedChanged

        temp = RadioButton32.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton33_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton33.CheckedChanged

        temp = RadioButton33.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton34_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton34.CheckedChanged

        temp = RadioButton34.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton35_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton35.CheckedChanged

        temp = RadioButton35.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton36_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton36.CheckedChanged

        temp = RadioButton36.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton37_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton37.CheckedChanged

        temp = RadioButton37.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton38_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton38.CheckedChanged

        temp = RadioButton38.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton39_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton39.CheckedChanged

        temp = RadioButton39.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton40_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton40.CheckedChanged

        temp = RadioButton40.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton41_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton41.CheckedChanged

        temp = RadioButton41.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton42_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton42.CheckedChanged

        temp = RadioButton42.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton43_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton43.CheckedChanged

        temp = RadioButton43.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton44_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton44.CheckedChanged

        temp = RadioButton44.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton45_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton45.CheckedChanged

        temp = RadioButton45.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton46_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton46.CheckedChanged

        temp = RadioButton46.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton47_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton47.CheckedChanged

        temp = RadioButton47.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton48_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton48.CheckedChanged

        temp = RadioButton48.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton49_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton49.CheckedChanged

        temp = RadioButton49.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton50_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton50.CheckedChanged

        temp = RadioButton50.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton51_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton51.CheckedChanged

        temp = RadioButton51.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton52_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton52.CheckedChanged

        temp = RadioButton52.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton53_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton53.CheckedChanged

        temp = RadioButton53.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton54_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton54.CheckedChanged

        temp = RadioButton54.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton55_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton55.CheckedChanged

        temp = RadioButton55.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton56_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton56.CheckedChanged

        temp = RadioButton56.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton57_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton57.CheckedChanged

        temp = RadioButton57.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton58_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton58.CheckedChanged

        temp = RadioButton58.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton59_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton59.CheckedChanged

        temp = RadioButton59.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton60_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton60.CheckedChanged

        temp = RadioButton60.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton61_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton61.CheckedChanged

        temp = RadioButton61.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton62_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton62.CheckedChanged

        temp = RadioButton62.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton63_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton63.CheckedChanged

        temp = RadioButton63.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton64_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton64.CheckedChanged

        temp = RadioButton64.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton65_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton65.CheckedChanged

        temp = RadioButton65.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton66_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton66.CheckedChanged

        temp = RadioButton66.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton67_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton67.CheckedChanged

        temp = RadioButton67.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton68_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton68.CheckedChanged

        temp = RadioButton68.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton69_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton69.CheckedChanged

        temp = RadioButton69.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton70_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton70.CheckedChanged

        temp = RadioButton70.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton71_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton71.CheckedChanged

        temp = RadioButton71.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton72_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton72.CheckedChanged

        temp = RadioButton72.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton73_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton73.CheckedChanged

        temp = RadioButton73.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton74_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton74.CheckedChanged

        temp = RadioButton74.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton75_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton75.CheckedChanged

        temp = RadioButton75.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton76_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton76.CheckedChanged

        temp = RadioButton76.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton77_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton77.CheckedChanged

        temp = RadioButton77.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton78_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton78.CheckedChanged

        temp = RadioButton78.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton79_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton79.CheckedChanged

        temp = RadioButton79.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton80_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton80.CheckedChanged

        temp = RadioButton80.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton81_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton81.CheckedChanged

        temp = RadioButton81.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton82_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton82.CheckedChanged

        temp = RadioButton82.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton83_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton83.CheckedChanged

        temp = RadioButton83.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton84_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton84.CheckedChanged

        temp = RadioButton84.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton85_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton85.CheckedChanged

        temp = RadioButton85.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton86_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton86.CheckedChanged

        temp = RadioButton86.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton87_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton87.CheckedChanged

        temp = RadioButton87.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton88_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton88.CheckedChanged

        temp = RadioButton88.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton89_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton89.CheckedChanged

        temp = RadioButton89.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton90_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton90.CheckedChanged

        temp = RadioButton90.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton91_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton91.CheckedChanged

        temp = RadioButton91.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton92_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton92.CheckedChanged

        temp = RadioButton92.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton93_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton93.CheckedChanged

        temp = RadioButton93.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton94_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton94.CheckedChanged

        temp = RadioButton94.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton95_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton95.CheckedChanged

        temp = RadioButton95.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton96_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton96.CheckedChanged

        temp = RadioButton96.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton97_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton97.CheckedChanged

        temp = RadioButton97.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton98_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton98.CheckedChanged

        temp = RadioButton98.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton99_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton99.CheckedChanged

        temp = RadioButton99.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub

    Private Sub RadioButton100_CheckedChanged(sender As Object, e As EventArgs) Handles RadioButton100.CheckedChanged

        temp = RadioButton100.BackColor.ToString.Replace("Color", "").Replace("[", "").Replace("]", "").Replace(" ", "")

    End Sub




End Class