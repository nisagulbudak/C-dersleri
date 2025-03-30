using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08_KlavyedenOndalikliSayiGirisleriVeDonusumleriDoubleDegiskeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Ondalıklı Sayı Girişleri Ve Dönüşümleri

            #region Double Değişkeni İçin Klavyeden Ondalıklı Sayı Girişleri Ve Dönüşümleri

            //mesela öğrencilerin sınav notunu double ile girelim

            double exam1, exam2, exam3, result;

            Console.Write("Lütfen 1. sınav notunu giriniz :");
            exam1 = double. Parse(Console.ReadLine());

            //parse dönüştürme metodu her zaman içine değer gireceğimiz ve dışarıya değeri yazdıracak olan komutun dışına yazılır ki onu kapsasın burda değeri dışarıdan yazmak ve onu yazdırması için kullandığımız komut Console.ReadLine() bu komut gireceğimiz değeri ekrana yazdırırken yazdırmadan önce o komutun string veri türünden dönüştürülmesi için dışına dönüştürmek için kullanacağımı metodu yazarız burada double veri tipini kullandık ve girilecek bu türden verinin stringten double a dönüştürülerek okunmasını ve yazdırılmasını istiyoruz bu sebeple kod satırı şu şekilde yazıldı: "double.Parse(Console.ReadLine());

            Console.Write("Lütefen 2. sınav notunu giriniz :");
            exam2 = double.Parse(Console.ReadLine());

            Console.Write("Lütfen 3. sınav notunu giriniz :");
            exam3 = double.Parse(Console.ReadLine());

            //KONSOLDA ONDALIKLI SAYILAR TANIMLANIRKEN ARASINA "NOKTA",TERMİNALDE İSE ONDALIKLI SAYILAR YAZILIRKEN ARASINA "VİRGÜL" KONUR.terminale ondalıklı gireceğimiz bu sınav bilgilerini yazarken ondalıklı sayıların arasında virgül koyarak yazacağız eğer konsoldaki gibi nokta ile ayırarak yazarsak terminal bunu basamakları ayırmak için kullanılan nokta şekilde algılar ve yazdığımız ondalıkı sayıyı bir bütün şeklinde algılayarak işlem içerisinde kullanır ve buna göre sonuç verir örneğin biz 40,52 şeklinde bir değer yazmaya çalıştık bunu konsoldaki gibi 40.54 şeklinde yazarsak terminal bunu 4054 şeklinde algılayacaktır.

            Console.WriteLine();

            result = (exam1 + exam2 + exam3) / 3;
            //resultun yani sonucun sınavların ortalaması olmasını istediğimizden ötürü 3 sınavın toplamının 3 e bölümü şeklinde tanımladık bunu 3 e bölmek için de sınav toplamlamını işlem önceliği kuralından ötürü parantez içerisinde yaparak dışına da /3 şeklinde bir ifade koyarak 3 e böldük.
            Console.Write("Sınav Ortalamanız :" + result);

            #endregion


            Console.Read();
        }
    }
}
