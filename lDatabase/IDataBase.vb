Public Interface lDatabase
    ''' <summary>
    ''' 获取数据库连接字串
    ''' </summary>
    ''' <returns></returns>
    ReadOnly Property connectionString As String

    ''' <summary>
    ''' 执行sql查询语句，并返回datatable。
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="Parameters"></param>
    ''' <returns></returns>
    Function ExecuteDataTable(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As DataTable

    ''' <summary>
    ''' 执行sql语句，并返回受影响行数。
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="Parameters"></param>
    ''' <returns></returns>
    Function ExecuteNonQuery(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As Integer

    ''' <summary>
    ''' 执行sql语句，结果集中第一行的第一列。
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <param name="Parameters"></param>
    ''' <returns></returns>
    Function ExecuteScalar(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As Object

End Interface
