using System.ComponentModel.DataAnnotations;

namespace SuperMarket.model.entity;

public class Produto
{
    [Key]
    public Guid id { get; set; }
    public string Name { get; set; }
    public decimal Price { get; set; }
    public int Quantity { get; set; }
}