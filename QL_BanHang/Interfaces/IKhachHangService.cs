using QL_BanHang.Models;
using System.Collections.Generic;

namespace QL_BanHang.Interfaces
{
    public interface IKhachHangService
    {
        //public List<KhachHang> 
        public KhachHang Login(LoginReq login);
        public List<KhachHang> GetKH();
        public bool SignIn(KhachHang kh);
        public bool UpdateKhachHang(int id, KhachHang khachHang);
        public KhachHang GetKHById(int id);

    }
}
