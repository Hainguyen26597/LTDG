<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()>
Partial Class frmMain
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()>
    Protected Overrides Sub Dispose(ByVal disposing As Boolean)
        Try
            If disposing AndAlso components IsNot Nothing Then
                components.Dispose()
            End If
        Finally
            MyBase.Dispose(disposing)
        End Try
    End Sub

    'Required by the Windows Form Designer
    Private components As System.ComponentModel.IContainer

    'NOTE: The following procedure is required by the Windows Form Designer
    'It can be modified using the Windows Form Designer.  
    'Do not modify it using the code editor.
    <System.Diagnostics.DebuggerStepThrough()>
    Private Sub InitializeComponent()
        Me.MenuStrip1 = New System.Windows.Forms.MenuStrip()
        Me.FileToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.QuảnLýToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LậpThẻĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.LoạiĐộcGiảToolStripMenuItem = New System.Windows.Forms.ToolStripMenuItem()
        Me.MenuStrip1.SuspendLayout()
        Me.SuspendLayout()
        '
        'MenuStrip1
        '
        Me.MenuStrip1.Items.AddRange(New System.Windows.Forms.ToolStripItem() {Me.FileToolStripMenuItem, Me.QuảnLýToolStripMenuItem})
        Me.MenuStrip1.Location = New System.Drawing.Point(0, 0)
        Me.MenuStrip1.Name = "MenuStrip1"
        Me.MenuStrip1.Size = New System.Drawing.Size(351, 24)
        Me.MenuStrip1.TabIndex = 0
        Me.MenuStrip1.Text = "MenuStrip1"
        '
        'FileToolStripMenuItem
        '
        Me.FileToolStripMenuItem.Name = "FileToolStripMenuItem"
        Me.FileToolStripMenuItem.Size = New System.Drawing.Size(37, 20)
        Me.FileToolStripMenuItem.Text = "File"
        '
        'QuảnLýToolStripMenuItem
        '
        Me.QuảnLýToolStripMenuItem.DropDownItems.AddRange(New System.Windows.Forms.ToolStripItem() {Me.LậpThẻĐộcGiảToolStripMenuItem, Me.LoạiĐộcGiảToolStripMenuItem})
        Me.QuảnLýToolStripMenuItem.Name = "QuảnLýToolStripMenuItem"
        Me.QuảnLýToolStripMenuItem.Size = New System.Drawing.Size(60, 20)
        Me.QuảnLýToolStripMenuItem.Text = "Độc Giả"
        '
        'LậpThẻĐộcGiảToolStripMenuItem
        '
        Me.LậpThẻĐộcGiảToolStripMenuItem.Name = "LậpThẻĐộcGiảToolStripMenuItem"
        Me.LậpThẻĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LậpThẻĐộcGiảToolStripMenuItem.Text = "Lập Thẻ Độc Giả"
        '
        'LoạiĐộcGiảToolStripMenuItem
        '
        Me.LoạiĐộcGiảToolStripMenuItem.Name = "LoạiĐộcGiảToolStripMenuItem"
        Me.LoạiĐộcGiảToolStripMenuItem.Size = New System.Drawing.Size(160, 22)
        Me.LoạiĐộcGiảToolStripMenuItem.Text = "Loại Độc Giả"
        '
        'frmMain
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(351, 261)
        Me.Controls.Add(Me.MenuStrip1)
        Me.IsMdiContainer = True
        Me.MainMenuStrip = Me.MenuStrip1
        Me.Name = "frmMain"
        Me.Text = "Quản Lý Độc Giả"
        Me.WindowState = System.Windows.Forms.FormWindowState.Maximized
        Me.MenuStrip1.ResumeLayout(False)
        Me.MenuStrip1.PerformLayout()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents MenuStrip1 As MenuStrip
    Friend WithEvents FileToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents QuảnLýToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LậpThẻĐộcGiảToolStripMenuItem As ToolStripMenuItem
    Friend WithEvents LoạiĐộcGiảToolStripMenuItem As ToolStripMenuItem
End Class
