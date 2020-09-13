using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToKhaiYte.Models.Entities;
using ToKhaiYte.Models.ViewModel;

namespace ToKhaiYte.Services
{
    public interface IToKhaiServices
    {
        List<CuaKhau> LayDanhSachCuaKhau();
        List<QuocGia> LayDanhSachQuocGia();
        List<TinhThanh> LayDanhsachTinhThanhVietNam();
        List<QuanHuyen> LayDanhSachQuanHuyen(int idTinh);
        List<PhuongXa> LayDanhSachPhuongXa(int idQuanHuyen, int idTinh);
        int TaoMoiToKhai(DangKyToKhai tokhai);
        IEnumerable<HienThiToKhai> LaydanhSachToKhai();
        IEnumerable<ChitietToKhai> LayChiTietToKhai();

    }
}
