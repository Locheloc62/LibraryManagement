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
GO
--------------------------

CREATE PROCEDURE uspAddStudentBorrowBook
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
	-- Kiểm tra xem dữ liệu đã tồn tại chưa
	IF NOT EXISTS (
		SELECT 1 FROM ISBook 
		WHERE mssv = @mssv AND tensach = @tensach 
	)
	BEGIN
		-- Nếu chưa có thì mới thêm
		INSERT INTO ISBook (mssv, hoten, coso, namhoc, dienthoai, email, tensach, ngaymuon)
		VALUES (@mssv, @hoten, @coso, @namhoc, @dienthoai, @email, @tensach, @ngaymuon)
	END
	ELSE
	BEGIN
		-- Có thể thông báo bằng cách trả giá trị (nếu cần)
		RAISERROR('Thông tin đã tồn tại. Không thể thêm.', 16, 1)
	END
END
GO
drop proc uspAddStudentBorrowBook
GO

CREATE PROCEDURE uspUpdateReturnBook
	@id int,
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
    WHERE mssv = @mssv and id=@id;
END
GO 

CREATE PROCEDURE uspDeleteReturnBook
	@id int
AS
BEGIN 
    DELETE FROM ISbook 
	WHERE id=@id;
END
GO

drop proc uspUpdateReturnBook