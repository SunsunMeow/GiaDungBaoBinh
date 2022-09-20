using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_DanhSachHoaDon")]
    public class DanhSachHoaDon : Auditable
    {
        [Key]
        [MaxLength(50)]
        public int MaHD { get; set; }
        public DateTime NgayGiaoHang { get; set; }
        public string DiaChiGiaoHang { get; set; }
        public bool TrangThaiGiaoHang { get; set; }
        [Required]
        public decimal TongTien  { get; set; }

        public int MaKH { get; set; }

    }
}
