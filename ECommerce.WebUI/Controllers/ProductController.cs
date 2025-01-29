using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
	public class ProductController : Controller
	{
		private readonly IProductService _productService;
		public IActionResult Index()
		{
			return View();
		}
	}
}
