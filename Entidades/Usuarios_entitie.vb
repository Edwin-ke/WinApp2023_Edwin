Imports System.Windows.Forms
Imports System.Drawing
Public Class Usuarios_entitie
    Private Id As Integer
    Private Usuario As String
    Private Password As String
    Public Property _Id() As Integer
        Get
            Return Id
        End Get
        Set(ByVal value As Integer)
            Id = value
        End Set
    End Property
    Public Property _Usuario() As String
        Get
            Return Usuario
        End Get
        Set(ByVal value As String)
            Usuario = value
        End Set
    End Property
    Public Property _Password() As String
        Get
            Return Password
        End Get
        Set(ByVal value As String)
            Password = value
        End Set
    End Property
End Class
