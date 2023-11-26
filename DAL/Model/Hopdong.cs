using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Hopdong
    {
        [Key]
        public string IdHopdong {  get; set; }
        [ForeignKey("MaPT")]
        public string MaPT {  get; set; }
        [ForeignKey("IdKhachhang")]
        public string IdKhachhang { get; set; }

        public DateOnly Ngaydangki { get; set; }

        public DateOnly Ngaykethuc { get; set; }
        [ForeignKey("IdDichvu")]
        public string IdDichvu {  get; set; }
    }
}
