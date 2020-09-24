using baikiemtra.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baikiemtra.Serviceesss
{
    public interface ILophocServices
    {
        List<LopHoc> LayDanhSachCacLop();
        List<HocVien> LayDanhSachHocVienTheoLop(int malop);
        HocVien LayVe1HocVien(int mahocvien);
        int ThemMoiHocVien(HocVien hocvien);
        HocVien ThayDoiThongTin(HocVien hocvien);
        int KiemTraHocVienDaCoChua(HocVien hocvien);
        HocVien XoaHocSinh(int mahocsinh);
    }
}
