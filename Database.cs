
namespace PhoneBook
{
    public class Database
    {
        public static List<Rehber> _phoneList;

        static Database()
        {
            _phoneList = new List<Rehber>()
            {
                new Rehber {FirstName = "Acil",   LastName = "Servis",     PhoneNumber = "112"},
                new Rehber {FirstName = "Alo",    LastName = "Yangın", PhoneNumber = "110"},
                new Rehber {FirstName = "Polis",    LastName = "İmdat",   PhoneNumber = "155"},
                new Rehber {FirstName = "Jandarma",  LastName = "İmdat",    PhoneNumber = "156"},
                new Rehber {FirstName = "Sahil ",  LastName = "Güvenlik", PhoneNumber = "158"},
            };
        }

        public static List<Rehber> telefonRehberim
        {
            get { return _phoneList; }
        }

        public static void RehberYazdır()
        {
            foreach (var item in telefonRehberim)
            {
                Console.WriteLine(item.FirstName + " " + item.LastName + " " + item.PhoneNumber);
            }
        }

        
    }

}
