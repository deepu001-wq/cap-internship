use first;
--employee table creation
Create table employee2 (Id int identity(1,1),EmployeeID nvarchar(28),EmployeeFirstName varchar(200),
EmployeeLastName varchar(200),Gender varchar(200),IsDeleted int default 0,EmployeeAge int,EmployeeDataofBirth date,
EmployeeEmail nvarchar(200),Primary key(Id)
);
--Department table creation
create table department2(Id int identity(1,1),Department varchar(200),IsDeleted int default 0, Primary key(Id));
--Employee Department mapping table creation
create table EmployeeDepartmentMapping(Id int identity(1,1),EmployeeID  int ,DepartmentID int,Primary key(Id),
FOREIGN KEY(EmployeeID) References employee2(ID),FOREIGN KEY(DepartmentID) References department2(ID));
--calling a function
select first.dbo.GetEmployeeFullName(1);
--select query to get all information
select first.dbo.GetEmployeeFullName(E.Id) as EmployeeName,Gender,EmployeeEmail,D.Department from employee2 E 
inner join EmployeeDepartmentMapping EDM on EDM.EmployeeID=E.Id inner join department2 D on D.Id=EDM.DepartmentID;
--executing the procedure
exec GetAllInformation;
select * from employee2

