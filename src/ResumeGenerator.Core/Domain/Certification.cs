using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;

namespace ResumeGenerator.Domain
{
    public class Certification : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string IssuingOrganization { get; set; }
        public virtual DateTime? CertificationDate { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid SectionId { get; set; }
        public Section Section { get; set; }
    }
}
