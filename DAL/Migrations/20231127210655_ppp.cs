using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DAL.Migrations
{
    public partial class ppp : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DichVu",
                columns: table => new
                {
                    IdDichvu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Tendichvu = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    IdHopDong = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
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
                name: "LichSuThanhToan",
                columns: table => new
                {
                    IdThanhtoan = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    SDT = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                    Roles = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_User", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "HoaDonChiTiet",
                columns: table => new
                {
                    IdHoadonchitiet = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdHoadon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gia = table.Column<double>(type: "float", nullable: false),
                    IdGG = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Giagiam = table.Column<float>(type: "real", nullable: false),
                    Tiencoctruoc = table.Column<double>(type: "float", nullable: false),
                    Tiencanthanhtoan = table.Column<double>(type: "float", nullable: false),
                    IdDichvu = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDonChiTiet", x => x.IdHoadonchitiet);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_DichVu_IdDichvu",
                        column: x => x.IdDichvu,
                        principalTable: "DichVu",
                        principalColumn: "IdDichvu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDonChiTiet_giamgia_IdGG",
                        column: x => x.IdGG,
                        principalTable: "giamgia",
                        principalColumn: "IdGG",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "phuongthucthanhtoan",
                columns: table => new
                {
                    IdPhongthuc = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdThanhToan = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ten = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_phuongthucthanhtoan", x => x.IdPhongthuc);
                    table.ForeignKey(
                        name: "FK_phuongthucthanhtoan_LichSuThanhToan_IdThanhToan",
                        column: x => x.IdThanhToan,
                        principalTable: "LichSuThanhToan",
                        principalColumn: "IdThanhtoan",
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
                name: "hopdong",
                columns: table => new
                {
                    IdHopDong = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ngaydangki = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ngaykethuc = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_hopdong", x => x.IdHopDong);
                    table.ForeignKey(
                        name: "FK_hopdong_DichVu_IdHopDong",
                        column: x => x.IdHopDong,
                        principalTable: "DichVu",
                        principalColumn: "IdDichvu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_hopdong_PT_MaPT",
                        column: x => x.MaPT,
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
                    MaPT = table.Column<string>(type: "nvarchar(max)", nullable: false),
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
                name: "HoaDon",
                columns: table => new
                {
                    IdHoadon = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaNhanVien = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachhang = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthaithanhtoan = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Trangthaihoadon = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaylap = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Tongtien = table.Column<double>(type: "float", nullable: false),
                    Giamgia = table.Column<float>(type: "real", nullable: false),
                    Thanhtien = table.Column<double>(type: "float", nullable: false),
                    Tongtienthanhtoan = table.Column<double>(type: "float", nullable: false),
                    IdThanhToan = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_HoaDon", x => x.IdHoadon);
                    table.ForeignKey(
                        name: "FK_HoaDon_HoaDonChiTiet_IdHoadon",
                        column: x => x.IdHoadon,
                        principalTable: "HoaDonChiTiet",
                        principalColumn: "IdHoadonchitiet",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_LichSuThanhToan_IdThanhToan",
                        column: x => x.IdThanhToan,
                        principalTable: "LichSuThanhToan",
                        principalColumn: "IdThanhtoan",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_HoaDon_NhanVien_MaNhanVien",
                        column: x => x.MaNhanVien,
                        principalTable: "NhanVien",
                        principalColumn: "MaNhanVien",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "ThongKeChiTiet",
                columns: table => new
                {
                    MaPhieuCT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaPhieu = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    MaThietBi = table.Column<string>(type: "nvarchar(450)", nullable: false),
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
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_PhieuThongKe_MaPhieu",
                        column: x => x.MaPhieu,
                        principalTable: "PhieuThongKe",
                        principalColumn: "MaPhieu",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_ThongKeChiTiet_ThietBi_MaThietBi",
                        column: x => x.MaThietBi,
                        principalTable: "ThietBi",
                        principalColumn: "MaThietBi",
                        onDelete: ReferentialAction.Cascade);
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
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HopdongIdHopDong = table.Column<string>(type: "nvarchar(450)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_KhachHang", x => x.IdKhachhang);
                    table.ForeignKey(
                        name: "FK_KhachHang_HoaDon_IdKhachhang",
                        column: x => x.IdKhachhang,
                        principalTable: "HoaDon",
                        principalColumn: "IdHoadon",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_KhachHang_hopdong_HopdongIdHopDong",
                        column: x => x.HopdongIdHopDong,
                        principalTable: "hopdong",
                        principalColumn: "IdHopDong");
                });

            migrationBuilder.CreateTable(
                name: "DatLich",
                columns: table => new
                {
                    IdPhieudatlich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdKhachhang = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Ngaydatlich = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatLich", x => x.IdPhieudatlich);
                    table.ForeignKey(
                        name: "FK_DatLich_KhachHang_IdKhachhang",
                        column: x => x.IdKhachhang,
                        principalTable: "KhachHang",
                        principalColumn: "IdKhachhang",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "DatLichChitiet",
                columns: table => new
                {
                    IdCT = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    IdPhieudatlich = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Trangthai = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Ngaydatlich = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gioibatdau = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Gioketthuc = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Ghichu = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatLichChitiet", x => x.IdCT);
                    table.ForeignKey(
                        name: "FK_DatLichChitiet_DatLich_IdPhieudatlich",
                        column: x => x.IdPhieudatlich,
                        principalTable: "DatLich",
                        principalColumn: "IdPhieudatlich",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_DatLich_IdKhachhang",
                table: "DatLich",
                column: "IdKhachhang");

            migrationBuilder.CreateIndex(
                name: "IX_DatLichChitiet_IdPhieudatlich",
                table: "DatLichChitiet",
                column: "IdPhieudatlich");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_IdThanhToan",
                table: "HoaDon",
                column: "IdThanhToan");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDon_MaNhanVien",
                table: "HoaDon",
                column: "MaNhanVien");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdDichvu",
                table: "HoaDonChiTiet",
                column: "IdDichvu");

            migrationBuilder.CreateIndex(
                name: "IX_HoaDonChiTiet_IdGG",
                table: "HoaDonChiTiet",
                column: "IdGG");

            migrationBuilder.CreateIndex(
                name: "IX_hopdong_MaPT",
                table: "hopdong",
                column: "MaPT");

            migrationBuilder.CreateIndex(
                name: "IX_KhachHang_HopdongIdHopDong",
                table: "KhachHang",
                column: "HopdongIdHopDong");

            migrationBuilder.CreateIndex(
                name: "IX_LichLamViec_PTMaPT",
                table: "LichLamViec",
                column: "PTMaPT");

            migrationBuilder.CreateIndex(
                name: "IX_phuongthucthanhtoan_IdThanhToan",
                table: "phuongthucthanhtoan",
                column: "IdThanhToan");

            migrationBuilder.CreateIndex(
                name: "IX_ThietBi_MaLoaiThietBi",
                table: "ThietBi",
                column: "MaLoaiThietBi");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_MaPhieu",
                table: "ThongKeChiTiet",
                column: "MaPhieu");

            migrationBuilder.CreateIndex(
                name: "IX_ThongKeChiTiet_MaThietBi",
                table: "ThongKeChiTiet",
                column: "MaThietBi");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatLichChitiet");

            migrationBuilder.DropTable(
                name: "LichLamViec");

            migrationBuilder.DropTable(
                name: "phuongthucthanhtoan");

            migrationBuilder.DropTable(
                name: "ThongKeChiTiet");

            migrationBuilder.DropTable(
                name: "User");

            migrationBuilder.DropTable(
                name: "DatLich");

            migrationBuilder.DropTable(
                name: "PhieuThongKe");

            migrationBuilder.DropTable(
                name: "ThietBi");

            migrationBuilder.DropTable(
                name: "KhachHang");

            migrationBuilder.DropTable(
                name: "LoaiThietBi");

            migrationBuilder.DropTable(
                name: "HoaDon");

            migrationBuilder.DropTable(
                name: "hopdong");

            migrationBuilder.DropTable(
                name: "HoaDonChiTiet");

            migrationBuilder.DropTable(
                name: "LichSuThanhToan");

            migrationBuilder.DropTable(
                name: "NhanVien");

            migrationBuilder.DropTable(
                name: "PT");

            migrationBuilder.DropTable(
                name: "DichVu");

            migrationBuilder.DropTable(
                name: "giamgia");
        }
    }
}
