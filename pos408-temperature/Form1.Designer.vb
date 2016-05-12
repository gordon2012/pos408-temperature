<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class TemperatureConversion
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
        Me.cmbUnit1 = New System.Windows.Forms.ComboBox()
        Me.txtTemp1 = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.txtTemp2 = New System.Windows.Forms.TextBox()
        Me.txtUnit2 = New System.Windows.Forms.TextBox()
        Me.SuspendLayout()
        '
        'cmbUnit1
        '
        Me.cmbUnit1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList
        Me.cmbUnit1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.cmbUnit1.FormattingEnabled = True
        Me.cmbUnit1.Items.AddRange(New Object() {"C", "F"})
        Me.cmbUnit1.Location = New System.Drawing.Point(131, 63)
        Me.cmbUnit1.Name = "cmbUnit1"
        Me.cmbUnit1.Size = New System.Drawing.Size(41, 28)
        Me.cmbUnit1.TabIndex = 0
        '
        'txtTemp1
        '
        Me.txtTemp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp1.Location = New System.Drawing.Point(18, 63)
        Me.txtTemp1.Name = "txtTemp1"
        Me.txtTemp1.Size = New System.Drawing.Size(107, 26)
        Me.txtTemp1.TabIndex = 1
        '
        'btnConvert
        '
        Me.btnConvert.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.btnConvert.Location = New System.Drawing.Point(18, 113)
        Me.btnConvert.Name = "btnConvert"
        Me.btnConvert.Size = New System.Drawing.Size(315, 48)
        Me.btnConvert.TabIndex = 2
        Me.btnConvert.Text = "Convert"
        Me.btnConvert.UseVisualStyleBackColor = True
        '
        'lblTitle
        '
        Me.lblTitle.AutoSize = True
        Me.lblTitle.Font = New System.Drawing.Font("Microsoft Sans Serif", 20.25!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTitle.Location = New System.Drawing.Point(12, 9)
        Me.lblTitle.Name = "lblTitle"
        Me.lblTitle.Size = New System.Drawing.Size(314, 31)
        Me.lblTitle.TabIndex = 7
        Me.lblTitle.Text = "Temperature Conversion"
        '
        'txtTemp2
        '
        Me.txtTemp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp2.Location = New System.Drawing.Point(185, 63)
        Me.txtTemp2.Name = "txtTemp2"
        Me.txtTemp2.ReadOnly = True
        Me.txtTemp2.Size = New System.Drawing.Size(108, 26)
        Me.txtTemp2.TabIndex = 8
        '
        'txtUnit2
        '
        Me.txtUnit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtUnit2.Location = New System.Drawing.Point(299, 63)
        Me.txtUnit2.Name = "txtUnit2"
        Me.txtUnit2.ReadOnly = True
        Me.txtUnit2.Size = New System.Drawing.Size(34, 26)
        Me.txtUnit2.TabIndex = 9
        '
        'TemperatureConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 185)
        Me.Controls.Add(Me.txtUnit2)
        Me.Controls.Add(Me.txtTemp2)
        Me.Controls.Add(Me.lblTitle)
        Me.Controls.Add(Me.btnConvert)
        Me.Controls.Add(Me.txtTemp1)
        Me.Controls.Add(Me.cmbUnit1)
        Me.Name = "TemperatureConversion"
        Me.Text = "Temperature Conversion"
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub
    Friend WithEvents cmbUnit1 As System.Windows.Forms.ComboBox
    Friend WithEvents txtTemp1 As System.Windows.Forms.TextBox
    Friend WithEvents btnConvert As System.Windows.Forms.Button
    Friend WithEvents lblTitle As System.Windows.Forms.Label
    Friend WithEvents txtTemp2 As System.Windows.Forms.TextBox
    Friend WithEvents txtUnit2 As System.Windows.Forms.TextBox

End Class
