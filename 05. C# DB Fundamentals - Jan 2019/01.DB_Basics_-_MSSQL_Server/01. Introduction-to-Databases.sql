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
	LastName NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_Clients_Id PRIMARY KEY (Id)
)

CREATE TABLE AccountTypes (
	Id INT IDENTITY,
	[Name] NVARCHAR(50) NOT NULL,
	CONSTRAINT PK_AccountTypes_Id PRIMARY KEY (Id)
)

CREATE TABLE Accounts (
	Id INT IDENTITY,
	AccountTypeId INT,
	Balance DECIMAL(15, 2) NOT NULL DEFAULT(0),
	ClientId INT ,
	CONSTRAINT PK_Accounts_Id PRIMARY KEY (Id),
	CONSTRAINT FK_Accounts_AccountTypeId FOREIGN KEY (AccountTypeId) REFERENCES AccountTypes(Id),
	CONSTRAINT FK_Accounts_ClientId FOREIGN KEY (ClientId) REFERENCES Clients(Id)
)

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

--04. Create a Function
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

--05. Create Procedures
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

--06. Create Transactions Table and a Trigger
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
