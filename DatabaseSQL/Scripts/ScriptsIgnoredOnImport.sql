
USE [master]
GO

/****** Object:  Database [QuidditchWorldCup]    Script Date: 31/12/2013 15:16:38 ******/
CREATE DATABASE [QuidditchWorldCup]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'QuidditchWorldCup', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQL2012\MSSQL\DATA\QuidditchWorldCup.mdf' , SIZE = 5120KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'QuidditchWorldCup_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL11.SQL2012\MSSQL\DATA\QuidditchWorldCup_log.ldf' , SIZE = 2560KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO

ALTER DATABASE [QuidditchWorldCup] SET COMPATIBILITY_LEVEL = 110
GO

IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [QuidditchWorldCup].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO

ALTER DATABASE [QuidditchWorldCup] SET ANSI_NULL_DEFAULT OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET ANSI_NULLS OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET ANSI_PADDING OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET ANSI_WARNINGS OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET ARITHABORT OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET AUTO_CLOSE OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET AUTO_CREATE_STATISTICS ON
GO

ALTER DATABASE [QuidditchWorldCup] SET AUTO_SHRINK OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET AUTO_UPDATE_STATISTICS ON
GO

ALTER DATABASE [QuidditchWorldCup] SET CURSOR_CLOSE_ON_COMMIT OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET CURSOR_DEFAULT  GLOBAL
GO

ALTER DATABASE [QuidditchWorldCup] SET CONCAT_NULL_YIELDS_NULL OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET NUMERIC_ROUNDABORT OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET QUOTED_IDENTIFIER OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET RECURSIVE_TRIGGERS OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET  DISABLE_BROKER
GO

ALTER DATABASE [QuidditchWorldCup] SET AUTO_UPDATE_STATISTICS_ASYNC OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET DATE_CORRELATION_OPTIMIZATION OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET TRUSTWORTHY OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET ALLOW_SNAPSHOT_ISOLATION OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET PARAMETERIZATION SIMPLE
GO

ALTER DATABASE [QuidditchWorldCup] SET READ_COMMITTED_SNAPSHOT OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET HONOR_BROKER_PRIORITY OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET RECOVERY FULL
GO

ALTER DATABASE [QuidditchWorldCup] SET  MULTI_USER
GO

ALTER DATABASE [QuidditchWorldCup] SET PAGE_VERIFY CHECKSUM
GO

ALTER DATABASE [QuidditchWorldCup] SET DB_CHAINING OFF
GO

ALTER DATABASE [QuidditchWorldCup] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF )
GO

ALTER DATABASE [QuidditchWorldCup] SET TARGET_RECOVERY_TIME = 0 SECONDS
GO

EXEC sys.sp_db_vardecimal_storage_format N'QuidditchWorldCup', N'ON'
GO

USE [QuidditchWorldCup]
GO

