using System.ComponentModel.DataAnnotations;

namespace Learning_phone.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}