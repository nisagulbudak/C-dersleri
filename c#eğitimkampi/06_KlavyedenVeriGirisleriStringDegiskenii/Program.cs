using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06_KlavyedenVeriGirisleriStringDegiskenii
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Klavyeden Veri Girişleri 
            //şu ana kadar kod ekranı üzerinden veri girişi yaptık şimdi klavyeden veri girişi yapmayı öğreneceğiz

            #region String Değişkenler İçin Klavyeden Veri Girişleri

            //şimdi mesela bir hava yolu firması için yolcuların bilgilerini alacağımız biz örnek yapalım

            Console.WriteLine("***** Nisa Hava Yolları Yolcu Bilgisi *****");
            Console.WriteLine();

            // öncelikle stringle bize yolcu bilgileri lazım

            string passengerName, passengerSurname, passengerDistrict, passengerCity, passengerAge, passengerIdentityNumber;

            //controle+f ile dökümandaki bir kelimenin kullanıldığı tüm yerleri bularak onu replace ile istediğimiz kelimeye dönüştürebiliyoruz.

            Console.Write("Yolcu Adı : ");
            passengerName = Console.ReadLine();

            // ReadLine(); kodu dışarıdan yani terminal veya oluşturulan uygulamadan alınan veriyi örnek burda yolcu adı olarak tanımladık karşıdan dışarıdan girilen yolcu adını passengerName olarak tanımlayıp yazdırmasını sağlaycak.ReadLine kodunun işlevi dışarıdan veri girişini alıp yazdırıyor olması.
            // Bunu yaparken ise WriteLine değil Write kodunu kullanmamızın sebebi ise almak istediğimiz sonucun şu şekilde olması " Yolcu Adı : Bla bla bla " şeklinde olması yani sonucu yolcu adının yanına yazdırmak istiyor olmamız

            Console.Write("Yolcu Soyadı :");
            passengerSurname = Console.ReadLine();
            Console.Write("İlçe Bilgisi : ");
            passengerDistrict = Console.ReadLine();
            Console.Write("Şehir Bilgisi : ");
            passengerCity = Console.ReadLine();
            Console.Write("Yolcu Yaş : ");
            passengerAge = Console.ReadLine();
            Console.Write("Yolcu TC Kimlik No : ");
            passengerIdentityNumber = Console.ReadLine();

            Console.WriteLine();
            Console.WriteLine("------------------------------");
            // yolcu adı ve soyadını bitişik yazılmasını istemiyorsan eğer araya boşluk bırakmayı unutma 
            Console.WriteLine("Yolcu TC Kimlik No :" + passengerIdentityNumber + "-" + "Ad Soyad :" + passengerName + " " + passengerSurname + " " + "Yaş :" + passengerAge + " " + "Adres Bilgisi :" + passengerCity + "/" + passengerDistrict);




            #endregion
            Console.Read();
        }
    }
}
