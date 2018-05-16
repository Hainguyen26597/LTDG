Imports LayerDAL
Imports LayerDTO
Imports Utility
Public Class LoaiDocGiaBUS
    Private ldgDAL As LoaiDocGiaDAL
    Public Sub New()
        ldgDAL = New LoaiDocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        ldgDAL = New LoaiDocGiaDAL(connectionString)
    End Sub
    Public Function isValidName(ldg As LoaiDocGiaDTO) As Boolean

        If (ldg.TenLoai.Length < 1) Then
            Return False
        End If

        Return True

    End Function
    Public Function selectAll(ByRef listLoaiDG As List(Of LoaiDocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.selectALL(listLoaiDG)
    End Function
    Public Function update(ldg As LoaiDocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.update(ldg)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return ldgDAL.delete(maLoai)
    End Function
End Class
