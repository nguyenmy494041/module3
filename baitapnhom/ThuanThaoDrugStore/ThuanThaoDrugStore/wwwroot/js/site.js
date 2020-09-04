
const idTinhmacdinh = 15;
const idHuyenmacdinh = 201;
const idXamacdinh = 2844;
var baseService = "https://localhost:44347/User";
var TinhThanhUrl = baseService + "/LayraTinhThanh";
var QuanHuyenUrl = baseService + "/LayraQuanHuyen";
var PhuongXaUrl = baseService + "/LayraPhuongXa";


$(document).ready(function () {
    LayTinhThanh();
    LayQuanHuyen();
    LayPhuongXa();
    $("#IdTinhThanh").on('change', function () {
        var id = $(this).val();
        if (id != undefined && id != '') {
            LayQuanHuyen(id);
        };
    });


    $("#IdQuanHuyen").on('change', function () {
        var id = $(this).val();
        if (id != undefined && id != '') {
            LayPhuongXa(id);

        }
    });

});






function LayTinhThanh() {
    $.get(TinhThanhUrl, function (data) {

        if (data != null && data != undefined && data.length) {
            var html = '';
            $.each(data, function (key, item) {
                console.log(item);
                if (item.id_TinhThanh == idTinhmacdinh) {
                    html += '<option value="' + item.id_TinhThanh + '" selected>' + item.tenTinhThanh + '</option>';
                }
                else {
                    html += '<option value="' + item.id_TinhThanh + '">' + item.tenTinhThanh + '</option>';
                }
            });
            $("#IdTinhThanh").html(html);
                    }
    });
}

function LayQuanHuyen(id = idTinhmacdinh) {
    $.get(QuanHuyenUrl + "/" + id, function (data) {
        if (data != null && data != undefined && data.length) {
            var html = '';
            $.each(data, function (key, item) {
                console.log(item);
                if (item.id_QuanHuyen == idHuyenmacdinh) {
                    html += '<option value="' + item.id_QuanHuyen + '"selected>' + item.tenQuanHuyen + '</option>';
                }
                else {
                    html += '<option value="' + item.id_QuanHuyen + '">' + item.tenQuanHuyen + '</option>';
                }
            });
            $("#IdQuanHuyen").html(html);
        }
    });
}

function LayPhuongXa(id = idHuyenmacdinh) {
    console.log(id);
    $.get(PhuongXaUrl + "/" + id, function (data) {
        if (data != null && data != undefined && data.length) {
            var html = '';
            $.each(data, function (key, item) {
                console.log(item);
                if (item.id_PhuongXa == idXamacdinh) {
                    html += '<option value="' + item.id_PhuongXa + '"selected>' + item.tenPhuongXa + '</option>';
                } else {
                    html += '<option value=' + item.id_PhuongXa + '>' + item.tenPhuongXa + '</option>';
                }
            });
            $("#IdPhuongXa").html(html);
        }
    });
}