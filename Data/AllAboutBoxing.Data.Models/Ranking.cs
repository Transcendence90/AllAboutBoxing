﻿using System.Collections.Concurrent;

namespace AllAboutBoxing.Data.Models
{
    public class Ranking
    {
        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }

        public Organization Organization { get; set; }
    }
}
