Imports System.Data
Imports System.Data.OleDb

Public Class Form5
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet

    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Try
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
            Dim command As String
            command = "INSERT INTO customer(Name,DOB,Age,Type_of_account,Nationality,Address,Mobile_Num,Marital_Status,Income,Occupation,Religion,Category,Aadhar,Mail_ID) VALUES(TextBox1,TextBox2,TextBox3,TextBox4,TextBox5,TextBox6,TextBox7,TextBox8,TextBox9,TextBox10,TextBox11,TextBox12,TextBox13,TextBox14)"
            conn.Open()
            Dim cmd As OleDbCommand
            cmd = New OleDbCommand(command, conn)
            cmd.Parameters.AddWithValue("Name", TextBox1.Text)
            cmd.Parameters.AddWithValue("DOB", TextBox3.Text)
            cmd.Parameters.AddWithValue("Age", TextBox2.Text)
            cmd.Parameters.AddWithValue("Type_of_account", TextBox4.Text)
            cmd.Parameters.AddWithValue("Nationality", TextBox5.Text)
            cmd.Parameters.AddWithValue("Address", TextBox6.Text)
            cmd.Parameters.AddWithValue("Mobile_Num", TextBox7.Text)
            cmd.Parameters.AddWithValue("Marital_Status", TextBox8.Text)
            cmd.Parameters.AddWithValue("Income", TextBox9.Text)
            cmd.Parameters.AddWithValue("Occupation", TextBox10.Text)
            cmd.Parameters.AddWithValue("Religion", TextBox11.Text)
            cmd.Parameters.AddWithValue("Category", TextBox12.Text)
            cmd.Parameters.AddWithValue("Aadhar", TextBox13.Text)
            cmd.Parameters.AddWithValue("Mail_ID", TextBox14.Text)
            cmd.Parameters.AddWithValue("acc_id", TextBox15.Text)
            cmd.ExecuteNonQuery()
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Form5_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
        Dim command As String
        command = "Update [customer] set [Name] = '" & TextBox1.Text & "', [DOB] = '" & TextBox2.Text & "',[Age] = '" & TextBox3.Text & "',[Type_Of_Account] = '" & TextBox4.Text & "',[Nationality] = '" & TextBox5.Text & "',[Address] = '" & TextBox6.Text & "',[Mobile_Num] = '" & TextBox7.Text & "',[Marital_Status] = '" & TextBox8.Text & "',[Income] = '" & TextBox9.Text & "',[Occupation] = '" & TextBox10.Text & "',[Religion] = '" & TextBox11.Text & "',[Category] = '" & TextBox12.Text & "',[Aadhar] = '" & TextBox13.Text & "',[Mail_ID] = '" & TextBox1.Text & "'Where [acc_id] = " & TextBox15.Text & " "
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Dim num As Integer
        Randomize()
        num = Int(Rnd() * 500) + 1
        TextBox15.Text = num
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Form6.Show()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        If OpenFileDialog1.ShowDialog = DialogResult.OK Then
            PictureBox1.Load(Me.OpenFileDialog1.FileName)
        Else
            MsgBox("Select Image")
        End If
    End Sub

    Private Sub OpenFileDialog1_FileOk(sender As Object, e As System.ComponentModel.CancelEventArgs) Handles OpenFileDialog1.FileOk

    End Sub

    Private Sub Label17_Click(sender As Object, e As EventArgs) Handles Label17.Click

    End Sub
End Class
