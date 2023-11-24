Public Class Form_Productos

    Dim com As New Negocios.Comunicacion
    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        DataGridView1.DataSource = com.Traer_Productos()


    End Sub
End Class