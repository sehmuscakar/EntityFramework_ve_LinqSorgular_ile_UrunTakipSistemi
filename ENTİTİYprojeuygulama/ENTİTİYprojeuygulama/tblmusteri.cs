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
    
    public partial class tblmusteri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tblmusteri()
        {
            this.tblsatiş = new HashSet<tblsatiş>();
        }
    
        public int MUSTERİİD { get; set; }
        public string MUSTERİAD { get; set; }
        public string MUSTERİSOYAD { get; set; }
        public string SEHİR { get; set; }
        public Nullable<bool> DURUM { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tblsatiş> tblsatiş { get; set; }
    }
}
