USE [master]
GO
/****** Object:  Database [Sistemas_II_CPVC]    Script Date: 17/10/2019 16:57:56 ******/
CREATE DATABASE [Sistemas_II_CPVC]
 CONTAINMENT = NONE
 ON  PRIMARY 
( NAME = N'Sistema_compras', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSERVER1234\MSSQL\DATA\pepinos.mdf' , SIZE = 8192KB , MAXSIZE = UNLIMITED, FILEGROWTH = 65536KB )
 LOG ON 
( NAME = N'Sistema_compras_log', FILENAME = N'C:\Program Files\Microsoft SQL Server\MSSQL13.SQLSERVER1234\MSSQL\DATA\pepinos_log.ldf' , SIZE = 8192KB , MAXSIZE = 2048GB , FILEGROWTH = 65536KB )
GO
ALTER DATABASE [Sistemas_II_CPVC] SET COMPATIBILITY_LEVEL = 130
GO
IF (1 = FULLTEXTSERVICEPROPERTY('IsFullTextInstalled'))
begin
EXEC [Sistemas_II_CPVC].[dbo].[sp_fulltext_database] @action = 'enable'
end
GO
ALTER DATABASE [Sistemas_II_CPVC] SET ANSI_NULL_DEFAULT OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET ANSI_NULLS OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET ANSI_PADDING OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET ANSI_WARNINGS OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET ARITHABORT OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET AUTO_CLOSE OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET AUTO_SHRINK OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET AUTO_UPDATE_STATISTICS ON 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET CURSOR_CLOSE_ON_COMMIT OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET CURSOR_DEFAULT  GLOBAL 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET CONCAT_NULL_YIELDS_NULL OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET NUMERIC_ROUNDABORT OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET QUOTED_IDENTIFIER OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET RECURSIVE_TRIGGERS OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET  DISABLE_BROKER 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET AUTO_UPDATE_STATISTICS_ASYNC OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET DATE_CORRELATION_OPTIMIZATION OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET TRUSTWORTHY OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET ALLOW_SNAPSHOT_ISOLATION OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET PARAMETERIZATION SIMPLE 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET READ_COMMITTED_SNAPSHOT OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET HONOR_BROKER_PRIORITY OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET RECOVERY FULL 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET  MULTI_USER 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET PAGE_VERIFY CHECKSUM  
GO
ALTER DATABASE [Sistemas_II_CPVC] SET DB_CHAINING OFF 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET FILESTREAM( NON_TRANSACTED_ACCESS = OFF ) 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET TARGET_RECOVERY_TIME = 60 SECONDS 
GO
ALTER DATABASE [Sistemas_II_CPVC] SET DELAYED_DURABILITY = DISABLED 
GO
EXEC sys.sp_db_vardecimal_storage_format N'Sistemas_II_CPVC', N'ON'
GO
ALTER DATABASE [Sistemas_II_CPVC] SET QUERY_STORE = OFF
GO
USE [Sistemas_II_CPVC]
GO
ALTER DATABASE SCOPED CONFIGURATION SET MAXDOP = 0;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET MAXDOP = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET LEGACY_CARDINALITY_ESTIMATION = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET LEGACY_CARDINALITY_ESTIMATION = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET PARAMETER_SNIFFING = ON;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET PARAMETER_SNIFFING = PRIMARY;
GO
ALTER DATABASE SCOPED CONFIGURATION SET QUERY_OPTIMIZER_HOTFIXES = OFF;
GO
ALTER DATABASE SCOPED CONFIGURATION FOR SECONDARY SET QUERY_OPTIMIZER_HOTFIXES = PRIMARY;
GO
USE [Sistemas_II_CPVC]
GO
/****** Object:  Table [dbo].[1_bien_uso]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_bien_uso](
	[cod_pro_buso] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[stock] [int] NOT NULL,
	[descripcion] [varchar](500) NULL,
	[observacion] [varchar](500) NULL,
 CONSTRAINT [PK_bien_uso] PRIMARY KEY CLUSTERED 
(
	[cod_pro_buso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_buso_proveedor]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_buso_proveedor](
	[cod_proveedor] [int] NOT NULL,
	[cod_pro_buso] [int] NOT NULL,
 CONSTRAINT [PK_buso_proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_proveedor] ASC,
	[cod_pro_buso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_buso_sc]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_buso_sc](
	[cod_sc] [int] NOT NULL,
	[cod_pro_buso] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_buso_sc] PRIMARY KEY CLUSTERED 
(
	[cod_sc] ASC,
	[cod_pro_buso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_categoria]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_categoria](
	[cod_cat] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_rubro] PRIMARY KEY CLUSTERED 
(
	[cod_cat] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cbu_proveedor]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cbu_proveedor](
	[cod_proveedor] [int] NOT NULL,
	[cod_cbu] [int] IDENTITY(1,1) NOT NULL,
	[cbu] [decimal](25, 0) NOT NULL,
 CONSTRAINT [PK_1_cbu_proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_cbu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_ciudad]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_ciudad](
	[cod_ciu] [int] IDENTITY(1,1) NOT NULL,
	[cod_provincia] [int] NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[codigo_postal] [varchar](10) NOT NULL,
 CONSTRAINT [PK_1_ciudad] PRIMARY KEY CLUSTERED 
(
	[cod_ciu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_pedido_reaprovisionamiento]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_pedido_reaprovisionamiento](
	[cod_cotizacion] [int] IDENTITY(1,1) NOT NULL,
	[cod_pro_stock] [int] NOT NULL,
	[cod_pr] [int] NOT NULL,
	[tiempo_entrega] [varchar](50) NOT NULL,
	[fecha_cotizacion] [date] NOT NULL,
	[precio_cotizado] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_cotizacion_pedido_reaprovisionamiento_1] PRIMARY KEY CLUSTERED 
(
	[cod_cotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_pr]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_pr](
	[cod_cotizacion] [int] NOT NULL,
	[cod_proveedor] [int] NOT NULL,
 CONSTRAINT [PK_1_cotizacion_pr] PRIMARY KEY CLUSTERED 
(
	[cod_cotizacion] ASC,
	[cod_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_pr_oc]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_pr_oc](
	[cod_cotizacion] [int] NOT NULL,
	[cod_ord_cpr] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_sc]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_sc](
	[cod_cotizacion] [int] NOT NULL,
	[cod_proveedor] [int] NOT NULL,
 CONSTRAINT [PK_cotizacion] PRIMARY KEY CLUSTERED 
(
	[cod_cotizacion] ASC,
	[cod_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_sc_oc]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_sc_oc](
	[cod_cotizacion] [int] NOT NULL,
	[cod_ord_cpr] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_solicitud_compra]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_solicitud_compra](
	[cod_cotizacion] [int] IDENTITY(1,1) NOT NULL,
	[cod_sc] [int] NOT NULL,
	[tiempo_entrega] [varchar](50) NOT NULL,
	[fecha_cotizacion] [date] NOT NULL,
	[precio_cotizado] [decimal](18, 0) NOT NULL,
	[cod_pro_buso] [int] NOT NULL,
 CONSTRAINT [PK_cotizacion_solicitud_compra_1] PRIMARY KEY CLUSTERED 
(
	[cod_cotizacion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cuenta_corriente_proveedor]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cuenta_corriente_proveedor](
	[cod_cuenta_corriente] [int] IDENTITY(1,1) NOT NULL,
	[cod_proveedor] [int] NOT NULL,
	[debe] [decimal](18, 0) NOT NULL,
	[haber] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_cuenta_corriente_proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_cuenta_corriente] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_direccion]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_direccion](
	[cod_dir] [int] IDENTITY(1,1) NOT NULL,
	[cod_ciu] [int] NOT NULL,
	[calle] [varchar](50) NOT NULL,
	[numero] [varchar](50) NOT NULL,
	[esquina] [varchar](50) NOT NULL,
 CONSTRAINT [PK_1_direccion] PRIMARY KEY CLUSTERED 
(
	[cod_dir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_empleado]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_empleado](
	[cod_emp] [int] IDENTITY(1,1) NOT NULL,
	[nom_emp] [varchar](30) NOT NULL,
	[ape_emp] [varchar](30) NOT NULL,
	[dni_emp] [int] NOT NULL,
 CONSTRAINT [PK_empleado] PRIMARY KEY CLUSTERED 
(
	[cod_emp] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_factura_proveedor]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_factura_proveedor](
	[cod_factura] [int] IDENTITY(1,1) NOT NULL,
	[cod_ord_cpr] [int] NOT NULL,
	[numero_factura] [int] NOT NULL,
	[fecha_recepcion] [date] NOT NULL,
	[importe] [decimal](18, 0) NOT NULL,
	[observaciones] [varchar](500) NULL,
	[sumada] [bit] NOT NULL,
 CONSTRAINT [PK_factura_proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_informe_recepcion]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_informe_recepcion](
	[cod_ir] [int] IDENTITY(1,1) NOT NULL,
	[cod_ord_cpr] [int] NOT NULL,
	[cod_factura] [int] NOT NULL,
	[cod_pd] [int] NULL,
	[cod_nc] [int] NULL,
	[numero_remito] [int] NOT NULL,
	[resultado_calidad] [varchar](15) NOT NULL,
	[problemas] [varchar](500) NULL,
	[estado_pd] [varchar](100) NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_informe_recepcion] PRIMARY KEY CLUSTERED 
(
	[cod_ir] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_marca]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_marca](
	[cod_mar] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_marca] PRIMARY KEY CLUSTERED 
(
	[cod_mar] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_marca_buso]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_marca_buso](
	[cod_mar] [int] NOT NULL,
	[cod_pro_buso] [int] NOT NULL,
 CONSTRAINT [PK_marca_buso] PRIMARY KEY CLUSTERED 
(
	[cod_mar] ASC,
	[cod_pro_buso] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_medida]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_medida](
	[cod_med] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[cod_cat] [int] NOT NULL,
 CONSTRAINT [PK_medida] PRIMARY KEY CLUSTERED 
(
	[cod_med] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_nota_credito]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_nota_credito](
	[cod_nc] [int] IDENTITY(1,1) NOT NULL,
	[cod_pd] [int] NOT NULL,
	[importe] [decimal](18, 0) NOT NULL,
	[detalle] [varchar](500) NULL,
	[sumado] [bit] NOT NULL,
 CONSTRAINT [PK_nota_credito] PRIMARY KEY CLUSTERED 
(
	[cod_nc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_orden_compra]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_orden_compra](
	[cod_ord_cpr] [int] IDENTITY(1,1) NOT NULL,
	[emitido] [bit] NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[tipo] [varchar](2) NOT NULL,
 CONSTRAINT [PK_orden_compra] PRIMARY KEY CLUSTERED 
(
	[cod_ord_cpr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_pedido_devolucion]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_pedido_devolucion](
	[cod_pd] [int] IDENTITY(1,1) NOT NULL,
	[cod_ir] [int] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_pedido_devolucion] PRIMARY KEY CLUSTERED 
(
	[cod_pd] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_pedido_reaprovisionamiento]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_pedido_reaprovisionamiento](
	[cod_pr] [int] IDENTITY(1,1) NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[cancelado] [bit] NOT NULL,
	[automatizado] [bit] NOT NULL,
 CONSTRAINT [PK_pedido_reaprovisionamiento] PRIMARY KEY CLUSTERED 
(
	[cod_pr] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_proveedor]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_proveedor](
	[cod_proveedor] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[numero_telefono] [varchar](50) NOT NULL,
	[cod_dir] [int] NOT NULL,
	[cp] [int] NOT NULL,
	[email] [varchar](100) NOT NULL,
	[razon_social] [varchar](50) NOT NULL,
 CONSTRAINT [PK_proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_proveedor] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_provincia]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_provincia](
	[cod_provincia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
 CONSTRAINT [PK_1_provincia] PRIMARY KEY CLUSTERED 
(
	[cod_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_registracion]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_registracion](
	[cod_reg] [int] IDENTITY(1,1) NOT NULL,
	[cod_ir] [int] NOT NULL,
	[fecha_reg] [date] NOT NULL,
 CONSTRAINT [PK_registracion] PRIMARY KEY CLUSTERED 
(
	[cod_reg] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_rol]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_rol](
	[cod_rol] [int] IDENTITY(1,1) NOT NULL,
	[rol] [varchar](50) NOT NULL,
 CONSTRAINT [PK_rol] PRIMARY KEY CLUSTERED 
(
	[cod_rol] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_solicitud_compra]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_solicitud_compra](
	[cod_sc] [int] IDENTITY(1,1) NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[departamento] [varchar](50) NULL,
	[cancelado] [bit] NOT NULL,
 CONSTRAINT [PK_solicitud_compra] PRIMARY KEY CLUSTERED 
(
	[cod_sc] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_stock]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_stock](
	[cod_pro_stock] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[stk_act] [int] NOT NULL,
	[stk_opt] [int] NOT NULL,
	[stk_cri] [int] NOT NULL,
	[cod_cat] [int] NOT NULL,
	[precio] [decimal](18, 2) NULL,
 CONSTRAINT [PK_stock] PRIMARY KEY CLUSTERED 
(
	[cod_pro_stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_stock_marca]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_stock_marca](
	[cod_mar] [int] NOT NULL,
	[cod_pro_stock] [int] NOT NULL,
 CONSTRAINT [PK_marca_stock] PRIMARY KEY CLUSTERED 
(
	[cod_mar] ASC,
	[cod_pro_stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_stock_medida]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_stock_medida](
	[cod_med] [int] NOT NULL,
	[cod_pro_stock] [int] NOT NULL,
 CONSTRAINT [PK_stock_medida] PRIMARY KEY CLUSTERED 
(
	[cod_med] ASC,
	[cod_pro_stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_stock_pr]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_stock_pr](
	[cod_pr] [int] NOT NULL,
	[cod_pro_stock] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_stock_pr] PRIMARY KEY CLUSTERED 
(
	[cod_pr] ASC,
	[cod_pro_stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_stock_proveedor]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_stock_proveedor](
	[cod_proveedor] [int] NOT NULL,
	[cod_pro_stock] [int] NOT NULL,
 CONSTRAINT [PK_stock_proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_proveedor] ASC,
	[cod_pro_stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_usuario]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_usuario](
	[cod_usu] [int] IDENTITY(1,1) NOT NULL,
	[cod_emp] [int] NOT NULL,
	[nom_usu] [varchar](20) NOT NULL,
	[psw_usu] [varchar](20) NOT NULL,
	[fecha_alta_usu] [date] NULL,
	[cuenta_activa_usu] [bit] NOT NULL,
 CONSTRAINT [PK_usuario] PRIMARY KEY CLUSTERED 
(
	[cod_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_usuario_rol]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_usuario_rol](
	[cod_rol] [int] NOT NULL,
	[cod_usu] [int] NOT NULL,
 CONSTRAINT [PK_usuario_rol] PRIMARY KEY CLUSTERED 
(
	[cod_rol] ASC,
	[cod_usu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2_cuenta_bancaria_empresa]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2_cuenta_bancaria_empresa](
	[cod_cuenta_bancaria] [int] IDENTITY(1,1) NOT NULL,
	[cbu] [decimal](25, 0) NOT NULL,
	[saldo] [decimal](18, 2) NOT NULL,
 CONSTRAINT [PK_2_cuenta_bancaria_empresa] PRIMARY KEY CLUSTERED 
(
	[cod_cuenta_bancaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2_orden_pago]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2_orden_pago](
	[cod_orden_pago] [int] IDENTITY(1,1) NOT NULL,
	[cod_factura] [int] NOT NULL,
	[cod_proveedor] [int] NOT NULL,
	[cod_banco_proveedor] [int] NOT NULL,
	[cod_cuenta_bancaria] [int] NULL,
	[debitada] [bit] NOT NULL,
	[aceptada_pago] [bit] NOT NULL,
	[observaciones] [varchar](500) NULL,
 CONSTRAINT [PK_2_orden_pago] PRIMARY KEY CLUSTERED 
(
	[cod_orden_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2_registracion_debito]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2_registracion_debito](
	[cod_registracion] [int] IDENTITY(1,1) NOT NULL,
	[cod_orden_pago] [int] NOT NULL,
	[fecha_registracion] [date] NOT NULL,
 CONSTRAINT [PK_2_registracion_debito] PRIMARY KEY CLUSTERED 
(
	[cod_registracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_cliente]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_cliente](
	[cod_cli] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [varchar](50) NOT NULL,
	[apellido] [varchar](50) NOT NULL,
	[cod_dir] [int] NOT NULL,
	[telefono] [varchar](50) NOT NULL,
 CONSTRAINT [PK_3_cliente] PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_cuenta_corriente_cliente]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_cuenta_corriente_cliente](
	[cod_cta_cli] [int] IDENTITY(1,1) NOT NULL,
	[cod_cli] [int] NOT NULL,
	[debe] [decimal](18, 0) NOT NULL,
	[haber] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_3_cuenta_corriente_cliente] PRIMARY KEY CLUSTERED 
(
	[cod_cta_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_devolucion_venta]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_devolucion_venta](
	[cod_dev_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_rem_vent] [int] NOT NULL,
	[cod_pro_stock] [int] NOT NULL,
	[problemas] [varchar](500) NOT NULL,
	[estado] [varchar](100) NOT NULL,
	[fecha_creacion] [date] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_3_devolucion_venta] PRIMARY KEY CLUSTERED 
(
	[cod_dev_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_factura_venta]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_factura_venta](
	[cod_fac_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_rem_vent] [int] NOT NULL,
	[importe] [decimal](18, 0) NOT NULL,
	[observaciones] [varchar](500) NULL,
	[sumada] [bit] NOT NULL,
 CONSTRAINT [PK_3_factura_venta] PRIMARY KEY CLUSTERED 
(
	[cod_fac_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_lista_precios]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_lista_precios](
	[cod_pro_stock] [int] NOT NULL,
	[precio] [int] NOT NULL,
 CONSTRAINT [PK_3_lista_precios] PRIMARY KEY CLUSTERED 
(
	[cod_pro_stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_nota_credito_cliente]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_nota_credito_cliente](
	[cod_nc_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_dev_vent] [int] NOT NULL,
	[sumado] [bit] NOT NULL,
	[importe] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_3_nota_credito_cliente] PRIMARY KEY CLUSTERED 
(
	[cod_nc_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_pedido_venta]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_pedido_venta](
	[cod_ped_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_cli] [int] NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[procesado] [bit] NOT NULL,
 CONSTRAINT [PK_3_pedido_venta] PRIMARY KEY CLUSTERED 
(
	[cod_ped_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_registracion_venta]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_registracion_venta](
	[cod_reg_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_fac_vent] [int] NULL,
	[cod_nc_vent] [int] NULL,
	[cod_cta_cli] [int] NOT NULL,
 CONSTRAINT [PK_3_registracion_venta] PRIMARY KEY CLUSTERED 
(
	[cod_reg_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_remito_venta]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_remito_venta](
	[cod_rem_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_ped_vent] [int] NOT NULL,
	[observaciones] [varchar](500) NULL,
	[es_devolucion] [bit] NOT NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_3_remito_venta] PRIMARY KEY CLUSTERED 
(
	[cod_rem_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_stock_venta]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_stock_venta](
	[cod_pro_stock] [int] NOT NULL,
	[cod_ped_vent] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
 CONSTRAINT [PK_3_stock_venta] PRIMARY KEY CLUSTERED 
(
	[cod_pro_stock] ASC,
	[cod_ped_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[4_confirmacion_cobro]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[4_confirmacion_cobro](
	[cod_con_cob] [int] IDENTITY(1,1) NOT NULL,
	[cod_fac_vent] [int] NOT NULL,
	[cod_cuenta_bancaria] [int] NOT NULL,
	[fecha_debitacion] [date] NOT NULL,
	[importe_recibido] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_4_confirmacion_cobro] PRIMARY KEY CLUSTERED 
(
	[cod_con_cob] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[4_registracion_monetaria]    Script Date: 17/10/2019 16:57:56 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[4_registracion_monetaria](
	[cod_registracion] [int] IDENTITY(1,1) NOT NULL,
	[cod_con_cob] [int] NOT NULL,
	[fecha_registracion] [date] NOT NULL,
 CONSTRAINT [PK_4_registracion_monetaria] PRIMARY KEY CLUSTERED 
(
	[cod_registracion] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
SET IDENTITY_INSERT [dbo].[1_categoria] ON 

INSERT [dbo].[1_categoria] ([cod_cat], [nombre]) VALUES (1, N'Libreria')
SET IDENTITY_INSERT [dbo].[1_categoria] OFF
SET IDENTITY_INSERT [dbo].[1_cbu_proveedor] ON 

INSERT [dbo].[1_cbu_proveedor] ([cod_proveedor], [cod_cbu], [cbu]) VALUES (12, 1, CAST(48486468468 AS Decimal(25, 0)))
INSERT [dbo].[1_cbu_proveedor] ([cod_proveedor], [cod_cbu], [cbu]) VALUES (12, 2, CAST(56651161516 AS Decimal(25, 0)))
SET IDENTITY_INSERT [dbo].[1_cbu_proveedor] OFF
SET IDENTITY_INSERT [dbo].[1_ciudad] ON 

INSERT [dbo].[1_ciudad] ([cod_ciu], [cod_provincia], [nombre], [codigo_postal]) VALUES (1, 1, N'Glew', N'1856')
SET IDENTITY_INSERT [dbo].[1_ciudad] OFF
SET IDENTITY_INSERT [dbo].[1_cotizacion_pedido_reaprovisionamiento] ON 

INSERT [dbo].[1_cotizacion_pedido_reaprovisionamiento] ([cod_cotizacion], [cod_pro_stock], [cod_pr], [tiempo_entrega], [fecha_cotizacion], [precio_cotizado]) VALUES (3, 1, 1, N'20 dias', CAST(N'2019-05-04' AS Date), CAST(15 AS Decimal(18, 0)))
INSERT [dbo].[1_cotizacion_pedido_reaprovisionamiento] ([cod_cotizacion], [cod_pro_stock], [cod_pr], [tiempo_entrega], [fecha_cotizacion], [precio_cotizado]) VALUES (5, 1, 1, N'31 dias', CAST(N'2019-05-05' AS Date), CAST(14 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[1_cotizacion_pedido_reaprovisionamiento] OFF
INSERT [dbo].[1_cotizacion_pr] ([cod_cotizacion], [cod_proveedor]) VALUES (3, 12)
INSERT [dbo].[1_cotizacion_pr] ([cod_cotizacion], [cod_proveedor]) VALUES (5, 12)
INSERT [dbo].[1_cotizacion_pr_oc] ([cod_cotizacion], [cod_ord_cpr]) VALUES (3, 1)
INSERT [dbo].[1_cotizacion_pr_oc] ([cod_cotizacion], [cod_ord_cpr]) VALUES (5, 2)
SET IDENTITY_INSERT [dbo].[1_direccion] ON 

INSERT [dbo].[1_direccion] ([cod_dir], [cod_ciu], [calle], [numero], [esquina]) VALUES (15, 1, N'Gondolin', N'442', N'Gral Finwe')
INSERT [dbo].[1_direccion] ([cod_dir], [cod_ciu], [calle], [numero], [esquina]) VALUES (16, 1, N'borrar', N'borrar', N'borrar')
INSERT [dbo].[1_direccion] ([cod_dir], [cod_ciu], [calle], [numero], [esquina]) VALUES (17, 1, N'borrar', N'borrar', N'borrar')
INSERT [dbo].[1_direccion] ([cod_dir], [cod_ciu], [calle], [numero], [esquina]) VALUES (1002, 1, N'Jeropa', N'666', N'Lavalle')
INSERT [dbo].[1_direccion] ([cod_dir], [cod_ciu], [calle], [numero], [esquina]) VALUES (1003, 1, N'etcetc', N'4512', N'4')
SET IDENTITY_INSERT [dbo].[1_direccion] OFF
SET IDENTITY_INSERT [dbo].[1_empleado] ON 

INSERT [dbo].[1_empleado] ([cod_emp], [nom_emp], [ape_emp], [dni_emp]) VALUES (1, N'leon', N'juarez', 34500123)
SET IDENTITY_INSERT [dbo].[1_empleado] OFF
SET IDENTITY_INSERT [dbo].[1_factura_proveedor] ON 

INSERT [dbo].[1_factura_proveedor] ([cod_factura], [cod_ord_cpr], [numero_factura], [fecha_recepcion], [importe], [observaciones], [sumada]) VALUES (1, 1, 15, CAST(N'2006-06-15' AS Date), CAST(1500 AS Decimal(18, 0)), NULL, 1)
SET IDENTITY_INSERT [dbo].[1_factura_proveedor] OFF
SET IDENTITY_INSERT [dbo].[1_marca] ON 

INSERT [dbo].[1_marca] ([cod_mar], [nombre]) VALUES (1, N'Garcia')
SET IDENTITY_INSERT [dbo].[1_marca] OFF
SET IDENTITY_INSERT [dbo].[1_medida] ON 

INSERT [dbo].[1_medida] ([cod_med], [nombre], [cod_cat]) VALUES (1, N'superfina', 1)
SET IDENTITY_INSERT [dbo].[1_medida] OFF
SET IDENTITY_INSERT [dbo].[1_orden_compra] ON 

INSERT [dbo].[1_orden_compra] ([cod_ord_cpr], [emitido], [fecha_emision], [tipo]) VALUES (1, 1, CAST(N'2019-09-09' AS Date), N'pr')
INSERT [dbo].[1_orden_compra] ([cod_ord_cpr], [emitido], [fecha_emision], [tipo]) VALUES (2, 1, CAST(N'2019-09-07' AS Date), N'pr')
INSERT [dbo].[1_orden_compra] ([cod_ord_cpr], [emitido], [fecha_emision], [tipo]) VALUES (4, 1, CAST(N'2019-08-01' AS Date), N'pr')
SET IDENTITY_INSERT [dbo].[1_orden_compra] OFF
SET IDENTITY_INSERT [dbo].[1_pedido_reaprovisionamiento] ON 

INSERT [dbo].[1_pedido_reaprovisionamiento] ([cod_pr], [fecha_emision], [cancelado], [automatizado]) VALUES (1, CAST(N'2019-05-05' AS Date), 0, 0)
SET IDENTITY_INSERT [dbo].[1_pedido_reaprovisionamiento] OFF
SET IDENTITY_INSERT [dbo].[1_proveedor] ON 

INSERT [dbo].[1_proveedor] ([cod_proveedor], [nombre], [numero_telefono], [cod_dir], [cp], [email], [razon_social]) VALUES (12, N'Recimplax', N'4260-2999', 15, 1233, N'peronas@socialismo.ar', N'129831')
SET IDENTITY_INSERT [dbo].[1_proveedor] OFF
SET IDENTITY_INSERT [dbo].[1_provincia] ON 

INSERT [dbo].[1_provincia] ([cod_provincia], [nombre]) VALUES (1, N'Buenos Aires')
SET IDENTITY_INSERT [dbo].[1_provincia] OFF
SET IDENTITY_INSERT [dbo].[1_rol] ON 

INSERT [dbo].[1_rol] ([cod_rol], [rol]) VALUES (1, N'panadero')
SET IDENTITY_INSERT [dbo].[1_rol] OFF
SET IDENTITY_INSERT [dbo].[1_stock] ON 

INSERT [dbo].[1_stock] ([cod_pro_stock], [nombre], [stk_act], [stk_opt], [stk_cri], [cod_cat], [precio]) VALUES (1, N'Lapiceras', 199, 40, 30, 1, CAST(29.25 AS Decimal(18, 2)))
INSERT [dbo].[1_stock] ([cod_pro_stock], [nombre], [stk_act], [stk_opt], [stk_cri], [cod_cat], [precio]) VALUES (2, N'Lapices', 200, 12, 13, 1, NULL)
SET IDENTITY_INSERT [dbo].[1_stock] OFF
INSERT [dbo].[1_stock_marca] ([cod_mar], [cod_pro_stock]) VALUES (1, 1)
INSERT [dbo].[1_stock_marca] ([cod_mar], [cod_pro_stock]) VALUES (1, 2)
INSERT [dbo].[1_stock_medida] ([cod_med], [cod_pro_stock]) VALUES (1, 1)
INSERT [dbo].[1_stock_pr] ([cod_pr], [cod_pro_stock], [cantidad]) VALUES (1, 1, 200)
SET IDENTITY_INSERT [dbo].[1_usuario] ON 

INSERT [dbo].[1_usuario] ([cod_usu], [cod_emp], [nom_usu], [psw_usu], [fecha_alta_usu], [cuenta_activa_usu]) VALUES (7, 1, N'nacho', N'123', CAST(N'2016-06-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[1_usuario] OFF
INSERT [dbo].[1_usuario_rol] ([cod_rol], [cod_usu]) VALUES (1, 7)
SET IDENTITY_INSERT [dbo].[2_cuenta_bancaria_empresa] ON 

INSERT [dbo].[2_cuenta_bancaria_empresa] ([cod_cuenta_bancaria], [cbu], [saldo]) VALUES (1, CAST(564654 AS Decimal(25, 0)), CAST(250000.00 AS Decimal(18, 2)))
INSERT [dbo].[2_cuenta_bancaria_empresa] ([cod_cuenta_bancaria], [cbu], [saldo]) VALUES (2, CAST(4684684864 AS Decimal(25, 0)), CAST(2750.00 AS Decimal(18, 2)))
SET IDENTITY_INSERT [dbo].[2_cuenta_bancaria_empresa] OFF
SET IDENTITY_INSERT [dbo].[2_orden_pago] ON 

INSERT [dbo].[2_orden_pago] ([cod_orden_pago], [cod_factura], [cod_proveedor], [cod_banco_proveedor], [cod_cuenta_bancaria], [debitada], [aceptada_pago], [observaciones]) VALUES (3, 1, 12, 2, NULL, 0, 0, N'Jujuy Revival')
SET IDENTITY_INSERT [dbo].[2_orden_pago] OFF
SET IDENTITY_INSERT [dbo].[3_cliente] ON 

INSERT [dbo].[3_cliente] ([cod_cli], [nombre], [apellido], [cod_dir], [telefono]) VALUES (3, N'Etchelion', N'De la fuente', 15, N'300400')
INSERT [dbo].[3_cliente] ([cod_cli], [nombre], [apellido], [cod_dir], [telefono]) VALUES (6, N'Carlos', N'Calves', 15, N'0')
SET IDENTITY_INSERT [dbo].[3_cliente] OFF
SET IDENTITY_INSERT [dbo].[3_cuenta_corriente_cliente] ON 

INSERT [dbo].[3_cuenta_corriente_cliente] ([cod_cta_cli], [cod_cli], [debe], [haber]) VALUES (1, 3, CAST(-444 AS Decimal(18, 0)), CAST(5448 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[3_cuenta_corriente_cliente] OFF
SET IDENTITY_INSERT [dbo].[3_devolucion_venta] ON 

INSERT [dbo].[3_devolucion_venta] ([cod_dev_vent], [cod_rem_vent], [cod_pro_stock], [problemas], [estado], [fecha_creacion], [cantidad]) VALUES (4, 4, 1, N'La verdad es que me gustaron pero quiero mas y gratis.', N'Nota de credito por sumar', CAST(N'2019-10-03' AS Date), 25)
INSERT [dbo].[3_devolucion_venta] ([cod_dev_vent], [cod_rem_vent], [cod_pro_stock], [problemas], [estado], [fecha_creacion], [cantidad]) VALUES (5, 7, 1, N'Vinieron sin tinta', N'Devolucion por producto', CAST(N'2019-10-03' AS Date), 50)
SET IDENTITY_INSERT [dbo].[3_devolucion_venta] OFF
SET IDENTITY_INSERT [dbo].[3_factura_venta] ON 

INSERT [dbo].[3_factura_venta] ([cod_fac_vent], [cod_rem_vent], [importe], [observaciones], [sumada]) VALUES (2, 8, CAST(5348 AS Decimal(18, 0)), N'En jerusalem los puntos flotantes son "." y no ","', 1)
INSERT [dbo].[3_factura_venta] ([cod_fac_vent], [cod_rem_vent], [importe], [observaciones], [sumada]) VALUES (3, 7, CAST(5348 AS Decimal(18, 0)), N'Este precio debería tener una coma flotante y no lo veo.', 0)
INSERT [dbo].[3_factura_venta] ([cod_fac_vent], [cod_rem_vent], [importe], [observaciones], [sumada]) VALUES (4, 4, CAST(6728 AS Decimal(18, 0)), N'Creando factura', 0)
SET IDENTITY_INSERT [dbo].[3_factura_venta] OFF
SET IDENTITY_INSERT [dbo].[3_nota_credito_cliente] ON 

INSERT [dbo].[3_nota_credito_cliente] ([cod_nc_vent], [cod_dev_vent], [sumado], [importe]) VALUES (1002, 4, 1, CAST(731 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[3_nota_credito_cliente] OFF
SET IDENTITY_INSERT [dbo].[3_pedido_venta] ON 

INSERT [dbo].[3_pedido_venta] ([cod_ped_vent], [cod_cli], [fecha_emision], [procesado]) VALUES (26, 3, CAST(N'2019-09-19' AS Date), 0)
SET IDENTITY_INSERT [dbo].[3_pedido_venta] OFF
SET IDENTITY_INSERT [dbo].[3_registracion_venta] ON 

INSERT [dbo].[3_registracion_venta] ([cod_reg_vent], [cod_fac_vent], [cod_nc_vent], [cod_cta_cli]) VALUES (1, NULL, 1002, 1)
INSERT [dbo].[3_registracion_venta] ([cod_reg_vent], [cod_fac_vent], [cod_nc_vent], [cod_cta_cli]) VALUES (2, NULL, 1002, 1)
INSERT [dbo].[3_registracion_venta] ([cod_reg_vent], [cod_fac_vent], [cod_nc_vent], [cod_cta_cli]) VALUES (3, NULL, 1002, 1)
INSERT [dbo].[3_registracion_venta] ([cod_reg_vent], [cod_fac_vent], [cod_nc_vent], [cod_cta_cli]) VALUES (4, 2, NULL, 1)
SET IDENTITY_INSERT [dbo].[3_registracion_venta] OFF
SET IDENTITY_INSERT [dbo].[3_remito_venta] ON 

INSERT [dbo].[3_remito_venta] ([cod_rem_vent], [cod_ped_vent], [observaciones], [es_devolucion], [fecha_creacion]) VALUES (4, 26, N'Lindo el culiado', 0, CAST(N'2019-09-25' AS Date))
INSERT [dbo].[3_remito_venta] ([cod_rem_vent], [cod_ped_vent], [observaciones], [es_devolucion], [fecha_creacion]) VALUES (5, 26, N'65656', 0, CAST(N'2019-09-28' AS Date))
INSERT [dbo].[3_remito_venta] ([cod_rem_vent], [cod_ped_vent], [observaciones], [es_devolucion], [fecha_creacion]) VALUES (6, 26, N'956235', 0, CAST(N'2019-09-28' AS Date))
INSERT [dbo].[3_remito_venta] ([cod_rem_vent], [cod_ped_vent], [observaciones], [es_devolucion], [fecha_creacion]) VALUES (7, 26, N'putamater', 0, CAST(N'2019-09-28' AS Date))
INSERT [dbo].[3_remito_venta] ([cod_rem_vent], [cod_ped_vent], [observaciones], [es_devolucion], [fecha_creacion]) VALUES (8, 26, N'Jerusalem', 0, CAST(N'2019-09-28' AS Date))
INSERT [dbo].[3_remito_venta] ([cod_rem_vent], [cod_ped_vent], [observaciones], [es_devolucion], [fecha_creacion]) VALUES (9, 26, N'No le gusto pero quiere un par nuevos para ver si esta vez le caben', 1, CAST(N'2019-09-28' AS Date))
INSERT [dbo].[3_remito_venta] ([cod_rem_vent], [cod_ped_vent], [observaciones], [es_devolucion], [fecha_creacion]) VALUES (10, 26, N'No le gusto pero quiere unos nuevos a ver si le caben ahora.', 1, CAST(N'2019-09-28' AS Date))
SET IDENTITY_INSERT [dbo].[3_remito_venta] OFF
INSERT [dbo].[3_stock_venta] ([cod_pro_stock], [cod_ped_vent], [cantidad]) VALUES (1, 26, 230)
SET IDENTITY_INSERT [dbo].[4_confirmacion_cobro] ON 

INSERT [dbo].[4_confirmacion_cobro] ([cod_con_cob], [cod_fac_vent], [cod_cuenta_bancaria], [fecha_debitacion], [importe_recibido]) VALUES (1, 2, 2, CAST(N'2019-02-12' AS Date), CAST(500 AS Decimal(18, 0)))
INSERT [dbo].[4_confirmacion_cobro] ([cod_con_cob], [cod_fac_vent], [cod_cuenta_bancaria], [fecha_debitacion], [importe_recibido]) VALUES (3, 2, 2, CAST(N'2019-02-11' AS Date), CAST(700 AS Decimal(18, 0)))
SET IDENTITY_INSERT [dbo].[4_confirmacion_cobro] OFF
SET IDENTITY_INSERT [dbo].[4_registracion_monetaria] ON 

INSERT [dbo].[4_registracion_monetaria] ([cod_registracion], [cod_con_cob], [fecha_registracion]) VALUES (1, 1, CAST(N'2002-05-13' AS Date))
INSERT [dbo].[4_registracion_monetaria] ([cod_registracion], [cod_con_cob], [fecha_registracion]) VALUES (2, 3, CAST(N'2019-10-15' AS Date))
SET IDENTITY_INSERT [dbo].[4_registracion_monetaria] OFF
ALTER TABLE [dbo].[1_buso_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_buso_proveedor_bien_uso] FOREIGN KEY([cod_pro_buso])
REFERENCES [dbo].[1_bien_uso] ([cod_pro_buso])
GO
ALTER TABLE [dbo].[1_buso_proveedor] CHECK CONSTRAINT [FK_buso_proveedor_bien_uso]
GO
ALTER TABLE [dbo].[1_buso_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_buso_proveedor_proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[1_proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[1_buso_proveedor] CHECK CONSTRAINT [FK_buso_proveedor_proveedor]
GO
ALTER TABLE [dbo].[1_buso_sc]  WITH CHECK ADD  CONSTRAINT [FK_buso_sc_bien_uso] FOREIGN KEY([cod_pro_buso])
REFERENCES [dbo].[1_bien_uso] ([cod_pro_buso])
GO
ALTER TABLE [dbo].[1_buso_sc] CHECK CONSTRAINT [FK_buso_sc_bien_uso]
GO
ALTER TABLE [dbo].[1_buso_sc]  WITH CHECK ADD  CONSTRAINT [FK_buso_sc_solicitud_compra] FOREIGN KEY([cod_sc])
REFERENCES [dbo].[1_solicitud_compra] ([cod_sc])
GO
ALTER TABLE [dbo].[1_buso_sc] CHECK CONSTRAINT [FK_buso_sc_solicitud_compra]
GO
ALTER TABLE [dbo].[1_cbu_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_1_cbu_proveedor_1_proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[1_proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[1_cbu_proveedor] CHECK CONSTRAINT [FK_1_cbu_proveedor_1_proveedor]
GO
ALTER TABLE [dbo].[1_ciudad]  WITH CHECK ADD  CONSTRAINT [FK_1_ciudad_1_provincia] FOREIGN KEY([cod_provincia])
REFERENCES [dbo].[1_provincia] ([cod_provincia])
GO
ALTER TABLE [dbo].[1_ciudad] CHECK CONSTRAINT [FK_1_ciudad_1_provincia]
GO
ALTER TABLE [dbo].[1_cotizacion_pedido_reaprovisionamiento]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_pedido_reaprovisionamiento_1_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[1_cotizacion_pedido_reaprovisionamiento] CHECK CONSTRAINT [FK_1_cotizacion_pedido_reaprovisionamiento_1_stock]
GO
ALTER TABLE [dbo].[1_cotizacion_pedido_reaprovisionamiento]  WITH CHECK ADD  CONSTRAINT [FK_cotizacion_pedido_reaprovisionamiento_pedido_reaprovisionamiento] FOREIGN KEY([cod_pr])
REFERENCES [dbo].[1_pedido_reaprovisionamiento] ([cod_pr])
GO
ALTER TABLE [dbo].[1_cotizacion_pedido_reaprovisionamiento] CHECK CONSTRAINT [FK_cotizacion_pedido_reaprovisionamiento_pedido_reaprovisionamiento]
GO
ALTER TABLE [dbo].[1_cotizacion_pr]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_pr_1_cotizacion_pedido_reaprovisionamiento] FOREIGN KEY([cod_cotizacion])
REFERENCES [dbo].[1_cotizacion_pedido_reaprovisionamiento] ([cod_cotizacion])
GO
ALTER TABLE [dbo].[1_cotizacion_pr] CHECK CONSTRAINT [FK_1_cotizacion_pr_1_cotizacion_pedido_reaprovisionamiento]
GO
ALTER TABLE [dbo].[1_cotizacion_pr]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_pr_1_proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[1_proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[1_cotizacion_pr] CHECK CONSTRAINT [FK_1_cotizacion_pr_1_proveedor]
GO
ALTER TABLE [dbo].[1_cotizacion_pr_oc]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_pr_oc_1_cotizacion_pedido_reaprovisionamiento] FOREIGN KEY([cod_cotizacion])
REFERENCES [dbo].[1_cotizacion_pedido_reaprovisionamiento] ([cod_cotizacion])
GO
ALTER TABLE [dbo].[1_cotizacion_pr_oc] CHECK CONSTRAINT [FK_1_cotizacion_pr_oc_1_cotizacion_pedido_reaprovisionamiento]
GO
ALTER TABLE [dbo].[1_cotizacion_pr_oc]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_pr_oc_1_orden_compra] FOREIGN KEY([cod_ord_cpr])
REFERENCES [dbo].[1_orden_compra] ([cod_ord_cpr])
GO
ALTER TABLE [dbo].[1_cotizacion_pr_oc] CHECK CONSTRAINT [FK_1_cotizacion_pr_oc_1_orden_compra]
GO
ALTER TABLE [dbo].[1_cotizacion_sc]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_sc_1_cotizacion_solicitud_compra] FOREIGN KEY([cod_cotizacion])
REFERENCES [dbo].[1_cotizacion_solicitud_compra] ([cod_cotizacion])
GO
ALTER TABLE [dbo].[1_cotizacion_sc] CHECK CONSTRAINT [FK_1_cotizacion_sc_1_cotizacion_solicitud_compra]
GO
ALTER TABLE [dbo].[1_cotizacion_sc]  WITH CHECK ADD  CONSTRAINT [FK_cotizacion_proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[1_proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[1_cotizacion_sc] CHECK CONSTRAINT [FK_cotizacion_proveedor]
GO
ALTER TABLE [dbo].[1_cotizacion_sc_oc]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_sc_oc_1_cotizacion_solicitud_compra] FOREIGN KEY([cod_cotizacion])
REFERENCES [dbo].[1_cotizacion_solicitud_compra] ([cod_cotizacion])
GO
ALTER TABLE [dbo].[1_cotizacion_sc_oc] CHECK CONSTRAINT [FK_1_cotizacion_sc_oc_1_cotizacion_solicitud_compra]
GO
ALTER TABLE [dbo].[1_cotizacion_sc_oc]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_sc_oc_1_orden_compra] FOREIGN KEY([cod_ord_cpr])
REFERENCES [dbo].[1_orden_compra] ([cod_ord_cpr])
GO
ALTER TABLE [dbo].[1_cotizacion_sc_oc] CHECK CONSTRAINT [FK_1_cotizacion_sc_oc_1_orden_compra]
GO
ALTER TABLE [dbo].[1_cotizacion_solicitud_compra]  WITH CHECK ADD  CONSTRAINT [FK_1_cotizacion_solicitud_compra_1_bien_uso] FOREIGN KEY([cod_pro_buso])
REFERENCES [dbo].[1_bien_uso] ([cod_pro_buso])
GO
ALTER TABLE [dbo].[1_cotizacion_solicitud_compra] CHECK CONSTRAINT [FK_1_cotizacion_solicitud_compra_1_bien_uso]
GO
ALTER TABLE [dbo].[1_cotizacion_solicitud_compra]  WITH CHECK ADD  CONSTRAINT [FK_cotizacion_solicitud_compra_solicitud_compra] FOREIGN KEY([cod_sc])
REFERENCES [dbo].[1_solicitud_compra] ([cod_sc])
GO
ALTER TABLE [dbo].[1_cotizacion_solicitud_compra] CHECK CONSTRAINT [FK_cotizacion_solicitud_compra_solicitud_compra]
GO
ALTER TABLE [dbo].[1_cuenta_corriente_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_cuenta_corriente_proveedor_proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[1_proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[1_cuenta_corriente_proveedor] CHECK CONSTRAINT [FK_cuenta_corriente_proveedor_proveedor]
GO
ALTER TABLE [dbo].[1_direccion]  WITH CHECK ADD  CONSTRAINT [FK_1_direccion_1_ciudad] FOREIGN KEY([cod_ciu])
REFERENCES [dbo].[1_ciudad] ([cod_ciu])
GO
ALTER TABLE [dbo].[1_direccion] CHECK CONSTRAINT [FK_1_direccion_1_ciudad]
GO
ALTER TABLE [dbo].[1_factura_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_factura_proveedor_orden_compra] FOREIGN KEY([cod_ord_cpr])
REFERENCES [dbo].[1_orden_compra] ([cod_ord_cpr])
GO
ALTER TABLE [dbo].[1_factura_proveedor] CHECK CONSTRAINT [FK_factura_proveedor_orden_compra]
GO
ALTER TABLE [dbo].[1_informe_recepcion]  WITH CHECK ADD  CONSTRAINT [FK_1_informe_recepcion_1_orden_compra] FOREIGN KEY([cod_ord_cpr])
REFERENCES [dbo].[1_orden_compra] ([cod_ord_cpr])
GO
ALTER TABLE [dbo].[1_informe_recepcion] CHECK CONSTRAINT [FK_1_informe_recepcion_1_orden_compra]
GO
ALTER TABLE [dbo].[1_informe_recepcion]  WITH CHECK ADD  CONSTRAINT [FK_informe_recepcion_factura_proveedor] FOREIGN KEY([cod_factura])
REFERENCES [dbo].[1_factura_proveedor] ([cod_factura])
GO
ALTER TABLE [dbo].[1_informe_recepcion] CHECK CONSTRAINT [FK_informe_recepcion_factura_proveedor]
GO
ALTER TABLE [dbo].[1_informe_recepcion]  WITH CHECK ADD  CONSTRAINT [FK_informe_recepcion_nota_credito] FOREIGN KEY([cod_nc])
REFERENCES [dbo].[1_nota_credito] ([cod_nc])
GO
ALTER TABLE [dbo].[1_informe_recepcion] CHECK CONSTRAINT [FK_informe_recepcion_nota_credito]
GO
ALTER TABLE [dbo].[1_informe_recepcion]  WITH CHECK ADD  CONSTRAINT [FK_informe_recepcion_pedido_devolucion] FOREIGN KEY([cod_pd])
REFERENCES [dbo].[1_pedido_devolucion] ([cod_pd])
GO
ALTER TABLE [dbo].[1_informe_recepcion] CHECK CONSTRAINT [FK_informe_recepcion_pedido_devolucion]
GO
ALTER TABLE [dbo].[1_marca_buso]  WITH CHECK ADD  CONSTRAINT [FK_marca_buso_bien_uso] FOREIGN KEY([cod_pro_buso])
REFERENCES [dbo].[1_bien_uso] ([cod_pro_buso])
GO
ALTER TABLE [dbo].[1_marca_buso] CHECK CONSTRAINT [FK_marca_buso_bien_uso]
GO
ALTER TABLE [dbo].[1_marca_buso]  WITH CHECK ADD  CONSTRAINT [FK_marca_buso_marca] FOREIGN KEY([cod_mar])
REFERENCES [dbo].[1_marca] ([cod_mar])
GO
ALTER TABLE [dbo].[1_marca_buso] CHECK CONSTRAINT [FK_marca_buso_marca]
GO
ALTER TABLE [dbo].[1_medida]  WITH CHECK ADD  CONSTRAINT [FK_medida_categoria] FOREIGN KEY([cod_cat])
REFERENCES [dbo].[1_categoria] ([cod_cat])
GO
ALTER TABLE [dbo].[1_medida] CHECK CONSTRAINT [FK_medida_categoria]
GO
ALTER TABLE [dbo].[1_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_1_proveedor_1_direccion] FOREIGN KEY([cod_dir])
REFERENCES [dbo].[1_direccion] ([cod_dir])
GO
ALTER TABLE [dbo].[1_proveedor] CHECK CONSTRAINT [FK_1_proveedor_1_direccion]
GO
ALTER TABLE [dbo].[1_registracion]  WITH CHECK ADD  CONSTRAINT [FK_registracion_informe_recepcion] FOREIGN KEY([cod_ir])
REFERENCES [dbo].[1_informe_recepcion] ([cod_ir])
GO
ALTER TABLE [dbo].[1_registracion] CHECK CONSTRAINT [FK_registracion_informe_recepcion]
GO
ALTER TABLE [dbo].[1_stock]  WITH CHECK ADD  CONSTRAINT [FK_stock_categoria] FOREIGN KEY([cod_cat])
REFERENCES [dbo].[1_categoria] ([cod_cat])
GO
ALTER TABLE [dbo].[1_stock] CHECK CONSTRAINT [FK_stock_categoria]
GO
ALTER TABLE [dbo].[1_stock_marca]  WITH CHECK ADD  CONSTRAINT [FK_stock_marca_marca] FOREIGN KEY([cod_mar])
REFERENCES [dbo].[1_marca] ([cod_mar])
GO
ALTER TABLE [dbo].[1_stock_marca] CHECK CONSTRAINT [FK_stock_marca_marca]
GO
ALTER TABLE [dbo].[1_stock_marca]  WITH CHECK ADD  CONSTRAINT [FK_stock_marca_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[1_stock_marca] CHECK CONSTRAINT [FK_stock_marca_stock]
GO
ALTER TABLE [dbo].[1_stock_medida]  WITH CHECK ADD  CONSTRAINT [FK_stock_medida_medida] FOREIGN KEY([cod_med])
REFERENCES [dbo].[1_medida] ([cod_med])
GO
ALTER TABLE [dbo].[1_stock_medida] CHECK CONSTRAINT [FK_stock_medida_medida]
GO
ALTER TABLE [dbo].[1_stock_medida]  WITH CHECK ADD  CONSTRAINT [FK_stock_medida_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[1_stock_medida] CHECK CONSTRAINT [FK_stock_medida_stock]
GO
ALTER TABLE [dbo].[1_stock_pr]  WITH CHECK ADD  CONSTRAINT [FK_stock_pr_pedido_reaprovisionamiento] FOREIGN KEY([cod_pr])
REFERENCES [dbo].[1_pedido_reaprovisionamiento] ([cod_pr])
GO
ALTER TABLE [dbo].[1_stock_pr] CHECK CONSTRAINT [FK_stock_pr_pedido_reaprovisionamiento]
GO
ALTER TABLE [dbo].[1_stock_pr]  WITH CHECK ADD  CONSTRAINT [FK_stock_pr_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[1_stock_pr] CHECK CONSTRAINT [FK_stock_pr_stock]
GO
ALTER TABLE [dbo].[1_stock_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_stock_proveedor_proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[1_proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[1_stock_proveedor] CHECK CONSTRAINT [FK_stock_proveedor_proveedor]
GO
ALTER TABLE [dbo].[1_stock_proveedor]  WITH CHECK ADD  CONSTRAINT [FK_stock_proveedor_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[1_stock_proveedor] CHECK CONSTRAINT [FK_stock_proveedor_stock]
GO
ALTER TABLE [dbo].[1_usuario]  WITH CHECK ADD  CONSTRAINT [FK_usuario_empleado] FOREIGN KEY([cod_emp])
REFERENCES [dbo].[1_empleado] ([cod_emp])
GO
ALTER TABLE [dbo].[1_usuario] CHECK CONSTRAINT [FK_usuario_empleado]
GO
ALTER TABLE [dbo].[1_usuario_rol]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol_rol] FOREIGN KEY([cod_rol])
REFERENCES [dbo].[1_rol] ([cod_rol])
GO
ALTER TABLE [dbo].[1_usuario_rol] CHECK CONSTRAINT [FK_usuario_rol_rol]
GO
ALTER TABLE [dbo].[1_usuario_rol]  WITH CHECK ADD  CONSTRAINT [FK_usuario_rol_usuario] FOREIGN KEY([cod_usu])
REFERENCES [dbo].[1_usuario] ([cod_usu])
GO
ALTER TABLE [dbo].[1_usuario_rol] CHECK CONSTRAINT [FK_usuario_rol_usuario]
GO
ALTER TABLE [dbo].[2_orden_pago]  WITH CHECK ADD  CONSTRAINT [FK_2_orden_pago_1_factura_proveedor] FOREIGN KEY([cod_factura])
REFERENCES [dbo].[1_factura_proveedor] ([cod_factura])
GO
ALTER TABLE [dbo].[2_orden_pago] CHECK CONSTRAINT [FK_2_orden_pago_1_factura_proveedor]
GO
ALTER TABLE [dbo].[2_orden_pago]  WITH CHECK ADD  CONSTRAINT [FK_2_orden_pago_1_proveedor] FOREIGN KEY([cod_proveedor])
REFERENCES [dbo].[1_proveedor] ([cod_proveedor])
GO
ALTER TABLE [dbo].[2_orden_pago] CHECK CONSTRAINT [FK_2_orden_pago_1_proveedor]
GO
ALTER TABLE [dbo].[2_orden_pago]  WITH CHECK ADD  CONSTRAINT [FK_2_orden_pago_2_cuenta_bancaria_empresa] FOREIGN KEY([cod_cuenta_bancaria])
REFERENCES [dbo].[2_cuenta_bancaria_empresa] ([cod_cuenta_bancaria])
GO
ALTER TABLE [dbo].[2_orden_pago] CHECK CONSTRAINT [FK_2_orden_pago_2_cuenta_bancaria_empresa]
GO
ALTER TABLE [dbo].[2_registracion_debito]  WITH CHECK ADD  CONSTRAINT [FK_2_registracion_debito_2_orden_pago] FOREIGN KEY([cod_orden_pago])
REFERENCES [dbo].[2_orden_pago] ([cod_orden_pago])
GO
ALTER TABLE [dbo].[2_registracion_debito] CHECK CONSTRAINT [FK_2_registracion_debito_2_orden_pago]
GO
ALTER TABLE [dbo].[3_cliente]  WITH CHECK ADD  CONSTRAINT [FK_3_cliente_1_direccion] FOREIGN KEY([cod_dir])
REFERENCES [dbo].[1_direccion] ([cod_dir])
GO
ALTER TABLE [dbo].[3_cliente] CHECK CONSTRAINT [FK_3_cliente_1_direccion]
GO
ALTER TABLE [dbo].[3_cuenta_corriente_cliente]  WITH CHECK ADD  CONSTRAINT [FK_3_cuenta_corriente_cliente_3_cliente] FOREIGN KEY([cod_cli])
REFERENCES [dbo].[3_cliente] ([cod_cli])
GO
ALTER TABLE [dbo].[3_cuenta_corriente_cliente] CHECK CONSTRAINT [FK_3_cuenta_corriente_cliente_3_cliente]
GO
ALTER TABLE [dbo].[3_devolucion_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_devolucion_venta_3_remito_venta] FOREIGN KEY([cod_rem_vent])
REFERENCES [dbo].[3_remito_venta] ([cod_rem_vent])
GO
ALTER TABLE [dbo].[3_devolucion_venta] CHECK CONSTRAINT [FK_3_devolucion_venta_3_remito_venta]
GO
ALTER TABLE [dbo].[3_factura_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_factura_venta_3_remito_venta] FOREIGN KEY([cod_rem_vent])
REFERENCES [dbo].[3_remito_venta] ([cod_rem_vent])
GO
ALTER TABLE [dbo].[3_factura_venta] CHECK CONSTRAINT [FK_3_factura_venta_3_remito_venta]
GO
ALTER TABLE [dbo].[3_lista_precios]  WITH CHECK ADD  CONSTRAINT [FK_3_lista_precios_1_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[3_lista_precios] CHECK CONSTRAINT [FK_3_lista_precios_1_stock]
GO
ALTER TABLE [dbo].[3_nota_credito_cliente]  WITH CHECK ADD  CONSTRAINT [FK_3_nota_credito_cliente_3_devolucion_venta] FOREIGN KEY([cod_dev_vent])
REFERENCES [dbo].[3_devolucion_venta] ([cod_dev_vent])
GO
ALTER TABLE [dbo].[3_nota_credito_cliente] CHECK CONSTRAINT [FK_3_nota_credito_cliente_3_devolucion_venta]
GO
ALTER TABLE [dbo].[3_pedido_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_pedido_venta_3_cliente] FOREIGN KEY([cod_cli])
REFERENCES [dbo].[3_cliente] ([cod_cli])
GO
ALTER TABLE [dbo].[3_pedido_venta] CHECK CONSTRAINT [FK_3_pedido_venta_3_cliente]
GO
ALTER TABLE [dbo].[3_registracion_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_registracion_venta_3_cuenta_corriente_cliente] FOREIGN KEY([cod_cta_cli])
REFERENCES [dbo].[3_cuenta_corriente_cliente] ([cod_cta_cli])
GO
ALTER TABLE [dbo].[3_registracion_venta] CHECK CONSTRAINT [FK_3_registracion_venta_3_cuenta_corriente_cliente]
GO
ALTER TABLE [dbo].[3_registracion_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_registracion_venta_3_factura_venta] FOREIGN KEY([cod_fac_vent])
REFERENCES [dbo].[3_factura_venta] ([cod_fac_vent])
GO
ALTER TABLE [dbo].[3_registracion_venta] CHECK CONSTRAINT [FK_3_registracion_venta_3_factura_venta]
GO
ALTER TABLE [dbo].[3_registracion_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_registracion_venta_3_nota_credito_cliente] FOREIGN KEY([cod_nc_vent])
REFERENCES [dbo].[3_nota_credito_cliente] ([cod_nc_vent])
GO
ALTER TABLE [dbo].[3_registracion_venta] CHECK CONSTRAINT [FK_3_registracion_venta_3_nota_credito_cliente]
GO
ALTER TABLE [dbo].[3_remito_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_remito_venta_3_pedido_venta] FOREIGN KEY([cod_ped_vent])
REFERENCES [dbo].[3_pedido_venta] ([cod_ped_vent])
GO
ALTER TABLE [dbo].[3_remito_venta] CHECK CONSTRAINT [FK_3_remito_venta_3_pedido_venta]
GO
ALTER TABLE [dbo].[3_stock_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_stock_venta_1_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[3_stock_venta] CHECK CONSTRAINT [FK_3_stock_venta_1_stock]
GO
ALTER TABLE [dbo].[3_stock_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_stock_venta_3_pedido_venta] FOREIGN KEY([cod_ped_vent])
REFERENCES [dbo].[3_pedido_venta] ([cod_ped_vent])
GO
ALTER TABLE [dbo].[3_stock_venta] CHECK CONSTRAINT [FK_3_stock_venta_3_pedido_venta]
GO
ALTER TABLE [dbo].[4_confirmacion_cobro]  WITH CHECK ADD  CONSTRAINT [FK_4_confirmacion_cobro_2_cuenta_bancaria_empresa] FOREIGN KEY([cod_cuenta_bancaria])
REFERENCES [dbo].[2_cuenta_bancaria_empresa] ([cod_cuenta_bancaria])
GO
ALTER TABLE [dbo].[4_confirmacion_cobro] CHECK CONSTRAINT [FK_4_confirmacion_cobro_2_cuenta_bancaria_empresa]
GO
ALTER TABLE [dbo].[4_confirmacion_cobro]  WITH CHECK ADD  CONSTRAINT [FK_4_confirmacion_cobro_3_factura_venta] FOREIGN KEY([cod_fac_vent])
REFERENCES [dbo].[3_factura_venta] ([cod_fac_vent])
GO
ALTER TABLE [dbo].[4_confirmacion_cobro] CHECK CONSTRAINT [FK_4_confirmacion_cobro_3_factura_venta]
GO
ALTER TABLE [dbo].[4_registracion_monetaria]  WITH CHECK ADD  CONSTRAINT [FK_4_registracion_monetaria_4_confirmacion_cobro] FOREIGN KEY([cod_con_cob])
REFERENCES [dbo].[4_confirmacion_cobro] ([cod_con_cob])
GO
ALTER TABLE [dbo].[4_registracion_monetaria] CHECK CONSTRAINT [FK_4_registracion_monetaria_4_confirmacion_cobro]
GO
/****** Object:  StoredProcedure [dbo].[BienUsoTieneMarcaAsociada]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[BienUsoTieneMarcaAsociada]
@cod_pro_buso int
as

select 1 from [1_marca_buso] where cod_pro_buso = @cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[DeleteBanco]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBanco]
(
	@cod_banco_proveedor int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[1_banco_proveedor] WHERE [cod_banco_proveedor] = @cod_banco_proveedor

GO
/****** Object:  StoredProcedure [dbo].[DeleteBienesPorSolcitudCompra]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBienesPorSolcitudCompra]
(
	@cod_sc int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [1_buso_sc] WHERE cod_sc = @cod_sc

GO
/****** Object:  StoredProcedure [dbo].[DeleteBienesUsoProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteBienesUsoProveedor]
(
	@cod_proveedor int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[1_buso_proveedor] WHERE [cod_proveedor] = @cod_proveedor

GO
/****** Object:  StoredProcedure [dbo].[DeleteBienUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteBienUso]
@cod_pro_buso int 
as
delete from [1_bien_uso] where cod_pro_buso = @cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[DeleteMarcaBienUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteMarcaBienUso]
(
	@cod_pro_buso int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[1_marca_buso] WHERE  [cod_pro_buso] = @cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[DeletePedidoReaprov]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeletePedidoReaprov]
(
	@cod_pr int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[1_pedido_reaprovisionamiento] WHERE [cod_pr] = @cod_pr

GO
/****** Object:  StoredProcedure [dbo].[DeleteProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteProveedor]
@cod_proveedor int
as
delete from [1_proveedor] where cod_proveedor=@cod_proveedor

GO
/****** Object:  StoredProcedure [dbo].[DeleteSolicitudCompra]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteSolicitudCompra]
(
	@_cod_sc int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [1_solicitud_compra] WHERE cod_sc = @_cod_sc

GO
/****** Object:  StoredProcedure [dbo].[DeleteStock]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteStock]
@cod_pro_stock int
as
delete from [1_stock] where cod_pro_stock = @cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[DeleteStockMarca]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteStockMarca]
(
	
	@cod_pro_stock int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[1_stock_marca] WHERE [cod_pro_stock] = @cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[DeleteStockMedida]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteStockMedida]
(
	
	@cod_pro_stock int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[1_stock_medida] WHERE [cod_pro_stock] = @cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[DeleteStockPedidoReaprov]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[DeleteStockPedidoReaprov]
	@cod_pr int
as

DELETE FROM [1_stock_pr] WHERE cod_pr = @cod_pr


GO
/****** Object:  StoredProcedure [dbo].[DeleteStockProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[DeleteStockProveedor]
(
	@cod_proveedor int
)
AS
	SET NOCOUNT OFF;
DELETE FROM [dbo].[1_stock_proveedor] WHERE [cod_proveedor] = @cod_proveedor

GO
/****** Object:  StoredProcedure [dbo].[ExisteBienUsoProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExisteBienUsoProveedor]
(
	@cod_pro_buso int
)
AS
	SET NOCOUNT ON;
select 1 from [1_buso_proveedor] where cod_pro_buso = @cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[ExisteStockProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ExisteStockProveedor]
(
	@cod_pro_stock int
)
AS
	SET NOCOUNT ON;
select 1 from [1_stock_proveedor] where cod_pro_stock = @cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[GetBienUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetBienUso]
@cod_pro_buso int
as
select * from [1_bien_uso] where cod_pro_buso = @cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[GetCodigosPedidosSinCotizacion]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[GetCodigosPedidosSinCotizacion]
as
select pr.cod_pr from [1_pedido_reaprovisionamiento] pr where not exists 
(select * from [1_cotizacion_pedido_reaprovisionamiento] cpr where cpr.cod_pr = pr.cod_pr)

GO
/****** Object:  StoredProcedure [dbo].[GetNombreBienUsoByCodBienUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetNombreBienUsoByCodBienUso]
(
	@cod_pro_buso int
)
AS
	SET NOCOUNT ON;
SELECT  nombre FROM [1_bien_uso] WHERE cod_pro_buso = @cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[GetNombreCompletoEmpleadoByCodEmpleado]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetNombreCompletoEmpleadoByCodEmpleado]
(
	@cod_emp int
)
AS
	SET NOCOUNT ON;
select cod_emp ,nom_emp, ape_emp ,dni_emp from [1_empleado] where cod_emp =@cod_emp

GO
/****** Object:  StoredProcedure [dbo].[GetNombreStockByCodStock]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetNombreStockByCodStock]
(
	@cod_pro_stock int
)
AS
	SET NOCOUNT ON;
SELECT nombre FROM [1_stock] WHERE cod_pro_stock = @cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[GetProducto]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetProducto]
@cod_pro_stock int
as
select * from [1_stock] where cod_pro_stock=@cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[GetProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[GetProveedor]
@cod_proveedor int
as
select * from [1_proveedor] where cod_proveedor=@cod_proveedor

GO
/****** Object:  StoredProcedure [dbo].[GetUsuario]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[GetUsuario]
(
	@nom_usu varchar(20)
)
AS
	SET NOCOUNT ON;
SELECT cod_usu, cod_emp, nom_usu, psw_usu, fecha_alta_usu, cuenta_activa_usu FROM dbo.[1_usuario] 
WHERE nom_usu = @nom_usu

GO
/****** Object:  StoredProcedure [dbo].[InicializarTablasTransaccionales]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InicializarTablasTransaccionales]

AS


	SET NOCOUNT ON;
	DBCC CHECKIDENT ([1_solicitud_compra], RESEED,0);
	DBCC CHECKIDENT ([1_pedido_reaprovisionamiento], RESEED,0);
	DELETE FROM [1_solicitud_compra]
	DELETE FROM [1_pedido_reaprovisionamiento]
	DELETE FROM [1_buso_sc]
	DELETE FROM [1_stock_pr]


GO
/****** Object:  StoredProcedure [dbo].[InsertarSolicitudCompra]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarSolicitudCompra]   
    @fecha_emision date,
	@departamento varchar(50),
	@cancelado bit 
AS   

    SET NOCOUNT ON;  
    INSERT INTO [dbo].[1_solicitud_compra] ([fecha_emision], [departamento], [cancelado]) 
VALUES (@fecha_emision, @departamento, @cancelado);
	
SELECT cod_sc FROM [1_solicitud_compra] WHERE (cod_sc = SCOPE_IDENTITY())

GO
/****** Object:  StoredProcedure [dbo].[InsertBanco]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertBanco]
(
	@numero_cuenta int,
	@banco varchar(50),
	@cod_proveedor int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_banco_proveedor] ([numero_cuenta], [banco], [cod_proveedor]) VALUES (@numero_cuenta, @banco, @cod_proveedor)

GO
/****** Object:  StoredProcedure [dbo].[InsertBienUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertBienUso]
@nombre nvarchar(50),
@stock int,
@descripcion nvarchar(50),
@observacion nvarchar(50)
as
insert into [1_bien_uso](nombre,stock,descripcion,observacion) 
values (@nombre,@stock,@descripcion, @observacion)

GO
/****** Object:  StoredProcedure [dbo].[InsertBienUsoProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertBienUsoProveedor]
(
	@cod_proveedor int,
	@cod_pro_buso int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_buso_proveedor] ([cod_proveedor], [cod_pro_buso]) VALUES (@cod_proveedor, @cod_pro_buso)

GO
/****** Object:  StoredProcedure [dbo].[InsertCotizacion]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCotizacion]
(
	@cod_cotizacion int,
	@cod_proveedor int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_cotizacion] ([cod_cotizacion], [cod_proveedor]) VALUES (@cod_cotizacion, @cod_proveedor)

GO
/****** Object:  StoredProcedure [dbo].[InsertCotizacionPedidoReaprov]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertCotizacionPedidoReaprov]
@cod_pr int,
@tiempo_entrega nvarchar(50),
@fecha_cotizacion date,
@precio_cotizado decimal

as
INSERT INTO [dbo].[1_cotizacion_pedido_reaprovisionamiento] ([cod_pr], [tiempo_entrega], [fecha_cotizacion], [precio_cotizado]) 
VALUES (@cod_pr, @tiempo_entrega, @fecha_cotizacion, @precio_cotizado);

SELECT cod_cotizacion FROM [1_cotizacion_pedido_reaprovisionamiento] WHERE (cod_cotizacion = SCOPE_IDENTITY())

GO
/****** Object:  StoredProcedure [dbo].[InsertCotizacionPR]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCotizacionPR]
(
	@cod_cotizacion int,
	@cod_proveedor int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_cotizacion_pr] ([cod_cotizacion], [cod_proveedor]) VALUES (@cod_cotizacion, @cod_proveedor)

GO
/****** Object:  StoredProcedure [dbo].[InsertCotizacionPrOc]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCotizacionPrOc]
(
	@cod_cotizacion int,
	@cod_ord_cpr int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_cotizacion_pr_oc] ([cod_cotizacion], [cod_ord_cpr]) VALUES (@cod_cotizacion, @cod_ord_cpr)

GO
/****** Object:  StoredProcedure [dbo].[InsertCotizacionSC]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCotizacionSC]
(
	@cod_cotizacion int,
	@cod_proveedor int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_cotizacion_sc] ([cod_cotizacion], [cod_proveedor]) VALUES (@cod_cotizacion, @cod_proveedor)

GO
/****** Object:  StoredProcedure [dbo].[InsertCotizacionScOc]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertCotizacionScOc]
(
	@cod_cotizacion int,
	@cod_ord_cpr int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_cotizacion_sc_oc] ([cod_cotizacion], [cod_ord_cpr]) VALUES (@cod_cotizacion, @cod_ord_cpr)

GO
/****** Object:  StoredProcedure [dbo].[InsertCotizacionSolicitudCompra]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertCotizacionSolicitudCompra]
@cod_sc int,
@tiempo_entrega nvarchar(50),
@fecha_cotizacion date,
@precio_cotizado decimal

as
INSERT INTO [dbo].[1_cotizacion_solicitud_compra] ([cod_sc], [tiempo_entrega], [fecha_cotizacion], [precio_cotizado]) 
VALUES (@cod_sc, @tiempo_entrega, @fecha_cotizacion, @precio_cotizado);
SELECT cod_cotizacion FROM [1_cotizacion_solicitud_compra] WHERE (cod_cotizacion = SCOPE_IDENTITY())

GO
/****** Object:  StoredProcedure [dbo].[InsertMarcaBienUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertMarcaBienUso]
(
	@cod_mar int,
	@cod_pro_buso int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_marca_buso] ([cod_mar], [cod_pro_buso]) VALUES (@cod_mar, @cod_pro_buso)

GO
/****** Object:  StoredProcedure [dbo].[InsertPedidoReaprov]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertPedidoReaprov]
	@fecha_emision date,
	@cancelado bit,
	@automatizado bit

as
	set nocount on;
	insert into [1_pedido_reaprovisionamiento] (fecha_emision,cancelado,automatizado) 
	values (@fecha_emision,@cancelado,@automatizado);

	select cod_pr from [1_pedido_reaprovisionamiento] where (cod_pr = SCOPE_IDENTITY())
	

GO
/****** Object:  StoredProcedure [dbo].[InsertProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[InsertProveedor]
@nombre nvarchar(50),
@telefono nvarchar(50),
@cod_dir int,
@email nvarchar(50),
@razon_social nvarchar(50)
as
insert into [1_proveedor] (nombre, numero_telefono, cod_dir, email, razon_social)
values (@nombre, @telefono, @cod_dir, @email, @razon_social)

GO
/****** Object:  StoredProcedure [dbo].[InsertSolicitudBienDeUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertSolicitudBienDeUso]
(
	@cod_sc int,
	@cod_pro_buso int,
	@cantidad int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_buso_sc] ([cod_sc], [cod_pro_buso], [cantidad]) VALUES (@cod_sc, @cod_pro_buso, @cantidad)

GO
/****** Object:  StoredProcedure [dbo].[InsertStock]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[InsertStock]
@nombre nvarchar(50),
@stk_act int,
@stk_opt int,
@stk_cri int,
@cod_cat int
as
insert into [1_stock] (nombre,stk_act,stk_opt,stk_cri,cod_cat) 
values (@nombre,@stk_act,@stk_opt, @stk_cri, @cod_cat)

GO
/****** Object:  StoredProcedure [dbo].[InsertStockMarca]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStockMarca]
(
	@cod_mar int,
	@cod_pro_stock int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_stock_marca] ([cod_mar], [cod_pro_stock]) VALUES (@cod_mar, @cod_pro_stock)

GO
/****** Object:  StoredProcedure [dbo].[InsertStockMedida]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStockMedida]
(
	@cod_med int,
	@cod_pro_stock int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_stock_medida] ([cod_med], [cod_pro_stock]) VALUES (@cod_med, @cod_pro_stock)

GO
/****** Object:  StoredProcedure [dbo].[InsertStockPedidoReaprov]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStockPedidoReaprov]
(
	@cod_pr int,
	@cod_pro_stock int,
	@cantidad int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_stock_pr] ([cod_pr], [cod_pro_stock], [cantidad]) VALUES (@cod_pr, @cod_pro_stock, @cantidad)

GO
/****** Object:  StoredProcedure [dbo].[InsertStockProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertStockProveedor]
(
	@cod_proveedor int,
	@cod_pro_stock int
)
AS
	SET NOCOUNT OFF;
INSERT INTO [dbo].[1_stock_proveedor] ([cod_proveedor], [cod_pro_stock]) VALUES (@cod_proveedor, @cod_pro_stock)

GO
/****** Object:  StoredProcedure [dbo].[PedidosReaprovSinCotizacion]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[PedidosReaprovSinCotizacion]
as


select * from [1_pedido_reaprovisionamiento] pr where not exists 
(select * from [1_cotizacion_pedido_reaprovisionamiento] cpr where cpr.cod_pr = pr.cod_pr)

GO
/****** Object:  StoredProcedure [dbo].[SelectBancos]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectBancos]
as
select cod_banco_proveedor, numero_cuenta, banco, p.nombre as proveedor from [1_banco_proveedor] b inner join [1_proveedor] p on p.cod_proveedor=b.cod_proveedor
order by b.cod_proveedor

GO
/****** Object:  StoredProcedure [dbo].[SelectBienesUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectBienesUso]
as
select * from [1_bien_uso] order by nombre

GO
/****** Object:  StoredProcedure [dbo].[SelectBienesUsoByNombre]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectBienesUsoByNombre]
@nombre nvarchar(50)
as
select * from [1_bien_uso] where nombre like '%' + @nombre + '%' order by nombre

GO
/****** Object:  StoredProcedure [dbo].[SelectCategorias]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectCategorias]
as
select cod_cat, nombre from [1_categoria]

GO
/****** Object:  StoredProcedure [dbo].[SelectCodAndNombreMedidaByCodCategoria]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[SelectCodAndNombreMedidaByCodCategoria]
(
	@cod_cat int
)
AS
	SET NOCOUNT ON;
select cod_med, nombre, cod_cat from [1_medida] where cod_cat = @cod_cat

GO
/****** Object:  StoredProcedure [dbo].[SelectDirecciones]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectDirecciones]
as
select d.cod_dir, d.calle + ' ' + d.numero as direccion from [1_direccion] d

GO
/****** Object:  StoredProcedure [dbo].[SelectListadoStockActualMenorAlCritico]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectListadoStockActualMenorAlCritico]

as

select * from [1_stock] where stk_act < stk_cri


GO
/****** Object:  StoredProcedure [dbo].[SelectMarcas]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectMarcas]
as
select m.cod_mar, m.nombre from [1_marca] m

GO
/****** Object:  StoredProcedure [dbo].[SelectMedidas]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SelectMedidas]
as
select m.cod_med, m.nombre from [1_medida] m

GO
/****** Object:  StoredProcedure [dbo].[SelectNombresBienesUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectNombresBienesUso]
as
select cod_pro_buso, nombre from [1_bien_uso] order by nombre 

GO
/****** Object:  StoredProcedure [dbo].[SelectNombresStock]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectNombresStock]
as
select cod_pro_stock, nombre from [1_stock] order by nombre 

GO
/****** Object:  StoredProcedure [dbo].[SelectProveedorByNombre]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectProveedorByNombre]
@nombre nvarchar(50)
as
select cod_proveedor, nombre, numero_telefono, (d.calle + ' ' + d.numero) as direccion, email, razon_social from [1_proveedor] pr 
inner join [1_direccion] d on d.cod_dir=pr.cod_dir
where nombre like '%' + @nombre + '%'
order by pr.nombre desc

GO
/****** Object:  StoredProcedure [dbo].[SelectProveedores]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectProveedores]
as
select cod_proveedor, nombre, numero_telefono, (d.calle + ' ' + d.numero) as direccion, email, razon_social from [1_proveedor] pr 
inner join [1_direccion] d on d.cod_dir=pr.cod_dir
order by pr.nombre desc

GO
/****** Object:  StoredProcedure [dbo].[SelectStock]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectStock]
as
select cod_pro_stock, s.nombre,stk_act, stk_opt, stk_cri, c.nombre from [1_stock] s 
inner join [1_categoria] c on c.cod_cat = s.cod_cat order by s.nombre


GO
/****** Object:  StoredProcedure [dbo].[SelectStockByNombre]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectStockByNombre]
@nombre nvarchar(50)
as
select * from [1_stock] where nombre like '%' + @nombre + '%' order by nombre

GO
/****** Object:  StoredProcedure [dbo].[SelectStockMarca]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[SelectStockMarca]
as
select m.nombre, s.nombre from [1_stock_marca] sm
  
inner join [1_marca] m on sm.cod_mar = m.cod_mar 
inner join [1_stock] s on sm.cod_pro_stock = s.cod_pro_stock
order by sm.cod_mar

GO
/****** Object:  StoredProcedure [dbo].[SolicitudCompraSinCotizacion]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[SolicitudCompraSinCotizacion]
as
select * from [1_solicitud_compra] sc where not exists 
(select * from [1_cotizacion_solicitud_compra] csc where csc.cod_sc = sc.cod_sc)

GO
/****** Object:  StoredProcedure [dbo].[StockActualEsMenorQueStockCritico]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[StockActualEsMenorQueStockCritico]
(
	@cod_pro_stock int
)
AS
	SET NOCOUNT ON;
select 1 from [1_stock] where cod_pro_stock = @cod_pro_stock and (stk_act < stk_cri)

GO
/****** Object:  StoredProcedure [dbo].[StockTieneMarcaAsociada]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[StockTieneMarcaAsociada]
@cod_pro_stock int
as

select 1 from [1_stock_marca] where cod_pro_stock = @cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[UpdateBienUso]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateBienUso]
@cod_pro_buso int,
@nombre nvarchar(50),
@stock int,
@descripcion nvarchar(50),
@observacion nvarchar(50)
as
update [1_bien_uso] set nombre=@nombre, stock=@stock, descripcion=@descripcion,observacion=@observacion
where cod_pro_buso=@cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[UpdatePedidoReaprov]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdatePedidoReaprov]
	
	@cod_pr int ,
	@cancelado bit

as

UPDATE [dbo].[1_pedido_reaprovisionamiento] SET [cancelado] = @cancelado 
WHERE cod_pr = @cod_pr


GO
/****** Object:  StoredProcedure [dbo].[UpdateProveedor]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create procedure [dbo].[UpdateProveedor]
@cod_proveedor int,
@nombre nvarchar(50),
@telefono nvarchar(50),
@cod_dir int,
@email nvarchar(50),
@razon_social nvarchar(50)
as
update [1_proveedor] set nombre=@nombre, numero_telefono=@telefono, cod_dir=@cod_dir, email=@email, razon_social=@razon_social
where cod_proveedor=@cod_proveedor

GO
/****** Object:  StoredProcedure [dbo].[UpdateSolicitudCompra]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateSolicitudCompra]
(
	@departamento varchar(50),
	@cancelado bit,
	@cod_sc int
)
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[1_solicitud_compra] SET [departamento] = @departamento, [cancelado] = @cancelado 
WHERE [cod_sc] = @cod_sc

GO
/****** Object:  StoredProcedure [dbo].[UpdateStock]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[UpdateStock]
@cod_pro_stock int,
@nombre nvarchar(50),
@stk_opt int,
@stk_cri int,
@cod_cat int
as
update [1_stock] set nombre=@nombre, stk_opt = @stk_opt, stk_cri= @stk_cri, cod_cat = @cod_cat
where cod_pro_stock = @cod_pro_stock

GO
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 17/10/2019 16:57:57 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ValidarUsuario]
(
	@nom_usu varchar(20),
	@psw_usud varchar(20)
)
AS
	SET NOCOUNT ON;
select 1 from [1_usuario] where nom_usu = @nom_usu and psw_usu = @psw_usud and cuenta_activa_usu = 1

GO
USE [master]
GO
ALTER DATABASE [Sistemas_II_CPVC] SET  READ_WRITE 
GO
