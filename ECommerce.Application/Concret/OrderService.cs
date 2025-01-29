using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concret;

public class OrderService(IOrderDal orderDal):IOrderService
{
	private readonly IOrderDal _orderDal = orderDal;

	public void Add(Order order)
	{
		_orderDal.Add(order);
	}

	public void Delete(int id)
	{
		var order = _orderDal.Get(o=>o.OrderId == id);
		_orderDal.Delete(order);
	}

	public List<Order> GetAll()
	{
		return _orderDal.GetList();
	}

	public Order getById(int id)
	{
		return _orderDal.Get(o=>o.OrderId==id);
	}

	public void Update(Order order)
	{
		_orderDal.Update(order);
	}
}
