using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CanlıHavaDurumu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen Bir Şehir Seçiniz= ");
            Console.WriteLine("Eskişehir,Ankara,İstanbul");
            string sehirler = Console.ReadLine();

            if (sehirler == "Eskişehir")
            {
                string apikey = "e4b7070abab1899610fd58316c8d4c53";
                string link = "https://api.openweathermap.org/data/2.5/weather?q=Eskişehir&lang=tr&units=metric&mode=xml&appid=" + apikey;

                XDocument havadurumu = XDocument.Load(link);

                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                Console.WriteLine("Eskişehir için sıcaklık = " + havasicaklik + " Hava Durumu = " + durum);
            }
            if (sehirler == "Ankara")
            {
                string apikey = "e4b7070abab1899610fd58316c8d4c53";
                string link = "https://api.openweathermap.org/data/2.5/weather?q=Ankara&lang=tr&units=metric&mode=xml&appid=" + apikey;

                XDocument havadurumu = XDocument.Load(link);

                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                Console.WriteLine("Ankara için sıcaklık = " + havasicaklik + " Hava Durumu = " + durum);
            }
            if(sehirler == "İstanbul")
            {
                string apikey = "e4b7070abab1899610fd58316c8d4c53";
                string link = "https://api.openweathermap.org/data/2.5/weather?q=İstanbul&lang=tr&units=metric&mode=xml&appid=" + apikey;

                XDocument havadurumu = XDocument.Load(link);

                string havasicaklik = havadurumu.Descendants("temperature").ElementAt(0).Attribute("value").Value;
                string durum = havadurumu.Descendants("weather").ElementAt(0).Attribute("value").Value;
                Console.WriteLine("İstanbul için sıcaklık = " + havasicaklik + " Hava Durumu = " + durum);
            }
            else
            {
                Console.WriteLine("Hatalı Giriş Yaptınız");
            }


        }
    }
}
