namespace Blog.Models
{
    public class Post
    {
        public int Id { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public required string Author { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
    }
}
