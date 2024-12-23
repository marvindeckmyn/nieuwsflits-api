namespace NieuwsFlits.API.Models
{
    public class NewsArticle
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Summary { get; set; }
        public int AuthorId { get; set; }
        public DateTime PublishDate { get; set; }
        public string Category { get; set; }
        public string? ImageUrl { get; set; }
        public List<string> Tags { get; set; } = new List<string>();
    }
}