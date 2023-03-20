using Abp.Application.Services.Dto;
using Abp.Domain.Entities.Auditing;
using AutoMapper;
using ResumeGenerator.Domain;
using ResumeGenerator.Domain.Enums;
using ResumeGenerator.Services.CertificationService.Dtos;
using ResumeGenerator.Services.EducationServices.Dtos;
using ResumeGenerator.Services.Helpers;
using ResumeGenerator.Services.SkillService.Dtos;
using ResumeGenerator.Services.SummaryService.Dtos;
using ResumeGenerator.Services.WorkExperienceService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace ResumeGenerator.Services.SectionService.Dtos
{
    [AutoMap(typeof(Section))]
    public class SectionDto : EntityDto<Guid>
    {
        public RefListSection Title { get; set; }
        public Guid ResumeId { get; set; }
        public string TitleText
        {
            get
            {
                return Title.GetEnumDescription();
            }
        }
        public ProfileDto Profile { get; set; }
        public List<WorkExperienceDto> WorkExperiences { get; set; }
        public List<EducationDto> Educations { get; set; }
        public List<SkillDto> Skills { get; set; }
        public List<CertificationDto> Certifications { get; set; }
    }
}
