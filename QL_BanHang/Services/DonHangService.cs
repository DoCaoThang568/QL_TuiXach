using QL_BanHang.Interfaces;
using QL_BanHang.Models;
using System.Collections.Generic;
using System.Linq;

namespace QL_BanHang.Services
{
    public class DonHangService : IDonHangService
    {
        private readonly QL_BanHangTuiXachContext _context;
        public DonHangService(QL_BanHangTuiXachContext context)
        {
            _context = context;
        }
        public List<DonHang> GetAll()
        {
            return _context.DonHangs.ToList();
        }

    }
}
