Imports MySql.Data.MySqlClient
Module Module2
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=192.168.63.166; database=ggym; username=janet; password=gymmanagementsystem;convert zero datetime=True")
    End Function
    Public strcon As MySqlConnection = strconnection()
    Public result As String
    Public cmd As New MySqlCommand
    Public da As New MySqlDataAdapter
    Public dt As New DataTable
    Public Sub create(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("failed to save the data", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("data has been save", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
    Public Sub reload(ByVal sql As String, ByVal DTG As Object)
        Try
            dt = New DataTable
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
            End With
            da.SelectCommand = cmd
            da.Fill(dt)
            DTG.datasource = dt

        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
            da.Dispose()
        End Try
    End Sub

    Public Sub update1(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("failed to update", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("data has been updatee", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub

    Public Sub delete(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                If result = 0 Then
                    MessageBox.Show("failed to delete", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("data has been delete", "success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                End If
            End With
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try
    End Sub
End Module
