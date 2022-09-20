using BaoBinhShop.Model.Abstract;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace BaoBinhShop.Model.Model
{
    [Table("tb_Menu")]
    public class Menu : Auditable
    {
        [Key]
        [MaxLength(50)]
        public int ID { get; set; }
        public string Ten { get; set; }
        public string MoTa { get; set; }
        public int ViTri { get; set; }
        public string Target { get; set; }
        public string Link { get; set; }

    }
}
