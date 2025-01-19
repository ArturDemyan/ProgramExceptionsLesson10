namespace ExceptionsLesson10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string login = "NewUserArtur!1";
            string password = "asdfdfgdgfghhgh1";
            string confirmPassword=" ";
            UserRegistrationService.RegisterUser(login, password, confirmPassword);
        }
    }
}
