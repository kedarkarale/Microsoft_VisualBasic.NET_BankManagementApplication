<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form11
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form11))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.EmpnmDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DeptDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.SalDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpidDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.EmpBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet6 = New GAD2.BankDataSet6()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.DeptToolStrip = New System.Windows.Forms.ToolStrip()
        Me.DeptToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.DeptToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.DeptToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.EmpTableAdapter = New GAD2.BankDataSet6TableAdapters.empTableAdapter()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet6, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.DeptToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.EmpnmDataGridViewTextBoxColumn, Me.DeptDataGridViewTextBoxColumn, Me.SalDataGridViewTextBoxColumn, Me.MobDataGridViewTextBoxColumn, Me.MailDataGridViewTextBoxColumn, Me.EmpidDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.EmpBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(225, 43)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(544, 198)
        Me.DataGridView1.TabIndex = 0
        '
        'EmpnmDataGridViewTextBoxColumn
        '
        Me.EmpnmDataGridViewTextBoxColumn.DataPropertyName = "empnm"
        Me.EmpnmDataGridViewTextBoxColumn.HeaderText = "empnm"
        Me.EmpnmDataGridViewTextBoxColumn.Name = "EmpnmDataGridViewTextBoxColumn"
        '
        'DeptDataGridViewTextBoxColumn
        '
        Me.DeptDataGridViewTextBoxColumn.DataPropertyName = "dept"
        Me.DeptDataGridViewTextBoxColumn.HeaderText = "dept"
        Me.DeptDataGridViewTextBoxColumn.Name = "DeptDataGridViewTextBoxColumn"
        '
        'SalDataGridViewTextBoxColumn
        '
        Me.SalDataGridViewTextBoxColumn.DataPropertyName = "sal"
        Me.SalDataGridViewTextBoxColumn.HeaderText = "sal"
        Me.SalDataGridViewTextBoxColumn.Name = "SalDataGridViewTextBoxColumn"
        '
        'MobDataGridViewTextBoxColumn
        '
        Me.MobDataGridViewTextBoxColumn.DataPropertyName = "mob"
        Me.MobDataGridViewTextBoxColumn.HeaderText = "mob"
        Me.MobDataGridViewTextBoxColumn.Name = "MobDataGridViewTextBoxColumn"
        '
        'MailDataGridViewTextBoxColumn
        '
        Me.MailDataGridViewTextBoxColumn.DataPropertyName = "mail"
        Me.MailDataGridViewTextBoxColumn.HeaderText = "mail"
        Me.MailDataGridViewTextBoxColumn.Name = "MailDataGridViewTextBoxColumn"
        '
        'EmpidDataGridViewTextBoxColumn
        '
        Me.EmpidDataGridViewTextBoxColumn.DataPropertyName = "empid"
        Me.EmpidDataGridViewTextBoxColumn.HeaderText = "empid"
        Me.EmpidDataGridViewTextBoxColumn.Name = "EmpidDataGridViewTextBoxColumn"
        '
        'EmpBindingSource
        '
        Me.EmpBindingSource.DataMember = "emp"
        Me.EmpBindingSource.DataSource = Me.BankDataSet6
        '
        'BankDataSet6
        '
        Me.BankDataSet6.DataSetName = "BankDataSet6"
        Me.BankDataSet6.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(50, 114)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(128, 22)
        Me.TextBox1.TabIndex = 1
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(50, 157)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(128, 25)
        Me.Button1.TabIndex = 2
        Me.Button1.Text = "Delete Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(682, 295)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(87, 25)
        Me.Button2.TabIndex = 3
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(266, 257)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(87, 25)
        Me.Button3.TabIndex = 4
        Me.Button3.Text = "First Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(360, 257)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(87, 25)
        Me.Button4.TabIndex = 5
        Me.Button4.Text = "Last Record"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(577, 257)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(87, 25)
        Me.Button5.TabIndex = 6
        Me.Button5.Text = "Next Record"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(682, 257)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(87, 25)
        Me.Button6.TabIndex = 7
        Me.Button6.Text = "Prev Record"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(17, 201)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(184, 25)
        Me.Button7.TabIndex = 8
        Me.Button7.Text = "Print Document"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'PrintPreviewDialog1
        '
        Me.PrintPreviewDialog1.AutoScrollMargin = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.AutoScrollMinSize = New System.Drawing.Size(0, 0)
        Me.PrintPreviewDialog1.ClientSize = New System.Drawing.Size(400, 300)
        Me.PrintPreviewDialog1.Enabled = True
        Me.PrintPreviewDialog1.Icon = CType(resources.GetObject("PrintPreviewDialog1.Icon"), System.Drawing.Icon)
        Me.PrintPreviewDialog1.Name = "PrintPreviewDialog1"
        Me.PrintPreviewDialog1.Visible = False
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(55, 78)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Mobile Number"
        '
        'DeptToolStrip
        '
        Me.DeptToolStrip.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.DeptToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.DeptToolStripLabel, Me.DeptToolStripTextBox, Me.DeptToolStripButton})
        Me.DeptToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.DeptToolStrip.Name = "DeptToolStrip"
        Me.DeptToolStrip.Size = New System.Drawing.Size(789, 25)
        Me.DeptToolStrip.TabIndex = 11
        Me.DeptToolStrip.Text = "DeptToolStrip"
        '
        'DeptToolStripLabel
        '
        Me.DeptToolStripLabel.Name = "DeptToolStripLabel"
        Me.DeptToolStripLabel.Size = New System.Drawing.Size(70, 22)
        Me.DeptToolStripLabel.Text = "Department"
        '
        'DeptToolStripTextBox
        '
        Me.DeptToolStripTextBox.Name = "DeptToolStripTextBox"
        Me.DeptToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'DeptToolStripButton
        '
        Me.DeptToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.DeptToolStripButton.Name = "DeptToolStripButton"
        Me.DeptToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.DeptToolStripButton.Text = "Search"
        '
        'EmpTableAdapter
        '
        Me.EmpTableAdapter.ClearBeforeFill = True
        '
        'Form11
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(789, 340)
        Me.Controls.Add(Me.DeptToolStrip)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Name = "Form11"
        Me.Text = "Form11"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.EmpBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet6, System.ComponentModel.ISupportInitialize).EndInit()
        Me.DeptToolStrip.ResumeLayout(False)
        Me.DeptToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents BankDataSet6 As GAD2.BankDataSet6
    Friend WithEvents EmpBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents EmpTableAdapter As GAD2.BankDataSet6TableAdapters.empTableAdapter
    Friend WithEvents EmpnmDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents SalDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MailDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents EmpidDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DeptToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents DeptToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents DeptToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents DeptToolStripButton As System.Windows.Forms.ToolStripButton
End Class
