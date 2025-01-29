using ECommerce.Domain.Entities;

namespace ECommerce.Application.Abstract
{
	public interface IInvoiceService
	{
		public List<Invoice> GetAll();
		public void	Add(Invoice invoice);	
		public void Update(Invoice invoice);
		public void Delete(Invoice invoice);
	}
}
