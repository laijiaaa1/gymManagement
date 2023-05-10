Public Class Form2
    Private Sub PictureBox5_Click(sender As Object, e As EventArgs) Handles PictureBox5.Click
        Dim result As DialogResult = MessageBox.Show("是否要關閉視窗？", "關閉視窗", MessageBoxButtons.YesNo)

        ' 如果用戶選擇 Yes，則關閉視窗
        If result = DialogResult.Yes Then
            Me.Close()
        End If
    End Sub

    Private Sub pictureBox2_Click(sender As Object, e As EventArgs) Handles pictureBox2.Click
        Dim Form4 As New Form4()
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub label4_Click(sender As Object, e As EventArgs) Handles label4.Click
        Dim Form4 As New Form4()
        Form4.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox1_Click(sender As Object, e As EventArgs) Handles pictureBox1.Click
        Dim Form5 As New Form5()
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub label3_Click(sender As Object, e As EventArgs) Handles label3.Click
        Dim Form5 As New Form5()
        Form5.Show()
        Me.Hide()
    End Sub

    Private Sub pictureBox3_Click(sender As Object, e As EventArgs) Handles pictureBox3.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub

    Private Sub label2_Click(sender As Object, e As EventArgs) Handles label2.Click
        Dim Form3 As New Form3()
        Form3.Show()
        Me.Hide()
    End Sub
End Class