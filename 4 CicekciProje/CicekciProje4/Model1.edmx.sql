
-- --------------------------------------------------
-- Entity Designer DDL Script for SQL Server 2005, 2008, 2012 and Azure
-- --------------------------------------------------
-- Date Created: 04/21/2022 21:46:43
-- Generated from EDMX file: C:\Users\hvdem\Desktop\Bugün\CicekciProje4\CicekciProje4\Model1.edmx
-- --------------------------------------------------

SET QUOTED_IDENTIFIER OFF;
GO
USE [cicekci];
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

-- Creating table 'kullaniciSet'
CREATE TABLE [dbo].[kullaniciSet] (
    [Kul_id] int IDENTITY(1,1) NOT NULL,
    [kulAd] nvarchar(max)  NOT NULL,
    [kulSifre] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'musteriSet'
CREATE TABLE [dbo].[musteriSet] (
    [Mus_id] int IDENTITY(1,1) NOT NULL,
    [MusteriAd] nvarchar(max)  NOT NULL,
    [MusAdres] nvarchar(max)  NOT NULL,
    [MusTel] nvarchar(max)  NOT NULL
);
GO

-- Creating table 'UrunSet'
CREATE TABLE [dbo].[UrunSet] (
    [Urun_id] int IDENTITY(1,1) NOT NULL,
    [UrunAd] nvarchar(max)  NOT NULL,
    [UrunFiyat] int  NOT NULL
);
GO

-- Creating table 'SiparisSet'
CREATE TABLE [dbo].[SiparisSet] (
    [Sip_id] int IDENTITY(1,1) NOT NULL,
    [SipAdres] nvarchar(max)  NOT NULL,
    [Adet] int  NOT NULL,
    [Tutar] int  NOT NULL,
    [mus_id] int  NOT NULL,
    [Urun_id] int  NOT NULL
);
GO

-- --------------------------------------------------
-- Creating all PRIMARY KEY constraints
-- --------------------------------------------------

-- Creating primary key on [Kul_id] in table 'kullaniciSet'
ALTER TABLE [dbo].[kullaniciSet]
ADD CONSTRAINT [PK_kullaniciSet]
    PRIMARY KEY CLUSTERED ([Kul_id] ASC);
GO

-- Creating primary key on [Mus_id] in table 'musteriSet'
ALTER TABLE [dbo].[musteriSet]
ADD CONSTRAINT [PK_musteriSet]
    PRIMARY KEY CLUSTERED ([Mus_id] ASC);
GO

-- Creating primary key on [Urun_id] in table 'UrunSet'
ALTER TABLE [dbo].[UrunSet]
ADD CONSTRAINT [PK_UrunSet]
    PRIMARY KEY CLUSTERED ([Urun_id] ASC);
GO

-- Creating primary key on [Sip_id] in table 'SiparisSet'
ALTER TABLE [dbo].[SiparisSet]
ADD CONSTRAINT [PK_SiparisSet]
    PRIMARY KEY CLUSTERED ([Sip_id] ASC);
GO

-- --------------------------------------------------
-- Creating all FOREIGN KEY constraints
-- --------------------------------------------------

-- Creating foreign key on [mus_id] in table 'SiparisSet'
ALTER TABLE [dbo].[SiparisSet]
ADD CONSTRAINT [FK_musteriSiparis]
    FOREIGN KEY ([mus_id])
    REFERENCES [dbo].[musteriSet]
        ([Mus_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_musteriSiparis'
CREATE INDEX [IX_FK_musteriSiparis]
ON [dbo].[SiparisSet]
    ([mus_id]);
GO

-- Creating foreign key on [Urun_id] in table 'SiparisSet'
ALTER TABLE [dbo].[SiparisSet]
ADD CONSTRAINT [FK_UrunSiparis]
    FOREIGN KEY ([Urun_id])
    REFERENCES [dbo].[UrunSet]
        ([Urun_id])
    ON DELETE NO ACTION ON UPDATE NO ACTION;
GO

-- Creating non-clustered index for FOREIGN KEY 'FK_UrunSiparis'
CREATE INDEX [IX_FK_UrunSiparis]
ON [dbo].[SiparisSet]
    ([Urun_id]);
GO

-- --------------------------------------------------
-- Script has ended
-- --------------------------------------------------