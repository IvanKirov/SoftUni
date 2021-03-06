-- Exercises: Built-in Functions
-- Queries for SoftUni Database
USE SoftUni

-- 01. Find Names of All Employees by First Name
SELECT [FirstName],
       [LastName]
  FROM Employees
 WHERE FirstName LIKE 'Sa%'

 -- 02. Find Names of All Employees by Last Name
SELECT [FirstName],
       [LastName]
  FROM Employees
 WHERE LastName LIKE '%EI%'

-- 03. Find First Names of All Employess
SELECT [FirstName]
  FROM Employees
 WHERE DepartmentID = 3 
    OR DepartmentID = 10
   AND DATEPART(YEAR, HireDate) >= 1995 
   AND DATEPART(YEAR, HireDate) <= 2005

-- 04. Find All Employees Except Engineers
SELECT [FirstName],
       [LastName]
  FROM Employees
 WHERE [JobTitle] NOT LIKE '%Engineer%'

-- 05. Find Towns with Name Length
   SELECT [Name] 
     FROM Towns
    WHERE LEN([Name]) = 5 OR LEN([Name]) = 6
 ORDER BY [Name]

-- 06. Find Towns Starting With
   SELECT * 
     FROM Towns
    WHERE [Name] LIKE '[MKBE]%'
 ORDER BY [Name]

-- 07. Find Towns Not Starting With
   SELECT * 
     FROM Towns
    WHERE [Name] LIKE '[^RBD]%'
 ORDER BY [Name]

-- 08. Create View Employees Hired After
CREATE VIEW V_EmployeesHiredAfter2000
		 AS
	 SELECT [FirstName],
            [LastName]
	   FROM Employees
	  WHERE DATEPART(YEAR, HireDate) > 2000

-- 09. Length of Last Name
SELECT [FirstName],
       [LastName]
  FROM Employees
 WHERE LEN([LastName]) = 5

-- Queries for Geography Databse
USE Geography

-- 10. Countries Holding 'A'
  SELECT [CountryName],
         [IsoCode]
    FROM Countries
   WHERE [CountryName] LIKE '%A%A%A%'	-- ALSO  WHERE LEN(CountryName) - LEN(REPLACE(CountryName,'A','')) >= 3
ORDER BY [IsoCode]

-- 11. Mix of Peak and River Names
  SELECT [PeakName],
         [RiverName],
	     LOWER(CONCAT([PeakName], SUBSTRING([RiverName], 2, LEN([RiverName])))) AS [Mix]
    FROM Peaks, Rivers
	WHERE RIGHT([PeakName], 1) = LEFT([RiverName], 1)
ORDER BY [Mix]

-- Queries for Diablo Databse
USE Diablo

-- 12. Games From 2011 and 2012 Year
SELECT TOP(50) [Name],
			   FORMAT([Start], 'yyyy-MM-dd')  AS [Start]
			   FROM Games
		 WHERE DATEPART(YEAR, [Start]) IN (2011, 2012)
	  ORDER BY [Start], 
		       [Name]

-- 13. User Email Providers
  SELECT [UserName],
	     SUBSTRING([Email], CHARINDEX('@',[Email])+1, 50) AS [Email Provider]
	FROM Users
ORDER BY [Email Provider], 
	     [UserName]

-- 14. Get Users with IPAddress Like Pattern
  SELECT [UserName],
	     [IpAddress]
	FROM Users
   WHERE [IpAddress] LIKE '___.1%.%.___'
ORDER BY [UserName]

-- 15. Show All Games with Duration
  SELECT [Name],
	CASE
		 WHEN DATEPART(HOUR, [Start]) BETWEEN 0 AND 11 THEN 'Morning'
		 WHEN DATEPART(HOUR, [Start]) BETWEEN 12 AND 17 THEN 'Afternoon'
		 WHEN DATEPART(HOUR, [Start]) BETWEEN 18 AND 23 THEN 'Evening'
	 END AS [Parts of the day],
	CASE
		 WHEN [Duration] BETWEEN 0 AND 3 THEN 'Extra Short'
		 WHEN [Duration] BETWEEN 4 AND 6 THEN 'Short'
		 WHEN [Duration]  > 6 THEN 'Long'
		 WHEN [Duration] IS NULL THEN 'Extra Long'
     END AS [Duration]
    FROM Games
ORDER BY [Name], 
		 [Duration],
		 [Parts of the day]

-- Date Functions Queries
USE Orders

-- 16. Orders Table
SELECT [ProductName],
	   [OrderDate],
	   DATEADD(DAY, 3, [OrderDate]) AS [Pay Due],
	   DATEADD(MONTH, 1, [OrderDate]) AS [Deliver Due]
  FROM Orders

-- 17. People Table
CREATE TABLE People(
	[Id] INT PRIMARY KEY IDENTITY,
	[Name] VARCHAR(50) NOT NULL, 
	[Birthdate] DATETIME NOT NULL
)

INSERT INTO People([Name], [Birthdate]) VALUES
('Victor', '2000-12-07 00:00:00.000'),
('Steven', '1992-09-10 00:00:00.000'),
('Stephen', '1910-09-19 00:00:00.000'),
('John', '2010-01-06 00:00:00.000')

SELECT [Name],
	   DATEDIFF(YEAR, [Birthdate], GETDATE()) AS [Age in Years],
	   DATEDIFF(MONTH, [Birthdate], GETDATE()) AS [Age in Months],
	   DATEDIFF(DAY, [Birthdate], GETDATE()) AS [Age in Days],
	   DATEDIFF(MINUTE, [Birthdate], GETDATE()) AS [Age in Minutes]
  FROM People