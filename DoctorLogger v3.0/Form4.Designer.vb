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
        Me.Button5 = New System.Windows.Forms.Button
        Me.TextIcon = New System.Windows.Forms.TextBox
        Me.Label10 = New System.Windows.Forms.Label
        Me.Button1 = New System.Windows.Forms.Button
        Me.OpenFileDialog1 = New System.Windows.Forms.OpenFileDialog
        Me.CheckBox1 = New System.Windows.Forms.CheckBox
        Me.Label1 = New System.Windows.Forms.Label
        Me.SuspendLayout()
        '
        'Button5
        '
        Me.Button5.Enabled = False
        Me.Button5.ForeColor = System.Drawing.Color.Black
        Me.Button5.Location = New System.Drawing.Point(216, 53)
        Me.Button5.Name = "Button5"
        Me.Button5.Size = New System.Drawing.Size(64, 24)
        Me.Button5.TabIndex = 210
        Me.Button5.Text = "icone"
        Me.Button5.UseVisualStyleBackColor = True
        '
        'TextIcon
        '
        Me.TextIcon.Enabled = False
        Me.TextIcon.Location = New System.Drawing.Point(6, 53)
        Me.TextIcon.Name = "TextIcon"
        Me.TextIcon.Size = New System.Drawing.Size(204, 20)
        Me.TextIcon.TabIndex = 209
        '
        'Label10
        '
        Me.Label10.AutoSize = True
        Me.Label10.Location = New System.Drawing.Point(3, 36)
        Me.Label10.Name = "Label10"
        Me.Label10.Size = New System.Drawing.Size(67, 14)
        Me.Label10.TabIndex = 208
        Me.Label10.Text = "Novo icone :"
        '
        'Button1
        '
        Me.Button1.ForeColor = System.Drawing.Color.Black
        Me.Button1.Location = New System.Drawing.Point(118, 110)
        Me.Button1.Name = "Button1"
        Me.Button1.Size = New System.Drawing.Size(64, 24)
        Me.Button1.TabIndex = 216
        Me.Button1.Text = "OK"
        Me.Button1.UseVisualStyleBackColor = True
        '
        'OpenFileDialog1
        '
        Me.OpenFileDialog1.FileName = "OpenFileDialog1"
        '
        'CheckBox1
        '
        Me.CheckBox1.AutoSize = True
        Me.CheckBox1.Location = New System.Drawing.Point(6, 4)
        Me.CheckBox1.Name = "CheckBox1"
        Me.CheckBox1.Size = New System.Drawing.Size(104, 18)
        Me.CheckBox1.TabIndex = 217
        Me.CheckBox1.Text = "sim mudar icone"
        Me.CheckBox1.UseVisualStyleBackColor = True
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.ForeColor = System.Drawing.Color.Red
        Me.Label1.Location = New System.Drawing.Point(41, 90)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(206, 14)
        Me.Label1.TabIndex = 218
        Me.Label1.Text = "Nota * Este pode corromper seu servidor."
        '
        'Form4
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 14.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(292, 146)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.CheckBox1)
        Me.Controls.Add(Me.Button1)
        Me.Controls.Add(Me.Button5)
        Me.Controls.Add(Me.TextIcon)
        Me.Controls.Add(Me.Label10)
        Me.Font = New System.Drawing.Font("Arial", 8.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow
        Me.MaximizeBox = False
        Me.MinimizeBox = False
        Me.Name = "Form4"
        Me.ShowIcon = False
        Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
        Me.Text = "Trocar icone (teste)"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents Button5 As System.Windows.Forms.Button
    Friend WithEvents TextIcon As System.Windows.Forms.TextBox
    Friend WithEvents Label10 As System.Windows.Forms.Label
    Friend WithEvents Button1 As System.Windows.Forms.Button
    Friend WithEvents OpenFileDialog1 As System.Windows.Forms.OpenFileDialog
    Friend WithEvents CheckBox1 As System.Windows.Forms.CheckBox
    Friend WithEvents Label1 As System.Windows.Forms.Label
End Class
