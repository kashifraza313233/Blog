namespace Blog_WebAPP.Models.Domain
{
    public class Tag
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public string Discription { get; set; }
        public ICollection<BlogPost> BlogPosts { get; set;}
    }
}
