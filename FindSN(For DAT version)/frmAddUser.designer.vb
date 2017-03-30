<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmAddUser
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmAddUser))
        Me.GroupBox1 = New System.Windows.Forms.GroupBox()
        Me.BtnSaveUser = New System.Windows.Forms.Button()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.txtPsd2 = New System.Windows.Forms.TextBox()
        Me.txtPsd1 = New System.Windows.Forms.TextBox()
        Me.txtNewId = New System.Windows.Forms.TextBox()
        Me.GroupBox2 = New System.Windows.Forms.GroupBox()
        Me.combUserId = New System.Windows.Forms.ComboBox()
        Me.btnChangePsd = New System.Windows.Forms.Button()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.txtNewPsd = New System.Windows.Forms.TextBox()
        Me.txtOldPsd = New System.Windows.Forms.TextBox()
        Me.GroupBox1.SuspendLayout()
        Me.GroupBox2.SuspendLayout()
        Me.SuspendLayout()
        '
        'GroupBox1
        '
        Me.GroupBox1.Controls.Add(Me.BtnSaveUser)
        Me.GroupBox1.Controls.Add(Me.Label3)
        Me.GroupBox1.Controls.Add(Me.Label2)
        Me.GroupBox1.Controls.Add(Me.Label1)
        Me.GroupBox1.Controls.Add(Me.txtPsd2)
        Me.GroupBox1.Controls.Add(Me.txtPsd1)
        Me.GroupBox1.Controls.Add(Me.txtNewId)
        Me.GroupBox1.Location = New System.Drawing.Point(12, 13)
        Me.GroupBox1.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Name = "GroupBox1"
        Me.GroupBox1.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox1.Size = New System.Drawing.Size(245, 196)
        Me.GroupBox1.TabIndex = 0
        Me.GroupBox1.TabStop = False
        Me.GroupBox1.Text = "Add User"
        '
        'BtnSaveUser
        '
        Me.BtnSaveUser.Location = New System.Drawing.Point(74, 146)
        Me.BtnSaveUser.Name = "BtnSaveUser"
        Me.BtnSaveUser.Size = New System.Drawing.Size(107, 29)
        Me.BtnSaveUser.TabIndex = 2
        Me.BtnSaveUser.Text = "SaveUserInfo"
        Me.BtnSaveUser.UseVisualStyleBackColor = True
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(6, 117)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(58, 17)
        Me.Label3.TabIndex = 4
        Me.Label3.Text = "Password"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(6, 70)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(58, 17)
        Me.Label2.TabIndex = 3
        Me.Label2.Text = "Password"
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(6, 31)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(46, 17)
        Me.Label1.TabIndex = 2
        Me.Label1.Text = "User ID"
        '
        'txtPsd2
        '
        Me.txtPsd2.Location = New System.Drawing.Point(74, 110)
        Me.txtPsd2.Name = "txtPsd2"
        Me.txtPsd2.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsd2.Size = New System.Drawing.Size(143, 24)
        Me.txtPsd2.TabIndex = 2
        '
        'txtPsd1
        '
        Me.txtPsd1.Location = New System.Drawing.Point(74, 70)
        Me.txtPsd1.Name = "txtPsd1"
        Me.txtPsd1.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtPsd1.Size = New System.Drawing.Size(143, 24)
        Me.txtPsd1.TabIndex = 1
        '
        'txtNewId
        '
        Me.txtNewId.Location = New System.Drawing.Point(74, 24)
        Me.txtNewId.Name = "txtNewId"
        Me.txtNewId.Size = New System.Drawing.Size(143, 24)
        Me.txtNewId.TabIndex = 0
        '
        'GroupBox2
        '
        Me.GroupBox2.Controls.Add(Me.combUserId)
        Me.GroupBox2.Controls.Add(Me.btnChangePsd)
        Me.GroupBox2.Controls.Add(Me.Label6)
        Me.GroupBox2.Controls.Add(Me.Label5)
        Me.GroupBox2.Controls.Add(Me.Label4)
        Me.GroupBox2.Controls.Add(Me.txtNewPsd)
        Me.GroupBox2.Controls.Add(Me.txtOldPsd)
        Me.GroupBox2.Location = New System.Drawing.Point(279, 13)
        Me.GroupBox2.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Name = "GroupBox2"
        Me.GroupBox2.Padding = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.GroupBox2.Size = New System.Drawing.Size(263, 196)
        Me.GroupBox2.TabIndex = 1
        Me.GroupBox2.TabStop = False
        Me.GroupBox2.Text = "ChangePassword"
        '
        'combUserId
        '
        Me.combUserId.FormattingEnabled = True
        Me.combUserId.Location = New System.Drawing.Point(104, 23)
        Me.combUserId.Name = "combUserId"
        Me.combUserId.Size = New System.Drawing.Size(143, 25)
        Me.combUserId.TabIndex = 9
        '
        'btnChangePsd
        '
        Me.btnChangePsd.Location = New System.Drawing.Point(81, 145)
        Me.btnChangePsd.Name = "btnChangePsd"
        Me.btnChangePsd.Size = New System.Drawing.Size(144, 30)
        Me.btnChangePsd.TabIndex = 6
        Me.btnChangePsd.Text = "ChangePassword"
        Me.btnChangePsd.UseVisualStyleBackColor = True
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Location = New System.Drawing.Point(6, 117)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(80, 17)
        Me.Label6.TabIndex = 7
        Me.Label6.Text = "NewPassword"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.Location = New System.Drawing.Point(6, 73)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(75, 17)
        Me.Label5.TabIndex = 6
        Me.Label5.Text = "OldPassword"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.Location = New System.Drawing.Point(6, 27)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(46, 17)
        Me.Label4.TabIndex = 5
        Me.Label4.Text = "User ID"
        '
        'txtNewPsd
        '
        Me.txtNewPsd.Location = New System.Drawing.Point(104, 110)
        Me.txtNewPsd.Name = "txtNewPsd"
        Me.txtNewPsd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtNewPsd.Size = New System.Drawing.Size(143, 24)
        Me.txtNewPsd.TabIndex = 2
        '
        'txtOldPsd
        '
        Me.txtOldPsd.Location = New System.Drawing.Point(104, 70)
        Me.txtOldPsd.Name = "txtOldPsd"
        Me.txtOldPsd.PasswordChar = Global.Microsoft.VisualBasic.ChrW(42)
        Me.txtOldPsd.Size = New System.Drawing.Size(143, 24)
        Me.txtOldPsd.TabIndex = 1
        '
        'frmAddUser
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(7.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(567, 242)
        Me.Controls.Add(Me.GroupBox2)
        Me.Controls.Add(Me.GroupBox1)
        Me.Font = New System.Drawing.Font("Arial Narrow", 10.5!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.Margin = New System.Windows.Forms.Padding(3, 4, 3, 4)
        Me.Name = "frmAddUser"
        Me.Text = "FindSn_AddUser"
        Me.GroupBox1.ResumeLayout(False)
        Me.GroupBox1.PerformLayout()
        Me.GroupBox2.ResumeLayout(False)
        Me.GroupBox2.PerformLayout()
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents GroupBox1 As System.Windows.Forms.GroupBox
    Friend WithEvents BtnSaveUser As System.Windows.Forms.Button
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents txtPsd2 As System.Windows.Forms.TextBox
    Friend WithEvents txtPsd1 As System.Windows.Forms.TextBox
    Friend WithEvents txtNewId As System.Windows.Forms.TextBox
    Friend WithEvents GroupBox2 As System.Windows.Forms.GroupBox
    Friend WithEvents btnChangePsd As System.Windows.Forms.Button
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Label5 As System.Windows.Forms.Label
    Friend WithEvents Label4 As System.Windows.Forms.Label
    Friend WithEvents txtNewPsd As System.Windows.Forms.TextBox
    Friend WithEvents txtOldPsd As System.Windows.Forms.TextBox
    Friend WithEvents combUserId As System.Windows.Forms.ComboBox
End Class
