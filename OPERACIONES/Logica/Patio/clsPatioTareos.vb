Public Class clsPatioTareos
    Private _idtareo As Integer
    Public Property IDTAREO() As Integer
        Get
            Return _idtareo
        End Get
        Set(ByVal value As Integer)
            _idtareo = value
        End Set
    End Property
    Private _idot As Integer
    Public Property IDOT() As Integer
        Get
            Return _idot
        End Get
        Set(ByVal value As Integer)
            _idot = value
        End Set
    End Property
    Private _idpersonal As Integer
    Public Property IDPERSONAL() As Integer
        Get
            Return _idpersonal
        End Get
        Set(ByVal value As Integer)
            _idpersonal = value
        End Set
    End Property
    Private _descripcion As String
    Public Property DESCRIPCION() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property
    Private _observacion As String
    Public Property OBSERVACION() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property
    Private _usuario As String
    Public Property USUARIO() As String
        Get
            Return _usuario
        End Get
        Set(ByVal value As String)
            _usuario = value
        End Set
    End Property
End Class
