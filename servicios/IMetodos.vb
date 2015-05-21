Public Interface IMetodos(Of entidad)

    Function add(ByVal obj As entidad) As Integer
    Function update(ByVal obj As entidad) As Integer
    Function delete(ByVal obj As entidad) As Integer
    Function read() As List(Of entidad)

End Interface
