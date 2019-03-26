using System;
namespace KitBoxSourceCode
{
    public class Profile
    {
        private const string format = "LastName: {0}, FirstName: {1}";
        private readonly string firstName;
        private readonly string lastName;
        private readonly string email;
        private readonly string adresse;

        public string GetFirstName => firstName;
        public string GetLastName => lastName;
        public string GetEmail => email;
        public string GetAdresse => adresse;

        public Profile(string LN, string FN, string mail = null, string ads = null)
        {
            firstName = FN;
            lastName = LN;
            email = mail;
            adresse = ads;
        }

        public void ShowClientInfo()
        {
            Console.WriteLine(format, arg0: lastName, arg1: firstName);
            if (email != null)
            {
                Console.WriteLine("Email: {0}", arg0: email);
            }

            if (adresse != null)
            {
                Console.WriteLine("Adresse: {0}", arg0: adresse);
            }

        }
    }
}
