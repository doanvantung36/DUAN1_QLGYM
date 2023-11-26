using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.DBContexs
{
    public class GymDBContext : DbContext
    {
        public GymDBContext() { }
        public GymDBContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public DbSet<User> User { get; set; }
        public DbSet<ThongKeChiTiet> ThongKeChiTiet { get; set; }
        public DbSet<ThietBi> ThietBi { get; set; }
        public DbSet<PT> PT { get; set; }
        public DbSet<Phuongthucthanhtoan> phuongthucthanhtoan { get; set; }
        public DbSet<PhieuThongKe> PhieuThongKe { get; set; }
        public DbSet<Nhanvien> NhanVien { get; set; }
        public DbSet<LoaiThietBi> LoaiThietBi { get; set; }
        public DbSet<Lichsuthanhtoan> LichSuThanhToan { get; set; }
        public DbSet<LichLamviec> LichLamViec { get; set; }
        public DbSet<KhachHang> KhachHang { get; set; }
        public DbSet<Hopdong> hopdong { get; set; }
        public DbSet<Hoadonchitiet> HoaDonChiTiet { get; set; }
        public DbSet<Hoadon> HoaDon { get; set; }
        public DbSet<Giamgia> giamgia { get; set; }
        public DbSet<Dichvu> DichVu { get; set; }
        public DbSet<Datlichchitiet> DatLichChitiet { get; set; }
        public DbSet<Datlich> DatLich { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=LAPTOP-7HORMRAF\SQLEXPRESS01;Initial Catalog=DUAN01;Integrated Security=True;TrustServerCertificate=True");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
