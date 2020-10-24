use master
go
drop database CSDESK_CustomerManagement
go
create database CSDESK_CustomerManagement
go
use CSDESK_CustomerManagement
go
create table Customer
(
	id int identity primary key,
	name nvarchar(50),
	address nvarchar(50),
	city nvarchar(50),
	country nvarchar(50),
	phone varchar(50),
	zipcode varchar(50),
	dob date,
	gender bit,
)
go
insert into Customer values
('Tsunami1', 'Address 1', 'Hanoi', 'Vietnam', '0836554688', '12345-1111', '2000/09/17', 0),
('Tsunami2', 'Address 2', 'Hanoi', 'Vietnam', '0836554688', '12345-2222', '2000/09/18', 1),
('Tsunami3', 'Address 3', 'Hanoi', 'Vietnam', '0836554688', '12345-3333', '2000/09/19', 1),
('Tsunami4', 'Address 4', 'Hanoi', 'Vietnam', '0836554688', '12345-4444', '2000/09/1', 1),
('Tsunami5', 'Address 5', 'Hanoi', 'Vietnam', '0836554688', '12345-5555', '2000/09/2', 0),
('Tsunami6', 'Address 6', 'Hanoi', 'Vietnam', '0836554688', '12345-6666', '2000/09/3', 0),
('Tsunami7', 'Address 7', 'Hanoi', 'Vietnam', '0836554688', '12345-7777', '2000/09/4', 1),
('Tsunami8', 'Address 8', 'Hanoi', 'Vietnam', '0836554688', '12345-8888', '2000/09/5', 1),
('Tsunami9', 'Address 9', 'Hanoi', 'Vietnam', '0836554688', '12345-9999', '2000/09/6', 0)
go

select * from Customer
