USE LibraryManagement
GO

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

drop proc uspAddStudent