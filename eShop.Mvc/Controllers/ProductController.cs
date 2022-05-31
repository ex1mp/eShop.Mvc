using AutoMapper;
using eShop.Mvc.BLL.Services;
using eShop.Mvc.BLL.ViewModels;
using eShop.Mvc.DAL;
using eShop.Mvc.DAL.Entities;
using eShop.Mvc.DAL.Enums;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace eShop.Mvc.Controllers
{
    public class ProductController : Controller
    {
        private readonly ApplicationContext aplicationContext;
        private readonly IMapper mapper;
        private readonly IProductService _productService;

        public ProductController(ApplicationContext aplicationContext, IMapper mapper, IProductService productService)
        {
            this.aplicationContext = aplicationContext;
            this.mapper = mapper;
            _productService = productService;
        }
        public IActionResult Index(string productId)
        {
             var product = _productService.GetproductById(new Guid(productId));

            return View(product);
        }

        [HttpPost]
        public async Task<IActionResult> Post(string productId)
        {
            return RedirectToAction("Index", "Product", new { productId = productId });
        }

    }
}
