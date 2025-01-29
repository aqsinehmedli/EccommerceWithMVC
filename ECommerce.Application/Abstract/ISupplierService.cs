using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface ISupplierService
{
	public List<Supplier> GetAll();
	Supplier GetById(int id);
	public void Add(Supplier supplier);
	public void Update(Supplier supplier);
	public void Delete(int id);
}
