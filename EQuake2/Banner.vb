Imports System.Threading

Public Class Banner

    Private Sub Banner_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Me.Width = PictureBox1.Size.Width - 1
        Me.Height = PictureBox1.Size.Height - 1

        Label1.Parent = PictureBox1
        Label1.BackColor = Color.Transparent
        

    End Sub



    
End Class