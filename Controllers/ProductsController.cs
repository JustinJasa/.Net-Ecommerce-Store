using Microsoft.AspNetCore.Mvc;

namespace BestStoreMVC.Controllers
{
    public class ProductsController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }


}