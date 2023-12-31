USE [master]
GO
/****** Object:  Database [LibraryMVB]    Script Date: 11/29/2023 10:00:00 PM ******/
CREATE DATABASE [LibraryMVB]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'LibraryMVB', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\LibraryMVB.mdf' , SIZE = 3072KB , MAXSIZE = UNLIMITED, FILEGROWTH = 1024KB )
 LOG ON 
( NAME = N'LibraryMVB_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL12.MSSQLSERVER\MSSQL\DATA\LibraryMVB_log.ldf' , SIZE = 1024KB , MAXSIZE = 2048GB , FILEGROWTH = 10%)
GO
ALTER DATABASE [LibraryMVB] SET COMPATIBILITY_LEVEL = 120
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [LibraryMVB].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [LibraryMVB] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [LibraryMVB] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [LibraryMVB] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [LibraryMVB] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [LibraryMVB] SET ARITHABORT OFF 
GO
ALTER DATABASE [LibraryMVB] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [LibraryMVB] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [LibraryMVB] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [LibraryMVB] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [LibraryMVB] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [LibraryMVB] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [LibraryMVB] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [LibraryMVB] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [LibraryMVB] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [LibraryMVB] SET  DISABLE_BROKER 
GO
ALTER DATABASE [LibraryMVB] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [LibraryMVB] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [LibraryMVB] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [LibraryMVB] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [LibraryMVB] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [LibraryMVB] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [LibraryMVB] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [LibraryMVB] SET RECOVERY SIMPLE 
GO
ALTER DATABASE [LibraryMVB] SET  MULTI_USER 
GO
ALTER DATABASE [LibraryMVB] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [LibraryMVB] SET DB_CHAINING OFF 
GO
ALTER DATABASE [LibraryMVB] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [LibraryMVB] SET TARGET_RECOVERY_TIME = 0 SECONDS 
GO
ALTER DATABASE [LibraryMVB] SET DELAYED_DURABILITY = DISABLED 
GO
USE [LibraryMVB]
GO
/****** Object:  Table [dbo].[Authors]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authors](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[Date] [nvarchar](250) NULL,
	[countryID] [int] NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Books_Borrow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Borrow](
	[Order_ID] [int] NOT NULL,
	[Book_ID] [int] NULL,
	[Borrow_ID] [int] NULL,
	[Start_Date] [nvarchar](50) NULL,
	[End_Date] [nvarchar](50) NULL,
	[Notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_Books_Borrow_1] PRIMARY KEY CLUSTERED 
(
	[Order_ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Books_Data]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Books_Data](
	[ID] [int] NOT NULL,
	[Book_Name] [nvarchar](250) NULL,
	[Cat_ID] [int] NULL,
	[Author_ID] [int] NULL,
	[country_ID] [int] NULL,
	[Dar_ID] [int] NULL,
	[supcat] [nvarchar](250) NULL,
	[Date] [nvarchar](250) NULL,
	[PagesNumber] [int] NULL,
	[Place_ID] [int] NULL,
	[Book_Status] [nvarchar](250) NULL,
	[Book_prices] [real] NULL,
	[Notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_Books_Data] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Borrowers]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Borrowers](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[phone] [nvarchar](250) NULL,
	[address] [nvarchar](250) NULL,
	[notes] [nvarchar](250) NULL,
 CONSTRAINT [PK_Borrowers] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[category]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[category](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_category] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[country]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[country](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_country] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Dar_elnashr]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Dar_elnashr](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
	[countryID] [int] NULL,
 CONSTRAINT [PK_Dar_elnashr] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[Places]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Places](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](250) NULL,
 CONSTRAINT [PK_Places] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Authors] FOREIGN KEY([Author_ID])
REFERENCES [dbo].[Authors] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Authors]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_category] FOREIGN KEY([Cat_ID])
REFERENCES [dbo].[category] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_category]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_country] FOREIGN KEY([country_ID])
REFERENCES [dbo].[country] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_country]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Dar_elnashr] FOREIGN KEY([Dar_ID])
REFERENCES [dbo].[Dar_elnashr] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Dar_elnashr]
GO
ALTER TABLE [dbo].[Books_Data]  WITH CHECK ADD  CONSTRAINT [FK_Books_Data_Places] FOREIGN KEY([Place_ID])
REFERENCES [dbo].[Places] ([ID])
ON UPDATE CASCADE
ON DELETE CASCADE
GO
ALTER TABLE [dbo].[Books_Data] CHECK CONSTRAINT [FK_Books_Data_Places]
GO
/****** Object:  StoredProcedure [dbo].[AuthorDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AuthorDelete] @id int
as

delete from  Authors  where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[AuthorDeleteall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AuthorDeleteall]
as

delete from  Authors

GO
/****** Object:  StoredProcedure [dbo].[Authorgetall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Authorgetall]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select Authors.Id as'رقم المؤلف', Authors.Name as'اسم المؤلف',Date as"التاريخ",country.Name as'اسم الدولة' from Authors ,country where country.ID=Authors.ID

GO
/****** Object:  StoredProcedure [dbo].[AuthorGetallcountryID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AuthorGetallcountryID]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select *  from Authors

GO
/****** Object:  StoredProcedure [dbo].[AuthorsgetlastRow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AuthorsgetlastRow]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select count(ID) from Authors

GO
/****** Object:  StoredProcedure [dbo].[AuthorsInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AuthorsInsert] @id int,@name nvarchar(250),@date nvarchar(250),@countryID int
as
insert into Authors values (@id ,@name,@date,@countryID)



GO
/****** Object:  StoredProcedure [dbo].[AuthorsMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AuthorsMaxID]
as

select max(ID) from Authors

GO
/****** Object:  StoredProcedure [dbo].[AuthorsUpdate]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[AuthorsUpdate] @id int,@name nvarchar(250),@date nvarchar(250),@countryID int
as
update Authors set Name=@name,Date=@date,countryID=@countryID where ID = @id



GO
/****** Object:  StoredProcedure [dbo].[BookBlaceMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookBlaceMaxID]
as

select max(ID) from Places

GO
/****** Object:  StoredProcedure [dbo].[BookdataDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookdataDelete] @id int
as

delete from  Books_Data  where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[BookdataDeleteAll]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookdataDeleteAll] 
as

delete from  Books_Data 

GO
/****** Object:  StoredProcedure [dbo].[BookDataGetallcountryID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookDataGetallcountryID]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select *  from Books_Data

GO
/****** Object:  StoredProcedure [dbo].[BookDatagetlastRow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookDatagetlastRow]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select count(ID) from Books_Data

GO
/****** Object:  StoredProcedure [dbo].[BookdataInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookdataInsert] @id int,@Book_name nvarchar(250),@Cat_id int,@Author_ID int,@countryID int
,@dar_id int,@supcat nvarchar(250),@date nvarchar(250),@PagesNumber int
,@Place_ID int,@Book_Status nvarchar(250),@Book_prices real,@Notes nvarchar(250) 
as
insert into Books_Data values (@id ,@Book_name,@Cat_id,@Author_ID,@countryID,@dar_id,@supcat,@date,@PagesNumber
,@Place_ID,@Book_Status,@Book_prices,@Notes)



GO
/****** Object:  StoredProcedure [dbo].[BookdataUpdata]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookdataUpdata] @id int,@Book_name nvarchar(250),@Cat_id int,@Author_ID int,@countryID int
,@dar_id int,@supcat nvarchar(250),@date nvarchar(250),@PagesNumber int
,@Place_ID int,@Book_Status nvarchar(250),@Book_prices real,@Notes nvarchar(250) 
as
update Books_Data set ID= @id ,Book_Name= @Book_name,Cat_ID= @Cat_id,Author_ID=@Author_ID,country_ID=@countryID,Dar_ID=@dar_id
,supcat=@supcat,Date=@date,PagesNumber=@PagesNumber
,Place_ID=@Place_ID,Book_Status=@Book_Status,Book_prices=@Book_prices,Notes=@Notes  where ID=@id



GO
/****** Object:  StoredProcedure [dbo].[BookPlaceDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookPlaceDelete] @id int
as

delete from Places where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[BookPlaceDeleteAll]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookPlaceDeleteAll]
as

delete from Places

GO
/****** Object:  StoredProcedure [dbo].[BookPlacegetall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BookPlacegetall]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select Id as'رقم المكان', Name as'اسم المكان'from Places

GO
/****** Object:  StoredProcedure [dbo].[bookplacegetlastRow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[bookplacegetlastRow]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select count(ID) from Places

GO
/****** Object:  StoredProcedure [dbo].[BookPlaceInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookPlaceInsert] @id int,@name nvarchar(250)
as
insert into Places values (@id ,@name)


GO
/****** Object:  StoredProcedure [dbo].[BookPlaceUpdate]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BookPlaceUpdate] @id int,@name nvarchar(250)
as

update Places set Name=@name where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[Booksborrowgetall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[Booksborrowgetall]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select ID as'رقم المستعير', Borrowers.Name as'اسم المستعير'from Borrowers

GO
/****** Object:  StoredProcedure [dbo].[BooksDatagetall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BooksDatagetall]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select * from Books_Data

GO
/****** Object:  StoredProcedure [dbo].[BooksGetAll]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BooksGetAll]
as

SELECT Books_Data.ID as 'رقم الكتاب'
      ,[Book_Name]as'اسم الكتاب'
      ,category.Name as'التصنيف'
      ,Authors.Name as'المؤلف'
      ,country.Name as'دولة النشر'
      ,Dar_elnashr.Name as'دار النشر'
      ,[supcat]as'التصنيف الفرعي'
      ,Books_Data.Date as'تاريخ النشر'
      ,[PagesNumber]as'عدد صفحات الكتاب'
      ,Places.Name as'مكان الكتاب'
      ,[Book_Status]as'حالة الكتاب'
      ,[Book_prices]as'سعر الكتاب'
      ,[Notes]as'ملاحظات'
  FROM [dbo].[Books_Data],category,Authors,country,Dar_elnashr,Places where Books_Data.Cat_ID=category.ID 
  and Authors.ID=Books_Data.Author_ID
   and country.ID=Books_Data.country_ID and Dar_elnashr.ID=Books_Data.Dar_ID
   and Places.ID=Books_Data.Place_ID

GO
/****** Object:  StoredProcedure [dbo].[BooksGetAllByCat]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BooksGetAllByCat] @catid int
as

SELECT Books_Data.ID as 'رقم الكتاب'
      ,[Book_Name]as'اسم الكتاب'
      ,category.Name as'التصنيف'
      ,Authors.Name as'المؤلف'
      ,country.Name as'دولة النشر'
      ,Dar_elnashr.Name as'دار النشر'
      ,[supcat]as'التصنيف الفرعي'
      ,Books_Data.Date as'تاريخ النشر'
      ,[PagesNumber]as'عدد صفحات الكتاب'
      ,Places.Name as'مكان الكتاب'
      ,[Book_Status]as'حالة الكتاب'
      ,[Book_prices]as'سعر الكتاب'
      ,[Notes]as'ملاحظات'
  FROM [dbo].[Books_Data],category,Authors,country,Dar_elnashr,Places where Books_Data.Cat_ID=category.ID 
  and Authors.ID=Books_Data.Author_ID
   and country.ID=Books_Data.country_ID and Dar_elnashr.ID=Books_Data.Dar_ID
   and Places.ID=Books_Data.Place_ID and [Books_Data].Cat_ID =@catid

GO
/****** Object:  StoredProcedure [dbo].[BooksGetAllByid]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BooksGetAllByid] @id int
as

SELECT Books_Data.ID as 'رقم الكتاب'
      ,[Book_Name]as'اسم الكتاب'
      ,category.Name as'التصنيف'
      ,Authors.Name as'المؤلف'
      ,country.Name as'دولة النشر'
      ,Dar_elnashr.Name as'دار النشر'
      ,[supcat]as'التصنيف الفرعي'
      ,Books_Data.Date as'تاريخ النشر'
      ,[PagesNumber]as'عدد صفحات الكتاب'
      ,Places.Name as'مكان الكتاب'
      ,[Book_Status]as'حالة الكتاب'
      ,[Book_prices]as'سعر الكتاب'
      ,[Notes]as'ملاحظات'
  FROM [dbo].[Books_Data],category,Authors,country,Dar_elnashr,Places where Books_Data.Cat_ID=category.ID 
  and Authors.ID=Books_Data.Author_ID
   and country.ID=Books_Data.country_ID and Dar_elnashr.ID=Books_Data.Dar_ID
   and Places.ID=Books_Data.Place_ID and Books_Data.ID=@id

GO
/****** Object:  StoredProcedure [dbo].[BooksMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BooksMaxID]
as

select max(ID) from Books_Data

GO
/****** Object:  StoredProcedure [dbo].[BorrowDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowDelete] @id int
as

delete from  Books_Borrow  where Order_ID=@id

GO
/****** Object:  StoredProcedure [dbo].[BorrowDeleteall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BorrowDeleteall]
as

delete  from  Books_Borrow   

GO
/****** Object:  StoredProcedure [dbo].[borrowerDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[borrowerDelete] @id int
as

delete from  Borrowers  where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[borrowerDeleteall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[borrowerDeleteall]
as

delete from  Borrowers

GO
/****** Object:  StoredProcedure [dbo].[BorrowerInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowerInsert] @id int,@name nvarchar(250),@phone nvarchar(250),@address nvarchar(250),@note nvarchar(250)
as
insert into Borrowers values (@id ,@name,@phone,@address,@note)


GO
/****** Object:  StoredProcedure [dbo].[BorrowersGetallcountryID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowersGetallcountryID]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select *  from Borrowers

GO
/****** Object:  StoredProcedure [dbo].[BorrowersgetlastRow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowersgetlastRow]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select count(ID) from Borrowers

GO
/****** Object:  StoredProcedure [dbo].[BorrowersMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowersMaxID]
as

select max(ID) from Borrowers

GO
/****** Object:  StoredProcedure [dbo].[BorrowerUpdate]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowerUpdate] @id int,@name nvarchar(250),@phone nvarchar(250),@address nvarchar(250),@note nvarchar(250)
as
update  Borrowers set Name=@name,phone=@phone,address=@address,notes=@note where ID=@id


GO
/****** Object:  StoredProcedure [dbo].[BorrowGetallcountryID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowGetallcountryID]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select *  from Books_Borrow

GO
/****** Object:  StoredProcedure [dbo].[BorrowgetMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[BorrowgetMaxID]
as

select max(Order_ID) from Books_Borrow

GO
/****** Object:  StoredProcedure [dbo].[BorrowInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[BorrowInsert] @id int,@Book_ID int,@Borrow_ID int,@Start_Date nvarchar(250),@End_Date nvarchar(250),@note nvarchar(250) 
as
insert into Books_Borrow values (@id ,@Book_ID,@Borrow_ID,@Start_Date,@End_Date,@note)



GO
/****** Object:  StoredProcedure [dbo].[Borrowupdate]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[Borrowupdate]@id int,@Book_ID int,@Borrow_ID int,@Start_Date nvarchar(250),@End_Date nvarchar(250),@note nvarchar(250) 
as
 update Books_Borrow set Book_ID=@Book_ID,Borrow_ID=@Borrow_ID,Start_Date=@Start_Date,End_Date=@End_Date,Notes=@note where Order_ID=@id



GO
/****** Object:  StoredProcedure [dbo].[categoryDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryDelete] @id int
as

delete from  category  where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[categoryDeleteAll]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryDeleteAll]
as

delete from  category

GO
/****** Object:  StoredProcedure [dbo].[categorygetall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categorygetall]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select Id as'رقم التصنيف', Name as'اسم التصنيف'from category

GO
/****** Object:  StoredProcedure [dbo].[categorygetlastRow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categorygetlastRow]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select count(ID) from category

GO
/****** Object:  StoredProcedure [dbo].[categoryInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[categoryInsert] @id int,@name nvarchar(250)
as
insert into category values (@id ,@name)


GO
/****** Object:  StoredProcedure [dbo].[categoryMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryMaxID]
as

select max(ID) from category

GO
/****** Object:  StoredProcedure [dbo].[categoryUpdate]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[categoryUpdate] @id int,@name nvarchar(250)
as

update category set Name=@name where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[countryDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countryDelete] @id int
as

delete from  country  where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[countryDeleteAll]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countryDeleteAll]
as

delete from  country

GO
/****** Object:  StoredProcedure [dbo].[countrygetall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countrygetall]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select Id as'رقم الدولة', Name as'اسم الدولة'from country

GO
/****** Object:  StoredProcedure [dbo].[countrygetlastRow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countrygetlastRow]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select count(ID) from country

GO
/****** Object:  StoredProcedure [dbo].[countryInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countryInsert] @id int,@name nvarchar(250)
as
insert into country values (@id ,@name)


GO
/****** Object:  StoredProcedure [dbo].[countryMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countryMaxID]
as

select max(ID) from country

GO
/****** Object:  StoredProcedure [dbo].[countryUpdate]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[countryUpdate] @id int,@name nvarchar(250)
as

update country set Name=@name where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[DarNashrDelete]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[DarNashrDelete] @id int
as

delete from  Dar_elnashr  where ID=@id

GO
/****** Object:  StoredProcedure [dbo].[DarNashrDeleteall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[DarNashrDeleteall]
as

delete from  Dar_elnashr

GO
/****** Object:  StoredProcedure [dbo].[darnashrgetall]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[darnashrgetall]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select Dar_elnashr.ID as'رقم الدار', Dar_elnashr.Name as'اسم الدار',country.Name as'اسم الدولة' from Dar_elnashr ,country where country.ID=Dar_elnashr.ID

GO
/****** Object:  StoredProcedure [dbo].[darnashrgetallID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[darnashrgetallID]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select * from Dar_elnashr
GO
/****** Object:  StoredProcedure [dbo].[DarNashrgetlastRow]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[DarNashrgetlastRow]
as
/******لعرض البيانات في الداتا جيرد فيو******/
select count(ID) from Dar_elnashr

GO
/****** Object:  StoredProcedure [dbo].[DarNashrInsert]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[DarNashrInsert] @id int,@name nvarchar(250),@countryID int
as
insert into Dar_elnashr values (@id ,@name,@countryID)



GO
/****** Object:  StoredProcedure [dbo].[DarNashrMaxID]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[DarNashrMaxID]
as

select max(ID) from Dar_elnashr

GO
/****** Object:  StoredProcedure [dbo].[DarNashrUpdate]    Script Date: 11/29/2023 10:00:00 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


create PROCEDURE [dbo].[DarNashrUpdate] @id int,@name nvarchar(250),@countryID int
as
update Dar_elnashr set Name=@name,countryID=@countryID where ID = @id



GO
USE [master]
GO
ALTER DATABASE [LibraryMVB] SET  READ_WRITE 
GO
