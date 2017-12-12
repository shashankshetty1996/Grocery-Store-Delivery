Imports System.Data.SqlClient

Public Class Form17
    Public Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from orderGrocery", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Form17_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call display()
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Call display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim id As Integer
        If TextBox1.Text = "" Then
            id = InputBox("Please Enter Order ID", "Order ID not entered")
            TextBox1.Text = id
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        id = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from orderGrocery where o_id=" & id & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim id As Integer
        If TextBox1.Text = "" Then
            id = InputBox("Please Enter Customer ID", "Customer ID not entered")
            TextBox1.Text = id
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        id = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from orderGrocery where c_id=" & id & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim id As Integer
        If TextBox1.Text = "" Then
            id = InputBox("Please Enter Employee ID", "Employee ID not entered")
            TextBox1.Text = id
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        id = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from orderGrocery where e_id=" & id & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class