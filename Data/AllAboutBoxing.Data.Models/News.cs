namespace AllAboutBoxing.Data.Models
{
    using AllAboutBoxing.Data.Common.Models;

    public class News : BaseModel<int>
    {
        public string Description { get; set; }

        public string Url { get; set; }

        public string ImageUrl { get; set; }
    }
}
