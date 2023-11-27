using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Datlich
    {
        [Key]
        public string IdPhieudatlich { get; set; }
        public string IdKhachhang { get; set; }

        [ForeignKey("IdKhachhang")]
        public KhachHang KhachHang { get; set; }

        public DateTime Ngaydatlich { get; set; }

        // Navigation property for the related Datlichchitiet
        public virtual ICollection<Datlichchitiet> Datlichchitiets { get; set; }
    }
}
