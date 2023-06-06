namespace Blog_Web.Models.Domain
{
    public class Tags
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public ICollection<BlogPosts> BlogPost { get; set; }
    }
}
