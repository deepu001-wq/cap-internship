--create table table name (columns)
create table datainfo (ID int,Name varchar(2000))
--to see the data inside table
select * from datainfo
--to see only specific columns
select ID from datainfo

--insert data into tables
insert into datainfo values(1,'Vikash 1')
insert into datainfo values(2,'Vikash2')
insert into datainfo values(3,'Vikash3')
insert into datainfo values(4,'Vikash4')
--to update the data we have update command
update datainfo set Name='Vikash 1'
 
--clauses where
update datainfo set Name='Vikash 2'  where ID=2;
--delete data from tables
delete datainfo where  ID=3;
--In clause
delete datainfo where  ID in (2,4)
--drop --remove something from schema
drop table datainfo;
Create table Employee (employeeid int ,employeeName varchar(200),Gender varchar(200),Salary int);

select * from Employee 

insert into Employee values(101,'Vikash4','Male',10000)

Create table Department (DepartmentID int ,DepartmentName varchar(200));
select * from Department 