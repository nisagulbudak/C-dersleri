using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_DoubleDegiskenTuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Double Değişken Türü
            //double değiken türü ondalıklı sayılar için kullanılan değişken türüdür.
            //tam sayılar bir süre sonra yeterli olmamaya başladığında bize ondalıklı sayılar gerekiyor örneğin geçtiğimiz türler için de kullandığımız bir restorant sahibiyiz diyelim müşteri ödeme yaparken ödeme tutarınından farklı bir ödeme yaptı veya fiyatlar ondalıklı belirlendi 299.90 günümüzde bulunan fiyatlar şeklinde belirlediğimzde double veri türünü kullanmamız gerekecek.

            //double number;

            //number = 4.85;

            //Console.WriteLine(number);

            //kod tarafında "nokta" olarak girdiğmiz ayrıma veya basamak belirme sembolünü konsol ekranında "virgül" olarak görüyoruz.

            //şimdi bir tane meyve sebze ekranı yapalım bunların da gramajları olsun ve bu gramajları da fiyata göre otomatik olarak çarptıralım

            Console.WriteLine("***** Fiyat Listesi *****");
            Console.WriteLine();
            double applePrice, strawberryPrice, orangePrice, bananaPrice, patatoPrice, tomatoPrice;

            applePrice = 40.85;
            strawberryPrice = 85.95;
            orangePrice = 45.75;
            bananaPrice = 86.88;
            patatoPrice = 12.55;
            tomatoPrice = 50.99;


            Console.WriteLine("-----Elma Birim Fiyatı : " + applePrice + " TL");
            Console.WriteLine("-----Çilek Birim Fiyatı : " + strawberryPrice + " TL");
            Console.WriteLine("-----Portakal Birim Fiyatı : " + orangePrice + " TL");
            Console.WriteLine("-----Muz Birim Fiyatı : " + bananaPrice + " TL");
            Console.WriteLine("-----Patates Birim Fiyatı : " + patatoPrice + " TL");
            Console.WriteLine("-----Domates Birim Fiyatı : " + tomatoPrice + " TL");

            //şimdi bunlardan almak istediğmiz değere göre gramaj bilgisi tanımlayacağız

            double appleGram, strawberryGram, orangeGram, bananaGram, patatoGram, tomatoGram;
            appleGram = 0.525;
            strawberryGram = 0.646;
            orangeGram = 1.450;
            bananaGram = 0.365;
            patatoGram = 1.875;
            tomatoGram = 0.785;


            double appleTotalPrice = applePrice * appleGram;
            double strawberryTotalPrice = strawberryPrice * strawberryGram;
            double orangeTotalPrice = orangePrice * orangeGram;
            double bananaTotalPrice = bananaPrice * bananaGram;
            double patatoTotalPrice = patatoPrice * patatoGram;
            double tomatoTotalPrice = tomatoPrice * tomatoGram;

            Console.WriteLine();
            Console.WriteLine("**Alınan Ürün :Elma -" + " Birim Fiyatı :" + applePrice + " Gramaj :" + appleGram + " *Toplam Tutar :" + appleTotalPrice + "TL");
            Console.WriteLine("**Alınan Ürün :Çilek -" + " Birim Fiyatı :" + strawberryPrice + " Gramaj :" + strawberryGram + " *Toplam Tutar :" + strawberryTotalPrice + "TL");
            Console.WriteLine("**Alınan Ürün :Portakal -" + " Birim Fiyatı :" + orangePrice + " Gramaj :" + orangeGram + " *Toplam Tutar :" + orangeTotalPrice + "TL");
            Console.WriteLine("**Alınan Ürün :Muz -" + " Birim Fiyatı :" + bananaPrice + " Gramaj :" + bananaGram + " *Toplam Tutar :" + bananaTotalPrice + "TL");
            Console.WriteLine("**Alınan Ürün :Patates -" + " Birim Fiyatı :" + patatoPrice + " Gramaj :" + patatoGram + " *Toplam Tutar :" + patatoTotalPrice + "TL");
            Console.WriteLine("**Alınan Ürün :Domates -" + " Birim Fiyatı :" + tomatoPrice + " Gramaj :" + tomatoGram + " *Toplam Tutar :" + tomatoTotalPrice + "TL");

            Console.WriteLine() ;
            Console.WriteLine();

            double totalPrice = appleTotalPrice + strawberryTotalPrice + orangeTotalPrice + bananaTotalPrice + patatoTotalPrice + tomatoTotalPrice;

            Console.WriteLine("Alışveriş Toplam Tutar : " + totalPrice + "TL");

            Console.Read();
        }
    }
}
