﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Phuongthucthanhtoan
    {
        [Key]
        public string IdPhongthuc {  get; set; }

        public string Ten {  get; set; }

        public string Trangthai {  get; set; }

    }
}
