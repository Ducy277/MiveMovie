//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MineMovie_Nhom7_CNPM.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class DS_YEU_THICH
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DS_YEU_THICH()
        {
            this.KH_PHIM_DSYT = new HashSet<KH_PHIM_DSYT>();
        }
    
        public int ID_DS { get; set; }
        public Nullable<int> ID_ND { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<KH_PHIM_DSYT> KH_PHIM_DSYT { get; set; }
        public virtual NGUOI_DUNG NGUOI_DUNG { get; set; }
    }
}
