Imports System.Data.SqlClient

Public Class Form10
    Private Function checkcid(ByVal cid As Integer) As Boolean
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        dt = New DataTable()
        adp = New SqlDataAdapter("select * from customersGrocery where c_id=" & cid, con)

        adp.Fill(dt)
        If dt.Rows.Count = 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from customersGrocery", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call display()
    End Sub

    Private Sub Form10_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Call display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form11.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form12.Show()
    End Sub
End Class