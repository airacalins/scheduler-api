namespace API.Controllers.ViewModels
{
    public class UserViewModel
    {
        public UserViewModel(string userName, string token)
        {
            UserName = userName;
            Token = token;
        }


        public string UserName { get; set; } = string.Empty;

        public string Token { get; set; } = string.Empty;
    }
}