<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Prophecy
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Prophecy))
        Me.ProphecyBox = New System.Windows.Forms.Label()
        Me.MiddleCard = New System.Windows.Forms.PictureBox()
        Me.RightCard = New System.Windows.Forms.PictureBox()
        Me.LeftCard = New System.Windows.Forms.PictureBox()
        Me.CloseButton = New System.Windows.Forms.Label()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        CType(Me.MiddleCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'ProphecyBox
        '
        Me.ProphecyBox.BackColor = System.Drawing.Color.Transparent
        Me.ProphecyBox.Font = New System.Drawing.Font("Palatino Linotype", 9.75!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.ProphecyBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.ProphecyBox.Location = New System.Drawing.Point(60, 40)
        Me.ProphecyBox.Margin = New System.Windows.Forms.Padding(0)
        Me.ProphecyBox.Name = "ProphecyBox"
        Me.ProphecyBox.Size = New System.Drawing.Size(536, 428)
        Me.ProphecyBox.TabIndex = 0
        Me.ProphecyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MiddleCard
        '
        Me.MiddleCard.Anchor = System.Windows.Forms.AnchorStyles.None
        Me.MiddleCard.BackColor = System.Drawing.Color.Transparent
        Me.MiddleCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MiddleCard.Location = New System.Drawing.Point(86, 229)
        Me.MiddleCard.Margin = New System.Windows.Forms.Padding(2)
        Me.MiddleCard.Name = "MiddleCard"
        Me.MiddleCard.Size = New System.Drawing.Size(209, 350)
        Me.MiddleCard.TabIndex = 6
        Me.MiddleCard.TabStop = False
        '
        'RightCard
        '
        Me.RightCard.Anchor = System.Windows.Forms.AnchorStyles.Right
        Me.RightCard.BackColor = System.Drawing.Color.Transparent
        Me.RightCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightCard.Location = New System.Drawing.Point(169, 11)
        Me.RightCard.Margin = New System.Windows.Forms.Padding(2)
        Me.RightCard.Name = "RightCard"
        Me.RightCard.Size = New System.Drawing.Size(209, 350)
        Me.RightCard.TabIndex = 5
        Me.RightCard.TabStop = False
        '
        'LeftCard
        '
        Me.LeftCard.Anchor = System.Windows.Forms.AnchorStyles.Left
        Me.LeftCard.BackColor = System.Drawing.Color.Transparent
        Me.LeftCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftCard.Location = New System.Drawing.Point(11, 407)
        Me.LeftCard.Margin = New System.Windows.Forms.Padding(2)
        Me.LeftCard.Name = "LeftCard"
        Me.LeftCard.Size = New System.Drawing.Size(209, 350)
        Me.LeftCard.TabIndex = 4
        Me.LeftCard.TabStop = False
        '
        'CloseButton
        '
        Me.CloseButton.BackColor = System.Drawing.Color.Black
        Me.CloseButton.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.CloseButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.CloseButton.ForeColor = System.Drawing.Color.Crimson
        Me.CloseButton.Location = New System.Drawing.Point(983, 9)
        Me.CloseButton.Name = "CloseButton"
        Me.CloseButton.Size = New System.Drawing.Size(33, 30)
        Me.CloseButton.TabIndex = 25
        Me.CloseButton.Text = "X"
        Me.CloseButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Label1
        '
        Me.Label1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.Label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D
        Me.Label1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(935, 728)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(77, 31)
        Me.Label1.TabIndex = 26
        Me.Label1.Text = "RETRY!"
        Me.Label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.Transparent
        Me.Panel1.BackgroundImage = Global.TarotProphesizer.My.Resources.Resources.Parchment
        Me.Panel1.Controls.Add(Me.ProphecyBox)
        Me.Panel1.Location = New System.Drawing.Point(383, 218)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(646, 507)
        Me.Panel1.TabIndex = 27
        '
        'Prophecy
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1024, 768)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CloseButton)
        Me.Controls.Add(Me.RightCard)
        Me.Controls.Add(Me.MiddleCard)
        Me.Controls.Add(Me.LeftCard)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Prophecy"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "The Card Oracle"
        CType(Me.MiddleCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.Panel1.ResumeLayout(False)
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents ProphecyBox As Label
    Friend WithEvents MiddleCard As PictureBox
    Friend WithEvents RightCard As PictureBox
    Friend WithEvents LeftCard As PictureBox
    Friend WithEvents CloseButton As Label
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel1 As Panel
End Class
