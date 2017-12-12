Imports System.Data.SqlClient

Public Class Form3
    Private Function checkeid(ByVal eid As Integer) As Boolean
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        dt = New DataTable()
        adp = New SqlDataAdapter("select * from employeeGrocery where EID=" & eid, con)

        adp.Fill(dt)
        If dt.Rows.Count = 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from employeeGrocery", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Form3_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call display()
    End Sub

    Private Sub Form3_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form4.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form5.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Call display()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sqlcmd As SqlCommand
        Dim query As String
        Dim eid As Integer = Val(TextBox1.Text)

        If TextBox1.Text = "" Then
            MsgBox("Please Enter the BookNumber", vbExclamation, "Warning")
            Exit Sub
        End If

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Book Number should be number only", vbExclamation, "Warning")
            Exit Sub
        End If

        If checkeid(eid) = True Then
            MsgBox("Book Number Not found", vbCritical, "Error")
            Exit Sub
        End If

        query = "delete from employeeGrocery where EID =" & eid
        Try
            If MsgBox("Are you sure you want to delete", vbYesNo, "Warning!!!") = vbYes Then
                sqlcmd = New SqlCommand(query, con)
                sqlcmd.ExecuteNonQuery()
                MsgBox("A book has been deleted", vbExclamation, "Please press on refresh")
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

End Class