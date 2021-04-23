using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace LTQL.Models
{
    [Table("HoaDons")]
    public class HoaDon
    {
        [Key]
        public string MaHoaDon { get; set; }
        public string TenHoaDon { get; set; }
        [MaxLength(15)]
        [AllowHtml]
        public string NgayTao { get; set; }
    }

}