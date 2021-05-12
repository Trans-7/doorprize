<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.NextAction = New System.Windows.Forms.GroupBox()
        Me.BtnshowOutput = New System.Windows.Forms.Button()
        Me.BtnSvWinner = New System.Windows.Forms.Button()
        Me.BtnShowAllWinner = New System.Windows.Forms.Button()
        Me.DataGridView1 = New System.Windows.Forms.DataGridView()
        Me.BtnImport = New System.Windows.Forms.Button()
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog()
        Me.BtnImport2 = New System.Windows.Forms.Button()
        Me.DataGridView2 = New System.Windows.Forms.DataGridView()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.BtnStart = New System.Windows.Forms.Button()
        Me.TextBox_FilePath = New System.Windows.Forms.TextBox()
        Me.TextBox_FilePath2 = New System.Windows.Forms.TextBox()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.NumericUpDown1 = New System.Windows.Forms.NumericUpDown()
        Me.DataGridView3 = New System.Windows.Forms.DataGridView()
        Me.BtnExport = New System.Windows.Forms.Button()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.GetDownButton = New System.Windows.Forms.Button()
        Me.DataGridView6 = New System.Windows.Forms.DataGridView()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.DataGridView4 = New System.Windows.Forms.DataGridView()
        Me.DataGridView5 = New System.Windows.Forms.DataGridView()
        Me.OpenFileDialog2 = New System.Windows.Forms.OpenFileDialog()
        Me.NextAction.SuspendLayout()
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel2.SuspendLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'NextAction
        '
        Me.NextAction.Controls.Add(Me.BtnshowOutput)
        Me.NextAction.Controls.Add(Me.BtnSvWinner)
        Me.NextAction.Controls.Add(Me.BtnShowAllWinner)
        Me.NextAction.Location = New System.Drawing.Point(421, 127)
        Me.NextAction.Name = "NextAction"
        Me.NextAction.Size = New System.Drawing.Size(223, 240)
        Me.NextAction.TabIndex = 31
        Me.NextAction.TabStop = False
        Me.NextAction.Text = "NextAction"
        '
        'BtnshowOutput
        '
        Me.BtnshowOutput.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnshowOutput.Location = New System.Drawing.Point(25, 45)
        Me.BtnshowOutput.Name = "BtnshowOutput"
        Me.BtnshowOutput.Size = New System.Drawing.Size(112, 27)
        Me.BtnshowOutput.TabIndex = 26
        Me.BtnshowOutput.Text = "Show Output"
        Me.BtnshowOutput.UseVisualStyleBackColor = True
        '
        'BtnSvWinner
        '
        Me.BtnSvWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnSvWinner.Location = New System.Drawing.Point(25, 104)
        Me.BtnSvWinner.Name = "BtnSvWinner"
        Me.BtnSvWinner.Size = New System.Drawing.Size(112, 27)
        Me.BtnSvWinner.TabIndex = 30
        Me.BtnSvWinner.Text = "Save Winner"
        Me.BtnSvWinner.UseVisualStyleBackColor = True
        '
        'BtnShowAllWinner
        '
        Me.BtnShowAllWinner.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnShowAllWinner.Location = New System.Drawing.Point(25, 163)
        Me.BtnShowAllWinner.Name = "BtnShowAllWinner"
        Me.BtnShowAllWinner.Size = New System.Drawing.Size(131, 27)
        Me.BtnShowAllWinner.TabIndex = 29
        Me.BtnShowAllWinner.Text = "Show All Winner"
        Me.BtnShowAllWinner.UseVisualStyleBackColor = True
        '
        'DataGridView1
        '
        Me.DataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView1.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView1.Name = "DataGridView1"
        Me.DataGridView1.Size = New System.Drawing.Size(294, 219)
        Me.DataGridView1.TabIndex = 0
        '
        'BtnImport
        '
        Me.BtnImport.Location = New System.Drawing.Point(244, 8)
        Me.BtnImport.Name = "BtnImport"
        Me.BtnImport.Size = New System.Drawing.Size(112, 23)
        Me.BtnImport.TabIndex = 1
        Me.BtnImport.Text = "Upload Participant"
        Me.BtnImport.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'BtnImport2
        '
        Me.BtnImport2.Location = New System.Drawing.Point(580, 8)
        Me.BtnImport2.Name = "BtnImport2"
        Me.BtnImport2.Size = New System.Drawing.Size(91, 23)
        Me.BtnImport2.TabIndex = 2
        Me.BtnImport2.Text = "Upload Prize"
        Me.BtnImport2.UseVisualStyleBackColor = True
        '
        'DataGridView2
        '
        Me.DataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView2.Location = New System.Drawing.Point(362, 36)
        Me.DataGridView2.Name = "DataGridView2"
        Me.DataGridView2.Size = New System.Drawing.Size(309, 275)
        Me.DataGridView2.TabIndex = 3
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.Location = New System.Drawing.Point(20, 78)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(56, 16)
        Me.Label2.TabIndex = 6
        Me.Label2.Text = "Quantity"
        '
        'Timer1
        '
        '
        'BtnStart
        '
        Me.BtnStart.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnStart.Location = New System.Drawing.Point(297, 89)
        Me.BtnStart.Name = "BtnStart"
        Me.BtnStart.Size = New System.Drawing.Size(102, 39)
        Me.BtnStart.TabIndex = 15
        Me.BtnStart.Text = "Start"
        Me.BtnStart.UseVisualStyleBackColor = True
        '
        'TextBox_FilePath
        '
        Me.TextBox_FilePath.Location = New System.Drawing.Point(12, 10)
        Me.TextBox_FilePath.Name = "TextBox_FilePath"
        Me.TextBox_FilePath.ReadOnly = True
        Me.TextBox_FilePath.Size = New System.Drawing.Size(226, 20)
        Me.TextBox_FilePath.TabIndex = 16
        Me.TextBox_FilePath.Text = "    << Click here to select file >>"
        '
        'TextBox_FilePath2
        '
        Me.TextBox_FilePath2.Location = New System.Drawing.Point(362, 10)
        Me.TextBox_FilePath2.Name = "TextBox_FilePath2"
        Me.TextBox_FilePath2.ReadOnly = True
        Me.TextBox_FilePath2.Size = New System.Drawing.Size(209, 20)
        Me.TextBox_FilePath2.TabIndex = 17
        Me.TextBox_FilePath2.Text = "    << Click here to select file >>"
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Cambria", 21.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.Location = New System.Drawing.Point(246, 27)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(174, 34)
        Me.Label6.TabIndex = 18
        Me.Label6.Text = "DOORPRIZE"
        '
        'Panel1
        '
        Me.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel1.Controls.Add(Me.NextAction)
        Me.Panel1.Controls.Add(Me.NumericUpDown1)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Controls.Add(Me.BtnStart)
        Me.Panel1.Controls.Add(Me.DataGridView3)
        Me.Panel1.Controls.Add(Me.Label2)
        Me.Panel1.Location = New System.Drawing.Point(12, 317)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(659, 382)
        Me.Panel1.TabIndex = 19
        '
        'NumericUpDown1
        '
        Me.NumericUpDown1.Location = New System.Drawing.Point(23, 100)
        Me.NumericUpDown1.Maximum = New Decimal(New Integer() {10, 0, 0, 0})
        Me.NumericUpDown1.Name = "NumericUpDown1"
        Me.NumericUpDown1.Size = New System.Drawing.Size(114, 20)
        Me.NumericUpDown1.TabIndex = 28
        '
        'DataGridView3
        '
        Me.DataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView3.Location = New System.Drawing.Point(23, 134)
        Me.DataGridView3.Name = "DataGridView3"
        Me.DataGridView3.Size = New System.Drawing.Size(376, 233)
        Me.DataGridView3.TabIndex = 0
        '
        'BtnExport
        '
        Me.BtnExport.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.BtnExport.Location = New System.Drawing.Point(305, 467)
        Me.BtnExport.Name = "BtnExport"
        Me.BtnExport.Size = New System.Drawing.Size(102, 28)
        Me.BtnExport.TabIndex = 22
        Me.BtnExport.Text = "Export Result"
        Me.BtnExport.UseVisualStyleBackColor = True
        '
        'Panel2
        '
        Me.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.Panel2.Controls.Add(Me.GetDownButton)
        Me.Panel2.Controls.Add(Me.DataGridView6)
        Me.Panel2.Controls.Add(Me.Label8)
        Me.Panel2.Controls.Add(Me.BtnExport)
        Me.Panel2.Controls.Add(Me.DataGridView4)
        Me.Panel2.Location = New System.Drawing.Point(687, 12)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(424, 687)
        Me.Panel2.TabIndex = 20
        '
        'GetDownButton
        '
        Me.GetDownButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.GetDownButton.Location = New System.Drawing.Point(11, 467)
        Me.GetDownButton.Name = "GetDownButton"
        Me.GetDownButton.Size = New System.Drawing.Size(159, 28)
        Me.GetDownButton.TabIndex = 24
        Me.GetDownButton.Text = "Drop Cancel Winner"
        Me.GetDownButton.UseVisualStyleBackColor = True
        '
        'DataGridView6
        '
        Me.DataGridView6.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView6.Location = New System.Drawing.Point(11, 501)
        Me.DataGridView6.Name = "DataGridView6"
        Me.DataGridView6.Size = New System.Drawing.Size(396, 171)
        Me.DataGridView6.TabIndex = 23
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Cambria", 9.0!, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.Location = New System.Drawing.Point(8, 5)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(59, 14)
        Me.Label8.TabIndex = 3
        Me.Label8.Text = "All Winner"
        '
        'DataGridView4
        '
        Me.DataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView4.Location = New System.Drawing.Point(11, 28)
        Me.DataGridView4.Name = "DataGridView4"
        Me.DataGridView4.Size = New System.Drawing.Size(396, 433)
        Me.DataGridView4.TabIndex = 1
        '
        'DataGridView5
        '
        Me.DataGridView5.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.DataGridView5.Location = New System.Drawing.Point(12, 36)
        Me.DataGridView5.Name = "DataGridView5"
        Me.DataGridView5.Size = New System.Drawing.Size(344, 275)
        Me.DataGridView5.TabIndex = 21
        Me.DataGridView5.Visible = False
        '
        'OpenFileDialog2
        '
        Me.OpenFileDialog2.FileName = "OpenFileDialog2"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1123, 711)
        Me.Controls.Add(Me.DataGridView5)
        Me.Controls.Add(Me.Panel2)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.TextBox_FilePath2)
        Me.Controls.Add(Me.TextBox_FilePath)
        Me.Controls.Add(Me.DataGridView2)
        Me.Controls.Add(Me.BtnImport2)
        Me.Controls.Add(Me.BtnImport)
        Me.Controls.Add(Me.DataGridView1)
        Me.Name = "Form1"
        Me.Text = "DOORPRIZE"
        Me.NextAction.ResumeLayout(False)
        CType(Me.DataGridView1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView2, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        CType(Me.NumericUpDown1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView3, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel2.ResumeLayout(False)
        Me.Panel2.PerformLayout()
        CType(Me.DataGridView6, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.DataGridView5, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents DataGridView1 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnImport As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents BtnImport2 As System.Windows.Forms.Button
    Friend WithEvents DataGridView2 As System.Windows.Forms.DataGridView
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents Timer1 As System.Windows.Forms.Timer
    Friend WithEvents BtnStart As System.Windows.Forms.Button
    Friend WithEvents TextBox_FilePath As System.Windows.Forms.TextBox
    Friend WithEvents TextBox_FilePath2 As System.Windows.Forms.TextBox
    Friend WithEvents Label6 As System.Windows.Forms.Label
    Friend WithEvents Panel1 As System.Windows.Forms.Panel
    Friend WithEvents BtnExport As System.Windows.Forms.Button
    Friend WithEvents Panel2 As System.Windows.Forms.Panel
    Friend WithEvents DataGridView4 As System.Windows.Forms.DataGridView
    Friend WithEvents DataGridView3 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnshowOutput As System.Windows.Forms.Button
    Friend WithEvents NumericUpDown1 As System.Windows.Forms.NumericUpDown
    Friend WithEvents BtnShowAllWinner As System.Windows.Forms.Button
    Friend WithEvents Label8 As System.Windows.Forms.Label
    Friend WithEvents DataGridView5 As System.Windows.Forms.DataGridView
    Friend WithEvents BtnSvWinner As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog2 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents GetDownButton As Button
    Friend WithEvents DataGridView6 As DataGridView
    Friend WithEvents NextAction As GroupBox
End Class
