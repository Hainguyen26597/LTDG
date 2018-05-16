Public Class DocGiaDTO
    Private strID As String
    Private strHoten As String
    Private iLoaiDG As Integer
    Private strEmail As String
    Private dateNgaysinh As DateTime
    Private strDiachi As String
    Private dateNgaylapthe As DateTime
    Private dateNgayhethan As DateTime
    Private strNguoilap As String
    Public Sub New(strID As Integer, iLoaiDG As Integer, strEmail As String, strHoten As String, strDiaChi As String, dateNgaySinh As DateTime, dateNgaylapthe As DateTime, dateNgayhethan As DateTime, strNguoilap As String)
        Me.strID = strID
        Me.strHoten = strHoten
        Me.iLoaiDG = iLoaiDG
        Me.strEmail = strEmail
        Me.strNguoilap = strNguoilap
        Me.strDiachi = strDiaChi
        Me.dateNgaysinh = dateNgaySinh
        Me.dateNgaylapthe = dateNgaylapthe
        Me.dateNgayhethan = dateNgayhethan
    End Sub

    Public Sub New()
    End Sub

    Property ID() As String
        Get
            Return strID
        End Get
        Set(ByVal Value As String)
            strID = Value
        End Set
    End Property
    Property Hoten() As String
        Get
            Return strHoten
        End Get
        Set(ByVal value As String)
            strHoten = value
        End Set
    End Property
    Property LoaiDG() As Integer
        Get
            Return iLoaiDG
        End Get
        Set(ByVal Value As Integer)
            iLoaiDG = Value
        End Set
    End Property
    Property Email() As String
        Get
            Return strEmail
        End Get
        Set(ByVal value As String)
            strEmail = value
        End Set
    End Property

    Property Ngaysinh() As DateTime
        Get
            Return dateNgaysinh
        End Get
        Set(ByVal value As DateTime)
            dateNgaysinh = value
        End Set
    End Property

    Property Diachi() As String
        Get
            Return strDiachi
        End Get
        Set(ByVal value As String)
            strDiachi = value
        End Set
    End Property

    Property Nguoilap() As String
        Get
            Return strNguoilap
        End Get
        Set(ByVal value As String)
            strNguoilap = value
        End Set
    End Property
    Property Ngaylapthe() As DateTime
        Get
            Return dateNgaylapthe
        End Get
        Set(ByVal value As DateTime)
            dateNgaylapthe = value
        End Set
    End Property
    Property Ngayhethan() As DateTime
        Get
            Return dateNgayhethan
        End Get
        Set(ByVal value As DateTime)
            dateNgayhethan = value
        End Set
    End Property
End Class



