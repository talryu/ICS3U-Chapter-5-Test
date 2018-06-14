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
        Me.txtStarting = New System.Windows.Forms.TextBox()
        Me.txtEnding = New System.Windows.Forms.TextBox()
        Me.lblStarting = New System.Windows.Forms.Label()
        Me.lblEnding = New System.Windows.Forms.Label()
        Me.btnDisplay = New System.Windows.Forms.Button()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblSquare = New System.Windows.Forms.Label()
        Me.lblA = New System.Windows.Forms.Label()
        Me.lblB = New System.Windows.Forms.Label()
        Me.lblLabel = New System.Windows.Forms.Label()
        Me.btnCombine = New System.Windows.Forms.Button()
        Me.lblText = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'txtStarting
        '
        Me.txtStarting.Location = New System.Drawing.Point(67, 77)
        Me.txtStarting.Name = "txtStarting"
        Me.txtStarting.Size = New System.Drawing.Size(100, 26)
        Me.txtStarting.TabIndex = 0
        '
        'txtEnding
        '
        Me.txtEnding.Location = New System.Drawing.Point(242, 77)
        Me.txtEnding.Name = "txtEnding"
        Me.txtEnding.Size = New System.Drawing.Size(100, 26)
        Me.txtEnding.TabIndex = 1
        '
        'lblStarting
        '
        Me.lblStarting.AutoSize = True
        Me.lblStarting.Location = New System.Drawing.Point(65, 51)
        Me.lblStarting.Name = "lblStarting"
        Me.lblStarting.Size = New System.Drawing.Size(110, 20)
        Me.lblStarting.TabIndex = 2
        Me.lblStarting.Text = "Starting Value"
        '
        'lblEnding
        '
        Me.lblEnding.AutoSize = True
        Me.lblEnding.Location = New System.Drawing.Point(240, 55)
        Me.lblEnding.Name = "lblEnding"
        Me.lblEnding.Size = New System.Drawing.Size(104, 20)
        Me.lblEnding.TabIndex = 3
        Me.lblEnding.Text = "Ending Value"
        '
        'btnDisplay
        '
        Me.btnDisplay.Location = New System.Drawing.Point(427, 75)
        Me.btnDisplay.Name = "btnDisplay"
        Me.btnDisplay.Size = New System.Drawing.Size(100, 31)
        Me.btnDisplay.TabIndex = 4
        Me.btnDisplay.Text = "Display"
        Me.btnDisplay.UseVisualStyleBackColor = True
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(65, 142)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(73, 20)
        Me.lblNumber.TabIndex = 6
        Me.lblNumber.Text = "Numbers"
        '
        'lblSquare
        '
        Me.lblSquare.AutoSize = True
        Me.lblSquare.Location = New System.Drawing.Point(240, 142)
        Me.lblSquare.Name = "lblSquare"
        Me.lblSquare.Size = New System.Drawing.Size(61, 20)
        Me.lblSquare.TabIndex = 7
        Me.lblSquare.Text = "Square"
        '
        'lblA
        '
        Me.lblA.AutoSize = True
        Me.lblA.Location = New System.Drawing.Point(199, 18)
        Me.lblA.Name = "lblA"
        Me.lblA.Size = New System.Drawing.Size(23, 20)
        Me.lblA.TabIndex = 8
        Me.lblA.Text = "a)"
        '
        'lblB
        '
        Me.lblB.AutoSize = True
        Me.lblB.Location = New System.Drawing.Point(886, 18)
        Me.lblB.Name = "lblB"
        Me.lblB.Size = New System.Drawing.Size(23, 20)
        Me.lblB.TabIndex = 9
        Me.lblB.Text = "b)"
        '
        'lblLabel
        '
        Me.lblLabel.AutoSize = True
        Me.lblLabel.Location = New System.Drawing.Point(709, 51)
        Me.lblLabel.Name = "lblLabel"
        Me.lblLabel.Size = New System.Drawing.Size(115, 20)
        Me.lblLabel.TabIndex = 10
        Me.lblLabel.Text = "Combined Text"
        '
        'btnCombine
        '
        Me.btnCombine.Location = New System.Drawing.Point(713, 131)
        Me.btnCombine.Name = "btnCombine"
        Me.btnCombine.Size = New System.Drawing.Size(100, 31)
        Me.btnCombine.TabIndex = 11
        Me.btnCombine.Text = "Combine"
        Me.btnCombine.UseVisualStyleBackColor = True
        '
        'lblText
        '
        Me.lblText.AutoSize = True
        Me.lblText.Location = New System.Drawing.Point(709, 86)
        Me.lblText.Name = "lblText"
        Me.lblText.Size = New System.Drawing.Size(0, 20)
        Me.lblText.TabIndex = 12
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(9.0!, 20.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1180, 708)
        Me.Controls.Add(Me.lblText)
        Me.Controls.Add(Me.btnCombine)
        Me.Controls.Add(Me.lblLabel)
        Me.Controls.Add(Me.lblB)
        Me.Controls.Add(Me.lblA)
        Me.Controls.Add(Me.lblSquare)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.btnDisplay)
        Me.Controls.Add(Me.lblEnding)
        Me.Controls.Add(Me.lblStarting)
        Me.Controls.Add(Me.txtEnding)
        Me.Controls.Add(Me.txtStarting)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtStarting As System.Windows.Forms.TextBox
    Friend WithEvents txtEnding As System.Windows.Forms.TextBox
    Friend WithEvents lblStarting As System.Windows.Forms.Label
    Friend WithEvents lblEnding As System.Windows.Forms.Label
    Friend WithEvents btnDisplay As System.Windows.Forms.Button
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblSquare As System.Windows.Forms.Label
    Friend WithEvents lblA As System.Windows.Forms.Label
    Friend WithEvents lblB As System.Windows.Forms.Label
    Friend WithEvents lblLabel As System.Windows.Forms.Label
    Friend WithEvents btnCombine As System.Windows.Forms.Button
    Friend WithEvents lblText As System.Windows.Forms.Label

End Class
