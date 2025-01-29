using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract;

public interface IEmployeeService
{
	public List<Employee> GetAll();
	public Employee GetById(int id);
	public void Add(Employee employee);
	public void Update(Employee employee);
	public void Delete(int id);
}
