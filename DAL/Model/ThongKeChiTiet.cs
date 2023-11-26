﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class ThongKeChiTiet
    {
        [Key]
        public string MaPhieuCT { get; set; }

        [ForeignKey("MaPhieu")]
        public string MaPhieu { get; set; }

        [ForeignKey("MaThietBi")]
        public string MaThietBi { get; set; }

        public string TenThietBi { get; set; }

        public string TenLoaiThietBi { get; set; }

        public double SoLuong { get; set; }

        public string TrangThai { get; set; }

        public string MaLoaiThietBi { get; set; }

        public string NhaCungCap { get; set; }
        // Navigation property for the related LoaiThietBi
        public ThietBi ThietBi { get; set; }
        public PhieuThongKe PhieuThongKe { get; set; }

    }
}
