using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using System.Xml.Linq;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_SanPham")]
    public class Product:Auditable
    {
        [Key]
        [MaxLength(50)]
        public int MaSP { get; set; }
        [Required]
        public string TenSP { get; set; }
        public string HinhAnh { get; set; }
        public XElement DSHinhAnh { get; set; }
        [Required]
        public decimal GiaSP { get; set; }
        public decimal? GiaKhuyenMai { get; set; }
        [Required]
        public int SoLuong { get; set; }
        public int? BaoHanh { get; set; }

        public DateTime? SanPhamHot { get; set; }
        [Required]
        public string MoTaSP { get; set; }
        [Required]
        public string ChiTiet { get; set; }
        public int LuotXem { get; set; }


        public int MaDMSP { get; set; }
        public int MaNSX { get; set; }
        public int MaNCC { get; set; }


        [ForeignKey("MaDMSP")]
        public virtual ProductCategory Category { get; set; }
    }
}
