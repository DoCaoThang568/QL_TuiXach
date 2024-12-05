using Microsoft.AspNetCore.Http;
using QL_BanHang.Models;
using System.ComponentModel.DataAnnotations.Schema;

using System.ComponentModel;

namespace QL_BanHang.Areas.Admin.Models
{
    public class SanPhamRequest: SanPham
    {
        [NotMapped]
        [DisplayName("Upload File")]
        public IFormFile ImageFile { get; set; }
    }
}
