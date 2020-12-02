CREATE TABLE [dbo].[Students]
(
	[Id] INT NOT NULL PRIMARY KEY IDENTITY, 
    [Name] NVARCHAR(100) NOT NULL, 
    [IndexNumber] NVARCHAR(20) NOT NULL, 
    [AverageMark] DECIMAL(16, 2) NULL
)



SET IDENTITY_INSERT [dbo].[Students] ON
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (1, N'Ivan Maćić', N'505/2020', CAST(8.35 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (2, N'Nemanja Kutlešić', N'507/2020', CAST(8.98 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (3, N'Stefan Šošić', N'509/2020', CAST(9.56 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (4, N'Stefan Radovanović', N'510/2020', CAST(8.26 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (5, N'Mina Tanasković', N'515/2020', CAST(8.37 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (6, N'Mladen Obradović', N'520/2020', CAST(8.47 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (7, N'Jovica Misirlić', N'522/2020', CAST(8.02 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (8, N'Marko Bogdanović', N'523/2020', CAST(8.09 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (9, N'Pavle Pavlović', N'525/2020', CAST(8.02 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (10, N'Kristina Resimić', N'526/2020', CAST(8.16 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (11, N'Sanja Ćurčić', N'528/2020', CAST(8.05 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (12, N'Stefan Jovanović', N'529/2020', CAST(9.23 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (13, N'Dušica Nikolić', N'530/2020', CAST(8.70 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (14, N'Slavko Džulović', N'531/2020', CAST(9.33 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (15, N'Zorana Gavrilović', N'533/2020', CAST(9.65 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (16, N'Jelena Polumirac', N'538/2020', CAST(7.00 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (17, N'Nemanja Vuković', N'540/2020', CAST(6.56 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (18, N'Milica Jokić', N'541/2020', CAST(9.23 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (19, N'Zvonko Simić', N'544/2020', CAST(8.40 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (20, N'Bogdan Mandić', N'545/2020', CAST(8.65 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (21, N'Alјoša Dmitrović', N'555/2020', CAST(8.30 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (22, N'Stefan Čeperković', N'556/2020', CAST(8.40 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (23, N'Milan Radulović', N'560/2020', CAST(8.37 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (24, N'Milica Nenadović', N'563/2020', CAST(7.93 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (25, N'Sandra Ristić', N'565/2020', CAST(6.86 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (26, N'Filip Filipović', N'567/2020', CAST(6.60 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (27, N'Lazar Dražević', N'573/2020', CAST(7.42 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (28, N'Nјegoš Janjić', N'574/2020', CAST(7.63 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (29, N'Milica Maksimović', N'576/2020', CAST(7.91 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (30, N'Aleksandar Todorović', N'577/2020', CAST(7.30 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (31, N'Lazar Radovanović', N'579/2020', CAST(6.56 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (32, N'Ana Rađenović', N'581/2020', CAST(7.49 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (33, N'Nebojša Rađenović', N'583/2020', CAST(6.89 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (34, N'Đorđe Đurović', N'584/2020', CAST(7.47 AS Decimal(16, 2)))
INSERT INTO [dbo].[Students] ([Id], [Name], [IndexNumber], [AverageMark]) VALUES (35, N'Petar Lazarević', N'585/2020', CAST(7.09 AS Decimal(16, 2)))
SET IDENTITY_INSERT [dbo].[Students] OFF
