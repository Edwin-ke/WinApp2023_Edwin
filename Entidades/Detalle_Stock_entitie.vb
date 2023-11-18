Imports System.Windows.Forms
Imports System.Drawing
Public Class DetalleStokvb
    Private Id As Integer
    Private Salidas As Integer
    Private Entradas As Integer
    Private Total As Integer
    Private Fecha As DateTime

    Public Property _Id() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property
    Public Property _Salidas() As Integer
        Get
            Return Salidas
        End Get
        Set(ByVal value As Integer)
            Salidas = value
        End Set
    End Property
    Public Property _Entradas() As Integer
        Get
            Return Entradas
        End Get
        Set(ByVal value As Integer)
            Entradas = value
        End Set
    End Property
    Public Property _Total() As Integer
        Get
            Return Total
        End Get
        Set(ByVal value As Integer)
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
