Imports System.IO

Module ColorSelection


    Public IsColv1, IsColv2, IsColv3, IsColv4, IsColv5, IsColv6, IsColv7, IsColv8, IsColv9, IsColv10 As Boolean
    Dim myColorFile As String = CurDir() & "\ColConf.dat"
    Public setColv1, setColv2, setColv3, setColv4, setColv5, setColv6, setColv7, setColv8, setColv9, setColv10 As String


    Public Sub setColorLevel_1(ByVal col As String)

        setColv1 = col
        IsColv1 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_1()

        setColv1 = "White"
        IsColv1 = False
        iSaveSettingColorAsync()
        'GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_2(ByVal col As String)

        setColv2 = col
        IsColv2 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_2()

        setColv2 = "White"
        IsColv2 = False
        iSaveSettingColorAsync()
        '  GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_3(ByVal col As String)

        setColv3 = col
        IsColv3 = True
        iSaveSettingColorAsync()
        'GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_3()

        setColv3 = "White"
        IsColv3 = False
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_4(ByVal col As String)

        setColv4 = col
        IsColv4 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_4()

        setColv4 = "White"
        IsColv4 = False
        iSaveSettingColorAsync()
        'GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_5(ByVal col As String)

        setColv5 = col
        IsColv5 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_5()


        setColv5 = "White"
        IsColv5 = False
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_6(ByVal col As String)

        setColv6 = col
        IsColv6 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_6()

        setColv6 = "White"
        IsColv6 = False
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_7(ByVal col As String)

        setColv7 = col
        IsColv7 = True
        iSaveSettingColorAsync()
        'GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_7()

        setColv7 = "White"
        IsColv7 = False
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_8(ByVal col As String)

        setColv8 = col
        IsColv8 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_8()

        setColv8 = "White"
        IsColv8 = False
        iSaveSettingColorAsync()
        'GenerateGridLevelColor()

    End Sub

    Public Sub setColorLevel_9(ByVal col As String)

        setColv9 = col
        IsColv9 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_9()

        setColv9 = "White"
        IsColv9 = False
        iSaveSettingColorAsync()
        'GenerateGridLevelColor()

    End Sub


    Public Sub setColorLevel_10(ByVal col As String)

        setColv10 = col
        IsColv10 = True
        iSaveSettingColorAsync()
        ' GenerateGridLevelColor()

    End Sub

    Public Sub unSetColorLevel_10()

        setColv10 = "White"
        IsColv10 = False
        iSaveSettingColorAsync()
        'GenerateGridLevelColor()

    End Sub


    Public Sub iSaveSettingColorAsync()


        'Dim colWrite As StreamWriter
        'colWrite = File.CreateText(myColorFile)
        ' colWrite.Close()


        My.Settings.IsColv1 = IsColv1
        My.Settings.IsColv2 = IsColv2
        My.Settings.IsColv3 = IsColv3
        My.Settings.IsColv4 = IsColv4
        My.Settings.IsColv5 = IsColv5
        My.Settings.IsColv6 = IsColv6
        My.Settings.IsColv7 = IsColv7
        My.Settings.IsColv8 = IsColv8
        My.Settings.IsColv9 = IsColv9
        My.Settings.IsColv10 = IsColv10
        My.Settings.setColv1 = setColv1
        My.Settings.setColv2 = setColv2
        My.Settings.setColv3 = setColv3
        My.Settings.setColv4 = setColv4
        My.Settings.setColv5 = setColv5
        My.Settings.setColv6 = setColv6
        My.Settings.setColv7 = setColv7
        My.Settings.setColv8 = setColv8
        My.Settings.setColv9 = setColv9
        My.Settings.setColv10 = setColv10
        My.Settings.Save()



    End Sub

    Public Sub iLoadSettingColorAsync()

        ' Dim colRead As StreamReader
        ' If File.Exists(myColorFile) Then

        ' colRead = File.OpenText(myColorFile)

        IsColv1 = My.Settings.IsColv1
        IsColv2 = My.Settings.IsColv2
        IsColv3 = My.Settings.IsColv3
        IsColv4 = My.Settings.IsColv4
        IsColv5 = My.Settings.IsColv5
        IsColv6 = My.Settings.IsColv6
        IsColv7 = My.Settings.IsColv7
        IsColv8 = My.Settings.IsColv8
        IsColv9 = My.Settings.IsColv9
        IsColv10 = My.Settings.IsColv10
        setColv1 = My.Settings.setColv1
        setColv2 = My.Settings.setColv2
        setColv3 = My.Settings.setColv3
        setColv4 = My.Settings.setColv4
        setColv5 = My.Settings.setColv5
        setColv6 = My.Settings.setColv6
        setColv7 = My.Settings.setColv7
        setColv8 = My.Settings.setColv8
        setColv9 = My.Settings.setColv9
        setColv10 = My.Settings.setColv10

        'colRead.Close()
        'Console.WriteLine(setColv1)
        'Console.WriteLine(setColv3)
        'Console.WriteLine(setColv5)
        'Console.WriteLine(setColv9)
        'Console.WriteLine(setColv10)

        ' End If


    End Sub

End Module
