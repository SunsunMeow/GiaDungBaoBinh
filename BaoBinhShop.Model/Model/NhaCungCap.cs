using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_NhaCungCap")]
    public class NhaCungCap
    {
        [Key]
        [MaxLength(50)]
        public int MaNCC { get; set; }
        [Required]
        public string TenNCC { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string SDT { get; set; }
        [Required]
        public string DiaChi { get; set; }
    }
}
