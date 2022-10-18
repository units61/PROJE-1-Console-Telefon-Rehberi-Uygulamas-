
namespace PhoneBook
{
    class Update : Database
    {
        public static void UpdateAction()
        {
            Console.WriteLine("Lütfen numarasını güncellemek istediğiniz kişinin adını ya da soyadını giriniz:");
            string input = Console.ReadLine();

            foreach(var item in _phoneList.ToList())
            {
                if(input == item.FirstName || input == item.LastName)
                {
                    Console.WriteLine("Lütfen yeni numarayı giriniz:");
                    string input1 = Console.ReadLine();
                    item.PhoneNumber = input1;
                    break;
                }else{
                    Console.WriteLine("Aradığınız kriterlere uygun veri rehberde bulunamadı. Lütfen seçim yapınız: ");
                    Console.WriteLine("* Güncellemeyi sonlandırmak için (1)");
                    Console.WriteLine("* Yeniden denemek için (2)");
                    int input2 = Convert.ToInt32(Console.ReadLine());

                     if(input2 == 1)
                    {
                        Console.WriteLine("İşlem sonlandırıldı.");
                        break;
                    }
                    else
                    {
                        Update.UpdateAction();
                    }
                        break;
                }
            }
        }
    }
}
