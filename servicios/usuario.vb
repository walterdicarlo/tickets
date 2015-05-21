Public Class usuario

    Private int_id As Integer
    Public Property ID() As Integer
        Get
            Return int_id
        End Get
        Set(ByVal value As Integer)
            int_id = value
        End Set
    End Property

    Private str_userName As String
    Public Property UserName() As String
        Get
            Return str_userName
        End Get
        Set(ByVal value As String)
            str_userName = value
        End Set
    End Property

    Private str_password As String
    Public Property Password() As String
        Get
            Return str_password
        End Get
        Set(ByVal value As String)
            str_password = value
        End Set
    End Property

    Private str_email As String
    Public Property Email() As String
        Get
            Return str_email
        End Get
        Set(ByVal value As String)
            str_email = value
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

    Private str_apellido As String
    Public Property Apellido() As String
        Get
            Return str_apellido
        End Get
        Set(ByVal value As String)
            str_apellido = value
        End Set
    End Property





End Class
