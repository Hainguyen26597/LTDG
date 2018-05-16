Imports System.Data.SqlClient
Imports System.Configuration
Imports LayerDTO
Imports Utility

Public Class DocGiaDAL
    Private connectionString As String
    Public Sub New()
        ' Read ConnectionString value from App.config file
        connectionString = ConfigurationManager.AppSettings("ConnectionString")
    End Sub
    Public Sub New(connectionString As String)
        Me.connectionString = connectionString
    End Sub

    Public Function buildID(ByRef nextId As String) As Result 'ex: 18222229

        nextId = String.Empty
        Dim y = DateTime.Now.Year
        Dim x = y.ToString().Substring(2)
        nextId = x + "000000"

        Dim query As String = String.Empty
        query &= "SELECT TOP 1 [Id] "
        query &= "FROM [tblDocGia] "
        query &= "ORDER BY [Id] DESC "

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
                    Dim msOnDB As String
                    msOnDB = Nothing
                    If reader.HasRows = True Then
                        While reader.Read()
                            msOnDB = reader("Id")
                        End While
                    End If
                    If (msOnDB <> Nothing And msOnDB.Length >= 8) Then
                        Dim currentYear = DateTime.Now.Year.ToString().Substring(2)
                        Dim iCurrentYear = Integer.Parse(currentYear)
                        Dim currentYearOnDB = msOnDB.Substring(0, 2)
                        Dim icurrentYearOnDB = Integer.Parse(currentYearOnDB)
                        Dim year = iCurrentYear
                        If (year < icurrentYearOnDB) Then
                            year = icurrentYearOnDB
                        End If
                        nextId = year.ToString()
                        Dim v = msOnDB.Substring(2)
                        Dim convertDecimal = Convert.ToDecimal(v)
                        convertDecimal = convertDecimal + 1
                        Dim tmp = convertDecimal.ToString()
                        tmp = tmp.PadLeft(msOnDB.Length - 2, "0")
                        nextId = nextId + tmp
                        System.Console.WriteLine(nextId)
                    End If

                Catch ex As Exception
                    conn.Close() ' that bai!!!
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Lấy tự động Mã số độc giả kế tiếp không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) ' thanh cong
    End Function

    Public Function insert(dg As DocGiaDTO) As Result
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblDocGia] ([ID],[Maloaidocgia],[Hoten],[Diachi],[Ngaysinh],[Email],[Ngaylapthe],[Ngayhethan],[Nguoilap])"
        query &= "VALUES (@ID,@Maloaidocgia,@Hoten,@Diachi,@Ngaysinh,@Email,@Ngaylapthe,@Ngayhethan,@Nguoilap)"


        Dim nextId = "1"
        buildID(nextId)
        dg.ID = nextId

        Using conn As New SqlConnection(connectionString)
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@ID", dg.ID)
                    .Parameters.AddWithValue("@Maloaidocgia", dg.LoaiDG)
                    .Parameters.AddWithValue("@Hoten", dg.Hoten)
                    .Parameters.AddWithValue("@Diachi", dg.Diachi)
                    .Parameters.AddWithValue("@Ngaysinh", dg.Ngaysinh)
                    .Parameters.AddWithValue("@Email", dg.Email)
                    .Parameters.AddWithValue("@Ngaylapthe", dg.Ngaylapthe)
                    .Parameters.AddWithValue("@Ngayhethan", dg.Ngayhethan)
                    .Parameters.AddWithValue("@Nguoilap", dg.Nguoilap)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    System.Console.WriteLine(ex.StackTrace)
                    Return New Result(False, "Thêm độc giả không thành công", ex.StackTrace)
                End Try
            End Using
        End Using
        Return New Result(True) 'Thành công
    End Function
    Public Function insertDocGia(dg As DocGiaDTO) As Integer
        Dim query As String = String.Empty
        query &= "INSERT INTO [tblHocSinh] ([Ngaysinh],[Ngaylapthe],[Ngayhethan])"
        query &= "VALUES (@NgaySinh,@Ngaylapthe, @Ngayhethan)"
        Using conn As New SqlConnection("Data Source=DESKTOP-7OAD3LE\SQLEXPRESS;Initial Catalog=QLHS_TH1;Integrated Security=True")
            Using comm As New SqlCommand()
                With comm
                    .Connection = conn
                    .CommandType = CommandType.Text
                    .CommandText = query
                    .Parameters.AddWithValue("@Ngaysinh", dg.Ngaysinh)
                    .Parameters.AddWithValue("@Ngaylapthe", dg.Ngaylapthe)
                    .Parameters.AddWithValue("@Ngayhethan", dg.Ngayhethan)
                End With
                Try
                    conn.Open()
                    comm.ExecuteNonQuery()
                Catch ex As Exception
                    conn.Close()
                    Return 1
                End Try
            End Using
        End Using
        Return 0
    End Function
    Public Function update(dg As DocGiaDTO) As Result
        Throw New NotImplementedException()
    End Function

    Public ReadOnly Property delete(maLoai As Integer) As Result
        Get
            Throw New NotImplementedException()
        End Get
    End Property

    Public Function selectALL(listLoaiDG As List(Of DocGiaDTO)) As Result
        Throw New NotImplementedException()
    End Function

    Public Function selectALL_ByType(maLoai As Integer, listDG As Object) As Result
        Throw New NotImplementedException()
    End Function
End Class



