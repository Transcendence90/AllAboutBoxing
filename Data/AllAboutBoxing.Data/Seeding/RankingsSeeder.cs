namespace AllAboutBoxing.Data.Seeding
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;

    using AllAboutBoxing.Data.Models;
    using AngleSharp;

    public class RankingsSeeder : ISeeder
    {
        public async Task SeedAsync(ApplicationDbContext dbContext, IServiceProvider serviceProvider)
        {
            if (dbContext.Rankings.Any())
            {
                return;
            }

            var config = Configuration.Default.WithDefaultLoader();
            var context = BrowsingContext.New(config);

            var rankingsDocument = await context.OpenAsync("https://www.worldboxingnews.net/boxing-rankings/");

            var names = rankingsDocument.QuerySelectorAll("div > div > ol > li");
            var rank = 1;

            var boxerNames = new List<string>();
            var boxerRanks = new List<int>();
            var weightClassId = 17;

            for (int i = 0; i < names.Count() - 10; i++)
            {
                if (rank == 6)
                {
                    rank = 1;
                }

                boxerRanks.Add(rank);
                boxerNames.Add(names[i].TextContent);
                rank++;
            }

            for (int i = 0; i < boxerNames.Count(); i++)
            {
                weightClassId = GetWeightClassId(weightClassId, i);

                await dbContext.AddAsync(new Ranking
                {
                    BoxerName = boxerNames[i],
                    Rank = boxerRanks[i],
                    WeightClassId = weightClassId,
                });
            }

            await dbContext.SaveChangesAsync();
        }

        private static int GetWeightClassId(int weightClassId, int i)
        {
            if (i <= 4)
            {
                weightClassId = 17;
            }
            else if (i > 4 && i <= 9)
            {
                weightClassId = 8;
            }
            else if (i > 9 && i <= 14)
            {
                weightClassId = 2;
            }
            else if (i > 14 && i <= 19)
            {
                weightClassId = 3;
            }
            else if (i > 19 && i <= 24)
            {
                weightClassId = 4;
            }
            else if (i > 24 && i <= 29)
            {
                weightClassId = 5;
            }
            else if (i > 29 && i <= 34)
            {
                weightClassId = 6;
            }
            else if (i > 34 && i <= 39)
            {
                weightClassId = 7;
            }
            else if (i > 39 && i <= 44)
            {
                weightClassId = 9;
            }
            else if (i > 44 && i <= 49)
            {
                weightClassId = 16;
            }
            else if (i > 49 && i <= 54)
            {
                weightClassId = 10;
            }
            else if (i > 54 && i <= 59)
            {
                weightClassId = 11;
            }
            else if (i > 59 & i <= 64)
            {
                weightClassId = 12;
            }
            else if (i > 64 && i <= 69)
            {
                weightClassId = 13;
            }
            else if (i > 69 && i <= 74)
            {
                weightClassId = 14;
            }
            else if (i > 74 && i <= 79)
            {
                weightClassId = 15;
            }
            else if (i > 79 && i <= 84)
            {
                weightClassId = 1;
            }

            return weightClassId;
        }
    }
}
