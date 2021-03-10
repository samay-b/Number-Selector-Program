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
        Me.btnNumbers = New System.Windows.Forms.Button()
        Me.lblInfo = New System.Windows.Forms.Label()
        Me.btnMean = New System.Windows.Forms.Button()
        Me.btnMedian = New System.Windows.Forms.Button()
        Me.lstNumbers = New System.Windows.Forms.ListBox()
        Me.pctReaction = New System.Windows.Forms.PictureBox()
        CType(Me.pctReaction, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnNumbers
        '
        Me.btnNumbers.BackColor = System.Drawing.SystemColors.Info
        Me.btnNumbers.Location = New System.Drawing.Point(12, 12)
        Me.btnNumbers.Name = "btnNumbers"
        Me.btnNumbers.Size = New System.Drawing.Size(192, 35)
        Me.btnNumbers.TabIndex = 0
        Me.btnNumbers.Text = "Insert 5 Numbers"
        Me.btnNumbers.UseVisualStyleBackColor = False
        '
        'lblInfo
        '
        Me.lblInfo.AutoSize = True
        Me.lblInfo.Location = New System.Drawing.Point(12, 64)
        Me.lblInfo.Name = "lblInfo"
        Me.lblInfo.Size = New System.Drawing.Size(0, 20)
        Me.lblInfo.TabIndex = 1
        '
        'btnMean
        '
        Me.btnMean.BackColor = System.Drawing.Color.LightGray
        Me.btnMean.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.btnMean.Location = New System.Drawing.Point(12, 101)
        Me.btnMean.Name = "btnMean"
        Me.btnMean.Size = New System.Drawing.Size(91, 54)
        Me.btnMean.TabIndex = 2
        Me.btnMean.Text = "Find Mean"
        Me.btnMean.UseVisualStyleBackColor = False
        '
        'btnMedian
        '
        Me.btnMedian.Location = New System.Drawing.Point(109, 101)
        Me.btnMedian.Name = "btnMedian"
        Me.btnMedian.Size = New System.Drawing.Size(95, 54)
        Me.btnMedian.TabIndex = 3
        Me.btnMedian.Text = "Find Median"
        Me.btnMedian.UseVisualStyleBackColor = True
        '
        'lstNumbers
        '
        Me.lstNumbers.FormattingEnabled = True
        Me.lstNumbers.ItemHeight = 20
        Me.lstNumbers.Location = New System.Drawing.Point(12, 178)
        Me.lstNumbers.Name = "lstNumbers"
        Me.lstNumbers.Size = New System.Drawing.Size(192, 124)
        Me.lstNumbers.TabIndex = 4
        '
        'pctReaction
        '
        Me.pctReaction.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.pctReaction.Location = New System.Drawing.Point(229, 95)
        Me.pctReaction.Name = "pctReaction"
        Me.pctReaction.Size = New System.Drawing.Size(130, 130)
        Me.pctReaction.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.pctReaction.TabIndex = 5
        Me.pctReaction.TabStop = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.WhiteSmoke
        Me.ClientSize = New System.Drawing.Size(445, 314)
        Me.Controls.Add(Me.pctReaction)
        Me.Controls.Add(Me.lstNumbers)
        Me.Controls.Add(Me.btnMedian)
        Me.Controls.Add(Me.btnMean)
        Me.Controls.Add(Me.lblInfo)
        Me.Controls.Add(Me.btnNumbers)
        Me.Name = "Form1"
        Me.Text = "Happy Fun Fun Number Time!"
        CType(Me.pctReaction, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnNumbers As Button
    Friend WithEvents lblInfo As Label
    Friend WithEvents btnMean As Button
    Friend WithEvents btnMedian As Button
    Friend WithEvents lstNumbers As ListBox
    Friend WithEvents pctReaction As PictureBox
End Class
