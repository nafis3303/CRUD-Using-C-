USE [nafis]
GO
/****** Object:  Table [dbo].[Practice]    Script Date: 9/12/2024 7:03:52 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Practice](
	[ID] [int] NOT NULL,
	[Name] [nvarchar](50) NULL,
	[Age] [int] NULL,
	[Type] [nvarchar](50) NULL,
	[Contact] [int] NULL,
	[EnrollDate] [datetime] NULL,
 CONSTRAINT [PK_Practice\] PRIMARY KEY CLUSTERED 
(
	[ID] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
