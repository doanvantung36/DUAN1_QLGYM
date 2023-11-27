using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class KhachHang
    {
        [Key]
        public string IdKhachhang { get; set; }
        public string Tenkhachhang { get; set; }
        public DateTime Ngaysinh { get; set; }
        public string Gioitinh { get; set; }
        public string Diachi { get; set; }
        public int SDT { get; set; }
        public string Email { get; set; }

        // Tên khóa ngoại phải trùng với tên thuộc tính của đối tượng
        public virtual ICollection<Datlich> Datlichs { get; set; }
    }
}
