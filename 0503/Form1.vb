Imports MySql.Data.MySqlClient
Public Class Form1
#Region "Declares"
    Dim myconection As New Module1
    Dim objdatapter As New MySqlDataAdapter
    Dim dtable As New DataTable
#End Region


    Private Sub button1_Click(sender As Object, e As EventArgs) Handles button1.Click
        objdatapter = New MySqlDataAdapter("select  ManagerID ,Password from manager where ManagerID='" & textBox1.Text & "' AND Password='" & textBox2.Text & "'", myconection.open)
        dtable.Clear()
        objdatapter.Fill(dtable)
        If dtable.Rows.Count = Nothing Then
            MsgBox("nothing ManagerID or Password")
        Else
            Dim Form12 As New Form12()
            Form12.Show()
            Me.Hide()
        End If
        myconection.close()
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Dim result As DialogResult = MessageBox.Show("是否要關閉視窗？", "關閉視窗", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub checkBox1_CheckedChanged(sender As Object, e As EventArgs) Handles checkBox1.CheckedChanged
        textBox2.UseSystemPasswordChar = Not textBox2.UseSystemPasswordChar
    End Sub

    Private Sub label5_Click(sender As Object, e As EventArgs) Handles label5.Click
        textBox1.Text = ""
        textBox2.Text = ""
    End Sub

    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
