using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using ResumeGenerator.Authorization.Roles;
using ResumeGenerator.Authorization.Users;
using ResumeGenerator.MultiTenancy;
using ResumeGenerator.Domain;

namespace ResumeGenerator.EntityFrameworkCore
{
    public class ResumeGeneratorDbContext : AbpZeroDbContext<Tenant, Role, User, ResumeGeneratorDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Certification> Certifications { get; set; }
        public DbSet<Education> Education { get; set; }
        public DbSet<Person> Persons { get; set; }
        public DbSet<Skill> Skills { get; set; }
        public DbSet<StoredFile> StoredFiles { get; set; }
        public DbSet<Section> Sections { get; set; }
        public DbSet<Resume> Resumes { get; set; }
        public DbSet<WorkExperience> WorkExperiences { get; set; }
        public DbSet<Profile> Profile { get; set; }

        public ResumeGeneratorDbContext(DbContextOptions<ResumeGeneratorDbContext> options)
            : base(options)
        {
        }
    }
}
