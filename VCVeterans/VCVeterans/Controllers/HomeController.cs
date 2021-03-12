using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using VCVeterans.Models;
using VCVBL;
using VCVModels;
namespace VCVeterans.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IUserBL _userBL;
        private readonly IImageBL _imageBL;
        public HomeController(IUserBL userBL, IImageBL imageBL)
        {
            _userBL = userBL;
            _imageBL = imageBL;
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult UploadImage(string email, string image)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    if (_userBL.GetUserByEmail(email) != null)
                    {
                        Image newImage = new Image();
                        newImage.User = _userBL.GetUserByEmail(email);
                        newImage.ByteStream = image;
                        _imageBL.AddImage(newImage);
                        return RedirectToAction(nameof(Index));
                    }
                    else
                    {
                        User newUser = new User();
                        newUser.Email = email;
                        _userBL.AddNewUser(newUser);
                        Image newImage = new Image();
                        newImage.User = _userBL.GetUserByEmail(email);
                        newImage.ByteStream = image;
                        _imageBL.AddImage(newImage);
                        return RedirectToAction(nameof(Index));
                    }
                }
                catch
                {
                    return View();
                }
            }
            return View("Index");
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
