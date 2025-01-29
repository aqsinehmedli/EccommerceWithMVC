using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
	public class SupplierController : Controller
	{
		private readonly ISupplierService _supplierService;
		public IActionResult Index()
		{
			return View();
		}
	}
}
