using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace ResumeGenerator.Domain
{
    public class WorkExperience : Entity<Guid>
    {
        public  virtual string Title { get; set; }
        public  virtual string CompanyName { get; set; }
        public  virtual DateTime StartDate { get; set; }
        public  virtual DateTime? EndDate { get; set; }
        public  virtual string Description { get; set; }
        public  virtual Guid SectionId { get; set; }
        public Section Section { get; set; }
    }
}
