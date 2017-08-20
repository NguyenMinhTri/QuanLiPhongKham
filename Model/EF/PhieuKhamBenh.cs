namespace Model.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("PhieuKhamBenh")]
    public partial class PhieuKhamBenh
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MaPKB { get; set; }

        public int? MaBN { get; set; }

        public int? STT { get; set; }

        [StringLength(50)]
        public string LyDo { get; set; }

        [StringLength(50)]
        public string BacSi { get; set; }
    }
}
