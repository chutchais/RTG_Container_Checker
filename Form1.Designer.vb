<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmMain))
        Me.SplitContainer1 = New System.Windows.Forms.SplitContainer()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.AxVLCPluginSea2 = New AxAXVLC.AxVLCPlugin2()
        Me.AxVLCPluginSea1 = New AxAXVLC.AxVLCPlugin2()
        Me.TableLayoutPanel2 = New System.Windows.Forms.TableLayoutPanel()
        Me.AxVLCPluginLand2 = New AxAXVLC.AxVLCPlugin2()
        Me.AxVLCPluginLand1 = New AxAXVLC.AxVLCPlugin2()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.CameraToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ViewToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SeaSideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LandSideToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.CenterToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStrip1 = New System.Windows.Forms.ToolStrip()
        Me.ToolStripSeparator1 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbSeaside = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator2 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbLandSide = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator3 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbAll = New System.Windows.Forms.ToolStripButton()
        Me.ToolStripSeparator4 = New System.Windows.Forms.ToolStripSeparator()
        Me.tsbRatio169 = New System.Windows.Forms.ToolStripButton()
        Me.tsbRatio43 = New System.Windows.Forms.ToolStripButton()
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SplitContainer1.Panel1.SuspendLayout()
        Me.SplitContainer1.Panel2.SuspendLayout()
        Me.SplitContainer1.SuspendLayout()
        Me.TableLayoutPanel1.SuspendLayout()
        CType(Me.AxVLCPluginSea2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVLCPluginSea1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.TableLayoutPanel2.SuspendLayout()
        CType(Me.AxVLCPluginLand2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.AxVLCPluginLand1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.MenuStrip1.SuspendLayout()
        Me.ToolStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'SplitContainer1
        '
        Me.SplitContainer1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.SplitContainer1.IsSplitterFixed = True
        Me.SplitContainer1.Location = New System.Drawing.Point(0, 63)
        Me.SplitContainer1.Name = "SplitContainer1"
        Me.SplitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal
        '
        'SplitContainer1.Panel1
        '
        Me.SplitContainer1.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.SplitContainer1.Panel1.Controls.Add(Me.TableLayoutPanel1)
        '
        'SplitContainer1.Panel2
        '
        Me.SplitContainer1.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(192, Byte), Integer), CType(CType(255, Byte), Integer), CType(CType(255, Byte), Integer))
        Me.SplitContainer1.Panel2.Controls.Add(Me.TableLayoutPanel2)
        Me.SplitContainer1.Size = New System.Drawing.Size(569, 418)
        Me.SplitContainer1.SplitterDistance = 208
        Me.SplitContainer1.TabIndex = 0
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.AutoSize = True
        Me.TableLayoutPanel1.ColumnCount = 2
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Controls.Add(Me.AxVLCPluginSea2, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.AxVLCPluginSea1, 0, 0)
        Me.TableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(569, 208)
        Me.TableLayoutPanel1.TabIndex = 1
        '
        'AxVLCPluginSea2
        '
        Me.AxVLCPluginSea2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxVLCPluginSea2.Enabled = True
        Me.AxVLCPluginSea2.Location = New System.Drawing.Point(287, 3)
        Me.AxVLCPluginSea2.Name = "AxVLCPluginSea2"
        Me.AxVLCPluginSea2.OcxState = CType(resources.GetObject("AxVLCPluginSea2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPluginSea2.Size = New System.Drawing.Size(279, 202)
        Me.AxVLCPluginSea2.TabIndex = 2
        '
        'AxVLCPluginSea1
        '
        Me.AxVLCPluginSea1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxVLCPluginSea1.Enabled = True
        Me.AxVLCPluginSea1.Location = New System.Drawing.Point(3, 3)
        Me.AxVLCPluginSea1.Name = "AxVLCPluginSea1"
        Me.AxVLCPluginSea1.OcxState = CType(resources.GetObject("AxVLCPluginSea1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPluginSea1.Size = New System.Drawing.Size(278, 202)
        Me.AxVLCPluginSea1.TabIndex = 1
        '
        'TableLayoutPanel2
        '
        Me.TableLayoutPanel2.ColumnCount = 2
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Controls.Add(Me.AxVLCPluginLand2, 0, 0)
        Me.TableLayoutPanel2.Controls.Add(Me.AxVLCPluginLand1, 0, 0)
        Me.TableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill
        Me.TableLayoutPanel2.Location = New System.Drawing.Point(0, 0)
        Me.TableLayoutPanel2.Name = "TableLayoutPanel2"
        Me.TableLayoutPanel2.RowCount = 1
        Me.TableLayoutPanel2.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50.0!))
        Me.TableLayoutPanel2.Size = New System.Drawing.Size(569, 206)
        Me.TableLayoutPanel2.TabIndex = 1
        '
        'AxVLCPluginLand2
        '
        Me.AxVLCPluginLand2.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxVLCPluginLand2.Enabled = True
        Me.AxVLCPluginLand2.Location = New System.Drawing.Point(287, 3)
        Me.AxVLCPluginLand2.Name = "AxVLCPluginLand2"
        Me.AxVLCPluginLand2.OcxState = CType(resources.GetObject("AxVLCPluginLand2.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPluginLand2.Size = New System.Drawing.Size(279, 200)
        Me.AxVLCPluginLand2.TabIndex = 3
        '
        'AxVLCPluginLand1
        '
        Me.AxVLCPluginLand1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AxVLCPluginLand1.Enabled = True
        Me.AxVLCPluginLand1.Location = New System.Drawing.Point(3, 3)
        Me.AxVLCPluginLand1.Name = "AxVLCPluginLand1"
        Me.AxVLCPluginLand1.OcxState = CType(resources.GetObject("AxVLCPluginLand1.OcxState"), System.Windows.Forms.AxHost.State)
        Me.AxVLCPluginLand1.Size = New System.Drawing.Size(278, 200)
        Me.AxVLCPluginLand1.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.CameraToolStripMenuItem, Me.ViewToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(569, 24)
        Me.MenuStrip1.TabIndex = 1
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'CameraToolStripMenuItem
        '
        Me.CameraToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SettingToolStripMenuItem})
        Me.CameraToolStripMenuItem.Name = "CameraToolStripMenuItem"
        Me.CameraToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.CameraToolStripMenuItem.Text = "Camera"
        '
        'SettingToolStripMenuItem
        '
        Me.SettingToolStripMenuItem.Name = "SettingToolStripMenuItem"
        Me.SettingToolStripMenuItem.Size = New System.Drawing.Size(111, 22)
        Me.SettingToolStripMenuItem.Text = "Setting"
        '
        'ViewToolStripMenuItem
        '
        Me.ViewToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.SeaSideToolStripMenuItem, Me.LandSideToolStripMenuItem, Me.CenterToolStripMenuItem})
        Me.ViewToolStripMenuItem.Name = "ViewToolStripMenuItem"
        Me.ViewToolStripMenuItem.Size = New System.Drawing.Size(44, 20)
        Me.ViewToolStripMenuItem.Text = "View"
        '
        'SeaSideToolStripMenuItem
        '
        Me.SeaSideToolStripMenuItem.Name = "SeaSideToolStripMenuItem"
        Me.SeaSideToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.SeaSideToolStripMenuItem.Text = "Sea Side"
        '
        'LandSideToolStripMenuItem
        '
        Me.LandSideToolStripMenuItem.Name = "LandSideToolStripMenuItem"
        Me.LandSideToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.LandSideToolStripMenuItem.Text = "Land Side"
        '
        'CenterToolStripMenuItem
        '
        Me.CenterToolStripMenuItem.Name = "CenterToolStripMenuItem"
        Me.CenterToolStripMenuItem.Size = New System.Drawing.Size(125, 22)
        Me.CenterToolStripMenuItem.Text = "&ALL"
        '
        'ToolStrip1
        '
        Me.ToolStrip1.ImageScalingSize = New System.Drawing.Size(32, 32)
        Me.ToolStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.ToolStripSeparator1, Me.tsbSeaside, Me.ToolStripSeparator2, Me.tsbLandSide, Me.ToolStripSeparator3, Me.tsbAll, Me.ToolStripSeparator4, Me.tsbRatio169, Me.tsbRatio43})
        Me.ToolStrip1.Location = New System.Drawing.Point(0, 24)
        Me.ToolStrip1.Name = "ToolStrip1"
        Me.ToolStrip1.RenderMode = System.Windows.Forms.ToolStripRenderMode.System
        Me.ToolStrip1.Size = New System.Drawing.Size(569, 39)
        Me.ToolStrip1.TabIndex = 2
        Me.ToolStrip1.Text = "ToolStrip1"
        '
        'ToolStripSeparator1
        '
        Me.ToolStripSeparator1.Name = "ToolStripSeparator1"
        Me.ToolStripSeparator1.Size = New System.Drawing.Size(6, 39)
        '
        'tsbSeaside
        '
        Me.tsbSeaside.Image = CType(resources.GetObject("tsbSeaside.Image"), System.Drawing.Image)
        Me.tsbSeaside.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbSeaside.Name = "tsbSeaside"
        Me.tsbSeaside.Size = New System.Drawing.Size(85, 36)
        Me.tsbSeaside.Text = "Sea side"
        '
        'ToolStripSeparator2
        '
        Me.ToolStripSeparator2.Name = "ToolStripSeparator2"
        Me.ToolStripSeparator2.Size = New System.Drawing.Size(6, 39)
        '
        'tsbLandSide
        '
        Me.tsbLandSide.Image = CType(resources.GetObject("tsbLandSide.Image"), System.Drawing.Image)
        Me.tsbLandSide.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbLandSide.Name = "tsbLandSide"
        Me.tsbLandSide.Size = New System.Drawing.Size(93, 36)
        Me.tsbLandSide.Text = "Land side"
        '
        'ToolStripSeparator3
        '
        Me.ToolStripSeparator3.Name = "ToolStripSeparator3"
        Me.ToolStripSeparator3.Size = New System.Drawing.Size(6, 39)
        '
        'tsbAll
        '
        Me.tsbAll.Image = CType(resources.GetObject("tsbAll.Image"), System.Drawing.Image)
        Me.tsbAll.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbAll.Name = "tsbAll"
        Me.tsbAll.Size = New System.Drawing.Size(63, 36)
        Me.tsbAll.Text = "ALL"
        '
        'ToolStripSeparator4
        '
        Me.ToolStripSeparator4.Name = "ToolStripSeparator4"
        Me.ToolStripSeparator4.Size = New System.Drawing.Size(6, 39)
        '
        'tsbRatio169
        '
        Me.tsbRatio169.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRatio169.Image = CType(resources.GetObject("tsbRatio169.Image"), System.Drawing.Image)
        Me.tsbRatio169.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRatio169.Name = "tsbRatio169"
        Me.tsbRatio169.Size = New System.Drawing.Size(32, 36)
        Me.tsbRatio169.Text = "16:9"
        '
        'tsbRatio43
        '
        Me.tsbRatio43.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text
        Me.tsbRatio43.Image = CType(resources.GetObject("tsbRatio43.Image"), System.Drawing.Image)
        Me.tsbRatio43.ImageTransparentColor = System.Drawing.Color.Magenta
        Me.tsbRatio43.Name = "tsbRatio43"
        Me.tsbRatio43.Size = New System.Drawing.Size(26, 36)
        Me.tsbRatio43.Text = "4:3"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(569, 481)
        Me.Controls.Add(Me.SplitContainer1)
        Me.Controls.Add(Me.ToolStrip1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "RTG Container Checker"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.SplitContainer1.Panel1.ResumeLayout(False)
        Me.SplitContainer1.Panel1.PerformLayout()
        Me.SplitContainer1.Panel2.ResumeLayout(False)
        CType(Me.SplitContainer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.SplitContainer1.ResumeLayout(False)
        Me.TableLayoutPanel1.ResumeLayout(False)
        CType(Me.AxVLCPluginSea2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVLCPluginSea1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.TableLayoutPanel2.ResumeLayout(False)
        CType(Me.AxVLCPluginLand2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.AxVLCPluginLand1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ToolStrip1.ResumeLayout(False)
        Me.ToolStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents SplitContainer1 As SplitContainer
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents AxVLCPluginSea1 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents AxVLCPluginSea2 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents CameraToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ViewToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents CenterToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents ToolStrip1 As ToolStrip
    Friend WithEvents SeaSideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LandSideToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents tsbSeaside As ToolStripButton
    Friend WithEvents tsbLandSide As ToolStripButton
    Friend WithEvents tsbAll As ToolStripButton
    Friend WithEvents ToolStripSeparator1 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator2 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator3 As ToolStripSeparator
    Friend WithEvents ToolStripSeparator4 As ToolStripSeparator
    Friend WithEvents tsbRatio169 As ToolStripButton
    Friend WithEvents tsbRatio43 As ToolStripButton
    Friend WithEvents TableLayoutPanel2 As TableLayoutPanel
    Friend WithEvents AxVLCPluginLand2 As AxAXVLC.AxVLCPlugin2
    Friend WithEvents AxVLCPluginLand1 As AxAXVLC.AxVLCPlugin2
End Class
