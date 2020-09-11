using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ToKhaiYte.Models.Entities
{
    public class SucKhoe
    {
        [Key]
        public int SucKhoeId { get; set; }
        [Required]
        public bool Ho { get; set; }
        [Required]
        public bool Sot { get; set; }
        [Required]
        public bool KhoTho { get; set; }
        [Required]
        public bool DauHong { get; set; }
        [Required]
        public bool BuonNon { get; set; }
        [Required]
        public bool TieuChay { get; set; }
        [Required]
        public bool XuatHuyetNgoaiDa { get; set; }
        [Required]
        public bool NoiBanNgoaiDa { get; set; }
        [Required,MaxLength(200)]
        public string DanhSachVacxin { get; set; }
        [Required]
        public bool TiepXucDongVat { get; set; }
        [Required]
        public bool TiepXucNguoiBenh { get; set; }


        [Required]
        [ForeignKey("ToKhai")]
        public int ToKhaiId { get; set; }

        public ToKhai ToKhai { get; set; }

    }
}
