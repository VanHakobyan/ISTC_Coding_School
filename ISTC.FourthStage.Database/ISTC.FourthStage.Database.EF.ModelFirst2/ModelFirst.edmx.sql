
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 10/05/2019 11:23:58
-- Generated from EDMX file: E:\Source\repos\VanHakobyan\ISTC_Coding_School\ISTC.FourthStage.Database\ISTC.FourthStage.Database.EF.ModelFirst2\ModelFirst.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [ModelFirst];
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

-- Creating table 'Teams'
CREATE TABLE [dbo].[Teams] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL,
    [CreateinYear] int  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Reputation] int  NULL
);
GO

-- Creating table 'Players'
CREATE TABLE [dbo].[Players] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [FirstName] nvarchar(max)  NOT NULL,
    [LastName] nvarchar(max)  NOT NULL,
    [Number] nvarchar(max)  NOT NULL,
    [Birthday] nvarchar(max)  NOT NULL,
    [Position] nvarchar(max)  NOT NULL,
    [Country] nvarchar(max)  NOT NULL,
    [Team_Id] int  NOT NULL
);
GO

-- Creating table 'Brands'
CREATE TABLE [dbo].[Brands] (
    [Id] int IDENTITY(1,1) NOT NULL,
    [Name] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'BrandPlayer'
CREATE TABLE [dbo].[BrandPlayer] (
    [Brand_Id] int  NOT NULL,
    [Players_Id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Id] in table 'Teams'
ALTER TABLE [dbo].[Teams]
ADD CONSTRAINT [PK_Teams]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [PK_Players]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Id] in table 'Brands'
ALTER TABLE [dbo].[Brands]
ADD CONSTRAINT [PK_Brands]
    PRIMARY KEY CLUSTERED ([Id] ASC);
GO

-- Creating primary key on [Brand_Id], [Players_Id] in table 'BrandPlayer'
ALTER TABLE [dbo].[BrandPlayer]
ADD CONSTRAINT [PK_BrandPlayer]
    PRIMARY KEY CLUSTERED ([Brand_Id], [Players_Id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [Team_Id] in table 'Players'
ALTER TABLE [dbo].[Players]
ADD CONSTRAINT [FK_TeamPlayer]
    FOREIGN KEY ([Team_Id])
    REFERENCES [dbo].[Teams]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_TeamPlayer'
CREATE INDEX [IX_FK_TeamPlayer]
ON [dbo].[Players]
    ([Team_Id]);
GO

-- Creating foreign key on [Brand_Id] in table 'BrandPlayer'
ALTER TABLE [dbo].[BrandPlayer]
ADD CONSTRAINT [FK_BrandPlayer_Brand]
    FOREIGN KEY ([Brand_Id])
    REFERENCES [dbo].[Brands]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating foreign key on [Players_Id] in table 'BrandPlayer'
ALTER TABLE [dbo].[BrandPlayer]
ADD CONSTRAINT [FK_BrandPlayer_Player]
    FOREIGN KEY ([Players_Id])
    REFERENCES [dbo].[Players]
        ([Id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_BrandPlayer_Player'
CREATE INDEX [IX_FK_BrandPlayer_Player]
ON [dbo].[BrandPlayer]
    ([Players_Id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------