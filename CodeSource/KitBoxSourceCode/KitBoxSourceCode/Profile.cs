using System;
namespace KitBoxSourceCode
{
    public class Profile
    {
        private const string format = "LastName: {0}, FirstName: {1}";
        private readonly string FirstName;
        private readonly string LastName;
        private readonly string Email;
        private readonly string Adresse;

        public string GetFirstName => FirstName;
        public string GetLastName => LastName;
        public string GetEmail => Email;
        public string GetAdresse => Adresse;

        public Profile(string LN, string FN, string mail = null, string adresse = null)
        {
            FirstName = FN;
            LastName = LN;
            Email = mail;
            Adresse = adresse;
        }

        public void ShowClientInfo()
        {
            Console.WriteLine(format, arg0: LastName, arg1: FirstName);
            if (Email != null)
            {
                Console.WriteLine("Email: {0}", arg0: Email);
            }

            if (Adresse != null)
            {
                Console.WriteLine("Adresse: {0}", arg0: Adresse);
            }

        }
    }
}
