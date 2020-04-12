﻿// <auto-generated />
using System;
using ComputerShop.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace ComputerShop.Migrations
{
    [DbContext(typeof(AppDbContext))]
    partial class AppDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0-preview6.19304.10")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ComputerShop.Models.Category", b =>
                {
                    b.Property<int>("CategoryId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("CategoryName");

                    b.HasKey("CategoryId");

                    b.ToTable("Categories");

                    b.HasData(
                        new
                        {
                            CategoryId = 1,
                            CategoryImage = "/Images/category/Notebooks.png",
                            CategoryName = "Notebooks"
                        },
                        new
                        {
                            CategoryId = 2,
                            CategoryImage = "/Images/category/Computers.png",
                            CategoryName = "Computers"
                        },
                        new
                        {
                            CategoryId = 3,
                            CategoryImage = "/Images/category/Monitors.png",
                            CategoryName = "Monitors"
                        },
                        new
                        {
                            CategoryId = 4,
                            CategoryImage = "/Images/category/ComputerHardware.png",
                            CategoryName = "Computer Hardware"
                        },
                        new
                        {
                            CategoryId = 5,
                            CategoryImage = "/Images/category/Tablets.png",
                            CategoryName = "Tablets"
                        });
                        
                });

            modelBuilder.Entity("ComputerShop.Models.Order", b =>
                {
                    b.Property<int>("OrderId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("AddressLine1")
                        .IsRequired()
                        .HasMaxLength(100);

                    b.Property<string>("AddressLine2");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Country")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<DateTime>("OrderPlaced");

                    b.Property<decimal>("OrderTotal");

                    b.Property<string>("PhoneNumber")
                        .IsRequired()
                        .HasMaxLength(25);

                    b.Property<string>("State")
                        .HasMaxLength(10);

                    b.Property<string>("ZipCode")
                        .IsRequired()
                        .HasMaxLength(10);

                    b.HasKey("OrderId");

                    b.ToTable("Orders");
                });

            modelBuilder.Entity("ComputerShop.Models.OrderDetail", b =>
                {
                    b.Property<int>("OrderDetailId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int>("OrderId");

                    b.Property<int>("ProductId");

                    b.Property<decimal>("Price");

                    b.HasKey("OrderDetailId");

                    b.HasIndex("OrderId");

                    b.HasIndex("ProductId");

                    b.ToTable("OrderDetails");
                });

            modelBuilder.Entity("ComputerShop.Models.Product", b =>
                {
                    b.Property<int>("ProductId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Name");

                    b.Property<decimal>("Price");

                    b.Property<string>("Image");

                    b.Property<string>("Description");

                    b.Property<bool>("IsProductOfTheWeek");

                    b.Property<bool>("InStock");

                    b.Property<int>("CategoryId");

                    b.HasKey("ProductId");

                    b.HasIndex("CategoryId");

                    b.ToTable("Products");

                b.HasData(
                    new
                    {
                        ProductId = 1,
                        Name = "Notebook Lenovo IdeaPad 330-15AST (81D600TDRA) Onyx Black",
                        Price = 4999m,
                        Image = "/Images/notebook/lenovo_81d600jyra.jpg",
                        Description = "Screen 15.6\" TN + film(1366x768) HD, matte / AMD E2 - 9000(1.8 - 2.2 GHz) / RAM 4 GB / SSD 128 GB / AMD Radeon R2 Graphics / without OD / LAN / Wi - Fi / Bluetooth / web - camera / DOS / 2.2 kg / black",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 1
                    },
                    new
                    {
                        ProductId = 2,
                        Name = "Notebook Asus ROG Strix G531GT-AL029 (90NR01L3-M10560) Black",
                        Price = 24999m,
                        Image = "/Images/notebook/asus_90nr01l3_m02530.jpg",
                        Description = "Screen 15.6\" IPS(1920x1080) Full HD 120 Hz, matte / Intel Core i5 - 9300H(2.4 - 4.1 GHz) / RAM 8 GB / SSD 256 GB / nVidia GeForce GTX 1650, 4 GB / without OD / LAN / Wi - Fi / Bluetooth / without OS / 2.35 kg / black",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 1
                    },
                    new
                    {
                        ProductId = 3,
                        Name = "Notebook Acer Aspire 5 A515-54G-50EQ (NX.HN5EU.00J) Pure Silver",
                        Price = 16499M,
                        Image = "/Images/notebook/acer_nx_hfreu_038_5e395313e5c5a.jpg",
                        Description = "Screen 15.6\" IPS (1920x1080) Full HD, matte / Intel Core i5-10210U (1.6 - 4.2 GHz) / RAM 8 GB / SSD 512 GB / nVidia GeForce MX250, 2 GB / without OD / LAN / Wi-Fi / Bluetooth / webcam / without OS / 1.8 kg / silver",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 1
                    },
                    new
                    {
                        ProductId = 4,
                        Name = "Notebook Lenovo Legion Y740-15IRHg (81UH006CRA) Black",
                        Price = 83499M,
                        Image = "/Images/notebook/lenovo_81uh006cra.jpg",
                        Description = "Screen 15.6\" IPS (1920x1080) Full HD 144 Hz, glossy anti-glare / Intel Core i7-9750H (2.6 - 4.5 GHz) / RAM 32 GB / SSD 1 TB / nVidia GeForce RTX 2070, 8 GB / without OD / LAN / Wi-Fi / Bluetooth / webcam / Windows 10 Home 64bit / 2.2 kg / black",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 1
                    },
                    new
                    {
                        ProductId = 5,
                        Name = "ARTLINE Gaming X39 v33 (X39v33)",
                        Price = 23399m,
                        Image = "/Images/computer/artline_x39v33.jpg",
                        Description = "Intel Core i5-9400F (2.9 - 4.1 GHz) / RAM 16 GB / HDD 1 TB + SSD 240 GB / nVidia GeForce GTX 1660 Ti, 6 GB / without OD / LAN / without OS",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 2
                    },
                    new
                    {
                        ProductId = 6,
                        Name = "Artline Gaming X33 v04 (X33v04)",
                        Price = 19499m,
                        Image = "/Images/computer/artline_x33v04.jpg",
                        Description = "Intel Core i5-9400F (2.9 - 4.1 GHz) / RAM 16 GB / HDD 1 TB + SSD 480 GB / nVidia GeForce GTX 1650, 4 GB / without OD / LAN / without OS",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 2
                    },
                    new
                    {
                        ProductId = 7,
                        Name = "ARTLINE Gaming X48 v04 (X48v04)",
                        Price = 19888M,
                        Image = "/Images/computer/artline_x48v04.jpg",
                        Description = "AMD Ryzen 5 2600 (3.4 - 3.9 GHz) / RAM 16 GB / HDD 1 TB + SSD 240 GB / AMD Radeon RX580, 8 GB / without OD / LAN / without OS",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 2
                    },
                    new
                    {
                        ProductId = 8,
                        Name = "Artline Overlord RTX P99 v11 (P99v11)",
                        Price = 221376M,
                        Image = "/Images/computer/artline_p98v11.jpg",
                        Description = "Intel Core i9-9900X (3.5 - 4.4 GHz) / RAM 64 GB / HDD 4 TB + SSD 1 TB / 2 x nVidia GeForce RTX 2080 Ti, 11 GB / without OD / LAN / Windows 10 Pro",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 2
                    },
                    new
                    {
                        ProductId = 9,
                        Name = "Monitor 23.8\" Philips 245E1S/00/01 - 75 Hz frequency, 8-Bit, FreeSync",
                        Price = 5099M,
                        Image = "/Images/monitor/philips_245e1s_00.jpg",
                        Description = "Display diagonal: 23.8\" / Maximum display resolution: 2560 x 1440 / Matrix type: IPS / Features: Flicker - Free",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 3
                    },
                    new
                    {
                        ProductId = 10,
                        Name = "Monitor 31.5\" LG UltraGear 32GK650F-B",
                        Price = 9999M,
                        Image = "/Images/monitor/lg_32gk650f_b.jpg",
                        Description = "Display diagonal: 31.5\" / Maximum display resolution: 2560 x 1440 / Matrix type: VA / Features: Pivot. Height adjustment",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 3
                    },
                    new
                    {
                        ProductId = 11,
                        Name = "Monitor 32\" BenQ PV3200PT (9H.LEFLB.QBE)",
                        Price = 28999M,
                        Image = "/Images/monitor/benq_9h_leflb_qbe.jpg",
                        Description = "Display diagonal: 32\" / Maximum display resolution: 3840 x 2160 / Matrix type: IPS / Features: Height adjustment. Pivot. Flicker-Free",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 3
                    },
                    new
                    {
                        ProductId = 12,
                        Name = "Monitor 42.5\" LG UltraFine 43UD79-B",
                        Price = 16499M,
                        Image = "/Images/monitor/lg_43ud79_b.jpg",
                        Description = "Display diagonal: 42.5\" / Maximum display resolution: 3840 x 2160 / Matrix type: IPS / Features: Сinema screen. USB hub. Flicker-Free",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 3
                    },
                    new
                    {
                        ProductId = 13,
                        Name = "Motherboard MSI MEG X570 Godlike (sAM4, AMD X570, PCI-Ex16)",
                        Price = 23360M,
                        Image = "/Images/computerhardware/msi_meg_x570_godlike.jpg",
                        Description = "Connector type: Socket AM4 / Form factor: E-ATX / Memory support: 4 x DDR4 DIMM; Number of channels 2 / Processor support: AMD Ryzen 2nd and 3rd generation / Ryzen with Radeon Vega graphics core",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 4
                    },
                    new
                    {
                        ProductId = 14,
                        Name = "Processor AMD Ryzen 9 3950X 3.5GHz/64MB (100-100000051WOF) sAM4 BOX",
                        Price = 25850M,
                        Image = "/Images/computerhardware/amd_ryzen_9_3950x.jpg",
                        Description = "Processor family: AMD Ryzen 9 / Connector type: Socket AM4 / Number of cores: 16 / Integrated graphics: No / Internal clock speed: 3500 MHz / L3 cache size: 64 MB",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 4
                    },
                    new
                    {
                        ProductId = 15,
                        Name = "RAM HyperX DDR4-3600 32768MB PC4-28800 (Kit of 2x16384) Predator (HX436C17PB3K2/32)",
                        Price = 9550M,
                        Image = "/Images/computerhardware/hyperx_hx433c16pb3k2_32_5cd3ccd839aac.jpg",
                        Description = "Memory size: 32 GB / Memory type: DDR4 SDRAM / Memory frequency: 3600 MHz / Number of strips: 2 / Function: For Desktop",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 4
                    },
                    new
                    {
                        ProductId = 16,
                        Name = "Asus PCI-Ex GeForce RTX 2080 Ti ROG Strix 11GB GDDR6 (352bit) (1350/14000) (2 x HDMI, 2 x DisplayPort, 1 x USB Type-C) (ROG-STRIX-RTX2080TI-O11G-GAMING)",
                        Price = 44465M,
                        Image = "/Images/computerhardware/asus_rog_strix_rtx2080ti_o11g_gaming.jpg",
                        Description = "Graphics chip: GeForce RTX 2080 Ti / Memory size: 11 GB / Memory Bus Width: 352 bit / Memory type: GDDR6 / Type of cooling system: Active",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 4
                    },
                    new
                    {
                        ProductId = 17,
                        Name = "Tablet Panasonic Toughpad FZ-M1 (FZ-M1F150RT9)",
                        Price = 86599M,
                        Image = "/Images/tablet/panasonic_fz_m1f150rt9.jpg",
                        Description = "Screen 7\" IPS (1280x800) capacitive, MultiTouch / Intel Core i5-7Y57 vPro (1.2 - 3.3 GHz) / RAM 4 GB / 128 GB internal memory / 3G / Wi-Fi / Bluetooth 4.1 / 8MP main camera, 2MP front camera / dustproof / waterproof IP65 / Windows 10 Pro / 540 g / silver black",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 5
                    },
                    new
                    {
                        ProductId = 18,
                        Name = "Apple iPad pro 11\" a1980 wi-fi 1tb 2018 10172232",
                        Price = 55999M,
                        Image = "/Images/tablet/apple_mtxw2.jpg",
                        Description = "Screen 11\" IPS (2388x1668) capacitive MultiTouch / Apple A12X Bionic / RAM 4 GB / 1 TB internal memory / Wi-Fi / Bluetooth 5.0 / 12MP main camera, 7MP front camera / iOS 12 / 468 g / silver",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 5
                    },
                    new
                    {
                        ProductId = 19,
                        Name = "Tablet Microsoft Surface Pro 6 12.3\" (LQ6-00019) Black",
                        Price = 39999M,
                        Image = "/Images/tablet/microsoft_lq6_00019.jpg",
                        Description = "Screen 12.3\" (2736x1824) Multitouch / Intel Core i5-8350U (1.7 - 3.6 GHz) / RAM 8 GB / 256 GB internal memory + microSD / Wi-Fi / Bluetooth 4.1 / 8MP main camera, 5MP front camera / Windows 10 Home / 770 g / black",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 5
                    },
                    new
                    {
                        ProductId = 20,
                        Name = "Tablet Samsung Galaxy Tab S6 10.5\" 6/128GB LTE Grey (SM-T865NZAASEK)",
                        Price = 24999M,
                        Image = "/Images/tablet/samsung_sm_t865nzaasek.jpg",
                        Description = "Screen 10.5\" (2560x1600) capacitive MultiTouch / Qualcomm Snapdragon 855 (1x2.8 GHz + 2x2.4 GHz + 4x1.7 GHz) / RAM 6 GB / 128 GB internal memory + microSD / 3G / 4G / Wi-Fi / Bluetooth 5.0 / 13MP + 5MP main dual camera, 8MP front camera / GPS / GLONASS / Android 9.0 (Pie) / 420 g / grey",
                        IsProductOfTheWeek = true,
                        InStock = true,
                        CategoryId = 5
                    });
                        
                      
                });

            modelBuilder.Entity("ComputerShop.Models.ShoppingCartItem", b =>
                {
                    b.Property<int>("ShoppingCartItemId")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Amount");

                    b.Property<int?>("ProductId");

                    b.Property<string>("ShoppingCartId");

                    b.HasKey("ShoppingCartItemId");

                    b.HasIndex("ProductId");

                    b.ToTable("ShoppingCartItems");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex")
                        .HasFilter("[NormalizedName] IS NOT NULL");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUser", b =>
                {
                    b.Property<string>("Id");

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex")
                        .HasFilter("[NormalizedUserName] IS NOT NULL");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("ComputerShop.Models.OrderDetail", b =>
                {
                    b.HasOne("ComputerShop.Models.Order", "Order")
                        .WithMany("OrderDetails")
                        .HasForeignKey("OrderId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ComputerShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComputerShop.Models.Product", b =>
                {
                    b.HasOne("ComputerShop.Models.Category", "Category")
                        .WithMany("Products")
                        .HasForeignKey("CategoryId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("ComputerShop.Models.ShoppingCartItem", b =>
                {
                    b.HasOne("ComputerShop.Models.Product", "Product")
                        .WithMany()
                        .HasForeignKey("ProductId");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole", null)
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityUser", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}
