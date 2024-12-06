using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using QL_BanHang.Extensions;
using QL_BanHang.Interfaces;
using QL_BanHang.Models;
using QL_BanHang.Services;
using System;
using System.Threading.Tasks;
using System.Linq;

namespace QL_BanHang.Controllers
{
    public class GioHangController : Controller
    {
        private readonly ISanPhamService _phamService;
        private readonly IGioHangService _gioHangService;
        private readonly QL_BanHangTuiXachContext _context;
        public GioHangController(ISanPhamService phamService, IGioHangService gioHangService, QL_BanHangTuiXachContext context)
        {
            _gioHangService = gioHangService;
            _phamService = phamService;
            _context = context;
        }
        [Route("~/gio-hang")]
        public async Task<IActionResult> Index() // Thay đổi thành async
        {
            Cart cart = HttpContext.Session.Get<Cart>("cart");

            if (cart != null)
            {
                // Cách 1: Truy vấn từng sản phẩm (không hiệu quả)
                //foreach (var item in cart.Items)
                //{
                //    var sanPham = await _context.SanPhams.FindAsync(item.sanPham.MaSp);
                //    if (sanPham != null)
                //    {
                //        item.sanPham.SoLuongTon = sanPham.SoLuongTon; 
                //    }
                //}

                // Cách 2: Truy vấn 1 lần duy nhất (hiệu quả hơn)
                var maSpList = cart.Items.Select(item => item.sanPham.MaSp).ToList();
                var sanPhams = await _context.SanPhams
                    .Where(sp => maSpList.Contains(sp.MaSp))
                    .ToListAsync();

                foreach (var item in cart.Items)
                {
                    var sanPham = sanPhams.FirstOrDefault(sp => sp.MaSp == item.sanPham.MaSp);

                    if (sanPham != null)
                    {
                        item.sanPham.SoLuongTon = sanPham.SoLuongTon;
                    }
                }

            }

            ViewBag.Cart = cart;
            return View();
        }

        [Route("~/thanh-toan")]
        [HttpGet]
        public IActionResult ThanhToan()
        {
            KhachHang kh = null;
            if (HttpContext.Session.Get<KhachHang>("user") == null)
            {
                return Redirect("/dang-nhap");
            }
            else
            {
                kh = HttpContext.Session.Get<KhachHang>("user");
            }
            Cart cart = null;
            if (HttpContext.Session.Get<Cart>("cart") != null)
            {
                cart = HttpContext.Session.Get<Cart>("cart");
                _phamService.SaveCart(cart, kh);
            }
            else
            {
                return RedirectToAction("Index");
            }
            ViewBag.ListThanhToan = _gioHangService.GetListThanhToan();
            return View(cart);
        }

        [Route("~/thanh-toan")]
        [HttpPost]
        public async Task<IActionResult> ThanhToan(ThanhToan tt)
        {
            Cart cart = HttpContext.Session.Get<Cart>("cart");
            KhachHang kh = HttpContext.Session.Get<KhachHang>("user");
            // Kiểm tra số lượng tồn kho **TRƯỚC KHI** gọi _gioHangService.ThanhToanNow()
            foreach (var item in cart.Items)
            {
                var sanPham = await _context.SanPhams.FindAsync(item.sanPham.MaSp);

                if (sanPham == null || sanPham.SoLuongTon < item.SoLuong)
                {
                    TempData["ErrorMessage"] = "Sản phẩm " + sanPham.TenSp + "không còn đủ hoặc đã hết! Xin lỗi vì sự bất tiện này.";
                    // Redirect về trang giỏ hàng với thông báo lỗi
                    return RedirectToAction("Index");
                }
            }
            using (var transaction = await _context.Database.BeginTransactionAsync())
            {
                try
                {
                    // Nếu đủ hàng, tiếp tục đặt hàng và cập nhật số lượng tồn
                    cart.MaKH = kh.MaKh;
                    var result = await _gioHangService.ThanhToanNow(cart, tt);

                    if (result)
                    {
                        // Chỉ cập nhật số lượng tồn kho sau khi ThanhToanNow thành công
                        foreach (var item in cart.Items)
                        {
                            var sanPham = await _context.SanPhams.FindAsync(item.sanPham.MaSp);
                            sanPham.SoLuongTon -= item.SoLuong;
                            _context.SanPhams.Update(sanPham);
                        }
                        await _context.SaveChangesAsync();
                        await transaction.CommitAsync();
                        HttpContext.Session.Set<Cart>("cart", null);
                        return Redirect("/");
                    }
                    else
                    {
                        // Xử lý khi thanh toán không thành công (ví dụ: do lỗi database)
                        // ...
                        TempData["ErrorMessage"] = "Lỗi trong quá trình thanh toán. Vui lòng thử lại.";
                        return RedirectToAction("Index");
                    }
                }
                catch (Exception ex)
                {
                    await transaction.RollbackAsync();
                    // ... Xử lý lỗi
                    TempData["ErrorMessage"] = "Lỗi trong quá trình thanh toán. Vui lòng thử lại.";
                    return RedirectToAction("Index"); // Hoặc xử lý lỗi khác
                }
            }
        }

