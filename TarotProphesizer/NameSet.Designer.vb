<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class NameSet
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(NameSet))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.NameSetButton = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.Location = New System.Drawing.Point(12, 133)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(474, 33)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WHAT IS YOUR NAME SAILOR?"
        '
        'NameBox
        '
        Me.NameBox.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.NameBox.Location = New System.Drawing.Point(188, 163)
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(100, 26)
        Me.NameBox.TabIndex = 1
        Me.NameBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'NameSetButton
        '
        Me.NameSetButton.BackColor = System.Drawing.Color.Black
        Me.NameSetButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.NameSetButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.NameSetButton.ForeColor = System.Drawing.Color.Red
        Me.NameSetButton.Location = New System.Drawing.Point(198, 192)
        Me.NameSetButton.Name = "NameSetButton"
        Me.NameSetButton.Size = New System.Drawing.Size(79, 28)
        Me.NameSetButton.TabIndex = 2
        Me.NameSetButton.Text = "DONE!"
        Me.NameSetButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Black
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Crimson
        Me.CloseButton.Location = New System.Drawing.Point(979, 9)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(33, 30)
        Me.CloseButton.TabIndex = 25
        Me.CloseButton.Text = "X"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'NameSet
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.NameSetButton)
        Me.Controls.Add(Me.NameBox)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "NameSet"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Card Oracle"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents NameBox As TextBox
    Friend WithEvents NameSetButton As Label
    Friend WithEvents CloseButton As Label
End Class
