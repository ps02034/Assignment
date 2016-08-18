
Class DataBaseAccess

    Private _getDataTable As DataTable

    Property GetDataTable(sqlquery As String) As DataTable
        Get
            Return _getDataTable
        End Get
        Set(value As DataTable)
            _getDataTable = value
        End Set
    End Property

    Function ExecuteNoneQuery(lenhsql As String) As Boolean
        Throw New NotImplementedException
    End Function

End Class
