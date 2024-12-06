// Please see documentation at https://docs.microsoft.com/aspnet/core/client-side/bundling-and-minification
// for details on configuring this project to bundle and minify static web assets.

// Write your JavaScript code.
function updateCartCount(count) {
    $("#cart-count").text("(" + count + ")");
}

// Đoạn code này sẽ được gọi sau mỗi lần thêm/xóa/cập nhật sản phẩm trong giỏ hàng
$(document).ready(function () {
    // Gọi AJAX để lấy số lượng sản phẩm trong giỏ hàng
    $.ajax({
        url: '/gio-hang/get-cart-count',
        method: 'GET',
        success: function (count) {
            updateCartCount(count);
        },
        error: function (error) {
            console.error("Lỗi khi lấy số lượng giỏ hàng:", error);
        }
    });

    // hoặc
    $.ajax({
        url: '/gio-hang/get-cart-count', // Tạo một action mới để trả về số lượng
        method: 'GET',
        success: function (count) {
            updateCartCount(count);
        }

    })

});