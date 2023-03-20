using System.Threading.Tasks;
using ResumeGenerator.Configuration.Dto;

namespace ResumeGenerator.Configuration
{
    public interface IConfigurationAppService
    {
        Task ChangeUiTheme(ChangeUiThemeInput input);
    }
}
