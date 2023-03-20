using Abp.Application.Services.Dto;

namespace ResumeGenerator.Roles.Dto
{
    public class PagedRoleResultRequestDto : PagedResultRequestDto
    {
        public string Keyword { get; set; }
    }
}

