using System.ComponentModel.DataAnnotations.Schema;

namespace AllAboutBoxing.Data.Models
{
    public class BoxerBout
    {
        public int BoutId { get; set; }

        public Bout Bout { get; set; }

        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }
    }
}
