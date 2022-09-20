using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_NhaSanXuat")]
    public class NhaSanXuat
    {
        [Key]
        [MaxLength(50)]
        public int MaNSX { get; set; }
        [Required]
        public string TenNSX { get; set; }
    }
}
