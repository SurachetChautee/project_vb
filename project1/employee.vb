Imports System.Data.SqlClient

Public Class employee
    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        connect_open()
        sql = "select * from employee1 where emp_usersname ='" & txt_add_username.Text & "' "
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        Dim dts As DataTable = ds.Tables("table")
        If dts.Rows.Count > 0 Then
            MsgBox("มี username นี่อยู่ในระบบแล้ว")
            Return
        End If


        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("เพิ่มข้อมูลหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            connect_open()
            sql = "insert into employee1(emp_usersname , emp_password , emp_name , emp_lastname , emp_tel) values(@username,@password,@name,@lastname,@tel)"
            cmd = New SqlCommand(sql, cn)
            cmd.CommandType = CommandType.Text
            ' cmd.Parameters.Clear()
            cmd.Parameters.AddWithValue("username", txt_add_username.Text)
            cmd.Parameters.AddWithValue("password", txt_add_password.Text)
            cmd.Parameters.AddWithValue("name", txt_add_name.Text)
            cmd.Parameters.AddWithValue("lastname", txt_add_lastname.Text)
            cmd.Parameters.AddWithValue("tel", txt_add_tel.Text)

            cmd.ExecuteNonQuery()
            MsgBox("55")
            load_employee()

        End If



        ' connect_open()
        ' sql = "insert into employee1 values(@username,@password,@name,@lastname,@tel)"
        ' cmd = New SqlCommand(sql, cn)
        ' cmd.Parameters.Clear()
        ' cmd.Parameters.AddWithValue("username", txt_add_username.Text)
        ' cmd.Parameters.AddWithValue("password", txt_add_password.Text)
        '  cmd.Parameters.AddWithValue("name", txt_add_name)
        '  cmd.Parameters.AddWithValue("lastname", txt_add_lastname.Text)
        '  cmd.Parameters.AddWithValue("tel", txt_add_tel .Text )
        '  If cmd.ExecuteNonQuery >= 1 Then
        '     MsgBox("เพิ่มข้อมูลสำเร็จ")
        ' Else
        '     MsgBox("เพิ่มข้อมูลผิดพลาด")
        ' End If

        ' load_employee()

    End Sub

    Private Sub employee_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        load_employee()

    End Sub

    Public Sub load_employee()
        connect_open()
        sql = "select * from employee1"
        da = New SqlDataAdapter(sql, cn)
        ds = New DataSet
        da.Fill(ds, "table")
        datagrid_search.DataSource = ds.Tables("table")
    End Sub



    Private Sub datagrid_search_CellClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellClick
        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value

        txt_showusername.Text = datagrid_search.Item(0, i).Value
        txt_showpassword.Text = datagrid_search.Item(1, i).Value
        txt_showname.Text = datagrid_search.Item(2, i).Value
        txt_showlastname.Text = datagrid_search.Item(3, i).Value
        txt_showtel.Text = datagrid_search.Item(4, i).Value



    End Sub

    Private Sub datagrid_search_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles datagrid_search.CellContentClick

    End Sub

    Private Sub btn_delete_Click(sender As Object, e As EventArgs) Handles btn_delete.Click

        Dim i As Integer = datagrid_search.CurrentRow.Index
        Dim key As String = datagrid_search.Item(0, i).Value
        sql = "delete from employee1 where emp_usersname='" & key & "'"
        cmd = New SqlCommand(sql, cn)
        If cmd.ExecuteNonQuery >= 1 Then
            MsgBox("ลบสำเร็จ")
        Else
            MsgBox("ลบผิดพลาด")

        End If

    End Sub

    Private Sub btn_edit_Click(sender As Object, e As EventArgs) Handles btn_edit.Click


        connect_open()
        sql = "update employee1 set emp_password=@password,emp_name=@name,emp_lastname=@lastname,emp_tel=@tel where emp_usersname='" & txt_edit_username.Text & "' "
        cmd = New SqlCommand(sql, cn)
        cmd.Parameters.Clear()
        cmd.Parameters.AddWithValue("password", txt_edit_password.Text)
        cmd.Parameters.AddWithValue("name", txt_edit_name.Text)
        cmd.Parameters.AddWithValue("lastname", txt_edit_lastname.Text)
        cmd.Parameters.AddWithValue("tel", txt_edit_tel.Text)

        If cmd.ExecuteNonQuery >= 1 Then
            MsgBox("แก้ไขข้อมูลพนักงานสำเร็จ")
        Else
            MsgBox("แก้ไขไม่สำเร็จ")
        End If



    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        txt_add_username.Clear()
        txt_add_password.Clear()
        txt_add_name.Clear()
        txt_add_lastname.Clear()
        txt_add_tel.Clear()

    End Sub
End Class