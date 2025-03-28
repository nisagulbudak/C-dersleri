using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_IntDegiskenTuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Int Değişken Türü
            //int değişkeni tam sayı türündeki değişkenlerdir.Java,pyhton,C# veya C'de d bu şekilde kullanılır

            //int 
            //int number = 24;
            //Console.WriteLine(number);

            //şimdi müşterinin yediği içtiği ve hesabı ödemesi gerektiği bir örnek yapalım

            int hamburgerPrice = 300;
            //değişkeni yazarken yine camel case e göre ilk kelimenin baş harfi büyük sonrakilerin küçük olacak şekilde yazdık!!
            int cokePrice = 35;
            int waterPrice = 10;
            int friesPrice = 50;
            int pizzaPrice = 250;
            int lemonadePrice = 30;

            Console.WriteLine("****Restorant Menü Fiyatı****");
            Console.WriteLine();
            Console.WriteLine("-----Hamburger Fiyatı : " + hamburgerPrice + "TL");
            Console.WriteLine("-----Pizza Fiyatı : " + pizzaPrice + "TL");
            Console.WriteLine("-----Kızartma Fiyatı : " + friesPrice + "TL");
            Console.WriteLine("-----Kola Fiyatı : " + cokePrice + "TL");
            Console.WriteLine("-----Limonata Fiyatı : " + lemonadePrice + "TL");
            Console.WriteLine("-----Su Fiyatı : " + waterPrice + "TL");
            Console.WriteLine();
            Console.WriteLine("****Restorant Menü Fiyatı****");



            Console.WriteLine();

            //müşteri geldi belirli sayıda ürün aldı bunun hesabını yapacağız

            int hamburgerCount;
            int cokeCount;
            int waterCount;
            int friesCount;
            int pizzaCount;
            int lemonadeCount;

            int totalHamburgerPrice = 0;
            int totalCokePrice = 0;
            int totalWaterPrice = 0;
            int totalFriesPrice = 0;
            int totalPizzaPrice = 0;
            int totalLemonadePrice = 0;

            hamburgerCount = 3;
            cokeCount = 3;
            waterCount = 2;
            friesCount = 3;
            pizzaCount = 0;
            lemonadeCount = 0;

            totalHamburgerPrice = hamburgerPrice * hamburgerCount;
            totalCokePrice = cokePrice * cokeCount;
            totalWaterPrice = waterPrice * waterCount;
            totalFriesPrice = friesPrice * friesCount; 
            totalPizzaPrice = pizzaPrice * pizzaCount;
            totalLemonadePrice = lemonadePrice * lemonadeCount;


            Console.WriteLine("-------------------------------------");
            Console.WriteLine("Hamburger Tutarı : " + totalHamburgerPrice + "TL");
            Console.WriteLine("Kola Tutarı : " + totalCokePrice + "TL");
            Console.WriteLine("Su Tutarı : " + totalWaterPrice + "TL");
            Console.WriteLine("Kızartma Tutarı : " + totalFriesPrice + "TL");
            Console.WriteLine("Pizza Tutarı : " + totalPizzaPrice + "TL");
            Console.WriteLine("Limonata Tutarı : " + totalLemonadePrice + "TL");

            Console.WriteLine();

            int totalPrice = totalHamburgerPrice + totalCokePrice + totalWaterPrice + totalFriesPrice + totalPizzaPrice + totalLemonadePrice;
            Console.WriteLine("Toplam Ödenecek Tutar : " + totalPrice + "TL");





            Console.Read();
        }
    }
}
