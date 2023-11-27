using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PhieuThongKe
    {
        [Key]
        public string MaPhieu { get; set; }

        public string MaNhanVien { get; set; }

        public DateTime NgayLap { get; set; }

        public string TrangThai { get; set; }

        // Navigation property for the related ThongKeChiTiet
        public virtual ICollection<ThongKeChiTiet> ThongKeChiTiets { get; set; }
    }
}
