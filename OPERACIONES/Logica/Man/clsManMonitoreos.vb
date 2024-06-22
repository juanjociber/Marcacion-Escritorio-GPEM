Public Class clsManMonitoreos
    Private _idmonitoreo As Integer
    Public Property IDMONITOREO() As Integer
        Get
            Return _idmonitoreo
        End Get
        Set(ByVal value As Integer)
            _idmonitoreo = value
        End Set
    End Property
    Private _idcomponente As Integer
    Public Property IDCOMPONENTE() As Integer
        Get
            Return _idcomponente
        End Get
        Set(ByVal value As Integer)
            _idcomponente = value
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
    Private _idactivo As Integer
    Public Property IDACTIVO() As Integer
        Get
            Return _idactivo
        End Get
        Set(ByVal value As Integer)
            _idactivo = value
        End Set
    End Property
    Private _ideval As Integer
    Public Property IDEVAL() As Integer
        Get
            Return _ideval
        End Get
        Set(ByVal value As Integer)
            _ideval = value
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
    Private _ot As String
    Public Property OT() As String
        Get
            Return _ot
        End Get
        Set(ByVal value As String)
            _ot = value
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
    Private _tipoot As String
    Public Property TIPOOT() As String
        Get
            Return _tipoot
        End Get
        Set(ByVal value As String)
            _tipoot = value
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
    Private _observaciones As String
    Public Property OBSERVACIONES() As String
        Get
            Return _observaciones
        End Get
        Set(ByVal value As String)
            _observaciones = value
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
