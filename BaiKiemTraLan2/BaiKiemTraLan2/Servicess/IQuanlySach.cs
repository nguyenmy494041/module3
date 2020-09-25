using BaiKiemTraLan2.Models.Entitiess;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan2.Servicess
{
    public interface IQuanlySach
    {
        List<Category> LayDanhSachCacTheLoai();
        List<Book> LayTenSachTheoLop(int matheloai);
        Book LayVe1Sach(int masach);
        int ThemMoiSach(Book sach);
        Book ThayDoiThongTin(Book sach);
        int KiemTraSachDaCoChua(Book sach);
        Book XoaSach(int masach);
    }
}
