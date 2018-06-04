-- Exercises: Data Definition And Datatypes
--01.Create Database
CREATE DATABASE Minions
ON
( NAME = Minions_dat,  
    FILENAME = 'D:\MSSQL_local_DB\Minions.mdf')  
LOG ON  
( NAME = Minions_log,  
    FILENAME = 'D:\MSSQL_local_DB\Minions_log.ldf');  
GO

USE Minions
GO

--02. Create Tables
CREATE TABLE Minions (
	Id INT IDENTITY,
  Name NVARCHAR(50) NOT NULL, 
   Age INT
)

ALTER TABLE Minions
ADD CONSTRAINT PK_Minions_Id PRIMARY KEY (Id);

CREATE TABLE Towns (
	Id INT IDENTITY,
  Name NVARCHAR(50) NOT NULL
)

ALTER TABLE Towns
ADD CONSTRAINT PK_Towns_Id PRIMARY KEY (Id);

--03. Alter Minions Table
ALTER TABLE Minions
ADD TownId INT;

ALTER TABLE Minions
ADD CONSTRAINT FK_Minions_TownId FOREIGN KEY (TownId) REFERENCES Towns(Id);

--04. Insert Records in Both Tables
INSERT INTO Towns (Name) VALUES
('Sofia'),
('Plovdiv'),
('Varna')

INSERT INTO Minions (Name, Age, TownId) VALUES
('Kevin', 22, 1),
('Bob', 15, 3),
('Steward', NULL, 2)

--05. Truncate Table Minions
TRUNCATE TABLE Minions

--06. Drop All Tables
DROP TABLE Minions
DROP TABLE Towns

--07. Create Table People
CREATE TABLE People (
   Id BIGINT IDENTITY,
   Name NVARCHAR(200) NOT NULL,
   Picture VARBINARY(MAX),
   Height DECIMAL(15, 2),  
   Weight DECIMAL(15, 2),
   Gender VARCHAR(1) CHECK (Gender='m' OR Gender='f') NOT NULL,
   Birthdate DATE NOT NULL,
   Biography NVARCHAR(MAX)
)

ALTER TABLE People
ADD CONSTRAINT PK_People_Id PRIMARY KEY (Id);

INSERT INTO People (Name, Height, Weight, Gender, Birthdate) VALUES
('Ivan', 175, 93, 'm', '19801212'),
('Petar', 181, 99, 'm', '19720626'),
('Gosho', 195, 111, 'm', '19890523'),
('Koko', 185, 83, 'm', '19820426'),
('Mimi', 155, 53, 'f', Convert(DateTime,'19620116',112))


--08. Create Table Users
CREATE TABLE Users (
   Id BIGINT IDENTITY,
   Username VARCHAR(30) NOT NULL,
   Password VARCHAR(26) NOT NULL,
   ProfilePicture VARBINARY(MAX),
   LastLoginTime DATETIME,
   IsDeleted BIT NOT NULL   
)

ALTER TABLE Users
ADD CONSTRAINT PK_Users_Id PRIMARY KEY (Id);

INSERT INTO Users (Username, Password, IsDeleted) VALUES
('IVAN', 'QWERTY', 0),
('KOKO', 'QWERTY', 0),
('BOBO', 'QWERTY', 0),
('BIBI', 'QWERTY', 0),
('PIPI', 'QWERTY', 0)

--09. Change Primary Key
ALTER TABLE Users 
DROP CONSTRAINT PK_Users_Id;

ALTER TABLE Users
ADD CONSTRAINT PK__Users_Id_Username PRIMARY KEY (Id, Username);

--10. Add Check Constraint
ALTER TABLE Users
ADD CONSTRAINT CHK_PasswordLength CHECK (DATALENGTH(Password) >= 5)

--11. Set Default Value of a Field
ALTER TABLE Users
ADD DEFAULT GETDATE() FOR LastLoginTime

--12. Set Unique Field
ALTER TABLE Users
ADD UNIQUE (Username)

--Other possible changes
ALTER TABLE Users
ADD CONSTRAINT CHK_UsernameLength CHECK (DATALENGTH(Username) >= 3)

ALTER TABLE Users
ADD CONSTRAINT CHK_ProfilePicture_Size CHECK (DATALENGTH(ProfilePicture) <= 900 * 1024)

