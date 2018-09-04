<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSetting
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSetting))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblResultR2 = New System.Windows.Forms.Label()
        Me.btnCheckR2 = New System.Windows.Forms.Button()
        Me.lblResultR1 = New System.Windows.Forms.Label()
        Me.btnCheckR1 = New System.Windows.Forms.Button()
        Me.txtCameraIpR2 = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtCameraIpR1 = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.lblResultL2 = New System.Windows.Forms.Label()
        Me.btnCheckL2 = New System.Windows.Forms.Button()
        Me.lblResultL1 = New System.Windows.Forms.Label()
        Me.btnCheckL1 = New System.Windows.Forms.Button()
        Me.txtCameraIpL2 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtCameraIpL1 = New System.Windows.Forms.TextBox()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.btnSave = New System.Windows.Forms.Button()
        Me.btnCancel = New System.Windows.Forms.Button()
        Me.lblSeaLeft = New System.Windows.Forms.Label()
        Me.lblSeaRight = New System.Windows.Forms.Label()
        Me.lblLandLeft = New System.Windows.Forms.Label()
        Me.lblLandRight = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblSeaRight)
        Me.GroupBox1.Controls.Add(Me.lblSeaLeft)
        Me.GroupBox1.Controls.Add(Me.lblResultR2)
        Me.GroupBox1.Controls.Add(Me.btnCheckR2)
        Me.GroupBox1.Controls.Add(Me.lblResultR1)
        Me.GroupBox1.Controls.Add(Me.btnCheckR1)
        Me.GroupBox1.Controls.Add(Me.txtCameraIpR2)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.txtCameraIpR1)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Location = New System.Drawing.Point(11, 9)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(492, 91)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Sea Side"
        '
        'lblResultR2
        '
        Me.lblResultR2.AutoSize = True
        Me.lblResultR2.Location = New System.Drawing.Point(356, 57)
        Me.lblResultR2.Name = "lblResultR2"
        Me.lblResultR2.Size = New System.Drawing.Size(37, 13)
        Me.lblResultR2.TabIndex = 7
        Me.lblResultR2.Text = "Result"
        '
        'btnCheckR2
        '
        Me.btnCheckR2.Location = New System.Drawing.Point(290, 53)
        Me.btnCheckR2.Name = "btnCheckR2"
        Me.btnCheckR2.Size = New System.Drawing.Size(60, 20)
        Me.btnCheckR2.TabIndex = 6
        Me.btnCheckR2.Text = "Check"
        Me.btnCheckR2.UseVisualStyleBackColor = True
        '
        'lblResultR1
        '
        Me.lblResultR1.AutoSize = True
        Me.lblResultR1.Location = New System.Drawing.Point(356, 30)
        Me.lblResultR1.Name = "lblResultR1"
        Me.lblResultR1.Size = New System.Drawing.Size(37, 13)
        Me.lblResultR1.TabIndex = 5
        Me.lblResultR1.Text = "Result"
        '
        'btnCheckR1
        '
        Me.btnCheckR1.Location = New System.Drawing.Point(290, 26)
        Me.btnCheckR1.Name = "btnCheckR1"
        Me.btnCheckR1.Size = New System.Drawing.Size(60, 20)
        Me.btnCheckR1.TabIndex = 4
        Me.btnCheckR1.Text = "Check"
        Me.btnCheckR1.UseVisualStyleBackColor = True
        '
        'txtCameraIpR2
        '
        Me.txtCameraIpR2.Location = New System.Drawing.Point(165, 53)
        Me.txtCameraIpR2.Name = "txtCameraIpR2"
        Me.txtCameraIpR2.Size = New System.Drawing.Size(119, 20)
        Me.txtCameraIpR2.TabIndex = 3
        Me.txtCameraIpR2.Text = "192.168.0.20"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(107, 56)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(52, 13)
        Me.Label2.TabIndex = 2
        Me.Label2.Text = "Camera 2"
        '
        'txtCameraIpR1
        '
        Me.txtCameraIpR1.Location = New System.Drawing.Point(165, 27)
        Me.txtCameraIpR1.Name = "txtCameraIpR1"
        Me.txtCameraIpR1.Size = New System.Drawing.Size(119, 20)
        Me.txtCameraIpR1.TabIndex = 1
        Me.txtCameraIpR1.Text = "192.168.0.10"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(107, 30)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(52, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Camera 1"
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.lblLandRight)
        Me.GroupBox2.Controls.Add(Me.lblLandLeft)
        Me.GroupBox2.Controls.Add(Me.lblResultL2)
        Me.GroupBox2.Controls.Add(Me.btnCheckL2)
        Me.GroupBox2.Controls.Add(Me.lblResultL1)
        Me.GroupBox2.Controls.Add(Me.btnCheckL1)
        Me.GroupBox2.Controls.Add(Me.txtCameraIpL2)
        Me.GroupBox2.Controls.Add(Me.Label3)
        Me.GroupBox2.Controls.Add(Me.txtCameraIpL1)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Location = New System.Drawing.Point(11, 106)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Size = New System.Drawing.Size(492, 91)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "Land Side"
        '
        'lblResultL2
        '
        Me.lblResultL2.AutoSize = True
        Me.lblResultL2.Location = New System.Drawing.Point(353, 56)
        Me.lblResultL2.Name = "lblResultL2"
        Me.lblResultL2.Size = New System.Drawing.Size(37, 13)
        Me.lblResultL2.TabIndex = 11
        Me.lblResultL2.Text = "Result"
        '
        'btnCheckL2
        '
        Me.btnCheckL2.Location = New System.Drawing.Point(287, 52)
        Me.btnCheckL2.Name = "btnCheckL2"
        Me.btnCheckL2.Size = New System.Drawing.Size(60, 20)
        Me.btnCheckL2.TabIndex = 10
        Me.btnCheckL2.Text = "Check"
        Me.btnCheckL2.UseVisualStyleBackColor = True
        '
        'lblResultL1
        '
        Me.lblResultL1.AutoSize = True
        Me.lblResultL1.Location = New System.Drawing.Point(353, 31)
        Me.lblResultL1.Name = "lblResultL1"
        Me.lblResultL1.Size = New System.Drawing.Size(37, 13)
        Me.lblResultL1.TabIndex = 9
        Me.lblResultL1.Text = "Result"
        '
        'btnCheckL1
        '
        Me.btnCheckL1.Location = New System.Drawing.Point(287, 27)
        Me.btnCheckL1.Name = "btnCheckL1"
        Me.btnCheckL1.Size = New System.Drawing.Size(60, 20)
        Me.btnCheckL1.TabIndex = 8
        Me.btnCheckL1.Text = "Check"
        Me.btnCheckL1.UseVisualStyleBackColor = True
        '
        'txtCameraIpL2
        '
        Me.txtCameraIpL2.Location = New System.Drawing.Point(162, 53)
        Me.txtCameraIpL2.Name = "txtCameraIpL2"
        Me.txtCameraIpL2.Size = New System.Drawing.Size(119, 20)
        Me.txtCameraIpL2.TabIndex = 3
        Me.txtCameraIpL2.Text = "192.168.0.40"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(104, 56)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(52, 13)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "Camera 2"
        '
        'txtCameraIpL1
        '
        Me.txtCameraIpL1.Location = New System.Drawing.Point(162, 27)
        Me.txtCameraIpL1.Name = "txtCameraIpL1"
        Me.txtCameraIpL1.Size = New System.Drawing.Size(119, 20)
        Me.txtCameraIpL1.TabIndex = 1
        Me.txtCameraIpL1.Text = "192.168.0.30"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(104, 30)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(52, 13)
        Me.Label4.TabIndex = 0
        Me.Label4.Text = "Camera 1"
        '
        'btnSave
        '
        Me.btnSave.Location = New System.Drawing.Point(131, 203)
        Me.btnSave.Name = "btnSave"
        Me.btnSave.Size = New System.Drawing.Size(119, 34)
        Me.btnSave.TabIndex = 2
        Me.btnSave.Text = "Save and Apply"
        Me.btnSave.UseVisualStyleBackColor = True
        '
        'btnCancel
        '
        Me.btnCancel.Location = New System.Drawing.Point(256, 203)
        Me.btnCancel.Name = "btnCancel"
        Me.btnCancel.Size = New System.Drawing.Size(119, 34)
        Me.btnCancel.TabIndex = 3
        Me.btnCancel.Text = "Cancel"
        Me.btnCancel.UseVisualStyleBackColor = True
        '
        'lblSeaLeft
        '
        Me.lblSeaLeft.AutoSize = True
        Me.lblSeaLeft.ForeColor = System.Drawing.Color.Blue
        Me.lblSeaLeft.Location = New System.Drawing.Point(6, 30)
        Me.lblSeaLeft.Name = "lblSeaLeft"
        Me.lblSeaLeft.Size = New System.Drawing.Size(50, 13)
        Me.lblSeaLeft.TabIndex = 8
        Me.lblSeaLeft.Text = "Hikvision"
        '
        'lblSeaRight
        '
        Me.lblSeaRight.AutoSize = True
        Me.lblSeaRight.ForeColor = System.Drawing.Color.Blue
        Me.lblSeaRight.Location = New System.Drawing.Point(6, 56)
        Me.lblSeaRight.Name = "lblSeaRight"
        Me.lblSeaRight.Size = New System.Drawing.Size(50, 13)
        Me.lblSeaRight.TabIndex = 9
        Me.lblSeaRight.Text = "Hikvision"
        '
        'lblLandLeft
        '
        Me.lblLandLeft.AutoSize = True
        Me.lblLandLeft.ForeColor = System.Drawing.Color.Blue
        Me.lblLandLeft.Location = New System.Drawing.Point(6, 30)
        Me.lblLandLeft.Name = "lblLandLeft"
        Me.lblLandLeft.Size = New System.Drawing.Size(50, 13)
        Me.lblLandLeft.TabIndex = 12
        Me.lblLandLeft.Text = "Hikvision"
        '
        'lblLandRight
        '
        Me.lblLandRight.AutoSize = True
        Me.lblLandRight.ForeColor = System.Drawing.Color.Blue
        Me.lblLandRight.Location = New System.Drawing.Point(6, 56)
        Me.lblLandRight.Name = "lblLandRight"
        Me.lblLandRight.Size = New System.Drawing.Size(50, 13)
        Me.lblLandRight.TabIndex = 13
        Me.lblLandRight.Text = "Hikvision"
        '
        'frmSetting
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(512, 249)
        Me.Controls.Add(Me.btnCancel)
        Me.Controls.Add(Me.btnSave)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmSetting"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent
        Me.Text = "Camera Setting"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents GroupBox1 As GroupBox
    Friend WithEvents txtCameraIpR2 As TextBox
    Friend WithEvents Label2 As Label
    Friend WithEvents txtCameraIpR1 As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents GroupBox2 As GroupBox
    Friend WithEvents txtCameraIpL2 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents txtCameraIpL1 As TextBox
    Friend WithEvents Label4 As Label
    Friend WithEvents btnSave As Button
    Friend WithEvents btnCancel As Button
    Friend WithEvents lblResultR1 As Label
    Friend WithEvents btnCheckR1 As Button
    Friend WithEvents lblResultR2 As Label
    Friend WithEvents btnCheckR2 As Button
    Friend WithEvents lblResultL2 As Label
    Friend WithEvents btnCheckL2 As Button
    Friend WithEvents lblResultL1 As Label
    Friend WithEvents btnCheckL1 As Button
    Friend WithEvents lblSeaRight As Label
    Friend WithEvents lblSeaLeft As Label
    Friend WithEvents lblLandRight As Label
    Friend WithEvents lblLandLeft As Label
End Class
