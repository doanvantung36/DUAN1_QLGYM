using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Model
{
    public class LichLamvic
    {
        [Key]
        public string IdLich {  get; set; }

        public string Ca {  get; set; }

        public DateOnly Ngay { get; set; }

        public string IdPT {  get; set; }
    }
}
