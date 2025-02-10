public class Post
{
    public int Id { get; set; }
    public required User User { get; set; }
    public required string PostName { get; set; }
    public string Content { get; set; } = "";
}