namespace Zum_Rails.Responces
{
    public enum Tags
    {
        tech,
        health
    }
    public class PostResponce
    {
        public int ID { get; set; }
        public string Author { get; set; }
        public int AuthorId { get; set; }
        public int Likes { get; set; }
        public int Popularity { get; set; }
        public int Reads { get; set; }
        public Tags Tags { get; set; }
    };
}
