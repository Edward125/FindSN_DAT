Imports System.IO

Public Class frmTopass

    Private Sub TextBox1_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtOpid.TextChanged

    End Sub

    Private Sub frmTopass_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        Dim fileContents As String
        fileContents = My.Computer.FileSystem.ReadAllText(My.Settings.BackupPath1 & "\test.dat")
        txtDat.Text = fileContents
        txtDat.Text.Replace("20130807043857", getNowLong)
        '  MsgBox(fileContents.Length)
        '  txtDat.Text.Replace("PASS", "FAIL")
        'PASS          11326-12         20130807043857   554WQ0100GG3310030CWDAB 1203ABJ0
    End Sub

    Private Sub frmTopass_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load
        CreatFolder()
    End Sub

    Private Sub btnExit_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnExit.Click
        Me.Hide()
        frmMain.Show()
    End Sub


    Private Sub CreatFolder()
        Dim folderExists As Boolean
        folderExists = My.Computer.FileSystem.DirectoryExists("C:\FindSN")
        If folderExists = False Then
            My.Computer.FileSystem.CreateDirectory("C:\FindSN")
            Dim fileData As FileInfo = My.Computer.FileSystem.GetFileInfo("C:\FindSN")
            fileData.Attributes = FileAttributes.Hidden
            Dim fileExists As Boolean
            fileExists = My.Computer.FileSystem.FileExists("C:\FindSN\ToPass.log")
            If fileExists = False Then
                My.Computer.FileSystem.WriteAllText("C:\FindSN\ToPass.log", String.Empty, True)
            End If
        End If
    End Sub

    Private Sub UploadDAT()
        Dim DATcontents As String = "PASS" & Space(10)


        Dim FixtureID As String = UCase(Trim(txtFixtureID.Text))
        Dim TestTime As String = getNowLong()
        Dim Opid As String = UCase(txtOpid.Text)
        Dim USN As String = UCase(Trim(txtSn.Text))
        DATcontents = DATcontents & FixtureID : CheckLeng(DATcontents, 31)
        DATcontents = DATcontents & TestTime : CheckLeng(DATcontents, 48)
        DATcontents = DATcontents & USN : CheckLeng(DATcontents, 72)
        DATcontents = DATcontents & Opid 
                  

        txtDat.Text =DATcontents 

        'output @MES;"PASS";tab(15);Fixture_ID$;tab(32);"20"&datetime$;tab(49);Panel_Serial$;tab(73);Oper$



        Try
            My.Computer.FileSystem.WriteAllText(My.Settings.UploadPath & "\" & txtSn.Text & ".DAT", DATcontents, False)
            lblUploadPass.Text = "Upload OK"
            lblUploadPass.ForeColor = Color.Green
            txtSn.Focus()
            txtSn.SelectAll()
        Catch ex As Exception
            MessageBox.Show(ex.Message)
        End Try
    End Sub

    Private Function getNowLong() As String
        Dim s As String = ""
        Dim year As String = Now.Year
        Dim month As String = Format(Now.Month, "00")
        Dim day As String = Format(Now.Day, "00")
        Dim hour As String = Format(Now.Hour, "00")
        Dim minute As String = Format(Now.Minute, "00")
        Dim second As String = Format(Now.Second, "00")
        s = year & month & day & hour & minute & second
        Return s
    End Function

    Private Sub Record()
        Dim s As String = UCase(Trim(txtSn.Text)) & Space(4) & _
                          UCase(txtOpid.Text) & Space(4) & _
                          UCase(Trim(txtFixtureID.Text)) & Space(4) & _
                          getNowLong() & Space(4) & lblg_user.Text & vbCrLf
        My.Computer.FileSystem.WriteAllText("C:\FindSN\ToPass.log", s, True)
    End Sub

    Private Function CheckOpid(ByVal Opid As String) As Boolean
        Dim b As Boolean = False
        If Opid.Length <> 8 Then
            lblUploadPass.Visible = True
            lblUploadPass.Text = "Operator ID length is less than 8"
            lblUploadPass.ForeColor = Color.Red
            b = False
        Else
            b = True
            '  txtDat.Text.Replace("1203ABJ0", Opid)
        End If
        Return b
    End Function


    Private Function CheckSn(ByVal SN As String) As Boolean
        Dim b As Boolean = False
        SN = UCase(SN)
        If SN.Length <> 23 And SN.Length <> 24 And SN.Length <> 25 Then

            lblUploadPass.Text = "SN length is error"
            lblUploadPass.ForeColor = Color.Red

            b = False
        Else
            b = True
            ' txtDat.Text.Replace("554WQ0100GG3310030CWDAB", SN)
        End If
        Return b
    End Function

    Private Function CheckFixtureId(ByVal fixtureid As String) As Boolean
        Dim b As Boolean = False
        If fixtureid.Length <> 0 Then
            b = True
            ' txtDat.Text.Replace("11326-12", UCase(Trim(txtFixtureID.Text)))
        Else
            lblUploadPass.Text = "FixtureId Can't be empty!"
            lblUploadPass.ForeColor = Color.Red
            b = False
        End If
        Return b
    End Function

    Private Sub BtnUpload_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnUpload.Click
        txtSn.Text = UCase(Trim(txtSn.Text))
        If CheckSn(txtSn.Text) = False Then Return
        If CheckOpid(txtOpid.Text) = False Then Return
        If CheckFixtureId(txtFixtureID.Text) = False Then Return
        UploadDAT()
        Record()
    End Sub

    Private Sub txtSn_KeyPress(ByVal sender As Object, ByVal e As System.Windows.Forms.KeyPressEventArgs) Handles txtSn.KeyPress
        If e.KeyChar = Chr(13) Then
            txtSn.Text = UCase(Trim(txtSn.Text))
            If CheckSn(txtSn.Text) = False Then Return
            If CheckOpid(txtOpid.Text) = False Then Return
            If CheckFixtureId(txtFixtureID.Text) = False Then Return
            UploadDAT()
            Record()
            '  txtDat.Text = "PASS          11326-12         20130807043857   554WQ0100GG3310030CWDAB 1203ABJ0"
        End If
    End Sub

    Private Sub txtSn_TextChanged(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles txtSn.TextChanged

    End Sub


    Private Sub CheckLeng(ByRef s As String, ByVal i As Short)
        Dim iSpan As Short = i - s.Length
        If iSpan > 0 Then
            s = s & Space(iSpan)
        End If
    End Sub
End Class


