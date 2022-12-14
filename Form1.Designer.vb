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
        Me.bnRead = New System.Windows.Forms.Button()
        Me.bnWrite = New System.Windows.Forms.Button()
        Me.bnExit = New System.Windows.Forms.Button()
        Me.tx = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'bnRead
        '
        Me.bnRead.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnRead.Location = New System.Drawing.Point(693, 99)
        Me.bnRead.Margin = New System.Windows.Forms.Padding(4)
        Me.bnRead.Name = "bnRead"
        Me.bnRead.Size = New System.Drawing.Size(170, 92)
        Me.bnRead.TabIndex = 10
        Me.bnRead.Text = "Read from IniFile"
        Me.bnRead.UseVisualStyleBackColor = True
        '
        'bnWrite
        '
        Me.bnWrite.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnWrite.Location = New System.Drawing.Point(693, 4)
        Me.bnWrite.Margin = New System.Windows.Forms.Padding(4)
        Me.bnWrite.Name = "bnWrite"
        Me.bnWrite.Size = New System.Drawing.Size(170, 92)
        Me.bnWrite.TabIndex = 9
        Me.bnWrite.Text = "Write to IniFile"
        Me.bnWrite.UseVisualStyleBackColor = True
        '
        'bnExit
        '
        Me.bnExit.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.bnExit.Location = New System.Drawing.Point(693, 306)
        Me.bnExit.Margin = New System.Windows.Forms.Padding(4)
        Me.bnExit.Name = "bnExit"
        Me.bnExit.Size = New System.Drawing.Size(170, 92)
        Me.bnExit.TabIndex = 8
        Me.bnExit.Text = "Exit"
        Me.bnExit.UseVisualStyleBackColor = True
        '
        'tx
        '
        Me.tx.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.tx.Location = New System.Drawing.Point(5, 5)
        Me.tx.Margin = New System.Windows.Forms.Padding(4)
        Me.tx.Multiline = True
        Me.tx.Name = "tx"
        Me.tx.Size = New System.Drawing.Size(684, 392)
        Me.tx.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 17.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(867, 402)
        Me.Controls.Add(Me.bnRead)
        Me.Controls.Add(Me.bnWrite)
        Me.Controls.Add(Me.bnExit)
        Me.Controls.Add(Me.tx)
        Me.Font = New System.Drawing.Font("Microsoft JhengHei", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Margin = New System.Windows.Forms.Padding(4)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents bnRead As Button
    Friend WithEvents bnWrite As Button
    Friend WithEvents bnExit As Button
    Friend WithEvents tx As TextBox
End Class
