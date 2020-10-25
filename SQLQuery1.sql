create proc spgetSVByTenKhoa
@tenkhoa nvarchar(50)
as
begin
	Select * from SINHVIEN Where TENK = @tenkhoa
end