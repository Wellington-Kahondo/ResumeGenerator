using System.ComponentModel.DataAnnotations;

namespace ResumeGenerator.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}