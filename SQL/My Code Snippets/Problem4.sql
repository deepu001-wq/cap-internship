create table Orders2(customer_id int,cust_name varchar(50),city varchar(50),grade int,salesman_id int) 
insert into Orders2 values(3002,'Nick','New York',100,5001);
insert into Orders2 values(3007,'Brad','New York',200,5001);
insert into Orders2 values(3005,'Graham','California',200,5002);
insert into Orders2 values(3008,'julian','London',300,5002);
insert into Orders2 values(3004,'Fabian','paris',300,5006);
insert into Orders2 values(3009,'Geoff','Berlin',100,5003);
insert into Orders2 values(3003,'Jozy','Moscow',200,5007);
insert into Orders2 values(3001,'Brad Guzan','London',NULL,5005);
Select * from Orders2;
Select city,MAX(grade) from orders2 GROUP BY city;