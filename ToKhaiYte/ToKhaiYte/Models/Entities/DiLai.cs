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

        [Required, MaxLength(300)]
        public string PhuongTienDiLai { get; set; }
        [Required, MaxLength(100)]
        public string SoHieuPhuongTien { get; set; }
        [Required, MaxLength(50)]
        public string SoGhe { get; set; }
        [Required]
        public DateTime NgayKhoiHanh { get; set; }
        [Required]
        public DateTime NgayNhapCanh { get; set; }
        [Required]
        public int QuocGiaKhoiHanh { get; set; }
        [Required, MaxLength(100)]
        public string TinhKhoiHanh { get; set; }
        [Required]
        public int QuocGiaDen { get; set; }
        [Required]
        public int TinhDen { get; set; }
        [Required, MaxLength(500)]
        public string NoiTungDen { get; set; }
        [Required]
        [ForeignKey("ToKhai")]
        public int ToKhaiId { get; set; }
        public ToKhai ToKhai { get; set; }
    }
}
