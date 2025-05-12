USE LibraryManagement
GO
--uspAddStudent
CREATE PROC uspAddStudent
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
--uspDeleteStudent
CREATE PROC uspDeleteStudent
	@mssv nvarchar(250)
AS 
BEGIN
	DELETE FROM NewStudent 
	WHERE mssv=@mssv;
END
GO
--uspUpdateStudent
CREATE PROC uspUpdateStudent
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
-------------------------------
--BOOK
-------------------------------
--uspAddStudent

CREATE PROC uspAddBook
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
--uspDeleteStudent
CREATE PROC uspDeleteBook
	@masach nvarchar(250)
AS 
BEGIN
	DELETE FROM NewBook 
	WHERE masach=@masach;
END
GO
--uspUpdateStudent
CREATE PROC uspUpdateBook
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
---------------------
--REGISTER--------------
------------------------

CREATE PROCEDURE uspAddAccount
    @username varchar(150),
    @password varchar(150),
	@role nvarchar(20),
	@hoten nvarchar(150)
AS
BEGIN
    INSERT INTO LoginTable (username, password,role,hoten)
    VALUES (@username, @password,@role,@hoten)
END

drop proc uspAddAccount