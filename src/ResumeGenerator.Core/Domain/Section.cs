using Abp.Domain.Entities;
using Abp.Domain.Entities.Auditing;
using ResumeGenerator.Domain.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace ResumeGenerator.Domain
{
    public class Section : Entity<Guid>
    {
        public RefListSection Title { get; set; }
        public Guid ResumeId { get; set; }
        public Resume Resume { get; set; }
        //[NotMapped]
        public List<WorkExperience> WorkExperiences { get; set; }
        //[NotMapped]
        public List<Education> Educations { get; set; }
        //[NotMapped]
        public List<Skill> Skills { get; set; }
        //[NotMapped]
        public List<Certification> Certifications { get; set; }
        public List<Profile> Profiles { get; set; }
    }
}
