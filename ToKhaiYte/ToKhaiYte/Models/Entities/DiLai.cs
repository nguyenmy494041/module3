using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class DiLai
    {
        [Key]
        public int DiLaiId { get; set; }

        [Required, MaxLength(110)]
        public string PhuongTienDiLai { get; set; }
        [Required, MaxLength(30)]
        public string SoHieuPhuongTien { get; set; }
        [Required, MaxLength(20)]
        public string SoGhe { get; set; }
        [Required]
        public DateTime NgayKhoiHanh { get; set; }
        [Required]
        public DateTime NgayNhapCanh { get; set; }
        [Required]
        public int QuocGiaKhoiHanh { get; set; }
        [Required, MaxLength(50)]
        public string TinhKhoiHanh { get; set; }
        [Required]
        public int QuocGiaDen { get; set; }
        [Required]
        public int TinhDen { get; set; }
        [Required, MaxLength(200)]
        public string NoiTungDen { get; set; }
        [Required]
        [ForeignKey("ToKhai")]
        public int ToKhaiId { get; set; }
        public ToKhai ToKhai { get; set; }
    }
}
