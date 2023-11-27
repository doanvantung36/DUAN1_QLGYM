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
        public string IdHoadon { get; set; }
        public string MaNhanVien {  get; set; }
        [ForeignKey("MaNhanVien")]
        public Nhanvien Nhanvien { get; set; }
        public string IdKhachhang { get; set; }
        [ForeignKey("IdKhachhang")]
        public virtual ICollection< KhachHang> KhachHang { get; set; }
        public string Trangthaithanhtoan {  get; set; }
        
        //public virtual Hopdong Hopdong { get; set; }
        public string Trangthaihoadon {  get; set; }

        public DateTime Ngaylap {  get; set; }
        public double Tongtien {  get; set; }

        public float Giamgia {  get; set; }

        public double Thanhtien {  get; set; }

        public double Tongtienthanhtoan { get; set; }
        public string IdThanhToan { get; set; }
        [ForeignKey("IdThanhToan")]
        public Lichsuthanhtoan Lichsuthanhtoan { get; set; }
        // Navigation property for the related LoaiThietBi
        
        
    }
}
