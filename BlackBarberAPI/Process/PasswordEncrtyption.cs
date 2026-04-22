namespace BlackBarberAPI.Process
{
    public class PasswordEncrtyption
    {
        private readonly IConfiguration _configuration;

        public PasswordEncrtyption(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public static string Encrypt(string password)
        {
            return password;
        }

        public static string Decrypt(string hash)
        {
            return hash;
        }
    }
}
