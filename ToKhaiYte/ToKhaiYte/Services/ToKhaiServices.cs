using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ToKhaiYte.Models;
using ToKhaiYte.Models.Entities;
using ToKhaiYte.Models.ViewModel;

namespace ToKhaiYte.Services
{
    public class ToKhaiServices : IToKhaiServices
    {
        private readonly AppDbContext context;

        public ToKhaiServices(AppDbContext context)
        {
            this.context = context;
        }
        public List<CuaKhau> LayDanhSachCuaKhau()
        {
            return context.CuaKhau.ToList();
        }

        public List<PhuongXa> LayDanhSachPhuongXa(int idQuanHuyen=0, int idTinh=0)
        {
            if (idQuanHuyen!=0 && idTinh!=0)
            {
                return context.PhuongXa.Where(e => e.TinhThanhId == idTinh && e.QuanHuyenId == idQuanHuyen).ToList();
            }
            else if (idQuanHuyen != 0)
            {
                return context.PhuongXa.Where(e => e.QuanHuyenId == idQuanHuyen).ToList();
            }
            else if (idTinh != 0)
            {
                return context.PhuongXa.Where(e => e.TinhThanhId == idTinh).ToList();
            }
            else
            {
                return context.PhuongXa.ToList();
            }
        }

        public List<QuanHuyen> LayDanhSachQuanHuyen(int idTinh)
        {
            var result = context.QuanHuyen.Where(e => e.TinhThanhId == idTinh).ToList();
            return result;
        }

        public List<QuocGia> LayDanhSachQuocGia()
        {
            return context.QuocGia.ToList();
        }

        public List<TinhThanh> LayDanhsachTinhThanhVietNam()
        {
            return context.TinhThanh.ToList();
        }

        public ICollection<DangKyToKhai> LaydanhSachToKhai()
        {
            var result = new List<DangKyToKhai>();
            
            return result;
        }

        public int TaoMoiToKhai(DangKyToKhai dangkytokhai)
        {
            var tokhai = new ToKhai()
            {
                Hoten = dangkytokhai.Hoten,
                Namsinh = dangkytokhai.Namsinh,
                Gioitinh = dangkytokhai.Gioitinh,
                Quoctich = dangkytokhai.Quoctich,
                SoCMND = dangkytokhai.SoCMND,
                CuaKhauId = dangkytokhai.CuaKhauId
            };
            context.ToKhai.Add(tokhai);
            context.SaveChanges();
            var dangkytokhaiId = context.ToKhai.FirstOrDefault(e => e.Hoten == dangkytokhai.Hoten &&
                                                                    e.Namsinh == dangkytokhai.Namsinh &&
                                                                    e.Gioitinh == dangkytokhai.Gioitinh &&
                                                                    e.Quoctich == dangkytokhai.Quoctich &&
                                                                    e.SoCMND == dangkytokhai.SoCMND &&
                                                                    e.CuaKhauId == dangkytokhai.CuaKhauId).ToKhaiId;

            var diachi = new DiaChi()
            {
                TinhThanhId = dangkytokhai.TinhThanhId,
                QuanHuyenId = dangkytokhai.QuanHuyenId,
                PhuongXaId = dangkytokhai.PhuongXaId,
                SoNha = dangkytokhai.SoNha,
                SoDienThoai = dangkytokhai.SoDienThoai,
                Email = dangkytokhai.Email,
                ToKhaiId = dangkytokhaiId
            };
            context.DiaChi.Add(diachi);
            context.SaveChanges();
            //var khoihanh = dangkytokhai.NgayDen + "-"
            var dilai = new DiLai()
            {
                PhuongTienDiLai = dangkytokhai.PhuongTienDiLai,
                SoHieuPhuongTien = dangkytokhai.SoHieuPhuongTien,
                SoGhe = dangkytokhai.SoGhe,
                NgayKhoiHanh = Convert.ToDateTime(dangkytokhai.NamDi + "-" + dangkytokhai.ThangDi + "-" + dangkytokhai.NgayDi),
                NgayNhapCanh = Convert.ToDateTime(dangkytokhai.NamDen + "-" + dangkytokhai.ThangDen + "-" + dangkytokhai.NgayDen),
                QuocGiaKhoiHanh = dangkytokhai.QuocGiaKhoiHanh,
                TinhKhoiHanh = dangkytokhai.TinhKhoiHanh,
                QuocGiaDen = dangkytokhai.QuocGiaDen,
                TinhDen = dangkytokhai.TinhDen,
                NoiTungDen = dangkytokhai.NoiTungDen,
                ToKhaiId = dangkytokhaiId
            };
            context.DiLai.Add(dilai);
            context.SaveChanges();

            var suckhoe = new SucKhoe()
            {
                Ho=dangkytokhai.Ho,
                Sot=dangkytokhai.Sot,
                KhoTho=dangkytokhai.KhoTho,
                DauHong=dangkytokhai.DauHong,
                BuonNon=dangkytokhai.BuonNon,
                TieuChay=dangkytokhai.TieuChay,
                XuatHuyetNgoaiDa=dangkytokhai.XuatHuyetNgoaiDa,
                NoiBanNgoaiDa=dangkytokhai.NoiBanNgoaiDa,
                DanhSachVacxin=dangkytokhai.DanhSachVacxin,
                TiepXucDongVat=dangkytokhai.TiepXucDongVat,
                TiepXucNguoiBenh=dangkytokhai.TiepXucNguoiBenh,
                ToKhaiId = dangkytokhaiId

            };
            context.SucKhoe.Add(suckhoe);
            context.SaveChanges();

            return dangkytokhaiId;

        }
    }
}
