Public Class ServiceUpdate

    Private Sub ServiceUpdate_Load(sender As Object, e As EventArgs) Handles MyBase.Load



    End Sub

    Private Sub ServiceUpdate_Move(sender As Object, e As EventArgs) Handles Me.Move

       
    End Sub


    Protected Overrides ReadOnly Property CreateParams() As CreateParams
        Get
            Dim cp As CreateParams = MyBase.CreateParams
            Const CS_DBLCLKS As Int32 = &H8
            Const CS_NOCLOSE As Int32 = &H200
            cp.ClassStyle = CS_DBLCLKS Or CS_NOCLOSE
            Return cp
        End Get
    End Property


End Class