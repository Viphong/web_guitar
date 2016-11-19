namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ChuDe")]
    public partial class ChuDe
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ChuDe()
        {
            BaiGiang = new HashSet<BaiGiang>();
        }

        [Key]
        public int MaChuDe { get; set; }

        [StringLength(20)]
        public string TenChuDe { get; set; }

        [StringLength(30)]
        public string MoTaCD { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BaiGiang> BaiGiang { get; set; }
    }
}
