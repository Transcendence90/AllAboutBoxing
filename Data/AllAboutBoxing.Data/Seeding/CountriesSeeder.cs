namespace AllAboutBoxing.Data.Seeding
{
    using System;
    using System.Linq;
    using System.Threading.Tasks;

    using AllAboutBoxing.Data.Models;

    public class CountriesSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Countries.Any())
            {
                return;
            }

            await dbContext.Countries.AddAsync(new Country { Name = "United Kingdom", CountryCode = "GB", FlagUrl = "https://www.countryflags.io/GB/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "United States", CountryCode = "US", FlagUrl = "https://www.countryflags.io/US/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Buglaria", CountryCode = "BG", FlagUrl = "https://www.countryflags.io/BG/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "France", CountryCode = "FR", FlagUrl = "https://www.countryflags.io/FR/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Spain", CountryCode = "ES", FlagUrl = "https://www.countryflags.io/ES/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Italy", CountryCode = "IT", FlagUrl = "https://www.countryflags.io/IT/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Germany", CountryCode = "DE", FlagUrl = "https://www.countryflags.io/DE/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Colombia", CountryCode = "CO", FlagUrl = "https://www.countryflags.io/CO/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Cuba", CountryCode = "CU", FlagUrl = "https://www.countryflags.io/CU/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Nigeria", CountryCode = "NG", FlagUrl = "https://www.countryflags.io/NG/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Norway", CountryCode = "NO", FlagUrl = "https://www.countryflags.io/NO/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Netherlands", CountryCode = "NL", FlagUrl = "https://www.countryflags.io/NL/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "New Zealand", CountryCode = "NZ", FlagUrl = "https://www.countryflags.io/NZ/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Poland", CountryCode = "PL", FlagUrl = "https://www.countryflags.io/PL/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Portugal", CountryCode = "PT", FlagUrl = "https://www.countryflags.io/PT/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Philippines", CountryCode = "PH", FlagUrl = "https://www.countryflags.io/PH/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Denmark", CountryCode = "DK", FlagUrl = "https://www.countryflags.io/DK/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Switzerland", CountryCode = "CH", FlagUrl = "https://www.countryflags.io/CH/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "China", CountryCode = "CN", FlagUrl = "https://www.countryflags.io/CN/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Japan", CountryCode = "JP", FlagUrl = "https://www.countryflags.io/JP/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Thailand", CountryCode = "TH", FlagUrl = "https://www.countryflags.io/TH/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Turkey", CountryCode = "TR", FlagUrl = "https://www.countryflags.io/TR/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Ukraine", CountryCode = "UA", FlagUrl = "https://www.countryflags.io/UA/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Russian Federation", CountryCode = "RU", FlagUrl = "https://www.countryflags.io/RU/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Romania", CountryCode = "RO", FlagUrl = "https://www.countryflags.io/RO/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Latvia", CountryCode = "LV", FlagUrl = "https://www.countryflags.io/LV/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Democratic Republic Of The Congo", CountryCode = "CD", FlagUrl = "https://www.countryflags.io/CD/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Armenia", CountryCode = "AM", FlagUrl = "https://www.countryflags.io/AM/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Kazakhstan", CountryCode = "KZ", FlagUrl = "https://www.countryflags.io/KZ/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Uzbekistan", CountryCode = "UZ", FlagUrl = "https://www.countryflags.io/UZ/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Canada", CountryCode = "CA", FlagUrl = "https://www.countryflags.io/CA/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Mexico", CountryCode = "MX", FlagUrl = "https://www.countryflags.io/MX/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Brazil", CountryCode = "BR", FlagUrl = "https://www.countryflags.io/BR/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Nicaragua", CountryCode = "NI", FlagUrl = "https://www.countryflags.io/NI/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Venezuela", CountryCode = "VE", FlagUrl = "https://www.countryflags.io/VE/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Puerto Rico", CountryCode = "PR", FlagUrl = "https://www.countryflags.io/PR/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "South Africa", CountryCode = "ZA", FlagUrl = "https://www.countryflags.io/ZA/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Sweden", CountryCode = "SE", FlagUrl = "https://www.countryflags.io/SE/shiny/64.png" });
            await dbContext.Countries.AddAsync(new Country { Name = "Finland", CountryCode = "FI", FlagUrl = "https://www.countryflags.io/FI/shiny/64.png" });

            await dbContext.SaveChangesAsync();
        }
    }
}
