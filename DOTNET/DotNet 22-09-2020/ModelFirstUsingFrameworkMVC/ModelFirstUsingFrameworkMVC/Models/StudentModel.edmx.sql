
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 09/22/2020 10:55:21
-- Generated from EDMX file: C:\Users\hp\source\repos\ModelFirstUsingFrameworkMVC\ModelFirstUsingFrameworkMVC\Models\StudentModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [College];
GO
IF SCHEMA_ID(N'dbo') IS NULL EXECUTE(N'CREATE SCHEMA [dbo]');
GO

-- --------------------------------------------------
-- Dropping existing FOREIGN KEY constraints
-- --------------------------------------------------


-- --------------------------------------------------
-- Dropping existing tables
-- --------------------------------------------------


-- --------------------------------------------------
-- Creating all tables
-- --------------------------------------------------

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Adreess] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Marks'
CREATE TABLE [dbo].[Marks] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Subject] nvarchar(max)  NOT NULL,
    [S_Marks] nvarchar(max)  NOT NULL,
    [StudentId] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [PK_Marks]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [StudentId] in table 'Marks'
ALTER TABLE [dbo].[Marks]
ADD CONSTRAINT [FK_StudentMark]
    FOREIGN KEY ([StudentId])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_StudentMark'
CREATE INDEX [IX_FK_StudentMark]
ON [dbo].[Marks]
    ([StudentId]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------