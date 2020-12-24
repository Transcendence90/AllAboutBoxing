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

        [Required]
        public string ImageUrl { get; set; }

        public DateTime PublishedOn { get; set; }
    }
}
