using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concret;

public class SupplierService(ISupplierDal supplierDal) : ISupplierService
{
	private readonly ISupplierDal _supplierDal = supplierDal;
	public void Add(Supplier supplier)
	{
		_supplierDal.Add(supplier);
	}

	public void Delete(int id)
	{
		var supplier = _supplierDal.Get(s => s.SupplierId == id);
		if (supplier != null)
		{
			_supplierDal.Delete(supplier);
		}
	}
	public List<Supplier> GetAll()
	{
		return _supplierDal.GetList();
	}

	public Supplier GetById(int id)
	{
		return _supplierDal.Get(s => s.SupplierId == id);
	}

	public void Update(Supplier supplier)
	{
		_supplierDal.Update(supplier);
	}
}
