Imports AutoUpdaterDotNET

Public Class MainForm

    Private Sub Button4_Click(sender As Object, e As EventArgs) Handles FullScan.Click

    End Sub

    Private Sub MainForm_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        AutoUpdater.Start("https://cryptid-data.global.ssl.fastly.net/updater/windows/Updater.xml")
    End Sub

    Private Sub OnMessageReceived(sender As Object, e As XDMessaging.XDMessageEventArgs)

    End Sub
End Class
