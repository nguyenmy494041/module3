// File javascript để lấy dữ liệu

// Khai báo URL service của bạn ở đây
var baseService = "https://localhost:44347/User";
var TinhThanhUrl = baseService + "/LayraTinhThanh";

var QuanHuyenUrl = baseService + "/LayraQuanHuyen";
var PhuongXaUrl = baseService + "/LayraPhuongXa";
$(document).ready(function () {
    // load danh sách country
    LayTinhThanh();

    $("#IdTinhThanh").on('change', function () {
        var id = $(this).val();
        if (id != undefined && id != '') {
            LayQuanHuyen(id);
        }
    });

   
    $("#IdQuanHuyen").on('change', function () {
        var id = $(this).val();
        if (id != undefined && id != '') {
            LayPhuongXa(id);
        }
    });
    //$("#IdPhuongXa").on('change', function () {
      
    //    var provinceText = $("#ddlProvince option:selected").text();
    //    var districtText = $("#ddlDistrict option:selected").text();
    //    var wardText = $("#ddlWard option:selected").text();
    //    var html =" Tỉnh thành: " + provinceText + " " + "Quận huyện: " + districtText + " " + "Xã phường: " + wardText;
    //    html += "</br>Quê bạn thật là đẹp. Chúc mừng bạn!!!";
    //    $("#divResult").html(html);
    //});
});






function LayTinhThanh() {
    $.get(TinhThanhUrl, function (data) {
        
        if (data != null && data != undefined && data.length) {
            var html = '';
            html += '<option value="">--Chưa được chọn--</option>';
            $.each(data, function (key, item) {
                console.log(item);
                html += '<option value=' + item.id_TinhThanh + '>' + item.tenTinhThanh + '</option>';
            });
            $("#IdTinhThanh").html(html);
        }
    });
}
// truyền id của country vào

// truyền id của province vào
function LayQuanHuyen(id) {
    $.get(QuanHuyenUrl + "/" + id, function (data) {
        if (data != null && data != undefined && data.length) {
            var html = '';
            html += '<option value="">--Chưa được chọn--</option>';
            $.each(data, function (key, item) {
                console.log(item);
                html += '<option value=' + item.id_QuanHuyen + '>' + item.tenQuanHuyen + '</option>';
            });
            $("#IdQuanHuyen").html(html);
        }
    });
}
// truyền id của district vào
function LayPhuongXa(id) {
    console.log(id);
    $.get(PhuongXaUrl + "/" + id, function (data) {
        if (data != null && data != undefined && data.length) {
            var html = '';
            html += '<option value="">--Chưa được chọn--</option>';
            $.each(data, function (key, item) {
                console.log(item);
                html += '<option value=' + item.id_PhuongXa + '>' + item.tenPhuongXa + '</option>';
            });
            $("#IdPhuongXa").html(html);
        }
    });
}