using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09_KlavyedenKarakterGirisleriCharDegiskeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Karakter Girişleri

            #region Char Değişkeni Klavyeden Karakter Girişleri
            //Char değişkeni yalnızca tek karakter belirtmek için kullanılır yani terminalden yazdırmak istiyor isek terminalde yazacağımız tek bir karakter hata vermeden yazılacaktır birden fazla karakter girmeye ve bunu yazdırmaya çalışırsak hata vercek ve uygulama çalışmayacaktır.
            //şimdi yapacağımız örnekte char cinsiyet belirtmek için kullanılsın.

            char gender;
            Console.Write("Lütfen cinsiyetinizi seçiniz :");
            gender = char.Parse(Console.ReadLine());

            Console.WriteLine("Seçtiğiniz cinsiyet :" + gender);






            #endregion

            Console.Read();
        }
    }
}
