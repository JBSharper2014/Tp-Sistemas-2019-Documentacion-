USE [master]
GO
/****** Object:  Database [Sistemas_II_CPVC]    Script Date: 28/8/2019 14:40:08 ******/
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
/****** Object:  Table [dbo].[1_bien_uso]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_buso_proveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_buso_sc]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_categoria]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_cbu_proveedor]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cbu_proveedor](
	[cod_proveedor] [int] NULL,
	[cbu] [varchar](50) NOT NULL,
 CONSTRAINT [PK_1_cbu_proveedor] PRIMARY KEY CLUSTERED 
(
	[cbu] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_ciudad]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_cotizacion_pedido_reaprovisionamiento]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_cotizacion_pr]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_cotizacion_pr_oc]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_pr_oc](
	[cod_cotizacion] [int] NOT NULL,
	[cod_ord_cpr] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_sc]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_cotizacion_sc_oc]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_cotizacion_sc_oc](
	[cod_cotizacion] [int] NOT NULL,
	[cod_ord_cpr] [int] NOT NULL
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_cotizacion_solicitud_compra]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_cuenta_corriente_proveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_direccion]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_empleado]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_factura_proveedor]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_factura_proveedor](
	[cod_factura] [int] IDENTITY(1,1) NOT NULL,
	[cod_ord_cpr] [int] NOT NULL,
	[numero_factura] [int] NOT NULL,
	[fecha_recepcion] [date] NOT NULL,
	[nombre_proveedor] [varchar](50) NOT NULL,
	[importe] [decimal](18, 0) NOT NULL,
	[observaciones] [varchar](500) NULL,
	[sumada] [bit] NOT NULL,
 CONSTRAINT [PK_factura_proveedor] PRIMARY KEY CLUSTERED 
(
	[cod_factura] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_informe_recepcion]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_marca]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_marca_buso]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_medida]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_nota_credito]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_orden_compra]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_pedido_devolucion]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_pedido_reaprovisionamiento]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_proveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_provincia]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[1_provincia](
	[cod_provincia] [int] IDENTITY(1,1) NOT NULL,
	[nombre] [int] NOT NULL,
 CONSTRAINT [PK_1_provincia] PRIMARY KEY CLUSTERED 
(
	[cod_provincia] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_registracion]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_rol]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_solicitud_compra]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_stock]    Script Date: 28/8/2019 14:40:09 ******/
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
 CONSTRAINT [PK_stock] PRIMARY KEY CLUSTERED 
