
USE [master]
GO
WHILE EXISTS(select NULL from sys.databases where name='LTDG')
BEGIN
    DECLARE @SQL varchar(max)
    SELECT @SQL = COALESCE(@SQL,'') + 'Kill ' + Convert(varchar, SPId) + ';'
    FROM MASTER..SysProcesses
    WHERE DBId = DB_ID(N'LTDG') AND SPId <> @@SPId
    EXEC(@SQL)
    DROP DATABASE [LTDG]
END
GO

/* Collation = SQL_Latin1_General_CP1_CI_AS */
CREATE DATABASE [LTDG]
GO

USE [LTDG]
GO
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO


USE [LTDG]
GO

SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblDocGia](
	[ID] [nvarchar](8) NOT NULL,
	[Hoten] [nvarchar](50) NOT NULL,
	[Maloaidocgia] [int] NOT NULL,
	[Ngaysinh] [datetime2](7) NOT NULL,
	[Ngaylapthe] [datetime2](7) NOT NULL,
	[Diachi] [nvarchar](50) NOT NULL,
	[Email] [nvarchar](50) NOT NULL,
	[Nguoilap] [nvarchar](50) NOT NULL,
	[Ngayhethan] [datetime2](7) NOT NULL,
	CONSTRAINT check_ns CHECK ([Ngaysinh] < '12/31/2000' and [Ngaysinh] >= '01/01/1963'),
    CONSTRAINT [PK_tblDocGia] PRIMARY KEY CLUSTERED 

(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO




USE [LTDG]
GO

/****** Object:  Table [dbo].[tblKhoi]    Script Date: 4/17/2018 9:45:22 AM ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[tblLoaiDocGia](
	[Maloaidocgia] int NOT NULL,
	[Tenloaidocgia] [nchar](10) NOT NULL,
 CONSTRAINT [PK_tblLoaiDocGia] PRIMARY KEY CLUSTERED 
(
	[Maloaidocgia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


USE [LTDG]
GO

INSERT INTO[dbo].[tblLoaiDocGia]([Maloaidocgia],[Tenloaidocgia]) VALUES(1,'X')
GO
INSERT INTO[dbo].[tblLoaiDocGia]([Maloaidocgia],[Tenloaidocgia]) VALUES(2,'Y')
GO

USE [LTDG]
GO

INSERT INTO [dbo].[tblDocGia]([ID],[Maloaidocgia],[Hoten],[Diachi],[Ngaysinh],[Email],[Ngaylapthe],[Ngayhethan],[Nguoilap]) VALUES(N'16000001',1,N'Nguyễn Văn An',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'an@gmail.com',convert(datetime,'1/30/2018 00:00:00',101),convert(datetime,'1/7/2017 00:00:00',101),N'Trần Trân')
GO
INSERT INTO [dbo].[tblDocGia]([ID],[Maloaidocgia],[Hoten],[Diachi],[Ngaysinh],[Email],[Ngaylapthe],[Ngayhethan],[Nguoilap]) VALUES(N'16000002',2,N'Nguyễn Văn Huy',N'1 Cống Quỳnh, Quận 1, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'huy@gmail.com',convert(datetime,'3/30/2018 00:00:00',101),convert(datetime,'9/30/2018 00:00:00',101),N'Bảo Vương')
GO
INSERT INTO [dbo].[tblDocGia]([ID],[Maloaidocgia],[Hoten],[Diachi],[Ngaysinh],[Email],[Ngaylapthe],[Ngayhethan],[Nguoilap]) VALUES(N'16000003',2,N'Nguyễn Văn Tùng',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'tung@gmail.com',convert(datetime,'1/30/2018 00:00:00',101),convert(datetime,'1/7/2017 00:00:00',101),N'Chương Hàm')
GO
INSERT INTO [dbo].[tblDocGia]([ID],[Maloaidocgia],[Hoten],[Diachi],[Ngaysinh],[Email],[Ngaylapthe],[Ngayhethan],[Nguoilap]) VALUES(N'16000004',1,N'Nguyễn Quang Minh',N'134 Cộng Hòa, Quận Tân Bình, TP HCM',convert(datetime,'12/30/2000 00:00:00',101),N'minh@gmail.com',convert(datetime,'1/30/2018 00:00:00',101),convert(datetime,'1/7/2017 00:00:00',101),N'Đinh Lĩnh')
GO