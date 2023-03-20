using AutoMapper;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.StoredFileService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using Profile = AutoMapper.Profile;

namespace ResumeGenerator.Services.StoredFileService.Mapping
{
    public class StoredFileMappingProfile : Profile
    {
        public StoredFileMappingProfile()
        {
            CreateMap<StoredFileDto, StoredFile>()
                .ForMember(x => x.Id, e => e.Ignore());
        }
    }
}
