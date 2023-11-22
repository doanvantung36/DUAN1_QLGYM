using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class LoaiThietBi
    {
        [Key]
        public string MaLoaiThetBi { get; set; }

        [Required(ErrorMessage = "LoaiThietBi is required.")]
        public string tenLoaiThietBi { get; set; }

        public string ChucNang { get; set; }

        public string ViTri { get; set; }

        public double KhoiLuong { get; set; }

        public string MauSac { get; set; }

        public string TrangThai { get; set; }
    }
}
