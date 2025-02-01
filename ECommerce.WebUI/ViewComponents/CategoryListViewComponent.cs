using ECommerce.Application.Abstract;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.ViewComponents
{
		public class CategoryListViewComponent(ICategoryService categoryService) : ViewComponent
		{
			private readonly ICategoryService _categoryService = categoryService;

			public ViewViewComponentResult Invoke()
			{
				var model = new CategoryListViewModel
				{
					Categories = _categoryService.GetAll(),
					CurrentCategory = Convert.ToInt32((HttpContext.Request.Query)["categoryId"])
				};
				return View(model);
			}
	}
}
