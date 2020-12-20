using System;
using System.Collections.Generic;
using System.Text;

namespace AllAboutBoxing.Data.Models
{
    public class BoxerBout
    {
        public int Id { get; set; }

        public int BoxerId { get; set; }

        public virtual Boxer Boxer { get; set; }

        public int BoutId { get; set; }

        public virtual Bout Bout { get; set; }
    }
}
