USE [master]
GO
/****** Object:  Database [PPAI2022]    Script Date: 12/6/2022 13:13:20 ******/
CREATE DATABASE [PPAI2022]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'PPAI2022', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PPAI2022.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'PPAI2022_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL15.MSSQLSERVER\MSSQL\DATA\PPAI2022_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
 WITH CATALOG_COLLATION = DATABASE_DEFAULT
GO
ALTER DATABASE [PPAI2022] SET COMPATIBILITY_LEVEL = 150
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [PPAI2022].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [PPAI2022] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [PPAI2022] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [PPAI2022] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [PPAI2022] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [PPAI2022] SET ARITHABORT OFF 
GO
ALTER DATABASE [PPAI2022] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [PPAI2022] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [PPAI2022] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [PPAI2022] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [PPAI2022] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [PPAI2022] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [PPAI2022] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [PPAI2022] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [PPAI2022] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [PPAI2022] SET  DISABLE_BROKER 
GO
ALTER DATABASE [PPAI2022] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [PPAI2022] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [PPAI2022] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [PPAI2022] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [PPAI2022] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [PPAI2022] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [PPAI2022] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [PPAI2022] SET RECOVERY FULL 
GO
ALTER DATABASE [PPAI2022] SET  MULTI_USER 
GO
ALTER DATABASE [PPAI2022] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [PPAI2022] SET DB_CHAINING OFF 
GO
ALTER DATABASE [PPAI2022] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [PPAI2022] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [PPAI2022] SET DELAYED_DURABILITY = DISABLED 
GO
ALTER DATABASE [PPAI2022] SET ACCELERATED_DATABASE_RECOVERY = OFF  
GO
EXEC sys.sp_db_vardecimal_storage_format N'PPAI2022', N'ON'
GO
ALTER DATABASE [PPAI2022] SET QUERY_STORE = OFF
GO
USE [PPAI2022]
GO
/****** Object:  Table [dbo].[AsignacionCientificoDelCI]    Script Date: 12/6/2022 13:13:20 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsignacionCientificoDelCI](
	[fechaDesde] [datetime] NULL,
	[fechaHasta] [datetime] NULL,
	[idAsgCienti] [int] NOT NULL,
	[cod_centro_invest] [int] NULL,
	[personalCientif] [int] NULL,
	[turno] [int] NULL,
 CONSTRAINT [PK_AsignacionCientificoDelCI] PRIMARY KEY CLUSTERED 
(
	[idAsgCienti] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsignacionDirectorCI]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsignacionDirectorCI](
	[fechaDesde] [datetime] NULL,
	[fechaHasta] [datetime] NULL,
	[idAsiDirect] [int] NOT NULL,
	[cod_centro_invest] [int] NULL,
	[personalCientif] [int] NULL,
 CONSTRAINT [PK_AsignacionDirectorCI] PRIMARY KEY CLUSTERED 
(
	[idAsiDirect] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsignacionRepotTecRT]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsignacionRepotTecRT](
	[fechaDesde] [datetime] NULL,
	[fechaHasta] [datetime] NULL,
	[idAsiRepRT] [int] NOT NULL,
	[numeroRT] [int] NULL,
	[personal] [int] NULL,
 CONSTRAINT [PK_AsignacionRepotTecRT] PRIMARY KEY CLUSTERED 
(
	[idAsiRepRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CambioEstadoRT]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CambioEstadoRT](
	[fechaHoraDesde] [datetime] NULL,
	[fechaHoraHasta] [datetime] NULL,
	[idCambEstRT] [int] NOT NULL,
	[numeroRT] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_CambioEstadoRT] PRIMARY KEY CLUSTERED 
(
	[idCambEstRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CambioEstadoTurno]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CambioEstadoTurno](
	[fechaHoraDesde] [datetime] NULL,
	[fechahoraHasta] [datetime] NULL,
	[idCambEsTurno] [int] NOT NULL,
	[cod_turno] [int] NULL,
	[estado] [int] NULL,
 CONSTRAINT [PK_CambioEstadoTurno] PRIMARY KEY CLUSTERED 
(
	[idCambEsTurno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Caracteristica]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Caracteristica](
	[cod_caract] [int] NOT NULL,
	[nombre] [nchar](10) NULL,
	[descripcion] [nchar](10) NULL,
	[cod_cararecuso] [int] NULL,
	[cod_tipoRT] [int] NULL,
 CONSTRAINT [PK_Caracteristica] PRIMARY KEY CLUSTERED 
(
	[cod_caract] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CaracteristicaRecurso]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CaracteristicaRecurso](
	[cod_cararecuso] [int] NOT NULL,
	[valor] [float] NULL,
	[numeroRT] [int] NULL,
 CONSTRAINT [PK_CaracteristicaRecurso] PRIMARY KEY CLUSTERED 
(
	[cod_cararecuso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CentroDeInvestigacion]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CentroDeInvestigacion](
	[cod_centro_invest] [int] NOT NULL,
	[nombre] [nchar](40) NULL,
	[sigla] [nchar](10) NULL,
	[edificio] [nchar](10) NULL,
	[piso] [int] NULL,
	[coordenada] [geography] NULL,
	[telefonocontacto] [int] NULL,
	[correo_electronico] [nchar](20) NULL,
	[num_resolu_creacion] [int] NULL,
	[fecha_resolucion_crea] [datetime] NULL,
	[reglamento] [nchar](50) NULL,
	[caracteristica_general] [nchar](10) NULL,
	[fechaAlta] [datetime] NULL,
	[tiempo_antelacio_reserva] [datetime] NULL,
	[fechaBaja] [datetime] NULL,
	[motivoBaja] [nchar](40) NULL,
	[cod_facultad] [int] NULL,
	[numeroRT] [int] NULL,
 CONSTRAINT [PK_CentroDeInvestigacion] PRIMARY KEY CLUSTERED 
(
	[cod_centro_invest] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Estado]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Estado](
	[cod_estado] [int] NOT NULL,
	[nombre] [nchar](50) NULL,
	[descripcion] [nchar](80) NULL,
	[ambito] [nchar](10) NULL,
 CONSTRAINT [PK_Estado] PRIMARY KEY CLUSTERED 
(
	[cod_estado] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ExtensionMantenimiento]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ExtensionMantenimiento](
	[fecha] [datetime] NULL,
	[fechaFinPrevista] [datetime] NULL,
	[motivo] [nchar](10) NULL,
	[idExtMante] [int] NOT NULL,
	[cod_manten] [int] NULL,
 CONSTRAINT [PK_ExtensionMantenimiento] PRIMARY KEY CLUSTERED 
(
	[idExtMante] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Facultad]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Facultad](
	[nombre] [nchar](40) NULL,
	[cod_facultad] [int] NOT NULL,
	[domicilio] [nchar](50) NULL,
 CONSTRAINT [PK_Facultad] PRIMARY KEY CLUSTERED 
(
	[cod_facultad] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HorarioRT]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HorarioRT](
	[diaSemana] [nchar](10) NULL,
	[horaDesde] [time](7) NULL,
	[horaHasta] [time](7) NULL,
	[vigenciaDesde] [datetime] NULL,
	[vigenciaHasta] [datetime] NULL,
	[idHorariRT] [int] NOT NULL,
	[numeroRT] [int] NULL,
 CONSTRAINT [PK_HorarioRT] PRIMARY KEY CLUSTERED 
(
	[idHorariRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Mantenimiento]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Mantenimiento](
	[cod_manten] [int] NOT NULL,
	[fechaFin] [datetime] NULL,
	[fechaInicio] [datetime] NULL,
	[fechaInicioPrevista] [datetime] NULL,
	[numeroRT] [int] NULL,
	[motivo] [varchar](50) NULL,
 CONSTRAINT [PK_Mantenimiento] PRIMARY KEY CLUSTERED 
(
	[cod_manten] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Marca]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Marca](
	[cod_marca] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
 CONSTRAINT [PK_Marca] PRIMARY KEY CLUSTERED 
(
	[cod_marca] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Modelo]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Modelo](
	[cod_modelo] [int] NOT NULL,
	[nombre] [varchar](50) NULL,
	[cod_marca] [int] NULL,
 CONSTRAINT [PK_Modelo] PRIMARY KEY CLUSTERED 
(
	[cod_modelo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PersonalCientifico]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PersonalCientifico](
	[legajo] [int] NOT NULL,
	[nombre] [nchar](50) NULL,
	[apellido] [nchar](50) NULL,
	[num_docu] [int] NULL,
	[correo_institucional] [nchar](80) NULL,
	[correo_personal] [nchar](80) NULL,
	[telef] [int] NULL,
	[cod_facultad] [int] NULL,
 CONSTRAINT [PK_PersonalCientifico] PRIMARY KEY CLUSTERED 
(
	[legajo] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[RecursoTecnologico]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[RecursoTecnologico](
	[numeroRT] [int] NOT NULL,
	[fechaAlta] [date] NULL,
	[periodicidadMant] [int] NULL,
	[duracionMant] [int] NULL,
	[fracicionHoraTurno] [date] NULL,
	[cod_tipoRT] [int] NULL,
	[estado] [int] NULL,
	[modelo] [int] NULL,
	[marca] [int] NULL,
 CONSTRAINT [PK_RecursoTecnologico] PRIMARY KEY CLUSTERED 
(
	[numeroRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Reserva]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Reserva](
	[idReserva] [int] NOT NULL,
	[estado] [int] NULL,
	[fechaInicio] [date] NULL,
	[fechaFin] [date] NULL,
 CONSTRAINT [PK_Reserva] PRIMARY KEY CLUSTERED 
(
	[idReserva] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Sesion]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Sesion](
	[fechaInicio] [date] NULL,
	[fechaFin] [date] NULL,
	[horaInicio] [time](7) NULL,
	[horaFin] [time](7) NULL,
	[idSesion] [int] NOT NULL,
	[usuario] [int] NULL,
 CONSTRAINT [PK_Sesion] PRIMARY KEY CLUSTERED 
(
	[idSesion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TipoRecursoTecnologico]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TipoRecursoTecnologico](
	[cod_tipoRT] [int] NOT NULL,
	[nombre] [nchar](60) NULL,
	[descripcion] [nchar](200) NULL,
 CONSTRAINT [PK_TipoRecursoTecnologico] PRIMARY KEY CLUSTERED 
(
	[cod_tipoRT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[cod_turno] [int] NOT NULL,
	[fechaGenera] [date] NULL,
	[diaSemana] [varchar](50) NULL,
	[fechaInicio] [date] NULL,
	[numeroRT] [int] NULL,
	[estado] [int] NULL,
	[horaInicio] [varchar](50) NULL,
	[horaFin] [varchar](50) NULL,
 CONSTRAINT [PK_Turno] PRIMARY KEY CLUSTERED 
(
	[cod_turno] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuario]    Script Date: 12/6/2022 13:13:21 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuario](
	[cod_usuario] [int] NOT NULL,
	[clave] [nchar](30) NULL,
	[usuario] [nchar](30) NULL,
	[habilitado] [char](3) NULL,
	[legajoCientifi] [int] NULL,
 CONSTRAINT [PK_Usuario] PRIMARY KEY CLUSTERED 
(
	[cod_usuario] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
INSERT [dbo].[Estado] ([cod_estado], [nombre], [descripcion], [ambito]) VALUES (1, N'disponible                                        ', N'disponible RT                                                                   ', N'si        ')
INSERT [dbo].[Estado] ([cod_estado], [nombre], [descripcion], [ambito]) VALUES (2, N'confirmadas                                       ', N'confirmadas RT                                                                  ', N'si        ')
INSERT [dbo].[Estado] ([cod_estado], [nombre], [descripcion], [ambito]) VALUES (3, N'pendientes                                        ', N'pendientes RT                                                                   ', N'si        ')
INSERT [dbo].[Estado] ([cod_estado], [nombre], [descripcion], [ambito]) VALUES (4, N'Cancelado                                         ', N'Cancelado RT                                                                    ', N'no        ')
INSERT [dbo].[Estado] ([cod_estado], [nombre], [descripcion], [ambito]) VALUES (5, N'creado                                            ', N'creado RT                                                                       ', N'si        ')
GO
INSERT [dbo].[Facultad] ([nombre], [cod_facultad], [domicilio]) VALUES (N'Universidad Tecnológica Nacional        ', 1, N'Maestro Marcelo López esq Cruz Roja               ')
INSERT [dbo].[Facultad] ([nombre], [cod_facultad], [domicilio]) VALUES (N'universidad nacional de cordoba         ', 2, N'Avenida Haya de la Torre                          ')
GO
INSERT [dbo].[Marca] ([cod_marca], [nombre]) VALUES (1, N'Quiltech')
INSERT [dbo].[Marca] ([cod_marca], [nombre]) VALUES (2, N'Omax')
INSERT [dbo].[Marca] ([cod_marca], [nombre]) VALUES (3, N'Siemens')
INSERT [dbo].[Marca] ([cod_marca], [nombre]) VALUES (4, N'Dell Technologies')
GO
INSERT [dbo].[Modelo] ([cod_modelo], [nombre], [cod_marca]) VALUES (1, N'QHS232M', 1)
INSERT [dbo].[Modelo] ([cod_modelo], [nombre], [cod_marca]) VALUES (2, N'40X-2500X', 2)
INSERT [dbo].[Modelo] ([cod_modelo], [nombre], [cod_marca]) VALUES (3, N'MAGNETON OPEN C', 3)
INSERT [dbo].[Modelo] ([cod_modelo], [nombre], [cod_marca]) VALUES (4, N'Cluster Altix UV2000', 4)
GO
INSERT [dbo].[PersonalCientifico] ([legajo], [nombre], [apellido], [num_docu], [correo_institucional], [correo_personal], [telef], [cod_facultad]) VALUES (100, N'Santiago                                          ', N'Perez                                             ', 38123456, N'santiago@frc.utn.edu.ar                                                         ', N'santiago@gmail.com                                                              ', 4915634, 1)
INSERT [dbo].[PersonalCientifico] ([legajo], [nombre], [apellido], [num_docu], [correo_institucional], [correo_personal], [telef], [cod_facultad]) VALUES (101, N'Maria                                             ', N'Rodriguez                                         ', 38977075, N'maria@frc.utn.edu.ar                                                            ', N'maria@gmail.com                                                                 ', 4918852, 1)
INSERT [dbo].[PersonalCientifico] ([legajo], [nombre], [apellido], [num_docu], [correo_institucional], [correo_personal], [telef], [cod_facultad]) VALUES (102, N'Victoria                                          ', N'Ibañez                                            ', 37547962, N'vicky@frc.utn.edu.ar                                                            ', N'vicky@gmail.com                                                                 ', 4919164, 1)
INSERT [dbo].[PersonalCientifico] ([legajo], [nombre], [apellido], [num_docu], [correo_institucional], [correo_personal], [telef], [cod_facultad]) VALUES (103, N'Matias                                            ', N'Vasquez                                           ', 38369987, N'matias@unc.edu.ar                                                               ', N'matias@gmail.com                                                                ', 4968947, 2)
GO
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (1, CAST(N'2022-05-09' AS Date), 1, 5, CAST(N'2022-05-19' AS Date), 1, 1, 1, 1)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (2, CAST(N'2022-05-12' AS Date), 1, 10, CAST(N'2022-05-21' AS Date), 2, 1, 1, 1)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (3, CAST(N'2022-05-13' AS Date), 1, 15, CAST(N'2022-05-22' AS Date), 3, 1, 2, 2)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (4, CAST(N'2022-05-26' AS Date), 1, 5, CAST(N'2022-05-22' AS Date), 4, 1, 3, 3)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (5, CAST(N'2022-05-28' AS Date), 1, 15, CAST(N'2022-05-13' AS Date), 1, 1, 4, 4)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (6, CAST(N'2022-05-30' AS Date), 1, 30, CAST(N'2022-05-13' AS Date), 2, 1, 2, 2)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (7, CAST(N'2022-06-01' AS Date), 2, 2, CAST(N'2022-05-05' AS Date), 3, 1, 1, 1)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (8, CAST(N'2022-06-01' AS Date), 2, 5, CAST(N'2022-05-06' AS Date), 4, 1, 3, 3)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (9, CAST(N'2022-06-08' AS Date), 2, 10, CAST(N'2022-05-06' AS Date), 1, 1, 1, 1)
INSERT [dbo].[RecursoTecnologico] ([numeroRT], [fechaAlta], [periodicidadMant], [duracionMant], [fracicionHoraTurno], [cod_tipoRT], [estado], [modelo], [marca]) VALUES (10, CAST(N'2022-06-09' AS Date), 2, 30, CAST(N'2022-05-08' AS Date), 2, 1, 2, 2)
GO
INSERT [dbo].[Sesion] ([fechaInicio], [fechaFin], [horaInicio], [horaFin], [idSesion], [usuario]) VALUES (CAST(N'2022-06-11' AS Date), CAST(N'2022-06-11' AS Date), CAST(N'09:00:00' AS Time), CAST(N'09:45:00' AS Time), 1, 1)
INSERT [dbo].[Sesion] ([fechaInicio], [fechaFin], [horaInicio], [horaFin], [idSesion], [usuario]) VALUES (CAST(N'2022-06-11' AS Date), CAST(N'2022-06-11' AS Date), CAST(N'11:10:00' AS Time), CAST(N'12:00:00' AS Time), 2, 2)
INSERT [dbo].[Sesion] ([fechaInicio], [fechaFin], [horaInicio], [horaFin], [idSesion], [usuario]) VALUES (CAST(N'2022-06-11' AS Date), CAST(N'2022-06-11' AS Date), CAST(N'08:25:00' AS Time), CAST(N'09:05:00' AS Time), 3, 3)
INSERT [dbo].[Sesion] ([fechaInicio], [fechaFin], [horaInicio], [horaFin], [idSesion], [usuario]) VALUES (CAST(N'2022-06-11' AS Date), CAST(N'2025-06-11' AS Date), CAST(N'15:35:00' AS Time), CAST(N'15:55:00' AS Time), 4, 4)
GO
INSERT [dbo].[TipoRecursoTecnologico] ([cod_tipoRT], [nombre], [descripcion]) VALUES (1, N'balanza de precisión                                        ', N'una balanza utilizada para pesar cantidades hasta un número muy preciso, generalmente hasta un miligramo                                                                                                ')
INSERT [dbo].[TipoRecursoTecnologico] ([cod_tipoRT], [nombre], [descripcion]) VALUES (2, N'microscopio                                                 ', N'El microscopio ? es una herramienta que permite observar objetos, que son demasiado pequeños para ser observados a simple vista                                                                         ')
INSERT [dbo].[TipoRecursoTecnologico] ([cod_tipoRT], [nombre], [descripcion]) VALUES (3, N'resonador magnético                                         ', N'equipo especializado en la obtención de imágenes del cuerpo en 2 + medio de un campo electromagnético muy potente                                                                                       ')
INSERT [dbo].[TipoRecursoTecnologico] ([cod_tipoRT], [nombre], [descripcion]) VALUES (4, N'equipo de cómputo de datos de alto rendimiento              ', N'representa la capacidad de procesar datos y realizar cálculos complejos a velocidades muy altas                                                                                                         ')
GO
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (1, CAST(N'2022-05-09' AS Date), N'lunes', CAST(N'2022-05-19' AS Date), 1, 1, N'10:00:05', N'08:00:05')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (2, CAST(N'2022-05-12' AS Date), N'martes', CAST(N'2022-05-21' AS Date), 2, 1, N'14:22:08', N'18:24:25')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (3, CAST(N'2022-05-13' AS Date), N'miércoles', CAST(N'2022-05-22' AS Date), 3, 1, N'13:45:20', N'18:24:25')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (4, CAST(N'2022-05-26' AS Date), N'jueves', CAST(N'2022-05-22' AS Date), 4, 2, N'22:22:01', N'08:00:05')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (5, CAST(N'2022-05-28' AS Date), N'viernes', CAST(N'2022-05-13' AS Date), 5, 2, N'15:00:00', N'22:22:01')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (6, CAST(N'2022-05-30' AS Date), N'lunes', CAST(N'2022-05-13' AS Date), 6, 3, N'18:24:25', N'22:22:01')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (7, CAST(N'2022-06-01' AS Date), N'martes', CAST(N'2022-05-05' AS Date), 7, 3, N'10:00:05', N'22:22:01')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (8, CAST(N'2022-06-01' AS Date), N'miércoles', CAST(N'2022-05-06' AS Date), 8, 1, N'14:22:08', N'18:24:25')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (9, CAST(N'2022-06-08' AS Date), N'lunes', CAST(N'2022-05-06' AS Date), 9, 1, N'13:45:20', N'18:24:25')
INSERT [dbo].[Turno] ([cod_turno], [fechaGenera], [diaSemana], [fechaInicio], [numeroRT], [estado], [horaInicio], [horaFin]) VALUES (10, CAST(N'2022-06-09' AS Date), N'martes', CAST(N'2022-05-08' AS Date), 10, 2, N'22:22:01', N'08:00:05')
GO
INSERT [dbo].[Usuario] ([cod_usuario], [clave], [usuario], [habilitado], [legajoCientifi]) VALUES (1, N'12345                         ', N'Juan                          ', N'ON ', 100)
INSERT [dbo].[Usuario] ([cod_usuario], [clave], [usuario], [habilitado], [legajoCientifi]) VALUES (2, N'164612                        ', N'Jose                          ', N'ON ', 101)
INSERT [dbo].[Usuario] ([cod_usuario], [clave], [usuario], [habilitado], [legajoCientifi]) VALUES (3, N'73313546                      ', N'Lucia                         ', N'ON ', 102)
INSERT [dbo].[Usuario] ([cod_usuario], [clave], [usuario], [habilitado], [legajoCientifi]) VALUES (4, N'3777465                       ', N'Gustavo                       ', N'ON ', 103)
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionCientificoDelCI_CentroDeInvestigacion1] FOREIGN KEY([cod_centro_invest])
REFERENCES [dbo].[CentroDeInvestigacion] ([cod_centro_invest])
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI] CHECK CONSTRAINT [FK_AsignacionCientificoDelCI_CentroDeInvestigacion1]
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionCientificoDelCI_PersonalCientifico] FOREIGN KEY([personalCientif])
REFERENCES [dbo].[PersonalCientifico] ([legajo])
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI] CHECK CONSTRAINT [FK_AsignacionCientificoDelCI_PersonalCientifico]
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionCientificoDelCI_Turno] FOREIGN KEY([turno])
REFERENCES [dbo].[Turno] ([cod_turno])
GO
ALTER TABLE [dbo].[AsignacionCientificoDelCI] CHECK CONSTRAINT [FK_AsignacionCientificoDelCI_Turno]
GO
ALTER TABLE [dbo].[AsignacionDirectorCI]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionDirectorCI_CentroDeInvestigacion1] FOREIGN KEY([cod_centro_invest])
REFERENCES [dbo].[CentroDeInvestigacion] ([cod_centro_invest])
GO
ALTER TABLE [dbo].[AsignacionDirectorCI] CHECK CONSTRAINT [FK_AsignacionDirectorCI_CentroDeInvestigacion1]
GO
ALTER TABLE [dbo].[AsignacionDirectorCI]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionDirectorCI_PersonalCientifico] FOREIGN KEY([personalCientif])
REFERENCES [dbo].[PersonalCientifico] ([legajo])
GO
ALTER TABLE [dbo].[AsignacionDirectorCI] CHECK CONSTRAINT [FK_AsignacionDirectorCI_PersonalCientifico]
GO
ALTER TABLE [dbo].[AsignacionRepotTecRT]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionRepotTecRT_PersonalCientifico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[PersonalCientifico] ([legajo])
GO
ALTER TABLE [dbo].[AsignacionRepotTecRT] CHECK CONSTRAINT [FK_AsignacionRepotTecRT_PersonalCientifico]
GO
ALTER TABLE [dbo].[AsignacionRepotTecRT]  WITH CHECK ADD  CONSTRAINT [FK_AsignacionRepotTecRT_RecursoTecnologico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[AsignacionRepotTecRT] CHECK CONSTRAINT [FK_AsignacionRepotTecRT_RecursoTecnologico]
GO
ALTER TABLE [dbo].[CambioEstadoRT]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstadoRT_Estado] FOREIGN KEY([estado])
REFERENCES [dbo].[Estado] ([cod_estado])
GO
ALTER TABLE [dbo].[CambioEstadoRT] CHECK CONSTRAINT [FK_CambioEstadoRT_Estado]
GO
ALTER TABLE [dbo].[CambioEstadoRT]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstadoRT_RecursoTecnologico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[CambioEstadoRT] CHECK CONSTRAINT [FK_CambioEstadoRT_RecursoTecnologico]
GO
ALTER TABLE [dbo].[CambioEstadoTurno]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstadoTurno_Estado] FOREIGN KEY([estado])
REFERENCES [dbo].[Estado] ([cod_estado])
GO
ALTER TABLE [dbo].[CambioEstadoTurno] CHECK CONSTRAINT [FK_CambioEstadoTurno_Estado]
GO
ALTER TABLE [dbo].[CambioEstadoTurno]  WITH CHECK ADD  CONSTRAINT [FK_CambioEstadoTurno_Turno] FOREIGN KEY([cod_turno])
REFERENCES [dbo].[Turno] ([cod_turno])
GO
ALTER TABLE [dbo].[CambioEstadoTurno] CHECK CONSTRAINT [FK_CambioEstadoTurno_Turno]
GO
ALTER TABLE [dbo].[Caracteristica]  WITH CHECK ADD  CONSTRAINT [FK_Caracteristica_CaracteristicaRecurso] FOREIGN KEY([cod_cararecuso])
REFERENCES [dbo].[CaracteristicaRecurso] ([cod_cararecuso])
GO
ALTER TABLE [dbo].[Caracteristica] CHECK CONSTRAINT [FK_Caracteristica_CaracteristicaRecurso]
GO
ALTER TABLE [dbo].[Caracteristica]  WITH CHECK ADD  CONSTRAINT [FK_Caracteristica_TipoRecursoTecnologico1] FOREIGN KEY([cod_tipoRT])
REFERENCES [dbo].[TipoRecursoTecnologico] ([cod_tipoRT])
GO
ALTER TABLE [dbo].[Caracteristica] CHECK CONSTRAINT [FK_Caracteristica_TipoRecursoTecnologico1]
GO
ALTER TABLE [dbo].[CaracteristicaRecurso]  WITH CHECK ADD  CONSTRAINT [FK_CaracteristicaRecurso_RecursoTecnologico1] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[CaracteristicaRecurso] CHECK CONSTRAINT [FK_CaracteristicaRecurso_RecursoTecnologico1]
GO
ALTER TABLE [dbo].[CentroDeInvestigacion]  WITH CHECK ADD  CONSTRAINT [FK_CentroDeInvestigacion_Facultad] FOREIGN KEY([cod_facultad])
REFERENCES [dbo].[Facultad] ([cod_facultad])
GO
ALTER TABLE [dbo].[CentroDeInvestigacion] CHECK CONSTRAINT [FK_CentroDeInvestigacion_Facultad]
GO
ALTER TABLE [dbo].[CentroDeInvestigacion]  WITH CHECK ADD  CONSTRAINT [FK_CentroDeInvestigacion_RecursoTecnologico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[CentroDeInvestigacion] CHECK CONSTRAINT [FK_CentroDeInvestigacion_RecursoTecnologico]
GO
ALTER TABLE [dbo].[ExtensionMantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_ExtensionMantenimiento_Mantenimiento] FOREIGN KEY([cod_manten])
REFERENCES [dbo].[Mantenimiento] ([cod_manten])
GO
ALTER TABLE [dbo].[ExtensionMantenimiento] CHECK CONSTRAINT [FK_ExtensionMantenimiento_Mantenimiento]
GO
ALTER TABLE [dbo].[HorarioRT]  WITH CHECK ADD  CONSTRAINT [FK_HorarioRT_RecursoTecnologico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[HorarioRT] CHECK CONSTRAINT [FK_HorarioRT_RecursoTecnologico]
GO
ALTER TABLE [dbo].[Mantenimiento]  WITH CHECK ADD  CONSTRAINT [FK_Mantenimiento_RecursoTecnologico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[Mantenimiento] CHECK CONSTRAINT [FK_Mantenimiento_RecursoTecnologico]
GO
ALTER TABLE [dbo].[Modelo]  WITH CHECK ADD  CONSTRAINT [FK_Modelo_Marca] FOREIGN KEY([cod_marca])
REFERENCES [dbo].[Marca] ([cod_marca])
GO
ALTER TABLE [dbo].[Modelo] CHECK CONSTRAINT [FK_Modelo_Marca]
GO
ALTER TABLE [dbo].[PersonalCientifico]  WITH CHECK ADD  CONSTRAINT [FK_PersonalCientifico_Facultad1] FOREIGN KEY([cod_facultad])
REFERENCES [dbo].[Facultad] ([cod_facultad])
GO
ALTER TABLE [dbo].[PersonalCientifico] CHECK CONSTRAINT [FK_PersonalCientifico_Facultad1]
GO
ALTER TABLE [dbo].[RecursoTecnologico]  WITH CHECK ADD  CONSTRAINT [FK_RecursoTecnologico_Estado] FOREIGN KEY([estado])
REFERENCES [dbo].[Estado] ([cod_estado])
GO
ALTER TABLE [dbo].[RecursoTecnologico] CHECK CONSTRAINT [FK_RecursoTecnologico_Estado]
GO
ALTER TABLE [dbo].[RecursoTecnologico]  WITH CHECK ADD  CONSTRAINT [FK_RecursoTecnologico_Marca] FOREIGN KEY([marca])
REFERENCES [dbo].[Marca] ([cod_marca])
GO
ALTER TABLE [dbo].[RecursoTecnologico] CHECK CONSTRAINT [FK_RecursoTecnologico_Marca]
GO
ALTER TABLE [dbo].[RecursoTecnologico]  WITH CHECK ADD  CONSTRAINT [FK_RecursoTecnologico_Modelo] FOREIGN KEY([modelo])
REFERENCES [dbo].[Modelo] ([cod_modelo])
GO
ALTER TABLE [dbo].[RecursoTecnologico] CHECK CONSTRAINT [FK_RecursoTecnologico_Modelo]
GO
ALTER TABLE [dbo].[RecursoTecnologico]  WITH CHECK ADD  CONSTRAINT [FK_RecursoTecnologico_TipoRecursoTecnologico] FOREIGN KEY([cod_tipoRT])
REFERENCES [dbo].[TipoRecursoTecnologico] ([cod_tipoRT])
GO
ALTER TABLE [dbo].[RecursoTecnologico] CHECK CONSTRAINT [FK_RecursoTecnologico_TipoRecursoTecnologico]
GO
ALTER TABLE [dbo].[Reserva]  WITH CHECK ADD  CONSTRAINT [FK_Reserva_Estado] FOREIGN KEY([estado])
REFERENCES [dbo].[Estado] ([cod_estado])
GO
ALTER TABLE [dbo].[Reserva] CHECK CONSTRAINT [FK_Reserva_Estado]
GO
ALTER TABLE [dbo].[Sesion]  WITH CHECK ADD  CONSTRAINT [FK_Sesion_Usuario1] FOREIGN KEY([usuario])
REFERENCES [dbo].[Usuario] ([cod_usuario])
GO
ALTER TABLE [dbo].[Sesion] CHECK CONSTRAINT [FK_Sesion_Usuario1]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_Estado] FOREIGN KEY([estado])
REFERENCES [dbo].[Estado] ([cod_estado])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_Estado]
GO
ALTER TABLE [dbo].[Turno]  WITH CHECK ADD  CONSTRAINT [FK_Turno_RecursoTecnologico] FOREIGN KEY([numeroRT])
REFERENCES [dbo].[RecursoTecnologico] ([numeroRT])
GO
ALTER TABLE [dbo].[Turno] CHECK CONSTRAINT [FK_Turno_RecursoTecnologico]
GO
ALTER TABLE [dbo].[Usuario]  WITH CHECK ADD  CONSTRAINT [FK_Usuario_PersonalCientifico1] FOREIGN KEY([legajoCientifi])
REFERENCES [dbo].[PersonalCientifico] ([legajo])
GO
ALTER TABLE [dbo].[Usuario] CHECK CONSTRAINT [FK_Usuario_PersonalCientifico1]
GO
USE [master]
GO
ALTER DATABASE [PPAI2022] SET  READ_WRITE 
GO
