<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class Form4
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
        Dim resources As System.ComponentModel.ComponentResourceManager = New System.ComponentModel.ComponentResourceManager(GetType(Form4))
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label6 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.TextBox4 = New System.Windows.Forms.TextBox()
        Me.TextBox1 = New System.Windows.Forms.TextBox()
        Me.ComboBox7 = New System.Windows.Forms.ComboBox()
        Me.TextBox3 = New System.Windows.Forms.TextBox()
        Me.Label8 = New System.Windows.Forms.Label()
        Me.feedback = New System.Windows.Forms.Label()
        Me.TextBox2 = New System.Windows.Forms.TextBox()
        Me.Button2 = New System.Windows.Forms.Button()
        Me.SuspendLayout()
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Font = New System.Drawing.Font("Calibri", 20.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label1.ForeColor = System.Drawing.Color.White
        Me.Label1.Location = New System.Drawing.Point(21, 313)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(238, 33)
        Me.Label1.TabIndex = 4
        Me.Label1.Text = "...Help us improve..."
        '
        'Label6
        '
        Me.Label6.AutoSize = True
        Me.Label6.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label6.ForeColor = System.Drawing.Color.White
        Me.Label6.Location = New System.Drawing.Point(23, 371)
        Me.Label6.Name = "Label6"
        Me.Label6.Size = New System.Drawing.Size(70, 23)
        Me.Label6.TabIndex = 13
        Me.Label6.Text = "Name:*"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label3.ForeColor = System.Drawing.Color.White
        Me.Label3.Location = New System.Drawing.Point(23, 419)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(74, 23)
        Me.Label3.TabIndex = 14
        Me.Label3.Text = "E-mail:*"
        '
        'TextBox4
        '
        Me.TextBox4.Location = New System.Drawing.Point(111, 419)
        Me.TextBox4.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox4.Name = "TextBox4"
        Me.TextBox4.Size = New System.Drawing.Size(191, 20)
        Me.TextBox4.TabIndex = 20
        '
        'TextBox1
        '
        Me.TextBox1.Location = New System.Drawing.Point(111, 371)
        Me.TextBox1.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox1.Name = "TextBox1"
        Me.TextBox1.Size = New System.Drawing.Size(191, 20)
        Me.TextBox1.TabIndex = 21
        '
        'ComboBox7
        '
        Me.ComboBox7.FormattingEnabled = True
        Me.ComboBox7.Location = New System.Drawing.Point(134, 470)
        Me.ComboBox7.Name = "ComboBox7"
        Me.ComboBox7.Size = New System.Drawing.Size(41, 21)
        Me.ComboBox7.TabIndex = 34
        '
        'TextBox3
        '
        Me.TextBox3.Location = New System.Drawing.Point(183, 470)
        Me.TextBox3.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox3.Name = "TextBox3"
        Me.TextBox3.Size = New System.Drawing.Size(119, 20)
        Me.TextBox3.TabIndex = 33
        '
        'Label8
        '
        Me.Label8.AutoSize = True
        Me.Label8.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Label8.ForeColor = System.Drawing.Color.White
        Me.Label8.Location = New System.Drawing.Point(24, 471)
        Me.Label8.Name = "Label8"
        Me.Label8.Size = New System.Drawing.Size(104, 23)
        Me.Label8.TabIndex = 32
        Me.Label8.Text = "Mobile no:*"
        '
        'feedback
        '
        Me.feedback.AutoSize = True
        Me.feedback.Font = New System.Drawing.Font("Calibri", 14.25!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.feedback.ForeColor = System.Drawing.Color.White
        Me.feedback.Location = New System.Drawing.Point(340, 419)
        Me.feedback.Name = "feedback"
        Me.feedback.Size = New System.Drawing.Size(107, 23)
        Me.feedback.TabIndex = 35
        Me.feedback.Text = "Comments:*"
        '
        'TextBox2
        '
        Me.TextBox2.Location = New System.Drawing.Point(455, 371)
        Me.TextBox2.Margin = New System.Windows.Forms.Padding(5)
        Me.TextBox2.Multiline = True
        Me.TextBox2.Name = "TextBox2"
        Me.TextBox2.Size = New System.Drawing.Size(240, 123)
        Me.TextBox2.TabIndex = 36
        '
        'Button2
        '
        Me.Button2.BackColor = System.Drawing.Color.DarkRed
        Me.Button2.Cursor = System.Windows.Forms.Cursors.Default
        Me.Button2.Font = New System.Drawing.Font("Calibri", 12.75!, CType((System.Drawing.FontStyle.Bold Or System.Drawing.FontStyle.Italic), System.Drawing.FontStyle), System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.Button2.ForeColor = System.Drawing.Color.White
        Me.Button2.Location = New System.Drawing.Point(703, 410)
        Me.Button2.Name = "Button2"
        Me.Button2.Size = New System.Drawing.Size(125, 42)
        Me.Button2.TabIndex = 37
        Me.Button2.Text = "Send Feedback"
        Me.Button2.UseVisualStyleBackColor = False
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.BackColor = System.Drawing.Color.DarkRed
        Me.BackgroundImage = CType(resources.GetObject("$this.BackgroundImage"), System.Drawing.Image)
        Me.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch
        Me.ClientSize = New System.Drawing.Size(929, 520)
        Me.Controls.Add(Me.Button2)
        Me.Controls.Add(Me.TextBox2)
        Me.Controls.Add(Me.feedback)
        Me.Controls.Add(Me.ComboBox7)
        Me.Controls.Add(Me.TextBox3)
        Me.Controls.Add(Me.Label8)
        Me.Controls.Add(Me.TextBox1)
        Me.Controls.Add(Me.TextBox4)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label6)
        Me.Controls.Add(Me.Label1)
        Me.Name = "Form4"
        Me.Text = "Form4"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents Label1 As Label
    Friend WithEvents Label6 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents TextBox4 As TextBox
    Friend WithEvents TextBox1 As TextBox
    Friend WithEvents ComboBox7 As ComboBox
    Friend WithEvents TextBox3 As TextBox
    Friend WithEvents Label8 As Label
    Friend WithEvents feedback As Label
    Friend WithEvents TextBox2 As TextBox
    Friend WithEvents Button2 As Button
End Class
