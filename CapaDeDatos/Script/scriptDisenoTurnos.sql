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
@busqueda nvarchar(100)
as
select Id, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol 
from Usuarios
where Id like '%' + @busqueda + '%'or  
Usuario like '%' + @busqueda + '%'or
PrimerNombre like '%' + @busqueda + '%'or 
SegundoNombre like '%' + @busqueda + '%'or 
Email like '%' + @busqueda + '%'or
Rol like '%' + @busqueda + '%'
GO
/****** Object:  StoredProcedure [dbo].[AdminCargarUsuarioFiltrado]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminCargarUsuarioFiltrado]
@rol nvarchar(100)
as
select Id, Usuario, Clave, PrimerNombre, SegundoNombre, Email, Rol 
from Usuarios
where Rol = @rol
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarBajaNotificacion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminGuardarBajaNotificacion]
@idTurno int,
@idAdmin int,
@idCliente int
as
insert into TurnoModificacion values
(
@idTurno,
@idAdmin,
@idCliente,
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
@idUsuario int,
@horarioInicio int,
@horarioFin int
as
update Usuarios set horarioInicio=@horarioInicio, horarioFin=@horarioFin where Id=@idUsuario
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarModificacion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminGuardarModificacion]
@idTurno int,
@idAdmin int,
@idCliente int,
@diaNombre nvarchar(50),
@diaNumero nvarchar(50),
@mes nvarchar(50),
@anio nvarchar(50),
@nombreProveedor nvarchar(50)
as
insert into TurnoModificacion values
(
@idTurno,
@idAdmin,
@idCliente,
@diaNombre, 
@diaNumero, 
@mes, 
@anio,
@nombreProveedor,
'')
GO
/****** Object:  StoredProcedure [dbo].[AdminGuardarProveedor]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminGuardarProveedor]
@idTurno int,
@nombreProveedor nvarchar(100)
as
update Turno set NombreProveedor=@nombreProveedor where Id=@idTurno
GO
/****** Object:  StoredProcedure [dbo].[AdminModificarUsuario]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[AdminModificarUsuario]
@idUsuario int,
@rol nvarchar(100)
as
update Usuarios set Rol=@rol where Id=@idUsuario
GO
/****** Object:  StoredProcedure [dbo].[AdminRegistrarUsuario]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[AdminRegistrarUsuario]
@nombreUsuario nvarchar(50),
@clave nvarchar(50),
@primerNombre nvarchar(50),
@segundoNombre nvarchar(50),
@email nvarchar(50),
@rol nvarchar(50),
@tipoPlan nvarchar(50)
as
insert into Usuarios values (@nombreUsuario, @clave, @primerNombre, @segundoNombre, @email, @rol, null, null, @tipoPlan, 'Ausente')
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
@idCliente int,
@busqueda nvarchar(100)
as
select IdTurno, DiaNombre, DiaNumero,Mes,Anio, NombreProveedor, Estado
from TurnoModificacion
where
DiaNombre like '%' + @busqueda + '%' and IdCliente = @idCliente or
DiaNumero like '%' + @busqueda + '%' and IdCliente = @idCliente or 
Mes like '%' + @busqueda + '%' and IdCliente = @idCliente or 
Anio like '%' + @busqueda + '%' and IdCliente = @idCliente or 
NombreProveedor like '%' + @busqueda + '%' and IdCliente = @idCliente or
Estado like '%' + @busqueda + '%' and IdCliente = @idCliente
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
@idTurno int
as
update Turno 
set Estado='EnCurso'
where Id=@idTurno
GO
/****** Object:  StoredProcedure [dbo].[ProveedorAsignar]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorAsignar]
@idProveedor int,
@idTurno int
as
update Turno 
set IdProveedor=@idProveedor, Estado='Asignado'
where Id=@idTurno
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarDisponibilidad]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProveedorCargarDisponibilidad]
@idProveedor int
as
select HorarioInicio, HorarioFin 
from Usuarios
where Id = @idProveedor
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnos]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[ProveedorCargarTurnos]
@horarioInicio int,
@horarioFin int
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
Turno.Hora >= @horarioInicio and Turno.Hora <= @horarioFin
GO
/****** Object:  StoredProcedure [dbo].[ProveedorCargarTurnosBusqueda]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[ProveedorCargarTurnosBusqueda]
@horarioInicio int,
@horarioFin int,
@busqueda nvarchar(100)
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
Turno.DiaNombre like '%' + @busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @horarioInicio and Turno.Hora <= @horarioFin or
Turno.DiaNumero like '%' + @busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @horarioInicio and Turno.Hora <= @horarioFin or 
Turno.Mes like '%' + @busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @horarioInicio and Turno.Hora <= @horarioFin or 
Turno.Anio like '%' + @busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @horarioInicio and Turno.Hora <= @horarioFin or 
Turno.Hora like '%' + @busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @horarioInicio and Turno.Hora <= @horarioFin or
Turno.Descripcion like '%' + @busqueda + '%' and Turno.Estado = 'Pendiente' and Turno.Hora >= @horarioInicio and Turno.Hora <= @horarioFin
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
@idCliente int
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where IdCliente = @idCliente

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
@busqueda nvarchar(100)
as
SELECT Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor
FROM Turno 
where Id like '%' + @busqueda + '%' and IdCliente = @IdCliente or  
DiaNombre like '%' + @busqueda + '%' and IdCliente = @IdCliente or
DiaNumero like '%' + @busqueda + '%' and IdCliente = @IdCliente or 
Mes like '%' + @busqueda + '%' and IdCliente = @IdCliente or 
Anio like '%' + @busqueda + '%' and IdCliente = @IdCliente or 
Hora like '%' + @busqueda + '%' and IdCliente = @IdCliente or
Descripcion like '%' + @busqueda + '%' and IdCliente = @IdCliente or 
Estado like '%' + @busqueda + '%' and IdCliente = @IdCliente

GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarBusquedaAdmin]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarBusquedaAdmin]
@busqueda nvarchar(100)
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
Turno.DiaNombre like '%' + @busqueda + '%'  or
Turno.DiaNumero like '%' + @busqueda + '%'  or 
Turno.Mes like '%' + @busqueda + '%'  or 
Turno.Anio like '%' + @busqueda + '%'  or 
Turno.Hora like '%' + @busqueda + '%'or
Turno.Estado like '%' + @busqueda + '%' or
Usuarios.PrimerNombre like '%' + @busqueda + '%'or
Usuarios.SegundoNombre like '%' + @busqueda + '%'
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
@estado nvarchar(100)
as
select Turno.Id, Turno.IdCliente, Turno.IdProveedor,
Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado, Turno.NombreProveedor,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id and Estado = @estado
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarModificacion]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarModificacion]
@idCliente int
as
select IdTurno, DiaNombre, DiaNumero,Mes,Anio, NombreProveedor, Estado from TurnoModificacion where IdCliente = @idCliente
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
@idProveedor int
as
select Turno.Id, Turno.IdCliente, Turno.DiaNombre, 
Turno.DiaNumero, Turno.Mes, Turno.Anio, 
Turno.Hora, Turno.Descripcion, Turno.Estado,
Usuarios.PrimerNombre, Usuarios.SegundoNombre, Usuarios.Usuario,
Usuarios.TipoPlan
from Turno
inner join Usuarios
on Turno.IdCliente = Usuarios.Id
where Turno.IdProveedor = @idProveedor and Turno.Estado = 'Asignado'
GO
/****** Object:  StoredProcedure [dbo].[TurnoCargarProveedorEnCurso]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoCargarProveedorEnCurso]
@idProveedor int
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
@idCliente int,
@diaNombre nvarchar(50),
@diaNumero nvarchar(50),
@mes nvarchar(50),
@anio nvarchar(50),
@hora nvarchar(50),
@descripcion nvarchar(50)
as
insert into Turno values (@idCliente,null,@diaNombre,@diaNumero,@mes, @anio,@hora,@descripcion,'Pendiente','Sin definir');
GO
/****** Object:  StoredProcedure [dbo].[TurnoDarBaja]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[TurnoDarBaja]
@idTurno int
as
update Turno set Estado='Cancelado' where Id=@idTurno
GO
/****** Object:  StoredProcedure [dbo].[TurnoFiltrarEstado]    Script Date: 25/08/2023 11:22:39 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[TurnoFiltrarEstado]
@idCliente int,
@estado nvarchar(100)
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Hora, Descripcion, Estado, NombreProveedor from Turno where IdCliente = @idCliente and Estado = @estado
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
@diaNumero nvarchar(50),
@diaNombre nvarchar(50),
@mes nvarchar(50),
@anio nvarchar(50)
as
update Turno
set 
diaNumero = @diaNumero,
diaNombre = @diaNombre,
mes = @mes,
anio = @anio
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
@idCliente int,
@estado nvarchar(100)
as
select Id, DiaNombre, DiaNumero,Mes,Anio, Estado, NombreProveedor 
from TurnoModificacion 
where IdCliente = @idCliente and Estado = @estado
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
@idTurno int
as
update Turno 
set Estado='Finalizado'
where Id=@idTurno
GO
