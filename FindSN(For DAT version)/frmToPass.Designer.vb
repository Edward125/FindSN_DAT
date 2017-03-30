<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmTopass
    Inherits System.Windows.Forms.Form

    'Form 重写 Dispose，以清理组件列表。
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

    'Windows 窗体设计器所必需的
    Private components As System.ComponentModel.IContainer

    '注意: 以下过程是 Windows 窗体设计器所必需的
    '可以使用 Windows 窗体设计器修改它。
    '不要使用代码编辑器修改它。
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmTopass))
        Me.lblUploadPass = New System.Windows.Forms.Label()
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.lblg_user = New System.Windows.Forms.Label()
        Me.txtDat = New System.Windows.Forms.TextBox()
        Me.btnExit = New System.Windows.Forms.Button()
        Me.BtnUpload = New System.Windows.Forms.Button()
        Me.txtOpid = New System.Windows.Forms.TextBox()
        Me.txtFixtureID = New System.Windows.Forms.TextBox()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtSn = New System.Windows.Forms.TextBox()
        Me.lblSn = New System.Windows.Forms.Label()
        Me.GroupBox1.SuspendLayout()
        Me.SuspendLayout()
        '
        'lblUploadPass
        '
        Me.lblUploadPass.AutoSize = True
        Me.lblUploadPass.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUploadPass.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.lblUploadPass.Location = New System.Drawing.Point(82, 110)
        Me.lblUploadPass.Name = "lblUploadPass"
        Me.lblUploadPass.Size = New System.Drawing.Size(54, 16)
        Me.lblUploadPass.TabIndex = 3
        Me.lblUploadPass.Text = "Waiting"
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.lblg_user)
        Me.GroupBox1.Controls.Add(Me.txtDat)
        Me.GroupBox1.Controls.Add(Me.btnExit)
        Me.GroupBox1.Controls.Add(Me.BtnUpload)
        Me.GroupBox1.Controls.Add(Me.lblUploadPass)
        Me.GroupBox1.Controls.Add(Me.txtOpid)
        Me.GroupBox1.Controls.Add(Me.txtFixtureID)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtSn)
        Me.GroupBox1.Controls.Add(Me.lblSn)
        Me.GroupBox1.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GroupBox1.Location = New System.Drawing.Point(12, 12)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Size = New System.Drawing.Size(496, 177)
        Me.GroupBox1.TabIndex = 3
        Me.GroupBox1.TabStop = False
        '
        'lblg_user
        '
        Me.lblg_user.AutoSize = True
        Me.lblg_user.Location = New System.Drawing.Point(380, 111)
        Me.lblg_user.Name = "lblg_user"
        Me.lblg_user.Size = New System.Drawing.Size(16, 16)
        Me.lblg_user.TabIndex = 7
        Me.lblg_user.Text = "  "
        '
        'txtDat
        '
        Me.txtDat.Font = New System.Drawing.Font("Arial Narrow", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtDat.ForeColor = System.Drawing.Color.Blue
        Me.txtDat.Location = New System.Drawing.Point(6, 138)
        Me.txtDat.Name = "txtDat"
        Me.txtDat.Size = New System.Drawing.Size(476, 24)
        Me.txtDat.TabIndex = 6
        Me.txtDat.Text = "PASS          11326-12         20130807043857   554WQ0100GG3310030CWDAB 1203ABJ0"
        Me.txtDat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'btnExit
        '
        Me.btnExit.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnExit.Location = New System.Drawing.Point(397, 67)
        Me.btnExit.Name = "btnExit"
        Me.btnExit.Size = New System.Drawing.Size(85, 34)
        Me.btnExit.TabIndex = 5
        Me.btnExit.Text = "Exit"
        Me.btnExit.UseVisualStyleBackColor = True
        '
        'BtnUpload
        '
        Me.BtnUpload.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnUpload.Location = New System.Drawing.Point(397, 23)
        Me.BtnUpload.Name = "BtnUpload"
        Me.BtnUpload.Size = New System.Drawing.Size(85, 34)
        Me.BtnUpload.TabIndex = 4
        Me.BtnUpload.Text = "Upload"
        Me.BtnUpload.UseVisualStyleBackColor = True
        '
        'txtOpid
        '
        Me.txtOpid.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtOpid.Location = New System.Drawing.Point(85, 73)
        Me.txtOpid.MaxLength = 8
        Me.txtOpid.Name = "txtOpid"
        Me.txtOpid.Size = New System.Drawing.Size(105, 24)
        Me.txtOpid.TabIndex = 1
        Me.txtOpid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'txtFixtureID
        '
        Me.txtFixtureID.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtFixtureID.Location = New System.Drawing.Point(270, 73)
        Me.txtFixtureID.Name = "txtFixtureID"
        Me.txtFixtureID.Size = New System.Drawing.Size(121, 24)
        Me.txtFixtureID.TabIndex = 2
        Me.txtFixtureID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(196, 76)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(68, 16)
        Me.Label2.TabIndex = 5
        Me.Label2.Text = "FixtureID:"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.Location = New System.Drawing.Point(10, 76)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(69, 16)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "Operator:"
        '
        'txtSn
        '
        Me.txtSn.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtSn.Location = New System.Drawing.Point(67, 23)
        Me.txtSn.MaxLength = 25
        Me.txtSn.Name = "txtSn"
        Me.txtSn.Size = New System.Drawing.Size(324, 24)
        Me.txtSn.TabIndex = 2
        '
        'lblSn
        '
        Me.lblSn.AutoSize = True
        Me.lblSn.Font = New System.Drawing.Font("Arial", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblSn.Location = New System.Drawing.Point(5, 25)
        Me.lblSn.Name = "lblSn"
        Me.lblSn.Size = New System.Drawing.Size(46, 16)
        Me.lblSn.TabIndex = 3
        Me.lblSn.Text = "  S N :"
        '
        'frmTopass
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 12.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(527, 201)
        Me.Controls.Add(Me.GroupBox1)
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Name = "frmTopass"
        Me.Text = "FindSN ToPass"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents lblUploadPass As System.Windows.Forms.Label
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents txtOpid As System.Windows.Forms.TextBox
    Friend WithEvents txtFixtureID As System.Windows.Forms.TextBox
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtSn As System.Windows.Forms.TextBox
    Friend WithEvents lblSn As System.Windows.Forms.Label
    Friend WithEvents BtnUpload As System.Windows.Forms.Button
    Friend WithEvents btnExit As System.Windows.Forms.Button
    Friend WithEvents txtDat As System.Windows.Forms.TextBox
    Friend WithEvents lblg_user As System.Windows.Forms.Label
End Class
