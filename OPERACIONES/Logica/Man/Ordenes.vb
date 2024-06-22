Public Class Orden
    Private _id As Integer
    Private _idactivo As Integer
    Private _idactividad As Integer
    Private _orden As String
    Private _activo As String
    Private _tipoorden As String
    Private _fecha As String
    Private _actividad As String
    Private _descripcion As String
    Private _observacion As String
    Private _km As Integer
    Private _supervisor As String
    Private _cliente As String
    Private _estado As Integer

    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property

    Public Property IdActivo() As Integer
        Get
            Return _idactivo
        End Get
        Set(ByVal value As Integer)
            _idactivo = value
        End Set
    End Property

    Public Property IdActividad() As Integer
        Get
            Return _idactividad
        End Get
        Set(ByVal value As Integer)
            _idactividad = value
        End Set
    End Property

    Public Property Orden() As String
        Get
            Return _orden
        End Get
        Set(ByVal value As String)
            _orden = value
        End Set
    End Property

    Public Property Activo() As String
        Get
            Return _activo
        End Get
        Set(ByVal value As String)
            _activo = value
        End Set
    End Property

    Public Property TipoOrden() As String
        Get
            Return _tipoorden
        End Get
        Set(ByVal value As String)
            _tipoorden = value
        End Set
    End Property

    Public Property Fecha() As String
        Get
            Return _fecha
        End Get
        Set(ByVal value As String)
            _fecha = value
        End Set
    End Property

    Public Property Actividad() As String
        Get
            Return _actividad
        End Get
        Set(ByVal value As String)
            _actividad = value
        End Set
    End Property

    Public Property Descripcion() As String
        Get
            Return _descripcion
        End Get
        Set(ByVal value As String)
            _descripcion = value
        End Set
    End Property

    Public Property Observacion() As String
        Get
            Return _observacion
        End Get
        Set(ByVal value As String)
            _observacion = value
        End Set
    End Property

    Public Property Km() As Integer
        Get
            Return _km
        End Get
        Set(ByVal value As Integer)
            _km = value
        End Set
    End Property

    Public Property Supervisor() As String
        Get
            Return _supervisor
        End Get
        Set(ByVal value As String)
            _supervisor = value
        End Set
    End Property

    Public Property Cliente() As String
        Get
            Return _cliente
        End Get
        Set(ByVal value As String)
            _cliente = value
        End Set
    End Property

    Public Property Estado() As Integer
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer)
            _estado = value
        End Set
    End Property
End Class
