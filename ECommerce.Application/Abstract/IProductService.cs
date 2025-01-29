using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		public Product GetById(int id);
		public void Add(Product product);
		public void Update(Product product);
		public void Delete(int id);
	}
}
