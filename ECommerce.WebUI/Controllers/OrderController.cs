using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
	public class OrderController : Controller
	{
		private readonly IOrderService _orderService;
		public IActionResult Index()
		{
			return View();
		}
	}
}
