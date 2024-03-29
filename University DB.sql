/****** Object:  StoredProcedure [dbo].[fetchrole]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fetchrole]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[fetchrole]
GO
/****** Object:  StoredProcedure [dbo].[fetchstate]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fetchstate]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[fetchstate]
GO
/****** Object:  StoredProcedure [dbo].[logincheck]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[logincheck]') AND type in (N'P', N'PC'))
DROP PROCEDURE [dbo].[logincheck]
GO
/****** Object:  Table [dbo].[Logindetails]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Logindetails]') AND type in (N'U'))
DROP TABLE [dbo].[Logindetails]
GO
/****** Object:  Table [dbo].[MasterStates]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterStates]') AND type in (N'U'))
DROP TABLE [dbo].[MasterStates]
GO
/****** Object:  Table [dbo].[MasterUserRights]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterUserRights]') AND type in (N'U'))
DROP TABLE [dbo].[MasterUserRights]
GO
/****** Object:  Table [dbo].[ModuleMaster]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModuleMaster]') AND type in (N'U'))
DROP TABLE [dbo].[ModuleMaster]
GO
/****** Object:  Table [dbo].[StudentSelected_ModuleMaster]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentSelected_ModuleMaster]') AND type in (N'U'))
DROP TABLE [dbo].[StudentSelected_ModuleMaster]
GO
/****** Object:  Table [dbo].[Assesment]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Assesment]') AND type in (N'U'))
DROP TABLE [dbo].[Assesment]
GO
/****** Object:  Table [dbo].[CourseMaster]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseMaster]') AND type in (N'U'))
DROP TABLE [dbo].[CourseMaster]
GO
/****** Object:  Schema [sdssms]    Script Date: 04/25/2012 01:16:02 ******/
IF  EXISTS (SELECT * FROM sys.schemas WHERE name = N'sdssms')
DROP SCHEMA [sdssms]
GO
/****** Object:  Role [sdssms]    Script Date: 04/25/2012 01:16:02 ******/
DECLARE @RoleName sysname
set @RoleName = N'sdssms'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from sys.database_principals 
	where principal_id in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'sdssms' AND type = 'R')
DROP ROLE [sdssms]
GO
/****** Object:  Role [abhay]    Script Date: 04/25/2012 01:16:02 ******/
DECLARE @RoleName sysname
set @RoleName = N'abhay'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from sys.database_principals 
	where principal_id in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'abhay' AND type = 'R')
DROP ROLE [abhay]
GO
/****** Object:  Role [abhijeet]    Script Date: 04/25/2012 01:16:02 ******/
DECLARE @RoleName sysname
set @RoleName = N'abhijeet'
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = @RoleName AND type = 'R')
Begin
	DECLARE @RoleMemberName sysname
	DECLARE Member_Cursor CURSOR FOR
	select [name]
	from sys.database_principals 
	where principal_id in ( 
		select member_principal_id 
		from sys.database_role_members 
		where role_principal_id in (
			select principal_id
			FROM sys.database_principals where [name] = @RoleName  AND type = 'R' ))

	OPEN Member_Cursor;

	FETCH NEXT FROM Member_Cursor
	into @RoleMemberName

	WHILE @@FETCH_STATUS = 0
	BEGIN

		exec sp_droprolemember @rolename=@RoleName, @membername= @RoleMemberName

		FETCH NEXT FROM Member_Cursor
		into @RoleMemberName
	END;

	CLOSE Member_Cursor;
	DEALLOCATE Member_Cursor;
End
GO
IF  EXISTS (SELECT * FROM sys.database_principals WHERE name = N'abhijeet' AND type = 'R')
DROP ROLE [abhijeet]
GO
/****** Object:  Role [sdssms]    Script Date: 04/25/2012 01:16:02 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'sdssms')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'sdssms' AND type = 'R')
CREATE ROLE [sdssms] AUTHORIZATION [dbo]

END
GO
/****** Object:  Role [abhay]    Script Date: 04/25/2012 01:16:02 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'abhay')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'abhay' AND type = 'R')
CREATE ROLE [abhay] AUTHORIZATION [sdssms]

END
GO
/****** Object:  Role [abhijeet]    Script Date: 04/25/2012 01:16:02 ******/
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'abhijeet')
BEGIN
IF NOT EXISTS (SELECT * FROM sys.database_principals WHERE name = N'abhijeet' AND type = 'R')
CREATE ROLE [abhijeet] AUTHORIZATION [sdssms]

