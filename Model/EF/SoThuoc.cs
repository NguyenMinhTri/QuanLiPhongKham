namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SoThuoc")]
    public partial class SoThuoc
    {
        [Key]
        public int MaThuoc { get; set; }

        [StringLength(50)]
        public string TenThuoc { get; set; }

        [StringLength(50)]
        public string NhaSanXuat { get; set; }

        public double? GiaBan { get; set; }

        public double? GiaNhap { get; set; }

        public int? SoLuong { get; set; }

        public int? SoLuongDaBan { get; set; }

        [StringLength(50)]
        public string DonViTinh { get; set; }

        public int? BHYT { get; set; }

        public int? TrangThai { get; set; }
    }
}
