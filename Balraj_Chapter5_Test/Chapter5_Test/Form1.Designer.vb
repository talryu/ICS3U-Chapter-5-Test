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
        Me.txtStartVal = New System.Windows.Forms.TextBox()
        Me.txtEndVal = New System.Windows.Forms.TextBox()
        Me.lblText1 = New System.Windows.Forms.Label()
        Me.lblText2 = New System.Windows.Forms.Label()
        Me.btnOutput = New System.Windows.Forms.Button()
        Me.lblSquare = New System.Windows.Forms.Label()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.btnComb = New System.Windows.Forms.Button()
        Me.lbltext3 = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStartVal
        '
        Me.txtStartVal.Location = New System.Drawing.Point(162, 78)
        Me.txtStartVal.Name = "txtStartVal"
        Me.txtStartVal.Size = New System.Drawing.Size(83, 20)
        Me.txtStartVal.TabIndex = 0
        '
        'txtEndVal
        '
        Me.txtEndVal.Location = New System.Drawing.Point(162, 143)
        Me.txtEndVal.Name = "txtEndVal"
        Me.txtEndVal.Size = New System.Drawing.Size(83, 20)
        Me.txtEndVal.TabIndex = 1
        '
        'lblText1
        '
        Me.lblText1.AutoSize = True
        Me.lblText1.Location = New System.Drawing.Point(49, 81)
        Me.lblText1.Name = "lblText1"
        Me.lblText1.Size = New System.Drawing.Size(76, 13)
        Me.lblText1.TabIndex = 2
        Me.lblText1.Text = "Starting Value:"
        '
        'lblText2
        '
        Me.lblText2.AutoSize = True
        Me.lblText2.Location = New System.Drawing.Point(49, 146)
        Me.lblText2.Name = "lblText2"
        Me.lblText2.Size = New System.Drawing.Size(73, 13)
        Me.lblText2.TabIndex = 3
        Me.lblText2.Text = "Ending Value:"
        '
        'btnOutput
        '
        Me.btnOutput.Location = New System.Drawing.Point(52, 199)
        Me.btnOutput.Name = "btnOutput"
        Me.btnOutput.Size = New System.Drawing.Size(97, 32)
        Me.btnOutput.TabIndex = 4
        Me.btnOutput.Text = "Output"
        Me.btnOutput.UseVisualStyleBackColor = True
        '
        'lblSquare
        '
        Me.lblSquare.AutoSize = True
        Me.lblSquare.Location = New System.Drawing.Point(131, 287)
        Me.lblSquare.Name = "lblSquare"
        Me.lblSquare.Size = New System.Drawing.Size(44, 13)
        Me.lblSquare.TabIndex = 6
        Me.lblSquare.Text = "Square:"
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(49, 287)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(47, 13)
        Me.lblNumber.TabIndex = 5
        Me.lblNumber.Text = "Number:"
        '
        'btnComb
        '
        Me.btnComb.Location = New System.Drawing.Point(377, 161)
        Me.btnComb.Name = "btnComb"
        Me.btnComb.Size = New System.Drawing.Size(97, 32)
        Me.btnComb.TabIndex = 7
        Me.btnComb.Text = "Combine Strings"
        Me.btnComb.UseVisualStyleBackColor = True
        '
        'lbltext3
        '
        Me.lbltext3.AutoSize = True
        Me.lbltext3.Location = New System.Drawing.Point(374, 248)
        Me.lbltext3.Name = "lbltext3"
        Me.lbltext3.Size = New System.Drawing.Size(0, 13)
        Me.lbltext3.TabIndex = 8
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(748, 628)
        Me.Controls.Add(Me.lbltext3)
        Me.Controls.Add(Me.btnComb)
        Me.Controls.Add(Me.lblSquare)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnOutput)
        Me.Controls.Add(Me.lblText2)
        Me.Controls.Add(Me.lblText1)
        Me.Controls.Add(Me.txtEndVal)
        Me.Controls.Add(Me.txtStartVal)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStartVal As System.Windows.Forms.TextBox
    Friend WithEvents txtEndVal As System.Windows.Forms.TextBox
    Friend WithEvents lblText1 As System.Windows.Forms.Label
    Friend WithEvents lblText2 As System.Windows.Forms.Label
    Friend WithEvents btnOutput As System.Windows.Forms.Button
    Friend WithEvents lblSquare As System.Windows.Forms.Label
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents btnComb As System.Windows.Forms.Button
    Friend WithEvents lbltext3 As System.Windows.Forms.Label

End Class
