using AutoMapper;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.Helpers;
using ResumeGenerator.Services.SectionService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Profile = AutoMapper.Profile;

namespace ResumeGenerator.Services.SectionService.Mapping
{
    public class SectionMappingProfile : Profile
    {
        public SectionMappingProfile()
        {
            CreateMap<Section, SectionDto>()
                .ForMember(x => x.Educations, m => m.MapFrom(e => e.Educations ?? null))
                .ForMember(x => x.Skills, m => m.MapFrom(e => e.Skills ?? null))
                .ForMember(x => x.Certifications, m => m.MapFrom(e => e.Certifications ?? null))
                .ForMember(x => x.WorkExperiences, m => m.MapFrom(e => e.WorkExperiences ?? null))
                 .ForMember(x => x.TitleText, m => m.MapFrom(e => e.Title.GetEnumDescription()));

            CreateMap<SectionDto, Section>()
                .ForMember(x => x.Educations, m => m.MapFrom(e => e.Educations ?? null))
                .ForMember(x => x.Skills, m => m.MapFrom(e => e.Skills ?? null))
                .ForMember(x => x.Certifications, m => m.MapFrom(e => e.Certifications ?? null))
                .ForMember(x => x.WorkExperiences, m => m.MapFrom(e => e.WorkExperiences ?? null))
                .ForMember(x => x.Id, m => m.Ignore());
        }
    }
}
