DROP DATABASE IF EXISTS empinfo;
create database empinfo;
use empinfo;
create table employees (empid integer primary key auto_increment, ename varchar(50), sal decimal);
insert into employees values(10, "Sufiyan",1000);
insert into employees(ename, sal) values("sahil",1000);