﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class PT
    {
        [Key]
        public string MaPT { get; set; }
        public string TenPT { get; set; }
        public DateTime NgaySinh { get; set; }
        public string GioiTinh { get; set; }
        public string  DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string Email { get; set; }
        public string ChucNang { get; set; }
        // Navigation property for the related LoaiThietBi
        public PT PT { get; set; }

    }
}
