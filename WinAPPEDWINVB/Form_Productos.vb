Imports Negocios
Imports Entidades
Imports System.Windows.Forms

Public Class Form_Productos

    Dim com As New Negocios.Comunicacion
    Public Sub Mostrar()
        cbx_Provedor.Visible = True
        cbx_Provedor.Visible = True
        btnBuscar.PerformClick()
        cbx_Provedor.DataSource = com.TraeProveedores()
        cbx_Provedor.DisplayMember = "_Nombre"
    End Sub
    Public Sub NoMostrar()
        cbx_Provedor.Visible = False
        txt_Producto.Visible = True
    End Sub
    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles btnBuscar.Click
        dgvProductos.DataSource = com.Traer_Productos()

        dgvProductos.Columns("_Id").Visible = False
        dgvProductos.Columns("_Nombre").HeaderText = "Producto"
        dgvProductos.Columns("_Nombre").DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft
        dgvProductos.Columns("_Nombre").Width = 180
        dgvProductos.Columns("_Nombre").ReadOnly = True
    End Sub

    Private Sub btnBorrar_Click(sender As Object, e As EventArgs) Handles btnBorrar.Click
        Close()
    End Sub

    Private Sub Form_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub
End Class