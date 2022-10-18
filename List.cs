
namespace PhoneBook
{
    public class List : Database
    {
        public static void ListAction()
        {
                Console.WriteLine("Telefon Rehberi");
                Console.WriteLine("***********************************");
                
                foreach (var item in _phoneList)
                {
                    Console.WriteLine("İsim            : " + item.FirstName);
                    Console.WriteLine("Soyisim         : " + item.LastName);
                    Console.WriteLine("Telefon Numarası: " + item.PhoneNumber);
                    Console.WriteLine("-");
                }
        }
    }

}