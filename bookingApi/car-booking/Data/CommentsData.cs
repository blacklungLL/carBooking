using System.Globalization;
using Bogus;
using car_booking.Models;

namespace car_booking.Data;

public class CommentsData
{
    public static List<Comment> Comments = GenerateComments();

    private static List<Comment> GenerateComments()
    {
        var comments = new List<Comment>();
        var random = new Random();
        var faker = new Faker("en");
        var reviewTexts = new List<string>
        {
            "Great car overall—comfortable, stylish, and packed with tech. Smooth on highways, but city driving feels a bit underpowered. Infotainment system lags at times. Good safety features and fuel efficiency, though. Solid choice for the price.",
            "The car is amazing! Handles well on both city roads and highways. The interior is luxurious, and the sound system is top-notch. My only complaint is the lack of trunk space.",
            "This car is perfect for long trips. The seats are comfortable, and the suspension absorbs bumps well. However, the acceleration could be better. Overall, I'm satisfied!",
            "I love this car! It's reliable, easy to drive, and has excellent fuel economy. The only downside is the small rear-view mirror, which makes parking a bit tricky.",
            "A fantastic vehicle for everyday use. The dashboard design is modern, and the touchscreen interface is intuitive. My only issue is the lack of USB ports in the backseat.",
            "This car exceeded my expectations! It handles beautifully, and the engine is powerful. The only drawback is the high maintenance cost. Still worth it, though.",
            "Comfortable and spacious, this car is ideal for families. The air conditioning works perfectly, and the ride is smooth. However, the brakes feel a bit soft.",
            "The car is sleek and stylish, with a sporty look that turns heads. The handling is precise, but the suspension is a bit stiff. Great value for the money!",
            "I’ve been driving this car for a month now, and it’s been a great experience. The navigation system is accurate, and the fuel efficiency is impressive. Just wish it had more legroom.",
            "An excellent choice for urban driving. The car is compact, easy to park, and has a responsive engine. My only gripe is the noisy cabin at high speeds.",
            "This car is a dream to drive! The acceleration is smooth, and the interior is well-designed. The only downside is the lack of advanced driver-assistance features.",
            "Perfect for daily commutes. The car is reliable, economical, and easy to maintain. The only issue is the weak air conditioning, which struggles in hot weather.",
            "I’m impressed with this car’s performance. It’s quick off the line, and the steering is responsive. However, the infotainment system freezes occasionally.",
            "A solid car with a lot of features. The seats are comfortable, and the sound system is great. My only complaint is the lack of visibility from the rear window.",
            "This car is a joy to drive! It’s quiet, smooth, and has plenty of power. The only downside is the high cost of optional extras.",
            "Great value for the price! The car is reliable, fuel-efficient, and easy to handle. The only issue is the lack of storage space in the cabin.",
            "I love the design of this car—it’s modern and stylish. The ride is comfortable, but the suspension feels too soft. Overall, I’m happy with my purchase.",
            "The car is perfect for road trips. The seats are supportive, and the engine is powerful. However, the fuel consumption is higher than expected.",
            "A reliable and practical car. The controls are intuitive, and the safety features are impressive. My only complaint is the lack of a sunroof.",
            "This car is a great all-rounder. It’s comfortable, efficient, and fun to drive. The only downside is the small trunk space.",
            "The car is fantastic! It’s fast, handles well, and has a luxurious interior. The only issue is the expensive servicing costs.",
            "I’m very satisfied with this car. It’s spacious, comfortable, and has excellent safety ratings. The only drawback is the slow acceleration.",
            "A great car for families. The interior is spacious, and the ride is smooth. However, the infotainment system is outdated.",
            "This car is perfect for city driving. It’s compact, easy to maneuver, and has low running costs. The only issue is the lack of legroom in the backseat.",
            "The car is reliable and efficient. The fuel economy is excellent, and the handling is precise. My only complaint is the lack of advanced tech features.",
            "I’m impressed with this car’s comfort and style. The seats are plush, and the interior is well-designed. The only downside is the noisy engine.",
            "A solid choice for everyday use. The car is reliable, economical, and easy to maintain. The only issue is the lack of USB ports in the backseat.",
            "This car is perfect for long drives. The seats are comfortable, and the suspension absorbs bumps well. However, the acceleration could be better.",
            "The car is sleek and stylish, with a sporty look that turns heads. The handling is precise, but the suspension is a bit stiff."
        };

        int commentId = 1;
        for (int carId = 1; carId <= 30; carId++)
        {
            for (int i = 0; i < 2; i++) // Два отзыва на машину
            {
                var firstName = faker.Name.FirstName(Bogus.DataSets.Name.Gender.Female);
                var lastName = faker.Name.LastName(Bogus.DataSets.Name.Gender.Female);
                var name = $"{firstName} {lastName}";
                var position = faker.Company.CompanyName();
                var text = reviewTexts[random.Next(reviewTexts.Count)];
                var rating = random.Next(3, 6);
                var date = DateTime.ParseExact($"{random.Next(1, 31):D2}-{random.Next(1, 13):D2}-2024", "dd-mm-yyyy", CultureInfo.InvariantCulture);
                var img = $"../assets/faces/{random.Next(1,11)}.jpg";

                comments.Add(new Comment
                {
                    Id = commentId++,
                    Name = name,
                    Position = position,
                    Text = text,
                    Rating = rating,
                    Date = date,
                    Img = img,
                    CarId = carId
                });
            }
        }

        return comments;
    }
}