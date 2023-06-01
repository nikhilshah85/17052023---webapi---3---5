create database bankingDB

use bankingDB

create table branchInfo
(
	brNo int primary key,
	brName varchar(20),
	brCity varchar(20)
)
insert into branchinfo values(10,'Hi-tech','Hyderabad')
insert into branchinfo values(20,'Kothrud','Pune')
insert into branchinfo values(30,'TNagar','Chennai')
insert into branchinfo values(40,'WhiteField','Bangalore')

create table AccountsInfo
(
	accNo int primary key,
	accName varchar(20),
	accType varchar(20),
	accBalance int,
	accIsActive bit
	)

	insert into AccountsInfo values(101,'Nikhil','Savings',5000,1)
	insert into AccountsInfo values(102,'Kriti','Savings',5000,1)
	insert into AccountsInfo values(103,'Aman','Savings',5000,1)
	insert into AccountsInfo values(104,'Sahil','Savings',5000,1)