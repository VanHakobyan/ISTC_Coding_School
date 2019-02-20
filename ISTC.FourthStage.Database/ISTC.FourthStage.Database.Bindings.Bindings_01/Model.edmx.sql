
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 02/20/2019 19:46:13
-- Generated from EDMX file: E:\Source\repos\VanHakobyan\ISTC_Coding_School\ISTC.FourthStage.Database\ISTC.FourthStage.Database.Bindings.Bindings_01\Model.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [Bindings];
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

-- Creating table 'Faculties'
CREATE TABLE [dbo].[Faculties] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Dean_Id] int  NOT NULL
);
GO

-- Creating table 'Deans'
CREATE TABLE [dbo].[Deans] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [About] nvarchar(max)  NOT NULL,
    [IsCorrupted] bit  NOT NULL
);
GO

-- Creating table 'Students'
CREATE TABLE [dbo].[Students] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Age] int  NOT NULL,
    [GPA] real  NOT NULL,
    [Status] nvarchar(max)  NOT NULL,
    [FacultyId] int  NOT NULL
);
GO

-- Creating table 'Subjects'
CREATE TABLE [dbo].[Subjects] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [Type] nvarchar(max)  NOT NULL,
    [Credit] int  NOT NULL
);
GO

-- Creating table 'SubjectStudent'
CREATE TABLE [dbo].[SubjectStudent] (
    [Subjects_Id] int  NOT NULL,
    [Students_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [PK_Faculties]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Deans'
ALTER TABLE [dbo].[Deans]
ADD CONSTRAINT [PK_Deans]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [PK_Students]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Subjects'
ALTER TABLE [dbo].[Subjects]
ADD CONSTRAINT [PK_Subjects]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Subjects_Id], [Students_Id] in table 'SubjectStudent'
ALTER TABLE [dbo].[SubjectStudent]
ADD CONSTRAINT [PK_SubjectStudent]
    PRIMARY KEY CLUSTERED ([Subjects_Id], [Students_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Dean_Id] in table 'Faculties'
ALTER TABLE [dbo].[Faculties]
ADD CONSTRAINT [FK_FacultyDean]
    FOREIGN KEY ([Dean_Id])
    REFERENCES [dbo].[Deans]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyDean'
CREATE INDEX [IX_FK_FacultyDean]
ON [dbo].[Faculties]
    ([Dean_Id]);
GO

-- Creating foreign key on [FacultyId] in table 'Students'
ALTER TABLE [dbo].[Students]
ADD CONSTRAINT [FK_FacultyStudent]
    FOREIGN KEY ([FacultyId])
    REFERENCES [dbo].[Faculties]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_FacultyStudent'
CREATE INDEX [IX_FK_FacultyStudent]
ON [dbo].[Students]
    ([FacultyId]);
GO

-- Creating foreign key on [Subjects_Id] in table 'SubjectStudent'
ALTER TABLE [dbo].[SubjectStudent]
ADD CONSTRAINT [FK_SubjectStudent_Subject]
    FOREIGN KEY ([Subjects_Id])
    REFERENCES [dbo].[Subjects]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Students_Id] in table 'SubjectStudent'
ALTER TABLE [dbo].[SubjectStudent]
ADD CONSTRAINT [FK_SubjectStudent_Student]
    FOREIGN KEY ([Students_Id])
    REFERENCES [dbo].[Students]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_SubjectStudent_Student'
CREATE INDEX [IX_FK_SubjectStudent_Student]
ON [dbo].[SubjectStudent]
    ([Students_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------