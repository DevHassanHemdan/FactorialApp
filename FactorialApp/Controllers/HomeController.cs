using IRepositories;
using System.Web.Mvc;

namespace FactorialApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRepository _repository;
        public HomeController(IRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult CalculateFactorial()
        {
            return View();
        }
        [HttpPost]
        public JsonResult Calculate(int number)
        {
            var result = _repository.CalculateFactorial(number);
            return Json(result, JsonRequestBehavior.AllowGet);
        }
    }
}