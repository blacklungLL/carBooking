using car_booking.Entities;

namespace car_booking.DataSeeds;

public static class Seed
{
    public static List<Car> Cars = new List<Car>()
    {
        new Car
        {
            Id = 1,
            Name = "Suzuki Swift (1)",
            Category = "Hatchback",
            Img = "/src/assets/suzuki_swift_1.png",
            Liters = 37,
            Transmission = "Manual",
            Spaces = 5,
            Price = 30.00m,
            Description =
                "The base model of the Suzuki Swift is perfect for urban driving. With a fuel-efficient engine and a compact design, it offers excellent maneuverability in city traffic. The manual transmission ensures a sporty driving experience, while the spacious interior provides comfort for all passengers."
        },
        new Car
        {
            Id = 2,
            Name = "Suzuki Swift (2)",
            Category = "Hatchback",
            Img = "/src/assets/suzuki_swift_2.png",
            Liters = 37,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 35.00m,
            Description =
                "This upgraded version of the Suzuki Swift features an automatic transmission for a smoother ride. Equipped with advanced safety features, air conditioning, and a modern infotainment system, it is an ideal choice for those seeking convenience and comfort in their daily commute."
        },
        new Car
        {
            Id = 3,
            Name = "Suzuki Swift (3)",
            Category = "Hatchback",
            Img = "/src/assets/suzuki_swift_3.png",
            Liters = 37,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 45.00m,
            Description =
                "The sporty variant of the Suzuki Swift comes with a turbocharged engine and automatic transmission. Designed for performance enthusiasts, it combines dynamic handling with a stylish exterior and premium interior features, making it stand out on the road."
        },
        new Car
        {
            Id = 4,
            Name = "Suzuki Vitara (1)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_vitara_1.png",
            Liters = 47,
            Transmission = "Manual",
            Spaces = 5,
            Price = 45.00m,
            Description =
                "The entry-level Suzuki Vitara is equipped with a manual transmission and front-wheel drive. Its compact size and efficient fuel consumption make it a great choice for urban adventures, while its robust design ensures durability and reliability."
        },
        new Car
        {
            Id = 5,
            Name = "Suzuki Vitara (2)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_vitara_2.png",
            Liters = 47,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 55.00m,
            Description =
                "This mid-range Vitara model features an automatic transmission and all-wheel drive. It includes advanced technology such as a touchscreen infotainment system, leather seats, and enhanced safety features, offering a blend of comfort and capability."
        },
        new Car
        {
            Id = 6,
            Name = "Suzuki Vitara (3)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_vitara_3.png",
            Liters = 47,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 65.00m,
            Description =
                "The top-tier Suzuki Vitara is a hybrid model designed for eco-conscious drivers. With advanced driver-assistance systems, a luxurious interior, and superior off-road capabilities, it’s perfect for both city streets and rugged terrains."
        },
        new Car
        {
            Id = 7,
            Name = "Suzuki Jimny (1)",
            Category = "SUV",
            Img = "/src/assets/suzuki_jimmy_1.png",
            Liters = 40,
            Transmission = "Manual",
            Spaces = 4,
            Price = 50.00m,
            Description =
                "The classic Suzuki Jimny is a no-frills, rugged SUV with a manual transmission and four-wheel drive. Its compact size and legendary off-road capabilities make it a favorite among adventure seekers and outdoor enthusiasts."
        },
        new Car
        {
            Id = 8,
            Name = "Suzuki Jimny (2)",
            Category = "SUV",
            Img = "/src/assets/suzuki_jimmy_2.png",
            Liters = 40,
            Transmission = "Automatic",
            Spaces = 4,
            Price = 60.00m,
            Description =
                "This upgraded Jimny model features an automatic transmission and enhanced off-road equipment. With improved ground clearance, durable tires, and additional accessories, it’s built to tackle challenging terrains with ease."
        },
        new Car
        {
            Id = 9,
            Name = "Suzuki Jimny (3)",
            Category = "SUV",
            Img = "/src/assets/suzuki_jimmy_3.png",
            Liters = 40,
            Transmission = "Manual",
            Spaces = 4,
            Price = 70.00m,
            Description =
                "The premium version of the Suzuki Jimny is designed for extreme off-roading. Featuring a reinforced chassis, advanced suspension, and specialized accessories, it’s the ultimate choice for adventurers who demand maximum performance and reliability."
        },
        new Car
        {
            Id = 10,
            Name = "Suzuki SX4 S-Cross (1)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_sx_4_s_cross_1.png",
            Liters = 48,
            Transmission = "Manual",
            Spaces = 5,
            Price = 40.00m,
            Description =
                "The base model of the Suzuki SX4 S-Cross is a practical crossover with a manual transmission and front-wheel drive. Its sleek design and efficient fuel consumption make it a versatile option for everyday use."
        },
        new Car
        {
            Id = 11,
            Name = "Suzuki SX4 S-Cross (2)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_sx_4_s_cross_2.png",
            Liters = 48,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 50.00m,
            Description =
                "This mid-range SX4 S-Cross model features an automatic transmission and all-wheel drive. Equipped with leather upholstery, climate control, and advanced safety technologies, it offers a refined driving experience."
        },
        new Car
        {
            Id = 12,
            Name = "Suzuki SX4 S-Cross (3)",
            Category = "Crossover",
            Img = "/src/assets/suzuki-sx4-s-cross_3.png",
            Liters = 48,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 60.00m,
            Description =
                "The top-of-the-line SX4 S-Cross is a hybrid model with cutting-edge technology. It includes adaptive cruise control, lane-keeping assist, and a premium sound system, ensuring comfort and safety on every journey."
        },
        new Car
        {
            Id = 13,
            Name = "Suzuki Baleno (1)",
            Category = "Hatchback",
            Img = "/src/assets/suzuki_baleno_1.png",
            Liters = 37,
            Transmission = "Manual",
            Spaces = 5,
            Price = 35.00m,
            Description =
                "The entry-level Suzuki Baleno is a compact hatchback with a manual transmission. Its lightweight design and fuel-efficient engine make it an excellent choice for urban commuters who value practicality and affordability."
        },
        new Car
        {
            Id = 14,
            Name = "Suzuki Baleno (2)",
            Category = "Hatchback",
            Img = "/src/assets/suzuki_baleno_2.png",
            Liters = 37,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 40.00m,
            Description =
                "This upgraded Baleno model features an automatic transmission and enhanced features such as air conditioning, a touchscreen infotainment system, and alloy wheels. It’s perfect for those seeking a balance of comfort and style."
        },
        new Car
        {
            Id = 15,
            Name = "Suzuki Baleno (3)",
            Category = "Hatchback",
            Img = "/src/assets/suzuki_baleno_3.png",
            Liters = 37,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 45.00m,
            Description =
                "The premium Baleno variant offers luxury features like leather seats, navigation, and advanced driver-assistance systems. Its spacious cabin and modern design make it a standout choice in the hatchback segment."
        },
        new Car
        {
            Id = 16,
            Name = "Suzuki Celerio (1)",
            Category = "Subcompact Hatchback",
            Img = "/src/assets/suzuki_celerio_1.png",
            Liters = 35,
            Transmission = "Manual",
            Spaces = 5,
            Price = 25.00m,
            Description =
                "The base Suzuki Celerio is a budget-friendly subcompact hatchback with a manual transmission. Its small size and excellent fuel economy make it ideal for navigating crowded city streets."
        },
        new Car
        {
            Id = 17,
            Name = "Suzuki Celerio (2)",
            Category = "Subcompact Hatchback",
            Img = "/src/assets/suzuki_celerio_2.png",
            Liters = 35,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 30.00m,
            Description =
                "This upgraded Celerio model features an automatic transmission and a more stylish exterior. With added features like power windows and a rearview camera, it offers enhanced convenience and functionality."
        },
        new Car
        {
            Id = 18,
            Name = "Suzuki Celerio (3)",
            Category = "Subcompact Hatchback",
            Img = "/src/assets/suzuki_celerio_3.png",
            Liters = 35,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 35.00m,
            Description =
                "The top-tier Celerio includes advanced features such as a touchscreen infotainment system, alloy wheels, and a rear parking sensor. It’s a smart choice for drivers looking for affordability without compromising on comfort."
        },
        new Car
        {
            Id = 19,
            Name = "Suzuki Ertiga (1)",
            Category = "Minivan",
            Img = "/src/assets/suzuki_ertiga_1.png",
            Liters = 45,
            Transmission = "Manual",
            Spaces = 7,
            Price = 50.00m,
            Description =
                "The base model of the Suzuki Ertiga is a practical minivan with a manual transmission and front-wheel drive. Its spacious interior and fuel efficiency make it an excellent choice for families and long trips."
        },
        new Car
        {
            Id = 20,
            Name = "Suzuki Ertiga (2)",
            Category = "Minivan",
            Img = "/src/assets/suzuki_ertiga_2.png",
            Liters = 45,
            Transmission = "Automatic",
            Spaces = 7,
            Price = 60.00m,
            Description =
                "This mid-range Ertiga model features an automatic transmission and upgraded features like leather seats, climate control, and advanced safety systems. It’s perfect for those who prioritize comfort and convenience."
        },
        new Car
        {
            Id = 21,
            Name = "Suzuki Ertiga (3)",
            Category = "Minivan",
            Img = "/src/assets/suzuki_ertiga_3.png",
            Liters = 45,
            Transmission = "Automatic",
            Spaces = 7,
            Price = 70.00m,
            Description =
                "The premium Ertiga variant offers luxury features such as a touchscreen infotainment system, navigation, and a rear entertainment system. Its spacious cabin and modern design make it ideal for family travel."
        },
        new Car
        {
            Id = 22,
            Name = "Suzuki Ignis (1)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_ignis_1.png",
            Liters = 32,
            Transmission = "Manual",
            Spaces = 4,
            Price = 35.00m,
            Description =
                "The base Suzuki Ignis is a compact crossover with a manual transmission and front-wheel drive. Its unique design and fuel efficiency make it a great choice for urban driving and weekend getaways."
        },
        new Car
        {
            Id = 23,
            Name = "Suzuki Ignis (2)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_ignis_2.jpg",
            Liters = 32,
            Transmission = "Automatic",
            Spaces = 4,
            Price = 40.00m,
            Description =
                "This upgraded Ignis model features an automatic transmission and a hybrid powertrain. With advanced safety features and a modern infotainment system, it offers a blend of style and technology."
        },
        new Car
        {
            Id = 24,
            Name = "Suzuki Ignis (3)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_ignis_3.png",
            Liters = 32,
            Transmission = "Automatic",
            Spaces = 4,
            Price = 45.00m,
            Description =
                "The top-tier Ignis variant is a hybrid model with advanced features like adaptive cruise control, lane departure warning, and a premium audio system. Its compact size and modern design make it a standout in the crossover segment."
        },
        new Car
        {
            Id = 25,
            Name = "Suzuki Grand Vitara (1)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_grand_vitara_1.png",
            Liters = 50,
            Transmission = "Manual",
            Spaces = 5,
            Price = 60.00m,
            Description =
                "The base model of the Suzuki Grand Vitara is a rugged crossover with a manual transmission and front-wheel drive. Its spacious interior and reliable performance make it a great choice for both city and off-road driving."
        },
        new Car
        {
            Id = 26,
            Name = "Suzuki Grand Vitara (2)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_grand_vitara_2.png",
            Liters = 50,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 70.00m,
            Description =
                "This mid-range Grand Vitara model features an automatic transmission and all-wheel drive. Equipped with leather seats, a touchscreen infotainment system, and advanced safety features, it offers a refined driving experience."
        },
        new Car
        {
            Id = 27,
            Name = "Suzuki Grand Vitara (3)",
            Category = "Crossover",
            Img = "/src/assets/suzuki_grand_vitara_3.png",
            Liters = 50,
            Transmission = "Automatic",
            Spaces = 5,
            Price = 80.00m,
            Description =
                "The premium Grand Vitara variant is a hybrid model with advanced technology like adaptive cruise control, lane-keeping assist, and a panoramic sunroof. Its luxurious interior and superior off-road capabilities make it a top choice in its class."
        },
        new Car
        {
            Id = 28,
            Name = "Suzuki Alto (1)",
            Category = "Subcompact Hatchback",
            Img = "/src/assets/suzuki_alto_1.png",
            Liters = 27,
            Transmission = "Manual",
            Spaces = 4,
            Price = 20.00m,
            Description =
                "The base Suzuki Alto is a budget-friendly subcompact hatchback with a manual transmission. Its small size and excellent fuel economy make it ideal for urban commuting and tight parking spaces."
        },
        new Car
        {
            Id = 29,
            Name = "Suzuki Alto (2)",
            Category = "Subcompact Hatchback",
            Img = "/src/assets/suzuki_alto_2.png",
            Liters = 27,
            Transmission = "Manual",
            Spaces = 4,
            Price = 25.00m,
            Description =
                "This upgraded Alto model features enhanced features like power windows, air conditioning, and a rearview camera. It’s a practical choice for those seeking affordability and convenience."
        },
        new Car
        {
            Id = 30,
            Name = "Suzuki Alto (3)",
            Category = "Subcompact Hatchback",
            Img = "/src/assets/suzuki_alto_3.png",
            Liters = 27,
            Transmission = "Manual",
            Spaces = 4,
            Price = 30.00m,
            Description =
                "The premium Alto variant includes advanced features such as a touchscreen infotainment system, alloy wheels, and a rear parking sensor. Its modern design and practicality make it a standout in the subcompact segment."
        }
    };
}