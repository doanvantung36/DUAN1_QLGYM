using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class LichLamviec
    {
        [Key]
        public string IdLich {  get; set; }

        public string Ca {  get; set; }

        public DateTime Ngay { get; set; }

        public string MaPT {  get; set; }
        // Navigation property for the related LoaiThietBi
        public PT PT { get; set; }
    }
}
