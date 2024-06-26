USE [master]
GO
/****** Object:  Database [libraryManagementSystem]    Script Date: 5/4/2024 4:16:15 PM ******/
CREATE DATABASE [libraryManagementSystem]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'libraryManagementSystem', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\libraryManagementSystem.mdf' , SIZE = 73728KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'libraryManagementSystem_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL16.MSSQLSERVER\MSSQL\DATA\libraryManagementSystem_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT, LEDGER = OFF
GO
ALTER DATABASE [libraryManagementSystem] SET COMPATIBILITY_LEVEL = 160
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [libraryManagementSystem].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [libraryManagementSystem] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET ARITHABORT OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [libraryManagementSystem] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [libraryManagementSystem] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET  DISABLE_BROKER 
GO
ALTER DATABASE [libraryManagementSystem] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [libraryManagementSystem] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET RECOVERY FULL 
GO
ALTER DATABASE [libraryManagementSystem] SET  MULTI_USER 
GO
ALTER DATABASE [libraryManagementSystem] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [libraryManagementSystem] SET DB_CHAINING OFF 
GO
ALTER DATABASE [libraryManagementSystem] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [libraryManagementSystem] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [libraryManagementSystem] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [libraryManagementSystem] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'libraryManagementSystem', N'ON'
GO
ALTER DATABASE [libraryManagementSystem] SET QUERY_STORE = ON
GO
ALTER DATABASE [libraryManagementSystem] SET QUERY_STORE (OPERATION_MODE = READ_WRITE, CLEANUP_POLICY = (STALE_QUERY_THRESHOLD_DAYS = 30), DATA_FLUSH_INTERVAL_SECONDS = 900, INTERVAL_LENGTH_MINUTES = 60, MAX_STORAGE_SIZE_MB = 1000, QUERY_CAPTURE_MODE = AUTO, SIZE_BASED_CLEANUP_MODE = AUTO, MAX_PLANS_PER_QUERY = 200, WAIT_STATS_CAPTURE_MODE = ON)
GO
USE [libraryManagementSystem]
GO
/****** Object:  Table [dbo].[Admin]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Admin](
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_Admin] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Authentication]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Authentication](
	[UserId] [int] NOT NULL,
	[Email] [nchar](100) NOT NULL,
	[Password] [nchar](25) NOT NULL
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Author]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Author](
	[AuthorID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](25) NOT NULL,
	[LastName] [nchar](25) NOT NULL,
	[UserID] [int] NOT NULL,
	[DateOfBirth] [datetime] NOT NULL,
	[Nationality] [varchar](25) NOT NULL,
 CONSTRAINT [PK_Author] PRIMARY KEY CLUSTERED 
(
	[AuthorID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Book]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Book](
	[BookID] [int] IDENTITY(1,1) NOT NULL,
	[BookTitle] [nchar](30) NOT NULL,
	[ISBNCode] [numeric](20, 0) NOT NULL,
	[CategoryID] [int] NOT NULL,
	[PublisherID] [int] NOT NULL,
	[PublicationYear] [numeric](18, 0) NOT NULL,
	[BookEdition] [int] NOT NULL,
	[TotalCopies] [numeric](18, 0) NOT NULL,
	[AvailableCopies] [numeric](18, 0) NOT NULL,
	[LocationID] [int] NOT NULL,
	[AdminID] [int] NOT NULL,
	[AuthorID] [int] NOT NULL,
 CONSTRAINT [PK_Book] PRIMARY KEY CLUSTERED 
(
	[BookID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookIssue]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookIssue](
	[IssueID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[IssueDate] [datetime] NOT NULL,
	[ReturnDate] [datetime] NOT NULL,
	[IssueStatus] [nchar](25) NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_BookIssue] PRIMARY KEY CLUSTERED 
(
	[IssueID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookRequest]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookRequest](
	[RequestID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[RequestDate] [datetime] NOT NULL,
	[StatusID] [int] NOT NULL,
	[UserID] [int] NOT NULL,
 CONSTRAINT [PK_BookRequest] PRIMARY KEY CLUSTERED 
(
	[RequestID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[BookRequestStatus]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[BookRequestStatus](
	[StatusID] [int] IDENTITY(1,1) NOT NULL,
	[AvailableStatus] [nchar](25) NOT NULL,
	[NearestAvailableDate] [datetime] NOT NULL,
 CONSTRAINT [PK_BookRequestStatus] PRIMARY KEY CLUSTERED 
(
	[StatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Category]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Category](
	[CategoryID] [int] IDENTITY(1,1) NOT NULL,
	[CategoryName] [nchar](25) NOT NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Category] PRIMARY KEY CLUSTERED 
(
	[CategoryID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FineDue]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FineDue](
	[FineID] [int] IDENTITY(1,1) NOT NULL,
	[IssueID] [int] NOT NULL,
	[StudentID] [int] NOT NULL,
	[FineDate] [datetime] NOT NULL,
	[TotalAmount] [float] NOT NULL,
 CONSTRAINT [PK_FineDue] PRIMARY KEY CLUSTERED 
(
	[FineID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[FinePayment]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[FinePayment](
	[PaymentID] [int] IDENTITY(1,1) NOT NULL,
	[PaymentAmount] [float] NOT NULL,
	[PaymentDate] [datetime] NOT NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_FinePayment] PRIMARY KEY CLUSTERED 
(
	[PaymentID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Location]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Location](
	[LocationID] [int] IDENTITY(1,1) NOT NULL,
	[ShelfNo] [numeric](18, 0) NOT NULL,
	[UserID] [int] NOT NULL,
	[Capacity] [int] NOT NULL,
 CONSTRAINT [PK_Location] PRIMARY KEY CLUSTERED 
(
	[LocationID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lookup]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lookup](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Value] [varchar](100) NOT NULL,
	[Category] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_Lookup] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Publisher]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Publisher](
	[PublisherID] [int] IDENTITY(1,1) NOT NULL,
	[PublisherName] [nchar](25) NOT NULL,
	[PublicationType] [nchar](25) NOT NULL,
	[PublicationLanguage] [nchar](25) NOT NULL,
	[UserID] [int] NULL,
	[PublisherAddress] [varchar](100) NOT NULL,
 CONSTRAINT [PK_Publisher] PRIMARY KEY CLUSTERED 
(
	[PublisherID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reviews]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reviews](
	[ReviewID] [int] IDENTITY(1,1) NOT NULL,
	[BookID] [int] NOT NULL,
	[BookReview] [nchar](25) NOT NULL,
	[ReviewDtae] [datetime] NOT NULL,
	[UserID] [int] NULL,
 CONSTRAINT [PK_Reviews] PRIMARY KEY CLUSTERED 
(
	[ReviewID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Staff]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Staff](
	[UserID] [int] NOT NULL,
	[Designation] [nchar](25) NOT NULL,
	[Salary] [float] NOT NULL,
 CONSTRAINT [PK_Staff] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Student]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Student](
	[UserID] [int] NOT NULL,
	[RegistrationNo] [nchar](25) NOT NULL,
	[Department] [nchar](25) NOT NULL,
	[Semester] [int] NOT NULL,
	[Status] [int] NOT NULL,
	[StudentShip_StartDate] [datetime] NOT NULL,
 CONSTRAINT [PK_Student] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[StudentStatus]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[StudentStatus](
	[ActiveStatusID] [int] IDENTITY(1,1) NOT NULL,
	[AccountStatus] [nchar](25) NOT NULL,
	[StudentShip_StartDate] [datetime] NOT NULL,
 CONSTRAINT [PK_StudentStatus] PRIMARY KEY CLUSTERED 
(
	[ActiveStatusID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[User]    Script Date: 5/4/2024 4:16:15 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[User](
	[UserID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nchar](25) NOT NULL,
	[LastName] [nchar](25) NOT NULL,
	[Email] [nchar](100) NOT NULL,
	[Password] [nchar](25) NOT NULL,
	[Contact] [numeric](18, 0) NOT NULL,
	[CNIC] [numeric](18, 0) NOT NULL,
	[City] [nchar](25) NOT NULL,
	[UserType] [varchar](25) NOT NULL,
 CONSTRAINT [PK_User] PRIMARY KEY CLUSTERED 
(
	[UserID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Admin] ([UserID]) VALUES (4)
GO
SET IDENTITY_INSERT [dbo].[Author] ON 

INSERT [dbo].[Author] ([AuthorID], [FirstName], [LastName], [UserID], [DateOfBirth], [Nationality]) VALUES (1, N'Umer                     ', N'Shahzad                  ', 4, CAST(N'2003-06-09T00:34:15.000' AS DateTime), N'American')
SET IDENTITY_INSERT [dbo].[Author] OFF
GO
SET IDENTITY_INSERT [dbo].[Book] ON 

INSERT [dbo].[Book] ([BookID], [BookTitle], [ISBNCode], [CategoryID], [PublisherID], [PublicationYear], [BookEdition], [TotalCopies], [AvailableCopies], [LocationID], [AdminID], [AuthorID]) VALUES (5, N'Harry Potter                  ', CAST(1234987634 AS Numeric(20, 0)), 1, 1, CAST(2000 AS Numeric(18, 0)), 3, CAST(5 AS Numeric(18, 0)), CAST(5 AS Numeric(18, 0)), 1, 4, 1)
SET IDENTITY_INSERT [dbo].[Book] OFF
GO
SET IDENTITY_INSERT [dbo].[Category] ON 

INSERT [dbo].[Category] ([CategoryID], [CategoryName], [UserID]) VALUES (1, N'Horror                   ', 4)
SET IDENTITY_INSERT [dbo].[Category] OFF
GO
SET IDENTITY_INSERT [dbo].[Location] ON 

INSERT [dbo].[Location] ([LocationID], [ShelfNo], [UserID], [Capacity]) VALUES (1, CAST(1 AS Numeric(18, 0)), 4, 3)
INSERT [dbo].[Location] ([LocationID], [ShelfNo], [UserID], [Capacity]) VALUES (2, CAST(2 AS Numeric(18, 0)), 4, 4)
SET IDENTITY_INSERT [dbo].[Location] OFF
GO
SET IDENTITY_INSERT [dbo].[Lookup] ON 

INSERT [dbo].[Lookup] ([ID], [Value], [Category]) VALUES (1, N'Active', N'STATUS')
INSERT [dbo].[Lookup] ([ID], [Value], [Category]) VALUES (2, N'InActive', N'STATUS')
SET IDENTITY_INSERT [dbo].[Lookup] OFF
GO
SET IDENTITY_INSERT [dbo].[Publisher] ON 

INSERT [dbo].[Publisher] ([PublisherID], [PublisherName], [PublicationType], [PublicationLanguage], [UserID], [PublisherAddress]) VALUES (1, N'waseem                   ', N'E Book                   ', N'English                  ', 4, N'Sambrial tehsil sialkot near paradise model school')
SET IDENTITY_INSERT [dbo].[Publisher] OFF
GO
INSERT [dbo].[Staff] ([UserID], [Designation], [Salary]) VALUES (5, N'Librarian                ', 50000)
GO
INSERT [dbo].[Student] ([UserID], [RegistrationNo], [Department], [Semester], [Status], [StudentShip_StartDate]) VALUES (2, N'2022-CS-17               ', N'Computer Science         ', 4, 1, CAST(N'2024-04-26T23:30:38.867' AS DateTime))
INSERT [dbo].[Student] ([UserID], [RegistrationNo], [Department], [Semester], [Status], [StudentShip_StartDate]) VALUES (10, N'2022-ME-17               ', N'Industrial Engineering   ', 4, 1, CAST(N'2024-05-04T16:01:28.383' AS DateTime))
GO
SET IDENTITY_INSERT [dbo].[User] ON 

INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Email], [Password], [Contact], [CNIC], [City], [UserType]) VALUES (2, N'Ameer                    ', N'Hamza                    ', N'hamzanaseer496@gmail.com                                                                            ', N'abcd123                  ', CAST(3430601827 AS Numeric(18, 0)), CAST(3410456462677 AS Numeric(18, 0)), N'Sambrial                 ', N'Student')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Email], [Password], [Contact], [CNIC], [City], [UserType]) VALUES (4, N'Hamza                    ', N'Naseer                   ', N'meharhn1012514@gmail.com                                                                            ', N'ab12cd34                 ', CAST(3274025364 AS Numeric(18, 0)), CAST(3410422683995 AS Numeric(18, 0)), N'Sialkot                  ', N'Admin')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Email], [Password], [Contact], [CNIC], [City], [UserType]) VALUES (5, N'Usama                    ', N'Abid                     ', N'usama123@gmail.com                                                                                  ', N'abc123                   ', CAST(3214585647 AS Numeric(18, 0)), CAST(3410425684599 AS Numeric(18, 0)), N'Islamabad                ', N'Staff')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Email], [Password], [Contact], [CNIC], [City], [UserType]) VALUES (8, N'Awais                    ', N'Jutt                     ', N'awaisjutt@gmail.com                                                                                 ', N'qwerty123                ', CAST(3274025364 AS Numeric(18, 0)), CAST(3410525413575 AS Numeric(18, 0)), N'Sheikhupura              ', N'Student')
INSERT [dbo].[User] ([UserID], [FirstName], [LastName], [Email], [Password], [Contact], [CNIC], [City], [UserType]) VALUES (10, N'Talha                    ', N'Khalid                   ', N'talha12@gmail.com                                                                                   ', N'1234567                  ', CAST(3124585967 AS Numeric(18, 0)), CAST(3460175849623 AS Numeric(18, 0)), N'Faislabad                ', N'Student')
SET IDENTITY_INSERT [dbo].[User] OFF
GO
ALTER TABLE [dbo].[Admin]  WITH CHECK ADD  CONSTRAINT [FK_Admin_Admin] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Admin] CHECK CONSTRAINT [FK_Admin_Admin]
GO
ALTER TABLE [dbo].[Authentication]  WITH CHECK ADD  CONSTRAINT [FK_Authentication_User] FOREIGN KEY([UserId])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Authentication] CHECK CONSTRAINT [FK_Authentication_User]
GO
ALTER TABLE [dbo].[Author]  WITH CHECK ADD  CONSTRAINT [FK_Author_Admin1] FOREIGN KEY([UserID])
REFERENCES [dbo].[Admin] ([UserID])
GO
ALTER TABLE [dbo].[Author] CHECK CONSTRAINT [FK_Author_Admin1]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Author] FOREIGN KEY([AuthorID])
REFERENCES [dbo].[Author] ([AuthorID])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Author]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Category] FOREIGN KEY([CategoryID])
REFERENCES [dbo].[Category] ([CategoryID])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Category]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Location] FOREIGN KEY([LocationID])
REFERENCES [dbo].[Location] ([LocationID])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Location]
GO
ALTER TABLE [dbo].[Book]  WITH CHECK ADD  CONSTRAINT [FK_Book_Publisher] FOREIGN KEY([PublisherID])
REFERENCES [dbo].[Publisher] ([PublisherID])
GO
ALTER TABLE [dbo].[Book] CHECK CONSTRAINT [FK_Book_Publisher]
GO
ALTER TABLE [dbo].[BookIssue]  WITH CHECK ADD  CONSTRAINT [FK_BookIssue_Book] FOREIGN KEY([BookID])
REFERENCES [dbo].[Book] ([BookID])
GO
ALTER TABLE [dbo].[BookIssue] CHECK CONSTRAINT [FK_BookIssue_Book]
GO
ALTER TABLE [dbo].[BookIssue]  WITH CHECK ADD  CONSTRAINT [FK_BookIssue_Staff] FOREIGN KEY([UserID])
REFERENCES [dbo].[Staff] ([UserID])
GO
ALTER TABLE [dbo].[BookIssue] CHECK CONSTRAINT [FK_BookIssue_Staff]
GO
ALTER TABLE [dbo].[BookIssue]  WITH CHECK ADD  CONSTRAINT [FK_BookIssue_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([UserID])
GO
ALTER TABLE [dbo].[BookIssue] CHECK CONSTRAINT [FK_BookIssue_Student]
GO
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD  CONSTRAINT [FK_BookRequest_Book] FOREIGN KEY([BookID])
REFERENCES [dbo].[Book] ([BookID])
GO
ALTER TABLE [dbo].[BookRequest] CHECK CONSTRAINT [FK_BookRequest_Book]
GO
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD  CONSTRAINT [FK_BookRequest_BookRequestStatus] FOREIGN KEY([StatusID])
REFERENCES [dbo].[BookRequestStatus] ([StatusID])
GO
ALTER TABLE [dbo].[BookRequest] CHECK CONSTRAINT [FK_BookRequest_BookRequestStatus]
GO
ALTER TABLE [dbo].[BookRequest]  WITH CHECK ADD  CONSTRAINT [FK_BookRequest_Student] FOREIGN KEY([UserID])
REFERENCES [dbo].[Student] ([UserID])
GO
ALTER TABLE [dbo].[BookRequest] CHECK CONSTRAINT [FK_BookRequest_Student]
GO
ALTER TABLE [dbo].[Category]  WITH CHECK ADD  CONSTRAINT [FK_Category_Admin] FOREIGN KEY([UserID])
REFERENCES [dbo].[Admin] ([UserID])
GO
ALTER TABLE [dbo].[Category] CHECK CONSTRAINT [FK_Category_Admin]
GO
ALTER TABLE [dbo].[FineDue]  WITH CHECK ADD  CONSTRAINT [FK_FineDue_BookIssue] FOREIGN KEY([IssueID])
REFERENCES [dbo].[BookIssue] ([IssueID])
GO
ALTER TABLE [dbo].[FineDue] CHECK CONSTRAINT [FK_FineDue_BookIssue]
GO
ALTER TABLE [dbo].[FineDue]  WITH CHECK ADD  CONSTRAINT [FK_FineDue_Student] FOREIGN KEY([StudentID])
REFERENCES [dbo].[Student] ([UserID])
GO
ALTER TABLE [dbo].[FineDue] CHECK CONSTRAINT [FK_FineDue_Student]
GO
ALTER TABLE [dbo].[FinePayment]  WITH CHECK ADD  CONSTRAINT [FK_FinePayment_Student] FOREIGN KEY([UserID])
REFERENCES [dbo].[Student] ([UserID])
GO
ALTER TABLE [dbo].[FinePayment] CHECK CONSTRAINT [FK_FinePayment_Student]
GO
ALTER TABLE [dbo].[Location]  WITH CHECK ADD  CONSTRAINT [FK_Location_Admin] FOREIGN KEY([UserID])
REFERENCES [dbo].[Admin] ([UserID])
GO
ALTER TABLE [dbo].[Location] CHECK CONSTRAINT [FK_Location_Admin]
GO
ALTER TABLE [dbo].[Publisher]  WITH CHECK ADD  CONSTRAINT [FK_Publisher_Admin] FOREIGN KEY([UserID])
REFERENCES [dbo].[Admin] ([UserID])
GO
ALTER TABLE [dbo].[Publisher] CHECK CONSTRAINT [FK_Publisher_Admin]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Book] FOREIGN KEY([BookID])
REFERENCES [dbo].[Book] ([BookID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Book]
GO
ALTER TABLE [dbo].[Reviews]  WITH CHECK ADD  CONSTRAINT [FK_Reviews_Student] FOREIGN KEY([UserID])
REFERENCES [dbo].[Student] ([UserID])
GO
ALTER TABLE [dbo].[Reviews] CHECK CONSTRAINT [FK_Reviews_Student]
GO
ALTER TABLE [dbo].[Staff]  WITH CHECK ADD  CONSTRAINT [FK_Staff_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Staff] CHECK CONSTRAINT [FK_Staff_User]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_Lookup] FOREIGN KEY([Status])
REFERENCES [dbo].[Lookup] ([ID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_Lookup]
GO
ALTER TABLE [dbo].[Student]  WITH CHECK ADD  CONSTRAINT [FK_Student_User] FOREIGN KEY([UserID])
REFERENCES [dbo].[User] ([UserID])
GO
ALTER TABLE [dbo].[Student] CHECK CONSTRAINT [FK_Student_User]
GO
/****** Object:  StoredProcedure [dbo].[AddPublisher]    Script Date: 5/4/2024 4:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddPublisher] 
	-- Add the parameters for the stored procedure here
	@PublisherName nchar(25),
    @PublicationType nchar(25),
    @PublicationLanguage nchar(25),
    @PublisherAddress varchar(100),
	@UserID int
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

    INSERT INTO Publisher (PublisherName, PublicationType, PublicationLanguage, UserID, PublisherAddress)
    VALUES (@PublisherName, @PublicationType, @PublicationLanguage, @UserID, @PublisherAddress)
END
GO
/****** Object:  StoredProcedure [dbo].[AddStudent]    Script Date: 5/4/2024 4:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[AddStudent]
    @FirstName NVARCHAR(25),
    @LastName NVARCHAR(25),
    @Email NVARCHAR(100),
    @Password NVARCHAR(8), -- Adjust the length as per your actual table structure
    @Contact NVARCHAR(11),
    @CNIC NVARCHAR(14),
    @City NVARCHAR(25),
    @UserType NVARCHAR(25),
    @RegistrationNo NVARCHAR(25),
    @Department NVARCHAR(25),
    @Semester INT,
    @Status INT,
    @StudentShip_StartDate DATETIME
AS
BEGIN
    SET NOCOUNT ON;

    -- Insert into User table
    INSERT INTO [User] (FirstName, LastName, Email, Password, Contact, CNIC, City, UserType)
    VALUES (@FirstName, @LastName, @Email, @Password, @Contact, @CNIC, @City, @UserType);

    -- Insert into Student table
    DECLARE @UserID INT = SCOPE_IDENTITY();
    INSERT INTO Student (UserID, RegistrationNo, Department, Semester, Status, StudentShip_StartDate)
    VALUES (@UserID, @RegistrationNo, @Department, @Semester, @Status, @StudentShip_StartDate);
END
GO
/****** Object:  StoredProcedure [dbo].[DeleteStudent]    Script Date: 5/4/2024 4:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[DeleteStudent]
	@UserID INT,
    @FirstName NVARCHAR(25),
    @LastName NVARCHAR(25),
    @Email NVARCHAR(100),
    @Password NVARCHAR(8),
    @Contact NVARCHAR(11),
    @CNIC NVARCHAR(14),
    @City NVARCHAR(25),
    @UserType NVARCHAR(25),
    @RegistrationNo NVARCHAR(25),
    @Department NVARCHAR(25),
	@Semester INT,
    @Status INT
AS
BEGIN
	
	SET NOCOUNT ON;
	DELETE FROM Student 
    WHERE UserID = @UserID
    AND RegistrationNo = @RegistrationNo
    AND Department = @Department;

	DELETE FROM [User] 
    WHERE UserID = @UserID
    AND FirstName = @FirstName
    AND LastName = @LastName
    AND Email = @Email
    AND Password = @Password
    AND Contact = @Contact
    AND CNIC = @CNIC
    AND City = @City
    AND UserType = @UserType;
 
END
GO
/****** Object:  StoredProcedure [dbo].[UpdatePublisher]    Script Date: 5/4/2024 4:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdatePublisher]
	-- Add the parameters for the stored procedure here
	@PublisherID INT,
    @PublisherName NVARCHAR(100),
    @PublicationType NVARCHAR(50),
    @PublicationLanguage NVARCHAR(50),
    @PublisherAddress NVARCHAR(200)
AS
BEGIN
	SET NOCOUNT ON;
	UPDATE Publisher
    SET 
        PublisherName = @PublisherName,
        PublicationType = @PublicationType,
        PublicationLanguage = @PublicationLanguage,
        PublisherAddress = @PublisherAddress
    WHERE PublisherID = @PublisherID;
END
GO
/****** Object:  StoredProcedure [dbo].[UpdateStudent]    Script Date: 5/4/2024 4:16:16 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Name>
-- Create date: <Create Date,,>
-- Description:	<Description,,>
-- =============================================
CREATE PROCEDURE [dbo].[UpdateStudent]
	@UserID INT,
    @FirstName NVARCHAR(25),
    @LastName NVARCHAR(25),
    @Email NVARCHAR(100),
    @Password NVARCHAR(8),
    @Contact NVARCHAR(11),
    @CNIC NVARCHAR(14),
    @City NVARCHAR(25),
    @UserType NVARCHAR(25),
    @RegistrationNo NVARCHAR(25),
    @Department NVARCHAR(25),
    @Semester INT,
    @Status INT,
    @StudentShip_StartDate DATETIME
AS
BEGIN
	-- SET NOCOUNT ON added to prevent extra result sets from
	-- interfering with SELECT statements.
	SET NOCOUNT ON;

   UPDATE [User] 
    SET FirstName = @FirstName,
        LastName = @LastName,
        Email = @Email,
        Password = @Password,
        Contact = @Contact,
        CNIC = @CNIC,
        City = @City,
        UserType = @UserType
    WHERE UserID = @UserID;

	UPDATE Student 
    SET 
		RegistrationNo = @RegistrationNo,
        Department = @Department,
        Semester = @Semester,
        Status = @Status,
        StudentShip_StartDate = @StudentShip_StartDate
    WHERE UserID = @UserID;
END
GO
USE [master]
GO
ALTER DATABASE [libraryManagementSystem] SET  READ_WRITE 
GO
