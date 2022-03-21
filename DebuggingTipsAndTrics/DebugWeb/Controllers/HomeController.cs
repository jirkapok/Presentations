using Microsoft.AspNetCore.Mvc;
using DebugWeb.Models;

namespace DebugWeb.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        /// <summary>
        /// Menu > Debug > Windows > Exception Settings
        /// https://blogs.msdn.microsoft.com/visualstudioalm/2015/02/23/the-new-exception-settings-window-in-visual-studio-2015/
        /// </summary>
        public IActionResult ThrowException()
        {
            throw new FunnyException("No this way, bloody debugger...");
        }
    }
}
