-- Lab: Introduction to Databases
--01.Create Database
CREATE DATABASE Bank
ON
( NAME = Bank_dat,  
    FILENAME = 'D:\MSSQL_local_DB\Bank.mdf')  
LOG ON  
( NAME = Bank_log,  
    FILENAME = 'D:\MSSQL_local_DB\Bank_log.ldf');  
GO

USE Bank
GO

--02. Create Tables
CREATE TABLE Clients(
	Id INT IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL
)

ALTER TABLE Clients
ADD CONSTRAINT PK_Clients_Id PRIMARY KEY (Id);

CREATE TABLE AccountTypes (
	Id INT IDENTITY,
	[Name] NVARCHAR(50) NOT NULL
)

ALTER TABLE AccountTypes
ADD CONSTRAINT PK_AccountTypes_Id PRIMARY KEY (Id);

CREATE TABLE Accounts (
	Id INT IDENTITY,
	AccountTypeId INT,
	Balance DECIMAL(15, 2) NOT NULL DEFAULT(0),
	ClientId INT 
)

ALTER TABLE Accounts
ADD CONSTRAINT PK_Accounts_Id PRIMARY KEY (Id);

ALTER TABLE Accounts
ADD CONSTRAINT FK_Accounts_AccountTypeId FOREIGN KEY (AccountTypeId) REFERENCES AccountTypes(Id);

ALTER TABLE Accounts
ADD CONSTRAINT FK_Accounts_ClientId FOREIGN KEY (ClientId) REFERENCES Clients(Id);

--03. Insert Sample Data into Database
INSERT INTO Clients (FirstName, LastName) VALUES
('Gosho', 'Ivanov'),
('Pesho', 'Petrov'),
('Ivan', 'Iliev'),
('Merry', 'Ivanova')

INSERT INTO AccountTypes (Name) VALUES
('Checking'),
('Savings')

INSERT INTO Accounts (ClientId, AccountTypeId, Balance) VALUES
(1, 1, 175),
(2, 1, 275.56),
(3, 1, 138.01),
(4, 1, 40.30),
(4, 2, 375.50)
GO

--04. Create a View
CREATE VIEW v_ClientBalances AS
SELECT (FirstName + ' ' + LastName) AS [Name], 
  (AccountTypes.Name) AS [Account Type], Balance 
FROM Clients
JOIN Accounts ON Clients.Id = Accounts.ClientId
JOIN AccountTypes ON AccountTypes.Id = Accounts.AccountTypeId
GO

SELECT * FROM v_ClientBalances
GO

--05. Create a Function
CREATE FUNCTION f_CalculateTotalBalance (@ClientID INT)
RETURNS DECIMAL(15, 2)
BEGIN
	DECLARE @result AS DECIMAL(15, 2) = (
	  SELECT SUM(Balance) 
	  FROM Accounts WHERE ClientId = @ClientID
	)	
  RETURN @result
END
GO

SELECT dbo.f_CalculateTotalBalance(4) AS Balance
GO

--06. Create Procedures
CREATE PROC p_AddAccount @ClientId INT, @AccountTypeId INT AS
INSERT INTO Accounts (ClientId, AccountTypeId) 
VALUES (@ClientId, @AccountTypeId)
GO

p_AddAccount 2, 2

SELECT * FROM Accounts
GO

CREATE PROC p_Deposit @AccountId INT, @Amount DECIMAL(15, 2) AS
UPDATE Accounts
SET Balance += @Amount
WHERE Id = @AccountId
GO

CREATE PROC p_Withdraw @AccountId INT, @Amount DECIMAL(15, 2) AS
BEGIN
	DECLARE @OldBalance DECIMAL(15, 2)
	SELECT @OldBalance = Balance FROM Accounts WHERE Id = @AccountId
	IF (@OldBalance - @Amount >= 0)
	BEGIN
		UPDATE Accounts
		SET Balance -= @Amount
		WHERE Id = @AccountId
	END
	ELSE
	BEGIN
		RAISERROR('Insufficient funds', 10, 1)
	END
END
GO

--07. Create Transactions Table and a Trigger
CREATE TABLE Transactions (
	Id INT IDENTITY,
	AccountId INT,
	OldBalance DECIMAL(15, 2) NOT NULL,
	NewBalance DECIMAL(15, 2) NOT NULL,
	Amount AS NewBalance - OldBalance,
	[DateTime] DATETIME2
)

ALTER TABLE Transactions
ADD CONSTRAINT PK_Transactions_Id PRIMARY KEY (Id);

ALTER TABLE Transactions
ADD CONSTRAINT FK_Transactions_AccountId FOREIGN KEY (AccountId) REFERENCES Accounts(Id)
GO

CREATE TRIGGER tr_Transaction ON Accounts
AFTER UPDATE
AS
	INSERT INTO Transactions (AccountId, OldBalance, NewBalance, [DateTime])
	SELECT inserted.Id, deleted.Balance, inserted.Balance, GETDATE() FROM inserted
	JOIN deleted ON inserted.Id = deleted.Id
GO

p_Deposit 1, 25.00
GO

p_Deposit 1, 40.00
GO

p_Withdraw 2, 200.00
GO

p_Deposit 4, 180.00
GO

SELECT * FROM Transactions

-- Exercises: Introduction to Databases
--12.Create New Database
CREATE DATABASE School
ON
( NAME = School_dat,  
    FILENAME = 'D:\MSSQL_local_DB\School.mdf')  
LOG ON  
( NAME = Sales_log,  
    FILENAME = 'D:\MSSQL_local_DB\School_log.ldf');  
GO

USE School
GO

CREATE TABLE Students(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL UNIQUE,
	Age INT CHECK (Age > 0),
	PhoneNumber NVARCHAR(50)
)

INSERT INTO Students(Name, Age, PhoneNumber) VALUES
('IVAN', 43, 5646464),
('KALINA', 33, 0000000005),
('BOBO', 3, 0464792)

CREATE TABLE Classes(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	MaxStudents INT CHECK (MaxStudents > -1)
)

INSERT INTO Classes(Name, MaxStudents) VALUES
('BIOLOGY', 100),
('MATHEMATICS', 200),
('PHYSICS', 10)

CREATE TABLE Teachers(
	Id INT PRIMARY KEY IDENTITY,
	Name NVARCHAR(50) NOT NULL,
	Class INT FOREIGN KEY REFERENCES Classes(Id)
)

INSERT INTO Teachers(Name, Class) VALUES
('PETAR', 1),
('MARIA', 2),
('KALOYAN', 3)


CREATE DATABASE Employes

USE Employes

DROP TABLE Employes

CREATE TABLE Employes(
	Id INT PRIMARY KEY IDENTITY,
	FirstName NVARCHAR(50) NOT NULL,
	LastName NVARCHAR(50) NOT NULL,
	Salary DECIMAL(15, 2) NOT NULL CHECK (Salary > 0),
	Email VARCHAR(50) UNIQUE NOT NULL,
	IsEmployd BIT DEFAULT 1,
	HireDate DATE DEFAULT GETDATE()
)

INSERT INTO Employes (FirstName, LastName, Salary, Email) VALUES
('Gosho', 'Petrov', 100, 'g@g.com'),
('Ivan', 'Ivanov', 202, 'i@i.com')

SELECT * FROM Employes

ALTER TABLE Employes
ADD Taxes DECIMAL(15, 2)

ALTER TABLE Employes
DROP COLUMN Taxes 