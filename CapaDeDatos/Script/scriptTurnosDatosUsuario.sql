USE [Turnos]
GO
SET IDENTITY_INSERT [dbo].[Usuarios] ON 

INSERT [dbo].[Usuarios] ([Id], [Usuario], [Clave], [Nombre], [Email], [Rol], [HorarioInicio], [HorarioFin], [TipoPlan], [Presencia]) VALUES (1, N'admin', N'1', N'Admin', N'admin@email.com', N'Admin', 8, 9, N'Basico', N'Ausente')
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Clave], [Nombre], [Email], [Rol], [HorarioInicio], [HorarioFin], [TipoPlan], [Presencia]) VALUES (2, N'cliente', N'1', N'Cliente', N'cliente@email.com', N'Cliente', 8, 9, N'Basico', N'Ausente')
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Clave], [Nombre], [Email], [Rol], [HorarioInicio], [HorarioFin], [TipoPlan], [Presencia]) VALUES (3, N'llamador', N'1', N'Llamador', N'sin dato', N'Llamador', 0, 0, N'Basico', N'Ausente')
INSERT [dbo].[Usuarios] ([Id], [Usuario], [Clave], [Nombre], [Email], [Rol], [HorarioInicio], [HorarioFin], [TipoPlan], [Presencia]) VALUES (4, N'proveedor', N'1', N'Proveedor', N'proveedor@email.com', N'Proveedor', 12, 19, N'Basico', N'Ausente')
SET IDENTITY_INSERT [dbo].[Usuarios] OFF
GO
