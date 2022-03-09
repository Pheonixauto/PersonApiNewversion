using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonApi.Configurations.Entities;
using PersonApi.DTO;
using PersonApi.Models;

namespace PersonApi.Datas
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions)
        {
            //this.ChangeTracker.LazyLoadingEnabled = true;
        }
        public DbSet<InformationEmployee> informationEmployees { get; set; }
        public DbSet<InformationDepartment> informationDepartments { get; set; }
        public DbSet<InformationRelative> informationRelatives { get; set; }
        public DbSet<InformationSkill> informationSkills { get; set; }
        public DbSet<InformationSalary> informationSalaries { get; set; }
        public DbSet<InformationLearning> informationLearnings { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<InformationSkill>()
                .HasKey(e => e.Id);

            //Many To Many: Nhan Vien -Ki Nang
            modelBuilder.Entity<InformationEmployeeSkill>()
                        .HasKey(t => new { t.EmployId, t.SkillId });

            modelBuilder.Entity<InformationEmployeeSkill>()
                        .HasOne(pt => pt.InformationEmployee)
                        .WithMany(p => p.InformationEmployeeSkills)
                        .HasForeignKey(pt => pt.EmployId);

            modelBuilder.Entity<InformationEmployeeSkill>()
                        .HasOne(pt => pt.InformationSkill)
                        .WithMany(t => t.InformationEmployeeSkills)
                        .HasForeignKey(pt => pt.SkillId);

            // Unique Table EmployeeSkill
            modelBuilder.Entity<InformationEmployeeSkill>()
                        .HasIndex(c => new { c.EmployId, c.SkillId })
                        .IsUnique();

            // modelBuilder.Entity<InformationEmployee>()
            //.HasMany(p => p.InformationSkills)
            //.WithMany(p => p.InformationEmployees)
            //.UsingEntity<InformationEmployee_Skill>(
            //    j => j
            //        .HasOne(pt => pt.ThongTinKiNang)
            //        .WithMany(t => t.ThongTinNhanVien_KiNangs)
            //        .HasForeignKey(pt => pt.SkillId),
            //    j => j
            //        .HasOne(pt => pt.ThongTinNhanVien)
            //        .WithMany(p => p.ThongTinNhanVien_KiNangs)
            //        .HasForeignKey(pt => pt.EmployId),
            //    j =>
            //    {
            //        //j.Property(pt => pt.PublicationDate).HasDefaultValueSql("CURRENT_TIMESTAMP");
            //        j.HasKey(t => new { t.EmployId, t.SkillId});
            //    });

            // Many To Many : Nhan Vien - Hoc Van
            modelBuilder.Entity<InformationEmployeeLearning>()
                        .HasKey(t => new { t.EmployeeId, t.StudyId });

            modelBuilder.Entity<InformationEmployeeLearning>()
                        .HasOne(pt => pt.InformationLearning)
                        .WithMany(p => p.InformationEmployeeLearnings)
                        .HasForeignKey(pt => pt.StudyId);

            modelBuilder.Entity<InformationEmployeeLearning>()
                        .HasOne(pt => pt.InformationEmployee)
                        .WithMany(t => t.InformationEmployeeLearnings)
                        .HasForeignKey(pt => pt.EmployeeId);

            // Unique Table Salary
            modelBuilder.Entity<InformationSalary>()
                        .HasIndex(p => new { p.DateTime, p.EmployeeId })
                        .IsUnique();

           

            // Seed data employee
            modelBuilder.ApplyConfiguration(new EmployeeConfig());
            //seed data study
            modelBuilder.ApplyConfiguration(new LearningConfig());
            //seed data skill
            modelBuilder.ApplyConfiguration(new SkillConfig());
            //seed data Salary
            modelBuilder.ApplyConfiguration(new SalaryConfig());
            //seed data relatives
            modelBuilder.ApplyConfiguration(new RelativesConfig());
            //seed data Department
            modelBuilder.ApplyConfiguration(new DepartmentConfig());
            //seed data EmployeesSkills
            modelBuilder.ApplyConfiguration(new EmployeeSkillsConfig());
            // seed role
            modelBuilder.ApplyConfiguration(new RoleConfiguration());
            // seed EmployeeLearning
            modelBuilder.ApplyConfiguration(new EmployeeLearningConfig());
        }
    }
}
