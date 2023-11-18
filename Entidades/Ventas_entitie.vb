Imports System.Windows.Forms
Imports System.Drawing
Public Class Ventas_entitie
    Private Clave As Integer
    Private SubT As Double
    Private Iva As Double
    Private Total As Double
    Private Fecha As DateTime
    Public Property _Clave() As Integer
        Get
            Return Clave
        End Get
        Set(ByVal value As Integer)
            Clave = value
        End Set
    End Property
    Public Property _SubT() As Double
        Get
            Return SubT
        End Get
        Set(ByVal value As Double)
            SubT = value
        End Set
    End Property
    Public Property _Iva() As Double
        Get
            Return Iva
        End Get
        Set(ByVal value As Double)
            Iva = value
        End Set
    End Property
    Public Property _Total() As Double
        Get
            Return Total
        End Get
        Set(ByVal value As Double)
            Total = value
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
