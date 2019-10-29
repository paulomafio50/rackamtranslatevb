Public Class Help
    Private Sub LinkLabel1_LinkClicked(sender As Object, e As LinkLabelLinkClickedEventArgs) Handles LinkLabel1.LinkClicked
        Process.Start("https://discord.gg/PsuHkDn")
    End Sub

    Private Sub Help_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        Try
            Dim Path As String = Application.StartupPath
            Process.Start(Path & "\pdf\help_En.pdf")
        Catch
            MsgBox("No have help file(help_En.pdf) in pdf subfolder")
        End Try

    End Sub

    Private Sub AxAcroPDF1_Enter(sender As Object, e As EventArgs)

    End Sub
End Class