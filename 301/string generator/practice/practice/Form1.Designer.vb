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
        Me.timer = New System.Windows.Forms.Timer(Me.components)
        Me.btnTimerStart = New System.Windows.Forms.Button()
        Me.lblTimer = New System.Windows.Forms.Label()
        Me.lblRandText = New System.Windows.Forms.Label()
        Me.lstOutput = New System.Windows.Forms.ListBox()
        Me.txtStrLen = New System.Windows.Forms.TextBox()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.ListBox1 = New System.Windows.Forms.ListBox()
        Me.lblCharacters = New System.Windows.Forms.Label()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.SuspendLayout()
        '
        'timer
        '
        '
        'btnTimerStart
        '
        Me.btnTimerStart.Location = New System.Drawing.Point(951, 260)
        Me.btnTimerStart.Margin = New System.Windows.Forms.Padding(6)
        Me.btnTimerStart.Name = "btnTimerStart"
        Me.btnTimerStart.Size = New System.Drawing.Size(150, 44)
        Me.btnTimerStart.TabIndex = 0
        Me.btnTimerStart.Text = "Start timer"
        Me.btnTimerStart.UseVisualStyleBackColor = True
        '
        'lblTimer
        '
        Me.lblTimer.AutoSize = True
        Me.lblTimer.Location = New System.Drawing.Point(1024, 194)
        Me.lblTimer.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblTimer.Name = "lblTimer"
        Me.lblTimer.Size = New System.Drawing.Size(59, 25)
        Me.lblTimer.TabIndex = 1
        Me.lblTimer.Text = "timer"
        '
        'lblRandText
        '
        Me.lblRandText.AutoSize = True
        Me.lblRandText.Location = New System.Drawing.Point(298, 44)
        Me.lblRandText.Margin = New System.Windows.Forms.Padding(6, 0, 6, 0)
        Me.lblRandText.Name = "lblRandText"
        Me.lblRandText.Size = New System.Drawing.Size(0, 25)
        Me.lblRandText.TabIndex = 2
        '
        'lstOutput
        '
        Me.lstOutput.FormattingEnabled = True
        Me.lstOutput.ItemHeight = 25
        Me.lstOutput.Location = New System.Drawing.Point(1461, 81)
        Me.lstOutput.Name = "lstOutput"
        Me.lstOutput.Size = New System.Drawing.Size(94, 604)
        Me.lstOutput.TabIndex = 3
        '
        'txtStrLen
        '
        Me.txtStrLen.Location = New System.Drawing.Point(983, 373)
        Me.txtStrLen.Name = "txtStrLen"
        Me.txtStrLen.Size = New System.Drawing.Size(100, 31)
        Me.txtStrLen.TabIndex = 4
        Me.txtStrLen.Text = "26"
        Me.txtStrLen.TextAlign = System.Windows.Forms.HorizontalAlignment.Center
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(920, 333)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(221, 25)
        Me.Label1.TabIndex = 5
        Me.Label1.Text = "number of characters:"
        '
        'ListBox1
        '
        Me.ListBox1.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable
        Me.ListBox1.FormattingEnabled = True
        Me.ListBox1.Location = New System.Drawing.Point(981, 491)
        Me.ListBox1.Name = "ListBox1"
        Me.ListBox1.Size = New System.Drawing.Size(120, 29)
        Me.ListBox1.TabIndex = 6
        '
        'lblCharacters
        '
        Me.lblCharacters.AutoSize = True
        Me.lblCharacters.Location = New System.Drawing.Point(727, 606)
        Me.lblCharacters.Name = "lblCharacters"
        Me.lblCharacters.Size = New System.Drawing.Size(124, 25)
        Me.lblCharacters.TabIndex = 8
        Me.lblCharacters.Text = "placeholder"
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 13.875!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(831, 81)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(430, 42)
        Me.lblTitle.TabIndex = 9
        Me.lblTitle.Text = "Random string generator"
        '
        'Form1
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(12.0!, 25.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(1600, 865)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.lblCharacters)
        Me.Controls.Add(Me.ListBox1)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.txtStrLen)
        Me.Controls.Add(Me.lstOutput)
        Me.Controls.Add(Me.lblRandText)
        Me.Controls.Add(Me.lblTimer)
        Me.Controls.Add(Me.btnTimerStart)
        Me.Margin = New System.Windows.Forms.Padding(6)
        Me.Name = "Form1"
        Me.Text = "Form1"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents timer As Timer
    Friend WithEvents btnTimerStart As Button
    Friend WithEvents lblTimer As Label
    Friend WithEvents lblRandText As Label
    Friend WithEvents lstOutput As ListBox
    Friend WithEvents txtStrLen As TextBox
    Friend WithEvents Label1 As Label
    Friend WithEvents ListBox1 As ListBox
    Friend WithEvents lblCharacters As Label
    Friend WithEvents lblTitle As Label
End Class
