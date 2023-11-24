Imports Negocios
Imports Entidades
Imports System.Windows.Forms

Public Class Form_Productos

    Dim com As New Negocios.Comunicacion

    Private Sub GroupBox1_Enter(sender As Object, e As EventArgs) Handles GroupBox1.Enter

    End Sub
    Public Sub Mostrar()
        cbx_Provedor.Visible = False
        txt_Producto.Visible = True
        btnBuscar.PerformClick()
        cbx_Provedor.DataSource = com.TraeProveedores()
        cbx_Provedor.DisplayMember = "_Nombre"
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvProductos.DataSource = com.Traer_Productos()

        dgvProductos.Columns("_Id").Visible = False
        dgvProductos.Columns("_Nombre").HeaderText = "Producto"
        dgvProductos.Columns("_Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProductos.Columns("_Nombre").Width = 180
        dgvProductos.Columns("_Nombre").ReadOnly = True

    End Sub


End Class