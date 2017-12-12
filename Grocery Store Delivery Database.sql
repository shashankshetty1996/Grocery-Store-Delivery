create database grocery
use grocery;

create table loginGrocery(
UserId varchar(20),
UserPassword varchar(20),
Primary key(UserId)
)

insert into loginGrocery values('admin','admin');
select * from loginGrocery;

create table employeeGrocery(
EID int,
EName varchar(25),
Mobile_Number decimal(10),
primary key(EID));
insert into employeeGrocery values(1,'rafeh',9465925568);
insert into employeeGrocery values(2,'pranam',8115805352);
insert into employeeGrocery values(3,'shashank',8970646392);
select * from employeeGrocery;

create table payement_methodGrocery
(                     
    p_id int ,
    p_total int, 
   method varchar(100),
   primary key(p_id),
    
);
insert into payement_methodGrocery values(001,500,'cash');
insert into payement_methodGrocery values(002,800,'credit');
select * from payement_methodGrocery;

create table customersGrocery
(                     
    p_id int ,
    c_id int, 
   cname varchar(100),
   phone decimal(10),
   Caddress varchar(100),
   primary key(c_id),
   foreign key(p_id) references payement_methodGrocery
);
insert into customersGrocery values(001,100,'rafeh',7022129818,'mumbai');
insert into customersGrocery values(002,101,'afreeda',712912278,'delhi');
select * from customersGrocery;

create table orderGrocery
(                     
    o_id int ,
   e_id int,
    c_id int,
   primary key(o_id),
   foreign key(c_id) references customersGrocery,
    foreign key(e_id) references employeeGrocery,

);
insert into orderGrocery values(1,1,100);
insert into orderGrocery values(2,2,100);
select * from orderGrocery;

select * from payement_methodGrocery;
select * from customersGrocery;