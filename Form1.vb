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
        Me.Text = Me.Text & " version :" & versionNumber.ToString
    End Sub

    Private Sub initial_camera_platlist()
        With AxVLCPluginR1
            'Stream for mutiple view (low res)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_1 & "/Streaming/Channels/" & vChannel)
            'Straem for full HD
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_1 & "/Streaming/Channels/1")
        End With

        With AxVLCPluginR2
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_2 & "/Streaming/Channels/" & vChannel)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_R_2 & "/Streaming/Channels/1")
        End With

        'On Bottom Camera
        With AxVLCPluginL1
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_1 & "/Streaming/Channels/" & vChannel)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_1 & "/Streaming/Channels/1")

        End With

        With AxVLCPluginL2
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_2 & "/Streaming/Channels/" & vChannel)
            .playlist.add("rtsp://" & vUser & ":" & vPassword & "@" & vCameraIp_L_2 & "/Streaming/Channels/1")
        End With
    End Sub

    Private Sub play_camera(Optional playlistIndex As Integer = 0)
        'On Top Camera

        With AxVLCPluginR1
            .playlist.playItem(playlistIndex)
        End With

        With AxVLCPluginR2
            .playlist.playItem(playlistIndex)
        End With

        'On Bottom Camera
        With AxVLCPluginL1
            .playlist.playItem(playlistIndex)

        End With

        With AxVLCPluginL2
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
        SplitContainer1.Panel1Collapsed = False
        SplitContainer1.Panel2Collapsed = False

        Dim playlistIndex As Integer = 0 'Low resolution
        AxVLCPluginR1.playlist.playItem(playlistIndex)
        AxVLCPluginR2.playlist.playItem(playlistIndex)
        AxVLCPluginL1.playlist.playItem(playlistIndex)
        AxVLCPluginL2.playlist.playItem(playlistIndex)

    End Sub

    Private Sub SwitchToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SwitchToolStripMenuItem.Click
        SplitContainer1.Panel1Collapsed = vToggleView
        SplitContainer1.Panel2Collapsed = Not vToggleView

        If SplitContainer1.Panel1Collapsed Then
            'Disable
            AxVLCPluginR2.playlist.stop()
            AxVLCPluginR2.playlist.stop()
            'Enable

            AxVLCPluginL1.playlist.playItem(1)
            AxVLCPluginL2.playlist.playItem(1)
            AxVLCPluginL1.playlist.play()
            AxVLCPluginL2.playlist.play()
        Else
            'Enable
            AxVLCPluginR1.playlist.playItem(1)
            AxVLCPluginR2.playlist.playItem(1)
            AxVLCPluginR1.playlist.play()
            AxVLCPluginR2.playlist.play()
            'Disable

            'AxVLCPluginL1.playlist.playItem(0)
            'AxVLCPluginL2.playlist.playItem(0)
            AxVLCPluginL2.playlist.stop()
            AxVLCPluginL1.playlist.stop()
        End If



        vToggleView = Not vToggleView
    End Sub

    Private Sub SettingToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles SettingToolStripMenuItem.Click
        frmSetting.ShowDialog()
        'reload_setting()
        'reload_camera()
    End Sub
End Class
