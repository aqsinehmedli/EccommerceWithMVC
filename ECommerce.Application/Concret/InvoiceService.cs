using ECommerce.Application.Abstract;
using ECommerce.DataAccess.Abstract;
using ECommerce.Domain.Entities;

namespace ECommerce.Application.Concret;

public class InvoiceService(IInvoiceDal invoiceDal) : IInvoiceService
{
	private readonly IInvoiceDal _invoiceDal = invoiceDal;

	public void Add(Invoice invoice)
	{
		_invoiceDal.Add(invoice);
	}

	public void Delete(Invoice invoice)
	{
		_invoiceDal.Delete(invoice);
	}

	public List<Invoice> GetAll()
	{
		return _invoiceDal.GetList();
	}

	public void Update(Invoice invoice)
	{
		_invoiceDal.Update(invoice);
	}
}
