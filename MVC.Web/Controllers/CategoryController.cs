using System.Linq;
using System.Web.Mvc;
using CS.Services;
using CS.Data;

namespace CS.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategoryService _categoryservice;

        public CategoryController(ICategoryService categoryservice)
        {
            _categoryservice = categoryservice;
        }

        public ActionResult Index()
        {
            var categories = _categoryservice.GetCategories().ToList();
            return View("Index", categories);
        }

        public ActionResult Details(int id)
        {
            Category category =
                _categoryservice.GetCategory(id);

            return category == null ? View("NotFound") : View("Details", category);
        }
    }
}