CREATE TABLE Users (
   Id BIGINT  IDENTITY,
   Username VARCHAR(30) UNIQUE NOT NULL,
   Password VARCHAR(26) NOT NULL,
   ProfilePicture VARBINARY(MAX),
   LastLoginTime DATETIME,
   IsDeleted BIT NOT NULL,
   CONSTRAINT PK_Users PRIMARY KEY (Id)
)

--13. Movies Database
CREATE DATABASE Movies
ON
( NAME = Movies_dat,  
    FILENAME = 'D:\MSSQL_local_DB\Movies.mdf')  
LOG ON  
( NAME = Movies_log,  
    FILENAME = 'D:\MSSQL_local_DB\Movies_log.ldf');  
GO

USE Movies
GO

CREATE TABLE Directors (
	Id INT IDENTITY,
	DirectorName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Directors_Id PRIMARY KEY (Id)
)

INSERT INTO Directors VALUES
('Aleksander Bolduin', NULL),
('Kris Taker', NULL),
('Borislav Stracinski', NULL),
('Ema Tomson', NULL),
('Leopold Borgin', NULL)

CREATE TABLE Genres (
	Id INT IDENTITY,
	GenreName NVARCHAR(50) NOT NULL,
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Geners_Id PRIMARY KEY (Id)
)

INSERT INTO Genres VALUES
('Action', NULL),
('Drama', NULL),
('Horor', NULL),
('Triler', NULL),
('Animation', NULL)

CREATE TABLE Categories (
	Id INT IDENTITY, 
	CategoryName CHAR(1) NOT NULL, 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Categories_Id PRIMARY KEY (Id)
)

INSERT INTO Categories VALUES
('A', NULL),
('B', NULL),
('C', NULL),
('D', NULL),
('E', NULL)

CREATE TABLE Movies (
	Id INT IDENTITY,
	Title NVARCHAR(50) NOT NULL, 
	DirectorId INT NOT NULL, 
	CopyrightYear DATE NOT NULL, 
	Length DECIMAL (10,2) NOT NULL, 
	GenreId INT NOT NULL, 
	CategoryId INT NOT NULL, 
	Rating INT NOT NULL, 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Movies_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Movies_DirectorId FOREIGN KEY (DirectorId) REFERENCES Directors(Id),
	CONSTRAINT FK_Movies_GenreId FOREIGN KEY (GenreId) REFERENCES Genres(Id),
	CONSTRAINT FK_Movies_CategoryId FOREIGN KEY (CategoryId) REFERENCES Categories(Id)
)
 
INSERT INTO Movies VALUES
('Chainsaw', 2, '1980', 120, 3, 5, 1, NULL),
('TOP GUN', 3, NULL, 120, 1, 2, 2, NULL),
('Nemo', 4, NULL, 120, 4, 5, 3, NULL),
('Memento', 5, NULL, 120, 5, 4, 4, NULL),
('Titanik', 1, NULL, 120, 2, 3, 5, NULL)

--14. Car Rental Database
CREATE DATABASE CarRental
ON
( NAME = CarRental_dat,  
    FILENAME = 'D:\MSSQL_local_DB\CarRental.mdf')  
LOG ON  
( NAME = CarRental_log,  
    FILENAME = 'D:\MSSQL_local_DB\CarRental_log.ldf');  
GO

USE CarRental
GO

CREATE TABLE Categories (
   Id INT IDENTITY,
   CategoryName NVARCHAR(50) NOT NULL,
   DailyRate DECIMAL(15, 2),  
   WeeklyRate DECIMAL(15, 2),
   MonthlyRate DECIMAL(15, 2),
   WeekendRate DECIMAL(15, 2),
   CONSTRAINT PK_Categories_Id PRIMARY KEY (Id)
)

CREATE TABLE Cars (
   Id INT IDENTITY,
   PlateNumber NVARCHAR(10) NOT NULL,
   Manufacturer NVARCHAR(10),  
   Model NVARCHAR(10),
   CarYear DATE,
   CategoryId INT,
   Doors INT,
   Picture VARBINARY(MAX),
   Condition NVARCHAR(MAX),
   Available BIT DEFAULT 1,
   CONSTRAINT PK_Cars_Id PRIMARY KEY (Id),
   CONSTRAINT FK_Cars_CategoryId FOREIGN KEY (CategoryId) REFERENCES Categories(Id),
   CONSTRAINT CHK_Doors CHECK (Doors >= 2),
   CONSTRAINT CHK_CarPictureSize CHECK (DATALENGTH(Picture) <= 100 * 1024)
)

