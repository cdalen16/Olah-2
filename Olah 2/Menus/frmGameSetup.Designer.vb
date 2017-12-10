<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmGameSetup
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
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
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.components = New System.ComponentModel.Container()
        Me.lblOlah2 = New System.Windows.Forms.Label()
        Me.timPics = New System.Windows.Forms.Timer(Me.components)
        Me.picPlayer4 = New System.Windows.Forms.PictureBox()
        Me.picPlayer3 = New System.Windows.Forms.PictureBox()
        Me.picPlayer2 = New System.Windows.Forms.PictureBox()
        Me.picPlayer1 = New System.Windows.Forms.PictureBox()
        Me.btnStart = New System.Windows.Forms.Button()
        Me.btnOptions = New System.Windows.Forms.Button()
        Me.btnMap = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'lblOlah2
        '
        Me.lblOlah2.AutoSize = True
        Me.lblOlah2.BackColor = System.Drawing.Color.Transparent
        Me.lblOlah2.Font = New System.Drawing.Font("Halo", 150.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlah2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblOlah2.Location = New System.Drawing.Point(12, 9)
        Me.lblOlah2.Name = "lblOlah2"
        Me.lblOlah2.Size = New System.Drawing.Size(905, 137)
        Me.lblOlah2.TabIndex = 24
        Me.lblOlah2.Text = "Olah 2"
        '
        'timPics
        '
        Me.timPics.Enabled = True
        Me.timPics.Interval = 1
        '
        'picPlayer4
        '
        Me.picPlayer4.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPlayer4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer4.Location = New System.Drawing.Point(908, 300)
        Me.picPlayer4.Name = "picPlayer4"
        Me.picPlayer4.Size = New System.Drawing.Size(251, 328)
        Me.picPlayer4.TabIndex = 32
        Me.picPlayer4.TabStop = False
        '
        'picPlayer3
        '
        Me.picPlayer3.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPlayer3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer3.Location = New System.Drawing.Point(651, 300)
        Me.picPlayer3.Name = "picPlayer3"
        Me.picPlayer3.Size = New System.Drawing.Size(251, 328)
        Me.picPlayer3.TabIndex = 31
        Me.picPlayer3.TabStop = False
        '
        'picPlayer2
        '
        Me.picPlayer2.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPlayer2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer2.Location = New System.Drawing.Point(394, 300)
        Me.picPlayer2.Name = "picPlayer2"
        Me.picPlayer2.Size = New System.Drawing.Size(251, 328)
        Me.picPlayer2.TabIndex = 30
        Me.picPlayer2.TabStop = False
        '
        'picPlayer1
        '
        Me.picPlayer1.BackColor = System.Drawing.Color.Transparent
        Me.picPlayer1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center
        Me.picPlayer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.picPlayer1.Location = New System.Drawing.Point(137, 300)
        Me.picPlayer1.Name = "picPlayer1"
        Me.picPlayer1.Size = New System.Drawing.Size(251, 328)
        Me.picPlayer1.TabIndex = 29
        Me.picPlayer1.TabStop = False
        '
        'btnStart
        '
        Me.btnStart.BackColor = System.Drawing.Color.Transparent
        Me.btnStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnStart.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnStart.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnStart.Location = New System.Drawing.Point(819, 187)
        Me.btnStart.Name = "btnStart"
        Me.btnStart.Size = New System.Drawing.Size(234, 61)
        Me.btnStart.TabIndex = 28
        Me.btnStart.Text = "Start"
        Me.btnStart.UseVisualStyleBackColor = False
        '
        'btnOptions
        '
        Me.btnOptions.BackColor = System.Drawing.Color.Transparent
        Me.btnOptions.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnOptions.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnOptions.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnOptions.Location = New System.Drawing.Point(579, 187)
        Me.btnOptions.Name = "btnOptions"
        Me.btnOptions.Size = New System.Drawing.Size(234, 61)
        Me.btnOptions.TabIndex = 26
        Me.btnOptions.Text = "Options"
        Me.btnOptions.UseVisualStyleBackColor = False
        '
        'btnMap
        '
        Me.btnMap.BackColor = System.Drawing.Color.Transparent
        Me.btnMap.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnMap.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnMap.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnMap.Location = New System.Drawing.Point(339, 187)
        Me.btnMap.Name = "btnMap"
        Me.btnMap.Size = New System.Drawing.Size(234, 61)
        Me.btnMap.TabIndex = 25
        Me.btnMap.Text = "Map"
        Me.btnMap.UseVisualStyleBackColor = False
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBack.Location = New System.Drawing.Point(99, 187)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(234, 61)
        Me.btnBack.TabIndex = 33
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmGameSetup
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olah_2.My.Resources.Resources.Olah_2_City
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblOlah2)
        Me.Controls.Add(Me.picPlayer4)
        Me.Controls.Add(Me.picPlayer3)
        Me.Controls.Add(Me.picPlayer2)
        Me.Controls.Add(Me.picPlayer1)
        Me.Controls.Add(Me.btnStart)
        Me.Controls.Add(Me.btnOptions)
        Me.Controls.Add(Me.btnMap)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGameSetup"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Olah 2"
        Me.TopMost = True
        CType(Me.picPlayer4, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer3, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picPlayer1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOlah2 As Label
    Friend WithEvents timPics As Timer
    Friend WithEvents picPlayer4 As PictureBox
    Friend WithEvents picPlayer3 As PictureBox
    Friend WithEvents picPlayer2 As PictureBox
    Friend WithEvents picPlayer1 As PictureBox
    Friend WithEvents btnStart As Button
    Friend WithEvents btnOptions As Button
    Friend WithEvents btnMap As Button
    Friend WithEvents btnBack As Button
End Class
