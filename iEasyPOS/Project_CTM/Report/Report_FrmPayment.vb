Public Class Report_FrmPayment
    Private Sub XrLabel2_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel2.BeforePrint
        Try
            XrLabel2.Text = Convert.ToDateTime(XrLabel2.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception
        End Try
    End Sub

    Private Sub XrLabel9_BeforePrint(sender As Object, e As Printing.PrintEventArgs) Handles XrLabel9.BeforePrint
        Try
            XrLabel9.Text = Convert.ToDateTime(XrLabel9.Text).ToString("dd/MM/yyyy", New System.Globalization.CultureInfo("en-US"))
        Catch ex As Exception
        End Try
    End Sub
End Class