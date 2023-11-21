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



    'Public Fuction Trae_Proveedores() As List(Of Entidades.Producto_entitie)
    ' D




End Class
