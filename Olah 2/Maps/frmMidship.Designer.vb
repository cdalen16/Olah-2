﻿<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMidship
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
        Me.timController1 = New System.Windows.Forms.Timer(Me.components)
        Me.timController2 = New System.Windows.Forms.Timer(Me.components)
        Me.timController3 = New System.Windows.Forms.Timer(Me.components)
        Me.timController4 = New System.Windows.Forms.Timer(Me.components)
        Me.timGrav = New System.Windows.Forms.Timer(Me.components)
        Me.timShootP1 = New System.Windows.Forms.Timer(Me.components)
        Me.timShootP2 = New System.Windows.Forms.Timer(Me.components)
        Me.timShootP3 = New System.Windows.Forms.Timer(Me.components)
        Me.timShootP4 = New System.Windows.Forms.Timer(Me.components)
        Me.timDeath = New System.Windows.Forms.Timer(Me.components)
        Me.lblCountdown = New System.Windows.Forms.Label()
        Me.timGameTime = New System.Windows.Forms.Timer(Me.components)
        Me.timJumpedP1 = New System.Windows.Forms.Timer(Me.components)
        Me.timJumpedP2 = New System.Windows.Forms.Timer(Me.components)
        Me.timJumpedP3 = New System.Windows.Forms.Timer(Me.components)
        Me.timJumpedP4 = New System.Windows.Forms.Timer(Me.components)
        Me.timLives = New System.Windows.Forms.Timer(Me.components)
        Me.lblP2Deaths = New System.Windows.Forms.Label()
        Me.lblP1Deaths = New System.Windows.Forms.Label()
        Me.lblP2Kills = New System.Windows.Forms.Label()
        Me.lblP1Kills = New System.Windows.Forms.Label()
        Me.lblP2Name = New System.Windows.Forms.Label()
        Me.lblP1Name = New System.Windows.Forms.Label()
        Me.lblP4Deaths = New System.Windows.Forms.Label()
        Me.lblP3Deaths = New System.Windows.Forms.Label()
        Me.lblP4Kills = New System.Windows.Forms.Label()
        Me.lblP3Kills = New System.Windows.Forms.Label()
        Me.lblP4Name = New System.Windows.Forms.Label()
        Me.lblP3Name = New System.Windows.Forms.Label()
        Me.picBottom = New System.Windows.Forms.PictureBox()
        Me.picP4Shot2 = New System.Windows.Forms.PictureBox()
        Me.picP3Shot2 = New System.Windows.Forms.PictureBox()
        Me.picP2Shot2 = New System.Windows.Forms.PictureBox()
        Me.picP1Shot2 = New System.Windows.Forms.PictureBox()
        Me.picP4Shot1 = New System.Windows.Forms.PictureBox()
        Me.picP3Shot1 = New System.Windows.Forms.PictureBox()
        Me.picP2Shot1 = New System.Windows.Forms.PictureBox()
        Me.picP1Shot1 = New System.Windows.Forms.PictureBox()
        Me.picSpawnBotRight = New System.Windows.Forms.PictureBox()
        Me.picSpawnBotLeft = New System.Windows.Forms.PictureBox()
        Me.picSpawnTopRight = New System.Windows.Forms.PictureBox()
        Me.picSpawnTopLeft = New System.Windows.Forms.PictureBox()
        Me.picBotLeft = New System.Windows.Forms.PictureBox()
        Me.picBotRight = New System.Windows.Forms.PictureBox()
        Me.picTopLeft = New System.Windows.Forms.PictureBox()
        Me.picTopRight = New System.Windows.Forms.PictureBox()
        Me.picBotSBlocker = New System.Windows.Forms.PictureBox()
        Me.picMidRight = New System.Windows.Forms.PictureBox()
        Me.picMidLeft = New System.Windows.Forms.PictureBox()
        Me.picTopSBlocker = New System.Windows.Forms.PictureBox()
        Me.timGameTimer = New System.Windows.Forms.Timer(Me.components)
        Me.lblGameTimer = New System.Windows.Forms.Label()
        Me.timKeyMove1 = New System.Windows.Forms.Timer(Me.components)
        Me.timKeyMove2 = New System.Windows.Forms.Timer(Me.components)
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP1Shot2, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP4Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP3Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP2Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picP1Shot1, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnBotRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnBotLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnTopRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picSpawnTopLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBotLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBotRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picBotSBlocker, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMidRight, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picMidLeft, System.ComponentModel.ISupportInitialize).BeginInit()
        CType(Me.picTopSBlocker, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'timController1
        '
        Me.timController1.Enabled = True
        Me.timController1.Interval = 10
        '
        'timController2
        '
        Me.timController2.Enabled = True
        Me.timController2.Interval = 10
        '
        'timController3
        '
        Me.timController3.Enabled = True
        Me.timController3.Interval = 10
        '
        'timController4
        '
        Me.timController4.Enabled = True
        Me.timController4.Interval = 10
        '
        'timGrav
        '
        Me.timGrav.Enabled = True
        Me.timGrav.Interval = 1
        '
        'timShootP1
        '
        Me.timShootP1.Enabled = True
        Me.timShootP1.Interval = 1
        '
        'timShootP2
        '
        Me.timShootP2.Enabled = True
        Me.timShootP2.Interval = 1
        '
        'timShootP3
        '
        Me.timShootP3.Enabled = True
        Me.timShootP3.Interval = 1
        '
        'timShootP4
        '
        Me.timShootP4.Enabled = True
        Me.timShootP4.Interval = 1
        '
        'timDeath
        '
        Me.timDeath.Enabled = True
        Me.timDeath.Interval = 35
        '
        'lblCountdown
        '
        Me.lblCountdown.BackColor = System.Drawing.Color.RoyalBlue
        Me.lblCountdown.Font = New System.Drawing.Font("Halo", 120.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblCountdown.ForeColor = System.Drawing.Color.Navy
        Me.lblCountdown.Location = New System.Drawing.Point(594, 255)
        Me.lblCountdown.Name = "lblCountdown"
        Me.lblCountdown.Size = New System.Drawing.Size(180, 111)
        Me.lblCountdown.TabIndex = 74
        Me.lblCountdown.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        Me.lblCountdown.Visible = False
        '
        'timGameTime
        '
        Me.timGameTime.Interval = 60000
        '
        'timJumpedP1
        '
        Me.timJumpedP1.Interval = 1
        '
        'timJumpedP2
        '
        Me.timJumpedP2.Interval = 1
        '
        'timJumpedP3
        '
        Me.timJumpedP3.Interval = 1
        '
        'timJumpedP4
        '
        Me.timJumpedP4.Interval = 1
        '
        'timLives
        '
        Me.timLives.Interval = 1
        '
        'lblP2Deaths
        '
        Me.lblP2Deaths.BackColor = System.Drawing.Color.Indigo
        Me.lblP2Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Deaths.Location = New System.Drawing.Point(293, 55)
        Me.lblP2Deaths.Name = "lblP2Deaths"
        Me.lblP2Deaths.Size = New System.Drawing.Size(182, 23)
        Me.lblP2Deaths.TabIndex = 147
        Me.lblP2Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP1Deaths
        '
        Me.lblP1Deaths.BackColor = System.Drawing.Color.Indigo
        Me.lblP1Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Deaths.Location = New System.Drawing.Point(12, 55)
        Me.lblP1Deaths.Name = "lblP1Deaths"
        Me.lblP1Deaths.Size = New System.Drawing.Size(166, 23)
        Me.lblP1Deaths.TabIndex = 146
        Me.lblP1Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP2Kills
        '
        Me.lblP2Kills.BackColor = System.Drawing.Color.Indigo
        Me.lblP2Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Kills.Location = New System.Drawing.Point(293, 32)
        Me.lblP2Kills.Name = "lblP2Kills"
        Me.lblP2Kills.Size = New System.Drawing.Size(182, 23)
        Me.lblP2Kills.TabIndex = 145
        Me.lblP2Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP1Kills
        '
        Me.lblP1Kills.BackColor = System.Drawing.Color.Indigo
        Me.lblP1Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Kills.Location = New System.Drawing.Point(12, 32)
        Me.lblP1Kills.Name = "lblP1Kills"
        Me.lblP1Kills.Size = New System.Drawing.Size(166, 23)
        Me.lblP1Kills.TabIndex = 144
        Me.lblP1Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP2Name
        '
        Me.lblP2Name.AutoSize = True
        Me.lblP2Name.BackColor = System.Drawing.Color.Indigo
        Me.lblP2Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP2Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP2Name.Location = New System.Drawing.Point(293, 9)
        Me.lblP2Name.Name = "lblP2Name"
        Me.lblP2Name.Size = New System.Drawing.Size(182, 23)
        Me.lblP2Name.TabIndex = 143
        Me.lblP2Name.Text = "Player 2"
        '
        'lblP1Name
        '
        Me.lblP1Name.AutoSize = True
        Me.lblP1Name.BackColor = System.Drawing.Color.Indigo
        Me.lblP1Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP1Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP1Name.Location = New System.Drawing.Point(12, 9)
        Me.lblP1Name.Name = "lblP1Name"
        Me.lblP1Name.Size = New System.Drawing.Size(166, 23)
        Me.lblP1Name.TabIndex = 142
        Me.lblP1Name.Text = "Player 1"
        '
        'lblP4Deaths
        '
        Me.lblP4Deaths.BackColor = System.Drawing.Color.Indigo
        Me.lblP4Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Deaths.Location = New System.Drawing.Point(1172, 58)
        Me.lblP4Deaths.Name = "lblP4Deaths"
        Me.lblP4Deaths.Size = New System.Drawing.Size(182, 23)
        Me.lblP4Deaths.TabIndex = 153
        Me.lblP4Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP3Deaths
        '
        Me.lblP3Deaths.BackColor = System.Drawing.Color.Indigo
        Me.lblP3Deaths.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Deaths.Location = New System.Drawing.Point(891, 58)
        Me.lblP3Deaths.Name = "lblP3Deaths"
        Me.lblP3Deaths.Size = New System.Drawing.Size(182, 23)
        Me.lblP3Deaths.TabIndex = 152
        Me.lblP3Deaths.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP4Kills
        '
        Me.lblP4Kills.BackColor = System.Drawing.Color.Indigo
        Me.lblP4Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Kills.Location = New System.Drawing.Point(1172, 35)
        Me.lblP4Kills.Name = "lblP4Kills"
        Me.lblP4Kills.Size = New System.Drawing.Size(182, 23)
        Me.lblP4Kills.TabIndex = 151
        Me.lblP4Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP3Kills
        '
        Me.lblP3Kills.BackColor = System.Drawing.Color.Indigo
        Me.lblP3Kills.Font = New System.Drawing.Font("Halo", 15.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Kills.Location = New System.Drawing.Point(891, 35)
        Me.lblP3Kills.Name = "lblP3Kills"
        Me.lblP3Kills.Size = New System.Drawing.Size(182, 23)
        Me.lblP3Kills.TabIndex = 150
        Me.lblP3Kills.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'lblP4Name
        '
        Me.lblP4Name.BackColor = System.Drawing.Color.Indigo
        Me.lblP4Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP4Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP4Name.Location = New System.Drawing.Point(1172, 12)
        Me.lblP4Name.Name = "lblP4Name"
        Me.lblP4Name.Size = New System.Drawing.Size(182, 23)
        Me.lblP4Name.TabIndex = 149
        Me.lblP4Name.Text = "Player 4"
        '
        'lblP3Name
        '
        Me.lblP3Name.AutoSize = True
        Me.lblP3Name.BackColor = System.Drawing.Color.Indigo
        Me.lblP3Name.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblP3Name.ForeColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblP3Name.Location = New System.Drawing.Point(891, 12)
        Me.lblP3Name.Name = "lblP3Name"
        Me.lblP3Name.Size = New System.Drawing.Size(182, 23)
        Me.lblP3Name.TabIndex = 148
        Me.lblP3Name.Text = "Player 3"
        '
        'picBottom
        '
        Me.picBottom.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBottom.Location = New System.Drawing.Point(0, 750)
        Me.picBottom.Name = "picBottom"
        Me.picBottom.Size = New System.Drawing.Size(1368, 26)
        Me.picBottom.TabIndex = 110
        Me.picBottom.TabStop = False
        '
        'picP4Shot2
        '
        Me.picP4Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP4Shot2.Location = New System.Drawing.Point(740, 45)
        Me.picP4Shot2.Name = "picP4Shot2"
        Me.picP4Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP4Shot2.TabIndex = 86
        Me.picP4Shot2.TabStop = False
        Me.picP4Shot2.Visible = False
        '
        'picP3Shot2
        '
        Me.picP3Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP3Shot2.Location = New System.Drawing.Point(690, 45)
        Me.picP3Shot2.Name = "picP3Shot2"
        Me.picP3Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP3Shot2.TabIndex = 85
        Me.picP3Shot2.TabStop = False
        Me.picP3Shot2.Visible = False
        '
        'picP2Shot2
        '
        Me.picP2Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP2Shot2.Location = New System.Drawing.Point(643, 45)
        Me.picP2Shot2.Name = "picP2Shot2"
        Me.picP2Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP2Shot2.TabIndex = 84
        Me.picP2Shot2.TabStop = False
        Me.picP2Shot2.Visible = False
        '
        'picP1Shot2
        '
        Me.picP1Shot2.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP1Shot2.Location = New System.Drawing.Point(603, 45)
        Me.picP1Shot2.Name = "picP1Shot2"
        Me.picP1Shot2.Size = New System.Drawing.Size(16, 10)
        Me.picP1Shot2.TabIndex = 83
        Me.picP1Shot2.TabStop = False
        Me.picP1Shot2.Visible = False
        '
        'picP4Shot1
        '
        Me.picP4Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP4Shot1.Location = New System.Drawing.Point(740, 12)
        Me.picP4Shot1.Name = "picP4Shot1"
        Me.picP4Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP4Shot1.TabIndex = 82
        Me.picP4Shot1.TabStop = False
        Me.picP4Shot1.Visible = False
        '
        'picP3Shot1
        '
        Me.picP3Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP3Shot1.Location = New System.Drawing.Point(690, 12)
        Me.picP3Shot1.Name = "picP3Shot1"
        Me.picP3Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP3Shot1.TabIndex = 81
        Me.picP3Shot1.TabStop = False
        Me.picP3Shot1.Visible = False
        '
        'picP2Shot1
        '
        Me.picP2Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP2Shot1.Location = New System.Drawing.Point(643, 12)
        Me.picP2Shot1.Name = "picP2Shot1"
        Me.picP2Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP2Shot1.TabIndex = 80
        Me.picP2Shot1.TabStop = False
        Me.picP2Shot1.Visible = False
        '
        'picP1Shot1
        '
        Me.picP1Shot1.BackColor = System.Drawing.SystemColors.ActiveCaptionText
        Me.picP1Shot1.Location = New System.Drawing.Point(603, 12)
        Me.picP1Shot1.Name = "picP1Shot1"
        Me.picP1Shot1.Size = New System.Drawing.Size(16, 10)
        Me.picP1Shot1.TabIndex = 79
        Me.picP1Shot1.TabStop = False
        Me.picP1Shot1.Visible = False
        '
        'picSpawnBotRight
        '
        Me.picSpawnBotRight.BackColor = System.Drawing.Color.Red
        Me.picSpawnBotRight.Location = New System.Drawing.Point(1021, 538)
        Me.picSpawnBotRight.Name = "picSpawnBotRight"
        Me.picSpawnBotRight.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnBotRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnBotRight.TabIndex = 78
        Me.picSpawnBotRight.TabStop = False
        '
        'picSpawnBotLeft
        '
        Me.picSpawnBotLeft.BackColor = System.Drawing.Color.Red
        Me.picSpawnBotLeft.Location = New System.Drawing.Point(268, 538)
        Me.picSpawnBotLeft.Name = "picSpawnBotLeft"
        Me.picSpawnBotLeft.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnBotLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnBotLeft.TabIndex = 77
        Me.picSpawnBotLeft.TabStop = False
        '
        'picSpawnTopRight
        '
        Me.picSpawnTopRight.BackColor = System.Drawing.Color.Red
        Me.picSpawnTopRight.Location = New System.Drawing.Point(1021, 178)
        Me.picSpawnTopRight.Name = "picSpawnTopRight"
        Me.picSpawnTopRight.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnTopRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnTopRight.TabIndex = 76
        Me.picSpawnTopRight.TabStop = False
        '
        'picSpawnTopLeft
        '
        Me.picSpawnTopLeft.BackColor = System.Drawing.Color.Red
        Me.picSpawnTopLeft.Location = New System.Drawing.Point(268, 178)
        Me.picSpawnTopLeft.Name = "picSpawnTopLeft"
        Me.picSpawnTopLeft.Size = New System.Drawing.Size(80, 77)
        Me.picSpawnTopLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage
        Me.picSpawnTopLeft.TabIndex = 75
        Me.picSpawnTopLeft.TabStop = False
        '
        'picBotLeft
        '
        Me.picBotLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBotLeft.Location = New System.Drawing.Point(220, 615)
        Me.picBotLeft.Name = "picBotLeft"
        Me.picBotLeft.Size = New System.Drawing.Size(180, 25)
        Me.picBotLeft.TabIndex = 73
        Me.picBotLeft.TabStop = False
        '
        'picBotRight
        '
        Me.picBotRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBotRight.Location = New System.Drawing.Point(970, 615)
        Me.picBotRight.Name = "picBotRight"
        Me.picBotRight.Size = New System.Drawing.Size(180, 25)
        Me.picBotRight.TabIndex = 72
        Me.picBotRight.TabStop = False
        '
        'picTopLeft
        '
        Me.picTopLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTopLeft.Location = New System.Drawing.Point(220, 255)
        Me.picTopLeft.Name = "picTopLeft"
        Me.picTopLeft.Size = New System.Drawing.Size(180, 25)
        Me.picTopLeft.TabIndex = 71
        Me.picTopLeft.TabStop = False
        '
        'picTopRight
        '
        Me.picTopRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTopRight.Location = New System.Drawing.Point(970, 255)
        Me.picTopRight.Name = "picTopRight"
        Me.picTopRight.Size = New System.Drawing.Size(180, 25)
        Me.picTopRight.TabIndex = 70
        Me.picTopRight.TabStop = False
        '
        'picBotSBlocker
        '
        Me.picBotSBlocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picBotSBlocker.Location = New System.Drawing.Point(517, 525)
        Me.picBotSBlocker.Name = "picBotSBlocker"
        Me.picBotSBlocker.Size = New System.Drawing.Size(324, 76)
        Me.picBotSBlocker.TabIndex = 69
        Me.picBotSBlocker.TabStop = False
        '
        'picMidRight
        '
        Me.picMidRight.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picMidRight.Location = New System.Drawing.Point(788, 375)
        Me.picMidRight.Name = "picMidRight"
        Me.picMidRight.Size = New System.Drawing.Size(180, 25)
        Me.picMidRight.TabIndex = 68
        Me.picMidRight.TabStop = False
        '
        'picMidLeft
        '
        Me.picMidLeft.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picMidLeft.Location = New System.Drawing.Point(400, 375)
        Me.picMidLeft.Name = "picMidLeft"
        Me.picMidLeft.Size = New System.Drawing.Size(180, 25)
        Me.picMidLeft.TabIndex = 67
        Me.picMidLeft.TabStop = False
        '
        'picTopSBlocker
        '
        Me.picTopSBlocker.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.picTopSBlocker.Location = New System.Drawing.Point(594, -6)
        Me.picTopSBlocker.Name = "picTopSBlocker"
        Me.picTopSBlocker.Size = New System.Drawing.Size(180, 225)
        Me.picTopSBlocker.TabIndex = 66
        Me.picTopSBlocker.TabStop = False
        '
        'timGameTimer
        '
        Me.timGameTimer.Interval = 1000
        '
        'lblGameTimer
        '
        Me.lblGameTimer.AutoSize = True
        Me.lblGameTimer.BackColor = System.Drawing.Color.FromArgb(CType(CType(0, Byte), Integer), CType(CType(0, Byte), Integer), CType(CType(64, Byte), Integer))
        Me.lblGameTimer.Font = New System.Drawing.Font("Halo", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblGameTimer.ForeColor = System.Drawing.SystemColors.MenuHighlight
        Me.lblGameTimer.Location = New System.Drawing.Point(622, 10)
        Me.lblGameTimer.Name = "lblGameTimer"
        Me.lblGameTimer.Size = New System.Drawing.Size(128, 23)
        Me.lblGameTimer.TabIndex = 154
        Me.lblGameTimer.Text = "0:00"
        Me.lblGameTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'timKeyMove1
        '
        Me.timKeyMove1.Enabled = True
        Me.timKeyMove1.Interval = 10
        '
        'timKeyMove2
        '
        Me.timKeyMove2.Enabled = True
        Me.timKeyMove2.Interval = 10
        '
        'frmMidship
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Indigo
        Me.ClientSize = New System.Drawing.Size(1366, 768)
        Me.Controls.Add(Me.lblGameTimer)
        Me.Controls.Add(Me.lblP4Deaths)
        Me.Controls.Add(Me.lblP3Deaths)
        Me.Controls.Add(Me.lblP4Kills)
        Me.Controls.Add(Me.lblP3Kills)
        Me.Controls.Add(Me.lblP4Name)
        Me.Controls.Add(Me.lblP3Name)
        Me.Controls.Add(Me.lblP2Deaths)
        Me.Controls.Add(Me.lblP1Deaths)
        Me.Controls.Add(Me.lblP2Kills)
        Me.Controls.Add(Me.lblP1Kills)
        Me.Controls.Add(Me.lblP2Name)
        Me.Controls.Add(Me.lblP1Name)
        Me.Controls.Add(Me.picBottom)
        Me.Controls.Add(Me.picP4Shot2)
        Me.Controls.Add(Me.picP3Shot2)
        Me.Controls.Add(Me.picP2Shot2)
        Me.Controls.Add(Me.picP1Shot2)
        Me.Controls.Add(Me.picP4Shot1)
        Me.Controls.Add(Me.picP3Shot1)
        Me.Controls.Add(Me.picP2Shot1)
        Me.Controls.Add(Me.picP1Shot1)
        Me.Controls.Add(Me.picSpawnBotRight)
        Me.Controls.Add(Me.picSpawnBotLeft)
        Me.Controls.Add(Me.picSpawnTopRight)
        Me.Controls.Add(Me.picSpawnTopLeft)
        Me.Controls.Add(Me.lblCountdown)
        Me.Controls.Add(Me.picBotLeft)
        Me.Controls.Add(Me.picBotRight)
        Me.Controls.Add(Me.picTopLeft)
        Me.Controls.Add(Me.picTopRight)
        Me.Controls.Add(Me.picBotSBlocker)
        Me.Controls.Add(Me.picMidRight)
        Me.Controls.Add(Me.picMidLeft)
        Me.Controls.Add(Me.picTopSBlocker)
        Me.Cursor = System.Windows.Forms.Cursors.No
        Me.DoubleBuffered = True
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None
        Me.Name = "frmMidship"
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "frmMidship"
        Me.TopMost = True
        CType(Me.picBottom, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP1Shot2, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP4Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP3Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP2Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picP1Shot1, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnBotRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnBotLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnTopRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picSpawnTopLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBotLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBotRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picBotSBlocker, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMidRight, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picMidLeft, System.ComponentModel.ISupportInitialize).EndInit()
        CType(Me.picTopSBlocker, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents timController1 As Timer
    Friend WithEvents timController2 As Timer
    Friend WithEvents timController3 As Timer
    Friend WithEvents timController4 As Timer
    Friend WithEvents timGrav As Timer
    Friend WithEvents timShootP1 As Timer
    Friend WithEvents timShootP2 As Timer
    Friend WithEvents timShootP3 As Timer
    Friend WithEvents timShootP4 As Timer
    Friend WithEvents timDeath As Timer
    Friend WithEvents picP4Shot2 As PictureBox
    Friend WithEvents picP3Shot2 As PictureBox
    Friend WithEvents picP2Shot2 As PictureBox
    Friend WithEvents picP1Shot2 As PictureBox
    Friend WithEvents picP4Shot1 As PictureBox
    Friend WithEvents picP3Shot1 As PictureBox
    Friend WithEvents picP2Shot1 As PictureBox
    Friend WithEvents picP1Shot1 As PictureBox
    Friend WithEvents picSpawnBotRight As PictureBox
    Friend WithEvents picSpawnBotLeft As PictureBox
    Friend WithEvents picSpawnTopRight As PictureBox
    Friend WithEvents picSpawnTopLeft As PictureBox
    Friend WithEvents picBotLeft As PictureBox
    Friend WithEvents picBotRight As PictureBox
    Friend WithEvents picTopLeft As PictureBox
    Friend WithEvents picTopRight As PictureBox
    Friend WithEvents picBotSBlocker As PictureBox
    Friend WithEvents picMidRight As PictureBox
    Friend WithEvents picMidLeft As PictureBox
    Friend WithEvents picTopSBlocker As PictureBox
    Friend WithEvents picBottom As PictureBox
    Friend WithEvents lblCountdown As Label
    Friend WithEvents timGameTime As Timer
    Friend WithEvents timJumpedP1 As Timer
    Friend WithEvents timJumpedP2 As Timer
    Friend WithEvents timJumpedP3 As Timer
    Friend WithEvents timJumpedP4 As Timer
    Friend WithEvents timLives As Timer
    Friend WithEvents lblP2Deaths As Label
    Friend WithEvents lblP1Deaths As Label
    Friend WithEvents lblP2Kills As Label
    Friend WithEvents lblP1Kills As Label
    Friend WithEvents lblP2Name As Label
    Friend WithEvents lblP1Name As Label
    Friend WithEvents lblP4Deaths As Label
    Friend WithEvents lblP3Deaths As Label
    Friend WithEvents lblP4Kills As Label
    Friend WithEvents lblP3Kills As Label
    Friend WithEvents lblP4Name As Label
    Friend WithEvents lblP3Name As Label
    Friend WithEvents timGameTimer As Timer
    Friend WithEvents lblGameTimer As Label
    Friend WithEvents timKeyMove1 As Timer
    Friend WithEvents timKeyMove2 As Timer
End Class
