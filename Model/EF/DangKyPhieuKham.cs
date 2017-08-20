namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DangKyPhieuKham")]
    public partial class DangKyPhieuKham
    {
        [Key]
        public int MaPDK { get; set; }

        public int? MaBN { get; set; }

        [StringLength(50)]
        public string LyDo { get; set; }

        public int STT { get; set; }

        [Column(TypeName = "date")]
        public DateTime NgayKham { get; set; }

        public int? Status { get; set; }

        public int? MaNV { get; set; }

        [StringLength(50)]
        public string KetQua { get; set; }
    }
}
