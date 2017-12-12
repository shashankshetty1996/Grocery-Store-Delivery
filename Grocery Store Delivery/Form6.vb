Imports System.Data.SqlClient

Public Class Form6
    Public Function display()
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select * from employeeGrocery", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
        Return Nothing
    End Function
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Call display()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Dim eid As Integer
        If TextBox1.Text = "" Then
            eid = InputBox("Please Enter Employee ID", "Employee ID not entered")
            TextBox1.Text = eid
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        eid = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from employeeGrocery where EID=" & eid & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim mb As Decimal

        If TextBox1.Text = "" Then
            mb = InputBox("Please Enter Mobile Number to be searched", "Mobile Number is not entered")
            TextBox1.Text = mb
        End If
        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Please Enter integer only", vbExclamation, "Warning")
            Exit Sub
        End If
        mb = Val(TextBox1.Text)

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from employeeGrocery where Mobile_Number=" & mb & "", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Dim name As String
        If TextBox1.Text = "" Then
            name = InputBox("Please Enter Employee Name to be searched", "Employee Name is not entered")
            TextBox1.Text = name
        End If

        name = TextBox1.Text

        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("select * from employeeGrocery where EName='" & name & "'", con)
        dt = New DataTable()

        adp.Fill(dt)
        DataGridView1.DataSource = dt
    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub
End Class