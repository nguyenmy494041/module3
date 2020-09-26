using BaiKiemTraLan3.Models.Entitiesss;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan3.Servicesss
{
    public interface IBanhService
    {
        List<Category> LayDanhSachCacLoaiBanh();
        List<Cake> LayTenBanhTheoLoai(int matheloai);
        Cake LayVe1Banh(int mabanh);
        int ThemMoiBanh(Cake banh);
        Cake ThayDoiThongTinBanh(Cake banh);
        int KiemTraBanhDaCoChua(Cake banh);
        Cake XoaBanh(int mabanh);

    }
}
