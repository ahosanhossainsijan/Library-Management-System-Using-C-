USE [master]
GO
/****** Object:  Database [This_Project]    Script Date: 12/25/2019 8:33:31 PM ******/
CREATE DATABASE [This_Project]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'This_Project', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\This_Project.mdf' , SIZE = 4096KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'This_Project_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.MSSQLSERVER\MSSQL\DATA\This_Project_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [This_Project] SET COMPATIBILITY_LEVEL = 110
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [This_Project].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [This_Project] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [This_Project] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [This_Project] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [This_Project] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [This_Project] SET ARITHABORT OFF 
GO
ALTER DATABASE [This_Project] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [This_Project] SET AUTO_CREATE_STATISTICS ON 
GO
ALTER DATABASE [This_Project] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [This_Project] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [This_Project] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [This_Project] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [This_Project] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [This_Project] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [This_Project] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [This_Project] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [This_Project] SET  DISABLE_BROKER 
GO
ALTER DATABASE [This_Project] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [This_Project] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [This_Project] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [This_Project] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [This_Project] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [This_Project] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [This_Project] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [This_Project] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [This_Project] SET  MULTI_USER 
GO
ALTER DATABASE [This_Project] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [This_Project] SET DB_CHAINING OFF 
GO
ALTER DATABASE [This_Project] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [This_Project] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
USE [This_Project]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 12/25/2019 8:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[AuthorName] [nvarchar](50) NOT NULL,
	[Isbn] [nvarchar](50) NOT NULL,
	[Quaintity] [int] NOT NULL,
	[PurchaseDate] [date] NOT NULL,
	[CategoryId] [int] NULL,
	[Price] [float] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BookDetails]    Script Date: 12/25/2019 8:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookDetails](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[BookId] [int] NOT NULL,
	[Status] [nvarchar](50) NOT NULL,
	[DaskNo] [int] NOT NULL,
 CONSTRAINT [PK_BookDetails] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[BorrowHistory]    Script Date: 12/25/2019 8:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BorrowHistory](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [int] NOT NULL,
	[BookDetailsId] [int] NOT NULL,
	[BorrowDate] [date] NOT NULL,
	[ExpectedReturnDate] [date] NOT NULL,
	[ReturnDate] [date] NULL,
	[LateFine] [float] NULL,
	[LostFine] [float] NULL,
 CONSTRAINT [PK_BorrowHistory] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Category]    Script Date: 12/25/2019 8:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[ShowFine]    Script Date: 12/25/2019 8:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ShowFine](
	[UserId] [int] NULL,
	[Date] [date] NULL,
	[LateFine] [int] NULL,
	[LostFine] [int] NULL,
	[Id] [int] NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[UserInfo]    Script Date: 12/25/2019 8:33:31 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[UserInfo](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Name] [nvarchar](50) NOT NULL,
	[UserName] [nvarchar](50) NOT NULL,
	[Password] [nvarchar](50) NOT NULL,
	[Type] [int] NOT NULL,
 CONSTRAINT [PK_UserInfo] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([Id], [Name], [AuthorName], [Isbn], [Quaintity], [PurchaseDate], [CategoryId], [Price]) VALUES (1, N'Himu rimand a', N'Humayan Ahmad', N'2656566', 50, CAST(0x7C400B00 AS Date), 1, 5550.5)
INSERT [dbo].[Book] ([Id], [Name], [AuthorName], [Isbn], [Quaintity], [PurchaseDate], [CategoryId], [Price]) VALUES (2, N'Hajabarala', N'Sukumar Roy', N'12354645', 30, CAST(0x84400B00 AS Date), 2, 2000)
INSERT [dbo].[Book] ([Id], [Name], [AuthorName], [Isbn], [Quaintity], [PurchaseDate], [CategoryId], [Price]) VALUES (3, N'Hajabarala2', N'Sukumar Roy', N'1235445', 30, CAST(0x84400B00 AS Date), 2, 2000)
INSERT [dbo].[Book] ([Id], [Name], [AuthorName], [Isbn], [Quaintity], [PurchaseDate], [CategoryId], [Price]) VALUES (4, N'Amar Ami', N'Sijan Ahosan', N'126554665', 10, CAST(0x85400B00 AS Date), 2, 500)
INSERT [dbo].[Book] ([Id], [Name], [AuthorName], [Isbn], [Quaintity], [PurchaseDate], [CategoryId], [Price]) VALUES (5, N'Padma Nodir Majhi', N'Manik Bondhopaddhay', N'531231313', 10, CAST(0x86400B00 AS Date), 3, 1500)
INSERT [dbo].[Book] ([Id], [Name], [AuthorName], [Isbn], [Quaintity], [PurchaseDate], [CategoryId], [Price]) VALUES (6, N'Ami Topu', N'Dr.Jafor Iqbal', N'153213215', 10, CAST(0x83400B00 AS Date), 2, 1000)
SET IDENTITY_INSERT [dbo].[Book] OFF
SET IDENTITY_INSERT [dbo].[BookDetails] ON 

INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (1, 1, N'1', 2)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (2, 1, N'1', 2)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (3, 5, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (4, 5, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (5, 5, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (6, 5, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (7, 5, N'3', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (8, 5, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (9, 5, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (10, 5, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (11, 5, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (12, 5, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (13, 6, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (14, 6, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (15, 6, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (16, 6, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (17, 6, N'1', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (18, 6, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (19, 6, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (20, 6, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (21, 6, N'0', 1)
INSERT [dbo].[BookDetails] ([Id], [BookId], [Status], [DaskNo]) VALUES (22, 6, N'0', 1)
SET IDENTITY_INSERT [dbo].[BookDetails] OFF
SET IDENTITY_INSERT [dbo].[BorrowHistory] ON 

INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (1, 2, 8, CAST(0x88400B00 AS Date), CAST(0x8F400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (4, 1, 11, CAST(0x88400B00 AS Date), CAST(0xA7400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (5, 1, 12, CAST(0x88400B00 AS Date), CAST(0xA7400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (6, 1, 20, CAST(0x88400B00 AS Date), CAST(0xA7400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (7, 2, 20, CAST(0x88400B00 AS Date), CAST(0x8F400B00 AS Date), CAST(0x93400B00 AS Date), 200, 0)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (8, 2, 20, CAST(0x88400B00 AS Date), CAST(0x8F400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (9, 2, 20, CAST(0x88400B00 AS Date), CAST(0x8F400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (10, 2, 20, CAST(0x88400B00 AS Date), CAST(0x8F400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (11, 1, 8, CAST(0x88400B00 AS Date), CAST(0xA7400B00 AS Date), CAST(0x93400B00 AS Date), 0, 0)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (12, 1, 8, CAST(0x88400B00 AS Date), CAST(0xA7400B00 AS Date), CAST(0x91400B00 AS Date), 0, 0)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (13, 1, 11, CAST(0x88400B00 AS Date), CAST(0xA7400B00 AS Date), NULL, NULL, NULL)
INSERT [dbo].[BorrowHistory] ([Id], [UserId], [BookDetailsId], [BorrowDate], [ExpectedReturnDate], [ReturnDate], [LateFine], [LostFine]) VALUES (14, 1, 11, CAST(0x88400B00 AS Date), CAST(0xA7400B00 AS Date), NULL, NULL, NULL)
SET IDENTITY_INSERT [dbo].[BorrowHistory] OFF
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([Id], [Name]) VALUES (1, N'History')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (2, N'Story')
INSERT [dbo].[Category] ([Id], [Name]) VALUES (3, N'Literature')
SET IDENTITY_INSERT [dbo].[Category] OFF
INSERT [dbo].[ShowFine] ([UserId], [Date], [LateFine], [LostFine], [Id]) VALUES (0, CAST(0x88400B00 AS Date), 0, 0, 1)
INSERT [dbo].[ShowFine] ([UserId], [Date], [LateFine], [LostFine], [Id]) VALUES (2, CAST(0x88400B00 AS Date), 0, 100, 2)
INSERT [dbo].[ShowFine] ([UserId], [Date], [LateFine], [LostFine], [Id]) VALUES (0, CAST(0x88400B00 AS Date), 0, 0, 3)
SET IDENTITY_INSERT [dbo].[UserInfo] ON 

INSERT [dbo].[UserInfo] ([Id], [Name], [UserName], [Password], [Type]) VALUES (1, N'Sijan Ahosan', N'18-37099-1', N'123456', 2)
INSERT [dbo].[UserInfo] ([Id], [Name], [UserName], [Password], [Type]) VALUES (2, N'Sijan Ahosan', N'1111', N'123456', 3)
INSERT [dbo].[UserInfo] ([Id], [Name], [UserName], [Password], [Type]) VALUES (5, N'Sijan Ahosan', N'2222', N'123456', 1)
INSERT [dbo].[UserInfo] ([Id], [Name], [UserName], [Password], [Type]) VALUES (6, N'Hemal', N'3333', N'123456', 3)
SET IDENTITY_INSERT [dbo].[UserInfo] OFF
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category] FOREIGN KEY([CategoryId])
REFERENCES [dbo].[Category] ([Id])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category]
GO
ALTER TABLE [dbo].[BookDetails]  WITH CHECK ADD  CONSTRAINT [FK_BookDetails_BookDetails] FOREIGN KEY([BookId])
REFERENCES [dbo].[Book] ([Id])
GO
ALTER TABLE [dbo].[BookDetails] CHECK CONSTRAINT [FK_BookDetails_BookDetails]
GO
ALTER TABLE [dbo].[BorrowHistory]  WITH CHECK ADD  CONSTRAINT [FK_BorrowHistory_BookDetails] FOREIGN KEY([BookDetailsId])
REFERENCES [dbo].[BookDetails] ([Id])
GO
ALTER TABLE [dbo].[BorrowHistory] CHECK CONSTRAINT [FK_BorrowHistory_BookDetails]
GO
USE [master]
GO
ALTER DATABASE [This_Project] SET  READ_WRITE 
GO
