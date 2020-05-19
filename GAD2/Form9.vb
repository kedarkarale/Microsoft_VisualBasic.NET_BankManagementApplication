Imports System.Data
Imports System.Data.OleDb

Public Class Form9
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
            Dim command As String
            command = "INSERT INTO trans(bfnm,bknm,bfcd,accid,amt) VALUES (TextBox1,TextBox2,TextBox3,TextBox4,TextBox5)"
            conn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(command, conn)
            cmd.Parameters.AddWithValue("bfnm", TextBox1.Text)
            cmd.Parameters.AddWithValue("bknm", TextBox2.Text)
            cmd.Parameters.AddWithValue("bfcd", TextBox3.Text)
            cmd.Parameters.AddWithValue("accid", TextBox4.Text)
            cmd.Parameters.AddWithValue("amt", TextBox5.Text)
            MsgBox("Amount Deposited Successfully", 0 + 64, "Transaction Management")
            cmd.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Try
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
            Dim command As String
            command = "INSERT INTO wid(accid,amt) VALUES (TextBox6,TextBox7)"
            conn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(command, conn)
            cmd.Parameters.AddWithValue("accid", TextBox6.Text)
            cmd.Parameters.AddWithValue("amt", TextBox7.Text)
            MsgBox("Withdraway Successfull", 0 + 64, "Transaction Management")
            cmd.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        Dim num As Integer
        Randomize()
        num = Int(Rnd() * 50) + 1
        TextBox8.Text = num
    End Sub

    Private Sub Form9_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
