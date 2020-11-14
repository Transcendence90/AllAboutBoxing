using System.ComponentModel.DataAnnotations.Schema;

namespace AllAboutBoxing.Data.Models
{
    public class BoxerBout
    {
        [ForeignKey(nameof(Bout))]
        public int BoutId { get; set; }

        public Bout Bout { get; set; }

        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }
    }
}
