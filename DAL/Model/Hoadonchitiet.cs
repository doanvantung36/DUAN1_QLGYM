using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Hoadonchitiet
    {
        [Key]
        public string IdHoadonchitiet {  get; set; }
        
        public string IdHoadon {  get; set; }
        [ForeignKey("IdHoadon")]
        public virtual ICollection< Hoadon> Hoadon { get; set; }
        public double Gia {  get; set; }
        
        public string IdGG {  get; set; }
        [ForeignKey("IdGG")]
        public Giamgia Giamgia { get; set; }
        public float Giagiam { get; set; }

        public double Tiencoctruoc { get; set; }

        public double Tiencanthanhtoan { get; set; }
        
        public string IdDichvu { get; set; }
        [ForeignKey("IdDichvu")]
        public Dichvu Dichvu { get; set; }
        
    }
}
