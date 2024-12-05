using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using QL_BanHang.Interfaces;
using QL_BanHang.Models;
using QL_BanHang.Services;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace QL_BanHang.Controllers
{
    public class HomeController : Controller
    {
        private readonly ISanPhamService _sanPhamService;

       
        public HomeController(ISanPhamService sanPhamService)
        {
            _sanPhamService = sanPhamService;
        }
        // Page 
        public IActionResult Index(int page = 1, int? limit = 9)
        {
            ViewBag.SanPhamNgauNhien = _sanPhamService.GetRandomSanPham();
            return View(_sanPhamService.GetAll(page, limit));
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
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
