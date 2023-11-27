Imports AccesoDatos
Imports Entidades
Imports System.Data.Linq





Public Class Comunicacion
    'intanciando a nuestro linq
    Dim db As New DataClasses3DataContext
    'Codigo de consuilta en el que se utiliza el encapsulamiento 
    Public Function TraeProveedores() As List(Of Entidades.Producto_entitie)
        Dim q = From P In db.Trae_provedores()
                Select New Entidades.Producto_entitie _
                With {
                    ._Id = P.Id_Prov,
                    ._Nombre = P.Nombre}

        Return q.ToList
    End Function
    Public Function Traer_Productos() As List(Of Entidades.Producto_entitie)
        Dim q = From P In db.Trae_producto()
                Select New Entidades.Producto_entitie _
        With
                {
                ._Nombre = P.Nombre,
                ._PrecioC = Convert.ToDouble(P.Precio_C)}
        Return q.ToList



    End Function

    Public Sub Eliminar_productos(ByVal id As Integer, ByVal nombre As String)
        db.Elimina_producto(id, nombre)
        db.SubmitChanges()
    End Sub

    Public Sub InsertayModifica_Productos(ByVal id_prod As Integer, ByVal id_prov As Integer, ByVal nombre As String, ByVal precio_c As Double, ByVal precio_v As Double, ByVal Fecha As DateTime, ByVal Imagen As Byte())
        db.Inserta_actualizaProducto(id_prod, id_prov, Convert.ToString(nombre), Convert.ToDecimal(precio_c), Convert.ToDecimal(precio_v), Imagen, Convert.ToDateTime(Fecha))
        db.SubmitChanges()
    End Sub

End Class
