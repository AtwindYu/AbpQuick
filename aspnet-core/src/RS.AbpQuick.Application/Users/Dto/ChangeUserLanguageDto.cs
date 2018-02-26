using System.ComponentModel.DataAnnotations;

namespace RS.AbpQuick.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}