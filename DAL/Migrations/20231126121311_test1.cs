using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class test1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                    GiaGiam = table.Column<float>(type: "real", nullable: false),
                    Ngayhethan = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_giamgia", x => x.IdGG);
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
                name: "DatLich",
                columns: table => new
                {
                    IdPhieudatlich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaydatlich = table.Column<DateTime>(type: "datetime2", nullable: false),
                    KhachHangIdKhachhang = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatLich", x => x.IdPhieudatlich);
                    table.ForeignKey(
                        name: "FK_DatLich_KhachHang_KhachHangIdKhachhang",
                        column: x => x.KhachHangIdKhachhang,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachhang",
                        onDelete: ReferentialAction.Cascade);
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
                    KhachHangIdKhachhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    NhanVienMaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IdNhanvien);
                    table.ForeignKey(
                        name: "FK_HoaDon_KhachHang_KhachHangIdKhachhang",
                        column: x => x.KhachHangIdKhachhang,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachhang",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_NhanVienMaNhanVien",
                        column: x => x.NhanVienMaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
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
                    IdDichvu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PTMaPT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HopDongIdHopdong = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hopdong", x => x.IdHopdong);
                    table.ForeignKey(
                        name: "FK_hopdong_hopdong_HopDongIdHopdong",
                        column: x => x.HopDongIdHopdong,
                        principalTable: "hopdong",
                        principalColumn: "IdHopdong");
                    table.ForeignKey(
                        name: "FK_hopdong_PT_PTMaPT",
                        column: x => x.PTMaPT,
                        principalTable: "PT",
                        principalColumn: "MaPT",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichLamViec",
                columns: table => new
                {
                    IdLich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ca = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngay = table.Column<DateTime>(type: "datetime2", nullable: false),
                    IdPT = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PTMaPT = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichLamViec", x => x.IdLich);
                    table.ForeignKey(
                        name: "FK_LichLamViec_PT_PTMaPT",
                        column: x => x.PTMaPT,
                        principalTable: "PT",
                        principalColumn: "MaPT",
                        onDelete: ReferentialAction.Cascade);
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
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DatLichIdPhieudatlich = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PTMaPT = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatLichChitiet", x => x.IdCT);
                    table.ForeignKey(
                        name: "FK_DatLichChitiet_DatLich_DatLichIdPhieudatlich",
                        column: x => x.DatLichIdPhieudatlich,
                        principalTable: "DatLich",
                        principalColumn: "IdPhieudatlich");
                    table.ForeignKey(
                        name: "FK_DatLichChitiet_PT_PTMaPT",
                        column: x => x.PTMaPT,
                        principalTable: "PT",
                        principalColumn: "MaPT",
                        onDelete: ReferentialAction.Cascade);
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
                    NhaCungCap = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    ThietBiMaThietBi = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    PhieuThongKeMaPhieu = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ThongKeChiTiet", x => x.MaPhieuCT);
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_PhieuThongKe_PhieuThongKeMaPhieu",
                        column: x => x.PhieuThongKeMaPhieu,
                        principalTable: "PhieuThongKe",
                        principalColumn: "MaPhieu");
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_ThietBi_ThietBiMaThietBi",
                        column: x => x.ThietBiMaThietBi,
                        principalTable: "ThietBi",
                        principalColumn: "MaThietBi");
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
                    IdDichVu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DichVuIdDichvu = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    KhachHangIdKhachhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    GiamGiaIdGG = table.Column<string>(type: "nvarchar(450)", nullable: true),
                    HoaDonIdNhanvien = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.IdHoadonchitiet);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_DichVu_DichVuIdDichvu",
                        column: x => x.DichVuIdDichvu,
                        principalTable: "DichVu",
                        principalColumn: "IdDichvu");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_giamgia_GiamGiaIdGG",
                        column: x => x.GiamGiaIdGG,
                        principalTable: "giamgia",
                        principalColumn: "IdGG");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_HoaDon_HoaDonIdNhanvien",
                        column: x => x.HoaDonIdNhanvien,
                        principalTable: "HoaDon",
                        principalColumn: "IdNhanvien");
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_KhachHang_KhachHangIdKhachhang",
                        column: x => x.KhachHangIdKhachhang,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachhang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "LichSuThanhToan",
                columns: table => new
                {
                    IdThanhtoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdPhuonthuc = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdHoadon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaythanhtoan = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PhuongThucThanhToanIdPhongthuc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    HoaDonIdNhanvien = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_LichSuThanhToan", x => x.IdThanhtoan);
                    table.ForeignKey(
                        name: "FK_LichSuThanhToan_HoaDon_HoaDonIdNhanvien",
                        column: x => x.HoaDonIdNhanvien,
                        principalTable: "HoaDon",
                        principalColumn: "IdNhanvien");
                    table.ForeignKey(
                        name: "FK_LichSuThanhToan_phuongthucthanhtoan_PhuongThucThanhToanIdPhongthuc",
                        column: x => x.PhuongThucThanhToanIdPhongthuc,
                        principalTable: "phuongthucthanhtoan",
                        principalColumn: "IdPhongthuc",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatLich_KhachHangIdKhachhang",
                table: "DatLich",
                column: "KhachHangIdKhachhang");

            migrationBuilder.CreateIndex(
                name: "IX_DatLichChitiet_DatLichIdPhieudatlich",
                table: "DatLichChitiet",
                column: "DatLichIdPhieudatlich");

            migrationBuilder.CreateIndex(
                name: "IX_DatLichChitiet_PTMaPT",
                table: "DatLichChitiet",
                column: "PTMaPT");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_KhachHangIdKhachhang",
                table: "HoaDon",
                column: "KhachHangIdKhachhang");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_NhanVienMaNhanVien",
                table: "HoaDon",
                column: "NhanVienMaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_DichVuIdDichvu",
                table: "HoaDonChiTiet",
                column: "DichVuIdDichvu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_GiamGiaIdGG",
                table: "HoaDonChiTiet",
                column: "GiamGiaIdGG");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_HoaDonIdNhanvien",
                table: "HoaDonChiTiet",
                column: "HoaDonIdNhanvien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_KhachHangIdKhachhang",
                table: "HoaDonChiTiet",
                column: "KhachHangIdKhachhang");

            migrationBuilder.CreateIndex(
                name: "IX_hopdong_HopDongIdHopdong",
                table: "hopdong",
                column: "HopDongIdHopdong");

            migrationBuilder.CreateIndex(
                name: "IX_hopdong_PTMaPT",
                table: "hopdong",
                column: "PTMaPT");

            migrationBuilder.CreateIndex(
                name: "IX_LichLamViec_PTMaPT",
                table: "LichLamViec",
                column: "PTMaPT");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuThanhToan_HoaDonIdNhanvien",
                table: "LichSuThanhToan",
                column: "HoaDonIdNhanvien");

            migrationBuilder.CreateIndex(
                name: "IX_LichSuThanhToan_PhuongThucThanhToanIdPhongthuc",
                table: "LichSuThanhToan",
                column: "PhuongThucThanhToanIdPhongthuc");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBi_MaLoaiThietBi",
                table: "ThietBi",
                column: "MaLoaiThietBi");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_PhieuThongKeMaPhieu",
                table: "ThongKeChiTiet",
                column: "PhieuThongKeMaPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_ThietBiMaThietBi",
                table: "ThongKeChiTiet",
                column: "ThietBiMaThietBi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatLichChitiet");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "hopdong");

            migrationBuilder.DropTable(
                name: "LichLamViec");

            migrationBuilder.DropTable(
                name: "LichSuThanhToan");

            migrationBuilder.DropTable(
                name: "ThongKeChiTiet");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DatLich");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "giamgia");

            migrationBuilder.DropTable(
                name: "PT");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "phuongthucthanhtoan");

            migrationBuilder.DropTable(
                name: "PhieuThongKe");

            migrationBuilder.DropTable(
                name: "ThietBi");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "LoaiThietBi");
        }
    }
}
