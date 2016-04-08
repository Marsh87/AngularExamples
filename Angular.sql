Create Database School;
go
use School;
go
CREATE TABLE Student
(
Id int primary key identity,
FirstName nvarchar(255),
LastName nvarchar(255),
IdNumber nvarchar(13),
Email nvarchar(255)
);
go
insert into Student values ('Mahesh','Moodley','8706045143082','moodelymahesh@gmail.com');
go