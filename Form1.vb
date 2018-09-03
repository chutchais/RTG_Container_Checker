Imports System.Net
Imports System.Reflection
Imports System.Resources

Public Class frmMain
    Dim vCameraIp_R_1 As String = "0"
    Dim vCameraIp_R_2 As String = "0"
    Dim vCameraIp_L_1 As String = "0"
    Dim vCameraIp_L_2 As String = "0"

    Dim vUser As String = ""
    Dim vPassword As String = ""
    Dim vChannel As String = ""

    Dim resx As ResXResourceSet

    Dim vToggleView As Boolean = True

    'Private Sub btnSwitch_Click(sender As Object, e As EventArgs) Handles btnSwitch.Click

    '    With AxVLCPluginR1
    '        .playlist.add("rtsp://gate:Gateview2018@" & vCameraIp_1 & "/Streaming/Channels/2")
    '        .playlist.playItem(0)
    '    End With

    '    With AxVLCPluginR2
    '        .playlist.add("rtsp://gate:Gateview2018@" & vCameraIp_2 & "/Streaming/Channels/2")
    '        .playlist.playItem(0)
    '    End With
    '    'AxVLCPlugin21.video.width = 760
    '    'AxVLCPlugin21.video.fullscreen = True
    '    'CPlugin21.video.aspectRatio = "16:9"  '    'AxVLCPlugin21.Width = 1024 'SplitContainer1.Panel1.Width
    '    ' AxVLCPlugin21.video.aspectRatio = "16:9" 'AxVLCPlugin21.Width + ":" + AxVLCPlugin21.Height
    '    'AxVLCPlugin21.Height = SplitContainer1.Panel1.Height
    'End Sub

    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles Me.Load
        reload_setting()
        initial_camera_platlist()

        play_camera(0) 'Play on low resolution

        Dim versionNumber As Version

        versionNumber = Assembly.GetExecutingAssembly().GetName().Version
        Me.Text = Me.Text & " version :" & versionNumber.ToString & "  (ip : " & GetIPv4Address() & ")"
    End Sub

    Private Function GetIPv4Address() As String
        GetIPv4Address = String.Empty
        Dim strHostName As String = System.Net.Dns.GetHostName()
        Dim iphe As System.Net.IPHostEntry = System.Net.Dns.GetHostEntry(strHostName)

        For Each ipheal As System.Net.IPAddress In iphe.AddressList
            If ipheal.AddressFamily = System.Net.Sockets.AddressFamily.InterNetwork Then
                If ipheal.ToString() <> "192.168.1.10" Then
                    GetIPv4Address = ipheal.ToString()
                    Exit For
                End If

            End If
        Next




    End Function

    Private Sub initial_camera_platlist()
        With AxVLCPluginSea1
            'Stream for mutiple view (low res)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_1 & "/Streaming/Channels/" & vChannel)
            'Straem for full HD
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_1 & "/Streaming/Channels/1")
        End With

        With AxVLCPluginSea2
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_2 & "/Streaming/Channels/" & vChannel)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_2 & "/Streaming/Channels/1")
        End With

        'On Bottom Camera
        With AxVLCPluginLand1
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_1 & "/Streaming/Channels/" & vChannel)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_1 & "/Streaming/Channels/1")

        End With

        With AxVLCPluginLand2
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_2 & "/Streaming/Channels/" & vChannel)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_2 & "/Streaming/Channels/1")
        End With
    End Sub

    Private Sub play_camera(Optional playlistIndex As Integer = 0)
        'On Top Camera

        With AxVLCPluginSea1
            .playlist.playItem(playlistIndex)
        End With

        With AxVLCPluginSea2
            .playlist.playItem(playlistIndex)
        End With

        'On Bottom Camera
        With AxVLCPluginLand1
            .playlist.playItem(playlistIndex)

        End With

        With AxVLCPluginLand2
            .playlist.playItem(playlistIndex)
        End With
        ''On Top Camera

        'With AxVLCPluginR1
        '    .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_1 & "/Streaming/Channels/" & vChannel)
        '    .playlist.playItem(0)
        'End With

        'With AxVLCPluginR2
        '    .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_2 & "/Streaming/Channels/" & vChannel)
        '    .playlist.playItem(0)
        'End With

        ''On Bottom Camera
        'With AxVLCPluginL1
        '    .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_1 & "/Streaming/Channels/" & vChannel)
        '    .playlist.playItem(0)

        'End With

        'With AxVLCPluginL2
        '    .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_2 & "/Streaming/Channels/" & vChannel)
        '    .playlist.playItem(0)
        'End With

    End Sub
    Private Sub reload_setting()
        resx = New ResXResourceSet("resource1.resx")
        vCameraIp_R_1 = resx.GetString("ip_r_1")
        vCameraIp_R_2 = resx.GetString("ip_r_2")
        vCameraIp_L_1 = resx.GetString("ip_l_1")
        vCameraIp_L_2 = resx.GetString("ip_l_2")
        vUser = resx.GetString("user")
        vPassword = resx.GetString("password")
        vChannel = resx.GetString("channel")
    End Sub

    Public Function ScreenResolution() As String
        Dim intX As Integer = Screen.PrimaryScreen.Bounds.Width
        Dim intY As Integer = Screen.PrimaryScreen.Bounds.Height
        Return intX & " × " & intY
    End Function

    Private Sub CenterToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles CenterToolStripMenuItem.Click
        show_all_side()
    End Sub



    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        frmSetting.ShowDialog()
        'reload_setting()
        'reload_camera()
    End Sub

    Private Sub SeaSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SeaSideToolStripMenuItem.Click
        show_sea_side()
    End Sub

    Sub show_all_side()
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = False

        Dim playlistIndex As Integer = 0 'Low resolution
        AxVLCPluginSea1.playlist.playItem(playlistIndex)
        AxVLCPluginSea2.playlist.playItem(playlistIndex)
        AxVLCPluginLand1.playlist.playItem(playlistIndex)
        AxVLCPluginLand2.playlist.playItem(playlistIndex)
    End Sub
    Sub show_sea_side()

        SplitContainer1.Panel1Collapsed = False 'Show sea
        SplitContainer1.Panel2Collapsed = True   'Hide land

        'Enable Sea side (11,12)
        AxVLCPluginSea1.playlist.playItem(1)
        AxVLCPluginSea2.playlist.playItem(1)
        AxVLCPluginSea1.playlist.play()
        AxVLCPluginSea2.playlist.play()

        'Disable Land side (21,22)
        AxVLCPluginLand1.playlist.stop()
        AxVLCPluginLand2.playlist.stop()
    End Sub

    Sub show_land_side()

        SplitContainer1.Panel1Collapsed = True 'Hide sea
        SplitContainer1.Panel2Collapsed = False   'Show land

        'Enable Land side (21,22)
        AxVLCPluginLand1.playlist.playItem(1)
        AxVLCPluginLand2.playlist.playItem(1)
        AxVLCPluginLand1.playlist.play()
        AxVLCPluginLand2.playlist.play()

        'Disable Sea side (11,12)
        AxVLCPluginSea1.playlist.stop()
        AxVLCPluginSea2.playlist.stop()
    End Sub

    Private Sub LandSideToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LandSideToolStripMenuItem.Click
        show_land_side()
    End Sub

    Private Sub tsbSeaside_Click(sender As Object, e As EventArgs) Handles tsbSeaside.Click
        show_sea_side()
    End Sub

    Private Sub tsbLandSide_Click(sender As Object, e As EventArgs) Handles tsbLandSide.Click
        show_land_side()
    End Sub

    Private Sub tsbAll_Click(sender As Object, e As EventArgs) Handles tsbAll.Click
        show_all_side()
    End Sub
End Class
