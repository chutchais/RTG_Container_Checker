Imports System.Resources

Public Class frmSetting
    Dim resx As ResXResourceSet

    Private Sub frmSetting_Load(sender As Object, e As EventArgs) Handles Me.Load
        resx = New ResXResourceSet("resource1.resx")
        txtCameraIpR1.Text = resx.GetString("ip_r_1")
        txtCameraIpR2.Text = resx.GetString("ip_r_2")
        txtCameraIpL1.Text = resx.GetString("ip_l_1")
        txtCameraIpL2.Text = resx.GetString("ip_l_2")
    End Sub

    Private Sub btnSave_Click(sender As Object, e As EventArgs) Handles btnSave.Click
        Me.Close()
    End Sub

    Private Sub btnCancel_Click(sender As Object, e As EventArgs) Handles btnCancel.Click
        Me.Close()
    End Sub

    Private Sub btnCheckR1_Click(sender As Object, e As EventArgs) Handles btnCheckR1.Click
        lblResultR1.Text = "Checking..."
        lblResultR1.ForeColor = Color.Black
        Application.DoEvents()
        If My.Computer.Network.Ping(txtCameraIpR1.Text) Then
            lblResultR1.Text = "Connection is Good"
            lblResultR1.ForeColor = Color.Green
        Else
            lblResultR1.Text = "Connection is Failed"
            lblResultR1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnCheckR2_Click(sender As Object, e As EventArgs) Handles btnCheckR2.Click
        lblResultR2.Text = "Checking..."
        lblResultR2.ForeColor = Color.Black
        Application.DoEvents()
        If My.Computer.Network.Ping(txtCameraIpR2.Text) Then
            lblResultR2.Text = "Connection is Good"
            lblResultR2.ForeColor = Color.Green
        Else
            lblResultR2.Text = "Connection is Failed"
            lblResultR2.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnCheckL1_Click(sender As Object, e As EventArgs) Handles btnCheckL1.Click
        lblResultL1.Text = "Checking..."
        lblResultL1.ForeColor = Color.Black
        Application.DoEvents()
        If My.Computer.Network.Ping(txtCameraIpL1.Text) Then
            lblResultL1.Text = "Connection is Good"
            lblResultL1.ForeColor = Color.Green
        Else
            lblResultL1.Text = "Connection is Failed"
            lblResultL1.ForeColor = Color.Red
        End If
    End Sub

    Private Sub btnCheckL2_Click(sender As Object, e As EventArgs) Handles btnCheckL2.Click
        lblResultL2.Text = "Checking..."
        lblResultL2.ForeColor = Color.Black
        Application.DoEvents()
        If My.Computer.Network.Ping(txtCameraIpL2.Text) Then
            lblResultL2.Text = "Connection is Good"
            lblResultL2.ForeColor = Color.Green
        Else
            lblResultL2.Text = "Connection is Failed"
            lblResultL2.ForeColor = Color.Red
        End If
    End Sub
End Class