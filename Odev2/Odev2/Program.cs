using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev2

//  ÖDEV 2:
// Program Çalışandan Kullanıcı Adı ve Şifre isteyecek.
// Eğer Kullanıcı Adı ve Şifre doğru ise;
// Yaşını ve Prim gün sayısını isteyecek
// Yanlış ise;
// Hatalı Giriş Yaptınız yazacak.
// Eğer yaş 40 ve üzerinde, primde 5000 ve üzerinde ise
// Emeklilik Hakkı Kazandınız yazacak.
// Çalışanın maaş tutarı ve Çalışma yılınını isteyecek
// Eğer çalışma yılı 20 ve üzerinde ise;
// Maas* yil ‘ın %77,5i kadar İkramiye hesaplayacak
// Çalışma yılı 20 ve üzeri değilse;
// Maas* yil’ın %50,5 i kadar ikramiye hesaplayacak.
// Yaş 40 ve üzeri, prim günü de 5000 ve üzeri değilse
// Emeklilik için kaç gün prim kaldığını hesaplasın
// Prim günleri için borç günü ödemek ister misiniz diye sorsun
// Cevap evet olursa 50000 ₺ borcu 5 taksit olarak ödeyebilirsiniz yazsın.
{
    internal class Program
    {
        public static float ikramiye(int calYili, int emekliMaasi)
        {
            if (calYili >= 20)
            {
                float ikramiye = (calYili * emekliMaasi) * (77.5f / 100);
                return ikramiye;
            }
            else
            {
                float ikramiye = (calYili * emekliMaasi) * (50.5f / 100);
                return ikramiye;
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.UTF8;

        git:

            Console.WriteLine("Kullanıcı Adınızı Giriniz: ");
            string user = Console.ReadLine();
            Console.WriteLine("Şifre Giriniz: ");
            string sifre = Console.ReadLine();

            if (user == "ERMAN" && sifre == "123")
            {
                Console.WriteLine("SAYIN " + user + " HOŞGELDİNİZ");
            }
            else
            {
                Console.WriteLine("Kullanıcı Adı veya Şifre Hatalı!");
                Console.WriteLine("Tekrar Denemek İster misiniz? E/H");
                char deneme = Convert.ToChar(Console.ReadLine());
                if (deneme == 'e' || deneme == 'E')
                {
                    Console.Clear();
                    goto git;
                }
                else
                {
                    return;
                }
            }

            Console.Write("Lütfen Yaşınızı Giriniz: ");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Prim Gün Sayınızı Giriniz: ");
            int pgs = Convert.ToInt32(Console.ReadLine());

            if (age < 40 && pgs < 5000)

            //Hem prim gün sayısı eksik, hem de yaş 40'ın altındaysa, borç ödense bile emekli olunamayacağı için , "Prim günleri için borç günü ödemek ister misiniz?" bu adımda yazdırılmamıştır. 

            {
                int kalanYil = 40 - age;
                int kalanGun = 5000 - pgs;
                Console.WriteLine("Yaş ve Prim gün sayısı kriterlerini karşılamadığınız için Emekli OLAMAZSINIZ!");
                Console.WriteLine("Emekli olabilmeniz için {0} yıl beklemeniz ve {1} gün daha prim ödemeniz gerekmektedir.", kalanYil, kalanGun);
                Console.ReadLine();
                return;
            }
            else if (pgs < 5000)
            {
                Console.WriteLine("Prim gün sayınız 5000 günden az olduğu için Emekli OLAMAZSINIZ!");
                int kalanGun = 5000 - pgs;
                Console.WriteLine("Emekli Olmanız için " + kalanGun + " gün daha prim ödemeniz gerekmektedir");
                Console.WriteLine("Prim günleri için borç günü ödemek ister misiniz? E/H");
                char borcOdeme = Convert.ToChar(Console.ReadLine());
                if (borcOdeme == 'E' || borcOdeme == 'e')
                {
                    Console.WriteLine("50000 TL borcu 5 taksit olarak ödeyebilirsiniz");
                    Console.ReadLine();
                }
                return;
            }
            else if (age < 40)
            {
                Console.WriteLine("Yaşınız 40'tan küçük olduğu için Emekli OLAMAZSINIZ!");
                int kalanYil = 40 - age;
                Console.WriteLine("Emekli Olmanız için " + kalanYil + " yıl daha beklemeniz gerekmektedir");
                Console.ReadLine();
                return;
            }
            else
            {
                Console.WriteLine("!!!TEBRİKLER!!! Emekliliğe Hak Kazandınız");
            }

            Console.Write("Çalışma Yılınızı Giriniz: ");
            int calYili = Convert.ToInt32(Console.ReadLine());
            Console.Write("Lütfen Emekli Maaşınızı Giriniz: ");
            int emekliMaas = Convert.ToInt32(Console.ReadLine());

            float ikramiyeHesap = ikramiye(calYili, emekliMaas);
            Console.WriteLine("Hesaplanan İkramiye: " + ikramiyeHesap.ToString("N2", System.Globalization.CultureInfo.InvariantCulture) + " TL \nGüzel günlerde harcayınız :) ");
            Console.ReadLine();
        }
    }
}
