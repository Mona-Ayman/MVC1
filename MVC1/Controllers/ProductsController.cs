using Microsoft.AspNetCore.Mvc;

namespace MVC1.Controllers
{
    public class ProductsController : Controller
    {
        public IActionResult Get(int id)
        {
            //ContentResult contentResult = new ContentResult();
            //contentResult.Content = $"Product id {id}";
            ////contentResult.ContentType = "object/pdf" ;
            //contentResult.ContentType = "text/html";


            return Content($"Product id {id}" , "text/html");
        }

        public IActionResult RedirectMethod()
        {
            //RedirectResult redirect = new RedirectResult("https://www.google.com");
            return Redirect("https://www.google.com");
        }

        public IActionResult RedirectTo()
        {
            //RedirectToActionResult redirect = new RedirectToActionResult(nameof(Get),"products", new { id = 5 });
            return RedirectToAction(nameof(Get), new { id = 5 });
        }
    }
}
