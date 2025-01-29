using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concret;

public class RegionService(IRegionDal regionDal) : IRegionService
{
	private readonly IRegionDal _regionDal = regionDal;

	public void Add(Region region)
	{
		_regionDal.Add(region);
	}

	public void Delete(int id)
	{
		var region = _regionDal.Get(r => r.RegionId == id);
		if (region != null)
		{
			_regionDal.Delete(region);
		}
	}

	public Region GetById(int id)
	{
		return _regionDal.Get(r=>r.RegionId == id);
	}

	public List<Region> GetList()
	{
		return _regionDal.GetList();
	}

	public void Update(Region region)
	{
		_regionDal.Update(region);
	}
}
