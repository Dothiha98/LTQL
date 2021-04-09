using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("NhaCCs")]
    public class NhaCC
    {
        [Key]
        public string MaCC { get; set; }
        public string TenCC { get; set; }
        [MaxLength(15)]
        public string  SoDienThoai { get; set; }
    }
}