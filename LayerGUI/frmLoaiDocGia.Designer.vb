<Global.Microsoft.VisualBasic.CompilerServices.DesignerGenerated()> _
Partial Class frmLoaiDocGia
    Inherits System.Windows.Forms.Form

    'Form overrides dispose to clean up the component list.
    <System.Diagnostics.DebuggerNonUserCode()> _
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
    <System.Diagnostics.DebuggerStepThrough()> _
    Private Sub InitializeComponent()
        Me.btnCapNhat = New System.Windows.Forms.Button()
        Me.btnXoa = New System.Windows.Forms.Button()
        Me.dgvDanhSachLoaiDG = New System.Windows.Forms.DataGridView()
        Me.Label1 = New System.Windows.Forms.Label()
        Me.Label2 = New System.Windows.Forms.Label()
        Me.Label3 = New System.Windows.Forms.Label()
        Me.txtMaLoai = New System.Windows.Forms.TextBox()
        Me.txtTenLoai = New System.Windows.Forms.TextBox()
        CType(Me.dgvDanhSachLoaiDG, System.ComponentModel.ISupportInitialize).BeginInit()
        Me.SuspendLayout()
        '
        'btnCapNhat
        '
        Me.btnCapNhat.Location = New System.Drawing.Point(167, 275)
        Me.btnCapNhat.Name = "btnCapNhat"
        Me.btnCapNhat.Size = New System.Drawing.Size(75, 23)
        Me.btnCapNhat.TabIndex = 0
        Me.btnCapNhat.Text = "Cập Nhật"
        Me.btnCapNhat.UseVisualStyleBackColor = True
        '
        'btnXoa
        '
        Me.btnXoa.Location = New System.Drawing.Point(313, 275)
        Me.btnXoa.Name = "btnXoa"
        Me.btnXoa.Size = New System.Drawing.Size(75, 23)
        Me.btnXoa.TabIndex = 1
        Me.btnXoa.Text = "Xóa"
        Me.btnXoa.UseVisualStyleBackColor = True
        '
        'dgvDanhSachLoaiDG
        '
        Me.dgvDanhSachLoaiDG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize
        Me.dgvDanhSachLoaiDG.Location = New System.Drawing.Point(65, 83)
        Me.dgvDanhSachLoaiDG.Name = "dgvDanhSachLoaiDG"
        Me.dgvDanhSachLoaiDG.Size = New System.Drawing.Size(399, 80)
        Me.dgvDanhSachLoaiDG.TabIndex = 2
        '
        'Label1
        '
        Me.Label1.AutoSize = True
        Me.Label1.Location = New System.Drawing.Point(62, 57)
        Me.Label1.Name = "Label1"
        Me.Label1.Size = New System.Drawing.Size(117, 13)
        Me.Label1.TabIndex = 3
        Me.Label1.Text = "Danh sách loại độc giả"
        '
        'Label2
        '
        Me.Label2.AutoSize = True
        Me.Label2.Location = New System.Drawing.Point(106, 191)
        Me.Label2.Name = "Label2"
        Me.Label2.Size = New System.Drawing.Size(45, 13)
        Me.Label2.TabIndex = 4
        Me.Label2.Text = "Mã Loại"
        '
        'Label3
        '
        Me.Label3.AutoSize = True
        Me.Label3.Location = New System.Drawing.Point(106, 230)
        Me.Label3.Name = "Label3"
        Me.Label3.Size = New System.Drawing.Size(49, 13)
        Me.Label3.TabIndex = 5
        Me.Label3.Text = "Tên Loại"
        '
        'txtMaLoai
        '
        Me.txtMaLoai.Location = New System.Drawing.Point(227, 185)
        Me.txtMaLoai.Name = "txtMaLoai"
        Me.txtMaLoai.Size = New System.Drawing.Size(100, 20)
        Me.txtMaLoai.TabIndex = 6
        Me.txtMaLoai.Text = "1"
        '
        'txtTenLoai
        '
        Me.txtTenLoai.Location = New System.Drawing.Point(227, 223)
        Me.txtTenLoai.Name = "txtTenLoai"
        Me.txtTenLoai.Size = New System.Drawing.Size(100, 20)
        Me.txtTenLoai.TabIndex = 7
        '
        'frmLoaiDocGia
        '
        Me.AutoScaleDimensions = New System.Drawing.SizeF(6.0!, 13.0!)
        Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
        Me.ClientSize = New System.Drawing.Size(514, 315)
        Me.Controls.Add(Me.txtTenLoai)
        Me.Controls.Add(Me.txtMaLoai)
        Me.Controls.Add(Me.Label3)
        Me.Controls.Add(Me.Label2)
        Me.Controls.Add(Me.Label1)
        Me.Controls.Add(Me.dgvDanhSachLoaiDG)
        Me.Controls.Add(Me.btnXoa)
        Me.Controls.Add(Me.btnCapNhat)
        Me.Name = "frmLoaiDocGia"
        Me.Text = "Loại Độc Giả"
        CType(Me.dgvDanhSachLoaiDG, System.ComponentModel.ISupportInitialize).EndInit()
        Me.ResumeLayout(False)
        Me.PerformLayout()

    End Sub

    Friend WithEvents btnCapNhat As Button
    Friend WithEvents btnXoa As Button
    Friend WithEvents dgvDanhSachLoaiDG As DataGridView
    Friend WithEvents Label1 As Label
    Friend WithEvents Label2 As Label
    Friend WithEvents Label3 As Label
    Friend WithEvents txtMaLoai As TextBox
    Friend WithEvents txtTenLoai As TextBox
End Class
