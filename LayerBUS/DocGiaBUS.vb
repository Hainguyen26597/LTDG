Imports LayerDAL
Imports LayerDTO
Imports Utility

Public Class DocGiaBUS
    Private dgDAL As DocGiaDAL
    Public Sub New()
        dgDAL = New DocGiaDAL()
    End Sub
    Public Sub New(connectionString As String)
        dgDAL = New DocGiaDAL(connectionString)
    End Sub
    Public Function isValidName(dg As DocGiaDTO) As Boolean

        If (dg.Hoten.Length < 1) Then
            Return False
        End If

        Return True
    End Function
    Public Function insert(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.insert(dg)
    End Function
    Public Function update(dg As DocGiaDTO) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.update(dg)
    End Function
    Public Function delete(maLoai As Integer) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.delete(maLoai)
    End Function
    Public Function selectAll(ByRef listLoaiDG As List(Of DocGiaDTO)) As Result
        '1. verify data here!!

        '2. insert to DB
        Return dgDAL.selectALL(listLoaiDG)
    End Function
    Public Function buildID(ByRef nextId As Integer) As Result
        Return dgDAL.buildID(nextId)
    End Function
End Class
