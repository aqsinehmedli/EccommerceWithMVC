using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface IOrderService
{
	List<Order> GetAll();
	Order getById(int id);	
	void Add(Order order);
	void Update(Order order);
	void Delete(int id);
}
