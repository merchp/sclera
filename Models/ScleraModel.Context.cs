﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sclera2.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class ScleraDB2Entities : DbContext
    {
        public ScleraDB2Entities()
            : base("name=ScleraDB2Entities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Gear> Gears { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Respondent> Respondents { get; set; }
        public virtual DbSet<Survey> Surveys { get; set; }
        public virtual DbSet<Survey_Response> Survey_Response { get; set; }
        public virtual DbSet<Track> Tracks { get; set; }
    }
}
