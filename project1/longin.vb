Public Class longin
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim mbr As MsgBoxResult
        mbr = MessageBox.Show("ออกจากโปรแกรมหรือไม่ ?", "คำเตือน", MessageBoxButtons.OKCancel, MessageBoxIcon.Information)
        If (mbr = MsgBoxResult.Ok) Then
            Me.Close()
        End If
    End Sub

    Private Sub longin_Load(sender As Object, e As EventArgs) Handles MyBase.Load


    End Sub

    Private Sub btn_longin_Click(sender As Object, e As EventArgs) Handles btn_longin.Click
        If txt_username.Text = "" Or txt_password.Text = "" Then
            MessageBox.Show("กรุณากรอกข้อมูลให้ครบ")
            Return
        End If

        sql = "select count (*) from  employee1 where emp_usersname ='" & txt_username.Text & "' and emp_password ='" & txt_password.Text & "'"
        Dim count_users As Integer = cmd_excuteScalar()

        If count_users <= 0 Then
            MsgBox("คุณ Longin ผิดพลาด")
            txt_username.Clear()
            txt_password.Clear()
            txt_username.Select()
        Else
            MsgBox("Longin สำเร็จ")
            main.Show()
            Me.Hide()
            sql = "select * from  employee1 where emp_usersname ='" & txt_username.Text & "' and emp_password ='" & txt_password.Text & "'"
            Dim dts As DataTable = cmd_excutedatatable()

            With main
                .lblusername.Text = dts.Rows(0)("emp_usersname")
                .lbl_name.Text = dts.Rows(0)("emp_name") & " " & dts.Rows(0)("emp_lastname")

                .lbl_time.Text = Date.Now
            End With



        End If

    End Sub

    Private Sub CheckBox1_CheckedChanged(sender As Object, e As EventArgs) Handles CheckBox1.CheckedChanged
        If CheckBox1.Checked = True Then
            txt_password.PasswordChar = ""
        Else
            txt_password.PasswordChar = "* "
        End If
    End Sub
End Class