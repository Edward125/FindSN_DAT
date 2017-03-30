Public Class frmSetting

    Private Sub frmSetting_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        txtBackuppath1.Text = My.Settings.BackupPath1
        txtBackuppath2.Text = My.Settings.BackupPath2
        txtUploadpath.Text = My.Settings.UploadPath
    End Sub

    Private Sub btnOk_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnOk.Click
        My.Settings.BackupPath1 = Trim(txtBackuppath1.Text)
        My.Settings.BackupPath2 = Trim(txtBackuppath2.Text)
        My.Settings.UploadPath = Trim(txtUploadpath.Text)
        My.Settings.Save()
        MsgBox("All path save OK")
        Me.Hide()
    End Sub


    Private Sub OpenFolder(ByVal txt As TextBox)
        Dim OpenF As New FolderBrowserDialog
        OpenF.RootFolder = Environment.SpecialFolder.MyComputer
        OpenF.ShowNewFolderButton = True
        If OpenF.ShowDialog = Windows.Forms.DialogResult.OK Then
            txt.Text = OpenF.SelectedPath
        End If
    End Sub

    Private Sub txtBackuppath1_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBackuppath1.DoubleClick
        OpenFolder(txtBackuppath1)
        My.Settings.BackupPath1 = txtBackuppath1.Text
        My.Settings.Save()
    End Sub


    Private Sub txtBackuppath2_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtBackuppath2.DoubleClick
        OpenFolder(txtBackuppath2)
        My.Settings.BackupPath2 = txtBackuppath2.Text
        My.Settings.Save()
    End Sub

    Private Sub txtUploadpath_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles txtUploadpath.DoubleClick
        OpenFolder(txtUploadpath)
        My.Settings.UploadPath = txtUploadpath.Text
        My.Settings.Save()
    End Sub


    Private Sub btnTopass_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnTopass.Click
        Me.Hide()
        '   frmLog.ShowDialog()
        frmLog.ShowDialog()
    End Sub
End Class


