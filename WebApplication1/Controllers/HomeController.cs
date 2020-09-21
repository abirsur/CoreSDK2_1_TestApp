using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Common;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        IDataProtectionProvider dataProtectionProvider = DataProtectionProvider.Create("WebApplication1");
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EncryptData(string encData)
        {
            ViewBag.encString = new CipherService(dataProtectionProvider).Encrypt(encData);
            return View("Index");
        }

        public IActionResult DecryptData(string decData)
        {
            ViewBag.decString = new CipherService(dataProtectionProvider).Decrypt(decData);
            return View("Index");
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
