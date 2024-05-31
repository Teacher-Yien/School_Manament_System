Create database enrolldb
go

use enrolldb
go

--drop table students
create table students
(
	id varchar(36) primary key,
	firstname nvarchar(30),
	lastname nvarchar(30),
	gender int null,
	age tinyint
) 
go

--drop table courses
Create table courses
(
	id varchar(36) primary key,
	code varchar(20) unique not null,
	name nvarchar(30) not null
)
go

--drop table enrollings
create table enrollings
(
	id varchar(36) primary key,
	studentid varchar(36),
	courseid varchar(36),
	begdate datetime,
	enddate datetime,
	constraint FK_Enrollings_Students foreign key (studentid) references students(id) on update cascade on delete no action,
	constraint FK_Enrollings_Courses foreign key (courseid) references courses(id) on update cascade on delete no action,
)
go