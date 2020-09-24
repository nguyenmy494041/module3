using baikiemtra.Models;
using baikiemtra.Models.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace baikiemtra.Serviceesss
{
    public class LophocServices : ILophocServices
    {
        private readonly AppDbContext context;

        public LophocServices(AppDbContext context)
        {
            this.context = context;
        }

       

        public List<LopHoc> LayDanhSachCacLop()
        {
            return context.LopHocs.ToList();
        }

        public List<HocVien> LayDanhSachHocVienTheoLop(int malop)
        {
          return context.HocViens.Include(em => em.Lophoc).Where(em => em.MaLop == malop).ToList();
        }

        public HocVien LayVe1HocVien(int mahocvien)
        {
           return context.HocViens.Include(em => em.Lophoc).FirstOrDefault(emm => emm.MaHocVien == mahocvien);
        }

        public HocVien ThayDoiThongTin(HocVien hocvien)
        {
            var hvien = LayVe1HocVien(hocvien.MaHocVien);
            var daco = KiemTraHocVienDaCoChua(hocvien);
            if (daco<0 && hvien!=null)
            {
                hvien.HoTen = hocvien.HoTen;
                hvien.GioiTinh = hocvien.GioiTinh;
                hvien.Ngaysinh = hocvien.Ngaysinh;
                hvien.Email = hocvien.Email;
                context.SaveChanges();
            }
            return hvien;
        }

        public int ThemMoiHocVien(HocVien hocvien)
        {
            var daco = KiemTraHocVienDaCoChua(hocvien);
            if (daco < 0)
            {
                context.HocViens.Add(hocvien);
               return context.SaveChanges();
            }
            return -1;
        }
        public int KiemTraHocVienDaCoChua(HocVien hocvien)
        {
            var daco = context.HocViens.Include(e => e.Lophoc).FirstOrDefault(e => e.HoTen == hocvien.HoTen &&
                                                                                   e.Email == hocvien.Email && e.MaLop == hocvien.MaLop);
            return (daco != null) ? 1 : -1;
        }

        public HocVien XoaHocSinh(int mahocsinh)
        {
            var hvien = LayVe1HocVien(mahocsinh);
            if (hvien!= null)
            {
                context.HocViens.Remove(hvien);
                context.SaveChanges();
            }
            return hvien;
        }
    }
}
