
namespace PhoneBook
{
    public class Rehber
    {
        private string firstName;
        private string lastName;
        private string phoneNumber;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string PhoneNumber { get => phoneNumber; set => phoneNumber = value; }

          public Rehber(string firstname, string lastname, string phonenumber)
        {
            this.firstName = firstname;
            this.lastName = lastname;
            this.phoneNumber = phonenumber;
        }

        public Rehber(){}

        
    }
}
