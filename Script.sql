USE [demo1]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 04/07/2013 17:03:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
SET ANSI_PADDING ON
GO
CREATE TABLE [dbo].[Usuario](
	[usuario] [varchar](50) NULL,
	[password] [varchar](300) NULL,
	[nombre] [varchar](30) NULL,
	[apellidos] [varchar](30) NULL,
	[cod] [int] IDENTITY(1,1) NOT NULL,
	[direccion] [varchar](100) NULL,
	[fecha_nacimiento] [datetime] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[cod] ASC
)WITH (PAD_INDEX  = OFF, STATISTICS_NORECOMPUTE  = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS  = ON, ALLOW_PAGE_LOCKS  = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
SET ANSI_PADDING OFF
GO
