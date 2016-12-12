<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainWindow
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
        Me.TopPanel = New System.Windows.Forms.Panel()
        Me.DrawCardsButton = New System.Windows.Forms.Button()
        Me.NameBox = New System.Windows.Forms.TextBox()
        Me.BottomPanel = New System.Windows.Forms.Panel()
        Me.ProphecyBox = New System.Windows.Forms.Label()
        Me.MiddlePanel = New System.Windows.Forms.Panel()
        Me.MiddleCard = New System.Windows.Forms.PictureBox()
        Me.RightCard = New System.Windows.Forms.PictureBox()
        Me.LeftCard = New System.Windows.Forms.PictureBox()
        Me.TopPanel.SuspendLayout()
        Me.BottomPanel.SuspendLayout()
        Me.MiddlePanel.SuspendLayout()
        CType(Me.MiddleCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.RightCard, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.LeftCard, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'TopPanel
        '
        Me.TopPanel.BackColor = System.Drawing.Color.Transparent
        Me.TopPanel.Controls.Add(Me.DrawCardsButton)
        Me.TopPanel.Controls.Add(Me.NameBox)
        Me.TopPanel.Dock = System.Windows.Forms.DockStyle.Top
        Me.TopPanel.Location = New System.Drawing.Point(0, 0)
        Me.TopPanel.Name = "TopPanel"
        Me.TopPanel.Size = New System.Drawing.Size(1008, 37)
        Me.TopPanel.TabIndex = 0
        '
        'DrawCardsButton
        '
        Me.DrawCardsButton.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(161, Byte))
        Me.DrawCardsButton.Location = New System.Drawing.Point(930, 4)
        Me.DrawCardsButton.Name = "DrawCardsButton"
        Me.DrawCardsButton.Size = New System.Drawing.Size(75, 30)
        Me.DrawCardsButton.TabIndex = 1
        Me.DrawCardsButton.Text = "Draw"
        Me.DrawCardsButton.UseVisualStyleBackColor = True
        '
        'NameBox
        '
        Me.NameBox.Font = New System.Drawing.Font("Linux Libertine G", 12.0!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.NameBox.Location = New System.Drawing.Point(4, 4)
        Me.NameBox.Multiline = True
        Me.NameBox.Name = "NameBox"
        Me.NameBox.Size = New System.Drawing.Size(131, 30)
        Me.NameBox.TabIndex = 0
        Me.NameBox.Text = "Name"
        '
        'BottomPanel
        '
        Me.BottomPanel.BackColor = System.Drawing.Color.Transparent
        Me.BottomPanel.Controls.Add(Me.ProphecyBox)
        Me.BottomPanel.Dock = System.Windows.Forms.DockStyle.Bottom
        Me.BottomPanel.Location = New System.Drawing.Point(0, 597)
        Me.BottomPanel.Name = "BottomPanel"
        Me.BottomPanel.Size = New System.Drawing.Size(1008, 133)
        Me.BottomPanel.TabIndex = 2
        '
        'ProphecyBox
        '
        Me.ProphecyBox.BackColor = System.Drawing.Color.Transparent
        Me.ProphecyBox.Dock = System.Windows.Forms.DockStyle.Fill
        Me.ProphecyBox.Font = New System.Drawing.Font("Palatino Linotype", 14.25!, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.ProphecyBox.ForeColor = System.Drawing.Color.Azure
        Me.ProphecyBox.Location = New System.Drawing.Point(0, 0)
        Me.ProphecyBox.Margin = New System.Windows.Forms.Padding(10)
        Me.ProphecyBox.Name = "ProphecyBox"
        Me.ProphecyBox.Size = New System.Drawing.Size(1008, 133)
        Me.ProphecyBox.TabIndex = 0
        Me.ProphecyBox.Text = "Label1"
        Me.ProphecyBox.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MiddlePanel
        '
        Me.MiddlePanel.BackColor = System.Drawing.Color.Transparent
        Me.MiddlePanel.Controls.Add(Me.MiddleCard)
        Me.MiddlePanel.Controls.Add(Me.RightCard)
        Me.MiddlePanel.Controls.Add(Me.LeftCard)
        Me.MiddlePanel.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiddlePanel.Location = New System.Drawing.Point(0, 37)
        Me.MiddlePanel.Name = "MiddlePanel"
        Me.MiddlePanel.Size = New System.Drawing.Size(1008, 560)
        Me.MiddlePanel.TabIndex = 3
        '
        'MiddleCard
        '
        Me.MiddleCard.BackColor = System.Drawing.Color.Transparent
        Me.MiddleCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.MiddleCard.Dock = System.Windows.Forms.DockStyle.Fill
        Me.MiddleCard.Location = New System.Drawing.Point(336, 0)
        Me.MiddleCard.Margin = New System.Windows.Forms.Padding(0)
        Me.MiddleCard.Name = "MiddleCard"
        Me.MiddleCard.Size = New System.Drawing.Size(336, 560)
        Me.MiddleCard.TabIndex = 6
        Me.MiddleCard.TabStop = False
        '
        'RightCard
        '
        Me.RightCard.BackColor = System.Drawing.Color.Transparent
        Me.RightCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.RightCard.Dock = System.Windows.Forms.DockStyle.Right
        Me.RightCard.Location = New System.Drawing.Point(672, 0)
        Me.RightCard.Margin = New System.Windows.Forms.Padding(0)
        Me.RightCard.Name = "RightCard"
        Me.RightCard.Size = New System.Drawing.Size(336, 560)
        Me.RightCard.TabIndex = 5
        Me.RightCard.TabStop = False
        '
        'LeftCard
        '
        Me.LeftCard.BackColor = System.Drawing.Color.Transparent
        Me.LeftCard.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.LeftCard.Dock = System.Windows.Forms.DockStyle.Left
        Me.LeftCard.Location = New System.Drawing.Point(0, 0)
        Me.LeftCard.Margin = New System.Windows.Forms.Padding(0)
        Me.LeftCard.Name = "LeftCard"
        Me.LeftCard.Size = New System.Drawing.Size(336, 560)
        Me.LeftCard.TabIndex = 4
        Me.LeftCard.TabStop = False
        '
        'MainWindow
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.TarotProphesizer.My.Resources.Resources.Background
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1008, 730)
        Me.Controls.Add(Me.MiddlePanel)
        Me.Controls.Add(Me.BottomPanel)
        Me.Controls.Add(Me.TopPanel)
        Me.Name = "MainWindow"
        Me.Text = "The Card Oracle"
        Me.TopPanel.ResumeLayout(False)
        Me.TopPanel.PerformLayout()
        Me.BottomPanel.ResumeLayout(False)
        Me.MiddlePanel.ResumeLayout(False)
        CType(Me.MiddleCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.RightCard, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.LeftCard, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents TopPanel As Panel
    Friend WithEvents BottomPanel As Panel
    Friend WithEvents NameBox As TextBox
    Friend WithEvents DrawCardsButton As Button
    Friend WithEvents ProphecyBox As Label
    Friend WithEvents MiddlePanel As Panel
    Friend WithEvents MiddleCard As PictureBox
    Friend WithEvents RightCard As PictureBox
    Friend WithEvents LeftCard As PictureBox
End Class
