using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchLinux.Controllers
{
    [Route("arch-linux/help")]
    public class HelpController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [Route("instalacao")]
        public IActionResult Instalacao() 
        {
            return View();
        }
        [Route("pos_instalacao")]
        public IActionResult PosInstalacao() 
        {
            return View();
        }
    }
}
