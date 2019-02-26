Imports System.Data.Sql
Imports System.Data.SqlClient

Module code
    'ฐานข้อมูล'
    Friend cn As New SqlConnection("Data Source=(local)\SQLEXPRESS;Initial Catalog=demo;User ID=sa;Password=12345678")

    'cmd sqlcommand'
    Friend cmd As New SqlCommand

    'da sqldataapter'
    Friend da As New SqlDataAdapter

    'sql คำสั่ง'
    Friend sql As String

    'sql data set'
    Friend ds As DataSet

    'ฟังชั่น ฐานข้อมูล'
    Friend Sub connect_open()
        If cn.State = ConnectionState.Closed Then cn.Open()
    End Sub


    'ฟังชั่นรีเทินค่าบางอย่างจากฐานข้อมูล'
    Friend Function cmd_excuteScalar()
        connect_open()
        cmd = New SqlCommand(sql, cn)
        Return cmd.ExecuteScalar
    End Function


    'ฟังชั่นรีเทิน datatable จากฐานข้อมูล'
    Friend Function cmd_excutedatatable()
        connect_open()
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        Return ds.Tables("table")



    End Function


End Module
