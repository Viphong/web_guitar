namespace Models.Framework
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("LoaiBlog")]
    public partial class LoaiBlog
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public LoaiBlog()
        {
            Blog = new HashSet<Blog>();
        }

        [Key]
        public int MaLoaiBlog { get; set; }

        [StringLength(50)]
        public string TenLoaiBlog { get; set; }

        [StringLength(80)]
        public string MotaBlog { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Blog> Blog { get; set; }
    }
}
