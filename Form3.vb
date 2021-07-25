Public Class Form3

    'Function to extract date of birth
    Public Function ExtractDOB() As String
        strIC = Form1.txtIc.Text
        Dim strDob As String, strDay As String, strMonth As String, strYear As String
        strDay = strIC.Substring(4, 2)
        strMonth = strIC.Substring(2, 2)
        Select Case strMonth
            Case "01"
                strMonth = "JANUARY"
            Case "02"
                strMonth = "FEBRUARY"
            Case "03"
                strMonth = "MARCH"
            Case "04"
                strMonth = "APRIL"
            Case "05"
                strMonth = "MAY"
            Case "06"
                strMonth = "JUNE"
            Case "07"
                strMonth = "JULY"
            Case "08"
                strMonth = "AUGUST"
            Case "09"
                strMonth = "SEPTEMBER"
            Case "10"
                strMonth = "OCTOBER"
            Case "11"
                strMonth = "NOVEMBER"
            Case "12"
                strMonth = "DECEMBER"
        End Select

        strYear = strIC.Substring(0, 2)
        If strYear < 50 Then
            strYear = "20" & strYear
        ElseIf strYear > 50 Then
            strYear = "19" & strYear
        End If

        strDob = strDay & " " & strMonth & " " & strYear
        Return strDob

    End Function

    'Function to extract place of birth (state in Malaysia)
    Public Function ExtractPB() As String
        strIC = Form1.txtIc.Text
        Dim strPbState As String
        Dim strPbCode As String = strIC.Substring(6, 2)
        Select Case strPbCode
            Case "01"
                strPbState = "JOHOR"
            Case "02"
                strPbState = "KEDAH"
            Case "03"
                strPbState = "KELANTAN"
            Case "04"
                strPbState = "MELAKA"
            Case "05"
                strPbState = "NEGERI SEMBILAN"
            Case "06"
                strPbState = "PAHANG"
            Case "07"
                strPbState = "PENANG"
            Case "08"
                strPbState = "PERAK"
            Case "09"
                strPbState = "PERLIS"
            Case "10"
                strPbState = "SELANGOR"
            Case "11"
                strPbState = "TERENGGANU"
            Case "12"
                strPbState = "SABAH"
            Case "13"
                strPbState = "SARAWAK"
            Case "14"
                strPbState = "FEDERAL TERRITORY OF KUALA LUMPUR"
            Case "15"
                strPbState = "FEDERAL TERRITORY OF LABUAN"
            Case "16"
                strPbState = "FEDERAL TERRITORY OF PUTRAJAYA"
            Case Else
                strPbState = "N/A"
        End Select
        Return strPbState

    End Function

    'Function to extract gender either male or female
    Public Function ExtractGender() As String
        strIC = Form1.txtIc.Text
        Dim strGender As String
        Dim strGenderCode As Integer = CInt(strIC.Substring(11, 1))
        If strGenderCode Mod 2 <> 0 Then
            strGender = "MALE"
        Else
            strGender = "FEMALE"
        End If
        Return strGender

    End Function

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        SaveFileDialog1.ShowDialog() 'to save ouput into file
    End Sub

    Private Sub btnPrint_Click(sender As Object, e As EventArgs) Handles btnPrint.Click
        PrintDialog1.ShowDialog() 'to print output
    End Sub

    Private Sub btnClose_Click(sender As Object, e As EventArgs) Handles btnClose.Click
        Me.Close() 'to close the personal information form
    End Sub
End Class