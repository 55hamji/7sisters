using Microsoft.AspNetCore.Mvc;

namespace HarborLight.WebUI.Controllers
{
    public class NotificationsController : Controller
    {
        public IActionResult Sweetalert2() => View();
        public IActionResult Toastr() => View();
    }
}