CREATE TABLE Employees (
   Id INT IDENTITY,
   FirstName NVARCHAR(50) NOT NULL,
   LastName NVARCHAR(50) NOT NULL,  
   Title NVARCHAR(10) NOT NULL,
   Notes NVARCHAR(MAX),
   CONSTRAINT PK_Employees_Id PRIMARY KEY (Id)
)

CREATE TABLE Customers (
   Id INT IDENTITY,
   DriverLicenceNumber NVARCHAR(50) NOT NULL,
   FullName NVARCHAR(50) NOT NULL,  
   Address NVARCHAR(50),
   City NVARCHAR(20),
   ZIPCode INT,
   Notes NVARCHAR(MAX),
   CONSTRAINT PK_Customers_Id PRIMARY KEY (Id)
)

CREATE TABLE RentalOrders (
   Id INT IDENTITY,
   EmployeeId INT,
   CustomerId INT,
   CarId INT FOREIGN KEY REFERENCES Cars(Id),
   TankLevel VARCHAR(1) CHECK (TankLevel='F' OR TankLevel='E') NOT NULL,
   KilometrageStart DECIMAL(15, 2) NOT NULL,
   KilometrageEnd DECIMAL(15, 2) NOT NULL,
   TotalKilometrage AS KilometrageEnd - KilometrageStart,
   StartDate DATE NOT NULL, 
   EndDate DATE NOT NULL, 
   TotalDays AS DATEDIFF(day, StartDate, EndDate),
   RateApplied DECIMAL(15, 2) NOT NULL, 
   TaxRate DECIMAL(15, 2) NOT NULL, 
   OrderStatus NVARCHAR(50), 
   Notes NVARCHAR(MAX),
   CONSTRAINT PK_RentalOrders_Id PRIMARY KEY (Id),
   CONSTRAINT FK_RentalOrders_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
   CONSTRAINT FK_RentalOrders_CustomerId FOREIGN KEY (CustomerId) REFERENCES Customers(Id)
)

INSERT INTO Categories VALUES
('Low', 20.10, 130.10, 450, 50),
('Middle', 25.50, 150.50, 550, 60),
('High', 30.99, 230.40, 770.20, 70)

INSERT INTO Cars (PlateNumber, CategoryId, Doors)  VALUES
('CX 5120', 1, 4),
('B 1523', 2, 4),
('K 1566', 3, 2)

INSERT INTO Employees VALUES
('Ivan','Kirov','Manager',NULL),
('Pesho','Petrov','Accountant',NULL),
('Elana','Popova','Consultant',NULL)

INSERT INTO Customers VALUES
('BG53667866', 'Kalina Petrova', '15 Tzar Boris Blvd.', 'Sofia', 1614, NULL),
('BG89576158', 'Nikolai Ivanov', '17 Gotse Delchev Str.', 'Sofia', 1615, NULL),
('BG74185296', 'Petar Nikolov', '18 Gotse Delchev Str.', 'Sofia', 1615, NULL)

INSERT INTO RentalOrders VALUES
(2, 1, 3, 'F', 1100, 1300, Convert(DateTime,'19780520',112), Convert(DateTime,'19780729',112), 20.25, 45.50, NULL, NULL),
(1, 3, 2, 'F', 1300, 1800, Convert(DateTime,'19780121',112), Convert(DateTime,'19780212',112), 33.2, 60, NULL, NULL),
(3, 2, 1, 'F', 1000, 1100, Convert(DateTime,'19780620',112), Convert(DateTime,'19780625',112), 20.12, 52.22, NULL, NULL)

--15. Hotel Database
CREATE DATABASE Hotel
ON
( NAME = Hotel_dat,  
    FILENAME = 'D:\MSSQL_local_DB\Hotel.mdf')  
LOG ON  
( NAME = Hotel_log,  
    FILENAME = 'D:\MSSQL_local_DB\Hotel_log.ldf');  
GO

USE Hotel
GO

CREATE TABLE Employees (
   Id INT IDENTITY,
   FirstName NVARCHAR(50) NOT NULL,
   LastName NVARCHAR(50) NOT NULL,  
   Title NVARCHAR(20) NOT NULL,
   Notes NVARCHAR(MAX),
   CONSTRAINT PK_Employees_Id PRIMARY KEY (Id)
)

INSERT INTO Employees VALUES
('Ivan','Kirov','Manager',NULL),
('Pesho','Petrov','Pikolo',NULL),
('Elana','Popova','Reception',NULL)

