Public Class programacion
    Private _id As Integer
    Public Property Id() As Integer
        Get
            Return _id
        End Get
        Set(ByVal value As Integer)
            _id = value
        End Set
    End Property
    Private _fecha As Date
    Public Property Fecha() As Date
        Get
            Return _fecha
        End Get
        Set(ByVal value As Date)
            _fecha = value
        End Set
    End Property
    Private _turno As String
    Public Property Turno() As String
        Get
            Return _turno
        End Get
        Set(ByVal value As String)
            _turno = value
        End Set
    End Property
    Private _programacion1 As DateTime
    Public Property Programacion1() As DateTime
        Get
            Return _programacion1
        End Get
        Set(ByVal value As DateTime)
            _programacion1 = value
        End Set
    End Property
    Private _programacion2 As DateTime
    Public Property Programacion2() As DateTime
        Get
            Return _programacion2
        End Get
        Set(ByVal value As DateTime)
            _programacion2 = value
        End Set
    End Property
    Private _asistencia1 As DateTime?
    Public Property Asistencia1() As DateTime?
        Get
            Return _asistencia1
        End Get
        Set(ByVal value As DateTime?)
            _asistencia1 = value
        End Set
    End Property
    Private _asistencia2 As DateTime?
    Public Property Asistencia2() As DateTime?
        Get
            Return _asistencia2
        End Get
        Set(ByVal value As DateTime?)
            _asistencia2 = value
        End Set
    End Property
    Private _refrigerio1 As DateTime?
    Public Property Refrigerio1() As DateTime?
        Get
            Return _refrigerio1
        End Get
        Set(ByVal value As DateTime?)
            _refrigerio1 = value
        End Set
    End Property
    Private _refrigerio2 As DateTime?
    Public Property Refrigerio2() As DateTime?
        Get
            Return _refrigerio2
        End Get
        Set(ByVal value As DateTime?)
            _refrigerio2 = value
        End Set
    End Property

    Private _tecnicosino As Integer?
    Public Property Tecnicosino() As Integer?
        Get
            Return _tecnicosino
        End Get
        Set(ByVal value As Integer?)
            _tecnicosino = value
        End Set
    End Property

    Private _estado As Integer?
    Public Property Estado() As Integer?
        Get
            Return _estado
        End Get
        Set(ByVal value As Integer?)
            _estado = value
        End Set
    End Property
End Class
