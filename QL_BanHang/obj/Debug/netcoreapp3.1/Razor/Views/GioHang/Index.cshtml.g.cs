#pragma checksum "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "fe7ee63d0768a2dc378a73fdb8f13f4fb11899807b36a40fe01c2b308525922b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCoreGeneratedDocument.Views_GioHang_Index), @"mvc.1.0.view", @"/Views/GioHang/Index.cshtml")]
namespace AspNetCoreGeneratedDocument
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\_ViewImports.cshtml"
using QL_BanHang

#nullable disable
    ;
#nullable restore
#line 2 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\_ViewImports.cshtml"
using QL_BanHang.Models

#nullable disable
    ;
#nullable restore
#line 3 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Http

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"fe7ee63d0768a2dc378a73fdb8f13f4fb11899807b36a40fe01c2b308525922b", @"/Views/GioHang/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"70429a805340e16be9d0efc642e7da2aa209de33e1b6777b716592f7bef1a2be", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    internal sealed class Views_GioHang_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "GioHang", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ThanhToan", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/imagesapp/not-available.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
  
    var carts = (Cart)ViewBag.Cart;

#line default
#line hidden
#nullable disable

            WriteLiteral("<div class=\"container mt-5\">\r\n");
#nullable restore
#line 5 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
     if (carts != null && carts.Items.Count > 0)
    {

#line default
#line hidden
#nullable disable

            WriteLiteral(@"        <table class=""table"">
            <thead>
                <tr>
                    <th scope=""col"">Mã SP</th>
                    <th scope=""col"">Tên Sản phẩm</th>
                    <th scope=""col"">Số Lượng</th>
                    <th scope=""col"">Đơn Giá</th>
                    <th scope=""col"">Thành Tiền</th>
                    <th scope=""col""></th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 19 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                 foreach (var item in carts.Items)
                {
                    var tt = item.sanPham.DonGia * item.SoLuong;

#line default
#line hidden
#nullable disable

            WriteLiteral("                    <tr");
            BeginWriteAttribute("id", " id=\"", 731, "\"", 754, 1);
            WriteAttributeValue("", 736, 
#nullable restore
#line 22 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                             item.sanPham.MaSp

#line default
#line hidden
#nullable disable
            , 736, 18, false);
            EndWriteAttribute();
            WriteLiteral(">\r\n                        <td>");
            Write(
#nullable restore
#line 23 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                             item.sanPham.MaSp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>");
            Write(
#nullable restore
#line 24 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                             item.sanPham.TenSp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>\r\n\r\n                            <div class=\"d-flex\">\r\n                                <button class=\"btn-reduce btn btn-sm btn-primary\" data-price=\"");
            Write(
#nullable restore
#line 28 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                                                                               String.Format("{0:#,###}",item.sanPham.DonGia)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\" data-id=\"");
            Write(
#nullable restore
#line 28 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                                                                                                                                         item.sanPham.MaSp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\">\r\n                                    <i class=\"bi bi-dash-lg\"></i>\r\n                                </button>\r\n                                <span class=\"number\">");
            Write(
#nullable restore
#line 31 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                                      item.SoLuong

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</span>\r\n                                \r\n                                <button class=\"btn-plus btn-sm btn btn-primary\" data-price=\"");
            Write(
#nullable restore
#line 33 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                                                                             item.sanPham.DonGia

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\" data-id=\"");
            Write(
#nullable restore
#line 33 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                                                                                                            item.sanPham.MaSp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\">\r\n                                    <i class=\"bi bi-plus-lg\"></i>\r\n                                </button>\r\n                            </div>\r\n\r\n                        </td>\r\n                        <td>");
            Write(
#nullable restore
#line 39 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                             String.Format("{0:#,###}", @item.sanPham.DonGia)

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td");
            BeginWriteAttribute("id", " id=\"", 1775, "\"", 1801, 2);
            WriteAttributeValue("", 1780, "td_", 1780, 3, true);
            WriteAttributeValue("", 1783, 
#nullable restore
#line 40 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                    item.sanPham.MaSp

#line default
#line hidden
#nullable disable
            , 1783, 18, false);
            EndWriteAttribute();
            WriteLiteral(">");
            Write(
#nullable restore
#line 40 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                                        tt

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("</td>\r\n                        <td>\r\n                            <button class=\"btn btn-danger btn-delete\" data-id=\"");
            Write(
#nullable restore
#line 42 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                                                                                item.sanPham.MaSp

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("\">\r\n                                Delete\r\n                            </button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 47 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
                }

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n            </tbody>\r\n        </table>\r\n");
            Write(
#nullable restore
#line 52 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
         ViewBag.Error

#line default
#line hidden
#nullable disable
            );
            WriteLiteral("        <div>\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "fe7ee63d0768a2dc378a73fdb8f13f4fb11899807b36a40fe01c2b308525922b12154", async() => {
                WriteLiteral("\r\n                Đặt hàng\r\n            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n");
#nullable restore
#line 58 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable

            WriteLiteral("        <div class=\"empty-data\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe7ee63d0768a2dc378a73fdb8f13f4fb11899807b36a40fe01c2b308525922b13950", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <span><i>Không có sản phẩm trong giỏ hàng</i></span>\r\n        </div>\r\n");
#nullable restore
#line 65 "C:\Users\thang\Desktop\DoAnMonHoc\QL_BanHang\QL_BanHang\Views\GioHang\Index.cshtml"
    }

#line default
#line hidden
#nullable disable

            WriteLiteral(@"</div>

<div class=""position-fixed top-0 right-0 p-3"" style=""z-index: 5; right: 0; top: 0;"">
    <div id=""liveToast"" class=""toast hide"" role=""alert"" aria-live=""assertive"" aria-atomic=""true"" data-delay=""2000"">
        <div class=""toast-header"">
            <div class=""toast-body"" id=""title-toast"">
                Hello, world! This is a toast message.
            </div>
        </div>
    </div>
</div>
");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $("".btn-reduce"").click(function () {
            let val = parseInt($(this).next().text())
            if (val > 0) {
                val--;
            }
            var el = $(this)
            var id = el.attr(""data-id"");
            let data = {
                MaSp: id,
                SoLuong: val
            }

            $.ajax({
                method: ""POST"",
                url: `/gio-hang/update`,
                data: JSON.stringify(data),
                contentType: 'application/json',
                success: function (data) {
                    el.next().text(val)
            
                    var price = parseInt(el.attr(""data-price""))
                    $(`#td_${id}`).text(new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(price * val))
                },
            })
        })

        $("".btn-plus"").click(function () {
            let val = parseInt($(this).prev().text())
            val++;
          ");
                WriteLiteral(@"  var el = $(this)
            var id = el.attr(""data-id"");
            let data = {
                MaSp: id,
                SoLuong: val
            }


            $.ajax({
                method: ""POST"",
                url: `/gio-hang/update`,
                data: JSON.stringify(data),
                contentType: 'application/json',
                success: function (data) {
                    el.prev().text(val)

                    var price = parseInt(el.attr(""data-price""))
                    $(`#td_${id}`).text(new Intl.NumberFormat('vi-VN', { style: 'currency', currency: 'VND' }).format(price * val))
                },
            })
        })

        $("".btn-delete"").click(function () {
            var id = $(this).attr(""data-id"");
            $.ajax({
                method: ""DELETE"",
                url: `/gio-hang/delete/${id}`,
                success: function (data) {
                    $(`tr#${id}`).remove();
                    $(""#title-toast"").text(""Xo");
                WriteLiteral("á thành công!\")\r\n                    $(\'#liveToast\').toast(\"show\")\r\n                },\r\n            })\r\n        })\r\n\r\n    </script>\r\n");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
