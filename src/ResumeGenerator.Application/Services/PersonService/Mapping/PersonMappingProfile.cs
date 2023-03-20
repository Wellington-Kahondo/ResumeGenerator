using AutoMapper;
using ResumeGenerator.Authorization.Users;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.Helpers;
using ResumeGenerator.Services.PersonService.Dtos;
using ResumeGenerator.Users.Dto;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Profile = AutoMapper.Profile;

namespace ResumeGenerator.Services.PersonService.Mapping
{

    public class PersonMappingProfile : Profile
    {
        public PersonMappingProfile()
        {
            CreateMap<User, PersonDto>()
                .ForMember(user => user.UserName, m => m.MapFrom(opt => opt.UserName))
                .ForMember(user => user.Password, m => m.MapFrom(opt => opt.Password))
                .ForMember(user => user.EmailAddress, m => m.MapFrom(opt => opt.EmailAddress))
                .ForMember(user => user.FirstName, m => m.MapFrom(opt => opt.Name))
                .ForMember(user => user.Surname, m => m.MapFrom(opt => opt.Surname));

            CreateMap<PersonDto, User>()
                .ForMember(user => user.UserName, m => m.MapFrom(opt => opt.UserName))
                .ForMember(user => user.Password, m => m.MapFrom(opt => opt.Password))
                .ForMember(user => user.EmailAddress, m => m.MapFrom(opt => opt.EmailAddress))
                .ForMember(user => user.Name, m => m.MapFrom(opt => opt.FirstName))
                .ForMember(user => user.Surname, m => m.MapFrom(opt => opt.Surname))
                .ForMember(user => user.Id, e => e.Ignore());

            CreateMap<User, PersonInputDto>();
            CreateMap<PersonInputDto, User>()
                .ForMember(user => user.Id, e => e.Ignore());

            CreateMap<Person, PersonDto>()
               .ForMember(x => x.UserName, e => e.Ignore())
               .ForMember(x => x.Password, e => e.Ignore())
               .ForMember(x => x.TitleText, m => m.MapFrom(e => e.Title != null ? e.Title.GetEnumDescription() : null))
               .ForMember(x => x.GenderText, m => m.MapFrom(e => e.Gender != null ? e.Gender.GetEnumDescription() : null))
               .ForMember(x => x.RaceText, m => m.MapFrom(e => e.Race != null ? e.Race.GetEnumDescription() : null));

            CreateMap<PersonDto, Person>()
                .ForMember(x => x.Id, e => e.Ignore());
        }
    }
}
