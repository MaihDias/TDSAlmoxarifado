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
    
    public partial class ITENSSAIDA
    {
        public int ITSID { get; set; }
        public int ITSQUANTIDADE { get; set; }
        public int SAIID { get; set; }
        public int PROID { get; set; }
    
        public virtual PRODUTO PRODUTO { get; set; }
        public virtual SAIDA SAIDA { get; set; }
    }
}
