Create proc [dbo].[SP_THONGTINDANGNHAP]
@TENLOGIN nvarchar(50)
as
Declare @TENUSER nvarchar(50), @UserID int
Select @UserID=UId, @TENUSER=NAME from sys.sysusers where sid=SUSER_SID(@TENLOGIN)
Select USER_NAME=@TENUSER, HOTEN= (Select HO+' '+TEN from [TN_CSDLPT].dbo.SINHVIEN where MASV=@TENUSER),NAME
from sys.sysusers
where uid=(select GROUPUID from sys.sysmembers where memberuid=@UserID)

create proc [dbo].[SP_TAOTAIKHOAN]
@LGNAME varchar(50),@PASS varchar(50),
@USERNAME varchar(50),@ROLE varchar(50)
as
Declare @RET int
exec @RET= sp_addlogin @LGNAME, @PASS,'COICHAMTHI'
if(@RET=1) --Login name bi trung
begin
	raiserror ('Login name b? trùng',16,1)
	return
end
exec @RET=sp_grantdbaccess @LGNAME, @USERNAME
if(@RET=1) --Username bi trung
begin
	exec sp_droplogin @LGNAME
	raiserror('Sinh vien da co login name',16,2)
	return
end
exec sp_addrolemember @ROLE, @USERNAME
if @ROLE='ADMIN'
begin
	exec sp_addsrvrolemember @LGNAME, 'SecurityAdmin'
	exec sp_addsrvrolemember @LGNAME, 'DBCREATOR'
	exec sp_addsrvrolemember @LGNAME, 'ProcessAdmin'
end