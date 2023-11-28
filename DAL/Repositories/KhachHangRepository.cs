using DAL.DBContexs;
using DAL.GymInterface;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Repositories
{
    public class KhachHangRepository : IKhachHangRepo
    {
        private readonly GymDBContext _gymDBContext;
        public KhachHangRepository(GymDBContext gymDBContext)
        {
            _gymDBContext = gymDBContext;
        }
        public KhachHang GetByID(string id)
        {
            return _gymDBContext.KhachHang.Find(id);
        }
        public KhachHang GetByName(string Name)
        {
            return _gymDBContext.KhachHang.SingleOrDefault(u => u.Tenkhachhang == Name);
        }

        public IEnumerable<KhachHang> GetAll()
        {
            return _gymDBContext.KhachHang.ToList();
        }

        public void Delete(string user)
        {
            var khachHangs = _gymDBContext.KhachHang.Find(user);
            if (khachHangs != null)
            {
                _gymDBContext.Remove(user);
                _gymDBContext.SaveChanges();
            }
        }
        public void Update(KhachHang khachhang)
        {
            _gymDBContext.Entry(khachhang).State = EntityState.Modified;
            _gymDBContext.SaveChanges();
        }
        public void Add(KhachHang khachhang)
        {
            _gymDBContext.KhachHang.Add(khachhang);
            _gymDBContext.SaveChanges();
        }
    }
}
