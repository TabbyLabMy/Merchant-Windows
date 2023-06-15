<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Dashboardvb
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Dashboardvb))
        Me.LabelControl1 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl2 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl3 = New DevExpress.XtraEditors.LabelControl()
        Me.LabelControl4 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.lblTotalTransaction = New DevExpress.XtraEditors.LabelControl()
        Me.lblCompletedTransaction = New DevExpress.XtraEditors.LabelControl()
        Me.lblActiveUser = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox2 = New System.Windows.Forms.PictureBox()
        Me.PictureBox3 = New System.Windows.Forms.PictureBox()
        Me.LabelControl8 = New DevExpress.XtraEditors.LabelControl()
        Me.btnDateRange24Hour = New System.Windows.Forms.Button()
        Me.btnDateRange7Days = New System.Windows.Forms.Button()
        Me.btnDateRange30Days = New System.Windows.Forms.Button()
        Me.btnDateRange90Days = New System.Windows.Forms.Button()
        Me.btnDateRangeReset = New System.Windows.Forms.Button()
        Me.cboDateFrom = New DevExpress.XtraEditors.DateEdit()
        Me.LabelControl9 = New DevExpress.XtraEditors.LabelControl()
        Me.cboDateTo = New DevExpress.XtraEditors.DateEdit()
        Me.GridControl1 = New DevExpress.XtraGrid.GridControl()
        Me.GridView1 = New DevExpress.XtraGrid.Views.Grid.GridView()
        Me.GridColumn1 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn2 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.RepositoryItemImageComboBox1 = New DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox()
        Me.ImageList1 = New System.Windows.Forms.ImageList(Me.components)
        Me.GridColumn8 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn9 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn3 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn4 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn5 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn6 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.GridColumn7 = New DevExpress.XtraGrid.Columns.GridColumn()
        Me.PictureBox4 = New System.Windows.Forms.PictureBox()
        Me.LabelControl10 = New DevExpress.XtraEditors.LabelControl()
        Me.PictureBox5 = New System.Windows.Forms.PictureBox()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateFrom.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.cboDateTo.Properties, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'LabelControl1
        '
        Me.LabelControl1.Appearance.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelControl1.Location = New System.Drawing.Point(14, 15)
        Me.LabelControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl1.Name = "LabelControl1"
        Me.LabelControl1.Size = New System.Drawing.Size(63, 27)
        Me.LabelControl1.TabIndex = 0
        Me.LabelControl1.Text = "Today"
        '
        'LabelControl2
        '
        Me.LabelControl2.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl2.Location = New System.Drawing.Point(68, 58)
        Me.LabelControl2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl2.Name = "LabelControl2"
        Me.LabelControl2.Size = New System.Drawing.Size(205, 20)
        Me.LabelControl2.TabIndex = 1
        Me.LabelControl2.Text = "Total Transactions / Amount"
        '
        'LabelControl3
        '
        Me.LabelControl3.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl3.Location = New System.Drawing.Point(342, 58)
        Me.LabelControl3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl3.Name = "LabelControl3"
        Me.LabelControl3.Size = New System.Drawing.Size(218, 20)
        Me.LabelControl3.TabIndex = 2
        Me.LabelControl3.Text = "Total Completed Transactions"
        '
        'LabelControl4
        '
        Me.LabelControl4.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl4.Location = New System.Drawing.Point(633, 58)
        Me.LabelControl4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl4.Name = "LabelControl4"
        Me.LabelControl4.Size = New System.Drawing.Size(90, 20)
        Me.LabelControl4.TabIndex = 3
        Me.LabelControl4.Text = "Active Users"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = CType(resources.GetObject("PictureBox1.Image"), System.Drawing.Image)
        Me.PictureBox1.Location = New System.Drawing.Point(20, 63)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(37, 39)
        Me.PictureBox1.TabIndex = 4
        Me.PictureBox1.TabStop = False
        '
        'lblTotalTransaction
        '
        Me.lblTotalTransaction.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblTotalTransaction.Location = New System.Drawing.Point(68, 86)
        Me.lblTotalTransaction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblTotalTransaction.Name = "lblTotalTransaction"
        Me.lblTotalTransaction.Size = New System.Drawing.Size(75, 22)
        Me.lblTotalTransaction.TabIndex = 7
        Me.lblTotalTransaction.Text = "0 / ERG 0"
        '
        'lblCompletedTransaction
        '
        Me.lblCompletedTransaction.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblCompletedTransaction.Location = New System.Drawing.Point(342, 86)
        Me.lblCompletedTransaction.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblCompletedTransaction.Name = "lblCompletedTransaction"
        Me.lblCompletedTransaction.Size = New System.Drawing.Size(75, 22)
        Me.lblCompletedTransaction.TabIndex = 8
        Me.lblCompletedTransaction.Text = "0 / ERG 0"
        '
        'lblActiveUser
        '
        Me.lblActiveUser.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.lblActiveUser.Location = New System.Drawing.Point(633, 86)
        Me.lblActiveUser.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.lblActiveUser.Name = "lblActiveUser"
        Me.lblActiveUser.Size = New System.Drawing.Size(10, 22)
        Me.lblActiveUser.TabIndex = 9
        Me.lblActiveUser.Text = "0"
        '
        'PictureBox2
        '
        Me.PictureBox2.Image = CType(resources.GetObject("PictureBox2.Image"), System.Drawing.Image)
        Me.PictureBox2.Location = New System.Drawing.Point(294, 63)
        Me.PictureBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox2.Name = "PictureBox2"
        Me.PictureBox2.Size = New System.Drawing.Size(37, 39)
        Me.PictureBox2.TabIndex = 10
        Me.PictureBox2.TabStop = False
        '
        'PictureBox3
        '
        Me.PictureBox3.Image = CType(resources.GetObject("PictureBox3.Image"), System.Drawing.Image)
        Me.PictureBox3.Location = New System.Drawing.Point(586, 63)
        Me.PictureBox3.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox3.Name = "PictureBox3"
        Me.PictureBox3.Size = New System.Drawing.Size(37, 39)
        Me.PictureBox3.TabIndex = 11
        Me.PictureBox3.TabStop = False
        '
        'LabelControl8
        '
        Me.LabelControl8.Appearance.Font = New System.Drawing.Font("Microsoft YaHei UI", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(134, Byte))
        Me.LabelControl8.Location = New System.Drawing.Point(14, 137)
        Me.LabelControl8.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl8.Name = "LabelControl8"
        Me.LabelControl8.Size = New System.Drawing.Size(219, 27)
        Me.LabelControl8.TabIndex = 12
        Me.LabelControl8.Text = "Transaction Overview"
        '
        'btnDateRange24Hour
        '
        Me.btnDateRange24Hour.Location = New System.Drawing.Point(15, 171)
        Me.btnDateRange24Hour.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange24Hour.Name = "btnDateRange24Hour"
        Me.btnDateRange24Hour.Size = New System.Drawing.Size(52, 31)
        Me.btnDateRange24Hour.TabIndex = 13
        Me.btnDateRange24Hour.Text = "24H"
        Me.btnDateRange24Hour.UseVisualStyleBackColor = True
        '
        'btnDateRange7Days
        '
        Me.btnDateRange7Days.Location = New System.Drawing.Point(75, 171)
        Me.btnDateRange7Days.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange7Days.Name = "btnDateRange7Days"
        Me.btnDateRange7Days.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRange7Days.TabIndex = 14
        Me.btnDateRange7Days.Text = "7 Days"
        Me.btnDateRange7Days.UseVisualStyleBackColor = True
        '
        'btnDateRange30Days
        '
        Me.btnDateRange30Days.Location = New System.Drawing.Point(150, 171)
        Me.btnDateRange30Days.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange30Days.Name = "btnDateRange30Days"
        Me.btnDateRange30Days.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRange30Days.TabIndex = 15
        Me.btnDateRange30Days.Text = "30 Days"
        Me.btnDateRange30Days.UseVisualStyleBackColor = True
        '
        'btnDateRange90Days
        '
        Me.btnDateRange90Days.Location = New System.Drawing.Point(226, 171)
        Me.btnDateRange90Days.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRange90Days.Name = "btnDateRange90Days"
        Me.btnDateRange90Days.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRange90Days.TabIndex = 16
        Me.btnDateRange90Days.Text = "90 Days"
        Me.btnDateRange90Days.UseVisualStyleBackColor = True
        '
        'btnDateRangeReset
        '
        Me.btnDateRangeReset.Location = New System.Drawing.Point(574, 171)
        Me.btnDateRangeReset.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.btnDateRangeReset.Name = "btnDateRangeReset"
        Me.btnDateRangeReset.Size = New System.Drawing.Size(69, 31)
        Me.btnDateRangeReset.TabIndex = 17
        Me.btnDateRangeReset.Text = "Load"
        Me.btnDateRangeReset.UseVisualStyleBackColor = True
        '
        'cboDateFrom
        '
        Me.cboDateFrom.EditValue = Nothing
        Me.cboDateFrom.Location = New System.Drawing.Point(302, 172)
        Me.cboDateFrom.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDateFrom.Name = "cboDateFrom"
        Me.cboDateFrom.Properties.Appearance.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateFrom.Properties.Appearance.Options.UseFont = True
        Me.cboDateFrom.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateFrom.Size = New System.Drawing.Size(117, 26)
        Me.cboDateFrom.TabIndex = 18
        '
        'LabelControl9
        '
        Me.LabelControl9.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl9.Location = New System.Drawing.Point(426, 176)
        Me.LabelControl9.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl9.Name = "LabelControl9"
        Me.LabelControl9.Size = New System.Drawing.Size(19, 20)
        Me.LabelControl9.TabIndex = 19
        Me.LabelControl9.Text = "To"
        '
        'cboDateTo
        '
        Me.cboDateTo.EditValue = Nothing
        Me.cboDateTo.Location = New System.Drawing.Point(450, 172)
        Me.cboDateTo.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.cboDateTo.Name = "cboDateTo"
        Me.cboDateTo.Properties.Appearance.Font = New System.Drawing.Font("Microsoft YaHei UI", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cboDateTo.Properties.Appearance.Options.UseFont = True
        Me.cboDateTo.Properties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateTo.Properties.CalendarTimeProperties.Buttons.AddRange(New DevExpress.XtraEditors.Controls.EditorButton() {New DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)})
        Me.cboDateTo.Size = New System.Drawing.Size(117, 26)
        Me.cboDateTo.TabIndex = 20
        '
        'GridControl1
        '
        Me.GridControl1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.GridControl1.EmbeddedNavigator.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Location = New System.Drawing.Point(20, 209)
        Me.GridControl1.MainView = Me.GridView1
        Me.GridControl1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GridControl1.Name = "GridControl1"
        Me.GridControl1.RepositoryItems.AddRange(New DevExpress.XtraEditors.Repository.RepositoryItem() {Me.RepositoryItemImageComboBox1})
        Me.GridControl1.Size = New System.Drawing.Size(1234, 569)
        Me.GridControl1.TabIndex = 21
        Me.GridControl1.ViewCollection.AddRange(New DevExpress.XtraGrid.Views.Base.BaseView() {Me.GridView1})
        '
        'GridView1
        '
        Me.GridView1.Columns.AddRange(New DevExpress.XtraGrid.Columns.GridColumn() {Me.GridColumn1, Me.GridColumn2, Me.GridColumn8, Me.GridColumn9, Me.GridColumn3, Me.GridColumn4, Me.GridColumn5, Me.GridColumn6, Me.GridColumn7})
        Me.GridView1.GridControl = Me.GridControl1
        Me.GridView1.Name = "GridView1"
        Me.GridView1.OptionsBehavior.Editable = False
        Me.GridView1.OptionsView.ShowGroupPanel = False
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
        Me.RepositoryItemImageComboBox1.Items.AddRange(New DevExpress.XtraEditors.Controls.ImageComboBoxItem() {New DevExpress.XtraEditors.Controls.ImageComboBoxItem("RECEIVE", "RECEIVE", 0), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("TRANSFER", "TRANSFER", 1), New DevExpress.XtraEditors.Controls.ImageComboBoxItem("DEPOSIT", "DEPOSIT", 2)})
        Me.RepositoryItemImageComboBox1.LargeImages = Me.ImageList1
        Me.RepositoryItemImageComboBox1.Name = "RepositoryItemImageComboBox1"
        '
        'ImageList1
        '
        Me.ImageList1.ImageStream = CType(resources.GetObject("ImageList1.ImageStream"), System.Windows.Forms.ImageListStreamer)
        Me.ImageList1.TransparentColor = System.Drawing.Color.Transparent
        Me.ImageList1.Images.SetKeyName(0, "Us Dollar Circled_20px.png")
        Me.ImageList1.Images.SetKeyName(1, "Logout_20px.png")
        Me.ImageList1.Images.SetKeyName(2, "safe_in_16px.png")
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
        'PictureBox4
        '
        Me.PictureBox4.BackColor = System.Drawing.Color.Transparent
        Me.PictureBox4.Image = CType(resources.GetObject("PictureBox4.Image"), System.Drawing.Image)
        Me.PictureBox4.Location = New System.Drawing.Point(1098, 15)
        Me.PictureBox4.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.PictureBox4.Name = "PictureBox4"
        Me.PictureBox4.Size = New System.Drawing.Size(113, 117)
        Me.PictureBox4.TabIndex = 22
        Me.PictureBox4.TabStop = False
        Me.PictureBox4.Visible = False
        '
        'LabelControl10
        '
        Me.LabelControl10.Appearance.Font = New System.Drawing.Font("Microsoft YaHei", 9.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.LabelControl10.Location = New System.Drawing.Point(1097, 139)
        Me.LabelControl10.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.LabelControl10.Name = "LabelControl10"
        Me.LabelControl10.Size = New System.Drawing.Size(121, 20)
        Me.LabelControl10.TabIndex = 23
        Me.LabelControl10.Text = "No results found"
        Me.LabelControl10.Visible = False
        '
        'PictureBox5
        '
        Me.PictureBox5.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.PictureBox5.Image = CType(resources.GetObject("PictureBox5.Image"), System.Drawing.Image)
        Me.PictureBox5.Location = New System.Drawing.Point(1072, 137)
        Me.PictureBox5.Name = "PictureBox5"
        Me.PictureBox5.Size = New System.Drawing.Size(212, 128)
        Me.PictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox5.TabIndex = 24
        Me.PictureBox5.TabStop = False
        '
        'Dashboardvb
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1268, 793)
        Me.Controls.Add(Me.LabelControl10)
        Me.Controls.Add(Me.PictureBox4)
        Me.Controls.Add(Me.GridControl1)
        Me.Controls.Add(Me.cboDateTo)
        Me.Controls.Add(Me.LabelControl9)
        Me.Controls.Add(Me.cboDateFrom)
        Me.Controls.Add(Me.btnDateRangeReset)
        Me.Controls.Add(Me.btnDateRange90Days)
        Me.Controls.Add(Me.btnDateRange30Days)
        Me.Controls.Add(Me.btnDateRange7Days)
        Me.Controls.Add(Me.btnDateRange24Hour)
        Me.Controls.Add(Me.LabelControl8)
        Me.Controls.Add(Me.PictureBox3)
        Me.Controls.Add(Me.PictureBox2)
        Me.Controls.Add(Me.lblActiveUser)
        Me.Controls.Add(Me.lblCompletedTransaction)
        Me.Controls.Add(Me.lblTotalTransaction)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.LabelControl4)
        Me.Controls.Add(Me.LabelControl3)
        Me.Controls.Add(Me.LabelControl2)
        Me.Controls.Add(Me.LabelControl1)
        Me.Controls.Add(Me.PictureBox5)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "Dashboardvb"
        Me.Text = "Dashboard"
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateFrom.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateFrom.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateTo.Properties.CalendarTimeProperties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.cboDateTo.Properties, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.GridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RepositoryItemImageComboBox1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.PictureBox5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents LabelControl1 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl2 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl3 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents LabelControl4 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox1 As System.Windows.Forms.PictureBox
    Friend WithEvents lblTotalTransaction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblCompletedTransaction As DevExpress.XtraEditors.LabelControl
    Friend WithEvents lblActiveUser As DevExpress.XtraEditors.LabelControl
    Friend WithEvents PictureBox2 As System.Windows.Forms.PictureBox
    Friend WithEvents PictureBox3 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl8 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents btnDateRange24Hour As System.Windows.Forms.Button
    Friend WithEvents btnDateRange7Days As System.Windows.Forms.Button
    Friend WithEvents btnDateRange30Days As System.Windows.Forms.Button
    Friend WithEvents btnDateRange90Days As System.Windows.Forms.Button
    Friend WithEvents btnDateRangeReset As System.Windows.Forms.Button
    Friend WithEvents cboDateFrom As DevExpress.XtraEditors.DateEdit
    Friend WithEvents LabelControl9 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents cboDateTo As DevExpress.XtraEditors.DateEdit
    Friend WithEvents GridControl1 As DevExpress.XtraGrid.GridControl
    Friend WithEvents GridView1 As DevExpress.XtraGrid.Views.Grid.GridView
    Friend WithEvents PictureBox4 As System.Windows.Forms.PictureBox
    Friend WithEvents LabelControl10 As DevExpress.XtraEditors.LabelControl
    Friend WithEvents GridColumn1 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn2 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn3 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn4 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn5 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn6 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn7 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents RepositoryItemImageComboBox1 As DevExpress.XtraEditors.Repository.RepositoryItemImageComboBox
    Friend WithEvents ImageList1 As System.Windows.Forms.ImageList
    Friend WithEvents GridColumn8 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents GridColumn9 As DevExpress.XtraGrid.Columns.GridColumn
    Friend WithEvents PictureBox5 As System.Windows.Forms.PictureBox
End Class
