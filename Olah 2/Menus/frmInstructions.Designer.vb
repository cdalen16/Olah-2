<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmInstructions
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmInstructions))
        Me.btnBackBroken = New System.Windows.Forms.Button()
        Me.lblOlah2 = New System.Windows.Forms.Label()
        Me.btnBack = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'btnBackBroken
        '
        Me.btnBackBroken.BackColor = System.Drawing.Color.Transparent
        Me.btnBackBroken.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBackBroken.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBackBroken.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBackBroken.Location = New System.Drawing.Point(566, 602)
        Me.btnBackBroken.Name = "btnBackBroken"
        Me.btnBackBroken.Size = New System.Drawing.Size(234, 61)
        Me.btnBackBroken.TabIndex = 34
        Me.btnBackBroken.Text = "Back"
        Me.btnBackBroken.UseVisualStyleBackColor = False
        '
        'lblOlah2
        '
        Me.lblOlah2.BackColor = System.Drawing.Color.Transparent
        Me.lblOlah2.Font = New System.Drawing.Font("Halo", 36.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblOlah2.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblOlah2.Location = New System.Drawing.Point(0, 0)
        Me.lblOlah2.Name = "lblOlah2"
        Me.lblOlah2.Size = New System.Drawing.Size(1366, 768)
        Me.lblOlah2.TabIndex = 35
        Me.lblOlah2.Text = resources.GetString("lblOlah2.Text")
        Me.lblOlah2.TextAlign = System.Drawing.ContentAlignment.TopCenter
        '
        'btnBack
        '
        Me.btnBack.BackColor = System.Drawing.Color.Transparent
        Me.btnBack.FlatStyle = System.Windows.Forms.FlatStyle.Flat
        Me.btnBack.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnBack.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.btnBack.Location = New System.Drawing.Point(415, 508)
        Me.btnBack.Name = "btnBack"
        Me.btnBack.Size = New System.Drawing.Size(234, 61)
        Me.btnBack.TabIndex = 36
        Me.btnBack.Text = "Back"
        Me.btnBack.UseVisualStyleBackColor = False
        '
        'frmInstructions
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackgroundImage = Global.Olah_2.My.Resources.Resources.Olah_2_City
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.btnBack)
        Me.Controls.Add(Me.lblOlah2)
        Me.Controls.Add(Me.btnBackBroken)
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmInstructions"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmInstructions"
        Me.TopMost = True
        Me.ResumeLayout(False)

    End Sub
    Friend WithEvents btnBackBroken As Button
    Friend WithEvents lblOlah2 As Label
    Friend WithEvents btnBack As Button
End Class
