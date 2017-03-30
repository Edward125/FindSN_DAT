Imports System.IO

Public Class frmLog

    Private Sub BtnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnExit.Click
        Me.txtPsd.Text = ""
        Me.Hide()

    End Sub

    Private Sub btnLogin_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnLogin.Click
        Me.Hide()
        txtPsd.Text = ""
        frmTopass.Show()
        frmTopass.lblg_user.Text = combUser.SelectedItem



    End Sub



    Private Function CheckAdminPassword() As Boolean
        Dim b As Boolean = False
        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\Windows\System32\FindSnDatAdmin.dll")
        If fileExists = True Then
            Dim fileContents As String
            fileContents = My.Computer.FileSystem.ReadAllText("C:\Windows\System32\FindSnDatAdmin.dll")
            If Me.txtPsd.Text.Trim() = fileContents Then b = True
        Else

            My.Computer.FileSystem.WriteAllText("C:\Windows\System32\FindSnDatAdmin.dll", "WcqAgilent3070", False)
            Dim info As New FileInfo("C:\Windows\System32\FindSnDatAdmin.dll")
            info.Attributes = FileAttributes.Hidden
            If txtPsd.Text.Trim = "WcqAgilent3070" Then b = True
        End If
        Return b
    End Function


    Private Sub frmLog_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\Windows\System32\FindSnDatUser.dll")
        If fileExists = False Then
            My.Computer.FileSystem.WriteAllText("C:\Windows\System32\FindSnDatUser.dll", String.Empty, False)
            Dim info As New FileInfo("C:\Windows\System32\FindSnDatUser.dll")
            info.Attributes = FileAttributes.Hidden
        End If
        BtnAdd.Enabled = False
        btnLogin.Enabled = False
        combUser.Items.Clear()
        LoadUser()
    End Sub

    Private Sub txtPsd_KeyDown(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyEventArgs) Handles txtPsd.KeyDown
        If e.KeyCode = Keys.Return Then
            If combUser.Text.Trim = "Administrator" Then
                If CheckAdminPassword() = True Then
                    Me.txtPsd.Text = "" : BtnAdd.Enabled = True
                Else
                    MsgBox("Invaild Password,try again") : txtPsd.Text = ""
                End If
            Else
                '==========other id=============================

                If combUser.SelectedIndex = -1 Then Exit Sub

                Dim allStr As String = ""
                Dim lineStr As String = "" '定义每一行的文本
                Dim textStream As StreamReader
                textStream = My.Computer.FileSystem.OpenTextFileReader("C:\Windows\System32\FindSnDatUser.dll")
                Do Until textStream.EndOfStream  '从文件逐行读取
                    lineStr = textStream.ReadLine '将读到的文本赋给linestr
                    If lineStr.Trim <> "" Then
                        Dim s() As String
                        s = lineStr.Trim.Split("|")
                        If combUser.SelectedItem = s(0) Then
                            If txtPsd.Text.Trim = s(1) Then btnLogin.Enabled = True : Exit Do
                        End If
                        allStr = allStr & lineStr & vbCrLf
                    End If
                Loop
                textStream.Close()









            End If
        End If

    End Sub


    Private Sub LoadUser()


        Dim allStr As String = ""
        Dim lineStr As String = "" '定义每一行的文本
        Dim textStream As StreamReader

        Dim fileExists As Boolean
        fileExists = My.Computer.FileSystem.FileExists("C:\Windows\System32\FindSnDatUser.dll")
        If fileExists = False Then Exit Sub
        textStream = My.Computer.FileSystem.OpenTextFileReader("C:\Windows\System32\FindSnDatUser.dll")
        Do Until textStream.EndOfStream  '从文件逐行读取
            lineStr = textStream.ReadLine '将读到的文本赋给linestr
            If lineStr.Trim <> "" Then
                Dim s() As String
                s = lineStr.Trim.Split("|")
                combUser.Items.Add(s(0))
                '   If combUser.SelectedItem = s(0) Then
                ' If txtPsd.Text.Trim = s(1) Then btnLogin.Enabled = True : Exit Do
                'End If
                '  allStr = allStr & lineStr & vbCrLf
            End If
        Loop
        textStream.Close()
    End Sub

    Private Sub BtnAdd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnAdd.Click
        frmAddUser.ShowDialog()
        Me.Hide()

    End Sub

    Private Sub combUser_SelectedIndexChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles combUser.SelectedIndexChanged
        BtnAdd.Enabled = False
        btnLogin.Enabled = False
        txtPsd.Text = ""
    End Sub

    Private Sub txtPsd_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtPsd.TextChanged

    End Sub
End Class