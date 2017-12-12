Imports System.Data.SqlClient

Public Class Form14
    Private Function checkoid(ByVal oid As Integer) As Boolean
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        dt = New DataTable()
        adp = New SqlDataAdapter("select * from orderGrocery where o_id=" & oid, con)

        adp.Fill(dt)
        If dt.Rows.Count = 0 Then
            Return True
        End If
        Return False
    End Function
    Public Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from orderGrocery", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Call display()
    End Sub

    Private Sub Form14_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call display()
    End Sub
    Private Sub Form14_Close(sender As Object, e As EventArgs) Handles MyBase.FormClosed
        Form2.Show()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim sqlcmd As SqlCommand
        Dim query As String
        Dim oid As Integer = Val(TextBox1.Text)

        If TextBox1.Text = "" Then
            MsgBox("Please Enter the Order Number", vbExclamation, "Warning")
            Exit Sub
        End If

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Order Number should be number only", vbExclamation, "Warning")
            Exit Sub
        End If

        If checkoid(oid) = True Then
            MsgBox("Order Number Not found", vbCritical, "Error")
            Exit Sub
        End If

        query = "delete from orderGrocery where o_id =" & oid
        Try
            If MsgBox("Are you sure you want to delete", vbYesNo, "Warning!!!") = vbYes Then
                sqlcmd = New SqlCommand(query, con)
                sqlcmd.ExecuteNonQuery()
                MsgBox("An order has been deleted", vbExclamation, "Please press on refresh")
                TextBox1.Text = ""
            End If
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form15.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form16.Show()
    End Sub
End Class