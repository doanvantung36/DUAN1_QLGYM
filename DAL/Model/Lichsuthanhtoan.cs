using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Lichsuthanhtoan
    {
        [Key]
        public string IdThanhtoan {  get; set; }
        public DateTime Ngaythanhtoan { get; set; }
        public string Trangthai {  get; set; }
        // Navigation property for the related LoaiThietBi

    }
}
