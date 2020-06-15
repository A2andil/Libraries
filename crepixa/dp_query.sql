--create database
create database crepixadb

use crepixadb

--create Company table
create table Companies(
	Id int primary key Identity(1, 1),
	ArName nvarchar(200) unique not null,
	EnName nvarchar(200) unique not null
)

--Create Countries
create table countries(
	Id int primary key Identity(1, 1),
	ArName nvarchar(50) unique not null,
	EnName nvarchar(50) unique not null
)

--create Employess Table
create table Employees(
	Id int primary key identity(1, 1),
	Name nvarchar(100) not null,
	Email nvarchar(100) unique not null,
	telephone nvarchar(20) not null,
	Picture nvarchar(200),
	Rate float,
	IncludeDate date,
	CompanyId int,
	CountryId int,
	Foreign key(CompanyId) references Companies(Id),
	Foreign key(CountryId) references Countries(Id)
)

--craete table Tags
create table Tags(
	Id int primary key Identity(1, 1),
	ArName nvarchar(100),
	EnName nvarchar(100)
)

--create table Projects
create table Projects(
	Id int Primary key Identity(1, 1),
	ArName nvarchar(100),
	EnName nvarchar(100),
	TagIds nvarchar(200),
	Images nvarchar(500),
	Descrip nvarchar(max),
	CompanyId int,
	EmployeeId int,
	foreign key(CompanyId) references Companies(Id),
	foreign key(EmployeeId) references Employees(Id)
 )

--create table Roles
create table roles(
	Id int primary key identity(1, 1),
	Name nvarchar(50) unique not null
)

-- insert admin, editor, arthur inside 
insert into roles values ('admin')
insert into roles values ('editor')
insert into roles values ('arthur')

--create table Accounts
create table Account(
	Id int primary key identity(1, 1),
	Name nvarchar(200) not null,
	Email nvarchar(200) unique not null,
	Picture nvarchar(300),
	HashPassword nvarchar(max) not null,
	RoleId int not null,
	foreign key (RoleId) references roles(id)
)

-- create table Permissions
create table PermissionsTable(
	Id int primary key identity(1, 1),
	Permission nvarchar(200) unique not null
)

--insert into table
insert into PermissionsTable values('all')
insert into PermissionsTable values('post')
insert into PermissionsTable values('edit')
insert into PermissionsTable values('delete')

--create table RolePermissions
create table RolePermissions(
	Id int primary key identity(1, 1),
	RoleId int not null,
	PermissionIds nvarchar(50),
	foreign key(RoleId) references roles(Id),
)

--insert into table default values
insert into RolePermissions values(1, '1')
insert into RolePermissions values(2, '2,3')
insert into RolePermissions values(3, '2')

--create table subscribers
create table Subcribers(
	Id int primary key identity(1, 1),
	Name nvarchar(100) not null,
	Email nvarchar(100) not null
)

--create table survies
create table survies(
	Id int primary key identity(1, 1),
	Question nvarchar(max) not null,
	QuestionType bit,
	Options nvarchar(max),
	Answer nvarchar(max)
)

--create table FAQ
create table FAQ(
	Id int primary key identity(1, 1),
	Question nvarchar(max) not null,
	Answer nvarchar(max) not null
)

--create table Offers
create table Offers(
	Id int primary key identity(1, 1),
	Offer nvarchar(max) not null,
	Price int not null,
	Discount float not null
)

--create table url sponsors
create table UrlSponsors(
	Id int primary key identity,
	CompanyId int not null,
	Urls nvarchar(max) not null,
	ShowTimes int not null,
	foreign key(CompanyId) references Companies(Id)
)

-- drop tables
drop table Companies
drop table Countries
drop table Employees
drop table Tags
drop table projects
drop table roles
drop table PermissionsTable
drop table RolePermissions
drop table survies
drop table Offers
drop table UrlSponsors

-- select tables
select * from Companies
select * from Countries
select * from Employees
select * from Tags
select * from Projects
select * from roles 
select * from PermissionsTable
select * from RolePermissions
select * from survies
select * from Offers
select * from UrlSponsors