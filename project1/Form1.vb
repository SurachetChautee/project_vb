Imports System.Configuration
Imports System.Data
Imports System.Data.SqlClient
Public Class Form1

    Dim strcon As String = ConfigurationManager.ConnectionStrings("project1.My.MySettings.strcon").ConnectionString
    Dim mycon As New SqlConnection
    Dim myda As New SqlDataAdapter
    Dim myds As New DataSet
    Dim cmd As New SqlCommand
    Dim dt As New DataTable
    Dim strsql As String

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged


    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        zara()
        myds = New DataSet
        dt = New DataTable
        myds.Tables.Add(dt)
        ' myda = New SqlDataAdapter("select * from demo.dbo.employee ", mycon)
        ' myda.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView

    End Sub
    Private Sub zara()
        If mycon.State = ConnectionState.Open Then
            mycon.Close()

        End If
        mycon.ConnectionString = strcon
        mycon.Open()
    End Sub

    Private Sub zara2()
        myds = New DataSet
        dt = New DataTable
        myds.Tables.Add(dt)
        myda = New SqlDataAdapter("select * from demo.dbo.employee ", mycon)
        myda.Fill(dt)
        DataGridView1.DataSource = dt.DefaultView
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click

        zara()

        If TextBox1.Text = "" Or TextBox2.Text = "" Or TextBox3.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบถ้วน", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error)
        Else

            cmd = New SqlCommand("insert into demo.dbo.employee(EmployeeID,Name,TelephoneNumber)values('" & TextBox1.Text & "','" & TextBox2.Text & "','" & TextBox3.Text & "')", mycon)
            cmd.ExecuteNonQuery()
            zara2()
            TextBox1.Clear()
            TextBox2.Clear()
            TextBox3.Clear()

        End If

    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        zara()
        Dim i As Integer = DataGridView1.CurrentRow.Index
        Dim username As String = DataGridView1.Item(0, i).Value
        cmd = New SqlCommand("delete from demo where EmployeeID'" & i & "' ")
        ' If cmd.ExecuteScalar = 0 Then
        'MessageBox.Show("ลบสำเร็จ")
        '   End If
        zara2()
    End Sub

    Private Sub DataGridView1_CellMouseClick(sender As Object, e As DataGridViewCellMouseEventArgs) Handles DataGridView1.CellMouseClick
        TextBox1.Text = DataGridView1.Rows(e.RowIndex).Cells(0).Value.ToString
        TextBox2.Text = DataGridView1.Rows(e.RowIndex).Cells(1).Value.ToString
        TextBox3.Text = DataGridView1.Rows(e.RowIndex).Cells(2).Value.ToString

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        zara()
        cmd = New SqlCommand("update demo.dbo.employee set Name ='" & TextBox2.Text & "',TelephoneNumber='" & TextBox3.Text & "' where EmployeeID ='" & TextBox1.Text & "'", mycon)
        cmd.ExecuteNonQuery()
        zara2()

    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub
End Class