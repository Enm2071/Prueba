USE [Prueba]
GO
/****** Object:  Table [dbo].[Msrt_Provincia]    Script Date: 01/02/2018 02:16:01 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Msrt_Provincia](
	[IDProvincia] [varchar](9) NOT NULL,
	[DescripcionProvincia] [varchar](50) NULL,
 CONSTRAINT [PK_Msrt_Provincia] PRIMARY KEY CLUSTERED 
(
	[IDProvincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Municipios]    Script Date: 01/02/2018 02:16:01 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Municipios](
	[IDMunicipio] [varchar](9) NOT NULL,
	[DescripcionMunicipio] [varchar](50) NULL,
	[IDProvincia] [varchar](9) NULL,
 CONSTRAINT [PK_Msrt_Municipio] PRIMARY KEY CLUSTERED 
(
	[IDMunicipio] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 01/02/2018 02:16:01 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[Cedula] [varchar](20) NOT NULL,
	[Nombre] [varchar](50) NOT NULL,
	[E_Mail] [varchar](100) NULL,
	[Telefono] [varchar](50) NOT NULL,
	[IDProvincia] [varchar](9) NOT NULL,
	[IDMunicipio] [varchar](9) NOT NULL,
	[ComentarioYSugerencia] [varchar](max) NOT NULL,
	[Estado] [varchar](20) NULL,
	[Archivo] [varchar](max) NULL,
 CONSTRAINT [PK__Usuario__B4ADFE393A8A35BE] PRIMARY KEY CLUSTERED 
(
	[Cedula] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[Usp_Insert]    Script Date: 01/02/2018 02:16:01 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[Usp_Insert]
(
					@Cedula varchar(20),
					@Nombre varchar(50),
					@E_Mail varchar(100),
					@Telefono varchar(50),
					@IDProvincia varchar(50),
					@IDMunicipio varchar(50),
					@ComentarioYSugerencia varchar(max),
					@Estado varchar(20),
					@Archivo varchar(max)
)
as begin
insert into Usuario(Cedula,
					Nombre,
					E_Mail,
					Telefono,
					IDProvincia,
					IDMunicipio,
					ComentarioYSugerencia,
					Estado,
					Archivo)
values(				@Cedula,
					@Nombre,
					@E_Mail,
					@Telefono,
					@IDProvincia,
					@IDMunicipio,
					@ComentarioYSugerencia,
					@Estado,
					@Archivo)
end
GO
/****** Object:  StoredProcedure [dbo].[Usp_Read]    Script Date: 01/02/2018 02:16:01 a.m. ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[Usp_Read]
as begin
select * from Provincia
end
GO
