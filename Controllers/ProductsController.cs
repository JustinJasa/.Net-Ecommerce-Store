using Microsoft.AspNetCore.Mvc;
using MyMvcApp.Data;

namespace BestStoreMVC.Controllers
{
    public class ProductsController: Controller
    {

        private readonly ApplicationDbContext context;
        public ProductsController(ApplicationDbContext context)
        {
            this.context = context;
        }

        public IActionResult Index()
        {
            var products = context.Products.OrderByDescending(products => products.Id).ToList();
            return View(products);
        }

    }

}