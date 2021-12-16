namespace SMNG.Models.RDBS.Entities;
public class OrderDetailEntity
{
    public int Id { get; set; }
    public int OrderHeaderId { get; set; }
    public int ProductId { get; set; }
    public int Quantity { get; set; }
}

