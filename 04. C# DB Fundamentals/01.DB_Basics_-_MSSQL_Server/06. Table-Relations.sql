-- Exercises: Table-Relations
CREATE DATABASE Task06
ON
( NAME =Task06_dat,  
    FILENAME = 'D:\MSSQL_local_DB\Task06.mdf')  
LOG ON  
( NAME = Task06_log,  
    FILENAME = 'D:\MSSQL_local_DB\Task06_log.ldf');  
GO

USE Task06
 
-- 01. One-To-One Relationship
  CREATE TABLE Passports(
	PassportID INT,
PassportNumber VARCHAR(10) UNIQUE NOT NULL,
	CONSTRAINT PK_Passports_PassportID PRIMARY KEY (PassportID)
)

INSERT INTO Passports (PassportID, PassportNumber) 
	 VALUES
			(101, 'N34FG21B'),
			(102, 'K65LO4R7'),
			(103, 'ZE657QP2')

CREATE TABLE Persons(
	PersonID INT IDENTITY,
   FirstName VARCHAR(20) NOT NULL,
	  Salary DECIMAL(15, 2),
  PassportID INT,
  CONSTRAINT PK_Persons_PersonID PRIMARY KEY (PersonID),
  CONSTRAINT FK_Persons_PassportID FOREIGN KEY (PassportID) REFERENCES Passports(PassportID)
)

INSERT INTO Persons(FirstName, Salary, PassportID) 
	 VALUES
			('Roberto', 43300, 102),
			('Tom', 56100.00, 103),
			('Yana', 60200.00, 101)

-- 02. One-To-Many Relationship
  CREATE TABLE Manufacturers(
ManufacturerID INT IDENTITY,
		  Name VARCHAR(50) NOT NULL,
 EstablishedOn DATETIME NOT NULL,
	CONSTRAINT PK_Manufacturers_ManufacturerID PRIMARY KEY (ManufacturerID)
)

INSERT INTO Manufacturers (Name, EstablishedOn) 
     VALUES 
			('BMW', '07/03/1916'),
			('Tesla', '01/01/2003'),
			('Lada', '01/05/1966')

  CREATE TABLE Models(
	   ModelID INT IDENTITY(101,1),
		  Name VARCHAR(50) NOT NULL,
ManufacturerID INT,
	CONSTRAINT PK_Models_ModelID PRIMARY KEY (ModelID),
	CONSTRAINT FK_Models_ManufacturerID FOREIGN KEY (ManufacturerID) REFERENCES Manufacturers(ManufacturerID)
)

INSERT INTO Models (Name, ManufacturerID) 
	 VALUES
			('X1', 1),
			('i6', 1),
			('Model S', 2),
			('Model X', 2),
			('Model 3', 2),
			('Nova', 3)

-- 03. Many-To-Many Relationship
CREATE TABLE Students(
   StudentID INT IDENTITY,
	    Name VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Students_StudentID PRIMARY KEY (StudentID)
)

INSERT INTO Students (Name)
	 VALUES 
			('Mila'),
			('Toni'),
			('Ron')

CREATE TABLE Exams(
	  ExamID INT IDENTITY(101, 1),
		Name VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Exams_ExamID PRIMARY KEY (ExamID)
)

INSERT INTO Exams (Name)
	 VALUES
			('SpringMVC'),
			('Neo4j'),
			('Oracle 11g')

CREATE TABLE StudentsExams(
   StudentID INT NOT NULL,
      ExamID INT NOT NULL,
  CONSTRAINT PK_StudentsExams_StudentID_ExamID PRIMARY KEY(StudentID, ExamID),
  CONSTRAINT FK_StudentsExams_StudentID FOREIGN KEY(StudentID) REFERENCES Students(StudentID),
  CONSTRAINT FK_StudentsExams_ExamID FOREIGN KEY(ExamID) REFERENCES Exams(ExamID)
)

INSERT INTO StudentsExams (StudentID, ExamID)
	 VALUES
			(1, 101),
			(1, 102),
			(2, 101),
			(3, 103),
			(2, 102),
			(2, 103)

-- 04. Self-Referencing
CREATE TABLE Teachers(
   TeacherID INT IDENTITY(101,1),
	    Name VARCHAR(50) NOT NULL,
   ManagerID INT,
  CONSTRAINT PK_Teachers_TeacherID PRIMARY KEY (TeacherID),
  CONSTRAINT FK_Teachers_ManagerID FOREIGN KEY(ManagerID) REFERENCES Teachers(TeacherID)
)

INSERT INTO Teachers (Name, ManagerID)
	 VALUES
			('John', NULL),
			('Maya', 106),
			('Silvia', 106),
			('Ted', 105),
			('Mark', 101),
			('Greta', 101)

-- 05. Online Store Database
CREATE DATABASE OnlineStore
ON
( NAME =OnlineStore_dat,  
    FILENAME = 'D:\MSSQL_local_DB\OnlineStore.mdf')  
