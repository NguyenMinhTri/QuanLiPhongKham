namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class CT_PhieuKham
    {
        [Key]
        public int MaCTPK { get; set; }

        public int? MaPK { get; set; }

        [StringLength(50)]
        public string TenXN { get; set; }

        [StringLength(50)]
        public string NoiDung { get; set; }

        public int? Status { get; set; }
    }
}
