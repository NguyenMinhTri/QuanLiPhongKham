namespace Model.EF
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class QuanLyPhongKham : DbContext
    {
        public QuanLyPhongKham()
            : base("name=QuanLyPhongKham")
        {
        }

        public virtual DbSet<Benh_Don_Thuoc> Benh_Don_Thuoc { get; set; }
        public virtual DbSet<BenhNhan> BenhNhans { get; set; }
        public virtual DbSet<CT_BenhDonThuoc> CT_BenhDonThuoc { get; set; }
        public virtual DbSet<CT_HoaDon> CT_HoaDon { get; set; }
        public virtual DbSet<CT_PhieuKham> CT_PhieuKham { get; set; }
        public virtual DbSet<DonViTinh> DonViTinhs { get; set; }
        public virtual DbSet<HoaDon> HoaDons { get; set; }
        public virtual DbSet<KetQuaThuoc> KetQuaThuocs { get; set; }
        public virtual DbSet<KhamChuyenKhoa> KhamChuyenKhoas { get; set; }
        public virtual DbSet<LoaiChuyenKhoa> LoaiChuyenKhoas { get; set; }
        public virtual DbSet<PhieuKhamBenh> PhieuKhamBenhs { get; set; }
        public virtual DbSet<SoBanThuoc> SoBanThuocs { get; set; }
        public virtual DbSet<SoThuoc> SoThuocs { get; set; }
        public virtual DbSet<DangKyPhieuKham> DangKyPhieuKhams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<LoaiChuyenKhoa>()
                .Property(e => e.TenCK)
                .IsFixedLength();
        }
    }
}
