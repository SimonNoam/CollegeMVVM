
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/23/2022 12:35:59
-- Generated from EDMX file: C:\Users\noamm\OneDrive\שולחן העבודה\ExerciseOnData\ExerciseOnData\DataModel\SchoolModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [SchoolData];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[FK_StudentTeacher_Student]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentTeacher] DROP CONSTRAINT [FK_StudentTeacher_Student];
GO
IF OBJECT_ID(N'[dbo].[FK_StudentTeacher_Teacher]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[StudentTeacher] DROP CONSTRAINT [FK_StudentTeacher_Teacher];
GO
IF OBJECT_ID(N'[dbo].[FK_Student_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persons_Student] DROP CONSTRAINT [FK_Student_inherits_Person];
GO
IF OBJECT_ID(N'[dbo].[FK_Teacher_inherits_Person]', 'F') IS NOT NULL
    ALTER TABLE [dbo].[Persons_Teacher] DROP CONSTRAINT [FK_Teacher_inherits_Person];
GO

-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------

IF OBJECT_ID(N'[dbo].[Persons]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons];
GO
IF OBJECT_ID(N'[dbo].[Persons_Student]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons_Student];
GO
IF OBJECT_ID(N'[dbo].[Persons_Teacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[Persons_Teacher];
GO
IF OBJECT_ID(N'[dbo].[StudentTeacher]', 'U') IS NOT NULL
    DROP TABLE [dbo].[StudentTeacher];
GO

-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Persons'
CREATE TABLE [dbo].[Persons] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Persons_Student'
CREATE TABLE [dbo].[Persons_Student] (
    [Grade] float  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'Persons_Teacher'
CREATE TABLE [dbo].[Persons_Teacher] (
    [Course] int  NOT NULL,
    [Id] int  NOT NULL
);
GO

-- Creating table 'StudentTeacher'
CREATE TABLE [dbo].[StudentTeacher] (
    [Student_Id] int  NOT NULL,
    [Teacher_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Persons'
ALTER TABLE [dbo].[Persons]
ADD CONSTRAINT [PK_Persons]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persons_Student'
ALTER TABLE [dbo].[Persons_Student]
ADD CONSTRAINT [PK_Persons_Student]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Persons_Teacher'
ALTER TABLE [dbo].[Persons_Teacher]
ADD CONSTRAINT [PK_Persons_Teacher]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Student_Id], [Teacher_Id] in table 'StudentTeacher'
ALTER TABLE [dbo].[StudentTeacher]
ADD CONSTRAINT [PK_StudentTeacher]
    PRIMARY KEY CLUSTERED ([Student_Id], [Teacher_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Student_Id] in table 'StudentTeacher'
ALTER TABLE [dbo].[StudentTeacher]
ADD CONSTRAINT [FK_StudentTeacher_Student]
    FOREIGN KEY ([Student_Id])
    REFERENCES [dbo].[Persons_Student]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Teacher_Id] in table 'StudentTeacher'
ALTER TABLE [dbo].[StudentTeacher]
ADD CONSTRAINT [FK_StudentTeacher_Teacher]
    FOREIGN KEY ([Teacher_Id])
    REFERENCES [dbo].[Persons_Teacher]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentTeacher_Teacher'
CREATE INDEX [IX_FK_StudentTeacher_Teacher]
ON [dbo].[StudentTeacher]
    ([Teacher_Id]);
GO

-- Creating foreign key on [Id] in table 'Persons_Student'
ALTER TABLE [dbo].[Persons_Student]
ADD CONSTRAINT [FK_Student_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Persons]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Id] in table 'Persons_Teacher'
ALTER TABLE [dbo].[Persons_Teacher]
ADD CONSTRAINT [FK_Teacher_inherits_Person]
    FOREIGN KEY ([Id])
    REFERENCES [dbo].[Persons]
        ([Id])
    ON DELETE CASCADE ON UPDATE NO ACTION;
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------