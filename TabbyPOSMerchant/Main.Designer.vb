<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Main
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Main))
        Me.RibbonControl1 = New DevExpress.XtraBars.Ribbon.RibbonControl()
        Me.btnDashbaord = New DevExpress.XtraBars.BarButtonItem()
        Me.btnBalance = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTransactions = New DevExpress.XtraBars.BarButtonItem()
        Me.btnReport = New DevExpress.XtraBars.BarButtonItem()
        Me.btnApprovalManagement = New DevExpress.XtraBars.BarButtonItem()
        Me.btnMyProfile = New DevExpress.XtraBars.BarButtonItem()
        Me.btnRoleAccess = New DevExpress.XtraBars.BarButtonItem()
        Me.btnLogout = New DevExpress.XtraBars.BarButtonItem()
        Me.btnWithdraw = New DevExpress.XtraBars.BarButtonItem()
        Me.btnTerminal = New DevExpress.XtraBars.BarButtonItem()
        Me.btnChangePassword = New DevExpress.XtraBars.BarButtonItem()
        Me.RibbonPage1 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup1 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage2 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup2 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage4 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup4 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonPage3 = New DevExpress.XtraBars.Ribbon.RibbonPage()
        Me.RibbonPageGroup3 = New DevExpress.XtraBars.Ribbon.RibbonPageGroup()
        Me.RibbonStatusBar1 = New DevExpress.XtraBars.Ribbon.RibbonStatusBar()
        Me.XtraTabbedMdiManager1 = New DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(Me.components)
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'RibbonControl1
        '
        Me.RibbonControl1.ExpandCollapseItem.Id = 0
        Me.RibbonControl1.Items.AddRange(New DevExpress.XtraBars.BarItem() {Me.RibbonControl1.ExpandCollapseItem, Me.btnDashbaord, Me.btnBalance, Me.btnTransactions, Me.btnReport, Me.btnApprovalManagement, Me.btnMyProfile, Me.btnRoleAccess, Me.btnLogout, Me.btnWithdraw, Me.btnTerminal, Me.btnChangePassword})
        Me.RibbonControl1.Location = New System.Drawing.Point(0, 0)
        Me.RibbonControl1.MaxItemId = 12
        Me.RibbonControl1.Name = "RibbonControl1"
        Me.RibbonControl1.Pages.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPage() {Me.RibbonPage1, Me.RibbonPage2, Me.RibbonPage4, Me.RibbonPage3})
        Me.RibbonControl1.ShowToolbarCustomizeItem = False
        Me.RibbonControl1.Size = New System.Drawing.Size(872, 117)
        Me.RibbonControl1.StatusBar = Me.RibbonStatusBar1
        Me.RibbonControl1.Toolbar.ShowCustomizeItem = False
        Me.RibbonControl1.ToolbarLocation = DevExpress.XtraBars.Ribbon.RibbonQuickAccessToolbarLocation.Hidden
        '
        'btnDashbaord
        '
        Me.btnDashbaord.Caption = "Dashboard"
        Me.btnDashbaord.Id = 1
        Me.btnDashbaord.LargeGlyph = CType(resources.GetObject("btnDashbaord.LargeGlyph"), System.Drawing.Image)
        Me.btnDashbaord.Name = "btnDashbaord"
        '
        'btnBalance
        '
        Me.btnBalance.Caption = "Balances"
        Me.btnBalance.Id = 2
        Me.btnBalance.LargeGlyph = CType(resources.GetObject("btnBalance.LargeGlyph"), System.Drawing.Image)
        Me.btnBalance.Name = "btnBalance"
        '
        'btnTransactions
        '
        Me.btnTransactions.Caption = "Transactions"
        Me.btnTransactions.Id = 3
        Me.btnTransactions.LargeGlyph = CType(resources.GetObject("btnTransactions.LargeGlyph"), System.Drawing.Image)
        Me.btnTransactions.Name = "btnTransactions"
        '
        'btnReport
        '
        Me.btnReport.Caption = "Report"
        Me.btnReport.Id = 4
        Me.btnReport.LargeGlyph = CType(resources.GetObject("btnReport.LargeGlyph"), System.Drawing.Image)
        Me.btnReport.Name = "btnReport"
        Me.btnReport.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnApprovalManagement
        '
        Me.btnApprovalManagement.Caption = "Approval" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Management"
        Me.btnApprovalManagement.Id = 5
        Me.btnApprovalManagement.LargeGlyph = CType(resources.GetObject("btnApprovalManagement.LargeGlyph"), System.Drawing.Image)
        Me.btnApprovalManagement.Name = "btnApprovalManagement"
        Me.btnApprovalManagement.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnMyProfile
        '
        Me.btnMyProfile.Caption = "My Profile"
        Me.btnMyProfile.Id = 6
        Me.btnMyProfile.LargeGlyph = CType(resources.GetObject("btnMyProfile.LargeGlyph"), System.Drawing.Image)
        Me.btnMyProfile.Name = "btnMyProfile"
        '
        'btnRoleAccess
        '
        Me.btnRoleAccess.Caption = "Access" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "Control"
        Me.btnRoleAccess.Id = 7
        Me.btnRoleAccess.LargeGlyph = CType(resources.GetObject("btnRoleAccess.LargeGlyph"), System.Drawing.Image)
        Me.btnRoleAccess.Name = "btnRoleAccess"
        Me.btnRoleAccess.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnLogout
        '
        Me.btnLogout.Caption = "Logout"
        Me.btnLogout.Id = 8
        Me.btnLogout.LargeGlyph = CType(resources.GetObject("btnLogout.LargeGlyph"), System.Drawing.Image)
        Me.btnLogout.Name = "btnLogout"
        '
        'btnWithdraw
        '
        Me.btnWithdraw.Caption = "Withdraw"
        Me.btnWithdraw.Id = 9
        Me.btnWithdraw.LargeGlyph = CType(resources.GetObject("btnWithdraw.LargeGlyph"), System.Drawing.Image)
        Me.btnWithdraw.Name = "btnWithdraw"
        Me.btnWithdraw.Visibility = DevExpress.XtraBars.BarItemVisibility.Never
        '
        'btnTerminal
        '
        Me.btnTerminal.Caption = "Terminal"
        Me.btnTerminal.Id = 10
        Me.btnTerminal.LargeGlyph = CType(resources.GetObject("btnTerminal.LargeGlyph"), System.Drawing.Image)
        Me.btnTerminal.Name = "btnTerminal"
        '
        'btnChangePassword
        '
        Me.btnChangePassword.Caption = "Change Password"
        Me.btnChangePassword.Id = 11
        Me.btnChangePassword.LargeGlyph = CType(resources.GetObject("btnChangePassword.LargeGlyph"), System.Drawing.Image)
        Me.btnChangePassword.Name = "btnChangePassword"
        '
        'RibbonPage1
        '
        Me.RibbonPage1.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup1})
        Me.RibbonPage1.Name = "RibbonPage1"
        Me.RibbonPage1.Text = "All Functions"
        '
        'RibbonPageGroup1
        '
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnDashbaord)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnTerminal)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnTransactions)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnBalance)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnWithdraw)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnReport)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnMyProfile)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnApprovalManagement)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnRoleAccess)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnChangePassword)
        Me.RibbonPageGroup1.ItemLinks.Add(Me.btnLogout)
        Me.RibbonPageGroup1.Name = "RibbonPageGroup1"
        '
        'RibbonPage2
        '
        Me.RibbonPage2.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup2})
        Me.RibbonPage2.Name = "RibbonPage2"
        Me.RibbonPage2.Text = "Setting"
        Me.RibbonPage2.Visible = False
        '
        'RibbonPageGroup2
        '
        Me.RibbonPageGroup2.Name = "RibbonPageGroup2"
        Me.RibbonPageGroup2.Text = "Setting"
        '
        'RibbonPage4
        '
        Me.RibbonPage4.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup4})
        Me.RibbonPage4.Name = "RibbonPage4"
        Me.RibbonPage4.Text = "Reports"
        Me.RibbonPage4.Visible = False
        '
        'RibbonPageGroup4
        '
        Me.RibbonPageGroup4.Name = "RibbonPageGroup4"
        Me.RibbonPageGroup4.Text = "Reports"
        '
        'RibbonPage3
        '
        Me.RibbonPage3.Groups.AddRange(New DevExpress.XtraBars.Ribbon.RibbonPageGroup() {Me.RibbonPageGroup3})
        Me.RibbonPage3.Name = "RibbonPage3"
        Me.RibbonPage3.Text = "About"
        Me.RibbonPage3.Visible = False
        '
        'RibbonPageGroup3
        '
        Me.RibbonPageGroup3.Name = "RibbonPageGroup3"
        Me.RibbonPageGroup3.Text = "About"
        '
        'RibbonStatusBar1
        '
        Me.RibbonStatusBar1.Location = New System.Drawing.Point(0, 471)
        Me.RibbonStatusBar1.Name = "RibbonStatusBar1"
        Me.RibbonStatusBar1.Ribbon = Me.RibbonControl1
        Me.RibbonStatusBar1.Size = New System.Drawing.Size(872, 27)
        '
        'XtraTabbedMdiManager1
        '
        Me.XtraTabbedMdiManager1.MdiParent = Me
        '
        'Main
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(872, 498)
        Me.Controls.Add(Me.RibbonStatusBar1)
        Me.Controls.Add(Me.RibbonControl1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.IsMdiContainer = True
        Me.Name = "Main"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Tabby Merchant Management Platform v0.0.7.13"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        CType(Me.RibbonControl1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.XtraTabbedMdiManager1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents RibbonControl1 As DevExpress.XtraBars.Ribbon.RibbonControl
    Friend WithEvents RibbonPage1 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup1 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonStatusBar1 As DevExpress.XtraBars.Ribbon.RibbonStatusBar
    Friend WithEvents RibbonPage2 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPage3 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents btnDashbaord As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnBalance As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTransactions As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnReport As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnApprovalManagement As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnMyProfile As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnRoleAccess As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnLogout As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents RibbonPageGroup2 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPage4 As DevExpress.XtraBars.Ribbon.RibbonPage
    Friend WithEvents RibbonPageGroup4 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents RibbonPageGroup3 As DevExpress.XtraBars.Ribbon.RibbonPageGroup
    Friend WithEvents XtraTabbedMdiManager1 As DevExpress.XtraTabbedMdi.XtraTabbedMdiManager
    Friend WithEvents btnWithdraw As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnTerminal As DevExpress.XtraBars.BarButtonItem
    Friend WithEvents btnChangePassword As DevExpress.XtraBars.BarButtonItem
End Class
