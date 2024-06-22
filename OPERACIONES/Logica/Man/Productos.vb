Public Class Productos
    Private _codigo As String
    Private _nombre As String
    Private _cantidad As Decimal
    Private _medida As String

    Public Property Codigo As String
        Get
            Return _codigo
        End Get
        Set(value As String)
            _codigo = value
        End Set
    End Property

    Public Property Nombre As String
        Get
            Return _nombre
        End Get
        Set(value As String)
            _nombre = value
        End Set
    End Property

    Public Property Cantidad As Decimal
        Get
            Return _cantidad
        End Get
        Set(value As Decimal)
            _cantidad = value
        End Set
    End Property

    Public Property Medida As String
        Get
            Return _medida
        End Get
        Set(value As String)
            _medida = value
        End Set
    End Property
End Class
