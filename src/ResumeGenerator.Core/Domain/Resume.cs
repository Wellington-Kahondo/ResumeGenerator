using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResumeGenerator.Domain
{
    public class Resume : Entity<Guid>
    {
        public virtual string Name { get; set; }
        public virtual string Description { get; set; }
        public virtual Guid PersonId { get; set; }
        public Person Person { get; set; }
        public List<Section> Sections { get; set; }
       // [NotMapped]
        public List<Profile> Profile { get; set; }
    }
}
