Imports System.Windows.Forms
Imports System.Drawing

Public Class Detalle_Ventas_entitie
    Private Factura As Integer
    Private Cantidad As Integer

    Public Property _Factura() As Integer
        Get
            Return Factura
        End Get
        Set(ByVal value As Integer)
            Factura = value
        End Set
    End Property
    Public Property _Cantidad() As Integer
        Get
            Return Cantidad
        End Get
        Set(ByVal value As Integer)
            Cantidad = value
        End Set
    End Property
End Class
