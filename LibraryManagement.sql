USE [master]
GO
/****** Object:  Database [LibraryManagement]    Script Date: 5/14/2025 10:55:50 PM ******/
CREATE DATABASE [LibraryManagement]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryManagement', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LibraryManagement.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'LibraryManagement_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\LibraryManagement_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [LibraryManagement] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryManagement].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryManagement] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryManagement] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryManagement] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryManagement] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryManagement] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryManagement] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryManagement] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryManagement] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryManagement] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryManagement] SET  ENABLE_BROKER 
GO
ALTER DATABASE [LibraryManagement] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryManagement] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryManagement] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryManagement] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryManagement] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryManagement] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryManagement] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryManagement] SET RECOVERY FULL 
GO
ALTER DATABASE [LibraryManagement] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryManagement] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryManagement] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryManagement] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryManagement] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [LibraryManagement] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [LibraryManagement] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'LibraryManagement', N'ON'
GO
ALTER DATABASE [LibraryManagement] SET QUERY_STORE = OFF
GO
USE [LibraryManagement]
GO
/****** Object:  Table [dbo].[ISBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ISBook](
	[id] [int] IDENTITY(1,1) NOT NULL,
	[mssv] [varchar](250) NOT NULL,
	[hoten] [nvarchar](250) NOT NULL,
	[coso] [nvarchar](250) NOT NULL,
	[namhoc] [varchar](250) NOT NULL,
	[dienthoai] [bigint] NOT NULL,
	[email] [nvarchar](250) NOT NULL,
	[tensach] [nvarchar](250) NOT NULL,
	[ngaymuon] [varchar](250) NOT NULL,
	[ngaytra] [nvarchar](250) NULL,
 CONSTRAINT [PK__ISBook__3213E83F18D6A3A6] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[LoginTable]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[LoginTable](
	[username] [varchar](150) NOT NULL,
	[password] [varchar](150) NOT NULL,
	[role] [nvarchar](20) NOT NULL,
	[hoten] [nvarchar](150) NOT NULL,
	[id_user] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK__loginTab__3213E83F10E316B1] PRIMARY KEY CLUSTERED 
(
	[id_user] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewBook](
	[masach] [varchar](50) NOT NULL,
	[tensach] [nvarchar](250) NOT NULL,
	[tacgia] [nvarchar](250) NOT NULL,
	[theloai] [nvarchar](250) NOT NULL,
	[soluonghientai] [bigint] NOT NULL,
	[soluong] [bigint] NOT NULL,
	[trangthai] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_NewBook_1] PRIMARY KEY CLUSTERED 
(
	[masach] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NewStudent]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NewStudent](
	[hoten] [nvarchar](250) NOT NULL,
	[mssv] [varchar](250) NOT NULL,
	[coso] [nvarchar](250) NOT NULL,
	[namhoc] [varchar](250) NOT NULL,
	[dienthoai] [bigint] NOT NULL,
	[email] [varchar](250) NOT NULL,
	[Id] [int] IDENTITY(1,1) NOT NULL,
 CONSTRAINT [PK_NewStudent] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ReturnBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ReturnBook](
	[id] [int] NOT NULL,
	[trangthai] [nvarchar](250) NOT NULL,
 CONSTRAINT [PK_ReturnBook] PRIMARY KEY CLUSTERED 
(
	[id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Status]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Status](
	[id] [int] NOT NULL,
	[trangthai] [nvarchar](250) NOT NULL
) ON [PRIMARY]
GO
SET IDENTITY_INSERT [dbo].[ISBook] ON 

INSERT [dbo].[ISBook] ([id], [mssv], [hoten], [coso], [namhoc], [dienthoai], [email], [tensach], [ngaymuon], [ngaytra]) VALUES (1, N'2254052040', N'Lê Hữu Lộc', N'Nhà Bè', N'2022', 123, N'123', N'Phân tích dữ liệu', N'Wednesday, May 14, 2025', N'đã trả')
INSERT [dbo].[ISBook] ([id], [mssv], [hoten], [coso], [namhoc], [dienthoai], [email], [tensach], [ngaymuon], [ngaytra]) VALUES (5, N'2254050034', N'Nguyễn Trí Lợi', N'Nhà Bè', N'2022', 5236, N'5236', N'Phân tích dữ liệu', N'Wednesday, May 14, 2025', N'chưa trả')
INSERT [dbo].[ISBook] ([id], [mssv], [hoten], [coso], [namhoc], [dienthoai], [email], [tensach], [ngaymuon], [ngaytra]) VALUES (20, N'2254052040', N'Lê Hữu Lộc', N'Nhà Bè', N'2022', 123, N'123', N'Phân tích dữ liệu', N'Wednesday, May 14, 2025', N'đã trả')
INSERT [dbo].[ISBook] ([id], [mssv], [hoten], [coso], [namhoc], [dienthoai], [email], [tensach], [ngaymuon], [ngaytra]) VALUES (21, N'2254050034', N'Nguyễn Trí Lợi', N'Nhà Bè', N'2022', 5236, N'5236', N'Phân tích dữ liệu', N'Wednesday, May 14, 2025', N'chưa trả')
SET IDENTITY_INSERT [dbo].[ISBook] OFF
GO
SET IDENTITY_INSERT [dbo].[LoginTable] ON 

INSERT [dbo].[LoginTable] ([username], [password], [role], [hoten], [id_user]) VALUES (N'admin', N'123', N'admin', N'ADMIN', 1)
INSERT [dbo].[LoginTable] ([username], [password], [role], [hoten], [id_user]) VALUES (N'user', N'123', N'user', N'USER', 4)
SET IDENTITY_INSERT [dbo].[LoginTable] OFF
GO
INSERT [dbo].[NewBook] ([masach], [tensach], [tacgia], [theloai], [soluonghientai], [soluong], [trangthai]) VALUES (N'MS001', N'Phân tích dữ liệu', N'Hồ Hướng Thiên', N'Sách học', 2, 54, N'Còn sách')
INSERT [dbo].[NewBook] ([masach], [tensach], [tacgia], [theloai], [soluonghientai], [soluong], [trangthai]) VALUES (N'MS002', N'Công nghệ phần mềm', N'Nguyễn Trung Hậu', N'Sách học', 3, 35, N'Còn sách')
INSERT [dbo].[NewBook] ([masach], [tensach], [tacgia], [theloai], [soluonghientai], [soluong], [trangthai]) VALUES (N'MS003', N'Lập trình cơ sở dữ liệu', N'Lê Viết Tuấn', N'Sách học', 0, 32, N'Đã hết')
INSERT [dbo].[NewBook] ([masach], [tensach], [tacgia], [theloai], [soluonghientai], [soluong], [trangthai]) VALUES (N'MS004', N'Phát triền hệ thống thông tin', N'Phạm Chí Công', N'Sách học', 24, 52, N'Còn sách')
INSERT [dbo].[NewBook] ([masach], [tensach], [tacgia], [theloai], [soluonghientai], [soluong], [trangthai]) VALUES (N'MS005', N'Đắc nhân tâm', N'Dale Carnegie', N'Sách đời sống', 34, 100, N'Còn sách')
INSERT [dbo].[NewBook] ([masach], [tensach], [tacgia], [theloai], [soluonghientai], [soluong], [trangthai]) VALUES (N'MS006', N'Bồ câu không đưa thư', N'Nguyễn Nhật Ánh', N'Truyện', 100, 100, N'Còn sách')
GO
SET IDENTITY_INSERT [dbo].[NewStudent] ON 

INSERT [dbo].[NewStudent] ([hoten], [mssv], [coso], [namhoc], [dienthoai], [email], [Id]) VALUES (N'Lê Hữu Lộc', N'2254052040', N'Nhà Bè', N'2022', 123, N'2254052040loc@ou.edu.vn', 1)
INSERT [dbo].[NewStudent] ([hoten], [mssv], [coso], [namhoc], [dienthoai], [email], [Id]) VALUES (N'Nguyễn Thị A', N'2354050031', N'Mai thị Lựu', N'2023', 134, N'2354050031c@ou.edu.vn', 2)
INSERT [dbo].[NewStudent] ([hoten], [mssv], [coso], [namhoc], [dienthoai], [email], [Id]) VALUES (N'Nguyễn Trí Lợi', N'2254050034', N'Nhà Bè', N'2022', 5236, N'2254050034loi@ou.edu.vn', 3)
INSERT [dbo].[NewStudent] ([hoten], [mssv], [coso], [namhoc], [dienthoai], [email], [Id]) VALUES (N'Nguyễn Văn A', N'2254050033', N'Mai Thị Lựu ', N'2022', 521, N'2254050033a@ou.edu.vn', 4)
INSERT [dbo].[NewStudent] ([hoten], [mssv], [coso], [namhoc], [dienthoai], [email], [Id]) VALUES (N'Nguyễn Văn B', N'2154050032', N'Võ Văn Tần', N'2021', 1235, N'2154050032b@ou.edu.vn', 5)
SET IDENTITY_INSERT [dbo].[NewStudent] OFF
GO
INSERT [dbo].[ReturnBook] ([id], [trangthai]) VALUES (1, N'đã trả')
INSERT [dbo].[ReturnBook] ([id], [trangthai]) VALUES (2, N'chưa trả')
GO
INSERT [dbo].[Status] ([id], [trangthai]) VALUES (1, N'Còn sách')
INSERT [dbo].[Status] ([id], [trangthai]) VALUES (2, N'Hết sách')
GO
ALTER TABLE [dbo].[LoginTable] ADD  CONSTRAINT [DF__LoginTable__role__14270015]  DEFAULT ('user') FOR [role]
GO
ALTER TABLE [dbo].[ISBook]  WITH CHECK ADD  CONSTRAINT [FK_ISBook_ISBook] FOREIGN KEY([id])
REFERENCES [dbo].[ISBook] ([id])
GO
ALTER TABLE [dbo].[ISBook] CHECK CONSTRAINT [FK_ISBook_ISBook]
GO
ALTER TABLE [dbo].[LoginTable]  WITH CHECK ADD  CONSTRAINT [FK_LoginTable_LoginTable] FOREIGN KEY([id_user])
REFERENCES [dbo].[LoginTable] ([id_user])
GO
ALTER TABLE [dbo].[LoginTable] CHECK CONSTRAINT [FK_LoginTable_LoginTable]
GO
/****** Object:  StoredProcedure [dbo].[proc_login]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[proc_login]
@username nvarchar(150),
@password  nvarchar(150)
as
begin 
	select * from LoginTable where username=@username and pass=@password
end
GO
/****** Object:  StoredProcedure [dbo].[uspAddAccount]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAddAccount]
    @username varchar(150),
    @password varchar(150),
	@role nvarchar(20),
	@hoten nvarchar(150)
AS
BEGIN
    INSERT INTO LoginTable (username, password,role,hoten)
    VALUES (@username, @password,@role,@hoten)
END
GO
/****** Object:  StoredProcedure [dbo].[uspAddBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[uspAddBook]
	@masach varchar(250),
	@tensach nvarchar(250),
	@tacgia nvarchar(250),
	@theloai nvarchar(250),
	@soluonghientai bigint,
	@soluong bigint,
	@trangthai nvarchar(250)
AS 
BEGIN
	INSERT INTO NewBook(masach,tensach,tacgia,theloai,soluonghientai,soluong,trangthai)
	VALUES(@masach,@tensach,@tacgia,@theloai,@soluonghientai,@soluong,@trangthai);
END
GO
/****** Object:  StoredProcedure [dbo].[uspAddStudent]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROC [dbo].[uspAddStudent]
	@hoten varchar(250),
	@mssv nvarchar(250),
	@coso nvarchar(250),
	@namhoc nvarchar(250),
	@dienthoai bigint,
	@email nvarchar(250)
	
AS 
BEGIN
	INSERT INTO NewStudent(hoten,mssv,coso,namhoc,dienthoai,email)
	VALUES(@hoten,@mssv,@coso,@namhoc,@dienthoai,@email);
END
GO
/****** Object:  StoredProcedure [dbo].[uspAddStudentBorrowBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[uspAddStudentBorrowBook]
	@mssv varchar(250), 
	@hoten nvarchar(250),
	@coso nvarchar(250),
	@namhoc varchar(250),
	@dienthoai bigint,
	@email varchar(250),
	@tensach nvarchar(250),
	@ngaymuon varchar(250)
AS
BEGIN
    INSERT INTO ISBook (mssv, hoten,coso,namhoc,dienthoai,email,tensach,ngaymuon)
    VALUES (@mssv, @hoten,@coso,@namhoc,@dienthoai,@email,@tensach,@ngaymuon)
END
GO
/****** Object:  StoredProcedure [dbo].[uspDeleteBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[uspDeleteBook]
	@masach nvarchar(250)
AS 
BEGIN
	DELETE FROM NewBook 
	WHERE masach=@masach;
END
GO
/****** Object:  StoredProcedure [dbo].[uspDeleteReturnBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspDeleteReturnBook]
	@id int
AS
BEGIN 
    DELETE FROM ISbook 
	WHERE id=@id;
END
GO
/****** Object:  StoredProcedure [dbo].[uspDeleteStudent]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[uspDeleteStudent]
	@mssv nvarchar(250)
AS 
BEGIN
	DELETE FROM NewStudent 
	WHERE mssv=@mssv;
END
GO
/****** Object:  StoredProcedure [dbo].[uspUpdateBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[uspUpdateBook]
	@masach varchar(250),
	@tensach nvarchar(250),
	@tacgia nvarchar(250),
	@theloai nvarchar(250),
	@soluonghientai bigint,
	@soluong bigint,
	@trangthai nvarchar(250)
AS 
BEGIN
	UPDATE NewBook
    SET 
        masach= @masach,
        tensach = @tensach,
		tacgia=@tacgia,
		theloai=@theloai,
		soluonghientai=@soluonghientai,
		soluong=@soluong,
		trangthai=@trangthai
    WHERE masach = @masach;
END
GO
/****** Object:  StoredProcedure [dbo].[uspUpdateReturnBook]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[uspUpdateReturnBook]
	@mssv varchar(250), 
	@hoten nvarchar(250),
	@coso nvarchar(250),
	@namhoc varchar(250),
	@dienthoai bigint,
	@email varchar(250),
	@tensach nvarchar(250),
	@ngaymuon varchar(250),
	@ngaytra nvarchar(250)
AS
BEGIN
   UPDATE ISBook
    SET 
        mssv= @mssv,
        hoten = @hoten,
		coso=@coso,
		namhoc=@namhoc,
		dienthoai=@dienthoai,
		email=@email,
		tensach=@tensach,
		ngaymuon=@ngaymuon,
		ngaytra=@ngaytra
    WHERE mssv = @mssv;
END
GO
/****** Object:  StoredProcedure [dbo].[uspUpdateSeat]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[uspUpdateSeat]
	@maso varchar(100),
	@khuvuc nvarchar(50),
	@loai nvarchar(30),
	@dienthoai bigint,
	@trangthai nvarchar(20)
AS 
BEGIN
	UPDATE Seat
    SET 
        maso = @maso,
		khuvuc=@khuvuc,
		loai=@loai,
		trangthai=@trangthai
    WHERE maso = @maso;
END
GO
/****** Object:  StoredProcedure [dbo].[uspUpdateStudent]    Script Date: 5/14/2025 10:55:50 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
--uspUpdateStudent
CREATE PROC [dbo].[uspUpdateStudent]
	@hoten nvarchar(250),
	@mssv nvarchar(250),
	@coso nvarchar(250),
	@namhoc nvarchar(250),
	@dienthoai bigint,
	@email nvarchar(250)
AS 
BEGIN
	UPDATE NewStudent
    SET 
        hoten= @hoten,
        mssv = @mssv,
		coso=@coso,
		namhoc=@namhoc,
		dienthoai=@dienthoai,
		email=@email
    WHERE mssv = @mssv;
END
GO
USE [master]
GO
ALTER DATABASE [LibraryManagement] SET  READ_WRITE 
GO
