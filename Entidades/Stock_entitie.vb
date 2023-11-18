Imports System.Windows.Forms
Imports System.Drawing
Public Class Stock_entitie
    Private Id As Integer
    Private Cantidad As Integer
    Private FechaIngreso As DateTime

    Public Property _Id() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
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
    Public Property _FechaIngreso() As DateTime
        Get
            Return FechaIngreso
        End Get
        Set(ByVal value As DateTime)
            FechaIngreso = value
        End Set
    End Property
End Class
