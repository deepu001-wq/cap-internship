create table StudentDetail(id int,StudentName varchar(200))
select * from StudentDetail
insert into StudentDetail values(1,'deepu');
insert into StudentDetail values(2,'deepu 2');
insert into StudentDetail values(3,'deepu 3');
insert into StudentDetail values(4,'deepu 4');
alter table StudentDetail add gender varchar(30)

update StudentDetail set gender='Male' 
update StudentDetail set gender='Female' where ID in (2,4)
