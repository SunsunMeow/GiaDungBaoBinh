using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_DanhMucSanPham")]   
    
    public class ProductCategory: Auditable
    {
        [Key]
        [MaxLength(50)]
        public int ID { get; set; }
       [Required]
       public string Name { get; set; }
       [Required]
       public string Description { get; set; }
       [Required]
       public string Alias { get; set; }
       public string Image { get; set; }
       public int? PrentID { get; set; }
       public int? DisplayOder { get; set; }
       public bool? HomeFlag { get; set; }

       public virtual IEnumerable<Product> Product { get; set; }
    }
}
