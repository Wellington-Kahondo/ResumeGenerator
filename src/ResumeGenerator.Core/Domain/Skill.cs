using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace ResumeGenerator.Domain
{
    public class Skill : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual int? ProficiencyLevel { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid SectionId { get; set; }
        public Section Section { get; set; }
    }
}
