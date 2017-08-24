CREATE TABLE [dbo].[Employees]
(
	[EmployeeId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[EmployeeName] VARCHAR(100) NOT NULL,
	[DateofBirth] DATE NOT NULL,
	[Gender] VARCHAR(50),
	[DateofJoining] DATE NOT NULL
)

-- DROP TABLE [dbo].[Employees]

CREATE TABLE [dbo].[EmployeeAddress]
(
	[EmployeeId] INT NOT NULL,
	[Address1] VARCHAR(100) NOT NULL,
	[Address] VARCHAR(100),
	[City] VARCHAR(100) NOT NULL,
	[State] VARCHAR(150) NOT NULL
)

-- DROP TABLE [dbo].[EmployeeAddress]

CREATE TABLE [dbo].[Departments]
(
	[DepartmentId] INT NOT NULL PRIMARY KEY IDENTITY(1,1),
	[DepartmentName] VARCHAR(100) NOT NULL,
	[Location] VARCHAR(100) 
)

-- DROP TABLE [dbo].[Departments]

CREATE TABLE [dbo].[EmpDeptDetails]
(
	[DepartmentId] INT NOT NULL,
	[EmployeeId] INT NOT NULL
)

-- DROP TABLE [dbo].[EmpDeptDetails]