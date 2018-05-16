Imports LayerBUS
Imports LayerDTO
Imports LayerDAL
Imports Utility

Public Class frmLapTheDocGia

    Private dgBus As DocGiaBUS
    Private ldgBus As LoaiDocGiaBUS

    Private Sub btnNhap_Click(sender As Object, e As EventArgs) Handles btnNhap.Click

        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.ID = txtID.Text
        docgia.Hoten = txtHoten.Text
        docgia.Diachi = txtDiachi.Text
        docgia.Ngaysinh = dtpNgaysinh.Value
        docgia.LoaiDG = Convert.ToInt32(cbLoaiDG.SelectedValue)
        docgia.Email = txtEmail.Text
        docgia.Ngaylapthe = dtpNgaylapthe.Value
        docgia.Ngayhethan = dtpNgayhethan.Value
        docgia.Nguoilap = txtNguoilap.Text
        '2. Business .....
        If (dgBus.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên học sinh không đúng")
            txtHoten.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Lập thẻ thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            'set MSSH auto
            Dim nextId = "1"
            result = dgBus.buildID(nextId)
            If (result.FlagResult = False) Then
                MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                Me.Close()
                Return
            End If
            txtID.Text = nextId
            txtDiachi.Text = String.Empty
            txtHoten.Text = String.Empty
            txtEmail.Text = String.Empty
            txtNguoilap.Text = String.Empty
        Else
            MessageBox.Show("Lập thẻ không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
    Private Sub frmDocGiaGUI_Load(sender As Object, e As EventArgs) Handles MyBase.Load

        dgBus = New DocGiaBUS()
        ldgBus = New LoaiDocGiaBUS()

        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        cbLoaiDG.DataSource = New BindingSource(listLoaiDocGia, String.Empty)
        cbLoaiDG.DisplayMember = "TenLoai"
        cbLoaiDG.ValueMember = "MaLoai"

        'set DG auto
        Dim nextId = "1"
        result = dgBus.buildID(nextId)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh tự động mã độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Me.Close()
            Return
        End If
        txtID.Text = nextId

    End Sub

    Private Sub btnNhapVaDong_Click(sender As Object, e As EventArgs) Handles btnNhapvaDong.Click
        Dim docgia As DocGiaDTO
        docgia = New DocGiaDTO()

        '1. Mapping data from GUI control
        docgia.ID = txtID.Text
        docgia.Hoten = txtHoten.Text
        docgia.Diachi = txtDiachi.Text
        docgia.Ngaysinh = dtpNgaysinh.Value
        docgia.LoaiDG = Convert.ToInt32(cbLoaiDG.SelectedValue)
        docgia.Email = txtEmail.Text
        docgia.Ngaylapthe = dtpNgaylapthe.Value
        docgia.Ngayhethan = dtpNgayhethan.Value
        docgia.Nguoilap = txtNguoilap.Text
        '2. Business .....
        If (dgBus.isValidName(docgia) = False) Then
            MessageBox.Show("Họ tên độc giả không đúng")
            txtHoten.Focus()
            Return
        End If
        '3. Insert to DB
        Dim result As Result
        result = dgBus.insert(docgia)
        If (result.FlagResult = True) Then
            MessageBox.Show("Lập thẻ độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
            Me.Close()
        Else
            MessageBox.Show("Lập thẻ độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
        End If
    End Sub
End Class