--create database prog7311
create table Items(
itemID int IDENTITY(1,1) not null PRIMARY KEY,
item varchar(25),
category varchar(30),
quantity int
);

create table Carts(
cartID int IDENTITY(1,1) not null PRIMARY KEY,
itemID int foreign key references Items(itemID),
);

create table Users(
userID int IDENTITY(1,1) not null PRIMARY KEY,
cartID int foreign key references Carts(cartID),
username varchar(25),
userRole varchar(25),
userPassword varchar(10)
);

insert into Items
([item],[category]) values ('Milk','Groceries'),('Samsung S35','Technology');

insert into Users 
values('Link','admin','Jeffeffe');






