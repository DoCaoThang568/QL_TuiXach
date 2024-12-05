using QL_BanHang.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace QL_BanHang.Interfaces
{
    public interface IGioHangService
    {
        List<ThanhToan> GetListThanhToan();

        public Task<bool> ThanhToanNow(Cart cart, ThanhToan tt);
    }
}
