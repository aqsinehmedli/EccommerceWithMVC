using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface IRegionService
{
	public List<Region> GetList();
	public Region GetById(int id);
	public void Update(Region region);
	public void Delete(int id);
	public void Add(Region region);
	
	
}
