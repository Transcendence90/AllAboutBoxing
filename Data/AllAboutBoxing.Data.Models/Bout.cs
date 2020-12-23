﻿namespace AllAboutBoxing.Data.Models
{
    using System.ComponentModel.DataAnnotations;

    using AllAboutBoxing.Data.Common.Models;

    public class Bout : BaseDeletableModel<int>
    {
        public int BoxerId { get; set; }

        public virtual Boxer Boxer { get; set; }

        public string OpponentName { get; set; }

        public int WeightClassId { get; set; }

        public virtual WeightClass WeightClass { get; set; }

        public string WayOfFinish { get; set; }

        public string BoutDate { get; set; }

        public string Place { get; set; }

        [MaxLength(500)]
        public string TitlesInFight { get; set; }
    }
}
