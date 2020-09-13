using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.ViewModel
{
    public class HienThiToKhai
    {
        [MaxLength(100)]
        public string HoTen { get; set; }
        public int STT { get; set; }
        public string GioiTinh { get; set; }
        public string SoDienThoai { get; set; }
        public string CuaKhau { get; set; }
        public string QuocTich { get; set; }
        public string Diachi { get; set; }
    }
}
