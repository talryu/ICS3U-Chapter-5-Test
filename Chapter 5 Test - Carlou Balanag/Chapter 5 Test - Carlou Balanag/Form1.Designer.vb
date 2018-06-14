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
        Me.btnComputeFactorial = New System.Windows.Forms.Button()
        Me.txtNumber = New System.Windows.Forms.TextBox()
        Me.lblNumber = New System.Windows.Forms.Label()
        Me.lblFactorialMessage = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'btnComputeFactorial
        '
        Me.btnComputeFactorial.Location = New System.Drawing.Point(67, 133)
        Me.btnComputeFactorial.Name = "btnComputeFactorial"
        Me.btnComputeFactorial.Size = New System.Drawing.Size(123, 23)
        Me.btnComputeFactorial.TabIndex = 0
        Me.btnComputeFactorial.Text = "Enter Factorial"
        Me.btnComputeFactorial.UseVisualStyleBackColor = True
        '
        'txtNumber
        '
        Me.txtNumber.Location = New System.Drawing.Point(56, 77)
        Me.txtNumber.Name = "txtNumber"
        Me.txtNumber.Size = New System.Drawing.Size(100, 20)
        Me.txtNumber.TabIndex = 1
        '
        'lblNumber
        '
        Me.lblNumber.AutoSize = True
        Me.lblNumber.Location = New System.Drawing.Point(53, 35)
        Me.lblNumber.Name = "lblNumber"
        Me.lblNumber.Size = New System.Drawing.Size(82, 13)
        Me.lblNumber.TabIndex = 2
        Me.lblNumber.Text = "Enter a number:"
        '
        'lblFactorialMessage
        '
        Me.lblFactorialMessage.AutoSize = True
        Me.lblFactorialMessage.Location = New System.Drawing.Point(283, 84)
        Me.lblFactorialMessage.Name = "lblFactorialMessage"
        Me.lblFactorialMessage.Size = New System.Drawing.Size(0, 13)
        Me.lblFactorialMessage.TabIndex = 3
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(969, 569)
        Me.Controls.Add(Me.lblFactorialMessage)
        Me.Controls.Add(Me.lblNumber)
        Me.Controls.Add(Me.txtNumber)
        Me.Controls.Add(Me.btnComputeFactorial)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents btnComputeFactorial As System.Windows.Forms.Button
    Friend WithEvents txtNumber As System.Windows.Forms.TextBox
    Friend WithEvents lblNumber As System.Windows.Forms.Label
    Friend WithEvents lblFactorialMessage As System.Windows.Forms.Label

End Class
