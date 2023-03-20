using Abp.Domain.Repositories;
using ResumeGenerator.Domain;
using ResumeGenerator.Services.SectionService.Dtos;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ResumeGenerator.Services.SectionService
{
    public class SectionAppService : ResumeGeneratorAppServiceBase
    {
        private readonly IRepository<Section, Guid> _sectionRepository;
        public SectionAppService(IRepository<Section, Guid> sectionRepository)
        {
            _sectionRepository = sectionRepository;
        }

        public async Task<SectionDto> CreateSection(SectionInputDto input)
        {
            var section = ObjectMapper.Map<Section>(input);
            return ObjectMapper.Map<SectionDto>(
                await _sectionRepository.InsertOrUpdateAsync(section));
        }


        public async Task<SectionDto> GetSection(Guid id)
        {
            var section = await _sectionRepository.GetAsync(id);
            return ObjectMapper.Map<SectionDto>(section);
        }

        //public async Task<SectionDto> CreateSection(CreateSectionDto input)
        //{
        //    var section = ObjectMapper.Map<CreateSectionDto, Section>(input);
        //    section = await _sectionRepository.InsertAsync(section, autoSave: true);
        //    return ObjectMapper.Map<SectionDto>(section);
        //}

        public async Task<SectionDto> UpdateSection(SectionInputDto input)
        {
            var section = await _sectionRepository.GetAsync(input.Id);
            ObjectMapper.Map(input, section);
            section = await _sectionRepository.UpdateAsync(section);
            return ObjectMapper.Map<SectionDto>(section);
        }

        public async Task DeleteSection(Guid id)
        {
            await _sectionRepository.DeleteAsync(id);
        }
    }
}
