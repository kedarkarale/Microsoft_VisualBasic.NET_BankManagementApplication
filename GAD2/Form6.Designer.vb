<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form6
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form6))
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.NameDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.DOBDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AgeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.TypeOfAccountDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.NationalityDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AddressDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MobileNumDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MaritalStatusDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.IncomeDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.OccupationDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.ReligionDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CategoryDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.AadharDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.MailIDDataGridViewTextBoxColumn = New System.Windows.Forms.DataGridViewTextBoxColumn()
        Me.CustomerBindingSource = New System.Windows.Forms.BindingSource(Me.components)
        Me.BankDataSet2 = New GAD2.BankDataSet2()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.Button3 = New System.Windows.Forms.Button()
        Me.Button4 = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.Button6 = New System.Windows.Forms.Button()
        Me.Button7 = New System.Windows.Forms.Button()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.PrintDocument1 = New System.Drawing.Printing.PrintDocument()
        Me.PrintPreviewDialog1 = New System.Windows.Forms.PrintPreviewDialog()
        Me.AddressToolStrip = New System.Windows.Forms.ToolStrip()
        Me.AddressToolStripLabel = New System.Windows.Forms.ToolStripLabel()
        Me.ToolStripLabel1 = New System.Windows.Forms.ToolStripLabel()
        Me.AddressToolStripTextBox = New System.Windows.Forms.ToolStripTextBox()
        Me.AddressToolStripButton = New System.Windows.Forms.ToolStripButton()
        Me.CustomerTableAdapter = New GAD2.BankDataSet2TableAdapters.customerTableAdapter()
        Me.Label1 = New System.Windows.Forms.Label()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.BankDataSet2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.AddressToolStrip.SuspendLayout()
        Me.SuspendLayout()
        '
        'DataGridView1
        '
        Me.DataGridView1.AutoGenerateColumns = False
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Columns.AddRange(New System.Windows.Forms.DataGridViewColumn() {Me.NameDataGridViewTextBoxColumn, Me.DOBDataGridViewTextBoxColumn, Me.AgeDataGridViewTextBoxColumn, Me.TypeOfAccountDataGridViewTextBoxColumn, Me.NationalityDataGridViewTextBoxColumn, Me.AddressDataGridViewTextBoxColumn, Me.MobileNumDataGridViewTextBoxColumn, Me.MaritalStatusDataGridViewTextBoxColumn, Me.IncomeDataGridViewTextBoxColumn, Me.OccupationDataGridViewTextBoxColumn, Me.ReligionDataGridViewTextBoxColumn, Me.CategoryDataGridViewTextBoxColumn, Me.AadharDataGridViewTextBoxColumn, Me.MailIDDataGridViewTextBoxColumn})
        Me.DataGridView1.DataSource = Me.CustomerBindingSource
        Me.DataGridView1.Location = New System.Drawing.Point(166, 33)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(744, 192)
        Me.DataGridView1.TabIndex = 0
        '
        'NameDataGridViewTextBoxColumn
        '
        Me.NameDataGridViewTextBoxColumn.DataPropertyName = "Name"
        Me.NameDataGridViewTextBoxColumn.HeaderText = "Name"
        Me.NameDataGridViewTextBoxColumn.Name = "NameDataGridViewTextBoxColumn"
        '
        'DOBDataGridViewTextBoxColumn
        '
        Me.DOBDataGridViewTextBoxColumn.DataPropertyName = "DOB"
        Me.DOBDataGridViewTextBoxColumn.HeaderText = "DOB"
        Me.DOBDataGridViewTextBoxColumn.Name = "DOBDataGridViewTextBoxColumn"
        '
        'AgeDataGridViewTextBoxColumn
        '
        Me.AgeDataGridViewTextBoxColumn.DataPropertyName = "Age"
        Me.AgeDataGridViewTextBoxColumn.HeaderText = "Age"
        Me.AgeDataGridViewTextBoxColumn.Name = "AgeDataGridViewTextBoxColumn"
        '
        'TypeOfAccountDataGridViewTextBoxColumn
        '
        Me.TypeOfAccountDataGridViewTextBoxColumn.DataPropertyName = "Type_Of_Account"
        Me.TypeOfAccountDataGridViewTextBoxColumn.HeaderText = "Type_Of_Account"
        Me.TypeOfAccountDataGridViewTextBoxColumn.Name = "TypeOfAccountDataGridViewTextBoxColumn"
        '
        'NationalityDataGridViewTextBoxColumn
        '
        Me.NationalityDataGridViewTextBoxColumn.DataPropertyName = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.HeaderText = "Nationality"
        Me.NationalityDataGridViewTextBoxColumn.Name = "NationalityDataGridViewTextBoxColumn"
        '
        'AddressDataGridViewTextBoxColumn
        '
        Me.AddressDataGridViewTextBoxColumn.DataPropertyName = "Address"
        Me.AddressDataGridViewTextBoxColumn.HeaderText = "Address"
        Me.AddressDataGridViewTextBoxColumn.Name = "AddressDataGridViewTextBoxColumn"
        '
        'MobileNumDataGridViewTextBoxColumn
        '
        Me.MobileNumDataGridViewTextBoxColumn.DataPropertyName = "Mobile_Num"
        Me.MobileNumDataGridViewTextBoxColumn.HeaderText = "Mobile_Num"
        Me.MobileNumDataGridViewTextBoxColumn.Name = "MobileNumDataGridViewTextBoxColumn"
        '
        'MaritalStatusDataGridViewTextBoxColumn
        '
        Me.MaritalStatusDataGridViewTextBoxColumn.DataPropertyName = "Marital_Status"
        Me.MaritalStatusDataGridViewTextBoxColumn.HeaderText = "Marital_Status"
        Me.MaritalStatusDataGridViewTextBoxColumn.Name = "MaritalStatusDataGridViewTextBoxColumn"
        '
        'IncomeDataGridViewTextBoxColumn
        '
        Me.IncomeDataGridViewTextBoxColumn.DataPropertyName = "Income"
        Me.IncomeDataGridViewTextBoxColumn.HeaderText = "Income"
        Me.IncomeDataGridViewTextBoxColumn.Name = "IncomeDataGridViewTextBoxColumn"
        '
        'OccupationDataGridViewTextBoxColumn
        '
        Me.OccupationDataGridViewTextBoxColumn.DataPropertyName = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.HeaderText = "Occupation"
        Me.OccupationDataGridViewTextBoxColumn.Name = "OccupationDataGridViewTextBoxColumn"
        '
        'ReligionDataGridViewTextBoxColumn
        '
        Me.ReligionDataGridViewTextBoxColumn.DataPropertyName = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.HeaderText = "Religion"
        Me.ReligionDataGridViewTextBoxColumn.Name = "ReligionDataGridViewTextBoxColumn"
        '
        'CategoryDataGridViewTextBoxColumn
        '
        Me.CategoryDataGridViewTextBoxColumn.DataPropertyName = "Category"
        Me.CategoryDataGridViewTextBoxColumn.HeaderText = "Category"
        Me.CategoryDataGridViewTextBoxColumn.Name = "CategoryDataGridViewTextBoxColumn"
        '
        'AadharDataGridViewTextBoxColumn
        '
        Me.AadharDataGridViewTextBoxColumn.DataPropertyName = "Aadhar"
        Me.AadharDataGridViewTextBoxColumn.HeaderText = "Aadhar"
        Me.AadharDataGridViewTextBoxColumn.Name = "AadharDataGridViewTextBoxColumn"
        '
        'MailIDDataGridViewTextBoxColumn
        '
        Me.MailIDDataGridViewTextBoxColumn.DataPropertyName = "Mail_ID"
        Me.MailIDDataGridViewTextBoxColumn.HeaderText = "Mail_ID"
        Me.MailIDDataGridViewTextBoxColumn.Name = "MailIDDataGridViewTextBoxColumn"
        '
        'CustomerBindingSource
        '
        Me.CustomerBindingSource.DataMember = "customer"
        Me.CustomerBindingSource.DataSource = Me.BankDataSet2
        '
        'BankDataSet2
        '
        Me.BankDataSet2.DataSetName = "BankDataSet2"
        Me.BankDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
        '
        'Button1
        '
        Me.Button1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(39, 129)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(91, 23)
        Me.Button1.TabIndex = 1
        Me.Button1.Text = "Delete Record"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Button2
        '
        Me.Button2.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.Location = New System.Drawing.Point(817, 283)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(93, 23)
        Me.Button2.TabIndex = 2
        Me.Button2.Text = "Exit"
        Me.Button2.UseVisualStyleBackColor = True
        '
        'Button3
        '
        Me.Button3.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button3.Location = New System.Drawing.Point(166, 247)
        Me.Button3.Name = "Button3"
        Me.Button3.Size = New System.Drawing.Size(103, 23)
        Me.Button3.TabIndex = 3
        Me.Button3.Text = "First Record"
        Me.Button3.UseVisualStyleBackColor = True
        '
        'Button4
        '
        Me.Button4.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button4.Location = New System.Drawing.Point(275, 247)
        Me.Button4.Name = "Button4"
        Me.Button4.Size = New System.Drawing.Size(114, 23)
        Me.Button4.TabIndex = 4
        Me.Button4.Text = "Last Record"
        Me.Button4.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button5.Location = New System.Drawing.Point(817, 247)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(93, 23)
        Me.Button5.TabIndex = 5
        Me.Button5.Text = "Next Record"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'Button6
        '
        Me.Button6.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button6.Location = New System.Drawing.Point(708, 247)
        Me.Button6.Name = "Button6"
        Me.Button6.Size = New System.Drawing.Size(103, 23)
        Me.Button6.TabIndex = 6
        Me.Button6.Text = "Prev Record"
        Me.Button6.UseVisualStyleBackColor = True
        '
        'Button7
        '
        Me.Button7.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button7.Location = New System.Drawing.Point(12, 167)
        Me.Button7.Name = "Button7"
        Me.Button7.Size = New System.Drawing.Size(139, 23)
        Me.Button7.TabIndex = 7
        Me.Button7.Text = "Print Document"
        Me.Button7.UseVisualStyleBackColor = True
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(39, 89)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(100, 20)
        Me.TextBox1.TabIndex = 8
        '
        'PrintDocument1
        '
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
        'AddressToolStrip
        '
        Me.AddressToolStrip.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.AddressToolStripLabel, Me.ToolStripLabel1, Me.AddressToolStripTextBox, Me.AddressToolStripButton})
        Me.AddressToolStrip.Location = New System.Drawing.Point(0, 0)
        Me.AddressToolStrip.Name = "AddressToolStrip"
        Me.AddressToolStrip.Size = New System.Drawing.Size(922, 25)
        Me.AddressToolStrip.TabIndex = 9
        Me.AddressToolStrip.Text = "AddressToolStrip"
        '
        'AddressToolStripLabel
        '
        Me.AddressToolStripLabel.Name = "AddressToolStripLabel"
        Me.AddressToolStripLabel.Size = New System.Drawing.Size(0, 22)
        '
        'ToolStripLabel1
        '
        Me.ToolStripLabel1.Name = "ToolStripLabel1"
        Me.ToolStripLabel1.Size = New System.Drawing.Size(49, 22)
        Me.ToolStripLabel1.Text = "Address"
        '
        'AddressToolStripTextBox
        '
        Me.AddressToolStripTextBox.Name = "AddressToolStripTextBox"
        Me.AddressToolStripTextBox.Size = New System.Drawing.Size(100, 25)
        '
        'AddressToolStripButton
        '
        Me.AddressToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.AddressToolStripButton.Name = "AddressToolStripButton"
        Me.AddressToolStripButton.Size = New System.Drawing.Size(46, 22)
        Me.AddressToolStripButton.Text = "Search"
        '
        'CustomerTableAdapter
        '
        Me.CustomerTableAdapter.ClearBeforeFill = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Constantia", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(22, 62)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(129, 14)
        Me.Label1.TabIndex = 10
        Me.Label1.Text = "Enter Mobile Number"
        '
        'Form6
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ButtonHighlight
        Me.ClientSize = New System.Drawing.Size(922, 318)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.AddressToolStrip)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.Button7)
        Me.Controls.Add(Me.Button6)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.Button4)
        Me.Controls.Add(Me.Button3)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form6"
        Me.Text = "Form6"
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.CustomerBindingSource, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.BankDataSet2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.AddressToolStrip.ResumeLayout(False)
        Me.AddressToolStrip.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BankDataSet2 As GAD2.BankDataSet2
    Friend WithEvents CustomerBindingSource As System.Windows.Forms.BindingSource
    Friend WithEvents CustomerTableAdapter As GAD2.BankDataSet2TableAdapters.customerTableAdapter
    Friend WithEvents NameDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents DOBDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AgeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents TypeOfAccountDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents NationalityDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AddressDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MobileNumDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MaritalStatusDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents IncomeDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents OccupationDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents ReligionDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents CategoryDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents AadharDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents MailIDDataGridViewTextBoxColumn As System.Windows.Forms.DataGridViewTextBoxColumn
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents Button2 As System.Windows.Forms.Button
    Friend WithEvents Button3 As System.Windows.Forms.Button
    Friend WithEvents Button4 As System.Windows.Forms.Button
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents Button6 As System.Windows.Forms.Button
    Friend WithEvents Button7 As System.Windows.Forms.Button
    Friend WithEvents TextBox1 As System.Windows.Forms.TextBox
    Friend WithEvents PrintDocument1 As System.Drawing.Printing.PrintDocument
    Friend WithEvents PrintPreviewDialog1 As System.Windows.Forms.PrintPreviewDialog
    Friend WithEvents AddressToolStrip As System.Windows.Forms.ToolStrip
    Friend WithEvents AddressToolStripLabel As System.Windows.Forms.ToolStripLabel
    Friend WithEvents AddressToolStripTextBox As System.Windows.Forms.ToolStripTextBox
    Friend WithEvents AddressToolStripButton As System.Windows.Forms.ToolStripButton
    Friend WithEvents ToolStripLabel1 As System.Windows.Forms.ToolStripLabel
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
