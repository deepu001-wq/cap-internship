create table Orders(ord_no int,purch_amt int,ord_date DATE,cust_id int,salesman_id int) 
insert into Orders values(70001,150.5,'2012-10-05',3005,5002);
insert into Orders values(70009,270.65,'2012-09-10',3001,5005);
insert into Orders values(70002,62.56,'2012-10-05',3002,5001);
insert into Orders values(70004,110.5,'2012-08-17',3009,5003);
insert into Orders values(70007,948.5,'2012-09-10',3005,5002);
insert into Orders values(70005,2400.6,'2012-07-27',3007,5001);
insert into Orders values(70008,5760,'2012-09-10',3002,5001);
select * from Orders;
SELECT COUNT (DISTINCT salesman_id) 
FROM Orders;


