<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmSettings
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(frmSettings))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.Label4 = New System.Windows.Forms.Label()
        Me.Label5 = New System.Windows.Forms.Label()
        Me.Panel1 = New System.Windows.Forms.Panel()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label7 = New System.Windows.Forms.Label()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.Label9 = New System.Windows.Forms.Label()
        Me.Button1 = New System.Windows.Forms.Button()
        Me.secret = New System.Windows.Forms.TextBox()
        Me.apiid = New System.Windows.Forms.TextBox()
        Me.apiusn = New System.Windows.Forms.TextBox()
        Me.autoip = New System.Windows.Forms.TextBox()
        Me.autoport = New System.Windows.Forms.TextBox()
        Me.ipadip = New System.Windows.Forms.TextBox()
        Me.startcmd = New System.Windows.Forms.TextBox()
        Me.endcmd = New System.Windows.Forms.TextBox()
        Me.Panel1.SuspendLayout()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(13, 23)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(99, 17)
        Me.Label1.TabIndex = 0
        Me.Label1.Text = "Automation IP:"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.ForeColor = System.Drawing.Color.White
        Me.Label2.Location = New System.Drawing.Point(12, 69)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(113, 17)
        Me.Label2.TabIndex = 1
        Me.Label2.Text = "Automation Port:"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(13, 118)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(56, 17)
        Me.Label3.TabIndex = 2
        Me.Label3.Text = "iPad IP:"
        '
        'Label4
        '
        Me.Label4.AutoSize = True
        Me.Label4.ForeColor = System.Drawing.Color.White
        Me.Label4.Location = New System.Drawing.Point(12, 168)
        Me.Label4.Name = "Label4"
        Me.Label4.Size = New System.Drawing.Size(76, 17)
        Me.Label4.TabIndex = 3
        Me.Label4.Text = "Start CMD:"
        '
        'Label5
        '
        Me.Label5.AutoSize = True
        Me.Label5.ForeColor = System.Drawing.Color.White
        Me.Label5.Location = New System.Drawing.Point(12, 218)
        Me.Label5.Name = "Label5"
        Me.Label5.Size = New System.Drawing.Size(71, 17)
        Me.Label5.TabIndex = 4
        Me.Label5.Text = "End CMD:"
        '
        'Panel1
        '
        Me.Panel1.BackColor = System.Drawing.Color.DimGray
        Me.Panel1.Controls.Add(Me.apiusn)
        Me.Panel1.Controls.Add(Me.apiid)
        Me.Panel1.Controls.Add(Me.secret)
        Me.Panel1.Controls.Add(Me.Label9)
        Me.Panel1.Controls.Add(Me.Label8)
        Me.Panel1.Controls.Add(Me.Label7)
        Me.Panel1.Controls.Add(Me.Label6)
        Me.Panel1.Location = New System.Drawing.Point(13, 254)
        Me.Panel1.Name = "Panel1"
        Me.Panel1.Size = New System.Drawing.Size(386, 161)
        Me.Panel1.TabIndex = 5
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(3, 2)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(165, 17)
        Me.Label6.TabIndex = 6
        Me.Label6.Text = "Stages API Configuration"
        '
        'Label7
        '
        Me.Label7.AutoSize = True
        Me.Label7.ForeColor = System.Drawing.Color.White
        Me.Label7.Location = New System.Drawing.Point(3, 43)
        Me.Label7.Name = "Label7"
        Me.Label7.Size = New System.Drawing.Size(53, 17)
        Me.Label7.TabIndex = 7
        Me.Label7.Text = "Secret:"
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(3, 82)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(50, 17)
        Me.Label8.TabIndex = 8
        Me.Label8.Text = "API ID:"
        '
        'Label9
        '
        Me.Label9.AutoSize = True
        Me.Label9.ForeColor = System.Drawing.Color.White
        Me.Label9.Location = New System.Drawing.Point(3, 125)
        Me.Label9.Name = "Label9"
        Me.Label9.Size = New System.Drawing.Size(66, 17)
        Me.Label9.TabIndex = 9
        Me.Label9.Text = "API USN:"
        '
        'Button1
        '
        Me.Button1.Location = New System.Drawing.Point(13, 422)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(386, 23)
        Me.Button1.TabIndex = 6
        Me.Button1.Text = "Save"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'secret
        '
        Me.secret.Location = New System.Drawing.Point(76, 42)
        Me.secret.Name = "secret"
        Me.secret.Size = New System.Drawing.Size(303, 22)
        Me.secret.TabIndex = 10
        '
        'apiid
        '
        Me.apiid.Location = New System.Drawing.Point(76, 82)
        Me.apiid.Name = "apiid"
        Me.apiid.Size = New System.Drawing.Size(303, 22)
        Me.apiid.TabIndex = 11
        '
        'apiusn
        '
        Me.apiusn.Location = New System.Drawing.Point(76, 122)
        Me.apiusn.Name = "apiusn"
        Me.apiusn.Size = New System.Drawing.Size(303, 22)
        Me.apiusn.TabIndex = 12
        '
        'autoip
        '
        Me.autoip.Location = New System.Drawing.Point(129, 20)
        Me.autoip.Name = "autoip"
        Me.autoip.Size = New System.Drawing.Size(270, 22)
        Me.autoip.TabIndex = 13
        '
        'autoport
        '
        Me.autoport.Location = New System.Drawing.Point(129, 69)
        Me.autoport.Name = "autoport"
        Me.autoport.Size = New System.Drawing.Size(270, 22)
        Me.autoport.TabIndex = 14
        '
        'ipadip
        '
        Me.ipadip.Location = New System.Drawing.Point(129, 118)
        Me.ipadip.Name = "ipadip"
        Me.ipadip.Size = New System.Drawing.Size(270, 22)
        Me.ipadip.TabIndex = 15
        '
        'startcmd
        '
        Me.startcmd.Location = New System.Drawing.Point(129, 168)
        Me.startcmd.Name = "startcmd"
        Me.startcmd.Size = New System.Drawing.Size(270, 22)
        Me.startcmd.TabIndex = 16
        '
        'endcmd
        '
        Me.endcmd.Location = New System.Drawing.Point(129, 218)
        Me.endcmd.Name = "endcmd"
        Me.endcmd.Size = New System.Drawing.Size(270, 22)
        Me.endcmd.TabIndex = 17
        '
        'frmSettings
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(8.0!, 16.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.SystemColors.ControlText
        Me.ClientSize = New System.Drawing.Size(411, 450)
        Me.Controls.Add(Me.endcmd)
        Me.Controls.Add(Me.startcmd)
        Me.Controls.Add(Me.ipadip)
        Me.Controls.Add(Me.autoport)
        Me.Controls.Add(Me.autoip)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Panel1)
        Me.Controls.Add(Me.Label5)
        Me.Controls.Add(Me.Label4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.Icon = CType(resources.GetObject("$this.Icon"), System.Drawing.Icon)
        Me.MaximumSize = New System.Drawing.Size(429, 497)
        Me.MinimumSize = New System.Drawing.Size(429, 497)
        Me.Name = "frmSettings"
        Me.Text = "Settings"
        Me.Panel1.ResumeLayout(False)
        Me.Panel1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents Label4 As Label
    Friend WithEvents Label5 As Label
    Friend WithEvents Panel1 As Panel
    Friend WithEvents Label9 As Label
    Friend WithEvents Label8 As Label
    Friend WithEvents Label7 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Button1 As Button
    Friend WithEvents apiusn As TextBox
    Friend WithEvents apiid As TextBox
    Friend WithEvents secret As TextBox
    Friend WithEvents autoip As TextBox
    Friend WithEvents autoport As TextBox
    Friend WithEvents ipadip As TextBox
    Friend WithEvents startcmd As TextBox
    Friend WithEvents endcmd As TextBox
End Class
