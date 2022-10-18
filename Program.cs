
namespace PhoneBook
{
    class Program
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Telefon Rehberi Uygulamasına Hoşgeldiniz!");

            string continueProgram = "";
            while (continueProgram != "exit")
            {
                 Console.WriteLine("Lütfen yapmak istediğiniz işlemi seçiniz :) ");
            Console.WriteLine("*******************************************");
            Console.WriteLine("(1) Yeni Numara Kaydetmek");
            Console.WriteLine("(2) Varolan Numarayı Silmek");
            Console.WriteLine("(3) Varolan Numarayı Güncelleme");
            Console.WriteLine("(4) Rehberi Listelemek");
            Console.WriteLine("(5) Rehberde Arama Yapmak");

            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":                 
                    Save.SaveAction();
                    break;

                case "2":                   
                    Remove.RemoveAction();
                    break;

                case "3":                   
                    Update.UpdateAction();
                    break;

                case "4":
                    List.ListAction();
                    break;

                case "5":
                    Search.SearchAction();
                    break;

            }

            Console.ReadLine();
            }

           
        }
    }

}