using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
	public class ShipperController : Controller
	{
		private readonly IShipperService _shipperService;
		public IActionResult Index()
		{
			return View();
		}
	}
}
