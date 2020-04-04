using Microsoft.EntityFrameworkCore.Migrations;

namespace ComputerShop.Migrations
{
    public partial class SeedDataAdded : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName" },
                values: new object[] { 1, "/Images/category/Notebooks.png", "Notebooks" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName" },
                values: new object[] { 2, "/Images/category/Computers.png", "Computers" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName" },
                values: new object[] { 3, "/Images/category/Monitors.png", "Monitors" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName" },
                values: new object[] { 4, "/Images/category/ComputerHardware.png", "Computer Hardware" });

            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryImage", "CategoryName" },
                values: new object[] { 5, "/Images/category/Tablets.png", "Tablets" });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "ProductId", "Name", "Price", "Image", "Description", "IsProductOfTheWeek", "InStock", "CategoryId" },
                values: new object[,]
                {
                    { 1, "Notebook Lenovo IdeaPad 330-15AST (81D600TDRA) Onyx Black", 4999m, "/Images/notebook/lenovo_81d600jyra.jpg", "Screen 15.6\" TN + film(1366x768) HD, matte / AMD E2 - 9000(1.8 - 2.2 GHz) / RAM 4 GB / SSD 128 GB / AMD Radeon R2 Graphics / without OD / LAN / Wi - Fi / Bluetooth / web - camera / DOS / 2.2 kg / black", true, true, 1},
                    { 2, "Notebook Asus ROG Strix G531GT-AL029 (90NR01L3-M10560) Black", 24999m, "/Images/notebook/asus_90nr01l3_m02530.jpg", "Screen 15.6\" IPS(1920x1080) Full HD 120 Hz, matte / Intel Core i5 - 9300H(2.4 - 4.1 GHz) / RAM 8 GB / SSD 256 GB / nVidia GeForce GTX 1650, 4 GB / without OD / LAN / Wi - Fi / Bluetooth / without OS / 2.35 kg / black", true, true, 1},
                    { 3, "Notebook Acer Aspire 5 A515-54G-50EQ (NX.HN5EU.00J) Pure Silver", 16499m, "/Images/notebook/acer_nx_hfreu_038_5e395313e5c5a.jpg", "Screen 15.6\" IPS (1920x1080) Full HD, matte / Intel Core i5-10210U (1.6 - 4.2 GHz) / RAM 8 GB / SSD 512 GB / nVidia GeForce MX250, 2 GB / without OD / LAN / Wi-Fi / Bluetooth / webcam / without OS / 1.8 kg / silver", true, true, 1},
                    { 4, "Notebook Lenovo Legion Y740-15IRHg (81UH006CRA) Black", 83499m, "/Images/notebook/lenovo_81uh006cra.jpg", "Screen 15.6\" IPS (1920x1080) Full HD 144 Hz, glossy anti-glare / Intel Core i7-9750H (2.6 - 4.5 GHz) / RAM 32 GB / SSD 1 TB / nVidia GeForce RTX 2070, 8 GB / without OD / LAN / Wi-Fi / Bluetooth / webcam / Windows 10 Home 64bit / 2.2 kg / black", true, true, 1},
                    { 5, "ARTLINE Gaming X39 v33 (X39v33)", 23399m, "/Images/computer/artline_x39v33.jpg", "Intel Core i5-9400F (2.9 - 4.1 GHz) / RAM 16 GB / HDD 1 TB + SSD 240 GB / nVidia GeForce GTX 1660 Ti, 6 GB / without OD / LAN / without OS", true, true, 2 },
                    { 6, "Artline Gaming X33 v04 (X33v04)", 19499m, "/Images/computer/artline_x33v04.jpg", "Intel Core i5-9400F (2.9 - 4.1 GHz) / RAM 16 GB / HDD 1 TB + SSD 480 GB / nVidia GeForce GTX 1650, 4 GB / without OD / LAN / without OS", true, true, 2 },
                    { 7, "ARTLINE Gaming X48 v04 (X48v04)", 19888m, "/Images/computer/artline_x48v04.jpg", "AMD Ryzen 5 2600 (3.4 - 3.9 GHz) / RAM 16 GB / HDD 1 TB + SSD 240 GB / AMD Radeon RX580, 8 GB / without OD / LAN / without OS", true, true, 2},
                    { 8, "Artline Overlord RTX P99 v11 (P99v11)", 221376m, "/Images/computer/artline_p98v11.jpg", "Intel Core i9-9900X (3.5 - 4.4 GHz) / RAM 64 GB / HDD 4 TB + SSD 1 TB / 2 x nVidia GeForce RTX 2080 Ti, 11 GB / without OD / LAN / Windows 10 Pro", true, true, 2},
                    { 9, "Monitor 23.8\" Philips 245E1S/00/01 - 75 Hz frequency, 8-Bit, FreeSync", 5099m, "/Images/monitor/philips_245e1s_00.jpg", "Display diagonal: 23.8\" / Maximum display resolution: 2560 x 1440 / Matrix type: IPS / Features: Flicker - Free", true, true, 3},
                    { 10, "Monitor 31.5\" LG UltraGear 32GK650F-B", 9999m, "/Images/monitor/lg_32gk650f_b.jpg", "Display diagonal: 31.5\" / Maximum display resolution: 2560 x 1440 / Matrix type: VA / Features: Pivot. Height adjustment", true, true, 3},
                    { 11, "Monitor 32\" BenQ PV3200PT (9H.LEFLB.QBE)", 28999m, "/Images/monitor/benq_9h_leflb_qbe.jpg", "Display diagonal: 32\" / Maximum display resolution: 3840 x 2160 / Matrix type: IPS / Features: Height adjustment. Pivot. Flicker-Free", true, true, 3},
                    { 12, "Monitor 42.5\" LG UltraFine 43UD79-B", 16499m, "/Images/monitor/lg_43ud79_b.jpg", "Display diagonal: 42.5\" / Maximum display resolution: 3840 x 2160 / Matrix type: IPS / Features: Сinema screen. USB hub. Flicker-Free", true, true, 3},
                    { 13, "Motherboard MSI MEG X570 Godlike (sAM4, AMD X570, PCI-Ex16)", 23360m, "/Images/computerhardware/msi_meg_x570_godlike.jpg", "Connector type: Socket AM4 / Form factor: E-ATX / Memory support: 4 x DDR4 DIMM; Number of channels 2 / Processor support: AMD Ryzen 2nd and 3rd generation / Ryzen with Radeon Vega graphics core", true, true, 4},
                    { 14, "Processor AMD Ryzen 9 3950X 3.5GHz/64MB (100-100000051WOF) sAM4 BOX", 25850m, "/Images/computerhardware/amd_ryzen_9_3950x.jpg", "Processor family: AMD Ryzen 9 / Connector type: Socket AM4 / Number of cores: 16 / Integrated graphics: No / Internal clock speed: 3500 MHz / L3 cache size: 64 MB", true, true, 4},
                    { 15, "RAM HyperX DDR4-3600 32768MB PC4-28800 (Kit of 2x16384) Predator (HX436C17PB3K2/32)", 9550m, "/Images/computerhardware/hyperx_hx433c16pb3k2_32_5cd3ccd839aac.jpg", "Memory size: 32 GB / Memory type: DDR4 SDRAM / Memory frequency: 3600 MHz / Number of strips: 2 / Function: For Desktop", true, true, 4},
                    { 16, "Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix 11GB GDDR6 (352bit) (1350/14000) (2 x HDMI, 2 x DisplayPort, 1 x USB Type-C) (ROG-STRIX-RTX2080TI-O11G-GAMING)", 44465m, "/Images/computerhardware/asus_rog_strix_rtx2080ti_o11g_gaming.jpg", "Graphics chip: GeForce RTX 2080 Ti / Memory size: 11 GB / Memory Bus Width: 352 bit / Memory type: GDDR6 / Type of cooling system: Active", true, true, 4},
                    { 17, "Tablet Panasonic Toughpad FZ-M1 (FZ-M1F150RT9)", 86599m, "/Images/tablet/panasonic_fz_m1f150rt9.jpg", "Screen 7\" IPS (1280x800) capacitive, MultiTouch / Intel Core i5-7Y57 vPro (1.2 - 3.3 GHz) / RAM 4 GB / 128 GB internal memory / 3G / Wi-Fi / Bluetooth 4.1 / 8MP main camera, 2MP front camera / dustproof / waterproof IP65 / Windows 10 Pro / 540 g / silver black", true, true, 5},
                    { 18, "Apple iPad pro 11\" a1980 wi-fi 1tb 2018 10172232", 55999m, "/Images/tablet/apple_mtxw2.jpg", "Screen 11\" IPS (2388x1668) capacitive MultiTouch / Apple A12X Bionic / RAM 4 GB / 1 TB internal memory / Wi-Fi / Bluetooth 5.0 / 12MP main camera, 7MP front camera / iOS 12 / 468 g / silver", true, true, 5},
                    { 19, "Tablet Microsoft Surface Pro 6 12.3\" (LQ6-00019) Black", 39999m, "/Images/tablet/microsoft_lq6_00019.jpg", "Screen 12.3\" (2736x1824) Multitouch / Intel Core i5-8350U (1.7 - 3.6 GHz) / RAM 8 GB / 256 GB internal memory + microSD / Wi-Fi / Bluetooth 4.1 / 8MP main camera, 5MP front camera / Windows 10 Home / 770 g / black", true, true, 5},
                    { 20, "Tablet Samsung Galaxy Tab S6 10.5\" 6/128GB LTE Grey (SM-T865NZAASEK)", 24999m, "/Images/tablet/samsung_sm_t865nzaasek.jpg", "Screen 10.5\" (2560x1600) capacitive MultiTouch / Qualcomm Snapdragon 855 (1x2.8 GHz + 2x2.4 GHz + 4x1.7 GHz) / RAM 6 GB / 128 GB internal memory + microSD / 3G / 4G / Wi-Fi / Bluetooth 5.0 / 13 Мп + 5 Мп main dual camera, 8 Мп front camera / GPS / GLONASS / Android 9.0 (Pie) / 420 g / grey", true, true, 5},
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "ProductId",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 5);
        }
    }
}
