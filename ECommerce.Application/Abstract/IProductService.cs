using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract
{
	public interface IProductService
	{
		List<Product> GetAll();
		public Product GetById(int id);
		List<Product> GetAllByCategory(int categoryId);
		public void Add(Product product);
		public void Update(Product product);
		public void Delete(int id);
	}
}
