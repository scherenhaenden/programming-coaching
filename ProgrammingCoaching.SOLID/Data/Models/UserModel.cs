namespace ProgrammingCoaching.SOLID.Data.Models;

public class UserModel
{
    public int Id { get; set; }
    public string Name { get; set; } = null!;
    public string Password { get; set; } = null!;
}