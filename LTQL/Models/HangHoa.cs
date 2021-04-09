using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace LTQL.Models
{
    [Table("HangHoas")]
    public class HangHoa
    {
        [Key]
        public string MaHanghoa { get; set; }
        public string TenHangHoa { get; set; }
        [MaxLength(15)]
        public string DonGia { get; set; }
    }
}