using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_ChiTietHoaDon")]
    public class ChiTietHoaDon : Auditable
    {
        [Key]
        [MaxLength(50)]
        public int MaHD { get; set; }
        public int SoLuong { get; set; }
        public decimal GiamGia { get; set; }
        public int MaSP { get; set; }
    }
}