LOG ON  
( NAME = OnlineStore_log,  
    FILENAME = 'D:\MSSQL_local_DB\OnlineStore_log.ldf');  
GO

USE OnlineStore

CREATE TABLE Cities(
	  CityID INT IDENTITY,
	  [Name] VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Cities_CityID PRIMARY KEY (CityID)
)

CREATE TABLE Customers(
  CustomerID INT IDENTITY,
	  [Name] VARCHAR(50) NOT NULL,
	Birthday DATE,
	  CityID INT,
  CONSTRAINT PK_Customers_CustomerID PRIMARY KEY (CustomerID),
  CONSTRAINT FK_Customers_CityID FOREIGN KEY (CityID) REFERENCES Cities(CityID)
)

CREATE TABLE ItemTypes(
  ItemTypeID INT IDENTITY,
	  [Name] VARCHAR(50) NOT NULL,
  CONSTRAINT PK_ItemTypes_ItemTypeID PRIMARY KEY (ItemTypeID)
)

CREATE TABLE Items(
	  ItemID INT IDENTITY,
	  [Name] VARCHAR(50) NOT NULL,
  ItemTypeID INT,
  CONSTRAINT PK_Items_ItemID PRIMARY KEY (ItemID),
  CONSTRAINT FK_Items_ItemTypeID FOREIGN KEY (ItemTypeID) REFERENCES ItemTypes(ItemTypeID)
)

CREATE TABLE Orders(
	 OrderID INT IDENTITY,
  CustomerID INT,
  CONSTRAINT PK_Orders_OrderID PRIMARY KEY (OrderID),
  CONSTRAINT FK_Orders_CustomerID FOREIGN KEY (CustomerID) REFERENCES Customers(CustomerID)
)

CREATE TABLE OrderItems(
	 OrderID INT,
	  ItemID INT,
  CONSTRAINT PK_OrderItems_OrderID_ItemTypeID PRIMARY KEY(OrderID,ItemID),
  CONSTRAINT FK_OrderItems_OrderID FOREIGN KEY (OrderID) REFERENCES Orders(OrderID),
  CONSTRAINT FK_OrderItems_ItemID FOREIGN KEY (ItemID) REFERENCES Items(ItemID)
)

-- 06. University Database
CREATE DATABASE University
ON
( NAME = University_dat,  
    FILENAME = 'D:\MSSQL_local_DB\University.mdf')  
LOG ON  
( NAME = University_log,  
    FILENAME = 'D:\MSSQL_local_DB\University_log.ldf');  
GO

USE University

CREATE TABLE Subjects(
   SubjectID INT IDENTITY,
 SubjectName VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Subjects_SubjectID PRIMARY KEY (SubjectID)
)

CREATE TABLE Majors(
	 MajorID INT IDENTITY,
	  [Name] VARCHAR(50) NOT NULL,
  CONSTRAINT PK_Majors_MajorID PRIMARY KEY (MajorID)
)

 CREATE TABLE Students(
	StudentID INT IDENTITY,
StudentNumber INT UNIQUE NOT NULL,
  StudentName VARCHAR(50) NOT NULL,
	  MajorID INT,
   CONSTRAINT PK_Students_StudentID PRIMARY KEY (StudentID),
   CONSTRAINT FK_Students_MajorID FOREIGN KEY (MajorID) REFERENCES Majors(MajorID)
)

CREATE TABLE Agenda(
   StudentID INT,
   SubjectID INT,
  CONSTRAINT PK_Agenda_StudentID_SubjectID PRIMARY KEY(StudentID, SubjectID),
  CONSTRAINT FK_Agenda_StudentID FOREIGN KEY (StudentID) REFERENCES Students(StudentID),
  CONSTRAINT FK_Agenda_SubjectID FOREIGN KEY (SubjectID) REFERENCES Subjects(SubjectID)
)

 CREATE TABLE Payments(
    PaymentID INT IDENTITY,
  PaymentDate DATE NOT NULL,
PaymentAmount DECIMAL(15,2) NOT NULL,
	StudentID INT,
   CONSTRAINT PK_Payments_PaymentID PRIMARY KEY (PaymentID),
   CONSTRAINT FK_Payments_StudentID FOREIGN KEY (StudentID) REFERENCES Students(StudentID)
)

-- 09. *Peaks in Rila
USE Geography

	SELECT Mountains.MountainRange,  Peaks.PeakName, Peaks.Elevation
	  FROM Mountains
INNER JOIN Peaks ON Mountains.Id = Peaks.MountainId
	 WHERE Mountains.MountainRange = 'Rila'
  ORDER BY Peaks.Elevation DESC

    SELECT m.MountainRange, p.PeakName, p.Elevation
      FROM Mountains AS m
INNER JOIN Peaks AS p 
        ON m.Id = p.MountainId
	 WHERE m.MountainRange = 'Rila'
  ORDER BY p.Elevation DESC