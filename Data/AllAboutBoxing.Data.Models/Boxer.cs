namespace AllAboutBoxing.Data.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using AllAboutBoxing.Data.Models.Enumerations;

    public class Boxer
    {
        public Boxer()
        {
            this.HomeBouts = new HashSet<Bout>();
            this.AwayBouts = new HashSet<Bout>();
        }

        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public string Description { get; set; }

        public byte Age { get; set; }

        public Sex Sex { get; set; }

        [MaxLength(50)]
        public string Alias { get; set; }

        [ForeignKey(nameof(Bout))]
        public int BoutId { get; set; }

        public Bout Bout { get; set; }

        public Record Record { get; set; }

        public bool IsActive { get; set; }

        public string LogoUrl { get; set; }

        public int ResidenceId { get; set; }

        public Residence Residence { get; set; }

        public int BirthPlaceId { get; set; }

        public Residence BirthPlace { get; set; }

        public Stance Stance { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }

        public int Reach { get; set; }

        [InverseProperty("FirstBoxer")]
        public virtual ICollection<Bout> HomeBouts { get; set; }

        [InverseProperty("SecondBoxer")]
        public virtual ICollection<Bout> AwayBouts { get; set; }
    }
}
