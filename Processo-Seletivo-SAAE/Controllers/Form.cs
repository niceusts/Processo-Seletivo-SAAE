using Microsoft.AspNetCore.Mvc;

namespace Processo_Seletivo_SAAE.Controllers
{
    public class Form : Controller
    {
        public IActionResult FormFiles()
        {
            return View();
        }
        public IActionResult InfoFiles()
        {
            return View();
        }
    }
}
