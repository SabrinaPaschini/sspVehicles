namespace Core.Entities;

public class Sale
{
    public int SaleId { get; set; }
    public int ProviderId { get; set; }
    public int CustomerId { get; set; }
    public decimal Total { get; set; }
    public Provider Provider { get; set; }
    public Customer Customer { get; set; }
    
}