using Microsoft.EntityFrameworkCore.Migrations;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace car_booking.Migrations
{
    /// <inheritdoc />
    public partial class Initial : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Cars",
                columns: table => new
                {
                    Id = table.Column<int>(type: "integer", nullable: false)
                        .Annotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn),
                    Name = table.Column<string>(type: "text", nullable: false),
                    Category = table.Column<string>(type: "text", nullable: false),
                    Img = table.Column<string>(type: "text", nullable: false),
                    Liters = table.Column<int>(type: "integer", nullable: false),
                    Transmission = table.Column<string>(type: "text", nullable: false),
                    Spaces = table.Column<int>(type: "integer", nullable: false),
                    Price = table.Column<decimal>(type: "numeric", nullable: false),
                    Description = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Cars", x => x.Id);
                });

            migrationBuilder.InsertData(
                table: "Cars",
                columns: new[] { "Id", "Category", "Description", "Img", "Liters", "Name", "Price", "Spaces", "Transmission" },
                values: new object[,]
                {
                    { 1, "Hatchback", "The base model of the Suzuki Swift is perfect for urban driving. With a fuel-efficient engine and a compact design, it offers excellent maneuverability in city traffic. The manual transmission ensures a sporty driving experience, while the spacious interior provides comfort for all passengers.", "/src/assets/suzuki_swift_1.png", 37, "Suzuki Swift (1)", 30.00m, 5, "Manual" },
                    { 2, "Hatchback", "This upgraded version of the Suzuki Swift features an automatic transmission for a smoother ride. Equipped with advanced safety features, air conditioning, and a modern infotainment system, it is an ideal choice for those seeking convenience and comfort in their daily commute.", "/src/assets/suzuki_swift_2.png", 37, "Suzuki Swift (2)", 35.00m, 5, "Automatic" },
                    { 3, "Hatchback", "The sporty variant of the Suzuki Swift comes with a turbocharged engine and automatic transmission. Designed for performance enthusiasts, it combines dynamic handling with a stylish exterior and premium interior features, making it stand out on the road.", "/src/assets/suzuki_swift_3.png", 37, "Suzuki Swift (3)", 45.00m, 5, "Automatic" },
                    { 4, "Crossover", "The entry-level Suzuki Vitara is equipped with a manual transmission and front-wheel drive. Its compact size and efficient fuel consumption make it a great choice for urban adventures, while its robust design ensures durability and reliability.", "/src/assets/suzuki_vitara_1.png", 47, "Suzuki Vitara (1)", 45.00m, 5, "Manual" },
                    { 5, "Crossover", "This mid-range Vitara model features an automatic transmission and all-wheel drive. It includes advanced technology such as a touchscreen infotainment system, leather seats, and enhanced safety features, offering a blend of comfort and capability.", "/src/assets/suzuki_vitara_2.png", 47, "Suzuki Vitara (2)", 55.00m, 5, "Automatic" },
                    { 6, "Crossover", "The top-tier Suzuki Vitara is a hybrid model designed for eco-conscious drivers. With advanced driver-assistance systems, a luxurious interior, and superior off-road capabilities, it’s perfect for both city streets and rugged terrains.", "/src/assets/suzuki_vitara_3.png", 47, "Suzuki Vitara (3)", 65.00m, 5, "Automatic" },
                    { 7, "SUV", "The classic Suzuki Jimny is a no-frills, rugged SUV with a manual transmission and four-wheel drive. Its compact size and legendary off-road capabilities make it a favorite among adventure seekers and outdoor enthusiasts.", "/src/assets/suzuki_jimmy_1.png", 40, "Suzuki Jimny (1)", 50.00m, 4, "Manual" },
                    { 8, "SUV", "This upgraded Jimny model features an automatic transmission and enhanced off-road equipment. With improved ground clearance, durable tires, and additional accessories, it’s built to tackle challenging terrains with ease.", "/src/assets/suzuki_jimmy_2.png", 40, "Suzuki Jimny (2)", 60.00m, 4, "Automatic" },
                    { 9, "SUV", "The premium version of the Suzuki Jimny is designed for extreme off-roading. Featuring a reinforced chassis, advanced suspension, and specialized accessories, it’s the ultimate choice for adventurers who demand maximum performance and reliability.", "/src/assets/suzuki_jimmy_3.png", 40, "Suzuki Jimny (3)", 70.00m, 4, "Manual" },
                    { 10, "Crossover", "The base model of the Suzuki SX4 S-Cross is a practical crossover with a manual transmission and front-wheel drive. Its sleek design and efficient fuel consumption make it a versatile option for everyday use.", "/src/assets/suzuki_sx_4_s_cross_1.png", 48, "Suzuki SX4 S-Cross (1)", 40.00m, 5, "Manual" },
                    { 11, "Crossover", "This mid-range SX4 S-Cross model features an automatic transmission and all-wheel drive. Equipped with leather upholstery, climate control, and advanced safety technologies, it offers a refined driving experience.", "/src/assets/suzuki_sx_4_s_cross_2.png", 48, "Suzuki SX4 S-Cross (2)", 50.00m, 5, "Automatic" },
                    { 12, "Crossover", "The top-of-the-line SX4 S-Cross is a hybrid model with cutting-edge technology. It includes adaptive cruise control, lane-keeping assist, and a premium sound system, ensuring comfort and safety on every journey.", "/src/assets/suzuki-sx4-s-cross_3.png", 48, "Suzuki SX4 S-Cross (3)", 60.00m, 5, "Automatic" },
                    { 13, "Hatchback", "The entry-level Suzuki Baleno is a compact hatchback with a manual transmission. Its lightweight design and fuel-efficient engine make it an excellent choice for urban commuters who value practicality and affordability.", "/src/assets/suzuki_baleno_1.png", 37, "Suzuki Baleno (1)", 35.00m, 5, "Manual" },
                    { 14, "Hatchback", "This upgraded Baleno model features an automatic transmission and enhanced features such as air conditioning, a touchscreen infotainment system, and alloy wheels. It’s perfect for those seeking a balance of comfort and style.", "/src/assets/suzuki_baleno_2.png", 37, "Suzuki Baleno (2)", 40.00m, 5, "Automatic" },
                    { 15, "Hatchback", "The premium Baleno variant offers luxury features like leather seats, navigation, and advanced driver-assistance systems. Its spacious cabin and modern design make it a standout choice in the hatchback segment.", "/src/assets/suzuki_baleno_3.png", 37, "Suzuki Baleno (3)", 45.00m, 5, "Automatic" },
                    { 16, "Subcompact Hatchback", "The base Suzuki Celerio is a budget-friendly subcompact hatchback with a manual transmission. Its small size and excellent fuel economy make it ideal for navigating crowded city streets.", "/src/assets/suzuki_celerio_1.png", 35, "Suzuki Celerio (1)", 25.00m, 5, "Manual" },
                    { 17, "Subcompact Hatchback", "This upgraded Celerio model features an automatic transmission and a more stylish exterior. With added features like power windows and a rearview camera, it offers enhanced convenience and functionality.", "/src/assets/suzuki_celerio_2.png", 35, "Suzuki Celerio (2)", 30.00m, 5, "Automatic" },
                    { 18, "Subcompact Hatchback", "The top-tier Celerio includes advanced features such as a touchscreen infotainment system, alloy wheels, and a rear parking sensor. It’s a smart choice for drivers looking for affordability without compromising on comfort.", "/src/assets/suzuki_celerio_3.png", 35, "Suzuki Celerio (3)", 35.00m, 5, "Automatic" },
                    { 19, "Minivan", "The base model of the Suzuki Ertiga is a practical minivan with a manual transmission and front-wheel drive. Its spacious interior and fuel efficiency make it an excellent choice for families and long trips.", "/src/assets/suzuki_ertiga_1.png", 45, "Suzuki Ertiga (1)", 50.00m, 7, "Manual" },
                    { 20, "Minivan", "This mid-range Ertiga model features an automatic transmission and upgraded features like leather seats, climate control, and advanced safety systems. It’s perfect for those who prioritize comfort and convenience.", "/src/assets/suzuki_ertiga_2.png", 45, "Suzuki Ertiga (2)", 60.00m, 7, "Automatic" },
                    { 21, "Minivan", "The premium Ertiga variant offers luxury features such as a touchscreen infotainment system, navigation, and a rear entertainment system. Its spacious cabin and modern design make it ideal for family travel.", "/src/assets/suzuki_ertiga_3.png", 45, "Suzuki Ertiga (3)", 70.00m, 7, "Automatic" },
                    { 22, "Crossover", "The base Suzuki Ignis is a compact crossover with a manual transmission and front-wheel drive. Its unique design and fuel efficiency make it a great choice for urban driving and weekend getaways.", "/src/assets/suzuki_ignis_1.png", 32, "Suzuki Ignis (1)", 35.00m, 4, "Manual" },
                    { 23, "Crossover", "This upgraded Ignis model features an automatic transmission and a hybrid powertrain. With advanced safety features and a modern infotainment system, it offers a blend of style and technology.", "/src/assets/suzuki_ignis_2.jpg", 32, "Suzuki Ignis (2)", 40.00m, 4, "Automatic" },
                    { 24, "Crossover", "The top-tier Ignis variant is a hybrid model with advanced features like adaptive cruise control, lane departure warning, and a premium audio system. Its compact size and modern design make it a standout in the crossover segment.", "/src/assets/suzuki_ignis_3.png", 32, "Suzuki Ignis (3)", 45.00m, 4, "Automatic" },
                    { 25, "Crossover", "The base model of the Suzuki Grand Vitara is a rugged crossover with a manual transmission and front-wheel drive. Its spacious interior and reliable performance make it a great choice for both city and off-road driving.", "/src/assets/suzuki_grand_vitara_1.png", 50, "Suzuki Grand Vitara (1)", 60.00m, 5, "Manual" },
                    { 26, "Crossover", "This mid-range Grand Vitara model features an automatic transmission and all-wheel drive. Equipped with leather seats, a touchscreen infotainment system, and advanced safety features, it offers a refined driving experience.", "/src/assets/suzuki_grand_vitara_2.png", 50, "Suzuki Grand Vitara (2)", 70.00m, 5, "Automatic" },
                    { 27, "Crossover", "The premium Grand Vitara variant is a hybrid model with advanced technology like adaptive cruise control, lane-keeping assist, and a panoramic sunroof. Its luxurious interior and superior off-road capabilities make it a top choice in its class.", "/src/assets/suzuki_grand_vitara_3.png", 50, "Suzuki Grand Vitara (3)", 80.00m, 5, "Automatic" },
                    { 28, "Subcompact Hatchback", "The base Suzuki Alto is a budget-friendly subcompact hatchback with a manual transmission. Its small size and excellent fuel economy make it ideal for urban commuting and tight parking spaces.", "/src/assets/suzuki_alto_1.png", 27, "Suzuki Alto (1)", 20.00m, 4, "Manual" },
                    { 29, "Subcompact Hatchback", "This upgraded Alto model features enhanced features like power windows, air conditioning, and a rearview camera. It’s a practical choice for those seeking affordability and convenience.", "/src/assets/suzuki_alto_2.png", 27, "Suzuki Alto (2)", 25.00m, 4, "Manual" },
                    { 30, "Subcompact Hatchback", "The premium Alto variant includes advanced features such as a touchscreen infotainment system, alloy wheels, and a rear parking sensor. Its modern design and practicality make it a standout in the subcompact segment.", "/src/assets/suzuki_alto_3.png", 27, "Suzuki Alto (3)", 30.00m, 4, "Manual" }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Cars");
        }
    }
}
