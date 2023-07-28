using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercises13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // *** Kullanici adi ve sifre kontrolü yapılarak bir sistemde login olunabilme ***

            Login();

            Console.Read();
        }

        static string EkraniOku()
        {
            string ekranaYazilanDeger = Console.ReadLine();
            return ekranaYazilanDeger;
        }

        static void EkranaYaz(string yazilacakDeger)
        {
            Console.WriteLine(yazilacakDeger);
        }

        static bool LoginInformation()
        {
            string kullaniciAdi = "IstanbulBilisim";
            string sifre = "123_abc";

            EkranaYaz("Kullanici adiniz : ");
            string userName = EkraniOku();

            EkranaYaz("Sifreniz :");
            string password = EkraniOku();

            if (userName == kullaniciAdi && password == sifre)
            {
                return true;
            }
            return false;
        }

        static void Login()
        {
            bool sonuc = LoginInformation();

            if (sonuc)
            {
                Console.WriteLine("Giris basarili");
            }
            else
            {
                Console.WriteLine("Giris hatalı");
            }
        }
    }
}
