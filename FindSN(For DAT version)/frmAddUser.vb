Imports System.IO
Imports System.Reflection

Public Class frmAddUser

    Private Sub frmAddUser_Click(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.Click
        '  WriteResourceFile("res11.txt")


    End Sub

    Private Sub frmAddUser_DoubleClick(ByVal sender As Object, ByVal e As System.EventArgs) Handles Me.DoubleClick
        '  WriteRes("C:\res.txt", "E:\Edward\FindSn\FindSn\bin\Debug\FindSn 2.2.exe", "custom", 101)
    End Sub

    Private Sub frmAddUser_FormClosing(ByVal sender As Object, ByVal e As System.Windows.Forms.FormClosingEventArgs) Handles Me.FormClosing
        Me.Hide()
        frmLog.Show()
    End Sub

    Private Sub frmAddUser_Load(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles MyBase.Load

        LoadUser()
        'Dim fileExists As Boolean
        'fileExists = My.Computer.FileSystem.FileExists("C:\Windows\System32\FindSnUser.dat")
        'If fileExists = False Then
        '    My.Computer.FileSystem.WriteAllText("C:\Windows\System32\FindSnUser.dat", String.Empty, False)
        '    Dim info As New FileInfo("C:\Windows\System32\FindSnUser.dat")
        '    info.Attributes = FileAttributes.Hidden
        'End If
    End Sub

    Private Sub BtnSaveUser_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles BtnSaveUser.Click



        '============check UserID====================
        If CheckUserID() = False Then Exit Sub
        '============check Password=================
        If txtPsd1.Text.Trim <> txtPsd2.Text.Trim Then MsgBox("The password must be the same") : Exit Sub
        If txtPsd1.Text = "" Or txtPsd2.Text = "" Then MsgBox("The password can be empty") : Exit Sub
        '============write userinfo================

        Dim userinfo As String = ""
        userinfo = txtNewId.Text.Trim & "|" & txtPsd1.Text.Trim
        Dim info As New FileInfo("C:\Windows\System32\FindSnDatUser.dll")
        info.Attributes = FileAttributes.Normal
        My.Computer.FileSystem.WriteAllText("C:\Windows\System32\FindSnDatUser.dll", userinfo & vbCrLf, True)

        info.Attributes = FileAttributes.Hidden
        MsgBox("User ID Add OK")
        txtNewId.Text = "" : txtPsd1.Text = "" : txtPsd2.Text = ""
        combUserId.Items.Clear()
        LoadUser()
    End Sub

    Private Function CheckUserID() As Boolean
        Dim b = True
        Dim lineStr As String = "" '定义每一行的文本
        Dim textStream As StreamReader
        textStream = My.Computer.FileSystem.OpenTextFileReader("C:\Windows\System32\FindSnDatUser.dll")
        Do Until textStream.EndOfStream  '从文件逐行读取
            lineStr = textStream.ReadLine '将读到的文本赋给linestr
            If lineStr <> "" AndAlso lineStr.Trim.Contains("|") = True Then
                Dim s() As String
                s = lineStr.Split("|")
                If txtNewId.Text.Trim = s(0) Then
                    MsgBox("The User ID is already exits")
                    b = False
                    Exit Do
                End If
            End If
        Loop
        textStream.Close()
        Return b
    End Function



    Private Sub btnChangePsd_Click(ByVal sender As System.Object, ByVal e As System.EventArgs) Handles btnChangePsd.Click

        If combUserId.SelectedIndex = -1 Or txtOldPsd.Text.Trim = "" Or txtNewPsd.Text.Trim = "" Then Exit Sub
        '============================================
        Dim allStr As String = ""
        Dim lineStr As String = "" '定义每一行的文本
        Dim textStream As StreamReader
        Dim b As Boolean = False
        textStream = My.Computer.FileSystem.OpenTextFileReader("C:\Windows\System32\FindSnDatUser.dll")
        Do Until textStream.EndOfStream  '从文件逐行读取
            lineStr = textStream.ReadLine '将读到的文本赋给linestr
            If lineStr.Trim <> "" Then
                Dim s() As String
                s = lineStr.Trim.Split("|")
                If combUserId.SelectedItem = s(0) Then
                    If txtOldPsd.Text.Trim <> s(1) Then MsgBox("Old Password is wrong") : Exit Do
                    If txtOldPsd.Text.Trim = s(1) Then lineStr = combUserId.SelectedItem & "|" & txtNewPsd.Text.Trim : b = True
                End If
                allStr = allStr & lineStr & vbCrLf
            End If
        Loop
        textStream.Close()
        If b = True Then
            My.Computer.FileSystem.WriteAllText("C:\Windows\System32\FindSnDatUser.dll", allStr, False)
            MsgBox("Password change OK")
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
                combUserId.Items.Add(s(0))
                '   If combUser.SelectedItem = s(0) Then
                ' If txtPsd.Text.Trim = s(1) Then btnLogin.Enabled = True : Exit Do
                'End If
                '  allStr = allStr & lineStr & vbCrLf
            End If
        Loop
        textStream.Close()
    End Sub







    Declare Function BeginUpdateResource Lib "kernel32" Alias "BeginUpdateResourceA" (ByVal pFileName As String, ByVal bDeleteExistingResources As Integer) As Integer
    Declare Function UpdateResource Lib "kernel32" Alias "UpdateResourceA" (ByVal hUpdate As Integer, ByVal lpType As String, ByVal lpName As String, ByVal wLanguage As Integer, ByRef lpData As Byte, ByVal cbData As Integer) As Integer
    Declare Function EndUpdateResource Lib "kernel32" Alias "EndUpdateResourceA" (ByVal hUpdate As Integer, ByVal fDiscard As Integer) As Integer
    'API
    Function WriteRes(ByVal ResFileName As String, ByVal WriteFileName As String, ByVal ResType As String, ByVal ResID As Integer) As Boolean
        '==============================================================================
        '函数名称:WriteRes
        '参    数:ResFileName:写入WriteFileName的文件路径
        '         WriteFileName:等待被写入的文件路径（主体）
        '         ResType:资源类型,任意String
        '         ResID:资源编号,任意Integer
        '返 回 值:一个Boolean，用来表示是否写入成功。
        '
        '2010年1月26日
        '==============================================================================
        '使用示范：
        'WriteRes("E:\test\res", "E:\test\a.exe", "CUSTOM", 101)
        '将E:\test\res写入E:\test\a.exe,
        '写在CUSTOM下，编号为101

        Dim b As Boolean = False
        Dim VbArrayRes() As Byte
        Dim hUpdate As Integer
        Dim Ret As Integer
        Dim ResTypeX As String
        ResTypeX = StrConv(ResType, VbStrConv.Uppercase)
        hUpdate = BeginUpdateResource(WriteFileName, False)
        ReDim VbArrayRes(FileLen(ResFileName) - 1)
        FileOpen(1, ResFileName, OpenMode.Binary)
        FileGet(1, VbArrayRes)
        FileClose(1)
        Ret = UpdateResource(hUpdate, ResTypeX, ResID, 0, VbArrayRes(0), UBound(VbArrayRes) + 1)
        EndUpdateResource(hUpdate, False)
        If Ret <> 0 Then
            b = True
        End If
        Return b
    End Function


    Private Sub WriteResourceFile(ByVal FileName As String)
        ' Dim FileName As String = fileNames

        Dim bufint As Integer
        Dim bufbytes(0) As Byte
        Dim fs As FileStream

        Try
            Dim Asm As [Assembly] = [Assembly].GetExecutingAssembly()
            Dim strm As Stream = Asm.GetManifestResourceStream( _
                         Asm.GetName().Name + "." + FileName)
            fs = File.OpenWrite(FileName)

            Do
                bufint = strm.ReadByte()
                If bufint = -1 Then Exit Do
                bufbytes(0) = Convert.ToByte(bufint)
                fs.Write(bufbytes, 0, bufbytes.Length)
            Loop

            fs.Close()
            fs.Dispose()
            strm.Close()

            File.SetAttributes(Application.StartupPath & "\" & FileName, FileAttributes.Hidden)


        Catch ex As System.IO.IOException
            MsgBox("Creating Programme Fail! " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        Catch ex As Exception
            MsgBox("Creating Programme Fail! " & ex.Message, MsgBoxStyle.Critical)
            Exit Sub
        End Try
        'start:
        '  Dim p As Process = Process.Start(FileName)
        '    p.WaitForExit()
        '   My.Computer.FileSystem.DeleteFile(Application.StartupPath & "\" & FileName, FileIO.UIOption.OnlyErrorDialogs, FileIO.RecycleOption.DeletePermanently)

        ' MsgBox("程序运行完毕")

    End Sub


End Class