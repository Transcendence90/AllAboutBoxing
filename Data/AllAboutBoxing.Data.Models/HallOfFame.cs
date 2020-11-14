using AllAboutBoxing.Data.Common.Models;
using System.ComponentModel.DataAnnotations.Schema;

namespace AllAboutBoxing.Data.Models
{
    public class HallOfFame : BaseDeletableModel<int>
    {
        [ForeignKey(nameof(Boxer))]
        public int BoxerId { get; set; }

        public Boxer Boxer { get; set; }
    }
}
