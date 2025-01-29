using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concret;

public class ShipperService(IShipperDal shipperDal) : IShipperService
{
	private readonly IShipperDal _shipperDal = shipperDal;

	public void Add(Shipper shipper)
	{
		_shipperDal.Add(shipper);
	}

	public void Delete(int id)
	{
		var shipper = _shipperDal.Get(s=>s.ShipperId == id);
		_shipperDal.Delete(shipper);
	}

	public List<Shipper> getAll()
	{
		return _shipperDal.GetList();
	}

	public Shipper getByShipperId(int id)
	{
		return _shipperDal.Get(s => s.ShipperId == id);
	}

	public void Update(Shipper shipper)
	{
		_shipperDal.Update(shipper);
	}
}
