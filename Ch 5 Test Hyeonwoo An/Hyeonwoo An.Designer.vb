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
        Me.Button1 = New System.Windows.Forms.Button()
        Me.lblmessage = New System.Windows.Forms.Label()
        Me.lblnumber = New System.Windows.Forms.Label()
        Me.lblfactor = New System.Windows.Forms.Label()
        Me.lblsquare = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(78, 64)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(119, 32)
        Me.Button1.TabIndex = 0
        Me.Button1.Text = "Start"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'lblmessage
        '
        Me.lblmessage.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblmessage.Location = New System.Drawing.Point(74, 162)
        Me.lblmessage.Name = "lblmessage"
        Me.lblmessage.Size = New System.Drawing.Size(182, 25)
        Me.lblmessage.TabIndex = 1
        '
        'lblnumber
        '
        Me.lblnumber.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblnumber.Location = New System.Drawing.Point(262, 162)
        Me.lblnumber.Name = "lblnumber"
        Me.lblnumber.Size = New System.Drawing.Size(66, 25)
        Me.lblnumber.TabIndex = 2
        '
        'lblfactor
        '
        Me.lblfactor.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblfactor.Location = New System.Drawing.Point(479, 162)
        Me.lblfactor.Name = "lblfactor"
        Me.lblfactor.Size = New System.Drawing.Size(66, 25)
        Me.lblfactor.TabIndex = 3
        '
        'lblsquare
        '
        Me.lblsquare.AutoSize = True
        Me.lblsquare.Location = New System.Drawing.Point(385, 214)
        Me.lblsquare.Name = "lblsquare"
        Me.lblsquare.Size = New System.Drawing.Size(0, 13)
        Me.lblsquare.TabIndex = 4
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(700, 502)
        Me.Controls.Add(Me.lblsquare)
        Me.Controls.Add(Me.lblfactor)
        Me.Controls.Add(Me.lblnumber)
        Me.Controls.Add(Me.lblmessage)
        Me.Controls.Add(Me.Button1)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents lblmessage As System.Windows.Forms.Label
    Friend WithEvents lblnumber As System.Windows.Forms.Label
    Friend WithEvents lblfactor As System.Windows.Forms.Label
    Friend WithEvents lblsquare As System.Windows.Forms.Label

End Class
