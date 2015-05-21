Public Class ticket

    Private int_id As Integer
    Public Property ID() As Integer
        Get
            Return int_id
        End Get
        Set(ByVal value As Integer)
            int_id = value
        End Set
    End Property

    Private str_titulo As String
    Public Property Titulo() As String
        Get
            Return str_titulo
        End Get
        Set(ByVal value As String)
            str_titulo = value
        End Set
    End Property

    Private str_descripcion As String
    Public Property Descripcion() As String
        Get
            Return str_descripcion
        End Get
        Set(ByVal value As String)
            str_descripcion = value
        End Set
    End Property

    Private dt_fecha_creacion As DateTime
    Public Property FechaCreacion() As DateTime
        Get
            Return dt_fecha_creacion
        End Get
        Set(ByVal value As DateTime)
            dt_fecha_creacion = value
        End Set
    End Property

    Private dt_fecha_modificacion As DateTime
    Public Property FechaModificacion() As DateTime
        Get
            Return dt_fecha_modificacion
        End Get
        Set(ByVal value As DateTime)
            dt_fecha_modificacion = value
        End Set
    End Property

    Private est_estado As estado
    Public Property Estado() As estado
        Get
            Return est_estado
        End Get
        Set(ByVal value As estado)
            est_estado = value
        End Set
    End Property




End Class
