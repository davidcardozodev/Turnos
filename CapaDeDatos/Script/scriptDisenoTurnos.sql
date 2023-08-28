USE [Turnos]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdProveedor] [int] NULL,
	[DiaNombre] [nvarchar](50) NOT NULL,
	[DiaNumero] [nvarchar](50) NOT NULL,
	[Mes] [nvarchar](50) NOT NULL,
	[Anio] [nvarchar](50) NOT NULL,
	[Hora] [nvarchar](50) NOT NULL,
	[Descripcion] [nvarchar](50) NOT NULL,
	[Estado] [nvarchar](50) NULL,
	[NombreProveedor] [nvarchar](50) NOT NULL,
 CONSTRAINT [PK_ClienteTurno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TurnoModificacion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurnoModificacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTurno] [int] NOT NULL,
	[IdAdmin] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[DiaNombre] [nvarchar](50) NULL,
	[DiaNumero] [nvarchar](50) NULL,
	[Mes] [nvarchar](50) NULL,
	[Anio] [nvarchar](50) NULL,
	[NombreProveedor] [nvarchar](50) NULL,
	[Estado] [nvarchar](50) NULL,
 CONSTRAINT [PK_TurnoModificacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](100) NOT NULL,
	[Clave] [nvarchar](100) NOT NULL,
	[PrimerNombre] [nvarchar](100) NULL,
	[SegundoNombre] [nvarchar](100) NULL,
	[Email] [nvarchar](100) NULL,
	[Rol] [nvarchar](100) NOT NULL,
	[HorarioInicio] [int] NULL,
	[HorarioFin] [int] NULL,
	[TipoPlan] [nvarchar](100) NULL,
	[Presencia] [nvarchar](100) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarProveedores]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarProveedores]
