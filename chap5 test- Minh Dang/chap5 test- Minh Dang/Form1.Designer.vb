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
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.txtend = New System.Windows.Forms.TextBox()
        Me.txtstart = New System.Windows.Forms.TextBox()
        Me.btnRange = New System.Windows.Forms.Button()
        Me.lblRange = New System.Windows.Forms.Label()
        Me.btnconcaternate = New System.Windows.Forms.Button()
        Me.lblconcaternate = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(47, 75)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(115, 13)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "enter the strating value"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(47, 104)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(87, 13)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "enter the ending "
        '
        'txtend
        '
        Me.txtend.Location = New System.Drawing.Point(168, 104)
        Me.txtend.Name = "txtend"
        Me.txtend.Size = New System.Drawing.Size(100, 20)
        Me.txtend.TabIndex = 2
        '
        'txtstart
        '
        Me.txtstart.Location = New System.Drawing.Point(168, 75)
        Me.txtstart.Name = "txtstart"
        Me.txtstart.Size = New System.Drawing.Size(100, 20)
        Me.txtstart.TabIndex = 3
        '
        'btnRange
        '
        Me.btnRange.Location = New System.Drawing.Point(50, 155)
        Me.btnRange.Name = "btnRange"
        Me.btnRange.Size = New System.Drawing.Size(75, 23)
        Me.btnRange.TabIndex = 4
        Me.btnRange.Text = "Range"
        Me.btnRange.UseVisualStyleBackColor = True
        '
        'lblRange
        '
        Me.lblRange.AutoSize = True
        Me.lblRange.Location = New System.Drawing.Point(165, 160)
        Me.lblRange.Name = "lblRange"
        Me.lblRange.Size = New System.Drawing.Size(0, 13)
        Me.lblRange.TabIndex = 5
        '
        'btnconcaternate
        '
        Me.btnconcaternate.Location = New System.Drawing.Point(396, 71)
        Me.btnconcaternate.Name = "btnconcaternate"
        Me.btnconcaternate.Size = New System.Drawing.Size(75, 23)
        Me.btnconcaternate.TabIndex = 6
        Me.btnconcaternate.Text = "concatenate"
        Me.btnconcaternate.UseVisualStyleBackColor = True
        '
        'lblconcaternate
        '
        Me.lblconcaternate.AutoSize = True
        Me.lblconcaternate.Location = New System.Drawing.Point(396, 124)
        Me.lblconcaternate.Name = "lblconcaternate"
        Me.lblconcaternate.Size = New System.Drawing.Size(0, 13)
        Me.lblconcaternate.TabIndex = 7
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(764, 504)
        Me.Controls.Add(Me.lblconcaternate)
        Me.Controls.Add(Me.btnconcaternate)
        Me.Controls.Add(Me.lblRange)
        Me.Controls.Add(Me.btnRange)
        Me.Controls.Add(Me.txtstart)
        Me.Controls.Add(Me.txtend)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label1 As System.Windows.Forms.Label
    Friend WithEvents Label2 As System.Windows.Forms.Label
    Friend WithEvents txtend As System.Windows.Forms.TextBox
    Friend WithEvents txtstart As System.Windows.Forms.TextBox
    Friend WithEvents btnRange As System.Windows.Forms.Button
    Friend WithEvents lblRange As System.Windows.Forms.Label
    Friend WithEvents btnconcaternate As System.Windows.Forms.Button
    Friend WithEvents lblconcaternate As System.Windows.Forms.Label

End Class
