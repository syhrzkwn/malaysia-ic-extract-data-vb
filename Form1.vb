Public Class Form1
    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'to close the system
    End Sub

    Private Sub btnClear_Click(sender As Object, e As EventArgs) Handles btnClear.Click
        txtIc.Clear() 'to clear value in the text box

    End Sub

    'call the function ExtractDOB(), ExtractPB(), & ExtractGender() that have been declared in form3
    Private Sub btnExtract_Click(sender As Object, e As EventArgs) Handles btnExtract.Click
        If ValidateIcNumber() = False Then
            Form3.lblDob.Text = Form3.ExtractDOB()
            Form3.lblPB.Text = Form3.ExtractPB()
            Form3.lblGender.Text = Form3.ExtractGender()
            Form3.Show() 'to show form3
        End If
    End Sub

    'Function to validate NRIC
    Public Function ValidateIcNumber() As Boolean

        strIC = txtIc.Text
        If strIC.Length <> 12 Or IsNumeric(strIC) = False Then
            MessageBox.Show("Invalid NRIC", "User-Defined Error", MessageBoxButtons.OK, MessageBoxIcon.Error)

        End If
        Return False

    End Function

    'call the function ExtractDOB(), ExtractPB(), & ExtractGender() that have been declared in form3
    Private Sub ExtractToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ExtractToolStripMenuItem.Click
        If ValidateIcNumber() = False Then
            Form3.lblDob.Text = Form3.ExtractDOB()
            Form3.lblPB.Text = Form3.ExtractPB()
            Form3.lblGender.Text = Form3.ExtractGender()
            Form3.Show() 'to show form3

        End If
    End Sub

    Private Sub ClearToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles ClearToolStripMenuItem.Click
        txtIc.Clear() 'to clear value in the text box
    End Sub

    Private Sub CloseToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CloseToolStripMenuItem.Click
        Me.Close() 'to close the system
    End Sub

    'link label to tell user the NRIC required format to enter in the text box
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        MessageBox.Show("Please insert IC Number without dash ( - )", "NRIC Format", MessageBoxButtons.OK, MessageBoxIcon.Information)
    End Sub

    'to show form2 (software dev. details)
    Private Sub SoftwareDeveloperToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SoftwareDeveloperToolStripMenuItem.Click
        Form2.Show()
    End Sub

    'to show form4 (the information about the system)
    Private Sub SystemToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SystemToolStripMenuItem.Click
        Form4.Show()
    End Sub

    'to set the current live time and date
    Private Sub Timer1_Tick(sender As Object, e As EventArgs) Handles Timer1.Tick
        DateTime.Text = Date.Now.ToString("hh:mm tt dddd, dd MMMM yyyy")
    End Sub

    'to display the time & date
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.Timer1.Start()
    End Sub
End Class