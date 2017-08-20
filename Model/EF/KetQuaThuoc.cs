namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("KetQuaThuoc")]
    public partial class KetQuaThuoc
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPDK { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaThuoc { get; set; }

        public int? SoLuong { get; set; }

        [StringLength(50)]
        public string LieuDung { get; set; }

        [StringLength(50)]
        public string CachDung { get; set; }

        [StringLength(50)]
        public string GhiChu { get; set; }
    }
}
