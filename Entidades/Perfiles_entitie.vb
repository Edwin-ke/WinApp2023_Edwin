Imports System.Windows.Forms
Imports System.Drawing
Public Class Perfiles_entitie
    Private Id As Integer
    Private Puesto As String

    Public Property _Id() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property
    Public Property _Puesto() As String
        Get
            Return Puesto
        End Get
        Set(ByVal value As String)
            Puesto = value
        End Set
    End Property
End Class
