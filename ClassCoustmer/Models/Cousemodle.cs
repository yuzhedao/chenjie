namespace ClassCoustmer.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Cousemodle : DbContext
    {
        public Cousemodle()
            : base("name=Cousemodle")
        {
        }

        public virtual DbSet<Classes> Classes { get; set; }
        public virtual DbSet<CourseArrange> CourseArrange { get; set; }
        public virtual DbSet<CourseSubeject> CourseSubeject { get; set; }
        public virtual DbSet<Student> Student { get; set; }
        public virtual DbSet<Teachers> Teachers { get; set; }
        public virtual DbSet<Users> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CourseArrange>()
                .Property(e => e.ClassId)
                .IsFixedLength();

            modelBuilder.Entity<CourseArrange>()
                .Property(e => e.CourseSubjectId)
                .IsFixedLength();

            modelBuilder.Entity<CourseArrange>()
                .Property(e => e.TeacherId)
                .IsFixedLength();

            modelBuilder.Entity<CourseSubeject>()
                .Property(e => e.Name)
                .IsFixedLength();


            modelBuilder.Entity<Student>()
                .Property(e => e.name)
                .IsFixedLength();

            modelBuilder.Entity<Student>()
                .Property(e => e.ClassId)
                .IsFixedLength();

           
        }
    }
}
