Imports System.Data
Imports System.Data.OleDb

Public Class Form3
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click '//ADD RECORD
        Try
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
            Dim command As String
            command = "INSERT INTO branch(bid,bnm,bloc,bcd,bemp) VALUES (TextBox1,TextBox2,TextBox3,TextBox4,TextBox5)"
            conn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(command, conn)
            cmd.Parameters.AddWithValue("bid", TextBox1.Text)
            cmd.Parameters.AddWithValue("bnm", TextBox3.Text)
            cmd.Parameters.AddWithValue("bloc", TextBox2.Text)
            cmd.Parameters.AddWithValue("bcd", TextBox4.Text)
            cmd.Parameters.AddWithValue("bemp", TextBox5.Text)
            cmd.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form4.Show()
    End Sub
End Class