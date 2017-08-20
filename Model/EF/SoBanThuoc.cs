namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SoBanThuoc")]
    public partial class SoBanThuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaSBT { get; set; }

        public int? MaThuoc { get; set; }

        [Column(TypeName = "date")]
        public DateTime? NgayBan { get; set; }

        public int? SoLuong { get; set; }
    }
}
