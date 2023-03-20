using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Domain
{
    public class Profile : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid SectionId { get; set; }
        public Section Section { get; set; }
    }
}
