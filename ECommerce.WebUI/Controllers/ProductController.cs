using ECommerce.Application.Abstract;
using ECommerce.Domain.Entities;
using ECommerce.WebUI.Models;
using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class ProductController : Controller
{
    private readonly IProductService _productService;
    private readonly ICategoryService _categoryService;

    public ProductController(IProductService productService, ICategoryService categoryService)
    {
        _productService = productService;
        _categoryService = categoryService;
    }

    public IActionResult Index(int page = 1, int categoryId = 0)
    {
        int pageSize = 10;
        var products = _productService.GetAllByCategory(categoryId);
        var paginatedProducts = products.Skip((page - 1) * pageSize).Take(pageSize).ToList();
        var model = new ProductListViewModel
        {
            Products = paginatedProducts,
            CurrentCategory = categoryId,
            PageCount = (int)Math.Ceiling(products.Count / (double)pageSize),
            CurrentPage = page

        };
        return View(model);
    }
    [HttpGet]
    public IActionResult Add()
    {
        var model = new ProductAddViewModel();
        model.Product = new Domain.Entities.Product();
        model.Categories = _categoryService.GetAll();
        return View(model);
    }
    [HttpPost]
    public IActionResult Add(ProductAddViewModel model)
    {
        _productService.Add(model.Product);
        return RedirectToAction("index");
    }
    [HttpGet]
    public IActionResult Update(int id)
    {
        var product = _productService.GetById(id);

        if (product == null)
        {
            return NotFound(); 
        }

        var model = new ProductUpdateViewModel
        {
            Product = product
        };

        return View(model);
    }
    [HttpPost]
    public IActionResult Update(ProductUpdateViewModel model)
    {
        if (ModelState.IsValid)
        {
            var product = _productService.GetById(model.Product.ProductId);

            if (product != null)
            {
                product.ProductName = model.Product.ProductName;
                product.UnitPrice = model.Product.UnitPrice;
                product.UnitsInStock = model.Product.UnitsInStock;
                //product.CategoryId = model.Product.CategoryId;

                _productService.Update(product);

                return RedirectToAction("Index");
            }
            else
            {
                ModelState.AddModelError("", "Ürün bulunamadı.");
            }
        }

        return View(model);
    }

    [HttpGet]
    public IActionResult Delete(int id)
    {
        var product = _productService.GetById(id);
        if (product == null)
        {
            Console.WriteLine($"{id} gecersiz");
            return NotFound();
        }
        var model = new ProductDeleteViewModel
        {
            ProductId = product.ProductId,
        };
        return View(model);
    }
    [HttpPost]
    public IActionResult Delete(ProductDeleteViewModel viewModel)
    {
        if (ModelState.IsValid)
        {
            _productService.Delete(viewModel.ProductId);
            return RedirectToAction("Index");
        }
        return View(viewModel);


    }
}
