<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class MainMenu
    Inherits Project_Aminka.Aminka.AminkaForm

    'Das Formular überschreibt den Löschvorgang, um die Komponentenliste zu bereinigen.
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

    'Wird vom Windows Form-Designer benötigt.
    Private components As System.ComponentModel.IContainer

    'Hinweis: Die folgende Prozedur ist für den Windows Form-Designer erforderlich.
    'Das Bearbeiten ist mit dem Windows Form-Designer möglich.  
    'Das Bearbeiten mit dem Code-Editor ist nicht möglich.
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(MainMenu))
        Me.AminkaControlSet1 = New Project_Aminka.Aminka.AminkaControlSet()
        Me.AminkaItemList1 = New Project_Aminka.AminkaItemList()
        Me.Panel5 = New System.Windows.Forms.Panel()
        Me.Panel16 = New System.Windows.Forms.Panel()
        Me.AminkaButton1 = New Project_Aminka.Aminka.AminkaButton()
        Me.AminkaButton2 = New Project_Aminka.Aminka.AminkaButton()
        Me.AminkaButton3 = New Project_Aminka.Aminka.AminkaButton()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Panel2 = New System.Windows.Forms.Panel()
        Me.AminkaButton4 = New Project_Aminka.Aminka.AminkaButton()
        Me.AminkaButton6 = New Project_Aminka.Aminka.AminkaButton()
        Me.Panel18 = New System.Windows.Forms.Panel()
        Me.tb_name1 = New System.Windows.Forms.TextBox()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Panel3 = New System.Windows.Forms.Panel()
        Me.Panel4 = New System.Windows.Forms.Panel()
        Me.tb_cd = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Panel6 = New System.Windows.Forms.Panel()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.AminkaButton7 = New Project_Aminka.Aminka.AminkaButton()
        Me.AminkaButton8 = New Project_Aminka.Aminka.AminkaButton()
        Me.Panel5.SuspendLayout()
        Me.Panel1.SuspendLayout()
        Me.Panel18.SuspendLayout()
        Me.Panel4.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'AminkaControlSet1
        '
        Me.AminkaControlSet1.ArrangeTo = Project_Aminka.Aminka.AminkaControlSet.arrangedir.Right
        Me.AminkaControlSet1.CloseButton = True
        Me.AminkaControlSet1.CloseButtonFont = New System.Drawing.Font("Marlett", 8.0!)
        Me.AminkaControlSet1.CloseButtonForeColor = System.Drawing.SystemColors.Control
        Me.AminkaControlSet1.CloseButtonText = "r"
        Me.AminkaControlSet1.Cursor = System.Windows.Forms.Cursors.Arrow
        Me.AminkaControlSet1.EnableApplicationExitOnCloseButton = True
        Me.AminkaControlSet1.GrayScale = True
        Me.AminkaControlSet1.GrayScaleColor = System.Drawing.Color.Empty
        Me.AminkaControlSet1.Location = New System.Drawing.Point(1024, 2)
        Me.AminkaControlSet1.MaximizeButton = True
        Me.AminkaControlSet1.MaximizeButtonColor = System.Drawing.SystemColors.Control
        Me.AminkaControlSet1.MaximizeButtonFont = New System.Drawing.Font("Marlett", 8.0!)
        Me.AminkaControlSet1.MaximizeButtonText = "2"
        Me.AminkaControlSet1.MinimizeButton = True
        Me.AminkaControlSet1.MinimizeButtonColor = System.Drawing.SystemColors.Control
        Me.AminkaControlSet1.MinimizeButtonFont = New System.Drawing.Font("Marlett", 8.0!)
        Me.AminkaControlSet1.MinimizeButtonText = "0"
        Me.AminkaControlSet1.Name = "AminkaControlSet1"
        Me.AminkaControlSet1.Size = New System.Drawing.Size(132, 33)
        Me.AminkaControlSet1.TabIndex = 0
        '
        'AminkaItemList1
        '
        Me.AminkaItemList1.Anchor = CType((((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AminkaItemList1.DEBUG_GraphicsRenderZones = False
        Me.AminkaItemList1.DEBUG_Mode = False
        Me.AminkaItemList1.DEBUG_ShowNumbers = False
        Me.AminkaItemList1.HighlightRadius = 247
        Me.AminkaItemList1.ItemColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.AminkaItemList1.ItemHeight = 100
        Me.AminkaItemList1.ItemHighlightColor = System.Drawing.Color.FromArgb(CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer), CType(CType(54, Byte), Integer))
        Me.AminkaItemList1.ItemRounded = 0
        Me.AminkaItemList1.Items.Add(CType(resources.GetObject("AminkaItemList1.Items"), Project_Aminka.AminkaItemListItem))
        Me.AminkaItemList1.ItemSpaceing = 10
        Me.AminkaItemList1.ItemWidth = 100
        Me.AminkaItemList1.Location = New System.Drawing.Point(12, 66)
        Me.AminkaItemList1.MinimumSize = New System.Drawing.Size(110, 110)
        Me.AminkaItemList1.Name = "AminkaItemList1"
        Me.AminkaItemList1.Size = New System.Drawing.Size(865, 553)
        Me.AminkaItemList1.TabIndex = 1
        Me.AminkaItemList1.Text = "AminkaItemList1"
        '
        'Panel5
        '
        Me.Panel5.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel5.BackColor = System.Drawing.Color.FromArgb(CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer), CType(CType(35, Byte), Integer))
        Me.Panel5.Controls.Add(Me.Panel16)
        Me.Panel5.Controls.Add(Me.Panel2)
        Me.Panel5.Location = New System.Drawing.Point(-3, 25)
        Me.Panel5.Name = "Panel5"
        Me.Panel5.Size = New System.Drawing.Size(1168, 23)
        Me.Panel5.TabIndex = 3
        '
        'Panel16
        '
        Me.Panel16.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel16.BackColor = System.Drawing.Color.FromArgb(CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer), CType(CType(42, Byte), Integer))
        Me.Panel16.Font = New System.Drawing.Font("Roboto Condensed", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Panel16.Location = New System.Drawing.Point(-4, -7)
        Me.Panel16.Name = "Panel16"
        Me.Panel16.Size = New System.Drawing.Size(1191, 18)
        Me.Panel16.TabIndex = 3
        '
        'AminkaButton1
        '
        Me.AminkaButton1.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AminkaButton1.Font = New System.Drawing.Font("Roboto Thin", 26.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AminkaButton1.Location = New System.Drawing.Point(965, 539)
        Me.AminkaButton1.Name = "AminkaButton1"
        Me.AminkaButton1.Size = New System.Drawing.Size(219, 54)
        Me.AminkaButton1.TabIndex = 154
        Me.AminkaButton1.Text = "CREATE ❱"
        Me.AminkaButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AminkaButton2
        '
        Me.AminkaButton2.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AminkaButton2.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AminkaButton2.Location = New System.Drawing.Point(895, 539)
        Me.AminkaButton2.Name = "AminkaButton2"
        Me.AminkaButton2.Size = New System.Drawing.Size(39, 37)
        Me.AminkaButton2.TabIndex = 156
        Me.AminkaButton2.Text = "⯅"
        Me.AminkaButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AminkaButton3
        '
        Me.AminkaButton3.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AminkaButton3.Font = New System.Drawing.Font("Roboto", 24.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.AminkaButton3.Location = New System.Drawing.Point(895, 582)
        Me.AminkaButton3.Name = "AminkaButton3"
        Me.AminkaButton3.Size = New System.Drawing.Size(39, 37)
        Me.AminkaButton3.TabIndex = 157
        Me.AminkaButton3.Text = "⯆"
        Me.AminkaButton3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel1
        '
        Me.Panel1.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Bottom) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.Panel1.Controls.Add(Me.AminkaButton6)
        Me.Panel1.Controls.Add(Me.PictureBox1)
        Me.Panel1.Controls.Add(Me.Panel4)
        Me.Panel1.Controls.Add(Me.Panel18)
        Me.Panel1.Controls.Add(Me.AminkaButton4)
        Me.Panel1.Location = New System.Drawing.Point(895, 67)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(237, 430)
        Me.Panel1.TabIndex = 158
        '
        'Panel2
        '
        Me.Panel2.Anchor = CType(((System.Windows.Forms.AnchorStyles.Top Or System.Windows.Forms.AnchorStyles.Left) _
            Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.Panel2.BackColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.Panel2.Location = New System.Drawing.Point(-3, -7)
        Me.Panel2.Name = "Panel2"
        Me.Panel2.Size = New System.Drawing.Size(1191, 23)
        Me.Panel2.TabIndex = 3
        '
        'AminkaButton4
        '
        Me.AminkaButton4.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AminkaButton4.Font = New System.Drawing.Font("Roboto Thin", 18.25!)
        Me.AminkaButton4.Location = New System.Drawing.Point(0, 399)
        Me.AminkaButton4.Name = "AminkaButton4"
        Me.AminkaButton4.Size = New System.Drawing.Size(237, 31)
        Me.AminkaButton4.TabIndex = 159
        Me.AminkaButton4.Text = "Remove"
        Me.AminkaButton4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AminkaButton6
        '
        Me.AminkaButton6.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AminkaButton6.Font = New System.Drawing.Font("Roboto Thin", 18.25!)
        Me.AminkaButton6.Location = New System.Drawing.Point(0, 358)
        Me.AminkaButton6.Name = "AminkaButton6"
        Me.AminkaButton6.Size = New System.Drawing.Size(237, 44)
        Me.AminkaButton6.TabIndex = 161
        Me.AminkaButton6.Text = "Edit"
        Me.AminkaButton6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'Panel18
        '
        Me.Panel18.Controls.Add(Me.tb_name1)
        Me.Panel18.Controls.Add(Me.Label3)
        Me.Panel18.Controls.Add(Me.Panel3)
        Me.Panel18.Location = New System.Drawing.Point(13, 212)
        Me.Panel18.Name = "Panel18"
        Me.Panel18.Size = New System.Drawing.Size(212, 51)
        Me.Panel18.TabIndex = 162
        '
        'tb_name1
        '
        Me.tb_name1.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tb_name1.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_name1.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_name1.ForeColor = System.Drawing.SystemColors.Window
        Me.tb_name1.Location = New System.Drawing.Point(-1, 0)
        Me.tb_name1.Name = "tb_name1"
        Me.tb_name1.ReadOnly = True
        Me.tb_name1.Size = New System.Drawing.Size(365, 20)
        Me.tb_name1.TabIndex = 1
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Roboto Thin", 12.0!)
        Me.Label3.ForeColor = System.Drawing.SystemColors.Window
        Me.Label3.Location = New System.Drawing.Point(-5, 32)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(53, 19)
        Me.Label3.TabIndex = 7
        Me.Label3.Text = "NAME"
        '
        'Panel3
        '
        Me.Panel3.BackColor = System.Drawing.SystemColors.Window
        Me.Panel3.Location = New System.Drawing.Point(-1, 26)
        Me.Panel3.Name = "Panel3"
        Me.Panel3.Size = New System.Drawing.Size(365, 3)
        Me.Panel3.TabIndex = 4
        '
        'Panel4
        '
        Me.Panel4.Controls.Add(Me.tb_cd)
        Me.Panel4.Controls.Add(Me.Label1)
        Me.Panel4.Controls.Add(Me.Panel6)
        Me.Panel4.Location = New System.Drawing.Point(13, 289)
        Me.Panel4.Name = "Panel4"
        Me.Panel4.Size = New System.Drawing.Size(212, 51)
        Me.Panel4.TabIndex = 163
        '
        'tb_cd
        '
        Me.tb_cd.BackColor = System.Drawing.Color.FromArgb(CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer), CType(CType(48, Byte), Integer))
        Me.tb_cd.BorderStyle = System.Windows.Forms.BorderStyle.None
        Me.tb_cd.Font = New System.Drawing.Font("Roboto", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.tb_cd.ForeColor = System.Drawing.SystemColors.Window
        Me.tb_cd.Location = New System.Drawing.Point(-1, 0)
        Me.tb_cd.Name = "tb_cd"
        Me.tb_cd.ReadOnly = True
        Me.tb_cd.Size = New System.Drawing.Size(365, 20)
        Me.tb_cd.TabIndex = 1
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Roboto Thin", 12.0!)
        Me.Label1.ForeColor = System.Drawing.SystemColors.Window
        Me.Label1.Location = New System.Drawing.Point(-5, 32)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(125, 19)
        Me.Label1.TabIndex = 7
        Me.Label1.Text = "CREATION DATE"
        '
        'Panel6
        '
        Me.Panel6.BackColor = System.Drawing.SystemColors.Window
        Me.Panel6.Location = New System.Drawing.Point(-1, 26)
        Me.Panel6.Name = "Panel6"
        Me.Panel6.Size = New System.Drawing.Size(365, 3)
        Me.Panel6.TabIndex = 4
        '
        'PictureBox1
        '
        Me.PictureBox1.BackColor = System.Drawing.Color.FromArgb(CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer), CType(CType(50, Byte), Integer))
        Me.PictureBox1.Location = New System.Drawing.Point(20, 10)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(196, 196)
        Me.PictureBox1.TabIndex = 164
        Me.PictureBox1.TabStop = False
        '
        'AminkaButton7
        '
        Me.AminkaButton7.Anchor = CType((System.Windows.Forms.AnchorStyles.Bottom Or System.Windows.Forms.AnchorStyles.Right), System.Windows.Forms.AnchorStyles)
        Me.AminkaButton7.Font = New System.Drawing.Font("Roboto Thin", 12.25!)
        Me.AminkaButton7.Location = New System.Drawing.Point(965, 597)
        Me.AminkaButton7.Name = "AminkaButton7"
        Me.AminkaButton7.Size = New System.Drawing.Size(228, 33)
        Me.AminkaButton7.TabIndex = 159
        Me.AminkaButton7.Text = "CREATE ATTACK ❱"
        Me.AminkaButton7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'AminkaButton8
        '
        Me.AminkaButton8.Font = New System.Drawing.Font("Roboto Thin", 12.25!)
        Me.AminkaButton8.Location = New System.Drawing.Point(144, 0)
        Me.AminkaButton8.Name = "AminkaButton8"
        Me.AminkaButton8.Size = New System.Drawing.Size(100, 33)
        Me.AminkaButton8.TabIndex = 160
        Me.AminkaButton8.Text = "Export"
        Me.AminkaButton8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter
        '
        'MainMenu
        '
        Me.__FormBorderStyle = Project_Aminka.Aminka.Style.FormBorderStyle.borderless
        Me.AccentColor = System.Drawing.Color.FromArgb(CType(CType(202, Byte), Integer), CType(CType(81, Byte), Integer), CType(CType(0, Byte), Integer))
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1157, 648)
        Me.Controls.Add(Me.AminkaButton8)
        Me.Controls.Add(Me.AminkaButton1)
        Me.Controls.Add(Me.AminkaButton7)
        Me.Controls.Add(Me.AminkaControlSet1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.AminkaButton3)
        Me.Controls.Add(Me.AminkaButton2)
        Me.Controls.Add(Me.Panel5)
        Me.Controls.Add(Me.AminkaItemList1)
        Me.Font = New System.Drawing.Font("Roboto", 8.25!)
        Me.ForeColor = System.Drawing.SystemColors.Control
        Me.MinimumSize = New System.Drawing.Size(1157, 648)
        Me.Name = "MainMenu"
        Me.ShowIcon = False
        Me.Style = Project_Aminka.Aminka.Style.Styles.darkO
        Me.Text = "Create a Pokefrom"
        Me.Panel5.ResumeLayout(False)
        Me.Panel1.ResumeLayout(False)
        Me.Panel18.ResumeLayout(False)
        Me.Panel18.PerformLayout()
        Me.Panel4.ResumeLayout(False)
        Me.Panel4.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)

    End Sub

    Friend WithEvents AminkaControlSet1 As Project_Aminka.Aminka.AminkaControlSet
    Friend WithEvents AminkaItemList1 As Project_Aminka.AminkaItemList
    Friend WithEvents Panel5 As Panel
    Friend WithEvents Panel16 As Panel
    Friend WithEvents AminkaButton1 As Project_Aminka.Aminka.AminkaButton
    Friend WithEvents AminkaButton2 As Project_Aminka.Aminka.AminkaButton
    Friend WithEvents AminkaButton3 As Project_Aminka.Aminka.AminkaButton
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Panel2 As Panel
    Friend WithEvents AminkaButton4 As Project_Aminka.Aminka.AminkaButton
    Friend WithEvents AminkaButton6 As Project_Aminka.Aminka.AminkaButton
    Friend WithEvents Panel18 As Panel
    Friend WithEvents tb_name1 As TextBox
    Friend WithEvents Label3 As Label
    Friend WithEvents Panel3 As Panel
    Friend WithEvents Panel4 As Panel
    Friend WithEvents tb_cd As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents Panel6 As Panel
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents AminkaButton7 As Project_Aminka.Aminka.AminkaButton
    Friend WithEvents AminkaButton8 As Project_Aminka.Aminka.AminkaButton
End Class
