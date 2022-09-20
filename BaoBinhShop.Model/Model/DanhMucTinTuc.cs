using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_DanhMucTinTuc")]
    public class DanhMucTinTuc: Auditable
    {
        [Key]
        [MaxLength(50)]
        public int MaDMTT { get; set; }
        public string TenDMTT { get; set; }
        public int SapXep { get; set; }
        public int ParentID { get; set; }
    }
}
