Imports System.Data
Imports System.Data.OleDb

Public Class Form4
    Private conn As OleDbConnection
    Private adpt As OleDbDataAdapter
    Private cmd As OleDbCommandBuilder
    Private myds As DataSet
    Private Sub Form4_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        'TODO: This line of code loads data into the 'BankDataSet1.branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.BankDataSet.branch)
        'TODO: This line of code loads data into the 'BankDataSet.branch' table. You can move, or remove it, as needed.
        Me.BranchTableAdapter.Fill(Me.BankDataSet.branch)
    End Sub
    Private bitmap As Bitmap
    Private Sub Button1_Click(sender As Object, e As EventArgs) Handles Button1.Click
        Form3.Show()
    End Sub

    Private Sub Button2_Click(sender As Object, e As EventArgs) Handles Button2.Click
        conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
        Dim command As String
        command = "Delete from [branch]  Where [bid] = " & TextBox1.Text & " "
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

    Private Sub Button3_Click(sender As Object, e As EventArgs) Handles Button3.Click
            conn = New OleDb.OleDbConnection("Provider=Microsoft.Jet.Oledb.4.0;Data Source=C:\Users\Kedar\Documents\Visual Studio 2012\Projects\GAD2\Bank.mdb")
            Dim command As String
        command = "Update [branch] set [bnm] = '" & TextBox2.Text & "', [bloc] = '" & TextBox3.Text & "',[bcd] = '" & TextBox4.Text & "',[bemp] = '" & TextBox5.Text & "' Where [bid] = " & TextBox1.Text & " "
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

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles Button4.Click
        Form2.Show()
    End Sub

    Private Sub Button6_Click(sender As Object, e As EventArgs) Handles Button6.Click
        BranchBindingSource.MoveFirst()
    End Sub

    Private Sub DataGridView1_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles DataGridView1.CellContentClick

    End Sub

    Private Sub Button9_Click(sender As Object, e As EventArgs) Handles Button9.Click
        BranchBindingSource.MovePrevious()
    End Sub

    Private Sub Button8_Click(sender As Object, e As EventArgs) Handles Button8.Click
        BranchBindingSource.MoveNext()
    End Sub

    Private Sub Button7_Click(sender As Object, e As EventArgs) Handles Button7.Click
        BranchBindingSource.MoveLast()
    End Sub
    Private Sub Button5_Click(sender As Object, e As EventArgs) Handles Button5.Click
        Dim h As Integer = DataGridView1.Height
        DataGridView1.Height = DataGridView1.RowCount * DataGridView1.RowTemplate.Height
        bitmap = New Bitmap(Me.DataGridView1.Width, Me.DataGridView1.Height)
        DataGridView1.DrawToBitmap(bitmap, New Rectangle(0, 0, Me.DataGridView1.Width, Me.DataGridView1.Height))
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

    Private Sub Button10_Click(sender As Object, e As EventArgs)

    End Sub

    Private Sub SearchToolStripButton_Click(sender As Object, e As EventArgs) Handles SearchToolStripButton.Click
        Try
            Me.BranchTableAdapter.Search(Me.BankDataSet.branch, BlocToolStripTextBox.Text & "%")
        Catch ex As System.Exception
            System.Windows.Forms.MessageBox.Show(ex.Message)
        End Try

    End Sub

    Private Sub ToolStripLabel1_Click(sender As Object, e As EventArgs) Handles ToolStripLabel1.Click

    End Sub
End Class