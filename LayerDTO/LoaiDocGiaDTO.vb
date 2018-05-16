Public Class LoaiDocGiaDTO

    Private iMaLoai As Integer
    Private strTenLoai As String

    Public Sub New()
    End Sub
    Public Sub New(ml As Integer, tl As String)
        iMaLoai = ml
        strTenLoai = tl
    End Sub
    Property MaLoai() As Integer
        Get
            Return iMaLoai
        End Get
        Set(ByVal Value As Integer)
            iMaLoai = Value
        End Set
    End Property
    Property TenLoai() As String
        Get
            Return strTenLoai
        End Get
        Set(ByVal Value As String)
            strTenLoai = Value
        End Set
    End Property

End Class
