SET IDENTITY_INSERT [dbo].[Flight] ON
INSERT INTO [dbo].[Flight] ([Id], [FlightNumber], [From], [To], [Price], [Scheduled]) VALUES (1, N'BA234', N'Auckland', N'London', CAST(800.00 AS Decimal(18, 2)), N'2020-01-23 03:34:00')
INSERT INTO [dbo].[Flight] ([Id], [FlightNumber], [From], [To], [Price], [Scheduled]) VALUES (2, N'NZ886', N'Wellington', N'Sydney', CAST(400.00 AS Decimal(18, 2)), N'2020-01-31 09:00:00')
INSERT INTO [dbo].[Flight] ([Id], [FlightNumber], [From], [To], [Price], [Scheduled]) VALUES (3, N'AA876', N'Auckland', N'Washington DC', CAST(900.00 AS Decimal(18, 2)), N'2020-02-19 07:45:00')
SET IDENTITY_INSERT [dbo].[Flight] OFF
