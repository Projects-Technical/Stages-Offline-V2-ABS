<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class Form1
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form1))
        Me.txtJson = New System.Windows.Forms.TextBox()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.HelpToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.RestartToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.WebsiteToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SettingsToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.SendTestCommandToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.ToolStripTextBox1 = New System.Windows.Forms.ToolStripTextBox()
        Me.PictureBox1 = New System.Windows.Forms.PictureBox()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.jsonout = New System.Windows.Forms.TextBox()
        Me.WebBrowser1 = New System.Windows.Forms.WebBrowser()
        Me.Timer1 = New System.Windows.Forms.Timer(Me.components)
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.lblCstrt = New System.Windows.Forms.Label()
        Me.lblCnd = New System.Windows.Forms.Label()
        Me.lblrunclass = New System.Windows.Forms.Label()
        Me.lblrunjson = New System.Windows.Forms.Label()
        Me.MenuStrip1.SuspendLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'txtJson
        '
        Me.txtJson.Location = New System.Drawing.Point(416, 60)
        Me.txtJson.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.txtJson.Multiline = True
        Me.txtJson.Name = "txtJson"
        Me.txtJson.Size = New System.Drawing.Size(316, 406)
        Me.txtJson.TabIndex = 2
        '
        'MenuStrip1
        '
        Me.MenuStrip1.AutoSize = False
        Me.MenuStrip1.Dock = System.Windows.Forms.DockStyle.None
        Me.MenuStrip1.ImageScalingSize = New System.Drawing.Size(20, 20)
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.HelpToolStripMenuItem, Me.SettingsToolStripMenuItem, Me.SendTestCommandToolStripMenuItem, Me.ToolStripTextBox1})
        Me.MenuStrip1.Location = New System.Drawing.Point(-5, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Padding = New System.Windows.Forms.Padding(5, 1, 0, 1)
        Me.MenuStrip1.RightToLeft = System.Windows.Forms.RightToLeft.Yes
        Me.MenuStrip1.Size = New System.Drawing.Size(347, 23)
        Me.MenuStrip1.TabIndex = 4
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'HelpToolStripMenuItem
        '
        Me.HelpToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.RestartToolStripMenuItem, Me.WebsiteToolStripMenuItem})
        Me.HelpToolStripMenuItem.Name = "HelpToolStripMenuItem"
        Me.HelpToolStripMenuItem.Size = New System.Drawing.Size(44, 21)
        Me.HelpToolStripMenuItem.Text = "Help"
        '
        'RestartToolStripMenuItem
        '
        Me.RestartToolStripMenuItem.Name = "RestartToolStripMenuItem"
        Me.RestartToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.RestartToolStripMenuItem.Text = "Restart"
        '
        'WebsiteToolStripMenuItem
        '
        Me.WebsiteToolStripMenuItem.Name = "WebsiteToolStripMenuItem"
        Me.WebsiteToolStripMenuItem.Size = New System.Drawing.Size(116, 22)
        Me.WebsiteToolStripMenuItem.Text = "Website"
        '
        'SettingsToolStripMenuItem
        '
        Me.SettingsToolStripMenuItem.Name = "SettingsToolStripMenuItem"
        Me.SettingsToolStripMenuItem.Size = New System.Drawing.Size(61, 21)
        Me.SettingsToolStripMenuItem.Text = "Settings"
        '
        'SendTestCommandToolStripMenuItem
        '
        Me.SendTestCommandToolStripMenuItem.Name = "SendTestCommandToolStripMenuItem"
        Me.SendTestCommandToolStripMenuItem.Size = New System.Drawing.Size(128, 21)
        Me.SendTestCommandToolStripMenuItem.Text = "Send Test Command"
        '
        'ToolStripTextBox1
        '
        Me.ToolStripTextBox1.Name = "ToolStripTextBox1"
        Me.ToolStripTextBox1.ReadOnly = True
        Me.ToolStripTextBox1.Size = New System.Drawing.Size(68, 21)
        Me.ToolStripTextBox1.Text = "test"
        '
        'PictureBox1
        '
        Me.PictureBox1.Image = Global.StagesFlight_Test_New.My.Resources.Resources.New_HT_AV_Logo
        Me.PictureBox1.Location = New System.Drawing.Point(7, 23)
        Me.PictureBox1.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.PictureBox1.Name = "PictureBox1"
        Me.PictureBox1.Size = New System.Drawing.Size(323, 111)
        Me.PictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom
        Me.PictureBox1.TabIndex = 3
        Me.PictureBox1.TabStop = False
        '
        'ListBox1
        '
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(7, 140)
        Me.ListBox1.Margin = New System.Windows.Forms.Padding(1)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(326, 134)
        Me.ListBox1.TabIndex = 5
        '
        'jsonout
        '
        Me.jsonout.Location = New System.Drawing.Point(406, 248)
        Me.jsonout.Margin = New System.Windows.Forms.Padding(2)
        Me.jsonout.Multiline = True
        Me.jsonout.Name = "jsonout"
        Me.jsonout.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.jsonout.Size = New System.Drawing.Size(326, 246)
        Me.jsonout.TabIndex = 6
        '
        'WebBrowser1
        '
        Me.WebBrowser1.Location = New System.Drawing.Point(333, 325)
        Me.WebBrowser1.Margin = New System.Windows.Forms.Padding(2)
        Me.WebBrowser1.MinimumSize = New System.Drawing.Size(13, 13)
        Me.WebBrowser1.Name = "WebBrowser1"
        Me.WebBrowser1.Size = New System.Drawing.Size(13, 13)
        Me.WebBrowser1.TabIndex = 7
        '
        'Timer1
        '
        Me.Timer1.Enabled = True
        Me.Timer1.Interval = 1
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(379, 294)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(2)
        Me.TextBox1.Multiline = True
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.ScrollBars = System.Windows.Forms.ScrollBars.Vertical
        Me.TextBox1.Size = New System.Drawing.Size(326, 246)
        Me.TextBox1.TabIndex = 8
        '
        'lblCstrt
        '
        Me.lblCstrt.AutoSize = True
        Me.lblCstrt.ForeColor = System.Drawing.Color.White
        Me.lblCstrt.Location = New System.Drawing.Point(12, 37)
        Me.lblCstrt.Name = "lblCstrt"
        Me.lblCstrt.Size = New System.Drawing.Size(39, 13)
        Me.lblCstrt.TabIndex = 9
        Me.lblCstrt.Text = "Label1"
        Me.lblCstrt.Visible = False
        '
        'lblCnd
        '
        Me.lblCnd.AutoSize = True
        Me.lblCnd.ForeColor = System.Drawing.Color.White
        Me.lblCnd.Location = New System.Drawing.Point(12, 60)
        Me.lblCnd.Name = "lblCnd"
        Me.lblCnd.Size = New System.Drawing.Size(39, 13)
        Me.lblCnd.TabIndex = 10
        Me.lblCnd.Text = "Label1"
        Me.lblCnd.Visible = False
        '
        'lblrunclass
        '
        Me.lblrunclass.AutoSize = True
        Me.lblrunclass.ForeColor = System.Drawing.Color.White
        Me.lblrunclass.Location = New System.Drawing.Point(310, 121)
        Me.lblrunclass.Name = "lblrunclass"
        Me.lblrunclass.Size = New System.Drawing.Size(20, 13)
        Me.lblrunclass.TabIndex = 12
        Me.lblrunclass.Text = "V2"
        '
        'lblrunjson
        '
        Me.lblrunjson.AutoSize = True
        Me.lblrunjson.ForeColor = System.Drawing.Color.White
        Me.lblrunjson.Location = New System.Drawing.Point(83, 37)
        Me.lblrunjson.Name = "lblrunjson"
        Me.lblrunjson.Size = New System.Drawing.Size(39, 13)
        Me.lblrunjson.TabIndex = 11
        Me.lblrunjson.Text = "Label1"
        Me.lblrunjson.Visible = False
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.Black
        Me.ClientSize = New System.Drawing.Size(342, 281)
        Me.Controls.Add(Me.txtJson)
        Me.Controls.Add(Me.lblrunclass)
        Me.Controls.Add(Me.lblrunjson)
        Me.Controls.Add(Me.lblCnd)
        Me.Controls.Add(Me.lblCstrt)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.WebBrowser1)
        Me.Controls.Add(Me.jsonout)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.PictureBox1)
        Me.Controls.Add(Me.MenuStrip1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Margin = New System.Windows.Forms.Padding(2, 3, 2, 3)
        Me.MaximizeBox = False
        Me.MaximumSize = New System.Drawing.Size(358, 320)
        Me.MinimizeBox = False
        Me.MinimumSize = New System.Drawing.Size(358, 320)
        Me.Name = "Form1"
        Me.Text = "Hutchison Technologies - Stages Automation"
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        CType(Me.PictureBox1, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents txtJson As TextBox
    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents HelpToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents RestartToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents WebsiteToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SettingsToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents SendTestCommandToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents PictureBox1 As PictureBox
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents jsonout As TextBox
    Friend WithEvents WebBrowser1 As WebBrowser
    Friend WithEvents Timer1 As Timer
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ToolStripTextBox1 As ToolStripTextBox
    Friend WithEvents lblCstrt As Label
    Friend WithEvents lblCnd As Label
    Friend WithEvents lblrunclass As Label
    Friend WithEvents lblrunjson As Label
End Class
