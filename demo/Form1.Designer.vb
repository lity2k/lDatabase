<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。  
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.TextBox_path_sqlite = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Button_test_sqlite3 = New System.Windows.Forms.Button()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.Button_test_pg = New System.Windows.Forms.Button()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.TextBox_path_pg = New System.Windows.Forms.TextBox()
        Me.GroupBox3 = New System.Windows.Forms.GroupBox()
        Me.Button_test_mysql = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox_path_mysql = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.GroupBox3.SuspendLayout()
        Me.SuspendLayout()
        '
        'TextBox_path_sqlite
        '
        Me.TextBox_path_sqlite.Location = New System.Drawing.Point(47, 22)
        Me.TextBox_path_sqlite.Name = "TextBox_path_sqlite"
        Me.TextBox_path_sqlite.Size = New System.Drawing.Size(591, 21)
        Me.TextBox_path_sqlite.TabIndex = 5
        Me.TextBox_path_sqlite.Text = ".\sqlite.db"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 25)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(35, 12)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "path:"
        '
        'Button_test_sqlite3
        '
        Me.Button_test_sqlite3.Location = New System.Drawing.Point(644, 20)
        Me.Button_test_sqlite3.Name = "Button_test_sqlite3"
        Me.Button_test_sqlite3.Size = New System.Drawing.Size(75, 23)
        Me.Button_test_sqlite3.TabIndex = 3
        Me.Button_test_sqlite3.Text = "Test"
        Me.Button_test_sqlite3.UseVisualStyleBackColor = True
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.Button_test_sqlite3)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.TextBox_path_sqlite)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(725, 64)
        Me.GroupBox1.TabIndex = 6
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sqlite"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.Button_test_pg)
        Me.GroupBox2.Controls.Add(Me.Label2)
        Me.GroupBox2.Controls.Add(Me.TextBox_path_pg)
        Me.GroupBox2.Location = New System.Drawing.Point(12, 82)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(725, 64)
        Me.GroupBox2.TabIndex = 7
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "PostgreSql"
        '
        'Button_test_pg
        '
        Me.Button_test_pg.Location = New System.Drawing.Point(644, 20)
        Me.Button_test_pg.Name = "Button_test_pg"
        Me.Button_test_pg.Size = New System.Drawing.Size(75, 23)
        Me.Button_test_pg.TabIndex = 3
        Me.Button_test_pg.Text = "Test"
        Me.Button_test_pg.UseVisualStyleBackColor = True
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 25)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(35, 12)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "path:"
        '
        'TextBox_path_pg
        '
        Me.TextBox_path_pg.Location = New System.Drawing.Point(47, 22)
        Me.TextBox_path_pg.Name = "TextBox_path_pg"
        Me.TextBox_path_pg.Size = New System.Drawing.Size(591, 21)
        Me.TextBox_path_pg.TabIndex = 5
        Me.TextBox_path_pg.Text = "Server=127.0.0.1;Port=5432;User Id=postgres;Password=123456;Database=demo_test;"
        '
        'GroupBox3
        '
        Me.GroupBox3.Controls.Add(Me.Button_test_mysql)
        Me.GroupBox3.Controls.Add(Me.Label3)
        Me.GroupBox3.Controls.Add(Me.TextBox_path_mysql)
        Me.GroupBox3.Location = New System.Drawing.Point(12, 152)
        Me.GroupBox3.Name = "GroupBox3"
        Me.GroupBox3.Size = New System.Drawing.Size(725, 64)
        Me.GroupBox3.TabIndex = 8
        Me.GroupBox3.TabStop = False
        Me.GroupBox3.Text = "Mysql"
        '
        'Button_test_mysql
        '
        Me.Button_test_mysql.Location = New System.Drawing.Point(644, 20)
        Me.Button_test_mysql.Name = "Button_test_mysql"
        Me.Button_test_mysql.Size = New System.Drawing.Size(75, 23)
        Me.Button_test_mysql.TabIndex = 3
        Me.Button_test_mysql.Text = "Test"
        Me.Button_test_mysql.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 25)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(35, 12)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "path:"
        '
        'TextBox_path_mysql
        '
        Me.TextBox_path_mysql.Location = New System.Drawing.Point(47, 22)
        Me.TextBox_path_mysql.Name = "TextBox_path_mysql"
        Me.TextBox_path_mysql.Size = New System.Drawing.Size(591, 21)
        Me.TextBox_path_mysql.TabIndex = 5
        Me.TextBox_path_mysql.Text = "Server=127.0.0.1;Database=demotest;Uid=root;Pwd=123456;"
        '
        'TextBox1
        '
        Me.TextBox1.BackColor = System.Drawing.SystemColors.Info
        Me.TextBox1.Location = New System.Drawing.Point(12, 222)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ReadOnly = True
        Me.TextBox1.Size = New System.Drawing.Size(725, 303)
        Me.TextBox1.TabIndex = 9
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(749, 537)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.GroupBox3)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "demo"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.GroupBox3.ResumeLayout(False)
        Me.GroupBox3.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents TextBox_path_sqlite As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Button_test_sqlite3 As Button
    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents Button_test_pg As Button
    Friend WithEvents Label2 As Label
    Friend WithEvents TextBox_path_pg As TextBox
    Friend WithEvents GroupBox3 As GroupBox
    Friend WithEvents Button_test_mysql As Button
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox_path_mysql As TextBox
    Friend WithEvents TextBox1 As TextBox
End Class
