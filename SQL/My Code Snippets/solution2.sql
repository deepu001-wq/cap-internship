Create table userdetails (Id int identity(1,1),FirstName varchar(200),
LastName varchar(200),Gender varchar(200),IsDeleted int default 0,DOB date,
EmailId nvarchar(200),Primary key(Id)
);
Create table tbluser (Id int identity(1,1),username nvarchar(28),password nvarchar(200),
userID int,IsDeleted int default 0,Primary key(Id),FOREIGN KEY(userID) references userdetails(ID));
select * from userdetails;
select * from tbluser;
Create Proc Login(@username nvarchar(200),@password nvarchar(200)) as
begin


if((select count(*) from tbluser where username=@username and [password]=@password)>0) 
select 1 as ValidUserName;
else
select 0 as ValidUserName;



END

exec Login 'deepu@dummy.com','123456'

Create Proc AddUserDetails(@firstname nvarchar(200),@lastname nvarchar(200),@gender varchar(20),@dob date,@email nvarchar(200)) as
begin


insert into userdetails(FirstName,LastName,Gender,DOB,EmailId) values(@firstname,@lastname,@gender,@dob,@email);
insert into tbluser(username,[password],UserID) values(@email,'123456',IDENT_CURRENT('userdetails'))

END

exec AddUserDetails 'Sumit','Kumar','Male','12/09/1978','Sumit.Kumar@dummy.com'

