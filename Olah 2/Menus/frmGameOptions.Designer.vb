<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmGameOptions
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
        Me.lblOlah2 = New System.Windows.Forms.Label()
        Me.btnTimeOrLives = New System.Windows.Forms.Button()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.txtTimeOrLives = New System.Windows.Forms.TextBox()
        Me.timBack = New System.Windows.Forms.Timer(Me.components)
        Me.SuspendLayout()
        '
        'lblOlah2
        '
        Me.lblOlah2.AutoSize = True
        Me.lblOlah2.BackColor = System.Drawing.Color.Transparent
        Me.lblOlah2.Font = New System.Drawing.Font("Halo", 69.74999!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlah2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblOlah2.Location = New System.Drawing.Point(-50, -50)
        Me.lblOlah2.Name = "lblOlah2"
        Me.lblOlah2.Size = New System.Drawing.Size(579, 192)
        Me.lblOlah2.TabIndex = 33
        Me.lblOlah2.Text = "" & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & Global.Microsoft.VisualBasic.ChrW(13) & Global.Microsoft.VisualBasic.ChrW(10) & "   Options"
        '
        'btnTimeOrLives
        '
        Me.btnTimeOrLives.BackColor = System.Drawing.Color.Transparent
        Me.btnTimeOrLives.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnTimeOrLives.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnTimeOrLives.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnTimeOrLives.Location = New System.Drawing.Point(339, 187)
        Me.btnTimeOrLives.Name = "btnTimeOrLives"
        Me.btnTimeOrLives.Size = New System.Drawing.Size(167, 61)
        Me.btnTimeOrLives.TabIndex = 35
        Me.btnTimeOrLives.Text = "Minutes"
        Me.btnTimeOrLives.TextAlign = System.Drawing.ContentAlignment.MiddleLeft
        Me.btnTimeOrLives.UseVisualStyleBackColor = False
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
        Me.btnBack.TabIndex = 34
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'txtTimeOrLives
        '
        Me.txtTimeOrLives.BackColor = System.Drawing.SystemColors.MenuHighlight
        Me.txtTimeOrLives.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle
        Me.txtTimeOrLives.Font = New System.Drawing.Font("Halo", 72.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTimeOrLives.ForeColor = System.Drawing.SystemColors.InactiveCaptionText
        Me.txtTimeOrLives.Location = New System.Drawing.Point(505, 187)
        Me.txtTimeOrLives.Multiline = True
        Me.txtTimeOrLives.Name = "txtTimeOrLives"
        Me.txtTimeOrLives.Size = New System.Drawing.Size(167, 61)
        Me.txtTimeOrLives.TabIndex = 37
        Me.txtTimeOrLives.Text = "3"
        Me.txtTimeOrLives.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'timBack
        '
        Me.timBack.Enabled = True
        Me.timBack.Interval = 1
        '
        'frmGameOptions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olah_2.My.Resources.Resources.Olah_2_City
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.txtTimeOrLives)
        Me.Controls.Add(Me.lblOlah2)
        Me.Controls.Add(Me.btnTimeOrLives)
        Me.Controls.Add(Me.btnBack)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmGameOptions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmGameOptions"
        Me.TopMost = True
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents lblOlah2 As Label
    Friend WithEvents btnTimeOrLives As Button
    Friend WithEvents btnBack As Button
    Friend WithEvents txtTimeOrLives As System.Windows.Forms.TextBox
    Friend WithEvents timBack As Timer
End Class
