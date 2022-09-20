using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_NhapHang")]
    public class NhapHang : Auditable
    {
        [Key]
        [MaxLength(50)]
        public int MaNH { get; set; }
        public decimal GiaNhap{ get; set; }
        public decimal TongTien { get; set; }
        public int SoLuong { get; set; }


        public int MaNCC { get; set; }
        public int MaSP { get; set; }

    }
}
