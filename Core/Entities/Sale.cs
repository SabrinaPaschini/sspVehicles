namespace Core.Entities;

public class Sale
{
    public int Id { get; set; }
    public int providerId { get; set; }
    public int customersId { get; set; }
    public decimal Total { get; set; }
    public string productSale { get; set; }
    
}