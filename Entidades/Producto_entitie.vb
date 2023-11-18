Imports System.Windows.Forms
Imports System.Drawing

Public Class Producto_entitie
    Private Id As Integer
    Private Nombre As String
    Private PrecioC As Double
    Private PrecioV As Double
    Private Imagen As Byte()
    Private Fecha As DateTime

    Public Property _Id() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property

    Public Property _Nombre() As String
        Get
            Return Nombre
        End Get
        Set(ByVal value As String)
            Nombre = value
        End Set
    End Property

    Public Property _PrecioC() As Double
        Get
            Return PrecioC
        End Get
        Set(ByVal value As Double)
            PrecioC = value
        End Set
    End Property

    Public Property _PrecioV() As Double
        Get
            Return PrecioV
        End Get
        Set(ByVal value As Double)
            PrecioV = value
        End Set
    End Property

    Public Property _Imagen() As Byte()
        Get
            Return Imagen
        End Get
        Set(ByVal value As Byte())
            Imagen = value
        End Set
    End Property

    Public Property _Fecha() As DateTime
        Get
            Return Fecha
        End Get
        Set(ByVal value As DateTime)
            Fecha = value
        End Set
    End Property
End Class
