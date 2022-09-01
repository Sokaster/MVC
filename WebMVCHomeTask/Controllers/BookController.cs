using Microsoft.AspNetCore.Mvc;
using WebMVCHomeTask.Models;
namespace WebMVCHomeTask.Controllers
{
    public class BookController : Controller
    {
        public IActionResult Index()
        {
            BookViewModel book = new BookViewModel("Stiven King","ONO", 342);

            return View(book);

        }
    }
}
