
using System.ComponentModel.DataAnnotations;

public class Stuff
{
    public int Id { get; set; }
    public string Name { get; set; } = "";
    [Required, Length(3, 32)]
    public string Description { get; set; } = "";
    [Range(1, 100)]
    public int Price { get; set; } = 0;
    public int Amount { get; set; } = 0;
    public string Category { get; set; } = "";
}