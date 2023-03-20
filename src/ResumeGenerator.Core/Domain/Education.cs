using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.Text;
using static System.Collections.Specialized.BitVector32;

namespace ResumeGenerator.Domain
{
    public class Education : Entity<Guid>
    {
        public virtual string Degree { get; set; }
        public virtual string SchoolName { get; set; }
        public virtual DateTime? GraduationDate { get; set; }
        public virtual string Major { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid SectionId { get; set; }
        public Section Section { get; set; }
    }
}
