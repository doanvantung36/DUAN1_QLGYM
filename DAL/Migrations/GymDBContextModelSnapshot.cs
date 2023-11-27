﻿// <auto-generated />
using System;
using DAL.DBContexs;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DAL.Migrations
{
    [DbContext(typeof(GymDBContext))]
    partial class GymDBContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.25")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("DAL.Model.Datlich", b =>
                {
                    b.Property<string>("IdPhieudatlich")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdKhachhang")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngaydatlich")
                        .HasColumnType("datetime2");

                    b.HasKey("IdPhieudatlich");

                    b.HasIndex("IdKhachhang");

                    b.ToTable("DatLich");
                });

            modelBuilder.Entity("DAL.Model.Datlichchitiet", b =>
                {
                    b.Property<string>("IdCT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Gioibatdau")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Gioketthuc")
                        .HasColumnType("datetime2");

                    b.Property<string>("IdPhieudatlich")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngaydatlich")
                        .HasColumnType("datetime2");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdCT");

                    b.HasIndex("IdPhieudatlich");

                    b.ToTable("DatLichChitiet");
                });

            modelBuilder.Entity("DAL.Model.Dichvu", b =>
                {
                    b.Property<string>("IdDichvu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ghichu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<string>("IdHopDong")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Tendichvu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Thoihan")
                        .HasColumnType("datetime2");

                    b.HasKey("IdDichvu");

                    b.ToTable("DichVu");
                });

            modelBuilder.Entity("DAL.Model.Giamgia", b =>
                {
                    b.Property<string>("IdGG")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("GiaGiam")
                        .HasColumnType("real");

                    b.Property<string>("Mota")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngayhethan")
                        .HasColumnType("datetime2");

                    b.HasKey("IdGG");

                    b.ToTable("giamgia");
                });

            modelBuilder.Entity("DAL.Model.Hoadon", b =>
                {
                    b.Property<string>("IdHoadon")
                        .HasColumnType("nvarchar(450)");

                    b.Property<float>("Giamgia")
                        .HasColumnType("real");

                    b.Property<string>("IdKhachhang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("IdThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngaylap")
                        .HasColumnType("datetime2");

                    b.Property<double>("Thanhtien")
                        .HasColumnType("float");

                    b.Property<double>("Tongtien")
                        .HasColumnType("float");

                    b.Property<double>("Tongtienthanhtoan")
                        .HasColumnType("float");

                    b.Property<string>("Trangthaihoadon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthaithanhtoan")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdHoadon");

                    b.HasIndex("IdThanhToan");

                    b.HasIndex("MaNhanVien");

                    b.ToTable("HoaDon");
                });

            modelBuilder.Entity("DAL.Model.Hoadonchitiet", b =>
                {
                    b.Property<string>("IdHoadonchitiet")
                        .HasColumnType("nvarchar(450)");

                    b.Property<double>("Gia")
                        .HasColumnType("float");

                    b.Property<float>("Giagiam")
                        .HasColumnType("real");

                    b.Property<string>("IdDichvu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdGG")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdHoadon")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("Tiencanthanhtoan")
                        .HasColumnType("float");

                    b.Property<double>("Tiencoctruoc")
                        .HasColumnType("float");

                    b.HasKey("IdHoadonchitiet");

                    b.HasIndex("IdDichvu");

                    b.HasIndex("IdGG");

                    b.ToTable("HoaDonChiTiet");
                });

            modelBuilder.Entity("DAL.Model.Hopdong", b =>
                {
                    b.Property<string>("IdHopDong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaPT")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngaydangki")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("Ngaykethuc")
                        .HasColumnType("datetime2");

                    b.HasKey("IdHopDong");

                    b.HasIndex("MaPT");

                    b.ToTable("hopdong");
                });

            modelBuilder.Entity("DAL.Model.KhachHang", b =>
                {
                    b.Property<string>("IdKhachhang")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gioitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("HopdongIdHopDong")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<int>("SDT")
                        .HasColumnType("int");

                    b.Property<string>("Tenkhachhang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdKhachhang");

                    b.HasIndex("HopdongIdHopDong");

                    b.ToTable("KhachHang");
                });

            modelBuilder.Entity("DAL.Model.LichLamviec", b =>
                {
                    b.Property<string>("IdLich")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ca")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaPT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngay")
                        .HasColumnType("datetime2");

                    b.Property<string>("PTMaPT")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.HasKey("IdLich");

                    b.HasIndex("PTMaPT");

                    b.ToTable("LichLamViec");
                });

            modelBuilder.Entity("DAL.Model.Lichsuthanhtoan", b =>
                {
                    b.Property<string>("IdThanhtoan")
                        .HasColumnType("nvarchar(450)");

                    b.Property<DateTime>("Ngaythanhtoan")
                        .HasColumnType("datetime2");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdThanhtoan");

                    b.ToTable("LichSuThanhToan");
                });

            modelBuilder.Entity("DAL.Model.LoaiThietBi", b =>
                {
                    b.Property<string>("MaLoaiThetBi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChucNang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("KhoiLuong")
                        .HasColumnType("float");

                    b.Property<string>("MauSac")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("ViTri")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("tenLoaiThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaLoaiThetBi");

                    b.ToTable("LoaiThietBi");
                });

            modelBuilder.Entity("DAL.Model.Nhanvien", b =>
                {
                    b.Property<string>("MaNhanVien")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Chucvu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Diachi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Ghichi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Gioitinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("Ngaysinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SDT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenNhanvien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaNhanVien");

                    b.ToTable("NhanVien");
                });

            modelBuilder.Entity("DAL.Model.PhieuThongKe", b =>
                {
                    b.Property<string>("MaPhieu")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaNhanVien")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgayLap")
                        .HasColumnType("datetime2");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPhieu");

                    b.ToTable("PhieuThongKe");
                });

            modelBuilder.Entity("DAL.Model.Phuongthucthanhtoan", b =>
                {
                    b.Property<string>("IdPhongthuc")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("IdThanhToan")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Ten")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Trangthai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("IdPhongthuc");

                    b.HasIndex("IdThanhToan");

                    b.ToTable("phuongthucthanhtoan");
                });

            modelBuilder.Entity("DAL.Model.PT", b =>
                {
                    b.Property<string>("MaPT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("ChucNang")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("DiaChi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("GioiTinh")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime>("NgaySinh")
                        .HasColumnType("datetime2");

                    b.Property<string>("SoDienThoai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenPT")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPT");

                    b.ToTable("PT");
                });

            modelBuilder.Entity("DAL.Model.ThietBi", b =>
                {
                    b.Property<string>("MaThietBi")
                        .HasColumnType("nvarchar(450)");

                    b.Property<decimal>("Gia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("MaLoaiThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("TenThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaThietBi");

                    b.HasIndex("MaLoaiThietBi");

                    b.ToTable("ThietBi");
                });

            modelBuilder.Entity("DAL.Model.ThongKeChiTiet", b =>
                {
                    b.Property<string>("MaPhieuCT")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaLoaiThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MaPhieu")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("MaThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("NhaCungCap")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<double>("SoLuong")
                        .HasColumnType("float");

                    b.Property<string>("TenLoaiThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TenThietBi")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TrangThai")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("MaPhieuCT");

                    b.HasIndex("MaPhieu");

                    b.HasIndex("MaThietBi");

                    b.ToTable("ThongKeChiTiet");
                });

            modelBuilder.Entity("DAL.Model.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("nvarchar(450)");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Roles")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("DAL.Model.Datlich", b =>
                {
                    b.HasOne("DAL.Model.KhachHang", "KhachHang")
                        .WithMany("Datlichs")
                        .HasForeignKey("IdKhachhang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("DAL.Model.Datlichchitiet", b =>
                {
                    b.HasOne("DAL.Model.Datlich", "Datlich")
                        .WithMany("Datlichchitiets")
                        .HasForeignKey("IdPhieudatlich")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Datlich");
                });

            modelBuilder.Entity("DAL.Model.Hoadon", b =>
                {
                    b.HasOne("DAL.Model.Hoadonchitiet", null)
                        .WithMany("Hoadon")
                        .HasForeignKey("IdHoadon")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.Lichsuthanhtoan", "Lichsuthanhtoan")
                        .WithMany()
                        .HasForeignKey("IdThanhToan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.Nhanvien", "Nhanvien")
                        .WithMany()
                        .HasForeignKey("MaNhanVien")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lichsuthanhtoan");

                    b.Navigation("Nhanvien");
                });

            modelBuilder.Entity("DAL.Model.Hoadonchitiet", b =>
                {
                    b.HasOne("DAL.Model.Dichvu", "Dichvu")
                        .WithMany()
                        .HasForeignKey("IdDichvu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.Giamgia", "Giamgia")
                        .WithMany()
                        .HasForeignKey("IdGG")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Dichvu");

                    b.Navigation("Giamgia");
                });

            modelBuilder.Entity("DAL.Model.Hopdong", b =>
                {
                    b.HasOne("DAL.Model.Dichvu", null)
                        .WithMany("Hopdong")
                        .HasForeignKey("IdHopDong")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.PT", "PT")
                        .WithMany("Hopdong")
                        .HasForeignKey("MaPT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PT");
                });

            modelBuilder.Entity("DAL.Model.KhachHang", b =>
                {
                    b.HasOne("DAL.Model.Hopdong", null)
                        .WithMany("Khachhangs")
                        .HasForeignKey("HopdongIdHopDong");

                    b.HasOne("DAL.Model.Hoadon", null)
                        .WithMany("KhachHang")
                        .HasForeignKey("IdKhachhang")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("DAL.Model.LichLamviec", b =>
                {
                    b.HasOne("DAL.Model.PT", "PT")
                        .WithMany("LichLamviecs")
                        .HasForeignKey("PTMaPT")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PT");
                });

            modelBuilder.Entity("DAL.Model.Phuongthucthanhtoan", b =>
                {
                    b.HasOne("DAL.Model.Lichsuthanhtoan", "Lichsuthanhtoan")
                        .WithMany()
                        .HasForeignKey("IdThanhToan")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Lichsuthanhtoan");
                });

            modelBuilder.Entity("DAL.Model.ThietBi", b =>
                {
                    b.HasOne("DAL.Model.LoaiThietBi", "LoaiThietBi")
                        .WithMany("ThietBis")
                        .HasForeignKey("MaLoaiThietBi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("LoaiThietBi");
                });

            modelBuilder.Entity("DAL.Model.ThongKeChiTiet", b =>
                {
                    b.HasOne("DAL.Model.PhieuThongKe", "PhieuThongKe")
                        .WithMany("ThongKeChiTiets")
                        .HasForeignKey("MaPhieu")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("DAL.Model.ThietBi", "ThietBi")
                        .WithMany("ThongKeChiTiets")
                        .HasForeignKey("MaThietBi")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("PhieuThongKe");

                    b.Navigation("ThietBi");
                });

            modelBuilder.Entity("DAL.Model.Datlich", b =>
                {
                    b.Navigation("Datlichchitiets");
                });

            modelBuilder.Entity("DAL.Model.Dichvu", b =>
                {
                    b.Navigation("Hopdong");
                });

            modelBuilder.Entity("DAL.Model.Hoadon", b =>
                {
                    b.Navigation("KhachHang");
                });

            modelBuilder.Entity("DAL.Model.Hoadonchitiet", b =>
                {
                    b.Navigation("Hoadon");
                });

            modelBuilder.Entity("DAL.Model.Hopdong", b =>
                {
                    b.Navigation("Khachhangs");
                });

            modelBuilder.Entity("DAL.Model.KhachHang", b =>
                {
                    b.Navigation("Datlichs");
                });

            modelBuilder.Entity("DAL.Model.LoaiThietBi", b =>
                {
                    b.Navigation("ThietBis");
                });

            modelBuilder.Entity("DAL.Model.PhieuThongKe", b =>
                {
                    b.Navigation("ThongKeChiTiets");
                });

            modelBuilder.Entity("DAL.Model.PT", b =>
                {
                    b.Navigation("Hopdong");

                    b.Navigation("LichLamviecs");
                });

            modelBuilder.Entity("DAL.Model.ThietBi", b =>
                {
                    b.Navigation("ThongKeChiTiets");
                });
#pragma warning restore 612, 618
        }
    }
}
