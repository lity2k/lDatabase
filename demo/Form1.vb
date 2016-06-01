
Public Class Form1
    Private Sub Button_test_sqlite3_Click(sender As Object, e As EventArgs) Handles Button_test_sqlite3.Click
        Try
            IO.File.Delete(Me.TextBox_path_sqlite.Text)
            prt("清除旧文件。")
        Catch ex As Exception
            Console.WriteLine("delete database file error. msg:" & ex.Message)
        End Try

        prt("初始化数据库类。")
        Dim _db As lDatabase.lDatabase = New lDatabase.sqlite3("Data Source=" & Me.TextBox_path_sqlite.Text)

        _db.ExecuteNonQuery("CREATE TABLE res (" & vbCrLf & "    ""id""  integer PRIMARY KEY AUTOINCREMENT," & vbCrLf & "    ""url"" varchar(2000)," & vbCrLf & "    ""content_lenght"" bigint DEFAULT 0," & vbCrLf & "    ""content_type"" varchar(64)," & vbCrLf & "    ""content"" blob," & vbCrLf & "    ""is_download"" integer DEFAULT 0," & vbCrLf & "    ""filename_for_download"" varchar(256)" & vbCrLf & ");")
        prt("创建数据表成功。")
        _db.ExecuteNonQuery("CREATE TABLE topic (" & vbCrLf & "    ""id""  integer PRIMARY KEY AUTOINCREMENT," & vbCrLf & "    tid integer," & vbCrLf & "    forum varchar(64)," & vbCrLf & "    title varchar(256)," & vbCrLf & "    content text," & vbCrLf & "    srctime timestamp);")
        prt("创建数据表成功。")

        _db.ExecuteNonQuery("create index res_index on res (url);")
        prt("创建数据索引成功。")
        _db.ExecuteNonQuery("create index topic_index on topic (tid,forum,srctime);")
        prt("创建数据索引成功。")
        prt("操作结束。")

    End Sub

    Sub prt(str As String)
        Me.TextBox1.AppendText(str & vbCrLf)
        Me.TextBox1.SelectionStart = Me.TextBox1.TextLength
    End Sub

End Class
