Public Class TemperatureConversion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUnit1.SelectedIndex = 1
        lblUnit2.Text = "C"
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim temperature As Double
        If Double.TryParse(txtTemp1.Text, temperature) Then
            If cmbUnit1.SelectedIndex = 0 Then
                lblTemp2.Text = (temperature * 9 / 5 + 32).ToString()
            Else
                lblTemp2.Text = ((temperature - 32) * 5 / 9).ToString()
            End If
        Else
            txtTemp1.ForeColor = Color.Red
            txtTemp1.BackColor = Color.Black
            lblError.Text = "Temperature not valid" + vbNewLine
            tmrError.Enabled = True
        End If
    End Sub

    Private Sub cmbUnit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnit1.SelectedIndexChanged
        lblTemp2.Text = ""
        If cmbUnit1.SelectedIndex = 0 Then
            lblUnit2.Text = "F"
        Else
            lblUnit2.Text = "C"
        End If
    End Sub

    Private Sub tmrError_Tick(sender As Object, e As EventArgs) Handles tmrError.Tick
        ClearError()
    End Sub

    Private Sub txtTemp1_Enter(sender As Object, e As EventArgs) Handles txtTemp1.Enter
        ClearError()
    End Sub

    Private Sub cmbUnit1_Enter(sender As Object, e As EventArgs) Handles cmbUnit1.Enter
        ClearError()
    End Sub

    Private Sub ClearError()
        txtTemp1.ForeColor = Color.Black
        txtTemp1.BackColor = Color.White
        lblError.Text = ""
        tmrError.Enabled = False
    End Sub
End Class
