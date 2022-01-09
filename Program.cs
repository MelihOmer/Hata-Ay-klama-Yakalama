using System;

namespace Hata_Yonetimi
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
               Console.WriteLine("Bir Sayı Giriniz");
            int sayi = Convert.ToInt32(Console.ReadLine());
            System.Console.WriteLine("Girilen Sayı : "+ sayi);  
            }
            catch(Exception ex)
            {
                System.Console.WriteLine("Alınan Hata : "+ ex.Message.ToString());
            }
            finally
            {
                System.Console.WriteLine("İşlem Tamamlandı.");
            }
            try
            {
                 //int a = int.Parse(null);
                 //int a  = int.Parse("test");
                 int a  = int.Parse("-20000000000");
            }
            catch (FormatException ex)
            {
                System.Console.WriteLine("Veri Taipi Uygun Değildir.");
                System.Console.WriteLine(ex);
            }
            catch(OverflowException ex){
               System.Console.WriteLine("Çok Küçük Veya Çok Büyük Bir Değer Girdiniz."); 
                System.Console.WriteLine(ex);
            }
            finally
            {
                System.Console.WriteLine("İşlem Başarı İle Tamamlandı.");
            }
        }
    }
}
