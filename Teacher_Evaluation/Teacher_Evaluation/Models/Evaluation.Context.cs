﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Teacher_Evaluation.Models
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class EvaluationDataContext : DbContext
    {
        public EvaluationDataContext()
            : base("name=EvaluationDataContext")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<Course> Courses { get; set; }
        public virtual DbSet<Evaluation> Evaluations { get; set; }
        public virtual DbSet<Participant> Participants { get; set; }
        public virtual DbSet<Question> Questions { get; set; }
        public virtual DbSet<Section> Sections { get; set; }
        public virtual DbSet<Teacher> Teachers { get; set; }
    }
}