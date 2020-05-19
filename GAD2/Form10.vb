Imports System.Data
Imports System.Data.OleDb

Public Class Form10
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
            Dim command As String
            command = "INSERT INTO emp(empnm,dept,sal,mob,mail) VALUES (TextBox1,TextBox2,TextBox3,TextBox4,TextBox5)"
            conn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(command, conn)
            cmd.Parameters.AddWithValue("empnm", TextBox1.Text)
            cmd.Parameters.AddWithValue("dept", TextBox3.Text)
            cmd.Parameters.AddWithValue("sal", TextBox2.Text)
            cmd.Parameters.AddWithValue("mob", TextBox4.Text)
            cmd.Parameters.AddWithValue("mail", TextBox5.Text)
            cmd.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub Button2_Click_1(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
        Dim command As String
        command = "Update [emp] set [empnm] = '" & TextBox1.Text & "',[dept] = '" & TextBox2.Text & "'[sal] = '" & TextBox3.Text & "'[mail] = '" & TextBox5.Text & "' Where [mob] = " & TextBox4.Text & " "
        conn.Open()
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(command, conn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            TextBox1.Clear()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Form11.Show()
    End Sub

    Private Sub Label1_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub TextBox1_TextChanged(sender As Object, e As EventArgs) Handles TextBox1.TextChanged

    End Sub

    Private Sub Label4_Click(sender As Object, e As EventArgs) Handles Label4.Click

    End Sub

    Private Sub Label3_Click(sender As Object, e As EventArgs) Handles Label3.Click

    End Sub

    Private Sub Label5_Click(sender As Object, e As EventArgs) Handles Label5.Click

    End Sub

    Private Sub Label6_Click(sender As Object, e As EventArgs) Handles Label6.Click

    End Sub

    Private Sub Label7_Click(sender As Object, e As EventArgs) Handles Label7.Click

    End Sub

    Private Sub Label8_Click(sender As Object, e As EventArgs) Handles Label8.Click

    End Sub

    Private Sub Label9_Click(sender As Object, e As EventArgs) Handles Label9.Click

    End Sub

    Private Sub Form10_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
