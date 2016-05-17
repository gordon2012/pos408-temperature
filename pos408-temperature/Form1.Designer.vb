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
        Me.components = New System.ComponentModel.Container()
        Me.cmbUnit1 = New System.Windows.Forms.ComboBox()
        Me.txtTemp1 = New System.Windows.Forms.TextBox()
        Me.btnConvert = New System.Windows.Forms.Button()
        Me.lblTitle = New System.Windows.Forms.Label()
        Me.lblError = New System.Windows.Forms.Label()
        Me.lblTemp2 = New System.Windows.Forms.Label()
        Me.lblUnit2 = New System.Windows.Forms.Label()
        Me.tmrError = New System.Windows.Forms.Timer(Me.components)
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
        Me.cmbUnit1.TabIndex = 1
        '
        'txtTemp1
        '
        Me.txtTemp1.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.txtTemp1.Location = New System.Drawing.Point(18, 63)
        Me.txtTemp1.Name = "txtTemp1"
        Me.txtTemp1.Size = New System.Drawing.Size(107, 26)
        Me.txtTemp1.TabIndex = 0
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
        'lblError
        '
        Me.lblError.AutoSize = True
        Me.lblError.BackColor = System.Drawing.Color.Black
        Me.lblError.Font = New System.Drawing.Font("Microsoft Sans Serif", 9.75!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblError.ForeColor = System.Drawing.Color.Red
        Me.lblError.Location = New System.Drawing.Point(15, 182)
        Me.lblError.Name = "lblError"
        Me.lblError.Size = New System.Drawing.Size(0, 16)
        Me.lblError.TabIndex = 10
        '
        'lblTemp2
        '
        Me.lblTemp2.AutoSize = True
        Me.lblTemp2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblTemp2.Location = New System.Drawing.Point(181, 66)
        Me.lblTemp2.Name = "lblTemp2"
        Me.lblTemp2.Size = New System.Drawing.Size(57, 20)
        Me.lblTemp2.TabIndex = 11
        Me.lblTemp2.Text = "Label2"
        '
        'lblUnit2
        '
        Me.lblUnit2.AutoSize = True
        Me.lblUnit2.Font = New System.Drawing.Font("Microsoft Sans Serif", 12.0!, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, CType(0, Byte))
        Me.lblUnit2.Location = New System.Drawing.Point(313, 66)
        Me.lblUnit2.Name = "lblUnit2"
        Me.lblUnit2.Size = New System.Drawing.Size(20, 20)
        Me.lblUnit2.TabIndex = 12
        Me.lblUnit2.Text = "C"
        '
        'tmrError
        '
        Me.tmrError.Interval = 3000
        '
        'TemperatureConversion
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(361, 218)
        Me.Controls.Add(Me.lblUnit2)
        Me.Controls.Add(Me.lblTemp2)
        Me.Controls.Add(Me.lblError)
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
    Friend WithEvents lblError As System.Windows.Forms.Label
    Friend WithEvents lblTemp2 As System.Windows.Forms.Label
    Friend WithEvents lblUnit2 As System.Windows.Forms.Label
    Friend WithEvents tmrError As System.Windows.Forms.Timer

End Class