CREATE TABLE Customers (
	AccountNumber INT IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	PhoneNumber INT, 
	EmergencyName NVARCHAR(50), 
	EmergencyNumber INT, 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Customers_AccountNumber PRIMARY KEY (AccountNumber)
)

INSERT INTO Customers VALUES
('Kalina', 'Petrova', 0899951753, NULL, NULL, NULL),
('Nikolai', 'Ivanov', 0888456321, NULL, NULL, NULL),
('Petar', 'Nikolov', 0879654321, NULL, NULL, NULL)

CREATE TABLE RoomStatus (
	RoomStatus NVARCHAR(20) NOT NULL, 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_RoomStatus PRIMARY KEY (RoomStatus)
)

INSERT INTO RoomStatus VALUES
('Free', NULL),
('Reserved', NULL),
('Occupied', NULL)

CREATE TABLE RoomTypes (
	RoomType NVARCHAR(20) NOT NULL, 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_RoomType PRIMARY KEY (RoomType)
)

INSERT INTO RoomTypes VALUES
('Standard', NULL),
('Luxury', NULL),
('Suite', NULL)

CREATE TABLE BedTypes (
	BedType NVARCHAR(20) NOT NULL, 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_BedType PRIMARY KEY (BedType)
)

INSERT INTO BedTypes VALUES
('Single bed', NULL),
('Double bed', NULL),
('Twin bed', NULL)

CREATE TABLE Rooms (
	RoomNumber INT IDENTITY, 
	RoomType NVARCHAR(20), 
	BedType NVARCHAR(20), 
	Rate DECIMAL(15, 2) NOT NULL, 
	RoomStatus NVARCHAR(20), 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Rooms_RoomNumber PRIMARY KEY (RoomNumber),
	CONSTRAINT FK_Rooms_RoomType FOREIGN KEY (RoomType) REFERENCES RoomTypes(RoomType),
	CONSTRAINT FK_Rooms_BedType FOREIGN KEY (BedType) REFERENCES BedTypes(BedType),
	CONSTRAINT FK_Rooms_RoomStatus FOREIGN KEY (RoomStatus) REFERENCES RoomStatus(RoomStatus),
)

INSERT INTO Rooms VALUES
('Standard', 'Single bed', 10.50, 'Free', NULL),
('Luxury', 'Double bed', 22, 'Reserved', NULL),
('Suite', 'Twin bed', 33.3, 'Occupied', NULL)

CREATE TABLE Payments (
	Id INT IDENTITY, 
	EmployeeId INT, 
	PaymentDate DATE, 
	AccountNumber INT, 
	FirstDateOccupied DATE NOT NULL, 
	LastDateOccupied DATE NOT NULL, 
	TotalDays AS DATEDIFF(day, FirstDateOccupied, LastDateOccupied), 
	AmountCharged DECIMAL(7,2) NOT NULL, 
	TaxRate DECIMAL(7,2) NOT NULL, 
	TaxAmount DECIMAL(7,2) NOT NULL, 
	PaymentTotal DECIMAL(7,2) NOT NULL, 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Payments_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Payments_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES Employees(Id),
	CONSTRAINT FK_Payments_AccountNumber FOREIGN KEY (AccountNumber) REFERENCES Customers(AccountNumber)
)

INSERT INTO Payments VALUES
(3, NULL, 1, '1978-05-20', '1978.07.29', 15, 2, 15, 15, NULL),
(3, NULL, 1,'1978-01-21', '1978-02-12', 30, 2, 5, 15, NULL),
(3, NULL, 1, '1978.06.20', '1978.06.25', 55, 2, 15, 5, NULL)

CREATE TABLE Occupancies (
	Id INT IDENTITY, 
	EmployeeId INT,
	DateOccupied DATE, 
	AccountNumber INT, 
	RoomNumber INT, 
	RateApplied DECIMAL(15,2) NOT NULL, 
	PhoneCharge DECIMAL(15,2), 
	Notes NVARCHAR(MAX),
	CONSTRAINT PK_Occupancies_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Occupancies_EmployeeId FOREIGN KEY (EmployeeId) REFERENCES Employees(Id), 
	CONSTRAINT FK_Occupancies_AccountNumber FOREIGN KEY (AccountNumber) REFERENCES Customers(AccountNumber),
	CONSTRAINT FK_Occupancies_RoomNumber FOREIGN KEY (RoomNumber) REFERENCES Rooms(RoomNumber)
)

