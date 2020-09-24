var filter = filter || {};
filter.delete = function (id) {
    bootbox.confirm({
        title: "Cảnh báo",
        message: "Bạn có muốn xóa danh mục này không?",
        buttons: {
            cancel: {
                label: '<i class="fa fa-times"></i> Không'
            },
            confirm: {
                label: '<i class="fa fa-check"></i> Có'
            }
        },
        callback: function (result) {
            var malop = $("#malop").val();
            if (result) {
                $.ajax({
                    url: `/Home/XoaHocSinh/${id}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data) {
                            window.location = `/Home/DanhSachHocSinh/${malop}`;
                        }
                    }
                });
            }
        }
    });
}