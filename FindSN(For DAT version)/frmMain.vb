Public Class frmMain

    Private Sub frmMain_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        LoadStart()
    End Sub

    Private Sub LoadStart()
        Me.Height = 225
        Me.txtSn.Text = ""
        Me.btnUpload.Enabled = False
        Me.btnNext.Enabled = False
        txtDat.Text = "Input SN" : txtDat.ForeColor = Color.Blue
        Me.Text = "FindSN_For_DAT(for DAT version),Ver:" + My.Application.Info.Version.ToString + ",Edward Song"
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        ' If CheckSN() = False Then Return
        '查找DAT是否存在,存在读取内容
        Dim DAT1Exists As Boolean
        Dim DAT2Exists As Boolean
        DAT1Exists = My.Computer.FileSystem.FileExists(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
        Debug.WriteLine(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
        DAT2Exists = My.Computer.FileSystem.FileExists(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
        Debug.WriteLine(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
        If DAT1Exists = False And DAT2Exists = False Then
            txtDat.Text = "The SN doesn't exit(SN不存在),input again pls." : txtDat.ForeColor = Color.Blue
            ' MsgBox("The SN doesn't exit(SN不存在),input again pls.")
        ElseIf DAT1Exists = True Then
            ReadDAT(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
            Me.Height = 225
            Dim EEEExitsts As Boolean = My.Computer.FileSystem.FileExists(My.Settings.BackupPath1 & "\" & txtSn.Text & ".EEE")
            If EEEExitsts = True Then ReadEEE(My.Settings.BackupPath1 & "\" & txtSn.Text & ".EEE") : Me.Height = 660
            Return
        ElseIf DAT1Exists = False And DAT2Exists = True Then
            ReadDAT(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
            Me.Height = 225
            Dim EEEExitsts As Boolean = My.Computer.FileSystem.FileExists(My.Settings.BackupPath2 & "\" & txtSn.Text & ".EEE")
            If EEEExitsts = True Then ReadEEE(My.Settings.BackupPath2 & "\" & txtSn.Text & ".EEE") : Me.Height = 660
            Return
        End If
    End Sub


    Private Function CheckSN() As Boolean
        Dim b As Boolean = False
        Me.txtSn.Text = UCase(Trim(Me.txtSn.Text))
        If txtSn.Text.Length <> 23 And txtSn.Text.Length <> 24 And txtSn.Text.Length <> 25 Then
            txtDat.Text = "SN length Error,input again pls" : txtDat.ForeColor = Color.Blue
            ' MsgBox("SN length Error,input again pls")
            b = False
        Else
            If txtSn.Text.StartsWith("554") Then lblSn.Text = "55SN:" : lblSn.ForeColor = Color.Red
            If txtSn.Text.StartsWith("CN") Then lblSn.Text = "PPID:" : lblSn.ForeColor = Color.Red
            If txtSn.Text.StartsWith("455") Then lblSn.Text = "45SN:" : lblSn.ForeColor = Color.Red
            b = True
        End If
        txtSn.Focus()
        txtSn.SelectAll()
        Return b
    End Function

    Private Sub ReadDAT(ByVal DATpath As String)
        txtDat.Text = ""
        Dim lineString As String = ""
        Dim allString As String = ""
        Dim iLine As String = 0
        Dim DATcontents As String = My.Computer.FileSystem.ReadAllText(DATpath)
        txtDat.Text = DATcontents
        Dim s() As String = DATcontents.Split(" ")
        If s(0) = "PASS" Then txtDat.ForeColor = Color.Green
        If s(0) = "FAIL" Then txtDat.ForeColor = Color.Red
    End Sub

    Private Sub ReadEEE(ByVal EEEpath As String)
        txtEEEcontents.Text = ""
        txtEEEcontents.Text = ""
        Dim EEEContents As String
        EEEContents = My.Computer.FileSystem.ReadAllText(EEEpath)
        txtEEEcontents.Text = EEEContents
    End Sub


    Private Sub UploadAll()
        Dim DAT1Exists As Boolean
        Dim DAT2Exists As Boolean
        DAT1Exists = My.Computer.FileSystem.FileExists(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
        Debug.WriteLine(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
        DAT2Exists = My.Computer.FileSystem.FileExists(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
        Debug.WriteLine(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
        If DAT1Exists = True Then
            Try
                My.Computer.FileSystem.CopyFile(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT", My.Settings.UploadPath & "\" & txtSn.Text & ".DAT")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Dim EEEExitsts As Boolean = My.Computer.FileSystem.FileExists(My.Settings.BackupPath1 & "\" & txtSn.Text & ".EEE")
            Try
                If EEEExitsts = True Then My.Computer.FileSystem.CopyFile(My.Settings.BackupPath1 & "\" & txtSn.Text & ".EEE", My.Settings.UploadPath & "\" & txtSn.Text & ".EEE")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return
        ElseIf DAT1Exists = False And DAT2Exists = True Then
            Try
                My.Computer.FileSystem.CopyFile(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT", My.Settings.UploadPath & "\" & txtSn.Text & ".DAT")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Dim EEEExitsts As Boolean = My.Computer.FileSystem.FileExists(My.Settings.BackupPath2 & "\" & txtSn.Text & ".EEE")
            Try
                If EEEExitsts = True Then My.Computer.FileSystem.CopyFile(My.Settings.BackupPath2 & "\" & txtSn.Text & ".EEE", My.Settings.UploadPath & "\" & txtSn.Text & ".EEE")
            Catch ex As Exception
                MessageBox.Show(ex.Message)
            End Try
            Return
        End If
    End Sub

    Private Sub btnSetting_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnSetting.Click
        frmSetting.ShowDialog()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Close()
        End
    End Sub

    Private Sub btnNext_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnNext.Click
        txtSn.Text = ""
        Me.Height = 225
        Me.btnNext.Enabled = False
        Me.btnUpload.Enabled = False
        txtDat.Text = "Input SN." : txtDat.ForeColor = Color.Blue
    End Sub

    Private Sub txtSn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSn.KeyPress
        If e.KeyChar = Chr(13) Then
            ' If CheckSN() = False Then Return
            '查找DAT是否存在,存在读取内容
            Dim DAT1Exists As Boolean
            Dim DAT2Exists As Boolean
            DAT1Exists = My.Computer.FileSystem.FileExists(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
            Debug.WriteLine(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
            DAT2Exists = My.Computer.FileSystem.FileExists(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
            Debug.WriteLine(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
            If DAT1Exists = False And DAT2Exists = False Then
                txtDat.Text = "The SN doesn't exit(SN不存在),input again pls." : txtDat.ForeColor = Color.Blue
                ' MsgBox("The SN doesn't exit(SN不存在),input again pls.")
            ElseIf DAT1Exists = True Then
                ReadDAT(My.Settings.BackupPath1 & "\" & txtSn.Text & ".DAT")
                Me.Height = 225
                Dim EEEExitsts As Boolean = My.Computer.FileSystem.FileExists(My.Settings.BackupPath1 & "\" & txtSn.Text & ".EEE")
                If EEEExitsts = True Then ReadEEE(My.Settings.BackupPath1 & "\" & txtSn.Text & ".EEE") : Me.Height = 660
                Return
            ElseIf DAT1Exists = False And DAT2Exists = True Then
                ReadDAT(My.Settings.BackupPath2 & "\" & txtSn.Text & ".DAT")
                Me.Height = 225
                Dim EEEExitsts As Boolean = My.Computer.FileSystem.FileExists(My.Settings.BackupPath2 & "\" & txtSn.Text & ".EEE")
                If EEEExitsts = True Then ReadEEE(My.Settings.BackupPath2 & "\" & txtSn.Text & ".EEE") : Me.Height = 660
                Return
            End If
        End If
    End Sub

    Private Sub txtSn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSn.TextChanged
        'If Me.txtSn.Text.Length = 23 Or Me.txtSn.Text.Length = 24 Or Me.txtSn.Text.Length = 25 Then
        '    Me.btnUpload.Enabled = True
        'Else
        '    Me.btnUpload.Enabled = False
        'End If
        If Me.txtSn.Text.Length <> 0 Then
            Me.btnNext.Enabled = True
            Me.btnUpload.Enabled = True
        Else
            Me.btnNext.Enabled = False
            Me.btnUpload.Enabled = False
        End If


    End Sub


    Private Sub btnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnUpload.Click
        txtSn.SelectAll()
        UploadAll()
        ' txtSn.SelectAll()
        Me.Height = 225
    End Sub

End Class
