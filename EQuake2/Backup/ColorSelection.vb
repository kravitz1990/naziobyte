
Module ColorSelection


    Public IsColv1, IsColv2, IsColv3, IsColv4, IsColv5, IsColv6, IsColv7, IsColv8, IsColv9, IsColv10 As Boolean
    Public setColv1, setColv2, setColv3, setColv4, setColv5, setColv6, setColv7, setColv8, setColv9, setColv10 As Color

    Public Sub GenerateGridLevelColor()

        On Error Resume Next

        Dim grid = Form1.grid


        For i = 0 To grid.Rows.Count - 1


            If Double.Parse(grid.Item(0, i).Value) >= 0.1 And Double.Parse(grid.Item(0, i).Value) <= 0.9 Then

                grid.Item(0, i).Style.BackColor = setColv1

            End If



            If Double.Parse(grid.Item(0, i).Value) >= 1.0 And Double.Parse(grid.Item(0, i).Value) <= 1.9 Then

                grid.Item(0, i).Style.BackColor = setColv2

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 2.0 And Double.Parse(grid.Item(0, i).Value) <= 2.9 Then

                grid.Item(0, i).Style.BackColor = setColv3

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 3.0 And Double.Parse(grid.Item(0, i).Value) <= 3.9 Then

                grid.Item(0, i).Style.BackColor = setColv4

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 4.0 And Double.Parse(grid.Item(0, i).Value) <= 4.9 Then

                grid.Item(0, i).Style.BackColor = setColv5

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 5.0 And Double.Parse(grid.Item(0, i).Value) <= 5.9 Then

                grid.Item(0, i).Style.BackColor = setColv6

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 6.0 And Double.Parse(grid.Item(0, i).Value) <= 6.9 Then

                grid.Item(0, i).Style.BackColor = setColv7

            End If

            If Double.Parse(grid.Item(0, i).Value) >= 7.0 And Double.Parse(grid.Item(0, i).Value) <= 7.9 Then

                grid.Item(0, i).Style.BackColor = setColv8

            End If


            If Double.Parse(grid.Item(0, i).Value) >= 8.0 And Double.Parse(grid.Item(0, i).Value) <= 8.9 Then

                grid.Item(0, i).Style.BackColor = setColv9

            End If



            If Double.Parse(grid.Item(0, i).Value) >= 9.0 Then

                grid.Item(0, i).Style.BackColor = setColv10


            End If



        Next


    End Sub



    Public Sub setColorLevel_1(ByVal col As Color)

        setColv1 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_1()

        setColv1 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_2(ByVal col As Color)

        setColv2 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_2()

        setColv2 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_3(ByVal col As Color)

        setColv3 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_3()

        setColv3 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_4(ByVal col As Color)

        setColv4 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_4()

        setColv4 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_5(ByVal col As Color)

        setColv5 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_5()

        setColv5 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_6(ByVal col As Color)

        setColv6 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_6()

        setColv6 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_7(ByVal col As Color)

        setColv7 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_7()

        setColv7 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_8(ByVal col As Color)

        setColv8 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_8()

        setColv8 = Nothing
        GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_9(ByVal col As Color)

        setColv9 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_9()

        setColv9 = Nothing
        GenerateGridLevelColor()

    End Sub


    Public Sub setColorLevel_10(ByVal col As Color)

        setColv10 = col
        GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_10()

        setColv10 = Nothing
        GenerateGridLevelColor()

    End Sub




End Module
