Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        lblConversion.Text = ""
        radInchToMeter.Checked = True
        radMeterToInch.Checked = False
        txtValue.Clear()
        txtValue.Focus()
    End Sub

    Private Sub btnConvert_Click(sender As Object, e As EventArgs) Handles btnConvert.Click
        Dim decValue As Decimal
        Dim decConversion As Decimal = 39.3701D
        Dim decNewValue As Decimal
        Dim strFrom As String = ""
        Dim strTo As String = ""
        If IsNumeric(txtValue.Text) Then
            decValue = Convert.ToDecimal(txtValue.Text)
            If decValue > 0 Then
                If radInchToMeter.Checked Then
                    decNewValue = decValue / decConversion
                    strFrom = " inches "
                    strTo = " meters"
                ElseIf radMeterToInch.Checked Then
                    decNewValue = decValue * decConversion
                    strFrom = " meters "
                    strTo = " inches"
                End If
                lblConversion.Text = txtValue.Text & strFrom & "is " & decNewValue.ToString("F3") & strTo & "."
            Else
                MsgBox("Please enter a positive number over 0.", , "Invalid Entry")
            End If
        Else
            MsgBox("That is not a number. Please try again.", , "Invalid Entry")
        End If
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        lblConversion.Text = ""
        radInchToMeter.Checked = True
        radMeterToInch.Checked = False
        txtValue.Clear()
        txtValue.Focus()
    End Sub

    Private Sub btnExit_Click(sender As Object, e As EventArgs) Handles btnExit.Click
        Close()
    End Sub
End Class
