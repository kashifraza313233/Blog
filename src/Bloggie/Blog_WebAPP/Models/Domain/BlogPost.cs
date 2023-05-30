namespace Blog_WebAPP.Models.Domain
{
    public class BlogPost
    {
        public Guid ID { get; set; }
        public string? Heading { get; set; }
        public string? PageTitle { get; set; }
        public string? Content { get; set; }
        public string? ShortDescription { get; set; }
        public string? ImageUrl { get; set; }
        public string? UrlHandler { get; set; }
        public DateTime PublisDate { get; set; }
        public string? Author{ get; set; }
        public bool? Visible{ get; set; }

    }
}
