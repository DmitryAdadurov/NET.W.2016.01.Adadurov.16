﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Task1.Logic.Shawarma
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ShawarmaContext : DbContext
    {
        public ShawarmaContext()
            : base("name=ShawarmaContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Ingredient> Ingredient { get; set; }
        public virtual DbSet<IngredientCategory> IngredientCategory { get; set; }
        public virtual DbSet<OrderHeader> OrderHeader { get; set; }
        public virtual DbSet<PriceController> PriceController { get; set; }
        public virtual DbSet<Seller> Seller { get; set; }
        public virtual DbSet<SellingPoint> SellingPoint { get; set; }
        public virtual DbSet<SellingPointCategory> SellingPointCategory { get; set; }
        public virtual DbSet<Shawarma> Shawarma { get; set; }
        public virtual DbSet<ShawarmaRecipe> ShawarmaRecipe { get; set; }
        public virtual DbSet<TimeController> TimeController { get; set; }
        public virtual DbSet<OrderDetails> OrderDetails { get; set; }
    }
}