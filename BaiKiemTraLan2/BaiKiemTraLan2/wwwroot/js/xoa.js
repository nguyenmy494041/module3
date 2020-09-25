var filter = filter || {};
filter.delete = function (id) {
    bootbox.confirm({
        title: "Cảnh báo",
        message: "Bạn có muốn xóa đầu sách này không?",
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
                    url: `/Home/XoaSach/${masach}`,
                    method: "GET",
                    contentType: 'json',
                    success: function (data) {
                        if (data) {
                            window.location = `/Home/XemChiTiet/${malop}`;
                        }
                    }
                });
            }
        }
    });
}