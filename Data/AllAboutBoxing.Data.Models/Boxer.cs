using AllAboutBoxing.Data.Models.Enumerations;
using System;
using System.ComponentModel.DataAnnotations;

namespace AllAboutBoxing.Data.Models
{
    public class Boxer
    {
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }

        public byte Age { get; set; }

        public Sex Sex { get; set; }

        [MaxLength(50)]
        public string Alias { get; set; }

        public Record Record { get; set; }

        public bool IsActive { get; set; }

        public float Rating { get; set; }

        public int ResidenceId { get; set; }

        public Residence Residence { get; set; }

        public Residence BirthPlace { get; set; }

        public Stance Stance { get; set; }

        public DateTime BirthDate { get; set; }

        public int Height { get; set; }

        public int Reach { get; set; }
    }
}
