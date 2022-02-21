Create table userdetails2 (Id int identity(1,1),FirstName varchar(200),
LastName varchar(200),Gender varchar(200),IsDeleted int default 0,DOB date,
EmailId nvarchar(200),Primary key(Id)
);
Create table tbluser2 (Id int identity(1,1),username nvarchar(28),password nvarchar(200),
userID int,IsDeleted int default 0,Primary key(Id),FOREIGN KEY(userID) references userdetails2(ID));
--tblrole
--Id PK identity(1,1)
--RoleName
--IsDeleted default value 0
create table tblrole(Id int identity(1,1),Rolename nvarchar(28),IsDeleted int default 0,Primary key(Id));
--tblmenumaster
--id PK identity(1,1)
--pagename
create table tblmenumaster(Id int identity(1,1),pagename nvarchar(28),Primary key(Id));
--tblroleusermapping
--id PK identity(1,1)
--roleid FK to ID of tblrole
--userid FK to the User
--IsDeleted default value 0
create table tblroleusermapping(Id int identity(1,1),IsDeleted int default 0,Primary key(Id),roleid int,userid int,foreign key (roleid) references tblrole(Id),
foreign key (userid) references tbluser2(Id));
--tblmenurolemapping
--id PK identity(1,1)
--menuid FK to ID of tblmenumaster
--roleid FK to ID of tblrole
--IsDeleted default value 0
create table tblmenurolemapping (Id int identity(1,1),IsDeleted int default 0,Primary key(Id),menuid int,roleid int,foreign key (menuid) references tblmenumaster(Id),
foreign key (roleid) references tblrole(Id));
select * from userdetails2;
select * from tbluser2;
select * from tblrole;
select * from tblmenumaster;
select * from tblroleusermapping;
select * from tblmenurolemapping;





Create proc GetMenuByUser(@userid int)
As Begin

select M.PageName from tbluser2 T inner join tblroleusermapping TUM on TUM.UserId=T.UserId 
inner join tblmenurolemapping MRM on MRM.RoleId=TUM.RoleId 
inner join tblmenumaster M on M.Id=MRM.MenuId where T.Id=@userid;

End
exec GetMenuByUser 1