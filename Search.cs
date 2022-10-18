
namespace PhoneBook
{
    public class Search : Database
    {
        public static void SearchAction()
        {
            Console.WriteLine("Arama yapmak istediğiniz tipi seçiniz:");
            Console.WriteLine("*****************************************");
            Console.WriteLine("İsim veya soy isime göre arama yapmak için: (1)");
            Console.WriteLine("Numaraya göre arama yapmak için: (2)");
            int input = Convert.ToInt32(Console.ReadLine());

            if (input == 1)
            {
                Console.WriteLine("Lütfen isim  veya soyisim giriniz:");
                string input1 = Console.ReadLine();
                foreach (var item in _phoneList)
                {
                    if (input1 == item.FirstName || input1 == item.LastName)
                    {
                        Console.WriteLine("İsim            : " + item.FirstName);
                        Console.WriteLine("Soyisim         : " + item.LastName);
                        Console.WriteLine("Telefon Numarası: " + item.PhoneNumber);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }
            }
            else
            {
                Console.WriteLine("Lütfen numarayı giriniz:");
                string input2 = Console.ReadLine();
                foreach (var item in _phoneList)
                {
                    if (input2 == item.PhoneNumber)
                    {
                        Console.WriteLine("İsim            : " + item.FirstName);
                        Console.WriteLine("Soyisim         : " + item.LastName);
                        Console.WriteLine("Telefon Numarası: " + item.PhoneNumber);
                        Console.WriteLine("-");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Aradığınız kişi rehberde kayıtlı değil.");
                        break;
                    }
                }
            }


        }
    }
}