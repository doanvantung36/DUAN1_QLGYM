using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Datlichchitiet
    {
        [Key]
        public string IdCT { get; set; }
        public string IdPhieudatlich { get; set; }
        [ForeignKey("IdPhieudatlich")]
        public Datlich Datlich { get; set; }
        public string Trangthai { get; set; }
        public DateTime Ngaydatlich { get; set; }
        public DateTime Gioibatdau { get; set; }
        public DateTime Gioketthuc { get; set; }
        public string Ghichu { get; set; }
    }
}
