namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Benh_Don_Thuoc
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaBDT { get; set; }

        [StringLength(50)]
        public string MaBN { get; set; }

        [StringLength(50)]
        public string KetLuan { get; set; }
    }
}
