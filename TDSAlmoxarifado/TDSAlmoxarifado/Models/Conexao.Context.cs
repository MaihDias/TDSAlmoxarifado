﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class BDTDSAlmoxarifado : DbContext
    {
        public BDTDSAlmoxarifado()
            : base("name=BDTDSAlmoxarifado")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<AREA> AREA { get; set; }
        public virtual DbSet<COLABORADOR> COLABORADOR { get; set; }
        public virtual DbSet<ENTRADA> ENTRADA { get; set; }
        public virtual DbSet<ITENSENTRADA> ITENSENTRADA { get; set; }
        public virtual DbSet<ITENSSAIDA> ITENSSAIDA { get; set; }
        public virtual DbSet<PRODUTO> PRODUTO { get; set; }
        public virtual DbSet<SAIDA> SAIDA { get; set; }
        public virtual DbSet<ProdutosSaida> ProdutosSaida { get; set; }
    }
}
