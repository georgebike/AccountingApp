//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AccountingApp
{
    using System;
    using System.Collections.Generic;
    
    public partial class Furnizori
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Furnizori()
        {
            this.Articole = new HashSet<Articole>();
        }
    
        public int Index { get; set; }
        public string Denumire { get; set; }
        public string CUI { get; set; }
        public string Localitate { get; set; }
        public string Judet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Articole> Articole { get; set; }
    }
}
