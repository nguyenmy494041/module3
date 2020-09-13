using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
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

        public IEnumerable<HienThiToKhai> LaydanhSachToKhai()
        {
            IEnumerable<HienThiToKhai> result = new List<HienThiToKhai>();
            result = (from tk in context.ToKhai
                      join sk in context.SucKhoe on tk.ToKhaiId equals sk.ToKhaiId
                      join dl in context.DiLai on tk.ToKhaiId equals dl.ToKhaiId
                      join dc in context.DiaChi on tk.ToKhaiId equals dc.ToKhaiId
                      join ck in context.CuaKhau on tk.CuaKhauId equals ck.CuaKhauId
                      join qg in context.QuocGia on tk.Quoctich equals qg.QuocGiaId
                      join tt in context.TinhThanh on dc.TinhThanhId equals tt.TinhThanhId
                      join qh in context.QuanHuyen on dc.QuanHuyenId equals qh.QuanHuyenId
                      join px in context.PhuongXa on dc.PhuongXaId equals px.PhuongXaId
                      select (new HienThiToKhai()
                      {
                          HoTen = tk.Hoten,
                          STT = tk.ToKhaiId,
                          CuaKhau = ck.TenCuaKhau,
                          SoDienThoai = dc.SoDienThoai,
                          GioiTinh = tk.Gioitinh,
                          QuocTich = qg.TenQuocGia,
                          Diachi = $"{dc.SoNha}, {px.PhuongHayXa} {px.TenPhuongXa}, {qh.QuanHayHuyen} {qh.TenQuanHuyen}, {tt.TenDayDu}",

                      }));
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
            var ketqua = "";
            if (dangkytokhai.taubay !="false")
            {
                ketqua += dangkytokhai.taubay+", ";
            }
            if (dangkytokhai.tauthuyen != "false")
            {
                ketqua += dangkytokhai.tauthuyen+", ";
            }
            if (dangkytokhai.oto != "false")
            {
                ketqua += dangkytokhai.oto+", ";
            }
            if (dangkytokhai.khac != "false")
            {
                ketqua += dangkytokhai.phuongtienkhac;
            }

            var dilai = new DiLai()
            {
                PhuongTienDiLai = ketqua,
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
        public IEnumerable<ChitietToKhai> LayChiTietToKhai()
        {

            IEnumerable<ChitietToKhai> result = new List<ChitietToKhai>();
            result = (from tk in context.ToKhai
                      join sk in context.SucKhoe on tk.ToKhaiId equals sk.ToKhaiId
                      join dl in context.DiLai on tk.ToKhaiId equals dl.ToKhaiId
                      join dc in context.DiaChi on tk.ToKhaiId equals dc.ToKhaiId
                      join ck in context.CuaKhau on tk.CuaKhauId equals ck.CuaKhauId
                      join qg in context.QuocGia on tk.Quoctich equals qg.QuocGiaId
                      join tt in context.TinhThanh on dc.TinhThanhId equals tt.TinhThanhId
                      join qh in context.QuanHuyen on dc.QuanHuyenId equals qh.QuanHuyenId
                      join px in context.PhuongXa on dc.PhuongXaId equals px.PhuongXaId
                      select (new ChitietToKhai()
                      {
                          STT=tk.ToKhaiId,
                          Hoten = tk.Hoten,
                          TenCuaKhau = ck.TenCuaKhau,
                          Namsinh= tk.Namsinh,
                          Gioitinh =tk.Gioitinh,
                          Quoctich=qg.TenQuocGia,
                          SoCMND = tk.SoCMND,
                          PhuongTienDiLai=dl.PhuongTienDiLai,
                          SoHieuPhuongTien=dl.SoHieuPhuongTien,
                          SoGhe=dl.SoGhe,
                          NgayKhoiHanh = dl.NgayKhoiHanh,
                          NgayNhapCanh =dl.NgayNhapCanh,
                          QuocGiaKhoiHanh =dl.QuocGiaKhoiHanh,
                          TinhKhoiHanh=dl.TinhKhoiHanh,
                          QuocGiaDen = dl.QuocGiaDen,
                          TinhDen =tt.TenDayDu,
                          NoiTungDen=dl.NoiTungDen,
                          TinhThanh=tt.TenDayDu,
                          QuanHuyen=qh.TenDayDu,
                          PhuongXa=px.TenDayDu,
                          SoNha=dc.SoNha,
                          SoDienThoai=dc.SoDienThoai,
                          Email=dc.Email,
                          Sot=sk.Sot,
                          Ho=sk.Ho,
                          KhoTho=sk.KhoTho,
                          DauHong=sk.DauHong,
                          BuonNon=sk.BuonNon,
                          TieuChay=sk.TieuChay,
                          XuatHuyetNgoaiDa=sk.XuatHuyetNgoaiDa,
                          NoiBanNgoaiDa=sk.NoiBanNgoaiDa,
                          DanhSachVacxin=sk.DanhSachVacxin,
                          TiepXucDongVat=sk.TiepXucDongVat,
                          TiepXucNguoiBenh=sk.TiepXucNguoiBenh,                        

                      }));
            return result;
        }
    }
}
