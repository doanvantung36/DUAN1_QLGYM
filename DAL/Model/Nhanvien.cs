﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Nhanvien
    {
        [Key]
        public string MaNhanVien {  get; set; }

        public string TenNhanvien { get; set; }

        public DateOnly Ngaysinh { get; set; }

        public string Diachi {  get; set; }

        public string Gioitinh { get; set; }

        public string Chucvu {  get; set; }

        public int SDT {  get; set; }

        public string Ghichi {  get; set; }
    }
}
