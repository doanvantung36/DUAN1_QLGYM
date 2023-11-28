using DAL.DBContexs;
using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BUS.Services
{
    public class KhachHangService
    {
        private readonly GymDBContext _gymDBContext;
        public KhachHangService(GymDBContext gymDBContext)
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

        public void Delete(string khachhangs)
        {
            var khachhang = _gymDBContext.KhachHang.Find(khachhangs);
            if (khachhang != null)
            {
                _gymDBContext.Remove(khachhangs);
                _gymDBContext.SaveChanges();
            }
        }
        public void Update(KhachHang user)
        {
            _gymDBContext.Entry(user).State = EntityState.Modified;
            _gymDBContext.SaveChanges();
        }
        public void Add(KhachHang user)
        {
            _gymDBContext.KhachHang.Add(user);
            _gymDBContext.SaveChanges();
        }
    }
}
