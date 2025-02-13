Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        Me.TopMost = True
        zSanitizeTextboxes()
    End Sub

    Public Sub zSanitizeTextboxes()
        'zNumFilter()
        'txtPPM.Text = zNumFilter(txtPPM.Text)
        'txtNumMachines.Text = zNumFilter(txtNumMachines.Text)
        'txtCalcCubeBase.Text = zNumFilter(txtCalcCubeBase.Text)
        'txtNewIO.Text = zNumFilter(txtNewIO.Text)
        'txtConverted.Text = zNumFilter(txtConverted.Text)

        'trim leading zeros
        'which includes znumfilter

        'zTrimLeadingZero()
        txtPPM.Text = zTrimLeadingZero2(txtPPM.Text)
        txtNumMachines.Text = zTrimLeadingZero2(txtNumMachines.Text)
        txtCalcCubeBase.Text = zTrimLeadingZero2(txtCalcCubeBase.Text)
        txtNewIO.Text = zTrimLeadingZero2(txtNewIO.Text)
        txtConverted.Text = zTrimLeadingZero2(txtConverted.Text)

        If txtPPM.Text = "0" Then txtPPM.Text = "60"
        If txtNumMachines.Text = "0" Then txtNumMachines.Text = "15"
        If txtCalcCubeBase.Text = "0" Then txtCalcCubeBase.Text = "900"
        If txtNewIO.Text = "0" Then txtNewIO.Text = "540"
        If txtConverted.Text = "0" Then txtConverted.Text = "60"

        'txtPPM.Text
        'txtNumMachines.Text
        'txtCalcCubeBase.text
        'txtNewIO.Text
        'txtConverted.Text

        'trim the excess decimals if there are any
        txtPPM.Text = zTrimDecimals(txtPPM.Text)
        txtNumMachines.Text = zTrimDecimals(txtNumMachines.Text)
        txtCalcCubeBase.Text = zTrimDecimals(txtCalcCubeBase.Text)
        txtNewIO.Text = zTrimDecimals(txtNewIO.Text)
        txtConverted.Text = zTrimDecimals(txtConverted.Text)

        'these numbers are for a 15 x steel beam input setup
        'ppm
        '60
        'num machine
        '15
        'calculated cube base
        '900
        'new input
        '540
        'converted percent value for each machine
        '60

        If txtPPM.Text = vbNullString Then txtPPM.Text = "60"
        If txtNumMachines.Text = vbNullString Then txtNumMachines.Text = "15"
        If txtCalcCubeBase.Text = vbNullString Then txtCalcCubeBase.Text = "900"
        If txtNewIO.Text = vbNullString Then txtNewIO.Text = "540"
        If txtConverted.Text = vbNullString Then txtConverted.Text = "60"

        Dim zTempLen As Integer

        'txtPPM.Text = "60"
        'txtNumMachines.Text = "15"
        'txtCalcCubeBase.Text = "900"
        'txtNewIO.Text = "540"
        'txtConverted.Text = "60"

        'this checks to see if the number of digits from the sanitized number
        'is greater than 6

        'this prevents a crash from the number being some insane number
        'that breaks the integer limit

        zTempLen = Len(txtPPM.Text)
        If zTempLen > 9 Then
            txtPPM.Text = "60"
        End If
        zTempLen = Len(txtNumMachines.Text)
        If zTempLen > 9 Then
            txtNumMachines.Text = "15"
        End If
        zTempLen = Len(txtCalcCubeBase.Text)
        If zTempLen > 9 Then
            txtCalcCubeBase.Text = "900"
        End If
        zTempLen = Len(txtNewIO.Text)
        If zTempLen > 9 Then
            txtNewIO.Text = "540"
        End If
        zTempLen = Len(txtConverted.Text)
        If zTempLen > 9 Then
            txtConverted.Text = "60"
        End If

    End Sub

    Public Sub zCalcCube()
        zSanitizeTextboxes()
        'txtPPM.Text
        'txtNumMachines.Text
        'txtCalcCubeBase.text
        'txtNewIO.Text
        'txtConverted.Text

        'Dim zPPM As Integer
        Dim zPPM As Decimal
        'Dim zNumMachines As Integer
        Dim zNumMachines As Decimal
        'Dim zCalcCubeBase As Integer
        Dim zCalcCubeBase As Decimal
        'Dim zNewIO As Integer
        Dim zNewIO As Decimal
        'Dim zConverted As Integer
        Dim zConverted As Decimal

        'zPPM = CInt(txtPPM.Text)
        zPPM = CDec(txtPPM.Text)
        zNumMachines = CDec(txtNumMachines.Text)
        'zNumMachines = CInt(txtNumMachines.Text)
        'zCalcCubeBase = CInt(txtCalcCubeBase.Text)
        'zNewIO = CInt(txtNewIO.Text)
        zNewIO = CDec(txtNewIO.Text)
        'zConverted = CInt(txtConverted.Text)

        Dim zCubeBase As Integer

        zCalcCubeBase = zPPM * zNumMachines

        txtCalcCubeBase.Text = CStr(zCalcCubeBase)

        'Dim zCon2 As Decimal

        zConverted = (zNewIO / zCalcCubeBase) * 100

        Dim zTempDecimal As Decimal

        'zTempDecimal = Math.Truncate(zConverted)

        'txtConverted.Text = CStr(zConverted)

        zTempDecimal = Fix(zConverted * 10000) / 10000

        txtConverted.Text = CStr(zTempDecimal)

        Clipboard.Clear()
        Clipboard.SetText(txtConverted.Text)

    End Sub

    Private Sub btCalc_Click(sender As Object, e As EventArgs) Handles btCalc.Click
        zCalcCube()
    End Sub

    Private Sub txtPPM_TextChanged(sender As Object, e As EventArgs) Handles txtPPM.TextChanged

    End Sub

    Private Sub txtPPM_KeyUp(sender As Object, e As KeyEventArgs) Handles txtPPM.KeyUp
        If e.KeyCode = 13 Then
            zCalcCube()
        End If
    End Sub

    Private Sub txtNumMachines_TextChanged(sender As Object, e As EventArgs) Handles txtNumMachines.TextChanged

    End Sub

    Private Sub txtNumMachines_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNumMachines.KeyUp
        If e.KeyCode = 13 Then
            zCalcCube()
        End If
    End Sub

    Private Sub txtCalcCubeBase_TextChanged(sender As Object, e As EventArgs) Handles txtCalcCubeBase.TextChanged

    End Sub

    Private Sub txtCalcCubeBase_KeyUp(sender As Object, e As KeyEventArgs) Handles txtCalcCubeBase.KeyUp
        If e.KeyCode = 13 Then
            zCalcCube()
        End If
    End Sub

    Private Sub txtNewIO_TextChanged(sender As Object, e As EventArgs) Handles txtNewIO.TextChanged

    End Sub

    Private Sub txtNewIO_KeyUp(sender As Object, e As KeyEventArgs) Handles txtNewIO.KeyUp
        If e.KeyCode = 13 Then
            zCalcCube()
        End If
    End Sub

    Private Sub txtConverted_TextChanged(sender As Object, e As EventArgs) Handles txtConverted.TextChanged

    End Sub

    Private Sub txtConverted_KeyUp(sender As Object, e As KeyEventArgs) Handles txtConverted.KeyUp
        If e.KeyCode = 13 Then
            zCalcCube()
        End If
    End Sub

    Private Sub btDefault_Click(sender As Object, e As EventArgs) Handles btDefault.Click
        txtPPM.Text = "60"
        txtNumMachines.Text = "15"
        txtCalcCubeBase.Text = "900"
        txtNewIO.Text = "540"
        txtConverted.Text = "60"
    End Sub

    Private Sub lbAbout_Click(sender As Object, e As EventArgs) Handles lbAbout.Click
        'Dim zYTurl As String
        'zYTurl = "https://www.youtube.com/channel/UChdR92IoNqHnvXJ4hTwuwLg"
        'Clipboard.Clear()
        'Clipboard.SetText(zYTurl)
        'MsgBox(zYTurl & " has been copied to the clipboard.", vbOKOnly)
    End Sub

    Private Sub ckOnTop_CheckedChanged(sender As Object, e As EventArgs) Handles ckOnTop.CheckedChanged
        If ckOnTop.Checked = True Then
            Me.TopMost = True
        Else
            Me.TopMost = False
        End If
    End Sub

    Private Sub lbAbout_DoubleClick(sender As Object, e As EventArgs) Handles lbAbout.DoubleClick
        Dim zYTurl As String
        zYTurl = "https://www.youtube.com/channel/UChdR92IoNqHnvXJ4hTwuwLg"
        Clipboard.Clear()
        Clipboard.SetText(zYTurl)
        MsgBox(zYTurl & " has been copied to the clipboard.", vbOKOnly, "Machine Set Calculator by Vabbajack Sandvich")
    End Sub

    Private Sub btAbout_Click(sender As Object, e As EventArgs) Handles btAbout.Click
        Me.Hide()
        Form2.Show()
        Form2.Select()
    End Sub
End Class
