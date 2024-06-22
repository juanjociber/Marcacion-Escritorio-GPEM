Public Class clsManComponentes
    Private _idcomponente As Integer
    Public Property IDCOMPONENTE() As Integer
        Get
            Return _idcomponente
        End Get
        Set(ByVal value As Integer)
            _idcomponente = value
        End Set
    End Property
    Private _idcliente As Integer
    Public Property IDCLIENTE() As Integer
        Get
            Return _idcliente
        End Get
        Set(ByVal value As Integer)
            _idcliente = value
        End Set
    End Property
    Private _idsistema As Integer
    Public Property IDSISTEMA() As Integer
        Get
            Return _idsistema
        End Get
        Set(ByVal value As Integer)
            _idsistema = value
        End Set
    End Property
    Private _activo As String
    Public Property ACTIVO() As String
        Get
            Return _activo
        End Get
        Set(ByVal value As String)
            _activo = value
        End Set
    End Property
    Private _sistema As String
    Public Property SISTEMA() As String
        Get
            Return _sistema
        End Get
        Set(ByVal value As String)
            _sistema = value
        End Set
    End Property
    Private _codigo As String
    Public Property CODIGO() As String
        Get
            Return _codigo
        End Get
        Set(ByVal value As String)
            _codigo = value
        End Set
    End Property
    Private _componente As String
    Public Property COMPONENTE() As String
        Get
            Return _componente
        End Get
        Set(ByVal value As String)
            _componente = value
        End Set
    End Property
    Private _serie As String
    Public Property SERIE() As String
        Get
            Return _serie
        End Get
        Set(ByVal value As String)
            _serie = value
        End Set
    End Property
    Private _marca As String
    Public Property MARCA() As String
        Get
            Return _marca
        End Get
        Set(ByVal value As String)
            _marca = value
        End Set
    End Property
    Private _modelo As String
    Public Property MODELO() As String
        Get
            Return _modelo
        End Get
        Set(ByVal value As String)
            _modelo = value
        End Set
    End Property
    Private _disponible As Integer
    Public Property DISPONIBLE() As Integer
        Get
            Return _disponible
        End Get
        Set(ByVal value As Integer)
            _disponible = value
        End Set
    End Property
    Private _estado As Integer
    Public Property ESTADO() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property

    Private _km As Integer
    Public Property KM() As Integer
        Get
            Return _km
        End Get
        Set(ByVal value As Integer)
            _km = value
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
