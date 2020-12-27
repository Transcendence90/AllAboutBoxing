namespace AllAboutBoxing.Data.Models
{
    using System;
    using System.ComponentModel.DataAnnotations;

    using AllAboutBoxing.Data.Common.Models;

    public class News : BaseModel<int>
    {
        [Required]
        public string Name { get; set; }

        [Required]
        public string Description { get; set; }

        [Required]
        public string OriginalUrl { get; set; }

        public string ImageUrl { get; set; }

        [Required]
        public DateTime PublishedOn { get; set; }
    }
}
