Module SettingAsync

    'ระดับที่ต้องการเตือน
    'รูปแบบเสียง 'จำนวนรอบเสียง
    'ข้อความ

    Public isShowPersonalMessage, isSendFacebookMessage, isSendTwitterMessage, isSendEmailMessage, isSendNetworkMessage As Boolean
    Public isPlaySound As Boolean = True
    Public playmode As Integer = 2
    Public cQuakeLevel As Double = 1.0
    Public soundPath As String = "C:\Program Files (x86)\Earthquake Realtime Checker\quakeAlert_10.wav"

    Public mailUser, mailPassword As String
    Public SSL As Boolean
    Public HOST As String
    Public PORT As Integer



End Module
