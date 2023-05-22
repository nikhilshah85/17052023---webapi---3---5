create database shoppingDBAPI

use shoppingDBAPI

create table productsList
(
	pId int primary key,
	pName varchar(20),
	pCategory varchar(20),
	pPrice int,
	pIsInStock bit
)

insert into productsList values(101,'Pepsi','Cold-Drink',50,1)
insert into productsList values(102,'IPhone','Watch',50,1)
insert into productsList values(103,'Fossil','Watch',50,0)
insert into productsList values(104,'IPad','Electronics',50,1)
insert into productsList values(105,'Nike','Shoe',50,0)



select * from productsList




alter table productsList add  pDiscount float
create table customersList
(
	cId int primary key,
	cName varchar(20),
	cType varchar(20),
	cWalletBalance int
)

insert into customersList values(501,'Nikhil','Regular',200)
insert into customersList values(502,'Rahul','Regular',200)
insert into customersList values(503,'Karan','Occassional',200)
insert into customersList values(504,'Mohan','Regular',200)
insert into customersList values(505,'Rohan','Regular',200)
insert into customersList values(506,'Sohan','Regular',200)
insert into customersList values(507,'Kriti','Occassional',200)
insert into customersList values(508,'Meet','Regular',200)




select * from productsList
select * from customersList