USE [Internet]
GO
/****** Object:  Table [dbo].[Thanh_vien]    Script Date: 5/5/2020 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thanh_vien](
	[Use_name] [nvarchar](50) NOT NULL,
	[Pass_word] [nvarchar](50) NOT NULL,
	[Name] [nchar](10) NULL,
	[Year_of_birth] [int] NULL,
	[Citizen_identification] [nchar](10) NULL,
	[Phone_number] [int] NULL,
	[Account_balance] [money] NOT NULL,
 CONSTRAINT [PK_Thanh_vien] PRIMARY KEY CLUSTERED 
(
	[Use_name] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Thuc_Don]    Script Date: 5/5/2020 9:10:22 AM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Thuc_Don](
	[MaSP] [nchar](10) NOT NULL,
	[TenMonAn] [nchar](10) NULL,
	[LoaiMonAn] [nchar](10) NULL,
	[DonGia] [int] NULL,
 CONSTRAINT [PK_Thuc_Don] PRIMARY KEY CLUSTERED 
(
	[MaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
INSERT [dbo].[Thanh_vien] ([Use_name], [Pass_word], [Name], [Year_of_birth], [Citizen_identification], [Phone_number], [Account_balance]) VALUES (N'dung', N'123', N'dung      ', NULL, NULL, NULL, 50000.0000)
