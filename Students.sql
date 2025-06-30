create database StudentDB
go
USE StudentDB
go
Create table Students (
StudentID INT PRIMARY KEY IDENTITY(1,1),
FullName NVARCHAR(50) NOT NULL,
Age INT,
Major NVARCHAR (50)
)