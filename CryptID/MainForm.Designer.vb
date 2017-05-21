<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainForm
    Inherits System.Windows.Forms.Form

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainForm))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.TableLayoutPanel1 = New System.Windows.Forms.TableLayoutPanel()
        Me.SelectFile = New System.Windows.Forms.Button()
        Me.FullScan = New System.Windows.Forms.Button()
        Me.SelectNote = New System.Windows.Forms.Button()
        Me.Button5 = New System.Windows.Forms.Button()
        Me.TableLayoutPanel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Padding = New System.Windows.Forms.Padding(0, 3, 0, 0)
        Me.Label1.Size = New System.Drawing.Size(1437, 20)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Please choose how you want to identify which ransomware has infected your system"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'TableLayoutPanel1
        '
        Me.TableLayoutPanel1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.TableLayoutPanel1.ColumnCount = 3
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.ColumnStyles.Add(New System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333!))
        Me.TableLayoutPanel1.Controls.Add(Me.SelectFile, 0, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.FullScan, 2, 0)
        Me.TableLayoutPanel1.Controls.Add(Me.SelectNote, 1, 0)
        Me.TableLayoutPanel1.Location = New System.Drawing.Point(16, 32)
        Me.TableLayoutPanel1.Name = "TableLayoutPanel1"
        Me.TableLayoutPanel1.RowCount = 1
        Me.TableLayoutPanel1.RowStyles.Add(New System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100.0!))
        Me.TableLayoutPanel1.Size = New System.Drawing.Size(1434, 514)
        Me.TableLayoutPanel1.TabIndex = 4
        '
        'SelectFile
        '
        Me.SelectFile.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectFile.Image = CType(resources.GetObject("SelectFile.Image"), System.Drawing.Image)
        Me.SelectFile.Location = New System.Drawing.Point(3, 3)
        Me.SelectFile.Name = "SelectFile"
        Me.SelectFile.Size = New System.Drawing.Size(472, 508)
        Me.SelectFile.TabIndex = 5
        Me.SelectFile.Text = "Select an encrypted file"
        Me.SelectFile.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SelectFile.UseVisualStyleBackColor = True
        '
        'FullScan
        '
        Me.FullScan.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.FullScan.Image = Global.CryptID.My.Resources.Resources.radar
        Me.FullScan.Location = New System.Drawing.Point(959, 3)
        Me.FullScan.Name = "FullScan"
        Me.FullScan.Size = New System.Drawing.Size(472, 508)
        Me.FullScan.TabIndex = 3
        Me.FullScan.Text = "Do a full scan (scans processes and your drives)"
        Me.FullScan.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.FullScan.UseVisualStyleBackColor = True
        '
        'SelectNote
        '
        Me.SelectNote.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.SelectNote.Image = Global.CryptID.My.Resources.Resources.note
        Me.SelectNote.Location = New System.Drawing.Point(481, 3)
        Me.SelectNote.Name = "SelectNote"
        Me.SelectNote.Size = New System.Drawing.Size(472, 508)
        Me.SelectNote.TabIndex = 4
        Me.SelectNote.Text = "Select a ransom/decryption note"
        Me.SelectNote.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.SelectNote.UseVisualStyleBackColor = True
        '
        'Button5
        '
        Me.Button5.Image = CType(resources.GetObject("Button5.Image"), System.Drawing.Image)
        Me.Button5.Location = New System.Drawing.Point(893, 3)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(15, 94)
        Me.Button5.TabIndex = 4
        Me.Button5.Text = "Select an encrypted file"
        Me.Button5.TextAlign = System.Drawing.ContentAlignment.BottomCenter
        Me.Button5.UseVisualStyleBackColor = True
        '
        'MainForm
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1461, 558)
        Me.Controls.Add(Me.TableLayoutPanel1)
        Me.Controls.Add(Me.Label1)
        Me.Margin = New System.Windows.Forms.Padding(2)
        Me.Name = "MainForm"
        Me.Text = "CryptID"
        Me.TableLayoutPanel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents TableLayoutPanel1 As TableLayoutPanel
    Friend WithEvents SelectFile As Button
    Friend WithEvents SelectNote As Button
    Friend WithEvents FullScan As Button
    Friend WithEvents Button5 As Button
End Class
