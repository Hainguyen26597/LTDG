
Imports LayerDTO
Imports Utility
Imports LayerBUS
Public Class frmLoaiDocGia
    Private ldgBus As LoaiDocGiaBUS

    Private Sub frmDanhSachLoaiDocGia_Load(sender As Object, e As EventArgs) Handles MyBase.Load
        ldgBus = New LoaiDocGiaBUS()
        ' Load LoaiDocGia list
        loadListLoaiDocGia()

    End Sub
    Private Sub loadListLoaiDocGia()
        ' Load LoaiDocGia list
        Dim listLoaiDocGia = New List(Of LoaiDocGiaDTO)
        Dim result As Result
        result = ldgBus.selectAll(listLoaiDocGia)
        If (result.FlagResult = False) Then
            MessageBox.Show("Lấy danh sách loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
            System.Console.WriteLine(result.SystemMessage)
            Return
        End If

        dgvDanhSachLoaiDG.Columns.Clear()
        dgvDanhSachLoaiDG.DataSource = Nothing

        dgvDanhSachLoaiDG.AutoGenerateColumns = False
        dgvDanhSachLoaiDG.AllowUserToAddRows = False
        dgvDanhSachLoaiDG.DataSource = listLoaiDocGia

        Dim clMaLoai = New DataGridViewTextBoxColumn()
        clMaLoai.Name = "MaLoai"
        clMaLoai.HeaderText = "Mã Loại"
        clMaLoai.DataPropertyName = "MaLoai"
        dgvDanhSachLoaiDG.Columns.Add(clMaLoai)

        Dim clTenLoai = New DataGridViewTextBoxColumn()
        clTenLoai.Name = "TenLoai"
        clTenLoai.HeaderText = "Tên Loại"
        clTenLoai.DataPropertyName = "TenLoai"
        dgvDanhSachLoaiDG.Columns.Add(clTenLoai)

    End Sub

    Private Sub btnCapNhat_Click(sender As Object, e As EventArgs) Handles btnCapNhat.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y 'current row selected
        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Try
                Dim ldg As LoaiDocGiaDTO
                ldg = New LoaiDocGiaDTO()

                '1. Mapping data from GUI control
                ldg.MaLoai = Convert.ToInt32(txtMaLoai.Text)
                ldg.TenLoai = txtTenLoai.Text

                '2. Business .....
                If (ldgBus.isValidName(ldg) = False) Then
                    MessageBox.Show("Tên Loại độc giả không đúng. Vui lòng kiểm tra lại", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    txtTenLoai.Focus()
                    Return
                End If

                '3. Insert to DB

                Dim result As Result
                result = ldgBus.update(ldg)
                If (result.FlagResult = True) Then
                    ' Re-Load LoaiHocSinh list
                    loadListLoaiDocGia()
                    ' Hightlight the row has been updated on table
                    dgvDanhSachLoaiDG.Rows(currentRowIndex).Selected = True
                    Try
                        ldg = CType(dgvDanhSachLoaiDG.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                        txtMaLoai.Text = ldg.MaLoai
                        txtTenLoai.Text = ldg.TenLoai
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                    MessageBox.Show("Cập nhật Loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                Else
                    MessageBox.Show("Cập nhật loại độc giả không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                    System.Console.WriteLine(result.SystemMessage)
                End If
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub

    Private Sub btnXoa_Click(sender As Object, e As EventArgs) Handles btnXoa.Click
        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y 'current row selected


        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Select Case MsgBox("Bạn có thực sự muốn xóa loại độc giả có mã: " + txtMaLoai.Text, MsgBoxStyle.YesNo, "Information")
                Case MsgBoxResult.Yes
                    Try

                        '1. Delete from DB
                        Dim result As Result
                        result = ldgBus.delete(Convert.ToInt32(txtMaLoai.Text))
                        If (result.FlagResult = True) Then

                            ' Re-Load LoaiHocSinh list
                            loadListLoaiDocGia()

                            ' Hightlight the next row on table
                            If (currentRowIndex >= dgvDanhSachLoaiDG.Rows.Count) Then
                                currentRowIndex = currentRowIndex - 1
                            End If
                            If (currentRowIndex >= 0) Then
                                dgvDanhSachLoaiDG.Rows(currentRowIndex).Selected = True
                                Try
                                    Dim ldg = CType(dgvDanhSachLoaiDG.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                                    txtMaLoai.Text = ldg.MaLoai
                                    txtTenLoai.Text = ldg.TenLoai
                                Catch ex As Exception
                                    Console.WriteLine(ex.StackTrace)
                                End Try
                            End If
                            MessageBox.Show("Xóa Loại độc giả thành công.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information)
                        Else
                            MessageBox.Show("Xóa Loại học sinh không thành công.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error)
                            System.Console.WriteLine(result.SystemMessage)
                        End If
                    Catch ex As Exception
                        Console.WriteLine(ex.StackTrace)
                    End Try
                Case MsgBoxResult.No
                    Return
            End Select

        End If
    End Sub

    Private Sub dgvDanhSachLoaiDG_CellContentClick(sender As Object, e As DataGridViewCellEventArgs) Handles dgvDanhSachLoaiDG.CellContentClick

        ' Get the current cell location.
        Dim currentRowIndex As Integer = dgvDanhSachLoaiDG.CurrentCellAddress.Y 'current row selected
        'Dim x As Integer = dgvDanhSachLoaiHS.CurrentCellAddress.X 'curent column selected

        ' Write coordinates to console for debugging
        'Console.WriteLine(y.ToString + " " + x.ToString)

        'Verify that indexing OK
        If (-1 < currentRowIndex And currentRowIndex < dgvDanhSachLoaiDG.RowCount) Then
            Try
                Dim ldg = CType(dgvDanhSachLoaiDG.Rows(currentRowIndex).DataBoundItem, LoaiDocGiaDTO)
                txtMaLoai.Text = ldg.MaLoai
                txtTenLoai.Text = ldg.TenLoai
            Catch ex As Exception
                Console.WriteLine(ex.StackTrace)
            End Try
        End If
    End Sub
End Class