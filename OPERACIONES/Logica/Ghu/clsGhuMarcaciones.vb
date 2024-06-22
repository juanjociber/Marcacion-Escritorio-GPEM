Public Class clsGhuMarcaciones
    Private _idmarcacion As Integer
    Public Property IDMARCACION() As Integer
        Get
            Return _idmarcacion
        End Get
        Set(ByVal value As Integer)
            _idmarcacion = value
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
    Private _idinout As Integer
    Public Property IDINOUT() As Integer
        Get
            Return _idinout
        End Get
        Set(ByVal value As Integer)
            _idinout = value
        End Set
    End Property
End Class
