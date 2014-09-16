Public Class tanchuditu

    Private Sub tanchuditu_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        PictureBox1.ImageLocation = "" & App_Path() & "\data\map\" & dituzhikong.ComboBox1.Text & ".jpg"
    End Sub
End Class