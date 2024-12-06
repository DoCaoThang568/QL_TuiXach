using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QL_BanHang.Models;
using System.Linq;
using System.Threading.Tasks;

namespace QL_BanHang.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class HomeController : Controller
    {
        private readonly QL_BanHangTuiXachContext _context;

        public HomeController(QL_BanHangTuiXachContext context)
        {
            _context = context;

        }

        [Route("/admin")]
        public async Task<IActionResult> Index()
        {
            // Tính toán doanh thu
            decimal doanhThu = await _context.DonHangs
                .Where(dh => dh.TrangThai == "Đã thanh toán")
                .SelectMany(dh => dh.Ctdhs)
                .SumAsync(ctdh => (decimal)ctdh.SoLuong * (decimal)ctdh.MaSpNavigation.DonGia);


            ViewBag.DoanhThu = doanhThu;
            return View();
        }
    }
}
