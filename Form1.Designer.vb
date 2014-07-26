<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtServerPath = New System.Windows.Forms.TextBox()
        Me.labDynamicAddress = New System.Windows.Forms.Label()
        Me.pickDynamicFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.btnPickDynamic = New System.Windows.Forms.Button()
        Me.btnPickStatic = New System.Windows.Forms.Button()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.pickStaticFolder = New System.Windows.Forms.FolderBrowserDialog()
        Me.listDynamicFiles = New System.Windows.Forms.ListBox()
        Me.listStaticFiles = New System.Windows.Forms.ListBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.btnValidate = New System.Windows.Forms.Button()
        Me.saveConfig = New System.Windows.Forms.Button()
        Me.loadConfig = New System.Windows.Forms.Button()
        Me.saveConfigDialog = New System.Windows.Forms.SaveFileDialog()
        Me.openConfigDialog = New System.Windows.Forms.OpenFileDialog()
        Me.ProgressBar = New System.Windows.Forms.ProgressBar()
        Me.SuspendLayout()
        '
        'txtServerPath
        '
        Me.txtServerPath.Location = New System.Drawing.Point(184, 12)
        Me.txtServerPath.Name = "txtServerPath"
        Me.txtServerPath.Size = New System.Drawing.Size(462, 20)
        Me.txtServerPath.TabIndex = 0
        '
        'labDynamicAddress
        '
        Me.labDynamicAddress.AutoSize = True
        Me.labDynamicAddress.Location = New System.Drawing.Point(12, 15)
        Me.labDynamicAddress.Name = "labDynamicAddress"
        Me.labDynamicAddress.Size = New System.Drawing.Size(166, 13)
        Me.labDynamicAddress.TabIndex = 1
        Me.labDynamicAddress.Text = "The root URL of the dynamic site:"
        '
        'btnPickDynamic
        '
        Me.btnPickDynamic.Location = New System.Drawing.Point(471, 38)
        Me.btnPickDynamic.Name = "btnPickDynamic"
        Me.btnPickDynamic.Size = New System.Drawing.Size(175, 23)
        Me.btnPickDynamic.TabIndex = 3
        Me.btnPickDynamic.Text = "Pick dynamic folder"
        Me.btnPickDynamic.UseVisualStyleBackColor = True
        '
        'btnPickStatic
        '
        Me.btnPickStatic.Location = New System.Drawing.Point(471, 67)
        Me.btnPickStatic.Name = "btnPickStatic"
        Me.btnPickStatic.Size = New System.Drawing.Size(175, 23)
        Me.btnPickStatic.TabIndex = 4
        Me.btnPickStatic.Text = "Pick static folder"
        Me.btnPickStatic.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(12, 43)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(420, 13)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "The folder containing the PHP files. All files in this folder will be copied to s" & _
    "tatic versions:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(12, 72)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(453, 13)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "The folder containing the HTML files. Files in this folder will be overwritten by" & _
    " updated versions:"
        '
        'listDynamicFiles
        '
        Me.listDynamicFiles.FormattingEnabled = True
        Me.listDynamicFiles.Location = New System.Drawing.Point(15, 115)
        Me.listDynamicFiles.Name = "listDynamicFiles"
        Me.listDynamicFiles.Size = New System.Drawing.Size(313, 290)
        Me.listDynamicFiles.TabIndex = 7
        '
        'listStaticFiles
        '
        Me.listStaticFiles.FormattingEnabled = True
        Me.listStaticFiles.Location = New System.Drawing.Point(333, 115)
        Me.listStaticFiles.Name = "listStaticFiles"
        Me.listStaticFiles.Size = New System.Drawing.Size(313, 290)
        Me.listStaticFiles.TabIndex = 8
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(12, 408)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(465, 13)
        Me.Label3.TabIndex = 9
        Me.Label3.Text = "Files in either column without an exact name match (except extension) in the othe" & _
    "r will be ignored."
        '
        'btnValidate
        '
        Me.btnValidate.Location = New System.Drawing.Point(471, 433)
        Me.btnValidate.Name = "btnValidate"
        Me.btnValidate.Size = New System.Drawing.Size(175, 23)
        Me.btnValidate.TabIndex = 10
        Me.btnValidate.Text = "Continue"
        Me.btnValidate.UseVisualStyleBackColor = True
        '
        'saveConfig
        '
        Me.saveConfig.Location = New System.Drawing.Point(15, 433)
        Me.saveConfig.Name = "saveConfig"
        Me.saveConfig.Size = New System.Drawing.Size(145, 23)
        Me.saveConfig.TabIndex = 11
        Me.saveConfig.Text = "Save current configuration"
        Me.saveConfig.UseVisualStyleBackColor = True
        '
        'loadConfig
        '
        Me.loadConfig.Location = New System.Drawing.Point(166, 433)
        Me.loadConfig.Name = "loadConfig"
        Me.loadConfig.Size = New System.Drawing.Size(145, 23)
        Me.loadConfig.TabIndex = 12
        Me.loadConfig.Text = "Load a configuration"
        Me.loadConfig.UseVisualStyleBackColor = True
        '
        'ProgressBar
        '
        Me.ProgressBar.Location = New System.Drawing.Point(15, 462)
        Me.ProgressBar.Name = "ProgressBar"
        Me.ProgressBar.Size = New System.Drawing.Size(631, 23)
        Me.ProgressBar.TabIndex = 13
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(658, 499)
        Me.Controls.Add(Me.ProgressBar)
        Me.Controls.Add(Me.loadConfig)
        Me.Controls.Add(Me.saveConfig)
        Me.Controls.Add(Me.btnValidate)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.listStaticFiles)
        Me.Controls.Add(Me.listDynamicFiles)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.btnPickStatic)
        Me.Controls.Add(Me.btnPickDynamic)
        Me.Controls.Add(Me.labDynamicAddress)
        Me.Controls.Add(Me.txtServerPath)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximizeBox = False
        Me.Name = "Form1"
        Me.Text = "makestatic"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtServerPath As System.Windows.Forms.TextBox
    Friend WithEvents labDynamicAddress As System.Windows.Forms.Label
    Friend WithEvents pickDynamicFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents btnPickDynamic As System.Windows.Forms.Button
    Friend WithEvents btnPickStatic As System.Windows.Forms.Button
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents pickStaticFolder As System.Windows.Forms.FolderBrowserDialog
    Friend WithEvents listDynamicFiles As System.Windows.Forms.ListBox
    Friend WithEvents listStaticFiles As System.Windows.Forms.ListBox
    Friend WithEvents Label3 As System.Windows.Forms.Label
    Friend WithEvents btnValidate As System.Windows.Forms.Button
    Friend WithEvents saveConfig As System.Windows.Forms.Button
    Friend WithEvents loadConfig As System.Windows.Forms.Button
    Friend WithEvents saveConfigDialog As System.Windows.Forms.SaveFileDialog
    Friend WithEvents openConfigDialog As System.Windows.Forms.OpenFileDialog
    Friend WithEvents ProgressBar As System.Windows.Forms.ProgressBar

End Class
