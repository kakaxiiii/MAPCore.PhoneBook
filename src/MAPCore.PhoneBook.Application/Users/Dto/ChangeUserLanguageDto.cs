using System.ComponentModel.DataAnnotations;

namespace MAPCore.PhoneBook.Users.Dto
{
    public class ChangeUserLanguageDto
    {
        [Required]
        public string LanguageName { get; set; }
    }
}