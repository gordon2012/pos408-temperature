Public Class TemperatureConversion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUnit1.SelectedIndex = 1
        txtUnit2.Text = "C"
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim temperature As Double
        If Double.TryParse(txtTemp1.Text, temperature) Then
            If cmbUnit1.SelectedIndex = 0 Then
                txtTemp2.Text = (temperature * 9 / 5 + 32).ToString()
            Else
                txtTemp2.Text = ((temperature - 32) * 5 / 9).ToString()
            End If
        Else
            txtTemp1.Text = ""
            txtTemp2.Text = ""
        End If
    End Sub

    Private Sub cmbUnit1_SelectedIndexChanged(sender As Object, e As EventArgs) Handles cmbUnit1.SelectedIndexChanged
        txtTemp2.Text = ""
        If cmbUnit1.SelectedIndex = 0 Then
            txtUnit2.Text = "F"
        Else
            txtUnit2.Text = "C"
        End If
    End Sub
End Class
