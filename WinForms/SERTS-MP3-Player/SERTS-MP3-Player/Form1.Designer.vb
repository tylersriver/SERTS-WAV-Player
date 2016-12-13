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
        Me.components = New System.ComponentModel.Container()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.playBtn = New System.Windows.Forms.Button()
        Me.TrackLabel = New System.Windows.Forms.Label()
        Me.TrackNames = New System.Windows.Forms.ListBox()
        Me.SerialPort1 = New System.IO.Ports.SerialPort(Me.components)
        Me.Button1 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label2
        '
        Me.Label2.AccessibleName = "currentTrack"
        Me.Label2.AutoSize = True
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(39, 38)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(0, 13)
        Me.Label2.TabIndex = 1
        '
        'playBtn
        '
        Me.playBtn.AccessibleName = "playBtn"
        Me.playBtn.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.playBtn.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.playBtn.Location = New System.Drawing.Point(132, 277)
        Me.playBtn.Name = "playBtn"
        Me.playBtn.Size = New System.Drawing.Size(75, 33)
        Me.playBtn.TabIndex = 2
        Me.playBtn.Text = "Play"
        Me.playBtn.UseVisualStyleBackColor = True
        '
        'TrackLabel
        '
        Me.TrackLabel.AutoSize = True
        Me.TrackLabel.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.TrackLabel.ForeColor = System.Drawing.Color.White
        Me.TrackLabel.Location = New System.Drawing.Point(13, 9)
        Me.TrackLabel.Name = "TrackLabel"
        Me.TrackLabel.Size = New System.Drawing.Size(76, 13)
        Me.TrackLabel.TabIndex = 0
        Me.TrackLabel.Text = "Track Name"
        '
        'TrackNames
        '
        Me.TrackNames.FormattingEnabled = True
        Me.TrackNames.Location = New System.Drawing.Point(16, 30)
        Me.TrackNames.Name = "TrackNames"
        Me.TrackNames.Size = New System.Drawing.Size(432, 225)
        Me.TrackNames.TabIndex = 8
        '
        'SerialPort1
        '
        Me.SerialPort1.PortName = "COM5"
        '
        'Button1
        '
        Me.Button1.AccessibleName = "pauseBtn"
        Me.Button1.Anchor = CType((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom), System.Windows.Forms.AnchorStyles)
        Me.Button1.Font = New System.Drawing.Font("Microsoft Sans Serif", 8.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button1.Location = New System.Drawing.Point(246, 277)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(75, 33)
        Me.Button1.TabIndex = 9
        Me.Button1.Text = "Pause"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(192, Byte), Integer))
        Me.ClientSize = New System.Drawing.Size(460, 322)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.TrackNames)
        Me.Controls.Add(Me.playBtn)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.TrackLabel)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Label2 As Label
    Friend WithEvents playBtn As Button
    Friend WithEvents TrackLabel As Label
    Friend WithEvents TrackNames As ListBox
    Friend WithEvents SerialPort1 As IO.Ports.SerialPort
    Friend WithEvents Button1 As Button
End Class
