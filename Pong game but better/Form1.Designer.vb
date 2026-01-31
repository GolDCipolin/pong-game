<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Pong
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
        Me.components = New System.ComponentModel.Container()
        Me.Bat = New System.Windows.Forms.Button()
        Me.Ball = New System.Windows.Forms.Button()
        Me.Scorebox = New System.Windows.Forms.Label()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'Bat
        '
        Me.Bat.BackColor = System.Drawing.Color.DarkTurquoise
        Me.Bat.Location = New System.Drawing.Point(41, 500)
        Me.Bat.Name = "Bat"
        Me.Bat.Size = New System.Drawing.Size(100, 20)
        Me.Bat.TabIndex = 0
        Me.Bat.UseVisualStyleBackColor = False
        '
        'Ball
        '
        Me.Ball.Location = New System.Drawing.Point(374, 245)
        Me.Ball.Name = "Ball"
        Me.Ball.Size = New System.Drawing.Size(10, 10)
        Me.Ball.TabIndex = 1
        Me.Ball.UseVisualStyleBackColor = True
        '
        'Scorebox
        '
        Me.Scorebox.AutoSize = True
        Me.Scorebox.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Scorebox.ForeColor = System.Drawing.Color.White
        Me.Scorebox.Location = New System.Drawing.Point(391, 9)
        Me.Scorebox.Name = "Scorebox"
        Me.Scorebox.Size = New System.Drawing.Size(29, 31)
        Me.Scorebox.TabIndex = 2
        Me.Scorebox.Text = "0"
        '
        'Timer1
        '
        Me.Timer1.Interval = 70
        '
        'Pong
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.ForestGreen
        Me.ClientSize = New System.Drawing.Size(784, 561)
        Me.Controls.Add(Me.Scorebox)
        Me.Controls.Add(Me.Ball)
        Me.Controls.Add(Me.Bat)
        Me.Name = "Pong"
        Me.Text = "Pong"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Bat As Button
    Friend WithEvents Ball As Button
    Friend WithEvents Scorebox As Label
    Friend WithEvents Timer1 As Timer
End Class
