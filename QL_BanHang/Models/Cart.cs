using System.Collections.Generic;

namespace QL_BanHang.Models
{
    public class Cart
    {
        public Cart()
        {
            Items = new List<CartItem>();
        }
        public int MaKH { get; set; }
        public List<CartItem> Items { get; set; }
    }
}
