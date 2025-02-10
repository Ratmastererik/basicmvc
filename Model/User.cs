
using System.ComponentModel.DataAnnotations;

public class User
{
    public int Id { get; set; }
    [Required, Length(3, 32)]
    public string Username { get; set; } = "";
    public string Bio { get; set; } = "";
    public List<Post>? Post { get; set; }
}