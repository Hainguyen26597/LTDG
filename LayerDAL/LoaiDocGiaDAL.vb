Imports System.Configuration
Imports System.Data.SqlClient
Imports LayerDTO
Imports Utility

Public Class LoaiDocGiaDAL
    Private connectionString As String

    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(ConnectionString As String)
        Me.connectionString = ConnectionString
    End Sub
    Public Function selectALL(ByRef listLoaiDG As List(Of LoaiDocGiaDTO)) As Result

        Dim query As String = String.Empty
        query &= " SELECT [maloaidocgia], [tenloaidocgia]"
        query &= " FROM [tblLoaiDocGia]"


        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                End With
                Try
                    conn.Open()
                    Dim reader As SqlDataReader
                    reader = comm.ExecuteReader()
                    If reader.HasRows = True Then
                        listLoaiDG.Clear()
                        While reader.Read()
                            listLoaiDG.Add(New LoaiDocGiaDTO(reader("maloaidocgia"), reader("tenloaidocgia")))
                        End While
                    End If
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Lấy tất cả loại độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function update(ldg As LoaiDocGiaDTO) As Result

        Dim query As String = String.Empty
        query &= " UPDATE [tblLoaiDocGia] SET"
        query &= " [tenloaidocgia] = @tenloaidocgia "
        query &= "WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", ldg.MaLoai)
                    .Parameters.AddWithValue("@tenloaidocgia", ldg.TenLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Cập nhật loại độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
    Public Function delete(maLoai As Integer) As Result

        Dim query As String = String.Empty
        query &= " DELETE FROM [tblLoaiDocGia] "
        query &= " WHERE "
        query &= " [maloaidocgia] = @maloaidocgia "

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@maloaidocgia", maLoai)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    Console.WriteLine(ex.StackTrace)
                    conn.Close()
                    ' them that bai!!!
                    Return New Result(False, "Xóa loại độc giả
không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function
End Class
