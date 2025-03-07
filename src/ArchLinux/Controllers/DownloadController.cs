using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ArchLinux.Controllers
{
    [Route("arch-linux/download")]
    public class DownloadController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        //[HttpPost,ActionName("Index")]
        //public async Task<IActionResult> DownloadFile()
        //{
        //    var fileBytes = await System.IO.File.ReadAllBytesAsync("wwwroot/file/archlinux-2021.05.01-x86_64.iso");
        //    var fileName = "archlinux-demostration.iso";
        //
       //     return File(fileBytes, System.Net.Mime.MediaTypeNames.Application.Octet, fileName);
      //  }
    }
}
