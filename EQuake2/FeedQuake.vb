Imports System.Xml
Imports System.Text.RegularExpressions
Imports System.Threading


Public Class RssFeeder

    Dim mx As Object
    Dim xml(3) As XmlDocument
    Dim noX(3) As XmlNodeList
    Dim pub As String
    Dim node As String = "/rss/channel/item"
    Dim a, b, c, d, e As Integer
    Dim trd As Thread
    Dim usgsOK As Boolean = False
    Dim tmdOK As Boolean = False
    Dim gfzOK As Boolean = False
    Dim csemOK As Boolean = False
    Dim _tn1, _tn2, _tn3, _tn4 As String

    Sub ReadQuake(ByVal UsgsUrl As String, ByVal GFZUrl As String, ByVal CsemUrl As String, ByVal tmdUrl As String)

        Try
            clearDataArray()

            xml(0) = New XmlDocument
            noX(0) = xml(0).SelectNodes(node)
            xml(0).Load(UsgsUrl)

            xml(1) = New XmlDocument
            noX(1) = xml(1).SelectNodes(node)
            xml(1).Load(GFZUrl)

            xml(2) = New XmlDocument
            noX(2) = xml(2).SelectNodes(node)
            xml(2).Load(CsemUrl)

            xml(3) = New XmlDocument
            noX(3) = xml(3).SelectNodes(node)
            xml(3).Load(tmdUrl)


            FillUpdate()
            DefragQuakeList()
            DefragTimeUTC()
            lastTime = ari4(0)

        Catch ex As Exception

            Exit Sub

        End Try

    End Sub


    Public Sub UpdateUSGS()

        On Error Resume Next

        '0. ระดับ  / 1. ความลึก / 2. ละติจูด,ลองติจูด / 3. สถานที่ / 4. เมื่อ / 5. ผู้ประกาศ

        'Node       Info
        '==================
        '0          เมื่อ
        '1          ขนาด , สถานที่
        '2          Link
        '4          Lat
        '5          Long
        '8          ความลึก
        'Me.last = (noX.Item(0).ChildNodes(1).InnerText)
        '---------------------------------------------------------------


            For i = 1 To noX(0).Count - 1

            _tn1 = Mid(ToLocalTime(noX(0).Item(i).ChildNodes(2).InnerText), 1, 1)

            If _tn1 = "1" Or _tn1 = "10" Then

                ari0.Add(Mid(noX(0).Item(i).ChildNodes(1).InnerText, 2, 4).Replace(" ", ""))
                ari1.Add(noX(0).Item(i).ChildNodes(8).InnerText)
                ari2.Add(noX(0).Item(i).ChildNodes(4).InnerText & ", " & noX(0).Item(i).ChildNodes(5).InnerText)
                ari3.Add(Mid(noX(0).Item(i).ChildNodes(1).InnerText, 7).ToUpper)
                ari4.Add(ToLocalTime(noX(0).Item(i).ChildNodes(2).InnerText))
                ari5.Add("USGS")
                ari6.Add(noX(0).Item(i).ChildNodes(3).InnerText)

            ElseIf Mid(Date.Now, 1, 2) <> "01" Or Mid(Date.Now, 1, 2) <> "10" Then

                ari0.Add(Mid(noX(0).Item(i).ChildNodes(1).InnerText, 2, 4).Replace(" ", ""))
                ari1.Add(noX(0).Item(i).ChildNodes(8).InnerText)
                ari2.Add(noX(0).Item(i).ChildNodes(4).InnerText & ", " & noX(0).Item(i).ChildNodes(5).InnerText)
                ari3.Add(Mid(noX(0).Item(i).ChildNodes(1).InnerText, 7).ToUpper)
                ari4.Add(ToLocalTime(noX(0).Item(i).ChildNodes(2).InnerText))
                ari5.Add("USGS")
                ari6.Add(noX(0).Item(i).ChildNodes(3).InnerText)

            End If


                'noX(0).Item(i).ChildNodes(4).InnerText

            Next

            usgsOK = True

    End Sub

    Public Sub UpdateGFZ()


        On Error Resume Next
        '0. ระดับ  / 1. ความลึก / 2. ละติจูด,ลองติจูด / 3. สถานที่ / 4. เมื่อ / 5. ผู้ประกาศ / 6.รูปภาพ / 7.URL

        'Node       Info
        '==================
        '0          ระดับ , สถานที่
        '1          เมื่อ, ละติจูด/ลองติจูด, ความลึก
        '2          Link
        '-----------------------------------------------------------------
        Dim mt As Integer
        Dim rx As New Regex("km")

        For i = 0 To noX(1).Count - 1

            _tn2 = Mid(ToLocalTime(Mid(noX(1).Item(i).ChildNodes(1).InnerText, 1, 19) & " GMT"), 1, 1)

            If _tn2 = "1" Or _tn2 = "10" Then

                mt = rx.Match(noX(1).Item(i).ChildNodes(1).InnerText).Index - 3
                ari0.Add(Mid(noX(1).Item(i).ChildNodes(0).InnerText, 2, 4).Replace(" ", ""))
                ari1.Add(Mid(noX(1).Item(i).ChildNodes(1).InnerText, mt, 6))
                ari2.Add(Mid(noX(1).Item(i).ChildNodes(1).InnerText, 20, 9).Replace(" ", "") & ", " & Mid(noX(1).Item(i).ChildNodes(1).InnerText, 30, 9).Replace(" ", ""))
                ari3.Add(Mid(noX(1).Item(i).ChildNodes(0).InnerText, 7).ToUpper)
                ari4.Add(ToLocalTime(Mid(noX(1).Item(i).ChildNodes(1).InnerText, 1, 19) & " GMT"))
                ari5.Add("GEOFON")
                ari6.Add(noX(1).Item(i).ChildNodes(2).InnerText)


            ElseIf Mid(Date.Now, 1, 2) <> "01" Then


                mt = rx.Match(noX(1).Item(i).ChildNodes(1).InnerText).Index - 3
                ari0.Add(Mid(noX(1).Item(i).ChildNodes(0).InnerText, 2, 4).Replace(" ", ""))
                ari1.Add(Mid(noX(1).Item(i).ChildNodes(1).InnerText, mt, 6))
                ari2.Add(Mid(noX(1).Item(i).ChildNodes(1).InnerText, 20, 9).Replace(" ", "") & ", " & Mid(noX(1).Item(i).ChildNodes(1).InnerText, 30, 9).Replace(" ", ""))
                ari3.Add(Mid(noX(1).Item(i).ChildNodes(0).InnerText, 7).ToUpper)
                ari4.Add(ToLocalTime(Mid(noX(1).Item(i).ChildNodes(1).InnerText, 1, 19) & " GMT"))
                ari5.Add("GEOFON")
                ari6.Add(noX(1).Item(i).ChildNodes(2).InnerText)

            End If

            'ari6.Add("http://geofon.gfz-potsdam.de/data/alerts/" & DateTime.Now.Year & "/" & noX(1).Item(i).ChildNodes(3).InnerText & "/" & noX(1).Item(i).ChildNodes(3).InnerText & "jpg")
            'ari7.Add(noX(1).Item(i).ChildNodes(2).InnerText)

        Next

        gfzOK = True

    End Sub

    Public Sub UpdateCsem()

        On Error Resume Next
        '0. ระดับ  / 1. ความลึก / 2. ละติจูด,ลองติจูด / 3. สถานที่ / 4. เมื่อ / 5. ผู้ประกาศ

        'Node       Info
        '==================
        '0          ระดับ , สถานที่
        '1          Link
        '2          ละติจูด
        '3          ลองติจูด
        '4          ความลึก
        '5          ระดับ
        '6          เวลา
        '--------------------------------------------------------------------

        For i = 0 To noX(2).Count - 1

            _tn3 = Mid(ToLocalTime(noX(2).Item(i).ChildNodes(6).InnerText.Replace("UTC", "GMT")), 1, 1)

            If _tn3 = "1" Or _tn3 = "10" Then

                ari0.Add(Mid(noX(2).Item(i).ChildNodes(0).InnerText, 2, 6).ToUpper.Replace("B", "").Replace("L", "".Replace("MW", "M")).Replace(" ", "").Replace("W", "").Replace("D", "").Replace("C", "").Replace("I", ""))
                ari1.Add(noX(2).Item(i).ChildNodes(4).InnerText & "km".Replace(" ", ""))
                ari2.Add(noX(2).Item(i).ChildNodes(2).InnerText & ", " & noX(2).Item(i).ChildNodes(3).InnerText)
                ari3.Add(Mid(noX(2).Item(i).ChildNodes(0).InnerText, 8).ToUpper)
                ari4.Add(ToLocalTime(noX(2).Item(i).ChildNodes(6).InnerText.Replace("UTC", "GMT")))
                ari5.Add("EMSC - CSEM")
                ari6.Add(noX(2).Item(i).ChildNodes(1).InnerText)

            ElseIf Mid(Date.Now, 1, 2) <> "01" Then

                ari0.Add(Mid(noX(2).Item(i).ChildNodes(0).InnerText, 2, 6).ToUpper.Replace("B", "").Replace("L", "".Replace("MW", "M")).Replace(" ", "").Replace("W", "").Replace("D", "").Replace("C", ""))
                ari1.Add(noX(2).Item(i).ChildNodes(4).InnerText & "km".Replace(" ", ""))
                ari2.Add(noX(2).Item(i).ChildNodes(2).InnerText & ", " & noX(2).Item(i).ChildNodes(3).InnerText)
                ari3.Add(Mid(noX(2).Item(i).ChildNodes(0).InnerText, 8).ToUpper)
                ari4.Add(ToLocalTime(noX(2).Item(i).ChildNodes(6).InnerText.Replace("UTC", "GMT")))
                ari5.Add("EMSC - CSEM")
                ari6.Add(noX(2).Item(i).ChildNodes(1).InnerText)

            End If


        Next

        csemOK = True

    End Sub

    Public Sub UpdateTmd()

        On Error Resume Next
        '0. ระดับ  / 1. ความลึก / 2. ละติจูด,ลองติจูด / 3. สถานที่ / 4. เมื่อ / 5. ผู้ประกาศ

        'Node       Info
        '==================
        '0          สถานที่ , ละติจุด/ลองติจูด , ขนาด ,  เมื่อ  
        '1          Link
        '2          เมื่อ, Lat/Long, ขนาด
        ' หมายเหตุ :   ความลึกไม่ระบุ
        '-------------------------------------------------------------------

        Dim len As Integer
        Dim rx As New Regex("ขนาด")


        For i = 0 To noX(3).Count - 1

            _tn4 = Mid(ToLocalTime(Mid(noX(3).Item(i).ChildNodes(2).InnerText, 1, 20)), 1, 1)

            If _tn4 = "1" Or _tn4 = "10" Then

                len = rx.Match(noX(3).Item(i).ChildNodes(0).InnerText).Index - 25
                ari0.Add(Mid(noX(3).Item(i).ChildNodes(2).InnerText, 61, 4).Replace(" ", "").Replace("<", ""))
                ari1.Add("ไม่ระบุ")
                ari2.Add(Mid(noX(3).Item(i).ChildNodes(2).InnerText, 33, 6) & ", " & Mid(noX(3).Item(i).ChildNodes(2).InnerText, 46, 6))
                ari3.Add(Mid(noX(3).Item(i).ChildNodes(0).InnerText, 12, len).Replace("(", "").Replace(")", ""))
                ari4.Add(ToLocalTime(Mid(noX(3).Item(i).ChildNodes(2).InnerText, 1, 20)))
                ari5.Add("กรมอุตุนิยมวิทยา")
                ari6.Add(noX(3).Item(i).ChildNodes(1).InnerText)


            ElseIf Mid(Date.Now, 1, 2) <> "01" Then

                len = rx.Match(noX(3).Item(i).ChildNodes(0).InnerText).Index - 25
                ari0.Add(Mid(noX(3).Item(i).ChildNodes(2).InnerText, 61, 4).Replace(" ", "").Replace("<", ""))
                ari1.Add("ไม่ระบุ")
                ari2.Add(Mid(noX(3).Item(i).ChildNodes(2).InnerText, 33, 6) & ", " & Mid(noX(3).Item(i).ChildNodes(2).InnerText, 46, 6))
                ari3.Add(Mid(noX(3).Item(i).ChildNodes(0).InnerText, 12, len).Replace("(", "").Replace(")", ""))
                ari4.Add(ToLocalTime(Mid(noX(3).Item(i).ChildNodes(2).InnerText, 1, 20)))
                ari5.Add("กรมอุตุนิยมวิทยา")
                ari6.Add(noX(3).Item(i).ChildNodes(1).InnerText)

            End If

        Next

        tmdOK = True

    End Sub

    Public Sub FillUpdate()

        UpdateUSGS()
        UpdateGFZ()
        UpdateCsem()
        UpdateTmd()

    End Sub

    Public Function isLastUpdate() As Boolean

        If oldTime <> lastTime Then

            oldTime = ari4(0)

            Return True

        Else

            Return False

        End If


    End Function


    Public Sub DefragQuakeList()


        Dim _date1, _date2 As DateTime
        Dim _pub1, _pub2 As String
        Dim _lv1, _lv2 As String
        Dim _local1, _local2 As String
        Dim _dep1, _dep2 As String
        Dim _L1, _L2 As String
        Dim _url1, _url2 As String

        For x = 0 To ari0.Count

            For i = 0 To ari4.Count - 1

                Try

                    If (ari4(i) < ari4(i + 1)) Then

                        _date1 = ari4(i)
                        _date2 = ari4(i + 1)
                        'ari4(i) = _date2
                        'ari4(i + 1) = _date1
                        ari4.RemoveAt(i)
                        ari4.Insert(i, _date2)
                        ari4.RemoveAt(i + 1)
                        ari4.Insert(i + 1, _date1)



                        _url1 = ari6(i)
                        _url2 = ari6(i + 1)
                        'ari6(i) = _url2
                        'ari6(i + 1) = _url1
                        ari6.RemoveAt(i)
                        ari6.Insert(i, _url2)
                        ari6.RemoveAt(i + 1)
                        ari6.Insert(i + 1, _url1)



                        _dep1 = ari1(i)
                        _dep2 = ari1(i + 1)
                        'ari1(i) = _dep2
                        'ari1(i + 1) = _dep1
                        ari1.RemoveAt(i)
                        ari1.Insert(i, _dep2)
                        ari1.RemoveAt(i + 1)
                        ari1.Insert(i + 1, _dep1)



                        _L1 = ari2(i)
                        _L2 = ari2(i + 1)
                        'ari2(i) = _L2
                        'ari2(i + 1) = _L1
                        ari2.RemoveAt(i)
                        ari2.Insert(i, _L2)
                        ari2.RemoveAt(i + 1)
                        ari2.Insert(i + 1, _L1)



                        _local1 = ari3(i)
                        _local2 = ari3(i + 1)
                        'ari3(i) = _local2
                        'ari3(i + 1) = _local1
                        ari3.RemoveAt(i)
                        ari3.Insert(i, _local2)
                        ari3.RemoveAt(i + 1)
                        ari3.Insert(i + 1, _local1)



                        _pub1 = ari5(i)
                        _pub2 = ari5(i + 1)
                        'ari5(i) = _pub2
                        'ari5(i + 1) = _pub1
                        ari5.RemoveAt(i)
                        ari5.Insert(i, _pub2)
                        ari5.RemoveAt(i + 1)
                        ari5.Insert(i + 1, _pub1)



                        _lv1 = ari0(i)
                        _lv2 = ari0(i + 1)
                        'ari0(i) = _lv2
                        'ari0(i + 1) = _lv1
                        ari0.RemoveAt(i)
                        ari0.Insert(i, _lv2)
                        ari0.RemoveAt(i + 1)
                        ari0.Insert(i + 1, _lv1)


                    End If

                Catch ex As Exception

                End Try

            Next

        Next

    End Sub

    Public Sub DefragTimeUTC()

        For i = 0 To ari4.Count - 1

            ari4(i) = ToLocalTime(ari4(i))

        Next

    End Sub

    Private Sub clearDataArray()

        ari0.Clear()
        ari1.Clear()
        ari2.Clear()
        ari3.Clear()
        ari4.Clear()
        ari5.Clear()
        ari6.Clear()

    End Sub


    Public Function CleanInput(ByVal strIn As String) As String

        Return Regex.Replace(strIn, "[^A-Z0-9,+""]", "")

    End Function


End Class



