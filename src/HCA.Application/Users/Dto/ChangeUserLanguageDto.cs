using System.ComponentModel.DataAnnotations;

namespace HCA.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}