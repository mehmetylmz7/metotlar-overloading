using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metotlar_overloading
{
    class Program
    {
        static void Main(string[] args)
        {
            // out paremetreler

            string sayi = "999";

            bool sonuc = int.TryParse(sayi, out int  outSayi);
            if (sonuc)
            {
                Console.WriteLine("basarılı");
                Console.WriteLine(outSayi);
            }
            else
            {
                Console.WriteLine("basarısız");
            }

            Metotlar instance = new Metotlar();
            instance.Topla(4, 5, out int toplamSonucu);
            Console.WriteLine(toplamSonucu);


            //metot aşırı yuklenmesi - overloading

            int ifade = 999;
            instance.ekranaYazdir(Convert.ToString(ifade));
            instance.ekranaYazdir(ifade);
            instance.ekranaYazdir("zikriye", "urkmez");
            Console.ReadLine();
        }
    }


    class Metotlar
    {
        public void Topla(int a, int b, out int toplam)
        {
            toplam = a + b;
        } 

        public void ekranaYazdir(string veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranaYazdir(int veri)
        {
            Console.WriteLine(veri);
        }

        public void ekranaYazdir(string veri1, string veri2)
        {
            Console.WriteLine(veri1+veri2);
        }
    }




}
