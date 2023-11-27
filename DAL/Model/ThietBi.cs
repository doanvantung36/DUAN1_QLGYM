using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ThietBi
    {
        [Key]
        public string MaThietBi { get; set; }

        [Required(ErrorMessage = "Tên thiết bị is required.")]
        public string TenThietBi { get; set; }

        [Required(ErrorMessage = "Giá is required.")]
        public decimal Gia { get; set; }

        [ForeignKey("LoaiThietBi")]
        public string MaLoaiThietBi { get; set; }

        public string TrangThai { get; set; }

        // Navigation property for the related LoaiThietBi
        public virtual LoaiThietBi LoaiThietBi { get; set; }

        // Navigation property for the related ThongKeChiTiet
        public virtual ICollection<ThongKeChiTiet> ThongKeChiTiets { get; set; }
    }
}
