USE [Internet]
GO
/****** Object:  Table [dbo].[Thanh_vien]    Script Date: 07-May-20 4:19:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thanh_vien](
	[User_name] [nvarchar](50) NOT NULL,
	[Pass_word] [nvarchar](50) NOT NULL,
	[Name] [nchar](10) NULL,
	[Year_of_birth] [int] NULL,
	[Citizen_identification] [nchar](10) NULL,
	[Phone_number] [int] NULL,
	[Account_balance] [money] NOT NULL,
 CONSTRAINT [PK_Thanh_vien] PRIMARY KEY CLUSTERED 
(
	[User_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuc_Don]    Script Date: 07-May-20 4:19:04 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuc_Don](
	[MaSP] [nvarchar](50) NULL,
	[TenMonAn] [nvarchar](50) NULL,
	[LoaiMonAn] [nvarchar](50) NULL,
	[DonGia] [nvarchar](50) NULL
) ON [PRIMARY]

GO
INSERT [dbo].[Thanh_vien] ([User_name], [Pass_word], [Name], [Year_of_birth], [Citizen_identification], [Phone_number], [Account_balance]) VALUES (N'dung', N'123', N'dung      ', NULL, NULL, NULL, 50000.0000)
INSERT [dbo].[Thuc_Don] ([MaSP], [TenMonAn], [LoaiMonAn], [DonGia]) VALUES (N'001', N'Mi Xao Bo', N'MonChinh', N'15000')
INSERT [dbo].[Thuc_Don] ([MaSP], [TenMonAn], [LoaiMonAn], [DonGia]) VALUES (N'002', N'Heniken', N'DoUong', N'13000')
INSERT [dbo].[Thuc_Don] ([MaSP], [TenMonAn], [LoaiMonAn], [DonGia]) VALUES (N'003', N'Snack', N'AnNhe', N'5000')
