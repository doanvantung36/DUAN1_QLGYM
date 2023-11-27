using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
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
        public string IdHopDong { get; set; }
        [ForeignKey("IdHopDong")]
        public virtual ICollection< Hopdong> Hopdong { get; set; }
        public double Gia {  get; set; }
        public DateTime Thoihan { get; set; }

        public string Ghichu {  get; set; }
    }
}
