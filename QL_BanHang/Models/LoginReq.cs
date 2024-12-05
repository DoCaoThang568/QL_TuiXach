using System.ComponentModel.DataAnnotations;

namespace QL_BanHang.Models
{
    public class LoginReq
    {
        [Required]
        public string username { get; set; }

        [Required]
        public string password { get; set; }
    }
}
