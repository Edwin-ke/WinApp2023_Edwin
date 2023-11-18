Imports System.Windows.Forms
Imports System.Drawing

Public Class Cliente_entitie
    Private Id As Integer
    Private Nombre As String
    Private ApellidoP As String
    Private ApellidoM As String
    Private RFC As Integer
    Private Correo As String

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
    Public Property _ApellidoP() As String
        Get
            Return ApellidoP
        End Get
        Set(ByVal value As String)
            ApellidoP = value
        End Set
    End Property
    Public Property _ApellidoM() As String
        Get
            Return ApellidoM
        End Get
        Set(ByVal value As String)
            ApellidoM = value
        End Set
    End Property
    Public Property __RFC() As Integer
        Get
            Return RFC
        End Get
        Set(ByVal value As Integer)
            RFC = value
        End Set
    End Property
    Public Property _Correo() As String
        Get
            Return Correo
        End Get
        Set(ByVal value As String)
            Correo = value
        End Set
    End Property
End Class
