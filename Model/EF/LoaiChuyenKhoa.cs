namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiChuyenKhoa")]
    public partial class LoaiChuyenKhoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaCK { get; set; }

        [StringLength(10)]
        public string TenCK { get; set; }
    }
}
