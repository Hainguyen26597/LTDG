Imports System.Configuration
Public Class frmMain

    Private ConnectionString As String
    Private Sub LậpThẻĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LậpThẻĐộcGiảToolStripMenuItem.Click
        Dim frm As frmLapTheDocGia = New frmLapTheDocGia()
        frm.MdiParent = Me
        frm.Show()
    End Sub
    Private Sub frmMain_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        ' Read ConnectionString value from App.config file
        ConnectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Private Sub LoạiĐộcGiảToolStripMenuItem_Click(sender As Object, e As EventArgs) Handles LoạiĐộcGiảToolStripMenuItem.Click
        Dim frm As frmLoaiDocGia = New frmLoaiDocGia()
        frm.MdiParent = Me
        frm.Show()
    End Sub
End Class