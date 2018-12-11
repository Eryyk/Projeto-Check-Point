using Microsoft.AspNetCore.Mvc;

namespace Senai.Check.Point.Mvc.Web.Controllers
{
    public class PaginaController : Controller
    {
         public IActionResult FaleConosco() {
            return View();
        }


        [HttpGet]
        public IActionResult Home(){
            return View();
        }

        [HttpGet]

        public IActionResult Cadastrar () {
            return View();
        }

        [HttpGet]

        public IActionResult Login () {
            return View();
        }


    }
}