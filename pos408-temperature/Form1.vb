Public Class TemperatureConversion
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        cmbUnit1.SelectedIndex = 0
        cmbUnit2.Selectedindex = 1
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        If cmbUnit1.SelectedIndex = 0 Then
            If cmbUnit2.SelectedIndex = 1 Then
                txtTemp2.Text = (Convert.ToDouble(txtTemp1.Text) * 9 / 5 + 32).ToString()
            Else
                txtTemp2.Text = txtTemp1.Text
            End If
        Else
            If cmbUnit2.SelectedIndex = 0 Then
                txtTemp2.Text = ((Convert.ToDouble(txtTemp1.Text) - 32) * 5 / 9).ToString()
            Else
                txtTemp2.Text = txtTemp1.Text
            End If
        End If
    End Sub
End Class
