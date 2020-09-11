using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class TinhThanh
    {
        [Key]
        public int TinhThanhId { get; set; }

        [Required, MaxLength(100)]
        public string TenTinhThanh { get; set; }

        [Required, MaxLength(100)]
        public string TinhHayThanhPho { get; set; }
        [Required, MaxLength(10)]
        public string MaBuuDien { get; set; }

        [Required]
        [ForeignKey("QuocGia")]
        public int QuocGiaId { get; set; }
        public QuocGia Quocgia { get; set; }
        public List<QuanHuyen> QuanHuyens { get; set; }
        public List<DiaChi> DiaChis { get; set; }
      

    }
}
