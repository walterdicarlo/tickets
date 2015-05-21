Public Class estado

    Private int_id As Integer
    Public Property ID() As Integer
        Get
            Return int_id
        End Get
        Set(ByVal value As Integer)
            int_id = value
        End Set
    End Property

    Private str_estado As String
    Public Property Estado() As String
        Get
            Return str_estado
        End Get
        Set(ByVal value As String)
            str_estado = value
        End Set
    End Property


End Class
