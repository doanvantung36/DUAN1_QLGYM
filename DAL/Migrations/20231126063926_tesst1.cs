using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class tesst1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatLich",
                columns: table => new
                {
                    IdPhieudatlich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaydatlich = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdCT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatLich", x => x.IdPhieudatlich);
                });

            migrationBuilder.CreateTable(
                name: "DatLichChitiet",
                columns: table => new
                {
                    IdCT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdPhieudatlich = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdPT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaydatlich = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gioibatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gioketthuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatLichChitiet", x => x.IdCT);
                });

            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    IdDichvu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tendichvu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<int>(type: "int", nullable: false),
                    Thoihan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DichVu", x => x.IdDichvu);
                });

            migrationBuilder.CreateTable(
                name: "giamgia",
                columns: table => new
                {
                    IdGG = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Mota = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    giamgia = table.Column<float>(type: "real", nullable: false),
                    Ngayhethan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giamgia", x => x.IdGG);
                });

            migrationBuilder.CreateTable(
                name: "HoaDon",
                columns: table => new
                {
                    IdNhanvien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdHoadon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKhachhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthaithanhtoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthaihoadon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tongtien = table.Column<int>(type: "int", nullable: false),
                    Giamgia = table.Column<float>(type: "real", nullable: false),
                    Thanhtien = table.Column<int>(type: "int", nullable: false),
                    Tongtienthanhtoan = table.Column<int>(type: "int", nullable: false),
                    IdThanhToan = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IdNhanvien);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdHoadonchitiet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdHoadon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKhachhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    IdGG = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Giamgia = table.Column<float>(type: "real", nullable: false),
                    Tiencoctruoc = table.Column<double>(type: "float", nullable: false),
                    Tiencanthanhtoan = table.Column<double>(type: "float", nullable: false),
                    IdDichVu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.IdHoadonchitiet);
                });

            migrationBuilder.CreateTable(
                name: "hopdong",
                columns: table => new
                {
                    IdHopdong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdKhachhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaydangki = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaykethuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdDichvu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hopdong", x => x.IdHopdong);
                });

            migrationBuilder.CreateTable(
                name: "KhachHang",
                columns: table => new
                {
                    IdKhachhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tenkhachhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaysinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gioitinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.IdKhachhang);
                });

            migrationBuilder.CreateTable(
                name: "LichLamViec",
                columns: table => new
                {
                    IdLich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPT = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichLamViec", x => x.IdLich);
                });

            migrationBuilder.CreateTable(
                name: "LichSuThanhToan",
                columns: table => new
                {
                    IdThanhtoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdPhuonthuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdHoadon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaythanhtoan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuThanhToan", x => x.IdThanhtoan);
                });

            migrationBuilder.CreateTable(
                name: "LoaiThietBi",
                columns: table => new
                {
                    MaLoaiThetBi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    tenLoaiThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucNang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ViTri = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    KhoiLuong = table.Column<double>(type: "float", nullable: false),
                    MauSac = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LoaiThietBi", x => x.MaLoaiThetBi);
                });

            migrationBuilder.CreateTable(
                name: "NhanVien",
                columns: table => new
                {
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenNhanvien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaysinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Diachi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gioitinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Chucvu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SDT = table.Column<int>(type: "int", nullable: false),
                    Ghichi = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_NhanVien", x => x.MaNhanVien);
                });

            migrationBuilder.CreateTable(
                name: "PhieuThongKe",
                columns: table => new
                {
                    MaPhieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgayLap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PhieuThongKe", x => x.MaPhieu);
                });

            migrationBuilder.CreateTable(
                name: "phuongthucthanhtoan",
                columns: table => new
                {
                    IdPhongthuc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phuongthucthanhtoan", x => x.IdPhongthuc);
                });

            migrationBuilder.CreateTable(
                name: "PT",
                columns: table => new
                {
                    MaPT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenPT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NgaySinh = table.Column<DateTime>(type: "datetime2", nullable: false),
                    GioiTinh = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DiaChi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoDienThoai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ChucNang = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PT", x => x.MaPT);
                });

            migrationBuilder.CreateTable(
                name: "ThongKeChiTiet",
                columns: table => new
                {
                    MaPhieuCT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPhieu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TenLoaiThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    SoLuong = table.Column<double>(type: "float", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    MaLoaiThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongKeChiTiet", x => x.MaPhieuCT);
                });

            migrationBuilder.CreateTable(
                name: "User",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Password = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Rule = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ThietBi",
                columns: table => new
                {
                    MaThietBi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TenThietBi = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    MaLoaiThietBi = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    TrangThai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThietBi", x => x.MaThietBi);
                    table.ForeignKey(
                        name: "FK_ThietBi_LoaiThietBi_MaLoaiThietBi",
                        column: x => x.MaLoaiThietBi,
                        principalTable: "LoaiThietBi",
                        principalColumn: "MaLoaiThetBi",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_ThietBi_MaLoaiThietBi",
                table: "ThietBi",
                column: "MaLoaiThietBi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatLich");

            migrationBuilder.DropTable(
                name: "DatLichChitiet");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "giamgia");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "hopdong");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LichLamViec");

            migrationBuilder.DropTable(
                name: "LichSuThanhToan");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PhieuThongKe");

            migrationBuilder.DropTable(
                name: "phuongthucthanhtoan");

            migrationBuilder.DropTable(
                name: "PT");

            migrationBuilder.DropTable(
                name: "ThietBi");

            migrationBuilder.DropTable(
                name: "ThongKeChiTiet");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "LoaiThietBi");
        }
    }
}
