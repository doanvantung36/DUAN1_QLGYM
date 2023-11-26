using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Hoadon
    {
        [Key]
        public string IdNhanvien {  get; set; }
        [ForeignKey("IdHoadon")]
        public string IdHoadon {  get; set; }
        [ForeignKey(("IdKhachhang"))]
        public string IdKhachhang {  get; set; }

        public string Trangthaithanhtoan {  get; set; }

        public string Trangthaihoadon {  get; set; }

        public DateOnly Ngaylap {  get; set; }
        public int Tongtien {  get; set; }

        public float Giamgia {  get; set; }

        public int Thanhtien {  get; set; }

        public int Tongtienthanhtoan { get; set; }
        [ForeignKey("IdThanhtoan")]
        public string IdThanhToan {  get; set; }
    }
}
