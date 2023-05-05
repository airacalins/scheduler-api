namespace API.Controllers.InputModels
{
    public class LoginUserInputModel
    {
        public string Email { get; set; } = string.Empty!;

        public string Password { get; set; } = string.Empty!;
    }
}