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
        [ForeignKey("IdHoadon")]
        public string IdHoadon {  get; set; }
        [ForeignKey("IdKhachhang")]
        public string IdKhachhang {  get; set; }
        public double Gia {  get; set; }
        [ForeignKey("IdGG")]
        public string IdGG {  get; set; }

        public float Giagiam { get; set; }

        public double Tiencoctruoc { get; set; }

        public double Tiencanthanhtoan { get; set; }
        [ForeignKey("IdDichvu")]
        public string IdDichvu { get; set; }
        public Dichvu Dichvu { get; set; }
        public KhachHang KhachHang { get; set; }
        public Giamgia Giamgia { get; set; }
        public Hoadon Hoadon { get; set; }
    }
}
