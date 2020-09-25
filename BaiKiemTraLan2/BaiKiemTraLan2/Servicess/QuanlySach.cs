using BaiKiemTraLan2.Models;
using BaiKiemTraLan2.Models.Entitiess;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan2.Servicess
{
    public class QuanlySach : IQuanlySach
    {

        private readonly AppDbContext context;

        public QuanlySach(AppDbContext context)
        {
            this.context = context;
        }
        public int KiemTraSachDaCoChua(Book sach)
        {
            var daco = context.Sachs.Include(e => e.TheLoai).FirstOrDefault(e => e.TenSach == sach.TenSach &&
                                                                               e.MoTa == sach.MoTa && e.NamXuatBan == sach.NamXuatBan);

            return (daco != null) ? 1 : -1;
        }



        public List<Category> LayDanhSachCacTheLoai()
        {
            return context.TheLoais.ToList();
        }




        public List<Book> LayTenSachTheoLop(int matheloai)
        {
            return context.Sachs.Include(e => e.TheLoai).Where(e => e.MaTheLoai == matheloai).ToList();
        }




        public Book LayVe1Sach(int masach)
        {
            return context.Sachs.Include(e => e.TheLoai).FirstOrDefault(e => e.MaSach == masach);
        }




        public Book ThayDoiThongTin(Book sach)
        {
            var hvien = LayVe1Sach(sach.MaSach);
            var daco = KiemTraSachDaCoChua(sach);
            if (daco < 0 && hvien != null)
            {
                hvien.TenSach = sach.TenSach;
                hvien.TenTacGia = sach.TenTacGia;
                hvien.MoTa = sach.MoTa;
                hvien.NamXuatBan = sach.NamXuatBan;
                hvien.Soluong = sach.Soluong;
                context.SaveChanges();
            }
            return hvien;
        }




        public int ThemMoiSach(Book sach)
        {
            var daco = KiemTraSachDaCoChua(sach);
            if (daco < 0)
            {
                context.Sachs.Add(sach);
                return context.SaveChanges();
            }
            return -1;
        }




        public Book XoaSach(int masach)
        {
            var hvien = LayVe1Sach(masach);
            if (hvien != null)
            {
                context.Sachs.Remove(hvien);
                context.SaveChanges();
            }
            return hvien;
        }
    }
}
