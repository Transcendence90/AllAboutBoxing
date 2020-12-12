namespace AllAboutBoxing.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AllAboutBoxing.Data.Models;

    public class WeightClassesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.WeightClasses.Any())
            {
                return;
            }

            dbContext.WeightClasses.Add(new WeightClass { Division = "Heavyweight", WeightLimit = "Unlimited", Established = 1738 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Cruiserweight", WeightLimit = "200 lb / 90.72 kg / 14 st 4 lb", Established = 1979 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Light Heavyweight", WeightLimit = "175 lb / 79.38 kg / 12 st 7lb", Established = 1903 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Super Middleweight", WeightLimit = "168 lb / 76.2 kg / 12 st", Established = 1967 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Middleweight", WeightLimit = "160 lb / 72.57 kg / 11 st 6 lb", Established = 1840 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Super Welterweight", WeightLimit = "154 lb / 69.85 kg / 11 st", Established = 1920 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Welterweight", WeightLimit = "147 lb / 66.68 kg / 10 st 7 lb", Established = 1909 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Super Lightweight", WeightLimit = "140 lb / 63.5 kg / 10 st", Established = 1962 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Lightweight", WeightLimit = "135 lb / 61.23 kg / 9 st 9 lb", Established = 1738 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Super Featherweight", WeightLimit = "130 lb / 58.97 kg / 9 st 4 lb", Established = 1920 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Featherweight", WeightLimit = "126 lb / 57.15 kg / 9 st", Established = 1860 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Super Bantamweight", WeightLimit = "122 lb / 55.34 kg / 8 st 10 lb", Established = 1920 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Bantamweight", WeightLimit = "118 lb / 53.52 kg / 8 st 6 lb", Established = 1890 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Super Flyweight", WeightLimit = "115 lb / 52.16 / 8 st 3 lb", Established = 1920 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Flyweight", WeightLimit = "112 lb / 50.8 kg / 8 st", Established = 1909 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Light Flyweight", WeightLimit = "108 lb / 48.99 kg / 7 st 10 lb", Established = 1975 });
            dbContext.WeightClasses.Add(new WeightClass { Division = "Minimumweight", WeightLimit = "105 lb / 47.7 kg / 7 st 7 lb", Established = 1968 });

            await dbContext.SaveChangesAsync();
        }
    }
}