/****** Object:  Table [dbo].[Coupes]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Equipes]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Joueurs]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Matchs]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[MatchTypes]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Postes]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Reservations]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Spectateurs]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

/****** Object:  Table [dbo].[Stades]    Script Date: 31/12/2013 15:16:38 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

SET IDENTITY_INSERT [dbo].[Coupes] ON
GO

INSERT [dbo].[Coupes] ([ID], [Annee], [Titre]) VALUES (1, 2010, N'422e coupe du Monde')
GO

SET IDENTITY_INSERT [dbo].[Coupes] OFF
GO

SET IDENTITY_INSERT [dbo].[Equipes] ON
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (1, N'Angleterre', N'Equipe Nationale : Angleterre')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (2, N'Argentine', N'Equipe Nationale : Argentine')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (3, N'Australie', N'Equipe Nationale : Australie')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (4, N'Brésil', N'Equipe Nationale : Brésil')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (5, N'Bulgarie', N'Equipe Nationale : Bulgarie')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (6, N'Écosse', N'Equipe Nationale : Écosse')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (7, N'Espagne', N'Equipe Nationale : Espagne')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (8, N'États-Unis', N'Equipe Nationale : États-Unis')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (9, N'France', N'Equipe Nationale : France')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (10, N'Inde', N'Equipe Nationale : Inde')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (11, N'Irlande', N'Equipe Nationale : Irlande')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (12, N'Japon', N'Equipe Nationale : Japon')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (13, N'Luxembourg', N'Equipe Nationale : Luxembourg')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (14, N'Ouganda', N'Equipe Nationale : Ouganda')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (15, N'Pays de Galles', N'Equipe Nationale : Pays de Galles')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (16, N'Pérou', N'Equipe Nationale : Pérou')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (17, N'Portugal', N'Equipe Nationale : Portugal')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (18, N'Transylvanie', N'Equipe Nationale : Transylvanie')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (19, N'Allemagne', N'Equipe Nationale : Allemagne')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (20, N'Belgique', N'Equipe Nationale : Belgique')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (21, N'Suisse', N'Equipe Nationale : Suisse')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (22, N'Maroc', N'Equipe Nationale : Maroc')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (23, N'Suède', N'Equipe Nationale : Suède')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (24, N'Finlande', N'Equipe Nationale : Finlande')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (25, N'Danemark', N'Equipe Nationale : Danemark')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (26, N'Pologne', N'Equipe Nationale : Pologne')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (27, N'Italie', N'Equipe Nationale : Italie')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (28, N'Chine', N'Equipe Nationale : Chine')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (29, N'Canada', N'Equipe Nationale : Canada')
GO

INSERT [dbo].[Equipes] ([ID], [Pays], [Nom]) VALUES (30, N'Mexique', N'Equipe Nationale : Mexique')
GO

SET IDENTITY_INSERT [dbo].[Equipes] OFF
GO

SET IDENTITY_INSERT [dbo].[Joueurs] ON
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (635, N'Dina', N'Pittmon', CAST(0x00002F7E00000000 AS DateTime), 1, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (636, N'Casandra', N'Eisert', CAST(0x00000C7000000000 AS DateTime), 1, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (637, N'Agueda', N'Hardisty', CAST(0x0000271600000000 AS DateTime), 1, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (638, N'Russell', N'Cantor', CAST(0x00008BEA00000000 AS DateTime), 1, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (639, N'Casandra', N'Filiault', CAST(0x0000298C00000000 AS DateTime), 1, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (640, N'Leonard', N'Roysden', CAST(0x0000628C00000000 AS DateTime), 1, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (641, N'Cesar', N'Nettleton', CAST(0x00005AA900000000 AS DateTime), 1, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (642, N'Casandra', N'Coy', CAST(0x0000743100000000 AS DateTime), 2, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (643, N'Russell', N'Galang', CAST(0x0000567500000000 AS DateTime), 2, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (644, N'Cesar', N'Dey', CAST(0x000052EB00000000 AS DateTime), 2, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (645, N'Leonard', N'Galang', CAST(0x000029EB00000000 AS DateTime), 2, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (646, N'Casandra', N'Nettleton', CAST(0x0000758F00000000 AS DateTime), 2, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (647, N'Dina', N'Hardisty', CAST(0x00008C0F00000000 AS DateTime), 2, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (648, N'Ali', N'Nettleton', CAST(0x00005F7200000000 AS DateTime), 2, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (649, N'Casandra', N'Coy', CAST(0x0000743100000000 AS DateTime), 3, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (650, N'Russell', N'Galang', CAST(0x0000567500000000 AS DateTime), 3, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (651, N'Cesar', N'Dey', CAST(0x000052EB00000000 AS DateTime), 3, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (652, N'Leonard', N'Galang', CAST(0x000029EB00000000 AS DateTime), 3, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (653, N'Casandra', N'Nettleton', CAST(0x0000758F00000000 AS DateTime), 3, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (654, N'Dina', N'Hardisty', CAST(0x00008C0F00000000 AS DateTime), 3, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (655, N'Ali', N'Nettleton', CAST(0x00005F7200000000 AS DateTime), 3, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (656, N'Tonia', N'Filiault', CAST(0x000002AC00000000 AS DateTime), 4, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (657, N'Russell', N'Hardisty', CAST(0x00005AB900000000 AS DateTime), 4, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (658, N'Chad', N'Eisert', CAST(0x0000536800000000 AS DateTime), 4, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (659, N'Selena', N'Coy', CAST(0x00001F1F00000000 AS DateTime), 4, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (660, N'Russell', N'Galang', CAST(0x00004B6F00000000 AS DateTime), 4, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (661, N'Selena', N'Goley', CAST(0x0000813700000000 AS DateTime), 4, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (662, N'Liberty', N'Eisert', CAST(0x00000EC900000000 AS DateTime), 4, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (663, N'Tonia', N'Filiault', CAST(0x000002AC00000000 AS DateTime), 5, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (664, N'Russell', N'Hardisty', CAST(0x00005AB900000000 AS DateTime), 5, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (665, N'Chad', N'Eisert', CAST(0x0000536800000000 AS DateTime), 5, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (666, N'Selena', N'Coy', CAST(0x00001F1F00000000 AS DateTime), 5, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (667, N'Russell', N'Galang', CAST(0x00004B6F00000000 AS DateTime), 5, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (668, N'Selena', N'Goley', CAST(0x0000813700000000 AS DateTime), 5, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (669, N'Liberty', N'Eisert', CAST(0x00000EC900000000 AS DateTime), 5, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (670, N'Tonia', N'Filiault', CAST(0x000002AC00000000 AS DateTime), 6, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (671, N'Russell', N'Hardisty', CAST(0x00005AB900000000 AS DateTime), 6, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (672, N'Chad', N'Eisert', CAST(0x0000536800000000 AS DateTime), 6, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (673, N'Selena', N'Coy', CAST(0x00001F1F00000000 AS DateTime), 6, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (674, N'Russell', N'Galang', CAST(0x00004B6F00000000 AS DateTime), 6, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (675, N'Selena', N'Goley', CAST(0x0000813700000000 AS DateTime), 6, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (676, N'Liberty', N'Eisert', CAST(0x00000EC900000000 AS DateTime), 6, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (677, N'Tonia', N'Filiault', CAST(0x000002AC00000000 AS DateTime), 7, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (678, N'Russell', N'Hardisty', CAST(0x00005AB900000000 AS DateTime), 7, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (679, N'Chad', N'Eisert', CAST(0x0000536800000000 AS DateTime), 7, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (680, N'Selena', N'Coy', CAST(0x00001F1F00000000 AS DateTime), 7, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (681, N'Russell', N'Galang', CAST(0x00004B6F00000000 AS DateTime), 7, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (682, N'Selena', N'Goley', CAST(0x0000813700000000 AS DateTime), 7, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (683, N'Liberty', N'Eisert', CAST(0x00000EC900000000 AS DateTime), 7, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (684, N'Tonia', N'Filiault', CAST(0x000002AC00000000 AS DateTime), 8, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (685, N'Russell', N'Hardisty', CAST(0x00005AB900000000 AS DateTime), 8, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (686, N'Chad', N'Eisert', CAST(0x0000536800000000 AS DateTime), 8, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (687, N'Selena', N'Coy', CAST(0x00001F1F00000000 AS DateTime), 8, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (688, N'Russell', N'Galang', CAST(0x00004B6F00000000 AS DateTime), 8, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (689, N'Selena', N'Goley', CAST(0x0000813700000000 AS DateTime), 8, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (690, N'Liberty', N'Eisert', CAST(0x00000EC900000000 AS DateTime), 8, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (691, N'Tonia', N'Filiault', CAST(0x000002AC00000000 AS DateTime), 9, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (692, N'Russell', N'Hardisty', CAST(0x00005AB900000000 AS DateTime), 9, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (693, N'Chad', N'Eisert', CAST(0x0000536800000000 AS DateTime), 9, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (694, N'Selena', N'Coy', CAST(0x00001F1F00000000 AS DateTime), 9, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (695, N'Russell', N'Galang', CAST(0x00004B6F00000000 AS DateTime), 9, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (696, N'Selena', N'Goley', CAST(0x0000813700000000 AS DateTime), 9, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (697, N'Liberty', N'Eisert', CAST(0x00000EC900000000 AS DateTime), 9, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (698, N'Tonia', N'Filiault', CAST(0x000002AC00000000 AS DateTime), 10, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (699, N'Russell', N'Hardisty', CAST(0x00005AB900000000 AS DateTime), 10, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (700, N'Chad', N'Eisert', CAST(0x0000536800000000 AS DateTime), 10, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (701, N'Selena', N'Coy', CAST(0x00001F1F00000000 AS DateTime), 10, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (702, N'Russell', N'Galang', CAST(0x00004B6F00000000 AS DateTime), 10, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (703, N'Selena', N'Goley', CAST(0x0000813700000000 AS DateTime), 10, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (704, N'Liberty', N'Eisert', CAST(0x00000EC900000000 AS DateTime), 10, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (705, N'Dina', N'Baltes', CAST(0x0000461100000000 AS DateTime), 11, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (706, N'Liberty', N'Baltes', CAST(0x0000177D00000000 AS DateTime), 11, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (707, N'Chad', N'Galang', CAST(0x00007DEC00000000 AS DateTime), 11, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (708, N'Jimmie', N'Galang', CAST(0x0000491100000000 AS DateTime), 11, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (709, N'Russell', N'Coy', CAST(0x000008E400000000 AS DateTime), 11, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (710, N'Russell', N'Dey', CAST(0x00001D7D00000000 AS DateTime), 11, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (711, N'Agueda', N'Roysden', CAST(0x0000139200000000 AS DateTime), 11, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (712, N'Dina', N'Baltes', CAST(0x0000461100000000 AS DateTime), 12, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (713, N'Liberty', N'Baltes', CAST(0x0000177D00000000 AS DateTime), 12, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (714, N'Chad', N'Galang', CAST(0x00007DEC00000000 AS DateTime), 12, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (715, N'Jimmie', N'Galang', CAST(0x0000491100000000 AS DateTime), 12, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (716, N'Russell', N'Coy', CAST(0x000008E400000000 AS DateTime), 12, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (717, N'Russell', N'Dey', CAST(0x00001D7D00000000 AS DateTime), 12, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (718, N'Agueda', N'Roysden', CAST(0x0000139200000000 AS DateTime), 12, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (719, N'Dina', N'Baltes', CAST(0x0000461100000000 AS DateTime), 13, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (720, N'Liberty', N'Baltes', CAST(0x0000177D00000000 AS DateTime), 13, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (721, N'Chad', N'Galang', CAST(0x00007DEC00000000 AS DateTime), 13, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (722, N'Jimmie', N'Galang', CAST(0x0000491100000000 AS DateTime), 13, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (723, N'Russell', N'Coy', CAST(0x000008E400000000 AS DateTime), 13, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (724, N'Russell', N'Dey', CAST(0x00001D7D00000000 AS DateTime), 13, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (725, N'Agueda', N'Roysden', CAST(0x0000139200000000 AS DateTime), 13, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (726, N'Dina', N'Baltes', CAST(0x0000461100000000 AS DateTime), 14, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (727, N'Liberty', N'Baltes', CAST(0x0000177D00000000 AS DateTime), 14, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (728, N'Chad', N'Galang', CAST(0x00007DEC00000000 AS DateTime), 14, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (729, N'Jimmie', N'Galang', CAST(0x0000491100000000 AS DateTime), 14, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (730, N'Russell', N'Coy', CAST(0x000008E400000000 AS DateTime), 14, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (731, N'Russell', N'Dey', CAST(0x00001D7D00000000 AS DateTime), 14, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (732, N'Agueda', N'Roysden', CAST(0x0000139200000000 AS DateTime), 14, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (733, N'Dina', N'Baltes', CAST(0x0000461100000000 AS DateTime), 15, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (734, N'Liberty', N'Baltes', CAST(0x0000177D00000000 AS DateTime), 15, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (735, N'Chad', N'Galang', CAST(0x00007DEC00000000 AS DateTime), 15, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (736, N'Jimmie', N'Galang', CAST(0x0000491100000000 AS DateTime), 15, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (737, N'Russell', N'Coy', CAST(0x000008E400000000 AS DateTime), 15, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (738, N'Russell', N'Dey', CAST(0x00001D7D00000000 AS DateTime), 15, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (739, N'Agueda', N'Roysden', CAST(0x0000139200000000 AS DateTime), 15, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (740, N'Dina', N'Baltes', CAST(0x0000461100000000 AS DateTime), 16, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (741, N'Liberty', N'Baltes', CAST(0x0000177D00000000 AS DateTime), 16, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (742, N'Chad', N'Galang', CAST(0x00007DEC00000000 AS DateTime), 16, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (743, N'Jimmie', N'Galang', CAST(0x0000491100000000 AS DateTime), 16, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (744, N'Russell', N'Coy', CAST(0x000008E400000000 AS DateTime), 16, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (745, N'Russell', N'Dey', CAST(0x00001D7D00000000 AS DateTime), 16, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (746, N'Agueda', N'Roysden', CAST(0x0000139200000000 AS DateTime), 16, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (747, N'Leonard', N'Lobel', CAST(0x0000603D00000000 AS DateTime), 17, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (748, N'Dina', N'Nettleton', CAST(0x00001BC100000000 AS DateTime), 17, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (749, N'Tonia', N'Lobel', CAST(0x00007E4C00000000 AS DateTime), 17, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (750, N'Cesar', N'Coy', CAST(0x00003E4500000000 AS DateTime), 17, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (751, N'Liberty', N'Cantor', CAST(0x00006D7100000000 AS DateTime), 17, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (752, N'Tonia', N'Tanksley', CAST(0x0000100500000000 AS DateTime), 17, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (753, N'Lorina', N'Filiault', CAST(0x0000500C00000000 AS DateTime), 17, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (754, N'Leonard', N'Lobel', CAST(0x0000603D00000000 AS DateTime), 18, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (755, N'Dina', N'Nettleton', CAST(0x00001BC100000000 AS DateTime), 18, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (756, N'Tonia', N'Lobel', CAST(0x00007E4C00000000 AS DateTime), 18, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (757, N'Cesar', N'Coy', CAST(0x00003E4500000000 AS DateTime), 18, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (758, N'Liberty', N'Cantor', CAST(0x00006D7100000000 AS DateTime), 18, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (759, N'Tonia', N'Tanksley', CAST(0x0000100500000000 AS DateTime), 18, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (760, N'Lorina', N'Filiault', CAST(0x0000500C00000000 AS DateTime), 18, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (761, N'Leonard', N'Lobel', CAST(0x0000603D00000000 AS DateTime), 19, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (762, N'Dina', N'Nettleton', CAST(0x00001BC100000000 AS DateTime), 19, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (763, N'Tonia', N'Lobel', CAST(0x00007E4C00000000 AS DateTime), 19, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (764, N'Cesar', N'Coy', CAST(0x00003E4500000000 AS DateTime), 19, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (765, N'Liberty', N'Cantor', CAST(0x00006D7100000000 AS DateTime), 19, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (766, N'Tonia', N'Tanksley', CAST(0x0000100500000000 AS DateTime), 19, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (767, N'Lorina', N'Filiault', CAST(0x0000500C00000000 AS DateTime), 19, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (768, N'Leonard', N'Lobel', CAST(0x0000603D00000000 AS DateTime), 20, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (769, N'Dina', N'Nettleton', CAST(0x00001BC100000000 AS DateTime), 20, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (770, N'Tonia', N'Lobel', CAST(0x00007E4C00000000 AS DateTime), 20, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (771, N'Cesar', N'Coy', CAST(0x00003E4500000000 AS DateTime), 20, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (772, N'Liberty', N'Cantor', CAST(0x00006D7100000000 AS DateTime), 20, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (773, N'Tonia', N'Tanksley', CAST(0x0000100500000000 AS DateTime), 20, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (774, N'Lorina', N'Filiault', CAST(0x0000500C00000000 AS DateTime), 20, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (775, N'Leonard', N'Lobel', CAST(0x0000603D00000000 AS DateTime), 21, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (776, N'Dina', N'Nettleton', CAST(0x00001BC100000000 AS DateTime), 21, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (777, N'Tonia', N'Lobel', CAST(0x00007E4C00000000 AS DateTime), 21, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (778, N'Cesar', N'Coy', CAST(0x00003E4500000000 AS DateTime), 21, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (779, N'Liberty', N'Cantor', CAST(0x00006D7100000000 AS DateTime), 21, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (780, N'Tonia', N'Tanksley', CAST(0x0000100500000000 AS DateTime), 21, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (781, N'Lorina', N'Filiault', CAST(0x0000500C00000000 AS DateTime), 21, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (782, N'Leonard', N'Lobel', CAST(0x0000603D00000000 AS DateTime), 22, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (783, N'Dina', N'Nettleton', CAST(0x00001BC100000000 AS DateTime), 22, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (784, N'Tonia', N'Lobel', CAST(0x00007E4C00000000 AS DateTime), 22, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (785, N'Cesar', N'Coy', CAST(0x00003E4500000000 AS DateTime), 22, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (786, N'Liberty', N'Cantor', CAST(0x00006D7100000000 AS DateTime), 22, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (787, N'Tonia', N'Tanksley', CAST(0x0000100500000000 AS DateTime), 22, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (788, N'Lorina', N'Filiault', CAST(0x0000500C00000000 AS DateTime), 22, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (789, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 23, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (790, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 23, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (791, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 23, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (792, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 23, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (793, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 23, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (794, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 23, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (795, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 23, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (796, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 24, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (797, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 24, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (798, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 24, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (799, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 24, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (800, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 24, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (801, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 24, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (802, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 24, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (803, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 25, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (804, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 25, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (805, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 25, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (806, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 25, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (807, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 25, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (808, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 25, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (809, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 25, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (810, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 26, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (811, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 26, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (812, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 26, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (813, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 26, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (814, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 26, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (815, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 26, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (816, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 26, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (817, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 27, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (818, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 27, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (819, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 27, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (820, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 27, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (821, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 27, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (822, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 27, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (823, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 27, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (824, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 28, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (825, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 28, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (826, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 28, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (827, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 28, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (828, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 28, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (829, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 28, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (830, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 28, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (831, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 29, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (832, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 29, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (833, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 29, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (834, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 29, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (835, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 29, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (836, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 29, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (837, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 29, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (838, N'Janean', N'Roysden', CAST(0x00007A8B00000000 AS DateTime), 30, 1, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (839, N'Dina', N'Roysden', CAST(0x00001E9900000000 AS DateTime), 30, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (840, N'Dina', N'Galang', CAST(0x00007ECC00000000 AS DateTime), 30, 2, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (841, N'Cesar', N'Lobel', CAST(0x0000321100000000 AS DateTime), 30, 3, 1)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (842, N'Tonia', N'Tanksley', CAST(0x0000438900000000 AS DateTime), 30, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (843, N'Lorina', N'Eisert', CAST(0x0000051200000000 AS DateTime), 30, 4, 0)
GO

INSERT [dbo].[Joueurs] ([ID], [Prenom], [Nom], [DateNaissance], [EquipeID], [PosteID], [Captaine]) VALUES (844, N'Chad', N'Cantor', CAST(0x000000CD00000000 AS DateTime), 30, 4, 0)
GO

SET IDENTITY_INSERT [dbo].[Joueurs] OFF
GO

SET IDENTITY_INSERT [dbo].[Matchs] ON
GO

INSERT [dbo].[Matchs] ([ID], [CoupeID], [StadeID], [MatchTypeID], [DomicileID], [VisiteurID], [ScoreDomicile], [ScoreVisiteur], [Date]) VALUES (1, 1, 1, 1, 1, 8, 100, 80, CAST(0x0000A28700000000 AS DateTime))
GO

INSERT [dbo].[Matchs] ([ID], [CoupeID], [StadeID], [MatchTypeID], [DomicileID], [VisiteurID], [ScoreDomicile], [ScoreVisiteur], [Date]) VALUES (2, 1, 2, 1, 2, 7, 30, 270, CAST(0x0000A28700000000 AS DateTime))
GO

INSERT [dbo].[Matchs] ([ID], [CoupeID], [StadeID], [MatchTypeID], [DomicileID], [VisiteurID], [ScoreDomicile], [ScoreVisiteur], [Date]) VALUES (3, 1, 3, 1, 3, 6, 0, 300, CAST(0x0000A28700000000 AS DateTime))
GO

INSERT [dbo].[Matchs] ([ID], [CoupeID], [StadeID], [MatchTypeID], [DomicileID], [VisiteurID], [ScoreDomicile], [ScoreVisiteur], [Date]) VALUES (4, 1, 4, 1, 4, 5, 90, 210, CAST(0x0000A28700000000 AS DateTime))
GO

INSERT [dbo].[Matchs] ([ID], [CoupeID], [StadeID], [MatchTypeID], [DomicileID], [VisiteurID], [ScoreDomicile], [ScoreVisiteur], [Date]) VALUES (5, 1, 5, 2, 6, 1, 20, 160, CAST(0x0000A28800000000 AS DateTime))
GO

INSERT [dbo].[Matchs] ([ID], [CoupeID], [StadeID], [MatchTypeID], [DomicileID], [VisiteurID], [ScoreDomicile], [ScoreVisiteur], [Date]) VALUES (6, 1, 6, 2, 7, 5, 40, 220, CAST(0x0000A28800000000 AS DateTime))
GO

INSERT [dbo].[Matchs] ([ID], [CoupeID], [StadeID], [MatchTypeID], [DomicileID], [VisiteurID], [ScoreDomicile], [ScoreVisiteur], [Date]) VALUES (7, 1, 7, 3, 5, 1, 150, 160, CAST(0x0000A28900000000 AS DateTime))
GO

SET IDENTITY_INSERT [dbo].[Matchs] OFF
GO

SET IDENTITY_INSERT [dbo].[MatchTypes] ON
GO

INSERT [dbo].[MatchTypes] ([ID], [Description]) VALUES (1, N'Quart')
GO

INSERT [dbo].[MatchTypes] ([ID], [Description]) VALUES (2, N'Demi')
GO

INSERT [dbo].[MatchTypes] ([ID], [Description]) VALUES (3, N'Finale')
GO

SET IDENTITY_INSERT [dbo].[MatchTypes] OFF
GO

SET IDENTITY_INSERT [dbo].[Postes] ON
GO

INSERT [dbo].[Postes] ([ID], [Description]) VALUES (1, N'Attrapeur')
GO

INSERT [dbo].[Postes] ([ID], [Description]) VALUES (2, N'Batteur
')
GO

INSERT [dbo].[Postes] ([ID], [Description]) VALUES (3, N'Gardien
')
GO

INSERT [dbo].[Postes] ([ID], [Description]) VALUES (4, N'
Poursuiveur
')
GO

SET IDENTITY_INSERT [dbo].[Postes] OFF
GO

SET IDENTITY_INSERT [dbo].[Reservations] ON
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (1, 1, 1, 3, N'1234')
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (2, 2, 2, 1, N'5678')
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (3, 3, 4, 8, N'1468')
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (4, 1, 5, 4, N'1987')
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (5, 3, 6, 8, N'9567')
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (6, 1, 7, 3, N'7890')
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (7, 2, 7, 2, N'6789')
GO

INSERT [dbo].[Reservations] ([ID], [SpectateurID], [MatcheID], [NombrePlacesReservees], [CodeAnnulation]) VALUES (8, 3, 7, 7, N'5674')
GO

SET IDENTITY_INSERT [dbo].[Reservations] OFF
GO

SET IDENTITY_INSERT [dbo].[Spectateurs] ON
GO

INSERT [dbo].[Spectateurs] ([ID], [Prenom], [Nom], [DateNaissance], [Adresse], [EMail]) VALUES (1, N'Harry', N'Potter', CAST(0x000072F700000000 AS DateTime), N'The Cupboard under the Stairs 4 Privet Drive', N'harry.potter@hogwarts.com')
GO

INSERT [dbo].[Spectateurs] ([ID], [Prenom], [Nom], [DateNaissance], [Adresse], [EMail]) VALUES (2, N'Hermione', N'Granger', CAST(0x000071BB00000000 AS DateTime), N'Chez les moldus', N'hermione.granger@hogwarts.com')
GO

INSERT [dbo].[Spectateurs] ([ID], [Prenom], [Nom], [DateNaissance], [Adresse], [EMail]) VALUES (3, N'Ronald', N'Weasley', CAST(0x0000725F00000000 AS DateTime), N'Le Terrier', N'ronald.weasley@hogwarts.com')
GO

SET IDENTITY_INSERT [dbo].[Spectateurs] OFF
GO

SET IDENTITY_INSERT [dbo].[Stades] ON
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (1, N'Twickenham', N'Twickenham, place du Stade', 82000, 19)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (2, N'Wembley', N'Wembley, place du Stade', 90000, 18)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (3, N'Stade olympique', N'Stade olympique, place du Stade', 80000, 17)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (4, N'Millennium Stadium', N'Millennium Stadium, place du Stade', 74500, 16)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (5, N'City of Manchester Stadium', N'City of Manchester Stadium, place du Stade', 47726, 15)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (6, N'St James'' Park', N'St James'' Park, place du Stade', 52387, 14)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (7, N'Elland Road', N'Elland Road, place du Stade', 39460, 13)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (8, N'King Power Stadium', N'King Power Stadium, place du Stade', 32262, 12)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (9, N'Villa Park', N'Villa Park, place du Stade', 42788, 11)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (10, N'Kingsholm Stadium', N'Kingsholm Stadium, place du Stade', 16500, 10)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (11, N'Stadium mk', N'Stadium mk, place du Stade', 32000, 9)
GO

INSERT [dbo].[Stades] ([ID], [Nom], [Adresse], [NombrePlacesDisponibles], [PourcentageCommision]) VALUES (12, N'Falmer Stadium', N'Falmer Stadium, place du Stade', 30750, 8)
GO

SET IDENTITY_INSERT [dbo].[Stades] OFF
GO

USE [master]
GO

ALTER DATABASE [QuidditchWorldCup] SET  READ_WRITE
GO
