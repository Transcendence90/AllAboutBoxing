using AllAboutBoxing.Data.Models.Enumerations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllAboutBoxing.Data.Models
{
    public class Bout
    {
        public int FirstBoxerId { get; set; }

        public Boxer FirstBoxer { get; set; }

        public int SecondBoxerId { get; set; }

        public Boxer SecondBoxer { get; set; }

        public int WeightClassId { get; set; }

        public WeightClass WeightClass { get; set; }

        public WayOfFinish WayOfFinish { get; set; }
    }
}
