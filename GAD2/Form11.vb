
Imports System.Data
Imports System.Data.OleDb

Public Class Form11
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet
    Private bitmap As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
        Dim command As String
        command = "Delete from [emp]  Where [mob] = " & TextBox1.Text & " "
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

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        EmpBindingSource.MoveFirst()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        EmpBindingSource.MoveLast()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        EmpBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        EmpBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim h As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = h
    End Sub

    Private Sub Form11_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet6.emp' table. You can move, or remove it, as needed.
        Me.EmpTableAdapter.Fill(Me.BankDataSet6.emp)
        'TODO: This line of code loads data into the 'BankDataSet5.emp' table. You can move, or remove it, as needed.
        Me.EmpTableAdapter.Fill(Me.BankDataSet6.emp)

    End Sub

    Private Sub DeptToolStripButton_Click(sender As Object, e As EventArgs) Handles DeptToolStripButton.Click
        Try
            Me.EmpTableAdapter.dept(Me.BankDataSet6.emp, DeptToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub
End Class
