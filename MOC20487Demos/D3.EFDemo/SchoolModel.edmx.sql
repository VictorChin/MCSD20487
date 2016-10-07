
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, and Azure
-- --------------------------------------------------
-- Date Created: 05/18/2014 08:54:03
-- Generated from EDMX file: c:\users\admin\documents\visual studio 2012\Projects\EFDemo\EFDemo\SchoolModel.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Northwind];
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

-- Creating table 'Schools'
CREATE TABLE [dbo].[Schools] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [SchoolName] nvarchar(40)  NOT NULL,
    [PostalAddress_Street] nvarchar(max)  NOT NULL,
    [PostalAddress_City] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'Pupils'
CREATE TABLE [dbo].[Pupils] (
    [Id] int IDENTITY(1,1) NOT NULL
);
GO

-- Creating table 'SchoolPupil'
CREATE TABLE [dbo].[SchoolPupil] (
    [Schools_Id] int  NOT NULL,
    [Pupils_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Schools'
ALTER TABLE [dbo].[Schools]
ADD CONSTRAINT [PK_Schools]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Pupils'
ALTER TABLE [dbo].[Pupils]
ADD CONSTRAINT [PK_Pupils]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Schools_Id], [Pupils_Id] in table 'SchoolPupil'
ALTER TABLE [dbo].[SchoolPupil]
ADD CONSTRAINT [PK_SchoolPupil]
    PRIMARY KEY NONCLUSTERED ([Schools_Id], [Pupils_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Schools_Id] in table 'SchoolPupil'
ALTER TABLE [dbo].[SchoolPupil]
ADD CONSTRAINT [FK_SchoolPupil_School]
    FOREIGN KEY ([Schools_Id])
    REFERENCES [dbo].[Schools]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Pupils_Id] in table 'SchoolPupil'
ALTER TABLE [dbo].[SchoolPupil]
ADD CONSTRAINT [FK_SchoolPupil_Pupil]
    FOREIGN KEY ([Pupils_Id])
    REFERENCES [dbo].[Pupils]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;

-- Creating non-clustered index for FOREIGN KEY 'FK_SchoolPupil_Pupil'
CREATE INDEX [IX_FK_SchoolPupil_Pupil]
ON [dbo].[SchoolPupil]
    ([Pupils_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------