INSERT INTO Occupancies VALUES
(1, NULL, 2, 3, 15.5, NULL, NULL),
(2, NULL, 3, 2, 55.5, NULL, NULL),
(3, NULL, 1, 3, 25.5, NULL, NULL)

--16. Create SoftUni Database
CREATE DATABASE SoftUni
ON
( NAME = SoftUni_dat,  
    FILENAME = 'D:\MSSQL_local_DB\SoftUni.mdf')  
LOG ON  
( NAME = SoftUni_log,  
    FILENAME = 'D:\MSSQL_local_DB\SoftUni_log.ldf');  
GO 

USE SoftUni
GO

CREATE TABLE Towns (
	Id INT IDENTITY, 
	Name NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_Towns_Id PRIMARY KEY (Id)
)

INSERT INTO Towns VALUES 
('Sofia'),
('Burgas'),
('Plovdiv')

CREATE TABLE Addresses (
	Id INT IDENTITY, 
	AddressText NVARCHAR(50) NOT NULL, 
	TownId INT,
	CONSTRAINT PK_Addresses_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Addresses_TownId FOREIGN KEY (TownId) REFERENCES Towns(Id)
)

INSERT INTO Addresses VALUES
('bul.Gotse Delchev 15', 1),
('ul.Gorno 15',2),
('ul.Dolno 18',3)

CREATE TABLE Departments (
	Id INT IDENTITY, 
	DepartmentName NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_Departments_Id PRIMARY KEY (Id)
)

INSERT INTO Departments VALUES
('Software Development'), 
('Marketing'),
('Engineering')

CREATE TABLE Employees (
	Id INT IDENTITY, 
	FirstName NVARCHAR(50) NOT NULL, 
	MiddleName NVARCHAR(50), 
	LastName NVARCHAR(50) NOT NULL, 
	JobTitle NVARCHAR(50) NOT NULL, 
	DepartmentId INT NOT NULL, 
	HireDate DATE NOT NULL, 
	Salary DECIMAL(15,2) NOT NULL, 
	AddressId INT,
	CONSTRAINT PK_Employees_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Employees_DepartmentId FOREIGN KEY (DepartmentId) REFERENCES Departments(Id),
	CONSTRAINT FK_Employees_AddressId FOREIGN KEY (AddressId) REFERENCES Addresses(Id)
)

INSERT INTO Employees VALUES
('Ivan','Ivanov','Ivanov', '.NET DEVELOPER', 1,  '2013-02-01', 3500, 1),
('Petar','Petrov','Petrov', 'Senior Engineer', 2,  '2004-03-02', 4000, 2),
('Maria','Petrova','Ivanova', 'Intern', 3,  '2016-08-28', 525.25, 3),
('Georgi','Terziev','Ivanov', 'CEO', 1,  '09/12/2007', 3000, 2),
('Peter','Pan','Pan', 'Intern', 1,  '2016-08-28', 599.88, 1)

--17. Backup Database
BACKUP DATABASE SoftUni
TO DISK = 'D:\MSSQL_local_DB\SoftUni.Bak'
GO

USE master
GO

DROP DATABASE SoftUni
GO

RESTORE DATABASE SoftUni
FROM DISK = 'D:\MSSQL_local_DB\SoftUni.Bak'
GO

--19. Basic Select All fields
USE SoftUni
GO

SELECT * FROM Towns
SELECT * FROM Departments
SELECT * FROM Employees 

--20. Basic Select All Fields and Order Them
  SELECT * FROM Towns
ORDER BY Name

  SELECT * FROM Departments
ORDER BY DepartmentName

  SELECT * FROM Employees
ORDER BY Salary DESC

--21. Basic Select Some Fields
  SELECT Name FROM Towns 
ORDER BY Name

  SELECT DepartmentName FROM Departments 
ORDER BY DepartmentName

  SELECT FirstName, LastName, JobTitle, Salary FROM Employees 
ORDER BY Salary DESC

--22. Increase Employees Salary
UPDATE Employees
   SET Salary+=Salary*10/100
SELECT Salary FROM Employees

--23. Decrease Tax Rate Hotel Database
USE Hotel
GO

UPDATE Payments
   SET TaxRate-=TaxRate*3/100
SELECT TaxRate FROM Payments

--24. Delete All Records From Hotel Database table Occupancies
TRUNCATE TABLE Occupancies