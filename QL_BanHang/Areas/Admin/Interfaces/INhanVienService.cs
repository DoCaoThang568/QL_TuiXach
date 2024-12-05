using QL_BanHang.Models;
using System.Collections.Generic;

namespace QL_BanHang.Interfaces
{
    public interface INhanVienService 
    {
        public NhanVien Login(LoginReq login);
        public List<NhanVien> GetNV();
        public NhanVien GetNVById(int id);
        public bool UpdateNhanVien(int id, NhanVien nhanVien);
        public bool DeleteNV(int id);
        void CreateNV(NhanVien nhanVien);
    }
}