        [Route("~/gio-hang/add")]
        [HttpPost]
        public IActionResult AddCart([FromBody]AddCart addCart)
        {
            Cart cart;
            if (HttpContext.Session.Get<Cart>("cart") != null)
            {
                cart = HttpContext.Session.Get<Cart>("cart");

                bool tem = false;
                foreach (CartItem cItem in cart.Items)
                {
                    if (cItem.sanPham.MaSp == addCart.MaSp)
                    {
                        cItem.SoLuong = cItem.SoLuong + addCart.SoLuong;
                        tem = true;
                        break;
                    }
                }
                if (tem)
                {
                    HttpContext.Session.Set<Cart>("cart", cart);
                    return Ok(cart);
                }
            }
            else
            {
                cart = new Cart();
            }

            SanPham sp = _phamService.Get((int)addCart.MaSp);

            CartItem item = new CartItem()
            {
                sanPham = sp,
                SoLuong = addCart.SoLuong
            };

            cart.Items.Add(item);

            HttpContext.Session.Set<Cart>("cart", cart);

            return Ok(cart.Items.Count);
        }

        [Route("~/gio-hang/update")]
        [HttpPost]
        public IActionResult UpdateItem([FromBody] AddCart addCart)
        {
            Cart cart = null;
            if (HttpContext.Session.Get<Cart>("cart") != null)
            {
                cart = HttpContext.Session.Get<Cart>("cart");
                foreach(CartItem item in cart.Items)
                {
                    if(addCart.SoLuong == 0 && item.sanPham.MaSp == addCart.MaSp)
                    {
                        cart.Items.Remove(item);
                        break;
                    }
                    if(item.sanPham.MaSp == addCart.MaSp)
                    {
                        item.SoLuong = addCart.SoLuong;
                    }
                }
                HttpContext.Session.Set<Cart>("cart", cart);
            }
            return Ok(cart);
        }

        [Route("~/gio-hang/delete/{id}")]
        [HttpDelete]
        public IActionResult DeleteItem(int id)
        {
            Cart cart = null;
            if (HttpContext.Session.Get<Cart>("cart") != null)
            {
                cart = HttpContext.Session.Get<Cart>("cart");
                foreach (CartItem item in cart.Items)
                {
                    if(id == item.sanPham.MaSp)
                    {
                        cart.Items.Remove(item);
                        break;
                    }
                }
                HttpContext.Session.Set<Cart>("cart", cart);
            }
            return Ok(cart);
        }


        [Route("~/gio-hang/get-cart-count")]
        public int GetCartCount()
        {
            var cart = HttpContext.Session.Get<Cart>("cart");  // Lấy cart từ session
            return cart?.Items?.Count ?? 0; // Trả về số lượng, hoặc 0 nếu cart hoặc Items là null
        }
    }
}
