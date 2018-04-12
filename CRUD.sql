Create database ContactDB
Go
USE [ContactDB]
GO
/****** Object:  StoredProcedure [dbo].[spDeleteContactDetails]    Script Date: 4/8/2018 10:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


Create PROCEDURE [dbo].[spDeleteContactDetails]
@ID int
AS
BEGIN
	delete from tbl_ContactDetails where ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[spGetContactDetails]    Script Date: 4/8/2018 10:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spGetContactDetails]
AS
BEGIN
	--select ID,FirstName,LastName,Email,PhoneNumber,Status
	-- from tbl_ContactDetails order by UpdatedDate desc
	select c.ID,c.FirstName,c.LastName,c.Email,c.PhoneNumber,s.Status
	from tbl_ContactDetails c inner join tbl_Status s on 
	c.Status = s.ID order by c.UpdatedDate desc
END



GO
/****** Object:  StoredProcedure [dbo].[spGetOneContactDetails]    Script Date: 4/8/2018 10:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO


CREATE PROCEDURE [dbo].[spGetOneContactDetails]
@ID int
AS
BEGIN
	select ID,FirstName,LastName,Email,PhoneNumber,Status
	 from tbl_ContactDetails where ID = @ID
END

GO
/****** Object:  StoredProcedure [dbo].[spGetStatus]    Script Date: 4/8/2018 10:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

Create PROCEDURE [dbo].[spGetStatus]
AS
BEGIN
	select *
	 from tbl_Status
END



GO
/****** Object:  StoredProcedure [dbo].[spInsertContactDetails]    Script Date: 4/8/2018 10:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
-- =============================================
-- Author:		<Author,,Kunal Brahme>
-- Create date: <Create Date,,4/4/20178>
-- Description:	<Description,,To insert contact details into table>
-- =============================================
CREATE PROCEDURE [dbo].[spInsertContactDetails]
@FirstName nvarchar(max),
@LastName nvarchar(max),
@EmailId  nvarchar(max),
@PhoneNumber nvarchar(max),
@Status nvarchar(max)
AS
BEGIN
	insert into [dbo].[tbl_ContactDetails](FirstName,LastName,Email,PhoneNumber,Status,CreatedDate,UpdatedDate)
	values(@FirstName,@LastName,@EmailId,@PhoneNumber,@Status,SYSDATETIME(),SYSDATETIME())
END

GO
/****** Object:  StoredProcedure [dbo].[spUpdateContactDetails]    Script Date: 4/8/2018 10:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE PROCEDURE [dbo].[spUpdateContactDetails]
@FirstName nvarchar(max),
@LastName nvarchar(max),
@EmailId  nvarchar(max),
@PhoneNumber nvarchar(max),
@Status nvarchar(max),
@ID int
AS
BEGIN
UPDATE  [dbo].[tbl_ContactDetails]
SET FirstName = @FirstName, LastName = @LastName,Email = @EmailId,
PhoneNumber=@PhoneNumber,Status =@Status,UpdatedDate = SYSDATETIME()
WHERE ID = @ID;
end


GO
/****** Object:  Table [dbo].[tbl_ContactDetails]    Script Date: 4/8/2018 10:54:29 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_ContactDetails](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[FirstName] [nvarchar](max) NOT NULL,
	[LastName] [nvarchar](max) NOT NULL,
	[Email] [nvarchar](max) NOT NULL,
	[PhoneNumber] [nvarchar](max) NOT NULL,
	[Status] [nvarchar](max) NULL,
	[CreatedDate] [datetime] NULL,
	[UpdatedDate] [datetime] NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
/****** Object:  Table [dbo].[tbl_Status]    Script Date: 4/8/2018 10:54:30 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[tbl_Status](
	[ID] [int] IDENTITY(1,1) NOT NULL,
	[Status] [nvarchar](max) NOT NULL,
PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[tbl_ContactDetails] ON 

INSERT [dbo].[tbl_ContactDetails] ([ID], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreatedDate], [UpdatedDate]) VALUES (1047, N'Kunal', N'Brahme', N'kunal.brahme@gmail.com', N'7507305390', N'1', CAST(0x0000A8BC0177516D AS DateTime), CAST(0x0000A8BC0177516D AS DateTime))
INSERT [dbo].[tbl_ContactDetails] ([ID], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreatedDate], [UpdatedDate]) VALUES (1048, N'Jhon', N'Cena', N'Jhon.Cena@gmail.com', N'9876543120', N'1', CAST(0x0000A8BC01776E30 AS DateTime), CAST(0x0000A8BC01776E30 AS DateTime))
INSERT [dbo].[tbl_ContactDetails] ([ID], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreatedDate], [UpdatedDate]) VALUES (1049, N'Mark', N'Spencer', N'Mark.spencer@hotmail.com', N'9876556789', N'2', CAST(0x0000A8BC0177AF8D AS DateTime), CAST(0x0000A8BC0177AF8D AS DateTime))
INSERT [dbo].[tbl_ContactDetails] ([ID], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreatedDate], [UpdatedDate]) VALUES (1050, N'Angelina', N'jolie', N'Angelina@yahoo.com', N'9283938382', N'1', CAST(0x0000A8BC0177FAD1 AS DateTime), CAST(0x0000A8BC0177FAD1 AS DateTime))
INSERT [dbo].[tbl_ContactDetails] ([ID], [FirstName], [LastName], [Email], [PhoneNumber], [Status], [CreatedDate], [UpdatedDate]) VALUES (1051, N'Shawn', N'Michaels', N'michaels.shawn@gmail.com', N'8938932833', N'2', CAST(0x0000A8BC01785027 AS DateTime), CAST(0x0000A8BC01785027 AS DateTime))
SET IDENTITY_INSERT [dbo].[tbl_ContactDetails] OFF
SET IDENTITY_INSERT [dbo].[tbl_Status] ON 

INSERT [dbo].[tbl_Status] ([ID], [Status]) VALUES (1, N'Active')
INSERT [dbo].[tbl_Status] ([ID], [Status]) VALUES (2, N'Inactive')
SET IDENTITY_INSERT [dbo].[tbl_Status] OFF
