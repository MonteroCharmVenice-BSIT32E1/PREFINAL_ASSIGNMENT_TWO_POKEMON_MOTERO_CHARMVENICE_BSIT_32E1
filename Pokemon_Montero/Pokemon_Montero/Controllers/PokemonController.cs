using Microsoft.AspNetCore.Mvc;

namespace Pokemon_Montero.Controllers
{
    public class PokemonController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
