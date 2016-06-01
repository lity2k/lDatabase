Imports MySql.Data.MySqlClient

Public Class MySql
    Implements lDatabase

    Dim dbConnection As String = Nothing
    Public Sub New(ConnctionString As String)
        dbConnection = ConnctionString
    End Sub

    Public Property connectionString As String Implements lDatabase.connectionString
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Function ExecuteDataTable(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As DataTable Implements lDatabase.ExecuteDataTable
        Dim dt As DataTable = New DataTable()
        Try
            Using conn As New MySqlConnection(dbConnection)
                conn.Open()
                Dim cmd As New MySqlCommand(sql, conn)
                If Not Parameters Is Nothing Then
                    For Each Parameter As KeyValuePair(Of String, Object) In Parameters
                        cmd.Parameters.AddWithValue(Parameter.Key, Parameter.Value)
                    Next
                End If
                Using reader As MySqlDataReader = cmd.ExecuteReader()
                    '根据reader中的信息创建datatable
                    For i = 0 To reader.FieldCount - 1
                        dt.Columns.Add(reader.GetName(i), reader.GetFieldType(reader.GetName(i)))
                    Next

                    '把reader的中数据填充到datatable
                    While reader.Read
                        Dim newRow As DataRow = dt.NewRow()
                        For j = 0 To reader.FieldCount - 1
                            newRow.Item(j) = reader(j)
                        Next
                        dt.Rows.Add(newRow)
                    End While
                End Using
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
        Return dt
    End Function

    Public Function ExecuteNonQuery(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As Integer Implements lDatabase.ExecuteNonQuery
        Dim rowsUpdated As Integer = 0
        Try
            Using conn As New MySqlConnection(dbConnection)
                conn.Open()
                Dim cmd As New MySqlCommand(sql, conn)
                If Not Parameters Is Nothing Then
                    For Each Parameter As KeyValuePair(Of String, Object) In Parameters
                        cmd.Parameters.AddWithValue(Parameter.Key, Parameter.Value)
                    Next
                End If
                rowsUpdated = cmd.ExecuteNonQuery()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return rowsUpdated
    End Function

    Public Function ExecuteScalar(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As Object Implements lDatabase.ExecuteScalar
        Dim value As Object = Nothing
        Try
            Using conn As New MySqlConnection(dbConnection)
                conn.Open()
                Dim cmd As New MySqlCommand(sql, conn)
                If Not Parameters Is Nothing Then
                    For Each Parameter As KeyValuePair(Of String, Object) In Parameters
                        cmd.Parameters.AddWithValue(Parameter.Key, Parameter.Value)
                    Next
                End If
                value = cmd.ExecuteScalar()
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try

        Return value
    End Function

    'Public Function Update(tableName As String, data As Dictionary(Of String, String), where As String) As Boolean
    '    Dim vals As String = ""
    '    Dim returnCode As Boolean = True

    '    If (data.Count >= 1) Then
    '        For Each val As KeyValuePair(Of String, String) In data
    '            vals += String.Format(" {0} = '{1}',", val.Key.ToString(), val.Value.ToString())
    '        Next
    '        vals = vals.Substring(0, vals.Length - 1)
    '    End If

    '    Try
    '        ExecuteNonQuery(String.Format("update {0} set {1} where {2};", tableName, vals, where))
    '    Catch ex As Exception
    '        returnCode = False
    '    End Try
    '    Return returnCode
    'End Function
End Class
