namespace PhoneBook
{
    public class Remove : Database
    {
      public static void RemoveAction()
      {
        Console.WriteLine("Lütfen numarasını silmek istediğiniz kişinin adını ya da soyadını giriniz:");
        string input = Console.ReadLine();

        foreach(var item in _phoneList.ToList())
        {
            if(input == item.FirstName || input == item.LastName)
            {
                Console.WriteLine(item.FirstName+" "+item.LastName+ " isimli kişi rehberden silinmek üzere, onaylıyor musunuz ?(y/n)");
                string input1 = Console.ReadLine();
                if(input1 == "y")
                {
                    _phoneList.Remove(item);
                }else{
                    Console.WriteLine("Çıkış yapılıyor");
                    break;
                }
                break;
            }
            else{
                Console.WriteLine("Aradığınız krtiterlere uygun veri rehberde bulunamadı. Lütfen bir seçim yapınız.");
                Console.WriteLine("* Silmeyi sonlandırmak için : (1)");
                Console.WriteLine("* Yeniden denemek için      : (2)");
                int input2 = Convert.ToInt32(Console.ReadLine());

                if(input2 == 1)
                {
                    Console.WriteLine("İşlem Sonlandırıldı");
                    break;
                }else{
                    Remove.RemoveAction();
                }
                break;
            }
        }
      }
    }
}
