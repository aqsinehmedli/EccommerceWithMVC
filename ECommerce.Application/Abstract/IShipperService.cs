using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface IShipperService
{
	public List<Shipper> getAll();
	public Shipper getByShipperId(int id);
	public void Add(Shipper shipper);
	public void Delete(int id);
	public void Update(Shipper shipper);
}
