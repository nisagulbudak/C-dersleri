using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_KlavyedenVeriGirisleriIntDegiskeni
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Tam Sayı Girişleri Ve Dönüşümler
            //C# konsole ekranı üzerinden girilen değerleri başlangıçta string verisi olarak kabul ediyor biz buraya sayısal veya karakter, true false...vb şeklinde bir karakter gireceksek bu karakterin türünü tanımlamamız gerekiyor.
            //bu karakterin türünü de tanımlamak için dönüşümleri kullancağız 

            #region Int Değişkeni İçin Klavyeden Veri Girişi

            //şimdi örnek olarak bir e-ticaret için bir satış paneli oluşturacağız.ürünler olacak ürünlerin kaç adet alındığı girilsin daha sonra girilmiş adet sayısına göre para verelim ve karşılığını alalım.

            int shoesPrice, computerPrice, chairPrice, tvPrice;

            //şimdi bizim 4 tane değişkenimiz olacak ve buna göre değer belirleyceğiz

            shoesPrice = 500;
            computerPrice = 6000;
            chairPrice = 400;
            tvPrice = 10000;

            int shoesCount , computerCount , chairCount , tvCount ;

            Console.Write("Lütfen almış olduğunuz ayakkabı adedini giriniz :");

            //şimdi normal şartlarda aldığımız sayı adedini girip ekrana yazdırmak için shoesCount = Console.ReadLine(); kodunu gireriz fakat hata verir.
            //çünkü C# programlama dili bütün veri girişlerini başlangıçta "String" veri tipi olarak kabul eder fakat biz burda sayı değeri yani "Int" veri tipiyle bir giriş yapmaya çalışıyoruz.bize diyor ki o zaman dönüşüm uygulaman lazım.
            //Peki nasıl dönüşüm uygulayacağız? pek çok dönüşüm türü vardır biz burda şunu uygulayacağız:

            shoesCount = int.Parse(Console.ReadLine());

            //parse dönüştürmek için kullanılan bir metod diyor ki sana int'i 32 bit formatında dönüştüreceğim.
            //int'in aralıkları var 16,32,64 şeklinde bunların kendi içinde aralıkları vardır bellekte kapladıkları alandır.
            //örneğin alınabilecek ürün maks 1000 dir ona göre veri girişi yaparız veya 100 dür ona göre bir dönüşüm metodu kullanılır (bunları ileride daha detaylı yazacağım)

            Console.Write("Lütfen almış olduğunuz bilgisayar adedini giriniz :");
            computerCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen almış olduğunuz koltuk adedini giriniz :");
            chairCount = int.Parse(Console.ReadLine());

            Console.Write("Lütfen almış olduğunuz TV adedini giriniz :");
            tvCount = int.Parse(Console.ReadLine());

            //şimdi bir total fiyat belileyeceğiz bunu artık tek satırda yapabiliriz şu şekilde:

            int totalPrice = (shoesPrice * shoesCount) + (computerPrice * computerCount) + (chairPrice * chairCount) + (tvPrice * tvCount);

            //eklediğim parantezler visual studio22 önerisi üzerine daha açık ve anlaşılabilir görünmesi adına eklendi.eklemek zorunda değilsin eklemeden de aynı şekilde yazabilirsin herhangi bir hata vermez.

            Console.WriteLine();
            Console.WriteLine("Toplam Ödenecek Tutar :" + totalPrice + "TL");










            #endregion

            Console.Read();
        }
    }
}
