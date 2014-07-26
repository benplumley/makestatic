Imports System
Imports System.IO
Imports System.Environment

Public Class Form1
    Dim serverPath, dynamicPathString, staticPathString As String
    Dim FileListInFolder As FileInfo()
    Dim numberOfValidFiles As Integer

    Private Sub btnPickDynamic_Click(sender As Object, e As EventArgs) Handles btnPickDynamic.Click
        pickDynamicFolder.ShowDialog()
        Try
            dynamicPathString = pickDynamicFolder.SelectedPath
            updateDynamicPath()
        Catch ex As Exception
            'This will be thrown if the user cancels the dialog
        End Try
    End Sub

    Sub updateDynamicPath()
        listDynamicFiles.Items.Clear()
        Dim dynamicPath As New DirectoryInfo(dynamicPathString)
        Dim fileListInFolder As FileInfo() = dynamicPath.GetFiles
        Dim singleFileInFolder As FileInfo
        For Each singleFileInFolder In fileListInFolder
            If singleFileInFolder.Extension = ".php" Then
                listDynamicFiles.Items.Add(singleFileInFolder.Name)
            End If
        Next
    End Sub

    Private Sub btnPickStatic_Click(sender As Object, e As EventArgs) Handles btnPickStatic.Click
        pickStaticFolder.ShowDialog()
        Try
            staticPathString = pickStaticFolder.SelectedPath
            updateStaticPath()
        Catch ex As Exception
            'This will be thrown if the user cancels the dialog
        End Try
    End Sub

    Sub updateStaticPath()
        listStaticFiles.Items.Clear()
        Dim staticPath As New DirectoryInfo(staticPathString)
        Dim fileListInFolder As FileInfo() = staticPath.GetFiles
        Dim singleFileInFolder As FileInfo
        For Each singleFileInFolder In fileListInFolder
            If singleFileInFolder.Extension = ".html" Then
                listStaticFiles.Items.Add(singleFileInFolder.Name)
            End If
        Next
    End Sub

    Private Sub btnValidate_Click(sender As Object, e As EventArgs) Handles btnValidate.Click
        numberOfValidFiles = 0
        Dim PHPFilesToMakeStatic(listDynamicFiles.Items.Count - 1) As String
        For i = 0 To listDynamicFiles.Items.Count - 1
            If listStaticFiles.Items.Contains(listDynamicFiles.Items.Item(i).ToString.Replace(".php", ".html")) Then
                PHPFilesToMakeStatic(i) = listDynamicFiles.Items.Item(i).ToString
            End If
        Next
        For i = 0 To PHPFilesToMakeStatic.Length - 1
            If PHPFilesToMakeStatic(i) <> Nothing Then
                numberOfValidFiles += 1
            End If
        Next
        If MsgBox("Copying " & numberOfValidFiles & " PHP files to HTML files. Continue?", MsgBoxStyle.YesNo) = MsgBoxResult.Yes Then
            Dim HTMLSource As String = ""
            For i = 0 To PHPFilesToMakeStatic.Length - 1
                If PHPFilesToMakeStatic(i) <> Nothing Then
                    getHTMLSource(PHPFilesToMakeStatic(i), HTMLSource)
                    writeToHTMLFile(PHPFilesToMakeStatic(i), HTMLSource)
                End If
            Next
        End If
    End Sub

    Sub getHTMLSource(singlePHPFile As String, ByRef HTMLSource As String)
        Dim fileURL As String = serverPath & "/" & singlePHPFile
        Dim webClient As New System.Net.WebClient
        HTMLSource = webClient.DownloadString(fileURL)
    End Sub

    Sub writeToHTMLFile(singlePHPFile, HTMLSource)
        Dim HTMLFileWriter As New System.IO.StreamWriter(staticPathString & "\" & singlePHPFile.ToString.Replace(".php", ".html"))
        HTMLFileWriter.Write(HTMLSource)
        HTMLFileWriter.Close()
        Dim percentage As Integer = ProgressBar.Value + (100 / numberOfValidFiles)
        If percentage > 100 Then
            percentage = 100
        End If
        ProgressBar.Value = percentage
    End Sub

    Private Sub saveConfig_Click(sender As Object, e As EventArgs) Handles saveConfig.Click
        Dim appdataPath As String = GetFolderPath(SpecialFolder.ApplicationData) & "\makestatic"
        Dim configPath As String
        If Not Directory.Exists(appdataPath) Then
            Directory.CreateDirectory(appdataPath)
        End If
        saveConfigDialog.InitialDirectory = appdataPath
        saveConfigDialog.DefaultExt = "txt"
        saveConfigDialog.Filter = "Text files (*.txt)|*.txt"
        saveConfigDialog.ShowDialog()
        Try
            configPath = saveConfigDialog.FileName
            Dim configFileWriter As New System.IO.StreamWriter(configPath)
            configFileWriter.WriteLine(txtServerPath.Text)
            configFileWriter.WriteLine(dynamicPathString)
            configFileWriter.WriteLine(staticPathString)
            configFileWriter.Close()
        Catch ex As Exception
            'This will be thrown if the user cancels the dialog
        End Try
    End Sub


    Private Sub loadConfig_Click(sender As Object, e As EventArgs) Handles loadConfig.Click
        Dim appdataPath As String = GetFolderPath(SpecialFolder.ApplicationData) & "\makestatic"
        Dim configPath As String
        If Not Directory.Exists(appdataPath) Then
            Directory.CreateDirectory(appdataPath)
        End If
        openConfigDialog.InitialDirectory = appdataPath
        openConfigDialog.DefaultExt = "txt"
        openConfigDialog.Filter = "Text files (*.txt)|*.txt"
        openConfigDialog.ShowDialog()
        Try
            configPath = openConfigDialog.FileName
            Dim configFileReader As New System.IO.StreamReader(configPath)
            txtServerPath.Text = configFileReader.ReadLine
            dynamicPathString = configFileReader.ReadLine
            staticPathString = configFileReader.ReadLine
            configFileReader.Close()
            updateDynamicPath()
            updateStaticPath()
        Catch ex As Exception
            'This will be thrown if the user cancels the dialog
        End Try
    End Sub

    Private Sub txtServerPath_TextChanged(sender As Object, e As EventArgs) Handles txtServerPath.TextChanged
        serverPath = txtServerPath.Text
        If Mid(serverPath, 1, 7) <> "http://" And Mid(serverPath, 1, 8) <> "https://" Then
            serverPath = "http://" & serverPath
        End If
    End Sub
End Class
