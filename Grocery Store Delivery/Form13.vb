Imports System.Data.SqlClient

Public Class Form13
    Public Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from customersGrocery", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim pid As Integer
        If TextBox1.Text = "" Then
            pid = InputBox("Please Enter Process ID", "Process ID not entered")
            TextBox1.Text = pid
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        pid = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from customersGrocery where p_id=" & pid & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Form13_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call display()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim cid As Integer
        If TextBox1.Text = "" Then
            cid = InputBox("Please Enter Customer ID", "Customer ID not entered")
            TextBox1.Text = cid
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        cid = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from customersGrocery where c_id=" & cid & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Call display()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim name As String
        If TextBox1.Text = "" Then
            name = InputBox("Please Enter Customer Name", "Customer Name not entered")
            TextBox1.Text = name
        End If

        name = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from customersGrocery where cname='" & name & "'", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim mob As Decimal

        If TextBox1.Text = "" Then
            mob = InputBox("Please Enter Mobile number", "Mobile Number not entered")
            TextBox1.Text = mob
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        mob = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from customersGrocery where phone=" & mob & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim addr As String
        If TextBox1.Text = "" Then
            addr = InputBox("Please Enter Customer Address", "Customer Address not entered")
            TextBox1.Text = addr
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        addr = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from customersGrocery where Caddress=" & addr & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub
End Class