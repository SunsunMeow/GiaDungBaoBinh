using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_SanPhamCmt")]
    public class SanPhamCMT : Auditable
    {
        [Key]
        [MaxLength(50)]
        public int ID { get; set; }
        public string Email { get; set; }
        public string ChiTiet { get; set; }


        public int MaSP { get; set; }
        public int MaKH { get; set; }

    }
}
