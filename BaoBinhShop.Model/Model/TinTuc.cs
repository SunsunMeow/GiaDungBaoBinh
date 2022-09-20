using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Text;
using System.Xml.Linq;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_TinTuc")]
    public class TinTuc : Auditable
    {

        [Key]
        [MaxLength(50)]
        public int MaTT { get; set; }
        [Required]
        public string MoTaSP { get; set; }
        
        public string ChiTiet { get; set; }
        public int LuotXem { get; set; }
         
        public int MaDMTT { get; set; }
    }
}
