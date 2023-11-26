using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class Giamgia
    {
        [Key]
        public string IdGG {  get; set; }

        public string Mota {  get; set; }

        public float GiaGiam {  get; set; }

        public DateTime Ngayhethan { get; set; }
    }
}
