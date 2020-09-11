using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class QuanHuyen
    {
        [Key]
        public int QuanHuyenId { get; set; }
        [Required, MaxLength(100)]
        public string TenQuanHuyen { get; set; }
        [Required, MaxLength(100)]
        public string QuanHayHuyen { get; set; }

        [Required]
        [ForeignKey("TinhThanh")]
        public int TinhThanhId { get; set; }
        public TinhThanh TinhThanh { get; set; }
        //[Required]
        //[ForeignKey("QuocGia")]

        //public int QuocGiaId { get; set; }
        //public QuocGia QuocGia { get; set; }
        public List<PhuongXa> PhuongXas { get; set; }
       
    }
}
