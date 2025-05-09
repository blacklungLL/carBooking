﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using car_booking.Persistence;

#nullable disable

namespace car_booking.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    partial class ApplicationDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "9.0.4")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("car_booking.Entities.Car", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("integer");

                    NpgsqlPropertyBuilderExtensions.UseIdentityByDefaultColumn(b.Property<int>("Id"));

                    b.Property<string>("Category")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<string>("Img")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<int>("Liters")
                        .HasColumnType("integer");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("text");

                    b.Property<decimal>("Price")
                        .HasColumnType("numeric");

                    b.Property<int>("Spaces")
                        .HasColumnType("integer");

                    b.Property<string>("Transmission")
                        .IsRequired()
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Category = "Hatchback",
                            Description = "The base model of the Suzuki Swift is perfect for urban driving. With a fuel-efficient engine and a compact design, it offers excellent maneuverability in city traffic. The manual transmission ensures a sporty driving experience, while the spacious interior provides comfort for all passengers.",
                            Img = "/src/assets/suzuki_swift_1.png",
                            Liters = 37,
                            Name = "Suzuki Swift (1)",
                            Price = 30.00m,
                            Spaces = 5,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 2,
                            Category = "Hatchback",
                            Description = "This upgraded version of the Suzuki Swift features an automatic transmission for a smoother ride. Equipped with advanced safety features, air conditioning, and a modern infotainment system, it is an ideal choice for those seeking convenience and comfort in their daily commute.",
                            Img = "/src/assets/suzuki_swift_2.png",
                            Liters = 37,
                            Name = "Suzuki Swift (2)",
                            Price = 35.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 3,
                            Category = "Hatchback",
                            Description = "The sporty variant of the Suzuki Swift comes with a turbocharged engine and automatic transmission. Designed for performance enthusiasts, it combines dynamic handling with a stylish exterior and premium interior features, making it stand out on the road.",
                            Img = "/src/assets/suzuki_swift_3.png",
                            Liters = 37,
                            Name = "Suzuki Swift (3)",
                            Price = 45.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 4,
                            Category = "Crossover",
                            Description = "The entry-level Suzuki Vitara is equipped with a manual transmission and front-wheel drive. Its compact size and efficient fuel consumption make it a great choice for urban adventures, while its robust design ensures durability and reliability.",
                            Img = "/src/assets/suzuki_vitara_1.png",
                            Liters = 47,
                            Name = "Suzuki Vitara (1)",
                            Price = 45.00m,
                            Spaces = 5,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 5,
                            Category = "Crossover",
                            Description = "This mid-range Vitara model features an automatic transmission and all-wheel drive. It includes advanced technology such as a touchscreen infotainment system, leather seats, and enhanced safety features, offering a blend of comfort and capability.",
                            Img = "/src/assets/suzuki_vitara_2.png",
                            Liters = 47,
                            Name = "Suzuki Vitara (2)",
                            Price = 55.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 6,
                            Category = "Crossover",
                            Description = "The top-tier Suzuki Vitara is a hybrid model designed for eco-conscious drivers. With advanced driver-assistance systems, a luxurious interior, and superior off-road capabilities, it’s perfect for both city streets and rugged terrains.",
                            Img = "/src/assets/suzuki_vitara_3.png",
                            Liters = 47,
                            Name = "Suzuki Vitara (3)",
                            Price = 65.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 7,
                            Category = "SUV",
                            Description = "The classic Suzuki Jimny is a no-frills, rugged SUV with a manual transmission and four-wheel drive. Its compact size and legendary off-road capabilities make it a favorite among adventure seekers and outdoor enthusiasts.",
                            Img = "/src/assets/suzuki_jimmy_1.png",
                            Liters = 40,
                            Name = "Suzuki Jimny (1)",
                            Price = 50.00m,
                            Spaces = 4,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 8,
                            Category = "SUV",
                            Description = "This upgraded Jimny model features an automatic transmission and enhanced off-road equipment. With improved ground clearance, durable tires, and additional accessories, it’s built to tackle challenging terrains with ease.",
                            Img = "/src/assets/suzuki_jimmy_2.png",
                            Liters = 40,
                            Name = "Suzuki Jimny (2)",
                            Price = 60.00m,
                            Spaces = 4,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 9,
                            Category = "SUV",
                            Description = "The premium version of the Suzuki Jimny is designed for extreme off-roading. Featuring a reinforced chassis, advanced suspension, and specialized accessories, it’s the ultimate choice for adventurers who demand maximum performance and reliability.",
                            Img = "/src/assets/suzuki_jimmy_3.png",
                            Liters = 40,
                            Name = "Suzuki Jimny (3)",
                            Price = 70.00m,
                            Spaces = 4,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 10,
                            Category = "Crossover",
                            Description = "The base model of the Suzuki SX4 S-Cross is a practical crossover with a manual transmission and front-wheel drive. Its sleek design and efficient fuel consumption make it a versatile option for everyday use.",
                            Img = "/src/assets/suzuki_sx_4_s_cross_1.png",
                            Liters = 48,
                            Name = "Suzuki SX4 S-Cross (1)",
                            Price = 40.00m,
                            Spaces = 5,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 11,
                            Category = "Crossover",
                            Description = "This mid-range SX4 S-Cross model features an automatic transmission and all-wheel drive. Equipped with leather upholstery, climate control, and advanced safety technologies, it offers a refined driving experience.",
                            Img = "/src/assets/suzuki_sx_4_s_cross_2.png",
                            Liters = 48,
                            Name = "Suzuki SX4 S-Cross (2)",
                            Price = 50.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 12,
                            Category = "Crossover",
                            Description = "The top-of-the-line SX4 S-Cross is a hybrid model with cutting-edge technology. It includes adaptive cruise control, lane-keeping assist, and a premium sound system, ensuring comfort and safety on every journey.",
                            Img = "/src/assets/suzuki-sx4-s-cross_3.png",
                            Liters = 48,
                            Name = "Suzuki SX4 S-Cross (3)",
                            Price = 60.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 13,
                            Category = "Hatchback",
                            Description = "The entry-level Suzuki Baleno is a compact hatchback with a manual transmission. Its lightweight design and fuel-efficient engine make it an excellent choice for urban commuters who value practicality and affordability.",
                            Img = "/src/assets/suzuki_baleno_1.png",
                            Liters = 37,
                            Name = "Suzuki Baleno (1)",
                            Price = 35.00m,
                            Spaces = 5,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 14,
                            Category = "Hatchback",
                            Description = "This upgraded Baleno model features an automatic transmission and enhanced features such as air conditioning, a touchscreen infotainment system, and alloy wheels. It’s perfect for those seeking a balance of comfort and style.",
                            Img = "/src/assets/suzuki_baleno_2.png",
                            Liters = 37,
                            Name = "Suzuki Baleno (2)",
                            Price = 40.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 15,
                            Category = "Hatchback",
                            Description = "The premium Baleno variant offers luxury features like leather seats, navigation, and advanced driver-assistance systems. Its spacious cabin and modern design make it a standout choice in the hatchback segment.",
                            Img = "/src/assets/suzuki_baleno_3.png",
                            Liters = 37,
                            Name = "Suzuki Baleno (3)",
                            Price = 45.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 16,
                            Category = "Subcompact Hatchback",
                            Description = "The base Suzuki Celerio is a budget-friendly subcompact hatchback with a manual transmission. Its small size and excellent fuel economy make it ideal for navigating crowded city streets.",
                            Img = "/src/assets/suzuki_celerio_1.png",
                            Liters = 35,
                            Name = "Suzuki Celerio (1)",
                            Price = 25.00m,
                            Spaces = 5,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 17,
                            Category = "Subcompact Hatchback",
                            Description = "This upgraded Celerio model features an automatic transmission and a more stylish exterior. With added features like power windows and a rearview camera, it offers enhanced convenience and functionality.",
                            Img = "/src/assets/suzuki_celerio_2.png",
                            Liters = 35,
                            Name = "Suzuki Celerio (2)",
                            Price = 30.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 18,
                            Category = "Subcompact Hatchback",
                            Description = "The top-tier Celerio includes advanced features such as a touchscreen infotainment system, alloy wheels, and a rear parking sensor. It’s a smart choice for drivers looking for affordability without compromising on comfort.",
                            Img = "/src/assets/suzuki_celerio_3.png",
                            Liters = 35,
                            Name = "Suzuki Celerio (3)",
                            Price = 35.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 19,
                            Category = "Minivan",
                            Description = "The base model of the Suzuki Ertiga is a practical minivan with a manual transmission and front-wheel drive. Its spacious interior and fuel efficiency make it an excellent choice for families and long trips.",
                            Img = "/src/assets/suzuki_ertiga_1.png",
                            Liters = 45,
                            Name = "Suzuki Ertiga (1)",
                            Price = 50.00m,
                            Spaces = 7,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 20,
                            Category = "Minivan",
                            Description = "This mid-range Ertiga model features an automatic transmission and upgraded features like leather seats, climate control, and advanced safety systems. It’s perfect for those who prioritize comfort and convenience.",
                            Img = "/src/assets/suzuki_ertiga_2.png",
                            Liters = 45,
                            Name = "Suzuki Ertiga (2)",
                            Price = 60.00m,
                            Spaces = 7,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 21,
                            Category = "Minivan",
                            Description = "The premium Ertiga variant offers luxury features such as a touchscreen infotainment system, navigation, and a rear entertainment system. Its spacious cabin and modern design make it ideal for family travel.",
                            Img = "/src/assets/suzuki_ertiga_3.png",
                            Liters = 45,
                            Name = "Suzuki Ertiga (3)",
                            Price = 70.00m,
                            Spaces = 7,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 22,
                            Category = "Crossover",
                            Description = "The base Suzuki Ignis is a compact crossover with a manual transmission and front-wheel drive. Its unique design and fuel efficiency make it a great choice for urban driving and weekend getaways.",
                            Img = "/src/assets/suzuki_ignis_1.png",
                            Liters = 32,
                            Name = "Suzuki Ignis (1)",
                            Price = 35.00m,
                            Spaces = 4,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 23,
                            Category = "Crossover",
                            Description = "This upgraded Ignis model features an automatic transmission and a hybrid powertrain. With advanced safety features and a modern infotainment system, it offers a blend of style and technology.",
                            Img = "/src/assets/suzuki_ignis_2.jpg",
                            Liters = 32,
                            Name = "Suzuki Ignis (2)",
                            Price = 40.00m,
                            Spaces = 4,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 24,
                            Category = "Crossover",
                            Description = "The top-tier Ignis variant is a hybrid model with advanced features like adaptive cruise control, lane departure warning, and a premium audio system. Its compact size and modern design make it a standout in the crossover segment.",
                            Img = "/src/assets/suzuki_ignis_3.png",
                            Liters = 32,
                            Name = "Suzuki Ignis (3)",
                            Price = 45.00m,
                            Spaces = 4,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 25,
                            Category = "Crossover",
                            Description = "The base model of the Suzuki Grand Vitara is a rugged crossover with a manual transmission and front-wheel drive. Its spacious interior and reliable performance make it a great choice for both city and off-road driving.",
                            Img = "/src/assets/suzuki_grand_vitara_1.png",
                            Liters = 50,
                            Name = "Suzuki Grand Vitara (1)",
                            Price = 60.00m,
                            Spaces = 5,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 26,
                            Category = "Crossover",
                            Description = "This mid-range Grand Vitara model features an automatic transmission and all-wheel drive. Equipped with leather seats, a touchscreen infotainment system, and advanced safety features, it offers a refined driving experience.",
                            Img = "/src/assets/suzuki_grand_vitara_2.png",
                            Liters = 50,
                            Name = "Suzuki Grand Vitara (2)",
                            Price = 70.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 27,
                            Category = "Crossover",
                            Description = "The premium Grand Vitara variant is a hybrid model with advanced technology like adaptive cruise control, lane-keeping assist, and a panoramic sunroof. Its luxurious interior and superior off-road capabilities make it a top choice in its class.",
                            Img = "/src/assets/suzuki_grand_vitara_3.png",
                            Liters = 50,
                            Name = "Suzuki Grand Vitara (3)",
                            Price = 80.00m,
                            Spaces = 5,
                            Transmission = "Automatic"
                        },
                        new
                        {
                            Id = 28,
                            Category = "Subcompact Hatchback",
                            Description = "The base Suzuki Alto is a budget-friendly subcompact hatchback with a manual transmission. Its small size and excellent fuel economy make it ideal for urban commuting and tight parking spaces.",
                            Img = "/src/assets/suzuki_alto_1.png",
                            Liters = 27,
                            Name = "Suzuki Alto (1)",
                            Price = 20.00m,
                            Spaces = 4,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 29,
                            Category = "Subcompact Hatchback",
                            Description = "This upgraded Alto model features enhanced features like power windows, air conditioning, and a rearview camera. It’s a practical choice for those seeking affordability and convenience.",
                            Img = "/src/assets/suzuki_alto_2.png",
                            Liters = 27,
                            Name = "Suzuki Alto (2)",
                            Price = 25.00m,
                            Spaces = 4,
                            Transmission = "Manual"
                        },
                        new
                        {
                            Id = 30,
                            Category = "Subcompact Hatchback",
                            Description = "The premium Alto variant includes advanced features such as a touchscreen infotainment system, alloy wheels, and a rear parking sensor. Its modern design and practicality make it a standout in the subcompact segment.",
                            Img = "/src/assets/suzuki_alto_3.png",
                            Liters = 27,
                            Name = "Suzuki Alto (3)",
                            Price = 30.00m,
                            Spaces = 4,
                            Transmission = "Manual"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
