
namespace PhoneBook
{
    public class Save:Rehber
    {
        public static void SaveAction()
        {
            Console.WriteLine("Lütfen İsim Giriniz    :");
            string name = Console.ReadLine();
            Console.WriteLine("Lütfen Soyisim Giriniz :");
            string lastname = Console.ReadLine();
            Console.WriteLine("Lütfen Numara Giriniz  :");
            string number = Console.ReadLine();

            Rehber person = new Rehber();
            person.FirstName = name;
            person.LastName= lastname;
            person.PhoneNumber = number;

            Database._phoneList.Add(person);

        }
    }
}
