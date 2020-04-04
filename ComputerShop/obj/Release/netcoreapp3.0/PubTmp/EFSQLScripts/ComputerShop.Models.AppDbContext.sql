IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804201834_InitialMigration')
BEGIN
    CREATE TABLE [Categories] (
        [CategoryId] int NOT NULL IDENTITY,
        [CategoryImage] nvarchar(max) NULL,
        [CategoryName] nvarchar(max) NULL,
        CONSTRAINT [PK_Categories] PRIMARY KEY ([CategoryId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804201834_InitialMigration')
BEGIN
    CREATE TABLE [Products] (
        [ProductId] int NOT NULL IDENTITY,
        [Name] nvarchar(max) NULL,
        [Price] decimal(18,2) NOT NULL,
        [Image] nvarchar(max) NULL,
        [Description] nvarchar(max) NULL,
        [IsProductOfTheWeek] bit NOT NULL,
        [InStock] bit NOT NULL,
        [CategoryId] int NOT NULL,
        CONSTRAINT [PK_Products] PRIMARY KEY ([ProductId]),
        CONSTRAINT [FK_Products_Categories_CategoryId] FOREIGN KEY ([CategoryId]) REFERENCES [Categories] ([CategoryId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804201834_InitialMigration')
BEGIN
    CREATE INDEX [IX_Products_CategoryId] ON [Products] ([CategoryId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804201834_InitialMigration')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190804201834_InitialMigration', N'3.0.0-preview9.19423.6');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804202251_SeedDataAdded')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [CategoryImage], [CategoryName])
    VALUES (1, N'/Images/category/Notebooks.png', N'Notebooks');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804202251_SeedDataAdded')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [CategoryImage], [CategoryName])
    VALUES (2, N'/Images/category/Computers.png', N'Computers');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804202251_SeedDataAdded')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [CategoryImage], [CategoryName])
    VALUES (3, N'/Images/category/Monitors.png', N'Monitors');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804202251_SeedDataAdded')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [CategoryImage], [CategoryName])
    VALUES (4, N'/Images/category/ComputerHardware.png', N'Computer Hardware');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804202251_SeedDataAdded')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] ON;
    INSERT INTO [Categories] ([CategoryId], [CategoryImage], [CategoryName])
    VALUES (5, N'/Images/category/Tablets.png', N'Tablets');
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'CategoryId', N'CategoryImage', N'CategoryName') AND [object_id] = OBJECT_ID(N'[Categories]'))
        SET IDENTITY_INSERT [Categories] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804202251_SeedDataAdded')
BEGIN
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'Name', N'Price', N'Image', N'Description', N'IsProductOfTheWeek', N'InStock', N'CategoryId') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] ON;
    INSERT INTO [Products] ([ProductId], [Name], [Price], [Image], [Description], [IsProductOfTheWeek], [InStock], [CategoryId])
    VALUES (1, N'Notebook Lenovo IdeaPad 330-15AST (81D600TDRA) Onyx Black', 4999.0, N'/Images/notebook/lenovo_81d600jyra.jpg', N'Screen 15.6" TN + film(1366x768) HD, matte / AMD E2 - 9000(1.8 - 2.2 GHz) / RAM 4 GB / SSD 128 GB / AMD Radeon R2 Graphics / without OD / LAN / Wi - Fi / Bluetooth / web - camera / DOS / 2.2 kg / black', CAST(1 AS bit), CAST(1 AS bit), 1),
    (2, N'Notebook Asus ROG Strix G531GT-AL029 (90NR01L3-M10560) Black', 24999.0, N'/Images/notebook/asus_90nr01l3_m02530.jpg', N'Screen 15.6" IPS(1920x1080) Full HD 120 Hz, matte / Intel Core i5 - 9300H(2.4 - 4.1 GHz) / RAM 8 GB / SSD 256 GB / nVidia GeForce GTX 1650, 4 GB / without OD / LAN / Wi - Fi / Bluetooth / without OS / 2.35 kg / black', CAST(1 AS bit), CAST(1 AS bit), 1),
    (3, N'Notebook Acer Aspire 5 A515-54G-50EQ (NX.HN5EU.00J) Pure Silver', 16499.0, N'/Images/notebook/acer_nx_hfreu_038_5e395313e5c5a.jpg', N'Screen 15.6" IPS (1920x1080) Full HD, matte / Intel Core i5-10210U (1.6 - 4.2 GHz) / RAM 8 GB / SSD 512 GB / nVidia GeForce MX250, 2 GB / without OD / LAN / Wi-Fi / Bluetooth / webcam / without OS / 1.8 kg / silver', CAST(1 AS bit), CAST(1 AS bit), 1),
    (4, N'Notebook Lenovo Legion Y740-15IRHg (81UH006CRA) Black', 83499.0, N'/Images/notebook/lenovo_81uh006cra.jpg', N'Screen 15.6" IPS (1920x1080) Full HD 144 Hz, glossy anti-glare / Intel Core i7-9750H (2.6 - 4.5 GHz) / RAM 32 GB / SSD 1 TB / nVidia GeForce RTX 2070, 8 GB / without OD / LAN / Wi-Fi / Bluetooth / webcam / Windows 10 Home 64bit / 2.2 kg / black', CAST(1 AS bit), CAST(1 AS bit), 1),
    (5, N'ARTLINE Gaming X39 v33 (X39v33)', 23399.0, N'/Images/computer/artline_x39v33.jpg', N'Intel Core i5-9400F (2.9 - 4.1 GHz) / RAM 16 GB / HDD 1 TB + SSD 240 GB / nVidia GeForce GTX 1660 Ti, 6 GB / without OD / LAN / without OS', CAST(1 AS bit), CAST(1 AS bit), 2),
    (6, N'Artline Gaming X33 v04 (X33v04)', 19499.0, N'/Images/computer/artline_x33v04.jpg', N'Intel Core i5-9400F (2.9 - 4.1 GHz) / RAM 16 GB / HDD 1 TB + SSD 480 GB / nVidia GeForce GTX 1650, 4 GB / without OD / LAN / without OS', CAST(1 AS bit), CAST(1 AS bit), 2),
    (7, N'ARTLINE Gaming X48 v04 (X48v04)', 19888.0, N'/Images/computer/artline_x48v04.jpg', N'AMD Ryzen 5 2600 (3.4 - 3.9 GHz) / RAM 16 GB / HDD 1 TB + SSD 240 GB / AMD Radeon RX580, 8 GB / without OD / LAN / without OS', CAST(1 AS bit), CAST(1 AS bit), 2),
    (8, N'Artline Overlord RTX P99 v11 (P99v11)', 221376.0, N'/Images/computer/artline_p98v11.jpg', N'Intel Core i9-9900X (3.5 - 4.4 GHz) / RAM 64 GB / HDD 4 TB + SSD 1 TB / 2 x nVidia GeForce RTX 2080 Ti, 11 GB / without OD / LAN / Windows 10 Pro', CAST(1 AS bit), CAST(1 AS bit), 2),
    (9, N'Monitor 23.8" Philips 245E1S/00/01 - 75 Hz frequency, 8-Bit, FreeSync', 5099.0, N'/Images/monitor/philips_245e1s_00.jpg', N'Display diagonal: 23.8" / Maximum display resolution: 2560 x 1440 / Matrix type: IPS / Features: Flicker - Free', CAST(1 AS bit), CAST(1 AS bit), 3),
    (10, N'Monitor 31.5" LG UltraGear 32GK650F-B', 9999.0, N'/Images/monitor/lg_32gk650f_b.jpg', N'Display diagonal: 31.5" / Maximum display resolution: 2560 x 1440 / Matrix type: VA / Features: Pivot. Height adjustment', CAST(1 AS bit), CAST(1 AS bit), 3),
    (11, N'Monitor 32" BenQ PV3200PT (9H.LEFLB.QBE)', 28999.0, N'/Images/monitor/benq_9h_leflb_qbe.jpg', N'Display diagonal: 32" / Maximum display resolution: 3840 x 2160 / Matrix type: IPS / Features: Height adjustment. Pivot. Flicker-Free', CAST(1 AS bit), CAST(1 AS bit), 3),
    (12, N'Monitor 42.5" LG UltraFine 43UD79-B', 16499.0, N'/Images/monitor/lg_43ud79_b.jpg', N'Display diagonal: 42.5" / Maximum display resolution: 3840 x 2160 / Matrix type: IPS / Features: Сinema screen. USB hub. Flicker-Free', CAST(1 AS bit), CAST(1 AS bit), 3),
    (13, N'Motherboard MSI MEG X570 Godlike (sAM4, AMD X570, PCI-Ex16)', 23360.0, N'/Images/computerhardware/msi_meg_x570_godlike.jpg', N'Connector type: Socket AM4 / Form factor: E-ATX / Memory support: 4 x DDR4 DIMM; Number of channels 2 / Processor support: AMD Ryzen 2nd and 3rd generation / Ryzen with Radeon Vega graphics core', CAST(1 AS bit), CAST(1 AS bit), 4),
    (14, N'Processor AMD Ryzen 9 3950X 3.5GHz/64MB (100-100000051WOF) sAM4 BOX', 25850.0, N'/Images/computerhardware/amd_ryzen_9_3950x.jpg', N'Processor family: AMD Ryzen 9 / Connector type: Socket AM4 / Number of cores: 16 / Integrated graphics: No / Internal clock speed: 3500 MHz / L3 cache size: 64 MB', CAST(1 AS bit), CAST(1 AS bit), 4),
    (15, N'RAM HyperX DDR4-3600 32768MB PC4-28800 (Kit of 2x16384) Predator (HX436C17PB3K2/32)', 9550.0, N'/Images/computerhardware/hyperx_hx433c16pb3k2_32_5cd3ccd839aac.jpg', N'Memory size: 32 GB / Memory type: DDR4 SDRAM / Memory frequency: 3600 MHz / Number of strips: 2 / Function: For Desktop', CAST(1 AS bit), CAST(1 AS bit), 4),
    (16, N'Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix 11GB GDDR6 (352bit) (1350/14000) (2 x HDMI, 2 x DisplayPort, 1 x USB Type-C) (ROG-STRIX-RTX2080TI-O11G-GAMING)', 44465.0, N'/Images/computerhardware/asus_rog_strix_rtx2080ti_o11g_gaming.jpg', N'Graphics chip: GeForce RTX 2080 Ti / Memory size: 11 GB / Memory Bus Width: 352 bit / Memory type: GDDR6 / Type of cooling system: Active', CAST(1 AS bit), CAST(1 AS bit), 4),
    (17, N'Tablet Panasonic Toughpad FZ-M1 (FZ-M1F150RT9)', 86599.0, N'/Images/tablet/panasonic_fz_m1f150rt9.jpg', N'Screen 7" IPS (1280x800) capacitive, MultiTouch / Intel Core i5-7Y57 vPro (1.2 - 3.3 GHz) / RAM 4 GB / 128 GB internal memory / 3G / Wi-Fi / Bluetooth 4.1 / 8MP main camera, 2MP front camera / dustproof / waterproof IP65 / Windows 10 Pro / 540 g / silver black', CAST(1 AS bit), CAST(1 AS bit), 5),
    (18, N'Apple iPad pro 11" a1980 wi-fi 1tb 2018 10172232', 55999.0, N'/Images/tablet/apple_mtxw2.jpg', N'Screen 11" IPS (2388x1668) capacitive MultiTouch / Apple A12X Bionic / RAM 4 GB / 1 TB internal memory / Wi-Fi / Bluetooth 5.0 / 12MP main camera, 7MP front camera / iOS 12 / 468 g / silver', CAST(1 AS bit), CAST(1 AS bit), 5),
    (19, N'Tablet Microsoft Surface Pro 6 12.3" (LQ6-00019) Black', 39999.0, N'/Images/tablet/microsoft_lq6_00019.jpg', N'Screen 12.3" (2736x1824) Multitouch / Intel Core i5-8350U (1.7 - 3.6 GHz) / RAM 8 GB / 256 GB internal memory + microSD / Wi-Fi / Bluetooth 4.1 / 8MP main camera, 5MP front camera / Windows 10 Home / 770 g / black', CAST(1 AS bit), CAST(1 AS bit), 5),
    (20, N'Tablet Samsung Galaxy Tab S6 10.5" 6/128GB LTE Grey (SM-T865NZAASEK)', 24999.0, N'/Images/tablet/samsung_sm_t865nzaasek.jpg', N'Screen 10.5" (2560x1600) capacitive MultiTouch / Qualcomm Snapdragon 855 (1x2.8 GHz + 2x2.4 GHz + 4x1.7 GHz) / RAM 6 GB / 128 GB internal memory + microSD / 3G / 4G / Wi-Fi / Bluetooth 5.0 / 13 Мп + 5 Мп main dual camera, 8 Мп front camera / GPS / GLONASS / Android 9.0 (Pie) / 420 g / grey', CAST(1 AS bit), CAST(1 AS bit), 5);
    IF EXISTS (SELECT * FROM [sys].[identity_columns] WHERE [name] IN (N'ProductId', N'Name', N'Price', N'Image', N'Description', N'IsProductOfTheWeek', N'InStock', N'CategoryId') AND [object_id] = OBJECT_ID(N'[Products]'))
        SET IDENTITY_INSERT [Products] OFF;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190804202251_SeedDataAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190804202251_SeedDataAdded', N'3.0.0-preview9.19423.6');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805192600_AddShoppingCartItem')
BEGIN
    CREATE TABLE [ShoppingCartItems] (
        [ShoppingCartItemId] int NOT NULL IDENTITY,
        [ProductId] int NULL,
        [Amount] int NOT NULL,
        [ShoppingCartId] nvarchar(max) NULL,
        CONSTRAINT [PK_ShoppingCartItems] PRIMARY KEY ([ShoppingCartItemId]),
        CONSTRAINT [FK_ShoppingCartItems_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId]) ON DELETE NO ACTION
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805192600_AddShoppingCartItem')
BEGIN
    CREATE INDEX [IX_ShoppingCartItems_ProductId] ON [ShoppingCartItems] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805192600_AddShoppingCartItem')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190805192600_AddShoppingCartItem', N'3.0.0-preview9.19423.6');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805201030_OrdersAdded')
BEGIN
    CREATE TABLE [Orders] (
        [OrderId] int NOT NULL IDENTITY,
        [FirstName] nvarchar(max) NULL,
        [LastName] nvarchar(max) NULL,
        [AddressLine1] nvarchar(max) NULL,
        [AddressLine2] nvarchar(max) NULL,
        [ZipCode] nvarchar(max) NULL,
        [City] nvarchar(max) NULL,
        [State] nvarchar(max) NULL,
        [Country] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [Email] nvarchar(max) NULL,
        [OrderTotal] decimal(18,2) NOT NULL,
        [OrderPlaced] datetime2 NOT NULL,
        CONSTRAINT [PK_Orders] PRIMARY KEY ([OrderId])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805201030_OrdersAdded')
BEGIN
    CREATE TABLE [OrderDetails] (
        [OrderDetailId] int NOT NULL IDENTITY,
        [OrderId] int NOT NULL,
        [ProductId] int NOT NULL,
        [Amount] int NOT NULL,
        [Price] decimal(18,2) NOT NULL,
        CONSTRAINT [PK_OrderDetails] PRIMARY KEY ([OrderDetailId]),
        CONSTRAINT [FK_OrderDetails_Orders_OrderId] FOREIGN KEY ([OrderId]) REFERENCES [Orders] ([OrderId]) ON DELETE CASCADE,
        CONSTRAINT [FK_OrderDetails_Products_ProductId] FOREIGN KEY ([ProductId]) REFERENCES [Products] ([ProductId]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805201030_OrdersAdded')
BEGIN
    CREATE INDEX [IX_OrderDetails_OrderId] ON [OrderDetails] ([OrderId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805201030_OrdersAdded')
BEGIN
    CREATE INDEX [IX_OrderDetails_ProductId] ON [OrderDetails] ([ProductId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805201030_OrdersAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190805201030_OrdersAdded', N'3.0.0-preview9.19423.6');
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var0 sysname;
    SELECT @var0 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'ZipCode');
    IF @var0 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var0 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [ZipCode] nvarchar(10) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var1 sysname;
    SELECT @var1 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'State');
    IF @var1 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var1 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [State] nvarchar(10) NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var2 sysname;
    SELECT @var2 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'PhoneNumber');
    IF @var2 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var2 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [PhoneNumber] nvarchar(25) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var3 sysname;
    SELECT @var3 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'LastName');
    IF @var3 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var3 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [LastName] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var4 sysname;
    SELECT @var4 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'FirstName');
    IF @var4 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var4 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [FirstName] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var5 sysname;
    SELECT @var5 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'Email');
    IF @var5 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var5 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [Email] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var6 sysname;
    SELECT @var6 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'Country');
    IF @var6 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var6 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [Country] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var7 sysname;
    SELECT @var7 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'City');
    IF @var7 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var7 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [City] nvarchar(50) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    DECLARE @var8 sysname;
    SELECT @var8 = [d].[name]
    FROM [sys].[default_constraints] [d]
    INNER JOIN [sys].[columns] [c] ON [d].[parent_column_id] = [c].[column_id] AND [d].[parent_object_id] = [c].[object_id]
    WHERE ([d].[parent_object_id] = OBJECT_ID(N'[Orders]') AND [c].[name] = N'AddressLine1');
    IF @var8 IS NOT NULL EXEC(N'ALTER TABLE [Orders] DROP CONSTRAINT [' + @var8 + '];');
    ALTER TABLE [Orders] ALTER COLUMN [AddressLine1] nvarchar(100) NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetRoles] (
        [Id] nvarchar(450) NOT NULL,
        [Name] nvarchar(256) NULL,
        [NormalizedName] nvarchar(256) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoles] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUsers] (
        [Id] nvarchar(450) NOT NULL,
        [UserName] nvarchar(256) NULL,
        [NormalizedUserName] nvarchar(256) NULL,
        [Email] nvarchar(256) NULL,
        [NormalizedEmail] nvarchar(256) NULL,
        [EmailConfirmed] bit NOT NULL,
        [PasswordHash] nvarchar(max) NULL,
        [SecurityStamp] nvarchar(max) NULL,
        [ConcurrencyStamp] nvarchar(max) NULL,
        [PhoneNumber] nvarchar(max) NULL,
        [PhoneNumberConfirmed] bit NOT NULL,
        [TwoFactorEnabled] bit NOT NULL,
        [LockoutEnd] datetimeoffset NULL,
        [LockoutEnabled] bit NOT NULL,
        [AccessFailedCount] int NOT NULL,
        CONSTRAINT [PK_AspNetUsers] PRIMARY KEY ([Id])
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetRoleClaims] (
        [Id] int NOT NULL IDENTITY,
        [RoleId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetRoleClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetRoleClaims_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserClaims] (
        [Id] int NOT NULL IDENTITY,
        [UserId] nvarchar(450) NOT NULL,
        [ClaimType] nvarchar(max) NULL,
        [ClaimValue] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserClaims] PRIMARY KEY ([Id]),
        CONSTRAINT [FK_AspNetUserClaims_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserLogins] (
        [LoginProvider] nvarchar(128) NOT NULL,
        [ProviderKey] nvarchar(128) NOT NULL,
        [ProviderDisplayName] nvarchar(max) NULL,
        [UserId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserLogins] PRIMARY KEY ([LoginProvider], [ProviderKey]),
        CONSTRAINT [FK_AspNetUserLogins_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserRoles] (
        [UserId] nvarchar(450) NOT NULL,
        [RoleId] nvarchar(450) NOT NULL,
        CONSTRAINT [PK_AspNetUserRoles] PRIMARY KEY ([UserId], [RoleId]),
        CONSTRAINT [FK_AspNetUserRoles_AspNetRoles_RoleId] FOREIGN KEY ([RoleId]) REFERENCES [AspNetRoles] ([Id]) ON DELETE CASCADE,
        CONSTRAINT [FK_AspNetUserRoles_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE TABLE [AspNetUserTokens] (
        [UserId] nvarchar(450) NOT NULL,
        [LoginProvider] nvarchar(128) NOT NULL,
        [Name] nvarchar(128) NOT NULL,
        [Value] nvarchar(max) NULL,
        CONSTRAINT [PK_AspNetUserTokens] PRIMARY KEY ([UserId], [LoginProvider], [Name]),
        CONSTRAINT [FK_AspNetUserTokens_AspNetUsers_UserId] FOREIGN KEY ([UserId]) REFERENCES [AspNetUsers] ([Id]) ON DELETE CASCADE
    );
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetRoleClaims_RoleId] ON [AspNetRoleClaims] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE UNIQUE INDEX [RoleNameIndex] ON [AspNetRoles] ([NormalizedName]) WHERE [NormalizedName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetUserClaims_UserId] ON [AspNetUserClaims] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetUserLogins_UserId] ON [AspNetUserLogins] ([UserId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE INDEX [IX_AspNetUserRoles_RoleId] ON [AspNetUserRoles] ([RoleId]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE INDEX [EmailIndex] ON [AspNetUsers] ([NormalizedEmail]);
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    CREATE UNIQUE INDEX [UserNameIndex] ON [AspNetUsers] ([NormalizedUserName]) WHERE [NormalizedUserName] IS NOT NULL;
END;

GO

IF NOT EXISTS(SELECT * FROM [__EFMigrationsHistory] WHERE [MigrationId] = N'20190805205628_IdentityAdded')
BEGIN
    INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
    VALUES (N'20190805205628_IdentityAdded', N'3.0.0-preview9.19423.6');
END;

GO

