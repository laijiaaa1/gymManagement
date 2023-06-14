Imports MySql.Data.MySqlClient
Module Module2
    Public Function strconnection() As MySqlConnection
        Return New MySqlConnection("server=xingdou.sytes.net;port=3306 ; database=ggym; username=janet; password=gymmanagementsystem;convert zero datetime=True")
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

    Public Sub updates(ByVal sql As String)
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
    Public Sub search(ByVal sql As String)
        Try
            strcon.Open()
            With cmd
                .Connection = strcon
                .CommandText = sql
                result = cmd.ExecuteNonQuery
                da.SelectCommand = cmd
                Dim dt As New DataTable()
                da.Fill(dt)
                If result = 0 Then
                    MessageBox.Show("failed to search", "error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    If dt.Rows.Count > 0 Then
                        MessageBox.Show("Success", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    Else
                        MessageBox.Show("No data found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information)
                    End If
                End If
            End With
        Catch ex As Exception

            MessageBox.Show(ex.Message)
        Finally
            strcon.Close()
        End Try

    End Sub


End Module


