using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class PhuongXa
    {
        public int PhuongXaId { get; set; }
        [Required, MaxLength(100)]
        public string TenPhuongXa { get; set; }
        [Required, MaxLength(30)]
        public string PhuongHayXa { get; set; }
        public string TenDayDu => $"{PhuongHayXa} {TenPhuongXa}";
        //[Required]
        //[ForeignKey("QuocGia")]
        //public int QuocGiaId { get; set; }
        //public QuocGia QuocGia { get; set; }

        [Required]
        //[ForeignKey("TinhThanh")]
        public int TinhThanhId { get; set; }
        //public TinhThanh TinhThanh { get; set; }

        [Required]
        [ForeignKey("QuanHuyen")]
        public int QuanHuyenId { get; set; }
        public QuanHuyen QuanHuyen { get; set; }
       
    }
}
