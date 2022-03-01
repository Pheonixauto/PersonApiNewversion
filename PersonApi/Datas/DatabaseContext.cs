using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PersonApi.Configurations.Entities;
using PersonApi.Models;

namespace PersonApi.Datas
{
    public class DatabaseContext : IdentityDbContext<ApiUser>
    {
        public DatabaseContext(DbContextOptions dbContextOptions) : base(dbContextOptions) { }
        public  DbSet<InformationEmployee> NhanViens { get; set; }
        public DbSet<InformationDepartment> PhongBans { get; set; }
        public DbSet<InformationRelative> NguoiThans { get; set; }
        public DbSet<InformationSkill> KiNangs { get; set; }
        public DbSet<InformationSalary> Luongs { get; set; }
        public DbSet<InformationLearning> HocVans { get; set; }

       

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            //Many To Many: Nhan Vien -Ki Nang
            modelBuilder.Entity<InformationEmployee_Skill>()
                        .HasKey(t => new { t.EmployId, t.SkillId });

            modelBuilder.Entity<InformationEmployee_Skill>()
                        .HasOne(pt => pt.ThongTinNhanVien)
                        .WithMany(p => p.ThongTinNhanVien_KiNangs)
                        .HasForeignKey(pt => pt.EmployId);

            modelBuilder.Entity<InformationEmployee_Skill>()
                        .HasOne(pt => pt.ThongTinKiNang)
                        .WithMany(t => t.ThongTinNhanVien_KiNangs)
                        .HasForeignKey(pt => pt.SkillId);


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
            modelBuilder.Entity<InformationEmployee_Learning>()
                        .HasKey(t => new { t.EmployeeId, t.StudyId });

            modelBuilder.Entity<InformationEmployee_Learning>()
                        .HasOne(pt => pt.ThongTinHocVan)
                        .WithMany(p => p.ThongTinNhanVien_HocVans)
                        .HasForeignKey(pt => pt.StudyId);

            modelBuilder.Entity<InformationEmployee_Learning>()
                        .HasOne(pt => pt.ThongTinNhanVien)
                        .WithMany(t => t.ThongTinNhanVien_HocVans)
                        .HasForeignKey(pt => pt.EmployeeId);

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
