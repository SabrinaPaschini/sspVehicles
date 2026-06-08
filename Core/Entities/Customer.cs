namespace Core.Entities;

public class Customer
{
    public string Id { get; set; }
    public required string Name { get; set; }
    public string Email { get; set; }
    public string Phone { get; set; }
}