using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers
{
	public class RegionController : Controller
	{
		private readonly IRegionService _regionService;
		public IActionResult Index()
		{
			return View();
		}
	}
}