as
select PrimerNombre, SegundoNombre from Usuarios where Rol = 'Proveedor'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarUsuario]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarUsuario]
as
select Id, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol 
from Usuarios
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarUsuarioBusqueda]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminCargarUsuarioBusqueda]
@Busqueda nvarchar(100)
as
select Id, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol 
from Usuarios
where Id like '%' + @Busqueda + '%'or  
Usuario like '%' + @Busqueda + '%'or
PrimerNombre like '%' + @Busqueda + '%'or 
SegundoNombre like '%' + @Busqueda + '%'or 
Email like '%' + @Busqueda + '%'or
Rol like '%' + @Busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarUsuarioFiltrado]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminCargarUsuarioFiltrado]
@Rol nvarchar(100)
as
select Id, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol 
from Usuarios
where Rol = @Rol
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarBajaNotificacion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminGuardarBajaNotificacion]
@IdTurno int,
@IdAdmin int,
@IdCliente int
as
insert into TurnoModificacion values
(
@IdTurno,
@IdAdmin,
@IdCliente,
null, 
null, 
null, 
null,
null,
'Cancelado')
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarDisponibilidad]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminGuardarDisponibilidad]
@IdUsuario int,
@HorarioInicio int,
@HorarioFin int
as
update Usuarios set HorarioInicio=@HorarioInicio, HorarioFin=@HorarioFin where Id=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarModificacion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminGuardarModificacion]
@IdTurno int,
@IdAdmin int,
@IdCliente int,
@DiaNombre nvarchar(50),
@DiaNumero nvarchar(50),
@Mes nvarchar(50),
@Anio nvarchar(50),
@NombreProveedor nvarchar(50)
as
insert into TurnoModificacion values
(
@IdTurno,
@IdAdmin,
@IdCliente,
@DiaNombre, 
@DiaNumero, 
@Mes, 
@Anio,
@NombreProveedor,
'')
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarProveedor]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminGuardarProveedor]
@IdTurno int,
@NombreProveedor nvarchar(100)
as
update Turno set NombreProveedor=@NombreProveedor where Id=@IdTurno
GO
/****** Object:  StoredProcedure [dbo].[AdminModificarUsuario]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminModificarUsuario]
@IdUsuario int,
@Rol nvarchar(100)
as
update Usuarios set Rol=@Rol where Id=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[AdminRegistrarUsuario]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminRegistrarUsuario]
@NombreUsuario nvarchar(50),
@Clave nvarchar(50),
@PrimerNombre nvarchar(50),
@SegundoNombre nvarchar(50),
@Email nvarchar(50),
@Rol nvarchar(50),
@TipoPlan nvarchar(50)
as
insert into Usuarios values (@NombreUsuario, @Clave, @PrimerNombre, @SegundoNombre, @Email, @Rol, null, null, @TipoPlan, 'Ausente')
GO
/****** Object:  StoredProcedure [dbo].[BuscarCliente]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[BuscarCliente]
@Usuario nvarchar (100),
@Clave nvarchar (100)
as
select ID from Usuarios where Usuario=@Usuario and Clave = @Clave
GO
/****** Object:  StoredProcedure [dbo].[CargarTurnoModificacionBusqueda]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CargarTurnoModificacionBusqueda]
@IdCliente int,
@Busqueda nvarchar(100)
as
select IdTurno, DiaNombre, DiaNumero,Mes,Anio, NombreProveedor, Estado
from TurnoModificacion
where
DiaNombre like '%' + @Busqueda + '%' and IdCliente = @IdCliente or
DiaNumero like '%' + @Busqueda + '%' and IdCliente = @IdCliente or 
Mes like '%' + @Busqueda + '%' and IdCliente = @IdCliente or 
Anio like '%' + @Busqueda + '%' and IdCliente = @IdCliente or 
NombreProveedor like '%' + @Busqueda + '%' and IdCliente = @IdCliente or
Estado like '%' + @Busqueda + '%' and IdCliente = @IdCliente
GO
/****** Object:  StoredProcedure [dbo].[IniciarSesion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[IniciarSesion]
@Usuario nvarchar (100),
@Clave nvarchar (100)
as
select ID, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol from Usuarios where Usuario=@Usuario and Clave=@Clave
GO
/****** Object:  StoredProcedure [dbo].[ProveedorAgregarEnCurso]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorAgregarEnCurso]
@IdTurno int
as
update Turno 
set Estado='EnCurso'
where Id=@IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ProveedorAsignar]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorAsignar]
@IdProveedor int,
@IdTurno int
as
update Turno 
set IdProveedor=@IdProveedor, Estado='Asignado'
where Id=@IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarDisponibilidad]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProveedorCargarDisponibilidad]
@IdProveedor int
as
select HorarioInicio, HorarioFin 
from Usuarios
where Id = @IdProveedor
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnos]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorCargarTurnos]
@HorarioInicio int,
@HorarioFin int
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario,
Usuarios.Presencia, Usuarios.TipoPlan
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.Estado = 'Pendiente' and
Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnosBusqueda]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProveedorCargarTurnosBusqueda]
@HorarioInicio int,
@HorarioFin int,
@Busqueda nvarchar(100)
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario,
Usuarios.Presencia, Usuarios.TipoPlan
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where 
Turno.DiaNombre like '%' + @Busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin or
Turno.DiaNumero like '%' + @Busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin or 
Turno.Mes like '%' + @Busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin or 
Turno.Anio like '%' + @Busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin or 
Turno.Hora like '%' + @Busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin or
Turno.Descripcion like '%' + @Busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin
GO
/****** Object:  StoredProcedure [dbo].[RegistrarPresencia]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[RegistrarPresencia]
@Usuario nvarchar (100)
as
update Usuarios
set Presencia = 'Presente'
where Usuario=@Usuario
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargar]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargar]
@IdCliente int
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where IdCliente = @IdCliente

GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarAdmin]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarAdmin]
as
select Turno.Id, Turno.IdCliente, Turno.IdProveedor,
Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado, Turno.NombreProveedor,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarBusqueda]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarBusqueda]
@IdCliente int,
@Busqueda nvarchar(100)
as
SELECT Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor
FROM Turno 
where Id like '%' + @Busqueda + '%' and IdCliente = @IdCliente or  
DiaNombre like '%' + @Busqueda + '%' and IdCliente = @IdCliente or
DiaNumero like '%' + @Busqueda + '%' and IdCliente = @IdCliente or 
Mes like '%' + @Busqueda + '%' and IdCliente = @IdCliente or 
Anio like '%' + @Busqueda + '%' and IdCliente = @IdCliente or 
Hora like '%' + @Busqueda + '%' and IdCliente = @IdCliente or
Descripcion like '%' + @Busqueda + '%' and IdCliente = @IdCliente or 
Estado like '%' + @Busqueda + '%' and IdCliente = @IdCliente

GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarBusquedaAdmin]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarBusquedaAdmin]
@Busqueda nvarchar(100)
as
select Turno.Id, Turno.IdCliente, Turno.IdProveedor,
Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado, Turno.NombreProveedor,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where
Turno.DiaNombre like '%' + @Busqueda + '%'  or
Turno.DiaNumero like '%' + @Busqueda + '%'  or 
Turno.Mes like '%' + @Busqueda + '%'  or 
Turno.Anio like '%' + @Busqueda + '%'  or 
Turno.Hora like '%' + @Busqueda + '%'or
Turno.Estado like '%' + @Busqueda + '%' or
Usuarios.PrimerNombre like '%' + @Busqueda + '%'or
Usuarios.SegundoNombre like '%' + @Busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarDetalle]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarDetalle]
@IdTurno int
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarEstadoFiltradoAdmin]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarEstadoFiltradoAdmin]
@Estado nvarchar(100)
as
select Turno.Id, Turno.IdCliente, Turno.IdProveedor,
Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado, Turno.NombreProveedor,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id and Estado = @Estado
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarModificacion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarModificacion]
@IdCliente int
as
select IdTurno, DiaNombre, DiaNumero,Mes,Anio, NombreProveedor, Estado from TurnoModificacion where IdCliente = @IdCliente
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarProveedor]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarProveedor]
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.Estado = 'Pendiente'
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarProveedorAsignado]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarProveedorAsignado]
@IdProveedor int
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario,
Usuarios.TipoPlan
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.IdProveedor = @IdProveedor and Turno.Estado = 'Asignado'
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarProveedorEnCurso]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarProveedorEnCurso]
@IdProveedor int
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.Estado = 'En curso'
GO
/****** Object:  StoredProcedure [dbo].[TurnoCrear]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCrear]
@IdCliente int,
@DiaNombre nvarchar(50),
@DiaNumero nvarchar(50),
@Mes nvarchar(50),
@Anio nvarchar(50),
@Hora nvarchar(50),
@Descripcion nvarchar(50)
as
insert into Turno values (@IdCliente,null,@DiaNombre,@DiaNumero,@Mes, @Anio,@Hora,@Descripcion,'Pendiente','Sin definir');
GO
/****** Object:  StoredProcedure [dbo].[TurnoDarBaja]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoDarBaja]
@IdTurno int
as
update Turno set Estado='Cancelado' where Id=@IdTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoFiltrarEstado]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TurnoFiltrarEstado]
@IdCliente int,
@Estado nvarchar(100)
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where IdCliente = @IdCliente and Estado = @Estado
GO
/****** Object:  StoredProcedure [dbo].[TurnoModificacionAceptar]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TurnoModificacionAceptar]
@IdTurno int
as
update TurnoModificacion
set Estado = 'Aceptado'
where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoModificacionCambiarFecha]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoModificacionCambiarFecha]
@IdTurno int,
@DiaNumero nvarchar(50),
@DiaNombre nvarchar(50),
@Mes nvarchar(50),
@Anio nvarchar(50)
as
update Turno
set 
DiaNumero = @DiaNumero,
DiaNombre = @DiaNombre,
Mes = @Mes,
Anio = @Anio
where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoModificacionCambiarProveedor]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoModificacionCambiarProveedor]
@IdTurno int,
@NombreProveedor nvarchar(50)
as
update Turno
set 
NombreProveedor = @NombreProveedor
where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoModificacionFiltrarEstado]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TurnoModificacionFiltrarEstado]
@IdCliente int,
@Estado nvarchar(100)
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Estado, NombreProveedor 
from TurnoModificacion 
where IdCliente = @IdCliente and Estado = @Estado
GO
/****** Object:  StoredProcedure [dbo].[TurnoModificacionRechazar]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TurnoModificacionRechazar]
@IdTurno int
as
update TurnoModificacion
set Estado = 'Rechazado'
where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoProveedorFinalizar]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoProveedorFinalizar]
@IdTurno int
as
update Turno 
set Estado='Finalizado'
where Id=@IdTurno
GO