END
GO
/****** Object:  Schema [sdssms]    Script Date: 04/25/2012 01:16:02 ******/
IF NOT EXISTS (SELECT * FROM sys.schemas WHERE name = N'sdssms')
EXEC sys.sp_executesql N'CREATE SCHEMA [sdssms] AUTHORIZATION [sdssms]'
GO
/****** Object:  Table [dbo].[CourseMaster]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CourseMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[CourseMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[CourseName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[NoofModule] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Status] [char](10) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_MasterCity] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
IF NOT EXISTS (SELECT * FROM ::fn_listextendedproperty(N'MS_Description' , N'SCHEMA',N'dbo', N'TABLE',N'CourseMaster', N'COLUMN',N'NoofModule'))
EXEC sys.sp_addextendedproperty @name=N'MS_Description', @value=N'comes from state table column ID' , @level0type=N'SCHEMA',@level0name=N'dbo', @level1type=N'TABLE',@level1name=N'CourseMaster', @level2type=N'COLUMN',@level2name=N'NoofModule'
GO
SET IDENTITY_INSERT [dbo].[CourseMaster] ON
INSERT [dbo].[CourseMaster] ([Id], [CourseName], [NoofModule], [Status]) VALUES (21, N'Computer Science', N'25', N'y         ')
SET IDENTITY_INSERT [dbo].[CourseMaster] OFF
/****** Object:  Table [dbo].[Assesment]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Assesment]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Assesment](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[StudentRegno] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Name] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Course] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Module] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModuleId] [int] NULL,
	[Year] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Assesment] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AssesmentId] [int] NULL,
	[Marks] [numeric](18, 0) NULL,
	[Outof] [numeric](18, 0) NULL,
 CONSTRAINT [PK_Assesment] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Assesment] ON
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (30, N'W1', N'Abdalla', N'Computer Science', N'Communication and Learning Skills', NULL, N'4th', N'Assessment-1', 1, CAST(70 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (31, N'W1', N'Abdalla', N'Computer Science', N'Communication and Learning Skills', NULL, N'4th', N'Assessment-2', 2, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (32, N'W1', N'Abdalla', N'Computer Science', N'Communication and Learning Skills', NULL, N'4th', N'Assessment-3', 3, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (33, N'W1', N'Abdalla', N'Computer Science', N'Computer Systems Fundamentals', NULL, N'4th', N'Assessment-1', 1, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (34, N'W1', N'Abdalla', N'Computer Science', N'Computer Systems Fundamentals', NULL, N'4th', N'Assessment-2', 2, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (35, N'W1', N'Abdalla', N'Computer Science', N'Computer Systems Fundamentals', NULL, N'4th', N'Assessment-3', 3, CAST(88 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (36, N'W1', N'Abdalla', N'Computer Science', N'Computer Systems Fundamentals', NULL, N'4th', N'Assessment-4', 4, CAST(45 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (37, N'W1', N'Abdalla', N'Computer Science', N'Information and Data Modelling', NULL, N'4th', N'Assessment-1', 1, CAST(56 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (38, N'W1', N'Abdalla', N'Computer Science', N'Information and Data Modelling', NULL, N'4th', N'Assessment-2', 2, CAST(76 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (39, N'W1', N'Abdalla', N'Computer Science', N'Information and Data Modelling', NULL, N'4th', N'Assessment-3', 3, CAST(77 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (40, N'W1', N'Abdalla', N'Computer Science', N'Mathematics for Computing', NULL, N'4th', N'Assessment-1', 1, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (41, N'W1', N'Abdalla', N'Computer Science', N'Mathematics for Computing', NULL, N'4th', N'Assessment-2', 2, CAST(76 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (42, N'W1', N'Abdalla', N'Computer Science', N'Mathematics for Computing', NULL, N'4th', N'Assessment-3', 3, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (43, N'W1', N'Abdalla', N'Computer Science', N'Mathematics for Computing', NULL, N'4th', N'Assessment-4', 4, CAST(77 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (44, N'W1', N'Abdalla', N'Computer Science', N'Programming Methodology (Java)', NULL, N'4th', N'Assessment-1', 1, CAST(77 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (45, N'W1', N'Abdalla', N'Computer Science', N'Programming Methodology (Java)', NULL, N'4th', N'Assessment-2', 2, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (46, N'W1', N'Abdalla', N'Computer Science', N'Programming Methodology (Java)', NULL, N'4th', N'Assessment-3', 3, CAST(76 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (47, N'W1', N'Abdalla', N'Computer Science', N'Software Development Principles', NULL, N'4th', N'Assessment-1', 1, CAST(77 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (48, N'W1', N'Abdalla', N'Computer Science', N'Software Development Principles', NULL, N'4th', N'Assessment-2', 2, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (49, N'W1', N'Abdalla', N'Computer Science', N'Software Development Principles', NULL, N'4th', N'Assessment-3', 3, CAST(67 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (50, N'W1', N'Abdalla', N'Computer Science', N'Software Development Principles', NULL, N'4th', N'Assessment-4', 4, CAST(55 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (51, N'W1', N'Abdalla', N'Computer Science', N'Software Engineering Principles', NULL, N'4th', N'Assessment-1', 1, CAST(67 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (52, N'W1', N'Abdalla', N'Computer Science', N'Software Engineering Principles', NULL, N'4th', N'Assessment-2', 2, CAST(56 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (53, N'W1', N'Abdalla', N'Computer Science', N'Web Technology', NULL, N'4th', N'Assessment-1', 1, CAST(67 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (54, N'W1', N'Abdalla', N'Computer Science', N'Web Technology', NULL, N'4th', N'Assessment-2', 2, CAST(87 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
INSERT [dbo].[Assesment] ([Id], [StudentRegno], [Name], [Course], [Module], [ModuleId], [Year], [Assesment], [AssesmentId], [Marks], [Outof]) VALUES (55, N'W1', N'Abdalla', N'Computer Science', N'Web Technology', NULL, N'4th', N'Assessment-3', 3, CAST(88 AS Numeric(18, 0)), CAST(100 AS Numeric(18, 0)))
SET IDENTITY_INSERT [dbo].[Assesment] OFF
/****** Object:  Table [dbo].[StudentSelected_ModuleMaster]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[StudentSelected_ModuleMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[StudentSelected_ModuleMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[EnrollementNo] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Course] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Courseid] [int] NULL,
	[YearId] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Year] [nchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Module] [int] NULL,
	[ModuleName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Credites] [varchar](50) COLLATE Latin1_General_CI_AS NULL,
	[ModuleCode] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModuleSem] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModuleSemId] [int] NULL,
	[Lecture] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Tutorial] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Freeze] [char](10) COLLATE Latin1_General_CI_AS NULL,
 CONSTRAINT [PK_StudentSelected_ModuleMaster_1] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[StudentSelected_ModuleMaster] ON
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (259, N'W1', N'Computer Science', 21, N'3', N'6th       ', 2, N'Advanced Web Technology', N'15', N'ECWM604', N'Semester2', 2, N'Tuesday,12-14', N'Tuesday, 16-18', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (260, N'W1', N'Computer Science', 21, N'3', N'6th       ', 2, N'Software Quality', N'15', N'ECS607', N'Semester1', 1, N'Wednesday,16-18', N'Thrusday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (261, N'W1', N'Computer Science', 21, N'3', N'6th       ', 2, N'Computer Systems Administrator', N'15', N'ECSE615', N'Semester1', 1, N'Monday,16-18', N'Tuesday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (262, N'W1', N'Computer Science', 21, N'3', N'6th       ', 3, N'Requirements Engineering', N'15', N'ECWM617', N'Semester1', 1, N'Wednesday,09-11', N'Wednesday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (263, N'W1', N'Computer Science', 21, N'3', N'6th       ', 3, N'Mobile User Experience', N'15', N'EIMM609', N'Semester1', 1, N'Monday,09-11', N'Monday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (264, N'W1', N'Computer Science', 21, N'3', N'6th       ', 3, N'Computer Forensics Investigation', N'15', N'ECM408', N'Semester2', 2, N'Friday,16-18', N'Friday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (265, N'W1', N'Computer Science', 21, N'1', N'4th       ', 4, N'Computer Systems Fundamentals', N'15', N'EMS509', N'Semester1', 1, N'Monday,16-16', N'Tuesday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (266, N'W1', N'Computer Science', 21, N'1', N'4th       ', 3, N'Communication and Learning Skills', N'15', N'ECMW403', N'Semester1', 1, N'Monday,09-11', N'Monday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (267, N'W1', N'Computer Science', 21, N'3', N'6th       ', 3, N'Computer Systems Security', N'15', N'ECSE615', N'Semester2', 2, N'Monday,09-11', N'Monday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (268, N'W1', N'Computer Science', 21, N'3', N'6th       ', 3, N'Native programming', N'15', N'ECWM601', N'Semester2', 2, N'Monday,16-18', N'Tuesday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (269, N'W1', N'Computer Science', 21, N'1', N'4th       ', 3, N'Information and Data Modelling', N'15', N'EMCW507', N'Semester1', 1, N'Tuesday,12-14', N'Tuesday, 15-17', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (270, N'W1', N'Computer Science', 21, N'1', N'4th       ', 4, N'Mathematics for Computing', N'15', N'EMME509', N'Semester1', 1, N'Wednesday,09-11', N'Wednesday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (271, N'W1', N'Computer Science', 21, N'1', N'4th       ', 4, N'Software Development Principles', N'15', N'ECSE605', N'Semester2', 2, N'Thrusday,16-18', N'Friday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (272, N'W1', N'Computer Science', 21, N'1', N'4th       ', 3, N'Programming Methodology (Java)', N'15', N'EEMC407', N'Semester2', 2, N'Thrusday,09-11', N'Thrusday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (273, N'W1', N'Computer Science', 21, N'1', N'4th       ', 3, N'Web Technology', N'15', N'EEMW607', N'Semester2', 2, N'Monday,09-11', N'Tuesday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (274, N'W1', N'Computer Science', 21, N'1', N'4th       ', 2, N'Software Engineering Principles', N'15', N'EMW706', N'Semester2', 2, N'Friday,16-18', N'Friday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (275, N'W1', N'Computer Science', 21, N'2', N'5th       ', 3, N'Project Management', N'15', N'ECEE605', N'Semester1', 1, N'Thrusday,12-14', N'Thrusday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (276, N'W1', N'Computer Science', 21, N'2', N'5th       ', 3, N'Object-Oriented Development', N'15', N'ECSW809', N'Semester1', 1, N'Tuesday,12-14', N'Tuesday, 14-18', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (277, N'W1', N'Computer Science', 21, N'2', N'5th       ', 3, N'Algorithms and Data Structures', N'15', N'EEWM208', N'Semester1', 1, N'Monday,09-11', N'Monday, 12-14', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (278, N'W1', N'Computer Science', 21, N'2', N'5th       ', 2, N'Professional Practice', N'15', N'ESCP405', N'Semester1', 1, N'Wednesday,12-14', N'Wednesday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (279, N'W1', N'Computer Science', 21, N'2', N'5th       ', 3, N'Introduction to Symbolic Reasoning', N'15', N'ECS446', N'Semester2', 2, N'Wednesday,12-14', N'Wednesday, 16-18', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (280, N'W1', N'Computer Science', 21, N'2', N'5th       ', 3, N'Database Design and Practice 2', N'15', N'ECSE602', N'Semester2', 2, N'Monday,16-18', N'Tuesday, 09-11', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (281, N'W1', N'Computer Science', 21, N'2', N'5th       ', 3, N'Network Software Development', N'15', N'ECSE807', N'Semester2', 2, N'Thrusday,12-14', N'Thrusday, 16-18', N'y         ')
INSERT [dbo].[StudentSelected_ModuleMaster] ([Id], [EnrollementNo], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [Credites], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture], [Tutorial], [Freeze]) VALUES (282, N'W1', N'Computer Science', 21, N'2', N'5th       ', 3, N'Database Design and Practice 1', N'15', N'EECE708', N'Semester2', 2, N'Monday,12-14', N'Monday, 09-11', N'y         ')
SET IDENTITY_INSERT [dbo].[StudentSelected_ModuleMaster] OFF
/****** Object:  Table [dbo].[ModuleMaster]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[ModuleMaster]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[ModuleMaster](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Course] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Courseid] [int] NULL,
	[YearId] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Year] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Module] [int] NULL,
	[ModuleName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModuleCode] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModuleSem] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ModuleSemId] [int] NULL,
	[Lecture_day] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Lec_From] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Lec_To] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Tutorial_day] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Tut_From] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Tut_To] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Description] [varchar](500) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Credits] [int] NULL,
	[NoofAssesment] [int] NULL,
	[Assesment1] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Assesment2] [numeric](18, 0) NULL,
	[Weight] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
END
GO
SET IDENTITY_INSERT [dbo].[ModuleMaster] ON
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (401, N'Computer Science', 21, N'3', N'6th', 3, N'Computer Systems Security', N'ECSE615', N'Semester2', 2, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'This module will guide you to secure system, and how to how to ensure that you are capable of configure the system.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (402, N'Computer Science', 21, N'3', N'6th', 3, N'Computer Systems Security', N'ECSE615', N'Semester2', 2, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'This module will guide you to secure system, and how to how to ensure that you are capable of configure the system.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (403, N'Computer Science', 21, N'3', N'6th', 3, N'Computer Systems Security', N'ECSE615', N'Semester2', 2, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'This module will guide you to secure system, and how to how to ensure that you are capable of configure the system.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (404, N'Computer Science', 21, N'3', N'6th', 3, N'Native programming', N'ECWM601', N'Semester2', 2, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module will give the chance to develop your skills, and create applications for iPhone, and iPad.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (405, N'Computer Science', 21, N'3', N'6th', 3, N'Native programming', N'ECWM601', N'Semester2', 2, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module will give the chance to develop your skills, and create applications for iPhone, and iPad.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (406, N'Computer Science', 21, N'3', N'6th', 3, N'Native programming', N'ECWM601', N'Semester2', 2, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module will give the chance to develop your skills, and create applications for iPhone, and iPad.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (407, N'Computer Science', 21, N'3', N'6th', 2, N'Advanced Web Technology', N'ECWM604', N'Semester2', 2, N'Tuesday', N'12', N'14', N'Tuesday', N'16', N'18', N'This module will teach you how to develop, and create php, and java servlet web pages', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (408, N'Computer Science', 21, N'3', N'6th', 2, N'Advanced Web Technology', N'ECWM604', N'Semester2', 2, N'Tuesday', N'12', N'14', N'Tuesday', N'16', N'18', N'This module will teach you how to develop, and create php, and java servlet web pages', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (409, N'Computer Science', 21, N'3', N'6th', 5, N'The Semantic and Social Web', N'ECWM618', N'Semester2', 2, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how the system works', 15, 5, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'10')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (410, N'Computer Science', 21, N'3', N'6th', 5, N'The Semantic and Social Web', N'ECWM618', N'Semester2', 2, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how the system works', 15, 5, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'10')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (411, N'Computer Science', 21, N'3', N'6th', 5, N'The Semantic and Social Web', N'ECWM618', N'Semester2', 2, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how the system works', 15, 5, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (412, N'Computer Science', 21, N'3', N'6th', 5, N'The Semantic and Social Web', N'ECWM618', N'Semester2', 2, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how the system works', 15, 5, N'Assessment-4', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (413, N'Computer Science', 21, N'3', N'6th', 5, N'The Semantic and Social Web', N'ECWM618', N'Semester2', 2, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how the system works', 15, 5, N'Assessment-5', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (414, N'Computer Science', 21, N'3', N'6th', 3, N'Mobile User Experience', N'EIMM609', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'This module will teach you how to design ipad application using jQuery mobile.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (415, N'Computer Science', 21, N'3', N'6th', 3, N'Mobile User Experience', N'EIMM609', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'This module will teach you how to design ipad application using jQuery mobile.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (416, N'Computer Science', 21, N'3', N'6th', 3, N'Mobile User Experience', N'EIMM609', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'This module will teach you how to design ipad application using jQuery mobile.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (417, N'Computer Science', 21, N'3', N'6th', 2, N'Computer Systems Administrator', N'ECSE615', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module is will teach you the process of configuring the system.', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (418, N'Computer Science', 21, N'3', N'6th', 2, N'Computer Systems Administrator', N'ECSE615', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module is will teach you the process of configuring the system.', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (419, N'Computer Science', 21, N'3', N'6th', 3, N'Algorithem and data structure', N'ECSE699', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'16', N'18', N'You will be learning about the algorithms in programing languages', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (420, N'Computer Science', 21, N'3', N'6th', 3, N'Algorithem and data structure', N'ECSE699', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'16', N'18', N'You will be learning about the algorithms in programing languages', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (421, N'Computer Science', 21, N'3', N'6th', 3, N'Algorithem and data structure', N'ECSE699', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'16', N'18', N'You will be learning about the algorithms in programing languages', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (422, N'Computer Science', 21, N'3', N'6th', 3, N'Requirements Engineering', N'ECWM617', N'Semester1', 1, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how to write, and check the requirement for a system.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (423, N'Computer Science', 21, N'3', N'6th', 3, N'Requirements Engineering', N'ECWM617', N'Semester1', 1, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how to write, and check the requirement for a system.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (424, N'Computer Science', 21, N'3', N'6th', 3, N'Requirements Engineering', N'ECWM617', N'Semester1', 1, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module will teach you how to write, and check the requirement for a system.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (425, N'Computer Science', 21, N'3', N'6th', 2, N'Software Quality', N'ECS607', N'Semester1', 1, N'Wednesday', N'16', N'18', N'Thrusday', N'09', N'11', N'This module will teach you how the software testing etc...', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (426, N'Computer Science', 21, N'3', N'6th', 2, N'Software Quality', N'ECS607', N'Semester1', 1, N'Wednesday', N'16', N'18', N'Thrusday', N'09', N'11', N'This module will teach you how the software testing etc...', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (427, N'Computer Science', 21, N'3', N'6th', 3, N'Computer Forensics Investigation', N'ECM408', N'Semester2', 2, N'Friday', N'16', N'18', N'Friday', N'09', N'11', N'This module is about forensics.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (428, N'Computer Science', 21, N'3', N'6th', 3, N'Computer Forensics Investigation', N'ECM408', N'Semester2', 2, N'Friday', N'16', N'18', N'Friday', N'09', N'11', N'This module is about forensics.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (429, N'Computer Science', 21, N'3', N'6th', 3, N'Computer Forensics Investigation', N'ECM408', N'Semester2', 2, N'Friday', N'16', N'18', N'Friday', N'09', N'11', N'This module is about forensics.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (430, N'Computer Science', 21, N'1', N'4th', 3, N'Communication and Learning Skills', N'ECMW403', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'The module will teach you how the English can be used in the computing department.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (431, N'Computer Science', 21, N'1', N'4th', 3, N'Communication and Learning Skills', N'ECMW403', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'The module will teach you how the English can be used in the computing department.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (432, N'Computer Science', 21, N'1', N'4th', 3, N'Communication and Learning Skills', N'ECMW403', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'The module will teach you how the English can be used in the computing department.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (433, N'Computer Science', 21, N'4', N'4th', 4, N'Computer Systems Fundamentals', N'EMS509', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module will teach you how the memory allocation, and how to create app using pep', 15, 4, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (434, N'Computer Science', 21, N'4', N'4th', 4, N'Computer Systems Fundamentals', N'EMS509', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module will teach you how the memory allocation, and how to create app using pep', 15, 4, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (435, N'Computer Science', 21, N'4', N'4th', 4, N'Computer Systems Fundamentals', N'EMS509', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module will teach you how the memory allocation, and how to create app using pep', 15, 4, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (436, N'Computer Science', 21, N'4', N'4th', 4, N'Computer Systems Fundamentals', N'EMS509', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module will teach you how the memory allocation, and how to create app using pep', 15, 4, N'Assessment-4', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (437, N'Computer Science', 21, N'1', N'4th', 3, N'Information and Data Modelling', N'EMCW507', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'15', N'17', N'This module will teach you how create the system using classes, and domain modules etc..', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (438, N'Computer Science', 21, N'1', N'4th', 3, N'Information and Data Modelling', N'EMCW507', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'15', N'17', N'This module will teach you how create the system using classes, and domain modules etc..', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (439, N'Computer Science', 21, N'1', N'4th', 3, N'Information and Data Modelling', N'EMCW507', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'15', N'17', N'This module will teach you how create the system using classes, and domain modules etc..', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (440, N'Computer Science', 21, N'1', N'4th', 4, N'Mathematics for Computing', N'EMME509', N'Semester1', 1, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module is base on math for programing, it has an exam, and in class tutorials', 15, 4, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'10')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (441, N'Computer Science', 21, N'1', N'4th', 4, N'Mathematics for Computing', N'EMME509', N'Semester1', 1, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module is base on math for programing, it has an exam, and in class tutorials', 15, 4, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (442, N'Computer Science', 21, N'1', N'4th', 4, N'Mathematics for Computing', N'EMME509', N'Semester1', 1, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module is base on math for programing, it has an exam, and in class tutorials', 15, 4, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (443, N'Computer Science', 21, N'1', N'4th', 4, N'Mathematics for Computing', N'EMME509', N'Semester1', 1, N'Wednesday', N'09', N'11', N'Wednesday', N'12', N'14', N'This module is base on math for programing, it has an exam, and in class tutorials', 15, 4, N'Assessment-4', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (444, N'Computer Science', 21, N'1', N'4th', 3, N'Programming Methodology (Java)', N'EEMC407', N'Semester2', 2, N'Thrusday', N'09', N'11', N'Thrusday', N'12', N'14', N'This module is about java programing.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (445, N'Computer Science', 21, N'1', N'4th', 3, N'Programming Methodology (Java)', N'EEMC407', N'Semester2', 2, N'Thrusday', N'09', N'11', N'Thrusday', N'12', N'14', N'This module is about java programing.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (446, N'Computer Science', 21, N'1', N'4th', 3, N'Programming Methodology (Java)', N'EEMC407', N'Semester2', 2, N'Thrusday', N'09', N'11', N'Thrusday', N'12', N'14', N'This module is about java programing.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (447, N'Computer Science', 21, N'1', N'4th', 4, N'Software Development Principles', N'ECSE605', N'Semester2', 2, N'Thrusday', N'16', N'18', N'Friday', N'09', N'11', N'This module will have three test, and contain java swing.', 15, 4, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (448, N'Computer Science', 21, N'1', N'4th', 4, N'Software Development Principles', N'ECSE605', N'Semester2', 2, N'Thrusday', N'16', N'18', N'Friday', N'09', N'11', N'This module will have three test, and contain java swing.', 15, 4, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (449, N'Computer Science', 21, N'1', N'4th', 4, N'Software Development Principles', N'ECSE605', N'Semester2', 2, N'Thrusday', N'16', N'18', N'Friday', N'09', N'11', N'This module will have three test, and contain java swing.', 15, 4, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (450, N'Computer Science', 21, N'1', N'4th', 4, N'Software Development Principles', N'ECSE605', N'Semester2', 2, N'Thrusday', N'16', N'18', N'Friday', N'09', N'11', N'This module will have three test, and contain java swing.', 15, 4, N'Assessment-4', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (451, N'Computer Science', 21, N'1', N'4th', 2, N'Software Engineering Principles', N'EMW706', N'Semester2', 2, N'Friday', N'16', N'18', N'Friday', N'12', N'14', N'This module is about the industry system, and communications with systems.', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (452, N'Computer Science', 21, N'1', N'4th', 2, N'Software Engineering Principles', N'EMW706', N'Semester2', 2, N'Friday', N'16', N'18', N'Friday', N'12', N'14', N'This module is about the industry system, and communications with systems.', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (453, N'Computer Science', 21, N'1', N'4th', 3, N'Web Technology', N'EEMW607', N'Semester2', 2, N'Monday', N'09', N'11', N'Tuesday', N'12', N'14', N'In this module student will learn how to create website using HTML, CSS, and JavaScript', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (454, N'Computer Science', 21, N'1', N'4th', 3, N'Web Technology', N'EEMW607', N'Semester2', 2, N'Monday', N'09', N'11', N'Tuesday', N'12', N'14', N'In this module student will learn how to create website using HTML, CSS, and JavaScript', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (455, N'Computer Science', 21, N'1', N'4th', 3, N'Web Technology', N'EEMW607', N'Semester2', 2, N'Monday', N'09', N'11', N'Tuesday', N'12', N'14', N'In this module student will learn how to create website using HTML, CSS, and JavaScript', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (456, N'Computer Science', 21, N'2', N'5th', 3, N'Algorithms and Data Structures', N'EEWM208', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'You will learn how to develop algorithms', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (457, N'Computer Science', 21, N'2', N'5th', 3, N'Algorithms and Data Structures', N'EEWM208', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'You will learn how to develop algorithms', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (458, N'Computer Science', 21, N'2', N'5th', 3, N'Algorithms and Data Structures', N'EEWM208', N'Semester1', 1, N'Monday', N'09', N'11', N'Monday', N'12', N'14', N'You will learn how to develop algorithms', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (459, N'Computer Science', 21, N'2', N'5th', 2, N'Human Computer Interface Design', N'ESEW809', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This is how to create good HCI quality applications.', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (460, N'Computer Science', 21, N'2', N'5th', 2, N'Human Computer Interface Design', N'ESEW809', N'Semester1', 1, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This is how to create good HCI quality applications.', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (461, N'Computer Science', 21, N'2', N'5th', 3, N'Object-Oriented Development', N'ECSW809', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'14', N'18', N'Developing application using c sharp', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (462, N'Computer Science', 21, N'2', N'5th', 3, N'Object-Oriented Development', N'ECSW809', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'14', N'18', N'Developing application using c sharp', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (463, N'Computer Science', 21, N'2', N'5th', 3, N'Object-Oriented Development', N'ECSW809', N'Semester1', 1, N'Tuesday', N'12', N'14', N'Tuesday', N'14', N'18', N'Developing application using c sharp', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'20')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (464, N'Computer Science', 21, N'2', N'5th', 2, N'Professional Practice', N'ESCP405', N'Semester1', 1, N'Wednesday', N'12', N'14', N'Wednesday', N'09', N'11', N'Learning how the industry works, and the code of conduct.', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (465, N'Computer Science', 21, N'2', N'5th', 2, N'Professional Practice', N'ESCP405', N'Semester1', 1, N'Wednesday', N'12', N'14', N'Wednesday', N'09', N'11', N'Learning how the industry works, and the code of conduct.', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (466, N'Computer Science', 21, N'2', N'5th', 3, N'Project Management', N'ECEE605', N'Semester1', 1, N'Thrusday', N'12', N'14', N'Thrusday', N'09', N'11', N'This module is about developing project.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (467, N'Computer Science', 21, N'2', N'5th', 3, N'Project Management', N'ECEE605', N'Semester1', 1, N'Thrusday', N'12', N'14', N'Thrusday', N'09', N'11', N'This module is about developing project.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (468, N'Computer Science', 21, N'2', N'5th', 3, N'Project Management', N'ECEE605', N'Semester1', 1, N'Thrusday', N'12', N'14', N'Thrusday', N'09', N'11', N'This module is about developing project.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (469, N'Computer Science', 21, N'2', N'5th', 3, N'Database Design and Practice 1', N'EECE708', N'Semester2', 2, N'Monday', N'12', N'14', N'Monday', N'09', N'11', N'Learning how to create database.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (470, N'Computer Science', 21, N'2', N'5th', 3, N'Database Design and Practice 1', N'EECE708', N'Semester2', 2, N'Monday', N'12', N'14', N'Monday', N'09', N'11', N'Learning how to create database.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (471, N'Computer Science', 21, N'2', N'5th', 3, N'Database Design and Practice 1', N'EECE708', N'Semester2', 2, N'Monday', N'12', N'14', N'Monday', N'09', N'11', N'Learning how to create database.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (472, N'Computer Science', 21, N'2', N'5th', 3, N'Database Design and Practice 2', N'ECSE602', N'Semester2', 2, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module require database 1', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (473, N'Computer Science', 21, N'2', N'5th', 3, N'Database Design and Practice 2', N'ECSE602', N'Semester2', 2, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module require database 1', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (474, N'Computer Science', 21, N'2', N'5th', 3, N'Database Design and Practice 2', N'ECSE602', N'Semester2', 2, N'Monday', N'16', N'18', N'Tuesday', N'09', N'11', N'This module require database 1', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (475, N'Computer Science', 21, N'2', N'5th', 2, N'Introduction to 3D Graphics', N'ESEC805', N'Semester2', 2, N'Tuesday', N'12', N'14', N'Tuesday', N'16', N'18', N'Learning how to develop games using openGL', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (476, N'Computer Science', 21, N'2', N'5th', 2, N'Introduction to 3D Graphics', N'ESEC805', N'Semester2', 2, N'Tuesday', N'12', N'14', N'Tuesday', N'16', N'18', N'Learning how to develop games using openGL', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (477, N'Computer Science', 21, N'2', N'5th', 3, N'Introduction to Symbolic Reasoning', N'ECS446', N'Semester2', 2, N'Wednesday', N'12', N'14', N'Wednesday', N'16', N'18', N'Description of module goes here.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (478, N'Computer Science', 21, N'2', N'5th', 3, N'Introduction to Symbolic Reasoning', N'ECS446', N'Semester2', 2, N'Wednesday', N'12', N'14', N'Wednesday', N'16', N'18', N'Description of module goes here.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (479, N'Computer Science', 21, N'2', N'5th', 3, N'Introduction to Symbolic Reasoning', N'ECS446', N'Semester2', 2, N'Wednesday', N'12', N'14', N'Wednesday', N'16', N'18', N'Description of module goes here.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (480, N'Computer Science', 21, N'2', N'5th', 2, N'Mobile Application Development', N'ESCC706', N'Semester2', 2, N'Wednesday', N'09', N'11', N'Thrusday', N'09', N'11', N'Developing application for mobile phone.', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (481, N'Computer Science', 21, N'2', N'5th', 2, N'Mobile Application Development', N'ESCC706', N'Semester2', 2, N'Wednesday', N'09', N'11', N'Thrusday', N'09', N'11', N'Developing application for mobile phone.', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'60')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (482, N'Computer Science', 21, N'2', N'5th', 3, N'Network Software Development', N'ECSE807', N'Semester2', 2, N'Thrusday', N'12', N'14', N'Thrusday', N'16', N'18', N'Learing how to build sama on unix system.', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (483, N'Computer Science', 21, N'2', N'5th', 3, N'Network Software Development', N'ECSE807', N'Semester2', 2, N'Thrusday', N'12', N'14', N'Thrusday', N'16', N'18', N'Learing how to build sama on unix system.', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (484, N'Computer Science', 21, N'2', N'5th', 3, N'Network Software Development', N'ECSE807', N'Semester2', 2, N'Thrusday', N'12', N'14', N'Thrusday', N'16', N'18', N'Learing how to build sama on unix system.', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (485, N'Computer Science', 21, N'1', N'4th', 3, N'System Software and Tools', N'ESE506', N'Semester1', 1, N'Friday', N'09', N'11', N'Friday', N'12', N'14', N'Description is here', 15, 3, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (486, N'Computer Science', 21, N'1', N'4th', 3, N'System Software and Tools', N'ESE506', N'Semester1', 1, N'Friday', N'09', N'11', N'Friday', N'12', N'14', N'Description is here', 15, 3, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'30')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (487, N'Computer Science', 21, N'1', N'4th', 3, N'System Software and Tools', N'ESE506', N'Semester1', 1, N'Friday', N'09', N'11', N'Friday', N'12', N'14', N'Description is here', 15, 3, N'Assessment-3', CAST(100 AS Numeric(18, 0)), N'40')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (488, N'Computer Science', 21, N'1', N'4th', 2, N'Web Programming', N'ESEM607', N'Semester1', 1, N'Thrusday', N'09', N'11', N'Thrusday', N'12', N'14', N'Description', 15, 2, N'Assessment-1', CAST(100 AS Numeric(18, 0)), N'50')
INSERT [dbo].[ModuleMaster] ([Id], [Course], [Courseid], [YearId], [Year], [Module], [ModuleName], [ModuleCode], [ModuleSem], [ModuleSemId], [Lecture_day], [Lec_From], [Lec_To], [Tutorial_day], [Tut_From], [Tut_To], [Description], [Credits], [NoofAssesment], [Assesment1], [Assesment2], [Weight]) VALUES (489, N'Computer Science', 21, N'1', N'4th', 2, N'Web Programming', N'ESEM607', N'Semester1', 1, N'Thrusday', N'09', N'11', N'Thrusday', N'12', N'14', N'Description', 15, 2, N'Assessment-2', CAST(100 AS Numeric(18, 0)), N'50')
SET IDENTITY_INSERT [dbo].[ModuleMaster] OFF
/****** Object:  Table [dbo].[MasterUserRights]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterUserRights]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MasterUserRights](
	[SNo] [int] NULL,
	[UserRole] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[AddRights] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EditRights] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[DeleteRights] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[RoleID] [varchar](10) COLLATE SQL_Latin1_General_CP1_CI_AS NULL
)
END
GO
INSERT [dbo].[MasterUserRights] ([SNo], [UserRole], [AddRights], [EditRights], [DeleteRights], [RoleID]) VALUES (201, N'Admin', NULL, NULL, NULL, N'SAM')
INSERT [dbo].[MasterUserRights] ([SNo], [UserRole], [AddRights], [EditRights], [DeleteRights], [RoleID]) VALUES (202, N'Student', NULL, NULL, NULL, N'STUDENT')
/****** Object:  Table [dbo].[MasterStates]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[MasterStates]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[MasterStates](
	[Id] [int] NOT NULL,
	[StateName] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_MasterStates] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
INSERT [dbo].[MasterStates] ([Id], [StateName]) VALUES (1, N'Yorkshire')
/****** Object:  Table [dbo].[Logindetails]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Logindetails]') AND type in (N'U'))
BEGIN
CREATE TABLE [dbo].[Logindetails](
	[SNo] [int] IDENTITY(1,1) NOT NULL,
	[UserId] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Pswd] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Active] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[RoleID] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[EnrollementNo] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NOT NULL,
	[Name] [char](20) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Dob] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Gender] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Courseid] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Course] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Father] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Doj] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Occupation] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Present_Address] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Email] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Emergency_Contact] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[Phone] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[RegDate] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[ExpDate] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
	[City] [varchar](50) COLLATE SQL_Latin1_General_CP1_CI_AS NULL,
 CONSTRAINT [PK_Logindetails1] PRIMARY KEY CLUSTERED 
(
	[EnrollementNo] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON)
)
END
GO
SET IDENTITY_INSERT [dbo].[Logindetails] ON
INSERT [dbo].[Logindetails] ([SNo], [UserId], [Pswd], [Active], [RoleID], [EnrollementNo], [Name], [Dob], [Gender], [Courseid], [Course], [Father], [Doj], [Occupation], [Present_Address], [Email], [Emergency_Contact], [Phone], [RegDate], [ExpDate], [City]) VALUES (47, N'Abdalla', N'abdalla', N'y', N'SAM', N'n', N'Abdalla             ', N'15-02-2012', N'Male', NULL, NULL, N'fdf', NULL, N'fdg', N'd', N'a@gmail.com', N'54656', N'6546546', N'15-2-2012', NULL, NULL)
INSERT [dbo].[Logindetails] ([SNo], [UserId], [Pswd], [Active], [RoleID], [EnrollementNo], [Name], [Dob], [Gender], [Courseid], [Course], [Father], [Doj], [Occupation], [Present_Address], [Email], [Emergency_Contact], [Phone], [RegDate], [ExpDate], [City]) VALUES (58, N'W1', N'123', N'y', N'STUDENT', N'W1', N'Abdalla             ', N'25-12-1988', N'Male', N'21', N'Computer Science', N'Sala', NULL, N'student', N'21 Salisbury road,
London', N'asdasd@msn.com', N'0', N'0', N'22-4-2012', NULL, NULL)
SET IDENTITY_INSERT [dbo].[Logindetails] OFF
/****** Object:  StoredProcedure [dbo].[logincheck]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[logincheck]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'
CREATE procedure [dbo].[logincheck] @user_type varchar(20), @user_id varchar(20),@user_pass varchar(20)
as
begin
select LD.UserId,LD.Pswd,LD.Name as FullName,
LD.ExpDate,LD.RoleID 
from LoginDetails as LD
 where  LD.UserId=@user_id and LD.Pswd=@user_pass 

--and LD.Active=''y'' 
end









' 
END
GO
/****** Object:  StoredProcedure [dbo].[fetchstate]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fetchstate]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'



CREATE procedure [dbo].[fetchstate]
as
begin
select Id,StateName from MasterStates order by StateName asc
end



' 
END
GO
/****** Object:  StoredProcedure [dbo].[fetchrole]    Script Date: 04/25/2012 01:16:02 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[fetchrole]') AND type in (N'P', N'PC'))
BEGIN
EXEC dbo.sp_executesql @statement = N'

CREATE procedure [dbo].[fetchrole]
as
begin
select SNo,UserRole from MasterUserRights order by SNo asc
end

' 
END
GO