(
	[cod_pro_stock] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[1_stock_marca]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_stock_medida]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_stock_pr]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_stock_proveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_usuario]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[1_usuario_rol]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[2_cuenta_bancaria_empresa]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2_cuenta_bancaria_empresa](
	[cod_cuenta_bancaria] [int] IDENTITY(1,1) NOT NULL,
	[banco] [varchar](50) NOT NULL,
	[numero_cuenta] [int] NOT NULL,
	[saldo] [decimal](18, 0) NOT NULL,
 CONSTRAINT [PK_2_cuenta_bancaria_empresa] PRIMARY KEY CLUSTERED 
(
	[cod_cuenta_bancaria] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2_orden_pago]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[2_orden_pago](
	[cod_orden_pago] [int] IDENTITY(1,1) NOT NULL,
	[cod_factura] [int] NOT NULL,
	[cod_proveedor] [int] NOT NULL,
	[cod_banco_proveedor] [int] NOT NULL,
	[cod_cuenta_bancaria] [int] NOT NULL,
	[debitada] [bit] NOT NULL,
	[aceptada_pago] [bit] NOT NULL,
	[observaciones] [varchar](500) NULL,
 CONSTRAINT [PK_2_orden_pago] PRIMARY KEY CLUSTERED 
(
	[cod_orden_pago] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[2_registracion_debito]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[3_cliente]    Script Date: 28/8/2019 14:40:09 ******/
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
	[cod_pos] [smallint] NULL,
 CONSTRAINT [PK_3_cliente] PRIMARY KEY CLUSTERED 
(
	[cod_cli] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_cuenta_corriente_cliente]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[3_devolucion_venta]    Script Date: 28/8/2019 14:40:09 ******/
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
 CONSTRAINT [PK_3_devolucion_venta] PRIMARY KEY CLUSTERED 
(
	[cod_dev_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_factura_venta]    Script Date: 28/8/2019 14:40:09 ******/
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
	[numero] [int] NOT NULL,
 CONSTRAINT [PK_3_factura_venta] PRIMARY KEY CLUSTERED 
(
	[cod_fac_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_lista_precios]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[3_nota_credito_cliente]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[3_pedido_venta]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_pedido_venta](
	[cod_ped_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_cli] [int] NOT NULL,
	[cantidad] [int] NOT NULL,
	[fecha_emision] [date] NOT NULL,
	[procesado] [bit] NOT NULL,
 CONSTRAINT [PK_3_pedido_venta] PRIMARY KEY CLUSTERED 
(
	[cod_ped_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_registracion_venta]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[3_remito_venta]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_remito_venta](
	[cod_rem_vent] [int] IDENTITY(1,1) NOT NULL,
	[cod_ped_vent] [int] NOT NULL,
	[observaciones] [varchar](500) NULL,
	[es_devolucion] [bit] NOT NULL,
	[cod_dev_vent] [int] NULL,
	[fecha_creacion] [date] NOT NULL,
 CONSTRAINT [PK_3_remito_venta] PRIMARY KEY CLUSTERED 
(
	[cod_rem_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_stock_rem_venta]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_stock_rem_venta](
	[cod_pro_stock] [int] NOT NULL,
	[cod_rem_vent] [int] NOT NULL,
 CONSTRAINT [PK_stock_rem_venta] PRIMARY KEY CLUSTERED 
(
	[cod_pro_stock] ASC,
	[cod_rem_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[3_stock_venta]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[3_stock_venta](
	[cod_pro_stock] [int] NOT NULL,
	[cod_ped_vent] [int] NOT NULL,
 CONSTRAINT [PK_3_stock_venta] PRIMARY KEY CLUSTERED 
(
	[cod_pro_stock] ASC,
	[cod_ped_vent] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]

GO
/****** Object:  Table [dbo].[4_confirmacion_cobro]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  Table [dbo].[4_registracion_monetaria]    Script Date: 28/8/2019 14:40:09 ******/
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
SET IDENTITY_INSERT [dbo].[1_empleado] ON 

INSERT [dbo].[1_empleado] ([cod_emp], [nom_emp], [ape_emp], [dni_emp]) VALUES (1, N'leon', N'juarez', 34500123)
SET IDENTITY_INSERT [dbo].[1_empleado] OFF
SET IDENTITY_INSERT [dbo].[1_rol] ON 

INSERT [dbo].[1_rol] ([cod_rol], [rol]) VALUES (1, N'panadero')
SET IDENTITY_INSERT [dbo].[1_rol] OFF
SET IDENTITY_INSERT [dbo].[1_usuario] ON 

INSERT [dbo].[1_usuario] ([cod_usu], [cod_emp], [nom_usu], [psw_usu], [fecha_alta_usu], [cuenta_activa_usu]) VALUES (7, 1, N'nacho', N'123', CAST(N'2016-06-01' AS Date), 1)
SET IDENTITY_INSERT [dbo].[1_usuario] OFF
INSERT [dbo].[1_usuario_rol] ([cod_rol], [cod_usu]) VALUES (1, 7)
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
ALTER TABLE [dbo].[3_remito_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_remito_venta_3_devolucion_venta] FOREIGN KEY([cod_dev_vent])
REFERENCES [dbo].[3_devolucion_venta] ([cod_dev_vent])
GO
ALTER TABLE [dbo].[3_remito_venta] CHECK CONSTRAINT [FK_3_remito_venta_3_devolucion_venta]
GO
ALTER TABLE [dbo].[3_remito_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_remito_venta_3_pedido_venta] FOREIGN KEY([cod_ped_vent])
REFERENCES [dbo].[3_pedido_venta] ([cod_ped_vent])
GO
ALTER TABLE [dbo].[3_remito_venta] CHECK CONSTRAINT [FK_3_remito_venta_3_pedido_venta]
GO
ALTER TABLE [dbo].[3_stock_rem_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_stock_rem_venta_1_stock] FOREIGN KEY([cod_pro_stock])
REFERENCES [dbo].[1_stock] ([cod_pro_stock])
GO
ALTER TABLE [dbo].[3_stock_rem_venta] CHECK CONSTRAINT [FK_3_stock_rem_venta_1_stock]
GO
ALTER TABLE [dbo].[3_stock_rem_venta]  WITH CHECK ADD  CONSTRAINT [FK_3_stock_rem_venta_3_remito_venta] FOREIGN KEY([cod_rem_vent])
REFERENCES [dbo].[3_remito_venta] ([cod_rem_vent])
GO
ALTER TABLE [dbo].[3_stock_rem_venta] CHECK CONSTRAINT [FK_3_stock_rem_venta_3_remito_venta]
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
/****** Object:  StoredProcedure [dbo].[DeleteBanco]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteBienesPorSolcitudCompra]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteBienesUsoProveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteMarcaBienUso]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteSolicitudCompra]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteStockMarca]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteStockMedida]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[DeleteStockProveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[ExisteBienUsoProveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[ExisteStockProveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[GetNombreBienUsoByCodBienUso]    Script Date: 28/8/2019 14:40:09 ******/
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
SELECT nombre FROM [1_bien_uso] WHERE cod_pro_buso = @cod_pro_buso

GO
/****** Object:  StoredProcedure [dbo].[GetNombreCompletoEmpleadoByCodEmpleado]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[GetUsuario]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[InicializarTablasTransaccionales]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InicializarTablasTransaccionales]

AS
	SET NOCOUNT ON;
	DBCC CHECKIDENT ([1_solicitud_compra], RESEED,0);
	DELETE FROM [1_buso_sc]


GO
/****** Object:  StoredProcedure [dbo].[InsertarSolicitudCompra]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[InsertarSolicitudCompra]   
    @fecha_emision date,
	@departamento varchar(50),
	@cancelado bit,
	@cod_ord_cpr int   
AS   

    SET NOCOUNT ON;  
    INSERT INTO [dbo].[1_solicitud_compra] ([fecha_emision], [departamento], [cancelado], [cod_ord_cpr]) 
VALUES (@fecha_emision, @departamento, @cancelado, @cod_ord_cpr);
	
SELECT cod_sc FROM [1_solicitud_compra] WHERE (cod_sc = SCOPE_IDENTITY())

GO
/****** Object:  StoredProcedure [dbo].[InsertBanco]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertBienUsoProveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertMarcaBienUso]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertSolicitudBienDeUso]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertStockMarca]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertStockMedida]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[InsertStockProveedor]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[SelectCodAndNombreMedidaByCodCategoria]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[UpdateListadoSolicitudesCompraOrdenesToNull]    Script Date: 28/8/2019 14:40:09 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[UpdateListadoSolicitudesCompraOrdenesToNull]
AS
	SET NOCOUNT OFF;
UPDATE [dbo].[1_solicitud_compra] SET [cod_ord_cpr] = NULL WHERE [cod_ord_cpr] = -1

GO
/****** Object:  StoredProcedure [dbo].[UpdateSolicitudCompra]    Script Date: 28/8/2019 14:40:09 ******/
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
/****** Object:  StoredProcedure [dbo].[ValidarUsuario]    Script Date: 28/8/2019 14:40:09 ******/
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
