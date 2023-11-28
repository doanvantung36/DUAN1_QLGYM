using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.GymInterface
{
    public interface IKhachHangRepo
    {
        public KhachHang GetByID(string id);
        public KhachHang GetByName(string name);
        public void Add(KhachHang khachhang);
        public void Update(KhachHang khachhang);
        public void Delete(string khachhang);
        IEnumerable<KhachHang> GetAll();
    }
}
