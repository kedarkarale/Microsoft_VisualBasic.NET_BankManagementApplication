Imports System.Data
Imports System.Data.OleDb

Public Class Form6
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet
    Private Sub Form6_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet2.customer' table. You can move, or remove it, as needed.
        Me.CustomerTableAdapter.Fill(Me.BankDataSet2.customer)

    End Sub
    Private bitmap As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
        Dim command As String
        command = "Delete from [customer]  Where [Mobile_Num] = " & TextBox1.Text & " "
        conn.Open()
        Dim cmd As OleDbCommand
        cmd = New OleDbCommand(command, conn)
        Try
            cmd.ExecuteNonQuery()
            cmd.Dispose()
            TextBox1.Clear()
            MsgBox("Operation Succeded", 0 + 64, "Operation Proceeder")
        Catch exceptionObject As Exception
            MessageBox.Show(exceptionObject.Message)
        Finally
            conn.Close()
        End Try
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        Application.Exit()
    End Sub

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        CustomerBindingSource.MoveLast()
    End Sub

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
        CustomerBindingSource.MoveFirst()
    End Sub

    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        CustomerBindingSource.MoveNext()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        CustomerBindingSource.MovePrevious()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        Dim h As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        Bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(Bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
        PrintPreviewDialog1.Document = PrintDocument1
        PrintPreviewDialog1.PrintPreviewControl.Zoom = 1
        PrintPreviewDialog1.ShowDialog()
        DataGridView1.Height = h
    End Sub
    Private Sub PrintDocument1_PrintPage(sender As Object, e As Printing.PrintPageEventArgs) Handles PrintDocument1.PrintPage
        e.Graphics.DrawImage(bitmap, 0, 0)
        Dim rec As RectangleF = e.PageSettings.PrintableArea
        If Me.DataGridView1.Height = rec.Height > 0 Then e.HasMorePages = True
    End Sub

    Private Sub AddressToolStripButton_Click(sender As Object, e As EventArgs) Handles AddressToolStripButton.Click
        Try
            Me.CustomerTableAdapter.Address(Me.BankDataSet2.customer, AddressToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
End Class