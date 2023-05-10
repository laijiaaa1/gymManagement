Imports MySql.Data.MySqlClient
Public Class Form8
    Dim constring As New MySqlConnection
    Dim conect As New MySqlCommand
    Private Sub button5_Click(sender As Object, e As EventArgs) Handles button5.Click
        Try
            conect = New MySql.Data.MySqlClient.MySqlCommand("insert into manager values('" & textBox5.Text & "','" & textBox6.Text & "','" & textBox7.Text & "','" & textBox8.Text & "')", constring)
            conect.ExecuteNonQuery()
            MsgBox("data saved successfully")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub pictureBox10_Click(sender As Object, e As EventArgs) Handles pictureBox10.Click
        Dim result As DialogResult = MessageBox.Show("是否要關閉視窗？", "關閉視窗", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub
End Class