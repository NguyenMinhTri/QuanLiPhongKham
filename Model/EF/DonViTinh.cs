namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("DonViTinh")]
    public partial class DonViTinh
    {
        [Key]
        public int MaDVT { get; set; }

        [StringLength(50)]
        public string TenDVT { get; set; }
    }
}
