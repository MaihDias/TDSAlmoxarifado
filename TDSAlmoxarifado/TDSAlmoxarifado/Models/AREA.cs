//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace TDSAlmoxarifado.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class AREA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AREA()
        {
            this.COLABORADOR = new HashSet<COLABORADOR>();
        }
    
        public int AREID { get; set; }
        public string AREDESCRICAO { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COLABORADOR> COLABORADOR { get; set; }
    }
}
