using BaiKiemTraLan3.Models;
using BaiKiemTraLan3.Models.Entitiesss;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BaiKiemTraLan3.Servicesss
{
    public class BanhService : IBanhService
    {
        private readonly AppDbContext context;

        public BanhService(AppDbContext context)
        {
            this.context = context;
        }

        public int KiemTraBanhDaCoChua(Cake banh)
        {
            var daco = context.Banhs.Include(e => e.TheLoai).FirstOrDefault(e => e.TenBanh == banh.TenBanh
              && e.ThanhPhan == banh.ThanhPhan && e.HanSuDung == banh.HanSuDung && e.GiaBan == banh.GiaBan);              

            return (daco != null) ? 1 : -1;
        }

        public List<Category> LayDanhSachCacLoaiBanh()
        {
            return context.TheLoais.ToList(); 
        }

        public List<Cake> LayTenBanhTheoLoai(int matheloai)
        {
            return context.Banhs.Include(e => e.TheLoai).Where(e => e.MaTheLoai == matheloai && e.DaXoa == false).ToList();
        }

        public Cake LayVe1Banh(int mabanh)
        {
            return context.Banhs.Include(e => e.TheLoai).FirstOrDefault(e => e.MaBanh == mabanh);
        }

        public Cake ThayDoiThongTinBanh(Cake banh)
        {
            var hvien = LayVe1Banh(banh.MaBanh);
            
            if (hvien != null)
            {
                hvien.TenBanh = banh.TenBanh;
                hvien.ThanhPhan = banh.ThanhPhan;
                hvien.HanSuDung = banh.HanSuDung;
                hvien.NgaySanXuat = banh.NgaySanXuat;
                hvien.GiaBan = banh.GiaBan;
                hvien.MaTheLoai = banh.MaTheLoai;
                context.SaveChanges();
            }
            return hvien;
        }

        public int ThemMoiBanh(Cake banh)
        {
            var daco = KiemTraBanhDaCoChua(banh);
            if (daco < 0)
            {
                context.Banhs.Add(banh);
                return context.SaveChanges();
            }
            return -1;
        }

        public Cake XoaBanh(int mabanh)
        {
            var hvien = LayVe1Banh(mabanh);
            if (hvien != null)
            {
                hvien.DaXoa = true;
                context.SaveChanges();
            }
            return hvien;
        }
    }
}
