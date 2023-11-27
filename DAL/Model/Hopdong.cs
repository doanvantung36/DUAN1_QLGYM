using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Hopdong
    {
        [Key]
        public string IdHopDong { get; set; }

        [ForeignKey("PT")]
        public string MaPT { get; set; }

        public DateTime Ngaydangki { get; set; }

        public DateTime Ngaykethuc { get; set; }

        public PT PT { get; set; }

        public virtual ICollection<KhachHang> Khachhangs { get; set; }
    }
}
