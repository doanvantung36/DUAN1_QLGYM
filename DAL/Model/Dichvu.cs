using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Dichvu
    {
        [Key]
        public string IdDichvu {  get; set; }

        public string Tendichvu { get; set; }

        public int Gia {  get; set; }
        public DateTime Thoihan { get; set; }

        public string Ghichu {  get; set; }
    }
}
