Imports System.Data.SqlClient

Public Class Form16
    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Me.Hide()
    End Sub

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        If TextBox1.Text = "" Then
            MsgBox("Please Enter all the fields", vbExclamation, "Warning")
        End If

        If Not IsNumeric(TextBox1.Text) Then
            MsgBox("Order Number should be number", vbExclamation, "Warning")
        End If

        Dim oid As Integer = Val(TextBox1.Text)
        Dim eid As Integer = ComboBox1.SelectedValue
        Dim cid As Integer = ComboBox2.SelectedValue

        Dim query As String = "update orderGrocery set e_id=" & eid & ",c_id=" & cid & " where o_id=" & oid & ""

        Dim sqlcmd As SqlCommand

        Try
            sqlcmd = New SqlCommand(query, con)
            sqlcmd.ExecuteNonQuery()
            MsgBox("Order Successfully Updated",, "Message")
        Catch ex As Exception
            MsgBox(ex.Message)
        End Try
    End Sub

    Private Sub Form16_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Dim adp As SqlDataAdapter
        Dim dt As DataTable

        adp = New SqlDataAdapter("Select EID,EName from employeeGrocery", con)
        dt = New DataTable()
        adp.Fill(dt)

        ComboBox1.DataSource = dt
        ComboBox1.ValueMember = "EID"
        ComboBox1.DisplayMember = "EName"

        Dim adp1 As SqlDataAdapter
        Dim dt1 As DataTable

        adp1 = New SqlDataAdapter("Select c_id,cname from customersGrocery", con)
        dt1 = New DataTable()
        adp1.Fill(dt1)

        ComboBox2.DataSource = dt1
        ComboBox2.ValueMember = "c_id"
        ComboBox2.DisplayMember = "cname"
    End Sub
End Class