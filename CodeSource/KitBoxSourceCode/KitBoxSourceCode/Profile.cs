using System;
namespace KitBoxSourceCode
{
    public class Profile
    {
        private string FirstName;
        private string LastName;
        private string Email;
        private string Adresse;

        public Profile(string LN, string FN, string mail = null, string adresse = null)
        {
            FirstName = FN;
            LastName = LN;
            Email = mail;
            Adresse = adresse;
        }

        public string GetEmail => Email;

        public string GetLastName => LastName;

        public string GetFirstName => FirstName;

        public string GetAdresse => Adresse;
    }
}
