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

        public float Giamgia { get; set; }

        public double Tiencoctruoc { get; set; }

        public double Tiencanthanhtoan { get; set; }
        [ForeignKey("IdDichvu")]
        public string IdDichVu { get; set; }
        public Dichvu DichVu { get; set; }
        public KhachHang KhachHang { get; set; }
        public Giamgia GiamGia { get; set; }
        public Hoadon HoaDon { get; set; }
    }
}
