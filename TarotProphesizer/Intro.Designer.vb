<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Intro
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Intro))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.IntroNextButton = New System.Windows.Forms.Label()
        Me.IntroInfo = New System.Windows.Forms.Label()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.Color.Transparent
        Me.Label1.Cursor = System.Windows.Forms.Cursors.Default
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 27.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label1.Location = New System.Drawing.Point(12, 9)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(462, 42)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "WELCOME ON BOARD!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label2
        '
        Me.Label2.BackColor = System.Drawing.Color.Transparent
        Me.Label2.Font = New System.Drawing.Font("Microsoft Sans Serif", 21.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.Label2.Location = New System.Drawing.Point(12, 60)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(923, 42)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "DO YOU WISH TO SET SAILS IN THE SEA OF DESTINY?"
        Me.Label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntroNextButton
        '
        Me.IntroNextButton.BackColor = System.Drawing.Color.Transparent
        Me.IntroNextButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.IntroNextButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.IntroNextButton.ForeColor = System.Drawing.Color.Lavender
        Me.IntroNextButton.Location = New System.Drawing.Point(912, 601)
        Me.IntroNextButton.Name = "IntroNextButton"
        Me.IntroNextButton.Size = New System.Drawing.Size(100, 30)
        Me.IntroNextButton.TabIndex = 2
        Me.IntroNextButton.Text = "START!"
        Me.IntroNextButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'IntroInfo
        '
        Me.IntroInfo.BackColor = System.Drawing.Color.Transparent
        Me.IntroInfo.Font = New System.Drawing.Font("Linux Libertine Display G", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.IntroInfo.Image = Global.TarotProphesizer.My.Resources.Resources.Parchment
        Me.IntroInfo.Location = New System.Drawing.Point(201, 102)
        Me.IntroInfo.Name = "IntroInfo"
        Me.IntroInfo.Size = New System.Drawing.Size(640, 540)
        Me.IntroInfo.TabIndex = 3
        Me.IntroInfo.Text = resources.GetString("IntroInfo.Text")
        Me.IntroInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Transparent
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Crimson
        Me.CloseButton.Location = New System.Drawing.Point(979, 9)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(33, 30)
        Me.CloseButton.TabIndex = 4
        Me.CloseButton.Text = "X"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Intro
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 640)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.IntroInfo)
        Me.Controls.Add(Me.IntroNextButton)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "Intro"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Card Oracle"
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents IntroNextButton As Label
    Friend WithEvents IntroInfo As Label
    Friend WithEvents CloseButton As Label
End Class
