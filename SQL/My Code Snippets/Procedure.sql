--creation of procedure
Create Proc GetAllInformation as
begin

select first.dbo.GetEmployeeFullName(E.Id) as EmployeeName,Gender,EmployeeEmail,D.Department from employee2 E 
inner join EmployeeDepartmentMapping EDM on EDM.EmployeeID=E.Id inner join department2 D on D.Id=EDM.DepartmentID;

end