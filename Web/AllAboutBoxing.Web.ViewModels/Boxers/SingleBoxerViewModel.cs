namespace AllAboutBoxing.Web.ViewModels.Boxers
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;

    using AllAboutBoxing.Data.Models;
    using AllAboutBoxing.Services.Mapping;

    public class SingleBoxerViewModel : IMapFrom<Boxer>
    {
        public string Name { get; set; }

        public virtual Country Country { get; set; }

        public virtual WeightClass WeightClass { get; set; }

        public bool IsActive { get; set; }

        public string Residence { get; set; }

        public string ImageUrl { get; set; }

        public int Age => DateTime.Today.Year - DateTime.Parse(this.BirthDate, CultureInfo.InvariantCulture).Year;

        public string BirthDate { get; set; }

        public string DeathDate { get; set; }

        public string Description { get; set; }

        public string Alias { get; set; }

        public string Height { get; set; }

        public string Reach { get; set; }

        public string Debut { get; set; }

        public virtual Record Record { get; set; }

        public IEnumerable<BoxerBoutsViewModel> Bouts { get; set; }
    }
}
