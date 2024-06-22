Public Class Tareo
    Public Property Id As Integer
    Public Property OrdenId As Integer
    Public Property PersonalId As Integer
    Public Property PersonalNombre As String
    Public Property FechaIngreso As Date
    Public Property FechaIngresoRefrigerio As Date
    Public Property FechaSalidaRefrigerio As Date
    Public Property FechaSalida As Date
    Public Property Minutos As Decimal
    Public Property Estado As Integer
End Class

Public Class OrdenTareo
    Inherits Tareo
    Public Property OrdenNombre As String
    Public Property OrdenActividad As String
    Public Property OrdenDescripcion As String
    Public Property OrdenObservacion As String
    Public Property EquipoNombre As String
End Class



'Public Class TareoPorOrden
'    Private _id As Integer
'    Private _idorden As Integer
'    Private _orden As String
'    Private _activo As String
'    Private _fechainicial As String
'    Private _fechafinal As String
'    Private _actividad As String
'    Private _estado As Integer

'    Public Property Id() As Integer
'        Get
'            Return _id
'        End Get
'        Set(ByVal value As Integer)
'            _id = value
'        End Set
'    End Property

'    Public Property IdOrden() As Integer
'        Get
'            Return _idorden
'        End Get
'        Set(ByVal value As Integer)
'            _idorden = value
'        End Set
'    End Property

'    Public Property Orden() As String
'        Get
'            Return _orden
'        End Get
'        Set(ByVal value As String)
'            _orden = value
'        End Set
'    End Property

'    Public Property Activo() As String
'        Get
'            Return _activo
'        End Get
'        Set(ByVal value As String)
'            _activo = value
'        End Set
'    End Property

'    Public Property FechaInicial() As String
'        Get
'            Return _fechainicial
'        End Get
'        Set(ByVal value As String)
'            _fechainicial = value
'        End Set
'    End Property

'    Public Property FechaFinal() As String
'        Get
'            Return _fechafinal
'        End Get
'        Set(ByVal value As String)
'            _fechafinal = value
'        End Set
'    End Property

'    Public Property Actividad() As String
'        Get
'            Return _actividad
'        End Get
'        Set(ByVal value As String)
'            _actividad = value
'        End Set
'    End Property

'    Public Property Estado() As Integer
'        Get
'            Return _estado
'        End Get
'        Set(ByVal value As Integer)
'            _estado = value
'        End Set
'    End Property
'End Class

'Public Class CerrarTareo
'    Private _idtareo As Integer
'    Private _idorden As Integer
'    Private _idpersonal As Integer
'    Private _descripcion As String
'    Private _observacion As String

'    Public Property IdTareo As Integer
'        Get
'            Return _idtareo
'        End Get
'        Set(value As Integer)
'            _idtareo = value
'        End Set
'    End Property

'    Public Property IdOrden As Integer
'        Get
'            Return _idorden
'        End Get
'        Set(value As Integer)
'            _idorden = value
'        End Set
'    End Property

'    Public Property IdPersonal As Integer
'        Get
'            Return _idpersonal
'        End Get
'        Set(value As Integer)
'            _idpersonal = value
'        End Set
'    End Property

'    Public Property Descripcion As String
'        Get
'            Return _descripcion
'        End Get
'        Set(value As String)
'            _descripcion = value
'        End Set
'    End Property

'    Public Property Observacion As String
'        Get
'            Return _observacion
'        End Get
'        Set(value As String)
'            _observacion = value
'        End Set
'    End Property
'End Class
