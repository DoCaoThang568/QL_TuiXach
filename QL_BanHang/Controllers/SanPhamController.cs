using Microsoft.AspNetCore.Mvc;
using QL_BanHang.Interfaces;

namespace QL_BanHang.Controllers
{
    public class SanPhamController : Controller
    {
        private readonly ISanPhamService _sanPhamService;

        public SanPhamController(ISanPhamService sanPhamService)
        {
            _sanPhamService = sanPhamService;
        }
        [Route("~/san-pham/{theloai}")]
        public IActionResult Index(int theloai)
        {
            return View(_sanPhamService.GetListSanPhamByTheLoai(theloai));
        }

        [Route("~/san-pham/{id}/_chi-tiet")]
        public IActionResult Detail(int id)
        {
            var sanpham = _sanPhamService.Get(id);

            var SanPhamTheLoai = _sanPhamService.GetListSanPhamByTheLoai((int)sanpham.MaLoaiSp, sanpham.MaSp, 3);
            ViewBag.SanPhamTheLoai = SanPhamTheLoai;
            return View(sanpham);
        }

        [HttpGet]   
        [Route("~/san-pham/tim-kiem")]
        public IActionResult Search(string p)
        {
            ViewBag.p = p;
            return View(_sanPhamService.Search(p));
        }

        [HttpGet]
        [Route("~/san-pham/loai-sp")]
        public IActionResult GetAllLoaiSp(string p)
        {
            return Ok(_sanPhamService.GetAllLoaiSP(p));
        }
    }
}
