using Microsoft.AspNetCore.Mvc.Rendering;
using System;

namespace QL_BanHang.Helpers
{
    public static class HTMLHelpers
    {
        public static string FormatPrice(this IHtmlHelper htmlHelper, double? price)
        {
            return String.Format("{0:#,###}", price);
        }
    }
}
