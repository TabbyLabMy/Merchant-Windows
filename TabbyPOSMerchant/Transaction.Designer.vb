<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Transaction
    Inherits DevExpress.XtraEditors.XtraForm

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        If disposing AndAlso components IsNot Nothing Then
            components.Dispose()
        End If
        MyBase.Dispose(disposing)
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Transaction))
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.cboDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.btnDateRangeReset = New System.Windows.Forms.Button()
        Me.btnDateRange90Days = New System.Windows.Forms.Button()
        Me.btnDateRange30Days = New System.Windows.Forms.Button()
        Me.btnDateRange7Days = New System.Windows.Forms.Button()
        Me.btnDateRange24Hour = New System.Windows.Forms.Button()
        Me.btnExport = New System.Windows.Forms.Button()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.btnClose = New DevExpress.XtraEditors.SimpleButton()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(9, 57)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox1})
        Me.GridControl1.Size = New System.Drawing.Size(1018, 587)
        Me.GridControl1.TabIndex = 30
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn8, Me.GridColumn9, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowAutoFilterRow = True
        Me.GridView1.OptionsView.ShowFooter = True
        '
        'GridColumn1
        '
        Me.GridColumn1.Caption = "ID"
        Me.GridColumn1.FieldName = "ID"
        Me.GridColumn1.Name = "GridColumn1"
        '
        'GridColumn2
        '
        Me.GridColumn2.Caption = "Category"
        Me.GridColumn2.ColumnEdit = Me.RepositoryItemImageComboBox1
        Me.GridColumn2.FieldName = "Category"
        Me.GridColumn2.Name = "GridColumn2"
        Me.GridColumn2.OptionsColumn.FixedWidth = True
        Me.GridColumn2.Visible = True
        Me.GridColumn2.VisibleIndex = 0
        Me.GridColumn2.Width = 120
        '
        'RepositoryItemImageComboBox1
        '
        Me.RepositoryItemImageComboBox1.AutoHeight = False
        Me.RepositoryItemImageComboBox1.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("RECEIVE", "RECEIVE", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("TRANSFER", "TRANSFER", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("DEPOSIT", "DEPOSIT", -1)})
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'GridColumn8
        '
        Me.GridColumn8.Caption = "Terminal"
        Me.GridColumn8.FieldName = "DeviceDesc"
        Me.GridColumn8.Name = "GridColumn8"
        Me.GridColumn8.OptionsColumn.FixedWidth = True
        Me.GridColumn8.Visible = True
        Me.GridColumn8.VisibleIndex = 1
        Me.GridColumn8.Width = 100
        '
        'GridColumn9
        '
        Me.GridColumn9.Caption = "Terminal ID"
        Me.GridColumn9.FieldName = "DeviceID"
        Me.GridColumn9.Name = "GridColumn9"
        Me.GridColumn9.OptionsColumn.FixedWidth = True
        Me.GridColumn9.Visible = True
        Me.GridColumn9.VisibleIndex = 2
        Me.GridColumn9.Width = 120
        '
        'GridColumn3
        '
        Me.GridColumn3.Caption = "TxID"
        Me.GridColumn3.FieldName = "TTID"
        Me.GridColumn3.Name = "GridColumn3"
        Me.GridColumn3.OptionsColumn.FixedWidth = True
        Me.GridColumn3.Visible = True
        Me.GridColumn3.VisibleIndex = 3
        Me.GridColumn3.Width = 120
        '
        'GridColumn4
        '
        Me.GridColumn4.Caption = "TrnDesc"
        Me.GridColumn4.FieldName = "TrnDesc"
        Me.GridColumn4.Name = "GridColumn4"
        Me.GridColumn4.OptionsColumn.FixedWidth = True
        Me.GridColumn4.Visible = True
        Me.GridColumn4.VisibleIndex = 4
        Me.GridColumn4.Width = 150
        '
        'GridColumn5
        '
        Me.GridColumn5.Caption = "Amount"
        Me.GridColumn5.FieldName = "Amount"
        Me.GridColumn5.Name = "GridColumn5"
        Me.GridColumn5.OptionsColumn.FixedWidth = True
        Me.GridColumn5.Summary.AddRange(New DevExpress.XtraGrid.GridSummaryItem() {New DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Amount", "{0:0.##}")})
        Me.GridColumn5.Visible = True
        Me.GridColumn5.VisibleIndex = 5
        Me.GridColumn5.Width = 120
        '
        'GridColumn6
        '
        Me.GridColumn6.Caption = "Date Time"
        Me.GridColumn6.DisplayFormat.FormatString = "yyyy-MM-dd hh:mm tt"
        Me.GridColumn6.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom
        Me.GridColumn6.FieldName = "CreatedDateTime"
        Me.GridColumn6.Name = "GridColumn6"
        Me.GridColumn6.OptionsColumn.FixedWidth = True
        Me.GridColumn6.Visible = True
        Me.GridColumn6.VisibleIndex = 6
        Me.GridColumn6.Width = 150
        '
        'GridColumn7
        '
        Me.GridColumn7.Caption = "Remarks"
        Me.GridColumn7.FieldName = "Remarks"
        Me.GridColumn7.Name = "GridColumn7"
        Me.GridColumn7.Visible = True
        Me.GridColumn7.VisibleIndex = 7
        Me.GridColumn7.Width = 160
        '
        'cboDateTo
        '
        Me.cboDateTo.EditValue = Nothing
        Me.cboDateTo.Location = New System.Drawing.Point(444, 16)
        Me.cboDateTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDateTo.Name = "cboDateTo"
        Me.cboDateTo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateTo.Properties.Appearance.Options.UseFont = True
        Me.cboDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateTo.Size = New System.Drawing.Size(117, 26)
        Me.cboDateTo.TabIndex = 29
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(420, 20)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(19, 20)
        Me.LabelControl9.TabIndex = 28
        Me.LabelControl9.Text = "To"
        '
        'cboDateFrom
        '
        Me.cboDateFrom.EditValue = Nothing
        Me.cboDateFrom.Location = New System.Drawing.Point(296, 16)
        Me.cboDateFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDateFrom.Name = "cboDateFrom"
        Me.cboDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateFrom.Properties.Appearance.Options.UseFont = True
        Me.cboDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateFrom.Size = New System.Drawing.Size(117, 26)
        Me.cboDateFrom.TabIndex = 27
        '
        'btnDateRangeReset
        '
        Me.btnDateRangeReset.Location = New System.Drawing.Point(568, 15)
        Me.btnDateRangeReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRangeReset.Name = "btnDateRangeReset"
        Me.btnDateRangeReset.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRangeReset.TabIndex = 26
        Me.btnDateRangeReset.Text = "Load"
        Me.btnDateRangeReset.UseVisualStyleBackColor = True
        '
        'btnDateRange90Days
        '
        Me.btnDateRange90Days.Location = New System.Drawing.Point(220, 15)
        Me.btnDateRange90Days.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange90Days.Name = "btnDateRange90Days"
        Me.btnDateRange90Days.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRange90Days.TabIndex = 25
        Me.btnDateRange90Days.Text = "90 Days"
        Me.btnDateRange90Days.UseVisualStyleBackColor = True
        '
        'btnDateRange30Days
        '
        Me.btnDateRange30Days.Location = New System.Drawing.Point(145, 15)
        Me.btnDateRange30Days.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange30Days.Name = "btnDateRange30Days"
        Me.btnDateRange30Days.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRange30Days.TabIndex = 24
        Me.btnDateRange30Days.Text = "30 Days"
        Me.btnDateRange30Days.UseVisualStyleBackColor = True
        '
        'btnDateRange7Days
        '
        Me.btnDateRange7Days.Location = New System.Drawing.Point(69, 15)
        Me.btnDateRange7Days.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange7Days.Name = "btnDateRange7Days"
        Me.btnDateRange7Days.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRange7Days.TabIndex = 23
        Me.btnDateRange7Days.Text = "7 Days"
        Me.btnDateRange7Days.UseVisualStyleBackColor = True
        '
        'btnDateRange24Hour
        '
        Me.btnDateRange24Hour.Location = New System.Drawing.Point(9, 15)
        Me.btnDateRange24Hour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange24Hour.Name = "btnDateRange24Hour"
        Me.btnDateRange24Hour.Size = New System.Drawing.Size(52, 31)
        Me.btnDateRange24Hour.TabIndex = 22
        Me.btnDateRange24Hour.Text = "24H"
        Me.btnDateRange24Hour.UseVisualStyleBackColor = True
        '
        'btnExport
        '
        Me.btnExport.Location = New System.Drawing.Point(644, 15)
        Me.btnExport.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnExport.Name = "btnExport"
        Me.btnExport.Size = New System.Drawing.Size(69, 31)
        Me.btnExport.TabIndex = 32
        Me.btnExport.Text = "Export"
        Me.btnExport.UseVisualStyleBackColor = True
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Us Dollar Circled_20px.png")
        Me.ImageList1.Images.SetKeyName(1, "Logout_20px.png")
        Me.ImageList1.Images.SetKeyName(2, "safe_in_16px.png")
        '
        'btnClose
        '
        Me.btnClose.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.btnClose.Location = New System.Drawing.Point(933, 11)
        Me.btnClose.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnClose.Name = "btnClose"
        Me.btnClose.Size = New System.Drawing.Size(94, 38)
        Me.btnClose.TabIndex = 33
        Me.btnClose.Text = "Close"
        '
        'Transaction
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1042, 658)
        Me.Controls.Add(Me.btnClose)
        Me.Controls.Add(Me.btnExport)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cboDateTo)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.cboDateFrom)
        Me.Controls.Add(Me.btnDateRangeReset)
        Me.Controls.Add(Me.btnDateRange90Days)
        Me.Controls.Add(Me.btnDateRange30Days)
        Me.Controls.Add(Me.btnDateRange7Days)
        Me.Controls.Add(Me.btnDateRange24Hour)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Transaction"
        Me.Text = "Transaction"
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents cboDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents btnDateRangeReset As System.Windows.Forms.Button
    Friend WithEvents btnDateRange90Days As System.Windows.Forms.Button
    Friend WithEvents btnDateRange30Days As System.Windows.Forms.Button
    Friend WithEvents btnDateRange7Days As System.Windows.Forms.Button
    Friend WithEvents btnDateRange24Hour As System.Windows.Forms.Button
    Friend WithEvents btnExport As System.Windows.Forms.Button
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents btnClose As DevExpress.XtraEditors.SimpleButton
End Class
