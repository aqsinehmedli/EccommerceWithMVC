using ECommerce.Domain.Entities;

namespace ECommerce.Domain.Models;

public class CartLine
{
	public Product Products { get; set; }
    public int Quantity { get; set; }
}
