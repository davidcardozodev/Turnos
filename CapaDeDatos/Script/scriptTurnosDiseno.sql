USE [Turnos]
GO
/****** Object:  Table [dbo].[Area]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Area](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
 CONSTRAINT [PK_Area] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[AsociacionEstablecimientoArea]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[AsociacionEstablecimientoArea](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdEstablecimiento] [int] NOT NULL,
	[IdArea] [int] NOT NULL,
 CONSTRAINT [PK_AsociacionEstablecimientoArea] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Establecimiento]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Establecimiento](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
 CONSTRAINT [PK_Establecimiento] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Lugar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Lugar](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
	[Disponible] [bit] NOT NULL,
	[IdProveedor] [int] NULL,
 CONSTRAINT [PK_Lugar] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Turno]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Turno](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdCliente] [int] NOT NULL,
	[IdProveedor] [int] NULL,
	[DiaNombre] [nvarchar](200) NOT NULL,
	[DiaNumero] [nvarchar](200) NOT NULL,
	[Mes] [nvarchar](200) NOT NULL,
	[Anio] [nvarchar](200) NOT NULL,
	[Hora] [nvarchar](200) NOT NULL,
	[Descripcion] [nvarchar](200) NOT NULL,
	[Estado] [nvarchar](200) NULL,
	[NombreProveedor] [nvarchar](200) NOT NULL,
	[Area] [nvarchar](200) NULL,
	[Establecimiento] [nvarchar](200) NULL,
	[Lugar] [nvarchar](200) NULL,
 CONSTRAINT [PK_ClienteTurno] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[TurnoModificacion]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[TurnoModificacion](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[IdTurno] [int] NOT NULL,
	[IdAdmin] [int] NOT NULL,
	[IdCliente] [int] NOT NULL,
	[DiaNombre] [nvarchar](200) NULL,
	[DiaNumero] [nvarchar](200) NULL,
	[Mes] [nvarchar](200) NULL,
	[Anio] [nvarchar](200) NULL,
	[NombreProveedor] [nvarchar](200) NULL,
	[Estado] [nvarchar](200) NULL,
 CONSTRAINT [PK_TurnoModificacion] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Usuarios]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Usuarios](
	[Id] [int] IDENTITY(1,1) NOT NULL,
	[Usuario] [nvarchar](200) NOT NULL,
	[Clave] [nvarchar](200) NOT NULL,
	[Nombre] [nvarchar](200) NULL,
	[Email] [nvarchar](200) NULL,
	[Rol] [nvarchar](200) NOT NULL,
	[HorarioInicio] [int] NULL,
	[HorarioFin] [int] NULL,
	[TipoPlan] [nvarchar](200) NULL,
	[Presencia] [nvarchar](200) NULL,
 CONSTRAINT [PK_Usuarios] PRIMARY KEY CLUSTERED 
(
	[Id] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO
ALTER TABLE [dbo].[Lugar] ADD  CONSTRAINT [DF_Lugar_Disponible]  DEFAULT ((1)) FOR [Disponible]
GO
/****** Object:  StoredProcedure [dbo].[AdminAsociarEstablecimientoArea]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminAsociarEstablecimientoArea]
@IdEstablecimiento int,
@IdArea int
as
insert into AsociacionEstablecimientoArea
values (@IdEstablecimiento, @IdArea)
GO
/****** Object:  StoredProcedure [dbo].[AdminAsociarLugar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminAsociarLugar]
@IdProveedor int,
@IdLugar int
as
update Lugar
set IdProveedor = @IdProveedor,
Disponible = 0
where Id = @IdLugar
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarArea]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminCargarArea]
as
select Id, Nombre from Area
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarAreaItem]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminCargarAreaItem]
as
select Id, Nombre
from Area
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarAreaItemBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarAreaItemBusqueda]
@Busqueda nvarchar(100)
as
select Id, Nombre
from Area
where Nombre like '%' + @Busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarEstablecimiento]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarEstablecimiento]
as
select Id, Nombre from Establecimiento
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarEstablecimientoItem]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminCargarEstablecimientoItem]
as
select Id, Nombre from Establecimiento
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarEstablecimientoItemBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarEstablecimientoItemBusqueda]
@Busqueda nvarchar(100)
as
select Id, Nombre
from Establecimiento
where Nombre like '%' + @Busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarLugares]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarLugares]
as
select Id, Nombre from Lugar where Disponible = 1
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarLugarItem]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarLugarItem]
as
select Id, Nombre from Lugar
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarLugarItemBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminCargarLugarItemBusqueda]
@Busqueda nvarchar(100)
as
select Id, Nombre
from Lugar
where Nombre like '%' + @Busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarProveedores]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarProveedores]
as
select Id, Nombre from Usuarios where Rol = 'Proveedor'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarTurno]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarTurno]
as
select Turno.Id, Turno.IdCliente, Turno.IdProveedor,
Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado, Turno.NombreProveedor,
Usuarios.Nombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarTurnoBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarTurnoBusqueda]
@Busqueda nvarchar(200)
as
select Turno.Id, Turno.IdCliente, Turno.IdProveedor,
Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado, Turno.NombreProveedor,
Usuarios.Nombre, Usuarios.Usuario
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
Usuarios.Nombre like '%' + @Busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarTurnoEstadoFiltrado]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarTurnoEstadoFiltrado]
@Estado nvarchar(200)
as
select Turno.Id, Turno.IdCliente, Turno.IdProveedor,
Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado, Turno.NombreProveedor,
Usuarios.Nombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id and Estado = @Estado
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarUsuario]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarUsuario]
as
select Id, Usuario, Clave, Nombre, Email, Rol, TipoPlan, HorarioInicio, HorarioFin 
from Usuarios
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarUsuarioBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarUsuarioBusqueda]
@Busqueda nvarchar(200)
as
select Id, Usuario, Clave, Nombre, Email, Rol , HorarioInicio, HorarioFin, TipoPlan
from Usuarios
where Id like '%' + @Busqueda + '%'or  
Usuario like '%' + @Busqueda + '%'or
Nombre like '%' + @Busqueda + '%'or 
Email like '%' + @Busqueda + '%'or
Rol like '%' + @Busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarUsuarioFiltrado]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminCargarUsuarioFiltrado]
@Rol nvarchar(200)
as
select Id, Usuario, Clave, Nombre, Email, Rol , HorarioInicio, HorarioFin, TipoPlan
from Usuarios
where Rol = @Rol
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarBajaNotificacion]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminGuardarBajaNotificacion]
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
/****** Object:  StoredProcedure [dbo].[AdminGuardarDisponibilidad]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminGuardarDisponibilidad]
@IdUsuario int,
@HorarioInicio int,
@HorarioFin int
as
update Usuarios set HorarioInicio=@HorarioInicio, HorarioFin=@HorarioFin where Id=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarModificacion]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminGuardarModificacion]
@IdTurno int,
@IdAdmin int,
@IdCliente int,
@DiaNombre nvarchar(200),
@DiaNumero nvarchar(200),
@Mes nvarchar(200),
@Anio nvarchar(200),
@NombreProveedor nvarchar(200)
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
'Pendiente')
GO
/****** Object:  StoredProcedure [dbo].[AdminModificarArea]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminModificarArea]
@IdArea int,
@Nombre nvarchar(200)
as
update Area 
set 
Nombre = @Nombre
where Id=@IdArea
GO
/****** Object:  StoredProcedure [dbo].[AdminModificarEstablecimiento]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminModificarEstablecimiento]
@IdEstablecimiento int,
@Nombre nvarchar(200)
as
update Establecimiento 
set 
Nombre = @Nombre
where Id=@IdEstablecimiento
GO
/****** Object:  StoredProcedure [dbo].[AdminModificarLugar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminModificarLugar]
@IdLugar int,
@Nombre nvarchar(200)
as
update Lugar 
set 
Nombre = @Nombre
where Id=@IdLugar
GO
/****** Object:  StoredProcedure [dbo].[AdminModificarUsuario]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminModificarUsuario]
@IdUsuario int,
@Usuario nvarchar(200),
@Clave nvarchar(200),
@Nombre nvarchar(200),
@Email nvarchar(200),
@Rol nvarchar(200),
@Plan nvarchar(200)
as
update Usuarios 
set 
Usuario = @Usuario,
Clave = @Clave,
Nombre = @Nombre,
Email = @Email,
Rol=@Rol,
TipoPlan = @Plan
where Id=@IdUsuario
GO
/****** Object:  StoredProcedure [dbo].[AdminRegistrarArea]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminRegistrarArea]
@Nombre nvarchar(200)
as
insert into Area 
values (@Nombre)
GO
/****** Object:  StoredProcedure [dbo].[AdminRegistrarEstablecimiento]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminRegistrarEstablecimiento]
@Nombre nvarchar(200)
as
insert into Establecimiento 
values (@Nombre)
GO
/****** Object:  StoredProcedure [dbo].[AdminRegistrarLugar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminRegistrarLugar]
@Nombre nvarchar(200)
as
insert into Lugar 
values (@Nombre,'1',NULL)
GO
/****** Object:  StoredProcedure [dbo].[AdminRegistrarUsuario]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminRegistrarUsuario]
@NombreUsuario nvarchar(200),
@Clave nvarchar(200),
@Nombre nvarchar(200),
@Email nvarchar(200),
@Rol nvarchar(200),
@HorarioInicio int,
@HorarioFin int,
@TipoPlan nvarchar(200)
as
insert into Usuarios 
values (@NombreUsuario, @Clave, @Nombre, @Email, @Rol, @HorarioInicio, @HorarioFin, @TipoPlan, 'Ausente')
GO
/****** Object:  StoredProcedure [dbo].[ClienteBuscarCoincidencia]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteBuscarCoincidencia]
@Usuario nvarchar(200),
@Clave nvarchar(200)
as
select ID from Usuarios where Usuario=@Usuario and Clave = @Clave
GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarArea]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarArea]
as
select Id, Nombre from Area
GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarAsociacionEstablecimientoLugar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarAsociacionEstablecimientoLugar]
@IdArea int
as
select Establecimiento.Id, Establecimiento.Nombre
from AsociacionEstablecimientoArea
INNER JOIN Establecimiento 
on AsociacionEstablecimientoArea.IdArea=@IdArea
and AsociacionEstablecimientoArea.IdEstablecimiento = Establecimiento.Id
GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarEstablecimiento]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ClienteCargarEstablecimiento]
as
select Nombre from Establecimiento
GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarTurno]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarTurno]
@IdCliente int
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where IdCliente = @IdCliente

GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarTurnoBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarTurnoBusqueda]
@IdCliente int,
@Busqueda nvarchar(200)
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
/****** Object:  StoredProcedure [dbo].[ClienteCargarTurnoDetalle]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarTurnoDetalle]
@IdTurno int
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarTurnoFiltrado]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarTurnoFiltrado]
@IdCliente int,
@Estado nvarchar(200)
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where IdCliente = @IdCliente and Estado = @Estado
GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarTurnoModificacion]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarTurnoModificacion]
@IdCliente int
as
select IdTurno, DiaNombre, DiaNumero,Mes,Anio, NombreProveedor, Estado from TurnoModificacion where IdCliente = @IdCliente
GO
/****** Object:  StoredProcedure [dbo].[ClienteCargarTurnoModificacionBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarTurnoModificacionBusqueda]
@IdCliente int,
@Busqueda nvarchar(200)
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
/****** Object:  StoredProcedure [dbo].[ClienteCargarTurnoModificacionFiltrado]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCargarTurnoModificacionFiltrado]
@IdCliente int,
@Estado nvarchar(200)
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Estado, NombreProveedor 
from TurnoModificacion 
where IdCliente = @IdCliente and Estado = @Estado
GO
/****** Object:  StoredProcedure [dbo].[ClienteCrearTurno]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteCrearTurno]
@IdCliente int,
@DiaNombre nvarchar(200),
@DiaNumero nvarchar(200),
@Mes nvarchar(200),
@Anio nvarchar(200),
@Hora nvarchar(200),
@Descripcion nvarchar(200),
@Area nvarchar(200),
@Establecimiento nvarchar(200)
as
insert into Turno 
values (@IdCliente,null,@DiaNombre,@DiaNumero,@Mes, @Anio,@Hora,@Descripcion,'Pendiente','Sin definir',@Area,@Establecimiento, null);
GO
/****** Object:  StoredProcedure [dbo].[ClienteRegistrarPresencia]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteRegistrarPresencia]
@Usuario nvarchar(200)
as
update Usuarios
set Presencia = 'Presente'
where Usuario=@Usuario
GO
/****** Object:  StoredProcedure [dbo].[ClienteTurnoModificacionAceptar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteTurnoModificacionAceptar]
@IdTurno int
as
update TurnoModificacion
set Estado = 'Aceptado'
where IdTurno = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ClienteTurnoModificacionCambiarFecha]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteTurnoModificacionCambiarFecha]
@IdTurno int,
@DiaNumero nvarchar(200),
@DiaNombre nvarchar(200),
@Mes nvarchar(200),
@Anio nvarchar(200)
as
update Turno
set 
DiaNumero = @DiaNumero,
DiaNombre = @DiaNombre,
Mes = @Mes,
Anio = @Anio
where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ClienteTurnoModificacionCambiarProveedor]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteTurnoModificacionCambiarProveedor]
@IdTurno int,
@NombreProveedor nvarchar(200)
as
update Turno
set 
NombreProveedor = @NombreProveedor
where Id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ClienteTurnoModificacionRechazar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ClienteTurnoModificacionRechazar]
@IdTurno int
as
update TurnoModificacion
set Estado = 'Rechazado'
where IdTurno = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ProveedorAgregarEnCurso]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorAgregarEnCurso]
@IdTurno int
as
update Turno 
set Estado='En curso'
where Id=@IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ProveedorAsignar]    Script Date: 15/12/2023 2:04:16 ******/
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
/****** Object:  StoredProcedure [dbo].[ProveedorCargarDisponibilidad]    Script Date: 15/12/2023 2:04:16 ******/
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
/****** Object:  StoredProcedure [dbo].[ProveedorCargarLugar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProveedorCargarLugar]
@IdProveedor int
as
select Nombre from Lugar where IdProveedor = @IdProveedor
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnoAsignado]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorCargarTurnoAsignado]
@IdProveedor int
as
select Turno.Id, Turno.Lugar, Usuarios.Nombre, Usuarios.TipoPlan
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.IdProveedor = @IdProveedor and Turno.Estado = 'Asignado'
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnoEnCurso]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorCargarTurnoEnCurso]
@IdProveedor int
as
select Turno.Id, Turno.Lugar, Usuarios.Nombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.Estado = 'En curso'
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnos]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorCargarTurnos]
@HorarioInicio int,
@HorarioFin int
as
select Turno.Id, Turno.IdCliente, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.Nombre, Usuarios.Usuario,
Usuarios.Presencia, Usuarios.TipoPlan
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.Estado = 'Pendiente' and
Turno.Hora >= @HorarioInicio and Turno.Hora <= @HorarioFin
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnosBusqueda]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorCargarTurnosBusqueda]
@HorarioInicio int,
@HorarioFin int,
@Busqueda nvarchar(200)
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.Nombre, Usuarios.Usuario,
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
/****** Object:  StoredProcedure [dbo].[ProveedorFinalizarTurno]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorFinalizarTurno]
@IdTurno int
as
update Turno 
set Estado='Finalizado'
where Id=@IdTurno
GO
/****** Object:  StoredProcedure [dbo].[ProveedorGuardarLugar]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProveedorGuardarLugar]
@IdTurno int,
@Lugar nvarchar(200)
as
update Turno
set Lugar = @Lugar
where id = @IdTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarProveedor]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarProveedor]
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.Nombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.Estado = 'Pendiente'
GO
/****** Object:  StoredProcedure [dbo].[TurnoDarBaja]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoDarBaja]
@IdTurno int
as
update Turno set Estado='Cancelado' where Id=@IdTurno
GO
/****** Object:  StoredProcedure [dbo].[UsuarioIniciarSesion]    Script Date: 15/12/2023 2:04:16 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[UsuarioIniciarSesion]
@Usuario nvarchar(200),
@Clave nvarchar(200)
as
select ID, Usuario, Clave, Nombre, Email, Rol from Usuarios where Usuario=@Usuario and Clave=@Clave
GO
