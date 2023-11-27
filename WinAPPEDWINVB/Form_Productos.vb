Imports Negocios
Imports Entidades
Imports System.Windows.Forms
Imports System.Drawing
Imports System.IO

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
        Dim id = txt_Producto.Text
        Dim nombre = txt_nombre.Text
        com.Eliminar_productos(id, Convert.ToString(nombre))
    End Sub

    Private Sub btnGuardar_Click(sender As Object, e As EventArgs) Handles btnGuardar.Click
        Dim id_prod = txt_Producto.Text
        Dim id_prov = cbx_Provedor.Text
        Dim nombre = txt_nombre.Text
        Dim precio_c = txt_pc.Text
        Dim precio_v = txt_pv.Text
        Dim Fecha = DateTimePicker1.Text
        Dim Imagens As Drawing.Image
        Imagens = PictureBox1.Image
        Dim Imagen = ImagenToBytes(Imagens)
        com.InsertayModifica_Productos(id_prod, id_prov, nombre, precio_c, precio_v, Fecha, Imagen)
    End Sub

    Private Sub Form_Productos_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Mostrar()
    End Sub

    Private Sub txt_Producto_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_Producto.KeyPress
        If Char.IsNumber(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_nombre_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_nombre.KeyPress
        If Char.IsLetter(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsControl(e.KeyChar) Then
            e.Handled = False
        ElseIf Char.IsSeparator(e.KeyChar) Then
            e.Handled = False
        Else
            e.Handled = True
        End If
    End Sub

    Private Sub txt_pv_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pv.KeyPress
        Dim cadena As String = txt_pv.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            txt_pv.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            txt_pv.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If


    End Sub

    Private Sub txt_pc_KeyPress(sender As Object, e As KeyPressEventArgs) Handles txt_pc.KeyPress
        Dim cadena As String = txt_pc.Text
        Dim filtro As String = "1234567890"

        If Len(cadena) > 0 Then
            filtro += "."
        End If

        For Each caracter In filtro
            If e.KeyChar = caracter Then
                e.Handled = False
                Exit For
            Else
                e.Handled = True
            End If
        Next

        If e.KeyChar = "0" And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            txt_pc.Text = ""
        ElseIf e.KeyChar <> "0" And e.KeyChar <> "." And Mid(cadena, 1, 1) = "0" And Len(cadena) = 1 Then
            txt_pc.Text = ""
        End If

        If Char.IsControl(e.KeyChar) Then
            e.Handled = False
        End If

        If e.KeyChar = "." And Not cadena.IndexOf(".") Then
            e.Handled = True
        End If
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim file As New OpenFileDialog()
        file.Filter = "Archivo JPG|*.jpg"
        If file.ShowDialog() = DialogResult.OK Then
            PictureBox1.Image = Drawing.Image.FromFile(file.FileName)
        End If
    End Sub

    Public Function ImagenToBytes(ByVal Imagen As Image) As Byte()
        Dim arreglo As Byte() = Nothing
        Try
            If Not Imagen Is Nothing Then
                Dim Bin As New MemoryStream
                Imagen.Save(Bin, Imaging.ImageFormat.Jpeg)
                arreglo = Bin.GetBuffer
            Else
                Return Nothing
            End If
        Catch ex As Exception
            MsgBox("No convirtio a bytes por: " + ex.ToString)
        End Try
        Return arreglo
    End Function
End Class