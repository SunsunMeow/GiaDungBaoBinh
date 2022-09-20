using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_About")]
    public class About : Auditable
    {
        [Key]
        [MaxLength(50)]
        public int ID { get; set; }
        public string Ten { get; set; }
        public string ChiTiet { get; set; }
        public string MoTa { get; set; }
    }
}
