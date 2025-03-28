using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_StringDegiskenTuru
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //DEĞİŞKEN TÜRLERİ

            #region String

            //string
            //Değişken_türü değişken_adı;
            //alfabetik türde verileri tutabilmek için kullanılan değişken türü
            //string name;
            //name = "Nisa";
            //Console.WriteLine(name);
            //çift tırnak içerisinde yazılmaz name değerinin karşılığını istediğimiz için direkt yazılır.


            string customerName;

            //string değişkeni adlandırılırken ilk harf küçük sonraki harfler büyük yazılır.Buna Camel Case nedir
            //değişkenler adlandırılırken araya boşluk konmaz.
            //değişken adlandırılırken yalın ve kodlar rahat okunacak formatta yazılmalı

            string customerSurname;
            string customerPhone;
            string customerEmail, district, city;

            //birden fazla değişken tanımlanabiliyor, 30. satırda aynı string komutuna birden fazla değişken tanımladık.

            customerName = "Gökberk";
            customerSurname = "Anıt";
            customerPhone = "+90 500 400 30 40";
            customerEmail = "deneme@gmail.com";
            district = "Torbalı";
            city = "İzmir";

            Console.WriteLine("****Rezervasyon Kartı****");
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            //müşteri ; dedik artı araya boşluk bırakmak içi iki tane "" daha ekledik bu ikisinin arası boşluk oldu
            Console.WriteLine("İletişim : " + customerPhone);
            Console.WriteLine("Email Adresi : " + customerEmail);
            Console.WriteLine("Adres : " + district + "/" + city);
            //araya koyduğumuz "/" işareti şehir ve ilçe arasında / olsun diye konuldu ve ("")'lar (+)'la birleştirildi.
            Console.WriteLine("---------------------------------------------------------");

            //şimdi bir örnek daha yapacağız

            Console.WriteLine();

            customerName = "Nisa Gül";

            //tekrardan değişken tanımlıyoruz bu değişkenler sırasıyla komut satırına yazılacak çünkü kod sistemindeki hiyerarşi satır sayılarına göre okuma sırası belirlenecek şekildedir ilk önce yazılan satır ilk okunur.

            customerSurname = "Budak";
            customerPhone = "+90 500 400 40 50";
            customerEmail = "deneme1@gmail.com";
            district = "Odunpazarı";
            city = "Eskişehir";

            Console.WriteLine("---------------------------------------------------------");
            Console.WriteLine("Müşteri : " + customerName + " " + customerSurname);
            Console.WriteLine("İletişim : " + customerPhone);
            Console.WriteLine("Email Adresi : " + customerEmail);
            Console.WriteLine("Adres : " + district + "/" + city);
            Console.WriteLine("---------------------------------------------------------");


            #endregion

            Console.Read();

        }
    }
}



