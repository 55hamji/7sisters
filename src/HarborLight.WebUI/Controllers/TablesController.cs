using Microsoft.AspNetCore.Mvc;

namespace HarborLight.WebUI.Controllers
{
    public class TablesController : Controller
    {
        public IActionResult Basic() => View();
        public IActionResult GenerateStyle() => View();
    }
}
