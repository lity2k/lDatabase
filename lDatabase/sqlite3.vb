Imports System.Data.SQLite

Public Class sqlite3
    Implements lDatabase

    Private dbConnection As String

    Public Property connectionString As String Implements lDatabase.connectionString
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Public Sub New(ConnctionString As String)
        dbConnection = ConnctionString
    End Sub

    Public Function ExecuteDataTable(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As DataTable Implements lDatabase.ExecuteDataTable
        Dim dt As DataTable = New DataTable()
        Try
            Using conn As New SQLiteConnection(dbConnection)
                conn.Open()
                Dim cmd As New SQLiteCommand(sql, conn)
                If Not Parameters Is Nothing Then
                    For Each Parameter As KeyValuePair(Of String, Object) In Parameters
                        cmd.Parameters.AddWithValue(Parameter.Key, Parameter.Value)
                    Next
                End If
                Using reader As SQLiteDataReader = cmd.ExecuteReader()
                    '根据reader中的信息创建datatable
                    For i = 0 To reader.FieldCount - 1
                        dt.Columns.Add(reader.GetName(i), reader.GetFieldType(i))
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
        Try
            Using conn As SQLiteConnection = New SQLiteConnection(dbConnection)
                conn.Open()
                Dim cmd As SQLiteCommand = New SQLiteCommand(sql, conn)
                If Not Parameters Is Nothing Then
                    For Each Parameter As KeyValuePair(Of String, Object) In Parameters
                        cmd.Parameters.AddWithValue(Parameter.Key, Parameter.Value)
                    Next
                End If
                Dim rowsUpdated As Integer = cmd.ExecuteNonQuery()
                Return rowsUpdated
            End Using
        Catch ex As Exception
            Throw New Exception(ex.Message)
        End Try
    End Function

    Public Function ExecuteScalar(sql As String, Optional Parameters As Dictionary(Of String, Object) = Nothing) As Object Implements lDatabase.ExecuteScalar
        Dim value As Object = Nothing
        Using conn As SQLiteConnection = New SQLiteConnection(dbConnection)
            conn.Open()

            Dim cmd As SQLiteCommand = New SQLiteCommand(sql, conn)
            If Not Parameters Is Nothing Then
                For Each Parameter As KeyValuePair(Of String, Object) In Parameters
                    cmd.Parameters.AddWithValue(Parameter.Key, Parameter.Value)
                Next
            End If
            value = cmd.ExecuteScalar()
        End Using

        Return value
    End Function

End Class
