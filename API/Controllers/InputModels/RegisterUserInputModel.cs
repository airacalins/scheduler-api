using System.ComponentModel.DataAnnotations;
using Domain;

namespace API.Controllers.InputModels
{
    public class RegisterUserInputModel
    {
        public string FirstName { get; set; } = string.Empty;

        public string LastName { get; set; } = string.Empty;

        [Required]
        public string UserName { get; set; } = string.Empty;

        [Required]
        [EmailAddress]
        public string Email { get; set; } = string.Empty;

        [Required]
        [RegularExpression("(?=.*\\d)(?=.*[a-z])(?=.*[A-Z]).{4,8}$", ErrorMessage = "Password must be complex")]

        public string Password { get; set; } = string.Empty;

        public User ToUserEntity()
        {
            return new User
            {
                FirstName = FirstName,
                LastName = LastName,
                UserName = UserName,
                Email = Email,
            };
        }
    }
}