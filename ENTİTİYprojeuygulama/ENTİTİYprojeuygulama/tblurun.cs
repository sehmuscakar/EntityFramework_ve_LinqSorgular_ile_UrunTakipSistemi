//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ENTİTİYprojeuygulama
{
    using System;
    using System.Collections.Generic;
    
    public partial class tblurun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblurun()
        {
            this.tblsatiş = new HashSet<tblsatiş>();
        }
    
        public int URUNİD { get; set; }
        public string URUNAD { get; set; }
        public string MARKA { get; set; }
        public Nullable<short> STOK { get; set; }
        public Nullable<decimal> FİYAT { get; set; }
        public Nullable<bool> DURUM { get; set; }
        public Nullable<int> KATEGORİ { get; set; }
    
        public virtual tblkategori tblkategori { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatiş> tblsatiş { get; set; }
    }
}
