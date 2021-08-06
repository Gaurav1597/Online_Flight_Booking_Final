INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'7aa5b817-d11b-4e3e-b4df-61b3593eda26', N'flight_admin', N'flight_admin', N'72d7ab8e-fb4b-4f21-842e-e1c37721915a')
INSERT INTO [dbo].[AspNetRoles] ([Id], [Name], [NormalizedName], [ConcurrencyStamp]) VALUES (N'fe81998b-e3d8-447b-a2e0-80fdc7800d28', N'passenger', N'passenger', N'529b7694-478e-4e68-876f-b6ab1af1a065')
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'208eb7fe-25cc-4637-81cc-8d2c0e14955f', N'admin@flights.com', N'ADMIN@FLIGHTS.COM', N'admin@flights.com', N'ADMIN@FLIGHTS.COM', 1, N'AQAAAAEAACcQAAAAEJsPRfh2dyjNf05M61xXvN6ayqvep6llKy3v3HEmc0w9Zj3tfvGHGNXb7wyvlIrWVw==', N'UEEPLAQ42TNTBQXVJ66OEI6FO7HODWOI', N'8d85658f-255e-4c03-a0a6-b3c613a6e978', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'7fb48f7c-9ab4-4213-afb4-0428977af264', N'brian@gmail.com', N'BRIAN@GMAIL.COM', N'brian@gmail.com', N'BRIAN@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEPYkPv1V4ORWn/wZv9DAo+yGb/GfGpYdFjGiFQG1howuXFZiQooZ82kIzJO1IrFPSw==', N'5RX3K4BBBETCAJ2TAJT4476P2QZWK736', N'09d166e2-50a1-4137-9182-43902a8b5fdb', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUsers] ([Id], [UserName], [NormalizedUserName], [Email], [NormalizedEmail], [EmailConfirmed], [PasswordHash], [SecurityStamp], [ConcurrencyStamp], [PhoneNumber], [PhoneNumberConfirmed], [TwoFactorEnabled], [LockoutEnd], [LockoutEnabled], [AccessFailedCount]) VALUES (N'a6ab4c3d-ead6-4fe4-aee1-1f627f63d04a', N'kim@gmail.com', N'KIM@GMAIL.COM', N'kim@gmail.com', N'KIM@GMAIL.COM', 1, N'AQAAAAEAACcQAAAAEHN822IMypFv/eCGZKEu6FNYptJUpHm/w5gxpp9TiofEfPopxsJ17D4QxeZr16RHkA==', N'DPYU3JZ5UTPNQ56VPHK7X3NNHROV3VSE', N'699b5a5a-3a6f-4d64-804f-9b6108ed7e0d', NULL, 0, 0, NULL, 1, 0)
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'208eb7fe-25cc-4637-81cc-8d2c0e14955f', N'7aa5b817-d11b-4e3e-b4df-61b3593eda26')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'7fb48f7c-9ab4-4213-afb4-0428977af264', N'fe81998b-e3d8-447b-a2e0-80fdc7800d28')
INSERT INTO [dbo].[AspNetUserRoles] ([UserId], [RoleId]) VALUES (N'a6ab4c3d-ead6-4fe4-aee1-1f627f63d04a', N'fe81998b-e3d8-447b-a2e0-80fdc7800d28')
SET IDENTITY_INSERT [dbo].[Flight] ON
INSERT INTO [dbo].[Flight] ([Id], [FlightNumber], [From], [To], [Price], [Scheduled]) VALUES (1, N'BA234', N'Auckland', N'London', CAST(800.00 AS Decimal(18, 2)), N'2020-09-02 03:34:00')
INSERT INTO [dbo].[Flight] ([Id], [FlightNumber], [From], [To], [Price], [Scheduled]) VALUES (2, N'NZ886', N'Wellington', N'Sydney', CAST(400.00 AS Decimal(18, 2)), N'2020-09-03 09:00:00')
INSERT INTO [dbo].[Flight] ([Id], [FlightNumber], [From], [To], [Price], [Scheduled]) VALUES (3, N'AA876', N'Auckland', N'Washington DC', CAST(900.00 AS Decimal(18, 2)), N'2020-09-18 07:45:00')
SET IDENTITY_INSERT [dbo].[Flight] OFF
SET IDENTITY_INSERT [dbo].[Passenger] ON
INSERT INTO [dbo].[Passenger] ([Id], [Email], [Name], [Mobile]) VALUES (1, N'brian@gmail.com', N'Brian Thomas', N'0213334567')
INSERT INTO [dbo].[Passenger] ([Id], [Email], [Name], [Mobile]) VALUES (2, N'kim@gmail.com', N'Kim Kelly', N'02133345678')
SET IDENTITY_INSERT [dbo].[Passenger] OFF
SET IDENTITY_INSERT [dbo].[FlightBooking] ON
INSERT INTO [dbo].[FlightBooking] ([Id], [FlightId], [PassengerId]) VALUES (1, 1, 1)
INSERT INTO [dbo].[FlightBooking] ([Id], [FlightId], [PassengerId]) VALUES (2, 2, 2)
SET IDENTITY_INSERT [dbo].[FlightBooking] OFF
