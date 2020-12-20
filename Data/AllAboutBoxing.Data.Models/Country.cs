namespace AllAboutBoxing.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    using AllAboutBoxing.Data.Common.Models;

    public class Country : BaseDeletableModel<int>
    {
        public Country()
        {
            this.Boxers = new HashSet<Boxer>();
        }

        public string Name { get; set; }

        public string CountryCode { get; set; }

        public string FlagUrl { get; set; }

        public virtual ICollection<Boxer> Boxers { get; set; }
    }
}
