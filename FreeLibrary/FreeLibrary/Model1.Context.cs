﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FreeLibrary
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class KütüphaneEntities3 : DbContext
    {
        public KütüphaneEntities3()
            : base("name=KütüphaneEntities3")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ayarlar> Ayarlars { get; set; }
        public virtual DbSet<Kitap_Ekleme> Kitap_Eklemes { get; set; }
        public virtual DbSet<Ödünç_Kitap_Verme> Ödünç_Kitap_Verme { get; set; }
        public virtual DbSet<Üye_Ekleme> Üye_Ekleme { get; set; }
    }
}
