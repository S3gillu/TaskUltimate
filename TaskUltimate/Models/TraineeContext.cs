using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace TaskUltimate.Models
{
    public class TraineeContext:DbContext
    {
        public TraineeContext():base("myConn")
        {

        }
        public DbSet<Trainee> Trainees { get; set; }
        public DbSet<TraineeDetail>TraineeDetails { get; set; }
        public DbSet<TraineeVM> TraineeVMs { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.HasDefaultSchema("Test");


            modelBuilder.Entity<TraineeDetail>()
                .HasKey(e => e.LearnerId);


            modelBuilder.Entity<Trainee>()
                .HasRequired(c => c.Students)
                .WithRequiredPrincipal(c => c.Learn);
        }
    }
}