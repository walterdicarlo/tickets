Public Class prioridad
    Private int_id As Integer
    Public Property ID() As Integer
        Get
            Return int_id
        End Get
        Set(ByVal value As Integer)
            int_id = value
        End Set
    End Property

    Private str_nombre As String
    Public Property Nombre() As String
        Get
            Return str_nombre
        End Get
        Set(ByVal value As String)
            str_nombre = value
        End Set
    End Property

End Class
