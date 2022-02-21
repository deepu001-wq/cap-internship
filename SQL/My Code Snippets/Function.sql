create function GetEmployeeFullName(@EmployeeID int) returns varchar(200) as 
Begin
return (select Concat(EmployeeFirstName,EmployeeLastName) as EmployeeName from employee2 where Id=@EmployeeID);
END;
