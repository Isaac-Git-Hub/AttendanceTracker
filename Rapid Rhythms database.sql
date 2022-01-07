-- Creating and using the database
CREATE DATABASE RapidRhythms;

USE RapidRhythms
GO

-- Attendance Table 
CREATE TABLE Attendance (
Transaction_id INT IDENTITY(1,1) PRIMARY KEY,
Purchase_type VARCHAR(100),
Payment_method VARCHAR(100),
Payment_amount INT,
Class_id INT NOT NULL REFERENCES Class(Class_id),
Transaction_Date DATE
);

-- Debugging Attendance
SELECT * FROM Attendance;

TRUNCATE TABLE Attendance;

DROP TABLE Attendance;

-- Class table
CREATE TABLE Class (
Class_id INT PRIMARY KEY,
Class_name VARCHAR(100),
Instructor_id INT NOT NULL REFERENCES Instructor(Instructor_id),
Instructor_Two_id INT NOT NULL REFERENCES Instructor(Instructor_id)
);

INSERT INTO Class
VALUES 
(202112,'Holiday Ball - Free Class', 2,0),
(202201,'Introduction to Lindy Hop',1,2),
(202202,'Introduction to Six Count',3,4),
(202203,'Intermediate Lindy Hop',2,3),
(202204,'Introduction to Charleston',5,6),
(202205,'The Big Apple',1,0),
(202206,'Introduction to Lindy Hop',1,2);

--Debugging class
SELECT * FROM Class;

TRUNCATE TABLE Class;

DROP TABLE Class;

--Instructor table
CREATE TABLE Instructor (
Instructor_id INT PRIMARY KEY,
Instructor_fname VARCHAR(100),
);

INSERT INTO Instructor 
VALUES (0, 'No Partner'),
(1, 'Annika'),
(2, 'David'),
(3,'Isaac'),
(4,'Krissy'),
(5,'Sammi'),
(6,'Scott'),
(7,'Sarah');

--Debugging Instructor
SELECT * FROM Instructor;

TRUNCATE TABLE Instructor;

DROP TABLE Instructor;

--Notes table
CREATE TABLE Notes (
Note_id INT IDENTITY(1,1) PRIMARY KEY,
Note VARCHAR(MAX),
Class_id INT NOT NULL REFERENCES Class(Class_id),
Create_date DATE
);

--Debugging Notes
SELECT * FROM NOTES;
	
TRUNCATE TABLE Notes;

DROP TABLE Notes;

--Query for the app: Nightly Totals
select count(*) Total_attendance,
sum(case when a.Purchase_type = 'class' or a.Purchase_type = 'used month pass for class' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_class_attendance,
sum(case when a.Purchase_type = 'dance' or a.Purchase_type = 'used month pass for dance' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_dance_attendance,
'$' + cast(sum(a.Payment_amount) as VARCHAR(20)) Total_revenue,
sum(case when a.Purchase_type = 'used month pass for class and dance' then -1 else 0 end) Guard_against_counting_month_pass_twice,
sum(case when a.Purchase_type = 'class and dance' then -1 else 0 end) Guard_against_counting_twice
from Attendance a	
where a.Transaction_date = '2022-01-01'; --this line is changed in the C# app;

--Query for the app: Class and Instructor names
select c.Class_name, i.Instructor_fname, (select i.Instructor_fname from class c, instructor i where c.Instructor_Two_id = i.Instructor_id and c.class_id = 202201) Instructor_Two_Fname -- This line is changed in the app
from class c, instructor i
where c.Instructor_id = i.Instructor_id
and c.class_id = 202201; --This line is changed in the C# app;

--Query for the app: Monthly totals
select count(*) Total_attendance,
sum(case when a.Purchase_type = 'class' or a.Purchase_type = 'used month pass for class' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_class_attendance,
sum(case when a.Purchase_type = 'dance' or a.Purchase_type = 'used month pass for dance' or a.Purchase_type = 'class and dance' or a.Purchase_type = 'used month pass for class and dance' then 1 else 0 end) Total_dance_attendance,
'$' + cast(sum(a.Payment_amount) as VARCHAR(20)) Total_revenue,
sum(case when a.Purchase_type = 'used month pass for class and dance' then -1 else 0 end) Guard_against_counting_month_pass_twice,
sum(case when a.Purchase_type = 'class and dance' then -1 else 0 end) Guard_against_counting_twice
from Attendance a	
where a.class_id = 202201; -- This line	 is changed in the app

--Query for the app: Monthly notes
select Note, create_date
from Notes
where class_id = 202201; -- This line is changed in the app