using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
	public class InvoiceController : Controller
	{
		private readonly IInvoiceService _invoiceService;
		public IActionResult Index()
		{
			return View();
		}
	}
}
