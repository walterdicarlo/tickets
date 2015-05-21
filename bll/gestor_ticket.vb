Imports be
Imports servicios

Public Class gestor_ticket
    Implements IMetodos(Of ticket)


    Public Function add(obj As ticket) As Integer Implements IMetodos(Of ticket).add
        Return 1
    End Function

    Public Function delete(obj As ticket) As Integer Implements IMetodos(Of ticket).delete
        Return 1
    End Function

    Public Function read() As List(Of ticket) Implements IMetodos(Of ticket).read
        Dim ls As New List(Of ticket)
        Return ls
    End Function

    Public Function update(obj As ticket) As Integer Implements IMetodos(Of ticket).update
        Return 1
    End Function

End Class
