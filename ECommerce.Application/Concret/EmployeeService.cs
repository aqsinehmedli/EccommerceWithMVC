using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concret;

public class EmployeeService(IEmployeeDal employeeDal) : IEmployeeService
{
	private readonly IEmployeeDal _employeeDal = employeeDal;

	public void Add(Employee employee)
	{
		_employeeDal.Add(employee);
	}

	public void Delete(int id)
	{
		var employee = _employeeDal.Get(e => e.EmployeeId == id);
		if (employee != null)
		{
			_employeeDal.Delete(employee);
		}
	}

	public List<Employee> GetAll()
	{
		return _employeeDal.GetList();
	}

	public Employee GetById(int id)
	{
		return _employeeDal.Get(e=>e.EmployeeId == id);
	}

	public void Update(Employee employee)
	{
		_employeeDal.Update(employee);	
	}
}
